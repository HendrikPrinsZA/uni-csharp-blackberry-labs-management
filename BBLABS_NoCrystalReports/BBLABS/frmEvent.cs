using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BBLABS
{
    public partial class frmEvent : Form
    {
        logHandle myLogHangle = new logHandle();
        System.Data.DataRowView myRow;
        Form1 parentForm;
        int UserID = -1;
        string username = "";

        bool validate()
        {
            bool temp = true;
            lbl0.Visible = false;
            lbl1.Visible = false;

            if (dateEvent.Value < DateTime.Now)
            {
                temp = false;
                lbl1.Visible = true;
            }
            if (txtEventName.TextLength < 1)
            {
                temp = false;
                lbl0.Visible = true;
            }
            return temp;
        }

        public frmEvent(int id, string name, Form1 par)
        {
            InitializeComponent();
            this.Text = "Add New Event";
            parentForm = par;
            UserID = id;
            username = name;
            btnAdd.Visible = true;
            btnSave.Visible = false;

            bb_userTableAdapter.Fill(bblabsDataSet.bb_user);
            cmbUserNamesPartic.Items.Clear();
            for (int i = 0; i < bblabsDataSet.bb_user.Rows.Count; i++)
                cmbUserNamesPartic.Items.Add(bblabsDataSet.bb_user.Rows[i]["USERNAME"].ToString());

            bb_userTableAdapter.FillByLabUsers(bblabsDataSet.bb_user);
            lblCreator.Text = name;
            dateEvent.Text = myLogHangle.covertDateStringToString(DateTime.Now.ToString());
        }

        public frmEvent(int id, string name, System.Data.DataRowView row, Form1 par)
        {
            InitializeComponent();
            this.Text = "Edit Event";
            int respID = -1;
            parentForm = par;
            UserID = id;
            username = name;
            myRow = row;
            btnAdd.Visible = false;
            btnSave.Visible = true;
            bb_userTableAdapter.Fill(bblabsDataSet.bb_user);
            cmbUserNamesPartic.Items.Clear();
            for (int i = 0; i < bblabsDataSet.bb_user.Rows.Count; i++)
                cmbUserNamesPartic.Items.Add(bblabsDataSet.bb_user.Rows[i]["USERNAME"].ToString());
            txtEventName.Text = myRow[8].ToString();
            lblCreatedDate.Text = myLogHangle.covertDateStringToString(myRow[3].ToString());
            bb_userTableAdapter.FillByUserID(bblabsDataSet.bb_user,(int)myRow[1]);
            lblCreator.Text = bblabsDataSet.bb_user.Rows[0]["USERNAME"].ToString();
            dateEvent.Value = dateEvent.Value = Convert.ToDateTime(myRow[4].ToString());
            if ((int)myRow[6] == 1)
                chkOpen.Checked = false;
            else
                chkOpen.Checked = true;
            chkParticipants.Items.Clear();
            string parts = myRow[5].ToString();
            while (parts.Contains(','))
            {
                string user = parts.Substring(0, parts.IndexOf(','));
                parts = parts.Remove(0, parts.IndexOf(',') + 1);
                chkParticipants.Items.Add(user);
            }
            lblCount.Text = chkParticipants.Items.Count.ToString();
            redSummary.Text = myRow[2].ToString();
            txtVenue.Text = myRow[9].ToString();
            respID = (int)myRow[7];
            bb_userTableAdapter.FillByLabUsers(bblabsDataSet.bb_user);
            for (int i = 0; i < cmbResponsible.Items.Count; i++)
            {
                System.Data.DataRowView temp;
                temp = (System.Data.DataRowView)cmbResponsible.Items[i];
                if ((int)temp[0] == respID)
                {
                    cmbResponsible.SelectedIndex = i;
                    break;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                String eventName = txtEventName.Text, dateCreated = DateTime.Now.ToString(), eventDate = dateEvent.Value.ToString(), creator = lblCreator.Text, participants, summary = redSummary.Text, venue = txtVenue.Text;
                int RespPerson = (int)cmbResponsible.SelectedValue, eventStatus;

                if (chkOpen.Checked == true)
                    eventStatus = 0;
                else eventStatus = 1;

                participants = "";
                for (int i = 0; i < chkParticipants.Items.Count; i++)
                {
                    participants += chkParticipants.Items[i].ToString() + ",";
                }

                String querytString = "INSERT INTO event(CREATOR,LAB_USER,EVENT_NAME,COMMENTS,CREATION_DATE,EVENT_DATE,VENUE,PARTICIPANTS,EVENT_STATUS) " +
                                             "VALUES(" + UserID + "," + RespPerson + ",'" + eventName + "','" + summary + "','" + dateCreated + "','" + eventDate + "','" + venue + "','" + participants + "'," + eventStatus + ")";
                if (myLogHangle.doQuery(querytString))
                {
                    myLogHangle.insertChange(UserID, "Created new event: " + eventName);
                    parentForm.updateEvents();
                    this.Close();
                }
                else
                    MessageBox.Show("Fail");
            }
            
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            if (txtUsernamePart.Text.Length < 1)
            {
                if (chkParticipants.Items.Contains(cmbUserNamesPartic.Items[cmbUserNamesPartic.SelectedIndex].ToString()))
                {
                    MessageBox.Show("Participant exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkParticipants.Items.Add(cmbUserNamesPartic.Items[cmbUserNamesPartic.SelectedIndex].ToString());
                    lblCount.Text = chkParticipants.Items.Count.ToString();
                }
            }
            else
            {
                
                if (chkParticipants.Items.Contains(txtUsernamePart.Text))
                {
                    MessageBox.Show("Participant exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    chkParticipants.Items.Add(txtUsernamePart.Text);
                    lblCount.Text = chkParticipants.Items.Count.ToString();
                }
                txtUsernamePart.Text = "";
            }
        }

        private void txtUsernamePart_TextChanged(object sender, EventArgs e)
        {
            if (txtUsernamePart.TextLength > 0)
            {
                cmbUserNamesPartic.Enabled = false;
            } else
                cmbUserNamesPartic.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                String eventName = txtEventName.Text, dateCreated = DateTime.Now.ToString(), eventDate = dateEvent.Value.ToString(), creator = lblCreator.Text, participants, summary = redSummary.Text, venue = txtVenue.Text;
                int RespPerson = (int)cmbResponsible.SelectedValue, eventStatus;

                if (chkOpen.Checked == true)
                    eventStatus = 0;
                else eventStatus = 1;

                participants = "";
                for (int i = 0; i < chkParticipants.Items.Count; i++)
                {
                    participants += chkParticipants.Items[i].ToString() + ",";
                }

                String querytString = "UPDATE event SET CREATOR=" + UserID + ",LAB_USER=" + RespPerson + ",EVENT_NAME='" + eventName + "',COMMENTS='" + summary + "',EVENT_DATE='" + eventDate + "',VENUE='" + venue + "',PARTICIPANTS='" + participants + "',EVENT_STATUS=" + eventStatus +
                                      " WHERE EVENT_ID=" + myRow[0];
                if (myLogHangle.doQuery(querytString))
                {
                    myLogHangle.insertChange(UserID, "Created new event: " + eventName);
                    parentForm.updateEvents();
                    this.Close();
                }
                else
                    MessageBox.Show("Fail");
            }
        }
    }
}
