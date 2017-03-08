using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.IO;

namespace BBLABS
{
    public class Blob : Record
    {
        public Image imgImage;
        public Blob(int id)
            : base(id)
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT BLOBID, BLOBData, BLOBName FROM tblBLOB WHERE BLOBID =" + id, conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "tblBLOB");
            if (ds.Tables["tblBLOB"].Rows.Count > 0)
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])(ds.Tables["tblBLOB"].Rows[0]["BLOBData"]);
                MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
                imgImage = Image.FromStream(stmBLOBData);
                imgImage.Tag = (string)(ds.Tables["tblBLOB"].Rows[0]["BLOBName"]);
            }
            conn.Close();
        }
    }
}
