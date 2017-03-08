using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlTypes;
using System.Drawing.Imaging;
using System.Drawing;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace BBLABS
{
    public class Record
    {
        public int recordID;
        public Record()
        {
            recordID = 0;
        }
        public Record(int id)
        {
            recordID = id;
        }
    }
}
