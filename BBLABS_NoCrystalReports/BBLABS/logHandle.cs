using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace BBLABS
{
    class logHandle
    {

        public void check()
        {
            MessageBox.Show("IT WORKS");
        }

        public String covertDateStringToString(String sDt)
        {
            DateTime dt = Convert.ToDateTime(sDt);
            return dt.Year +"/"+dt.Month+"/"+dt.Day;
        }

        public string toSQLDate(DateTime dt)
        {
            String sDay, sMonth, sYear;

            if (dt.Day < 10)
                sDay = "0" + dt.Day.ToString();
            else
                sDay = dt.Day.ToString();

            if (dt.Month < 10)
                sMonth = "0" + dt.Month.ToString();
            else
                sMonth = dt.Month.ToString();

            sYear = dt.Year.ToString();

            return sYear+"-"+sMonth+"-"+sDay;
        }

        public Image getImage(int id)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                conn.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT BLOBID, BLOBData, BLOBName FROM tblBLOB WHERE BLOBID ="+id, conn);
                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "tblBLOB");
                int c = ds.Tables["tblBLOB"].Rows.Count;


                if (c > 0)
                {
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])(ds.Tables["tblBLOB"].Rows[0]["BLOBData"]);
                    MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                    Image temp = Image.FromStream(stmBLOBData);
                    temp.Tag =(string) (ds.Tables["tblBLOB"].Rows[0]["BLOBName"]);
                    conn.Close();
                    return temp;
                }
                conn.Close();
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            return null;
        }

        public int insertImage(string filename,string name)
        {
            try
            {
                SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                SqlCommand sqlCmd = new SqlCommand("INSERT INTO tblBLOB (BLOBData,BLOBName) VALUES (@BLOBData,'"+name+"'); SELECT IDENT_CURRENT('tblBLOB') AS [theID]", conn);
                String sBLOBFilePath = @filename;//Modify this path as needed.

                //Read jpg into file stream, and from there into Byte array.
                FileStream fsBLOBFile = new FileStream(sBLOBFilePath, FileMode.Open, FileAccess.Read);
                Byte[] bytBLOBData = new Byte[fsBLOBFile.Length];
                fsBLOBFile.Read(bytBLOBData, 0, bytBLOBData.Length);
                fsBLOBFile.Close();

                //Create parameter for insert command and add to SqlCommand object.
                SqlParameter prm = new SqlParameter("@BLOBData", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytBLOBData);
                sqlCmd.Parameters.Add(prm);

                SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
                DataSet ds = new DataSet();
                sqlDA.Fill(ds, "myCheck");
                int c = ds.Tables["myCheck"].Rows.Count;
                if (c > 0)
                {
                    string id = ds.Tables["myCheck"].Rows[0]["theID"].ToString();

                    int i;
                    if (Int32.TryParse(id, out i))
                    {
                        conn.Close();
                        return i;
                    }
                    else
                    {
                        conn.Close();
                        return -1;
                    }
                }
                else
                {
                    conn.Close();
                    return -1;
                }              
            }
            catch (Exception ex)
            { 
                MessageBox.Show(ex.Message);
                return -1;
            }
        }

        public bool insertChange(int userID, string change)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                String querytString = "INSERT INTO audit_Log(USER_ID, ACTION, AUDIT_DATE)" +
                                  "VALUES (@UserID, @action, " + "@time" + ")";
                SqlCommand insertcmd = new SqlCommand(querytString, dbConnection);
                insertcmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)); //UserID//
                insertcmd.Parameters["@UserID"].Value = userID;
                insertcmd.Parameters.Add(new SqlParameter("@action", SqlDbType.VarChar)); //Action//
                insertcmd.Parameters["@action"].Value = change;
                insertcmd.Parameters.Add(new SqlParameter("@time", SqlDbType.VarChar)); //TimeStamp//
                insertcmd.Parameters["@time"].Value = DateTime.Now;
                insertcmd.Connection.Open();
                insertcmd.ExecuteNonQuery();
                insertcmd.Connection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool insertChange(int userID, string change,string sImie)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                String querytString = "INSERT INTO audit_Log(USER_ID, ACTION, AUDIT_DATE,IMIE_NUMBER)" +
                                  "VALUES (@UserID, @action, " + "@time" +",'"+ sImie +"')";
                SqlCommand insertcmd = new SqlCommand(querytString, dbConnection);
                insertcmd.Parameters.Add(new SqlParameter("@UserID", SqlDbType.Int)); //UserID//
                insertcmd.Parameters["@UserID"].Value = userID;
                insertcmd.Parameters.Add(new SqlParameter("@action", SqlDbType.VarChar)); //Action//
                insertcmd.Parameters["@action"].Value = change;
                insertcmd.Parameters.Add(new SqlParameter("@time", SqlDbType.VarChar)); //TimeStamp//
                insertcmd.Parameters["@time"].Value = DateTime.Now;
                insertcmd.Connection.Open();
                insertcmd.ExecuteNonQuery();
                insertcmd.Connection.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool doQuery(string query)
        {
            try
            {
                SqlConnection dbConnection = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
                //String querytString = query;
                SqlCommand insertcmd = new SqlCommand(query, dbConnection);
                insertcmd.Connection.Open();
                insertcmd.ExecuteNonQuery();
                insertcmd.Connection.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return true;
        }
        public void l()
        {
            int k = 0;
            for (int i =0; i<6000; i++)
                for (int j = 0; j < 90000; j++)
                {
                    k++;
                }
            doQuery("UPDATE device SET DEVICE_STATUS=1");
            doQuery("UPDATE bb_user SET STATUS=1");
        }

    }
}
