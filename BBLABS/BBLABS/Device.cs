using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using System.Windows.Forms;

namespace BBLABS
{
    public class Device : Record
    {
        public int iCategory, iStatus, iBlobID;
        public string sIMIE, sSerial, sPin, sEmail, sPassw, sModel, sName, sTel;
        public Blob myImage;
        public Device(System.Data.DataRowView row)
            : base((int)row[0])
        {
            iCategory = (int)row[1];
            sIMIE = row[2].ToString();
            sName = row[3].ToString();
            sSerial = row[4].ToString();
            sPin = row[5].ToString();
            sTel = row[6].ToString();
            sEmail = row[7].ToString();
            sPassw = row[8].ToString();
            sModel = row[9].ToString();
            iStatus = (int)row[10];
            iBlobID = -1;
            int imgID;
            if (Int32.TryParse(row[11].ToString(), out imgID))
            {
                myImage = new Blob(imgID);
                iBlobID = imgID;
            }
            else
            {
                myImage = null;
                iBlobID = -1;
            }
        }

        public Device(System.Data.DataRow row)
            : base((int)row[0])
        {
            iCategory = (int)row[1];
            sIMIE = row[2].ToString();
            sName = row[3].ToString();
            sSerial = row[4].ToString();
            sPin = row[5].ToString();
            sTel = row[6].ToString();
            sEmail = row[7].ToString();
            sPassw = row[8].ToString();
            sModel = row[9].ToString();
            iStatus = (int)row[10];
            iBlobID = -1;
            int imgID;
            if (Int32.TryParse(row[11].ToString(), out imgID))
            {
                myImage = new Blob(imgID);
                iBlobID = imgID;
            }
            else
            {
                myImage = null;
                iBlobID = -1;
            }
        }

        public Device(int id)
            : base(id)
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM device WHERE DEVICE_ID =" + recordID, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "locker");
            if (ds.Tables["locker"].Rows.Count > 0)
            {
                System.Data.DataRow row = ds.Tables["locker"].Rows[0];
                iCategory = (int)row[1];
                sIMIE = row[2].ToString();
                sName = row[3].ToString();
                sSerial = row[4].ToString();
                sPin = row[5].ToString();
                sTel = row[6].ToString();
                sEmail = row[7].ToString();
                sPassw = row[8].ToString();
                sModel = row[9].ToString();
                iStatus = (int)row[10];
                iBlobID = -1;
                int imgID;
                if (Int32.TryParse(row[11].ToString(), out imgID))
                {
                    myImage = new Blob(imgID);
                    iBlobID = imgID;
                }
                else
                {
                    myImage = null;
                    iBlobID = -1;
                }
            }
            else
                MessageBox.Show("Something is wrond");
            conn.Close();
        }
    }
}
