using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BBLABS
{
    class Contact : Record
    {
        public string sStudNmr, sPersNmr, sID, sCell, sEmail, sTel, sAddress;
        public Contact(System.Data.DataRowView row)
            : base((int)row[0])
        {
            sStudNmr = row[1].ToString();
            sPersNmr = row[2].ToString();
            sID = row[3].ToString();
            sCell = row[4].ToString();
            sEmail = row[5].ToString();
            sTel = row[6].ToString();
            sAddress = row[7].ToString();
        }
        public Contact(int ID)
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM contact WHERE CONTACT_ID = " + ID, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "contact");
            if (ds.Tables["contact"].Rows.Count > 0)
            {
                System.Data.DataRow row = ds.Tables["contact"].Rows[0];
                sStudNmr = row[1].ToString();
                sPersNmr = row[2].ToString();
                sID = row[3].ToString();
                sCell = row[4].ToString();
                sEmail = row[5].ToString();
                sTel = row[6].ToString();
                sAddress = row[7].ToString();
            }
            conn.Close();
        }
    }
}
