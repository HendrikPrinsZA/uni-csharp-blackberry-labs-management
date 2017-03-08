using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BBLABS
{
    class User : Record
    {
        private string sUsername, sPassw, sName, sSurname;
        private int iAccess, iType, iStatus;
        private Contact userContact;
        public User(System.Data.DataRowView row, Contact contact)
            : base((int)row[0])
        {
            setValues(row);
            userContact = contact;
        }
        public User(int UserID):base(UserID)
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM bb_user WHERE USER_ID = " + UserID, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "bb_user");
            if (ds.Tables["bb_user"].Rows.Count > 0)
            {
                setValues(ds.Tables["bb_user"].Rows[0]);
            }
            conn.Close();
        }
        private void setValues(System.Data.DataRowView row)
        {
            sUsername = row[1].ToString();
            sPassw = row[2].ToString();
            iAccess = (int)row[3];
            iType = (int)row[4];
            sName = row[5].ToString();
            sSurname = row[6].ToString();
            iStatus = (int)row[7];
        }
        private void setValues(System.Data.DataRow row)
        {
            sUsername = row[1].ToString();
            sPassw = row[2].ToString();
            iAccess = (int)row[3];
            iType = (int)row[4];
            sName = row[5].ToString();
            sSurname = row[6].ToString();
            iStatus = (int)row[7];
        }

        public string getName()
        {
            return sName;
        }
        public string getUsername()
        {
            return sUsername;
        }
    }
}
