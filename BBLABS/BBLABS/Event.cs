using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BBLABS
{
    class Event : Record
    {
        int iCreator, iStatus, iRespPerson;
        string sComments, sName, sVenue;
        DateTime dateCreated, dateEvent;
        List<string> lstParticipants;

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
        public void addParticipant(string s)
        {
            lstParticipants.Add(s);
        }
    }
}
