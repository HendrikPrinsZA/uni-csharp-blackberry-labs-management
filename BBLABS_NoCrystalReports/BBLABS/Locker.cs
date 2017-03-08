using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BBLABS
{
    class Locker : Record
    {
        public User ukeyOne, ukeyTwo;
        int iStatus;
        public DateTime dFrom, dTo;
        List<Device> dStoredDevice;
        string sLockerName;

        public Locker()
        {
            dStoredDevice = new List<Device>();
        }

        public Locker(int ID)
            : base(ID)
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM locker WHERE LOCKER_ID =" + ID, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "locker");
            if (ds.Tables["locker"].Rows.Count > 0)
            {
                int iKey1 = -1, iKey2 = -1;
                if (Int32.TryParse((ds.Tables["locker"].Rows[0]["KEY_ONE_USER"]).ToString(), out iKey1))
                {
                    ukeyOne = new User(iKey1);
                }
                if (Int32.TryParse((ds.Tables["locker"].Rows[0]["KEY_TWO_USER"]).ToString(), out iKey2))
                {
                    ukeyTwo = new User(iKey2);
                }
                if (ds.Tables["locker"].Rows[0]["DATE_FROM"].ToString().Length > 0)
                    dFrom = DateTime.Parse(ds.Tables["locker"].Rows[0]["DATE_FROM"].ToString());
                if (ds.Tables["locker"].Rows[0]["DATE_TO"].ToString().Length > 0)
                    dTo = DateTime.Parse(ds.Tables["locker"].Rows[0]["DATE_TO"].ToString());
                iStatus = (int)ds.Tables["locker"].Rows[0]["LOCKER_STATUS"];
                sLockerName = ds.Tables["locker"].Rows[0]["LOCKER_NAME"].ToString();
                dStoredDevice = new List<Device>();
                conn.Close();
                if (iStatus == 2)
                {
                    conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                    conn.Open();
                    sqlCmd = new SqlCommand("SELECT * FROM lockerItem WHERE LOCKER_ID =" + ID, conn);
                    sqlDA = new SqlDataAdapter(sqlCmd);
                    ds = new DataSet();
                    sqlDA.Fill(ds, "lockerItem");
                    if (ds.Tables["lockerItem"].Rows.Count > 0)
                    {
                        for (int i = 0; i < ds.Tables["lockerItem"].Rows.Count; i++)
                        {
                            dStoredDevice.Add(new Device((int)ds.Tables["lockerItem"].Rows[i]["DEVICE_ID"]));
                        }
                    }
                }
            } else
                conn.Close();
        }

        public void updateDevices()
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM lockerItem WHERE LOCKER_ID = " + recordID, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "locker");

            for (int i = 0; i < ds.Tables["locker"].Rows.Count; i++)
            {
                dStoredDevice.Add(new Device(ds.Tables["locker"].Rows[0]));
            }
            conn.Close();
        }

        public bool update(int AdminID, string sLockName)
        {
            sLockerName = sLockName;
            logHandle myLog = new logHandle();
            if (myLog.doQuery("UPDATE locker SET LOCKER_NAME = '" + sLockerName + "' WHERE LOCKER_ID = " + recordID))
            {
                myLog.insertChange(AdminID, "Changed locker name to: " + sLockName);
                return true;
            }
            else
                return false;
        }

        public string getName()
        {
            return sLockerName;
        }

        public void addDevice(Device d)
        {
            dStoredDevice.Add(d);
        }

        public void removeDevice(Device d)
        {
            dStoredDevice.Remove(d);
        }

        public void setValues(User keyOne, User keyTwo, int status, DateTime from, DateTime to)
        {
            ukeyOne = keyOne;
            ukeyTwo = keyTwo;
            iStatus = status;
            dFrom = from;
            dTo = to;
        }

        public bool checkout()
        {
            String sQuery = "BEGIN TRANSACTION ";
            for (int i = 0; i < dStoredDevice.Count; i++)
            {
                sQuery += "INSERT INTO lockerItem(LOCKER_ID,DEVICE_ID,LOCK_ITEM_STATUS) VALUES(" + recordID + "," + dStoredDevice[i].recordID + "," + 1 + ") ";
                sQuery += "UPDATE device SET DEVICE_STATUS = 2 WHERE DEVICE_ID = " + dStoredDevice[i].recordID + " ";
            }
            sQuery += "UPDATE locker SET KEY_ONE_USER=" + ukeyOne.recordID + ", KEY_TWO_USER=" + ukeyTwo.recordID + ", LOCKER_STATUS = 2, DATE_FROM = '" + dFrom.ToString() + "', DATE_TO='" + dTo.ToString() + "' " +
                      "WHERE LOCKER_ID=" + recordID;
            sQuery += " COMMIT";

            logHandle myLog = new logHandle();

            if (myLog.doQuery(sQuery))
                return true;
            else
                return false;
        }

        public string getKeyHolder1()
        {
            return ukeyOne.getUsername();
        }
        public string getKeyHolder2()
        {
            return ukeyTwo.getUsername();
        }

        public void assignDeviceList(ListBox lst)
        {
            lst.Items.Clear();
            for (int i = 0; i < dStoredDevice.Count; i++)
                lst.Items.Add(dStoredDevice[i]);
        }

        public DateTime getDateFrom()
        {
            return dFrom;
        }
        public DateTime getDateTo()
        {
            return dTo;
        }
    }
}
