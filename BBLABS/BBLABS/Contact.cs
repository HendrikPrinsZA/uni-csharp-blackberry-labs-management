using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBLABS
{
    class Contact : Record
    {
        private string sStudNmr, sPersNmr, sID, sCell, sEmail, sTel, sAddress;
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
    }
}
