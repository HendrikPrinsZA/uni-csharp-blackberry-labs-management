using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BBLABS
{
    class User : Record
    {
        public string sUsername, sPassw, sName, sSurname;
        public int iAccess, iType, iStatus;
        public Contact userContact;
        List<Event> upcommingEvents;
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
                userContact = new Contact(UserID);
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

        public void setEvents()
        {
            SqlConnection conn = new SqlConnection("server=localhost;" + "database=bblabs;Trusted_Connection=Yes");
            conn.Open();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM event WHERE EVENT_DATE > '" + DateTime.Today+"'", conn);
            SqlDataAdapter sqlDA = new SqlDataAdapter(sqlCmd);
            DataSet ds = new DataSet();
            sqlDA.Fill(ds, "event");
            upcommingEvents = new List<Event>();
            if (ds.Tables["event"].Rows.Count > 0)
            {
                for (int i = 0; i<ds.Tables["event"].Rows.Count; i++)
                    upcommingEvents.Add(new Event(ds.Tables["event"].Rows[i]));
            }
            conn.Close();
        }

        public void assignToCalendar(MonthCalendar mC)
        {
            for (int i = 0; i < upcommingEvents.Count; i++)
                mC.AddBoldedDate(upcommingEvents[i].dateEvent);
            mC.UpdateBoldedDates();
        }

        public void clickedBoldedDate(DateTime dt)
        {
            for (int i = 0; i < upcommingEvents.Count; i++)
            {
                if (upcommingEvents[i].dateEvent == dt)
                {
                    String parts = "";
                    for (int j = 0; j < upcommingEvents[i].lstParticipants.Count; j++)
                    {
                        parts += upcommingEvents[i].lstParticipants[j] + ",";
                    }
                    String sLyn = "Showing info for event " + upcommingEvents[i].sName + '\n' + '\n' +
                                    "Date of event  " + upcommingEvents[i].dateEvent.ToShortDateString() + '\n' +
                                    "Created on      " + upcommingEvents[i].dateCreated.ToShortDateString() + '\n' +
                                     "Venue              " + upcommingEvents[i].sVenue + '\n' +
                                    "Participants     " + parts + '\n' + '\n' +
                                    "Comments  \n" + upcommingEvents[i].sComments + '\n';
                    MessageBox.Show(sLyn, "Event Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
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
