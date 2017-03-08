using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBLABS
{
    class Event : Record
    {
        int iCreator, iStatus, iRespPerson;
        public string sComments, sName, sVenue;
        public DateTime dateCreated, dateEvent;
        public List<string> lstParticipants;

        public Event(System.Data.DataRowView row)
            : base((int)row[0])
        {
            iCreator = (int)row[1];
            sComments = row[2].ToString();
            dateCreated = Convert.ToDateTime(row[3].ToString());
            dateEvent = Convert.ToDateTime(row[4].ToString());
            lstParticipants = new List<string>();
            string parts = row[5].ToString();
            while (parts.Contains(','))
            {
                string user = parts.Substring(0, parts.IndexOf(','));
                parts = parts.Remove(0, parts.IndexOf(',') + 1);
                lstParticipants.Add(user);
            }
            iStatus = (int)row[4];
            iRespPerson = (int)row[5];
            sName = row[6].ToString();
            sVenue = row[7].ToString();
        }

        public Event(System.Data.DataRow row)
            : base((int)row["EVENT_ID"])
        {
            iCreator = (int)row["CREATOR"];
            sComments = row["COMMENTS"].ToString();
            dateCreated = Convert.ToDateTime(row["CREATION_DATE"].ToString());
            dateEvent = Convert.ToDateTime(row["EVENT_DATE"].ToString());
            lstParticipants = new List<string>();
            string parts = row["PARTICIPANTS"].ToString();
            while (parts.Contains(','))
            {
                string user = parts.Substring(0, parts.IndexOf(','));
                parts = parts.Remove(0, parts.IndexOf(',') + 1);
                lstParticipants.Add(user);
            }
            iStatus = (int)row["EVENT_STATUS"];
            iRespPerson = (int)row["LAB_USER"];
            sName = row["EVENT_NAME"].ToString();
            sVenue = row["VENUE"].ToString();
        }

        public void addParticipant(string s)
        {
            lstParticipants.Add(s);
        }
    }
}
