using System;
using System.Collections.Generic;
using System.Data.Common;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.IO;
using System.Drawing.Imaging;

namespace BBLABS
{
    public partial class Form1 : Form
    {
        int UserID = -1;
        int UserAccess = -1;
        int UserType = -1;
        string userName = "";

        Locker chosenLocker;

        logHandle myLogHangle = new logHandle();

        public void changeState()
        {
            //UserAccess
            //1: Default User, limited access
            //2: Administrator
 
            //UserType
            //1: System user
            //2: Lab user
            //3: Both
            if (UserAccess == 1)
            {
                addNewUserToolStripMenuItem.Enabled = false;
                editUserToolStripMenuItem.Enabled = false;
                removeUserToolStripMenuItem.Enabled = false;
                //Events
                btnCreateNewEvent.Visible = false;
                btnEditEvent.Visible = false;
                btnDeleteEvent.Visible = false;
                //Posts
                btnCreatePost.Visible = false;
                //Devices
                btnDeviceAdd.Visible = false;
                btnDeviceEdit.Visible = false;
                btnRemoveDevice.Visible = false;
                btnAddDevice.Visible = false;
            }
            else if (UserAccess == 2)
            {
                addNewUserToolStripMenuItem.Enabled = true;
                editUserToolStripMenuItem.Enabled = true;
                removeUserToolStripMenuItem.Enabled = true;
                //Events
                btnCreateNewEvent.Visible = true;
                btnEditEvent.Visible = true;
                btnDeleteEvent.Visible = true;
                //Posts
                btnCreatePost.Visible = true;
                //Devices
                btnDeviceAdd.Visible = true;
                btnDeviceEdit.Visible = true;
                btnRemoveDevice.Visible = true;
                btnAddDevice.Visible = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void updateEvents()
        {
            eventTableAdapter.Fill(bBLABSDataSet._event);
        }

        public void updateDevices()
        {
            deviceTableAdapter.FillAllAvailable(bBLABSDataSet.device);
        }

        public void updateLockers()
        {
            lockerTableAdapter.FillAllOpen(bBLABSDataSet.locker);
        }

        public void updatePosts()
        {
            postTableAdapter.FillByDateAdded(bBLABSDataSet.announcement);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
             bb_userTableAdapter1.FillByUserName(bBLABSDataSet.bb_user, edtUsername.Text);
             if (bBLABSDataSet.bb_user.Rows.Count > 0)
             {
                 UserID = (int)bBLABSDataSet.bb_user.Rows[0].ItemArray[0];
                 string pass = (string)bBLABSDataSet.bb_user.Rows[0].ItemArray[2];
                 UserAccess = (int)bBLABSDataSet.bb_user.Rows[0].ItemArray[3];
                 UserType = (int)bBLABSDataSet.bb_user.Rows[0].ItemArray[4];

                if (pass == EdtPassword.Text)
                {
                    dropLogin.Text = edtUsername.Text;
                    if (myLogHangle.insertChange(UserID,"Login"))
                    {
                        Panel_login.Visible = false;
                        toolStrip.Visible = true;
                        userName = edtUsername.Text;
                        //Load posts
                        postTableAdapter.FillByDateAdded(bBLABSDataSet.announcement);
                        deviceTableAdapter.FillAllAvailable(bBLABSDataSet.device);
                        lockerTableAdapter.FillAllOpen(bBLABSDataSet.locker);
                        eventTableAdapter.Fill(this.bBLABSDataSet._event);
                        lstHistory_SelectedIndexChanged(sender, e);
                        changeState();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Invalid Login Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bBLABSDataSet._event' table. You can move, or remove it, as needed.
            
            toolStrip.Visible = false;

            Panel_login.Top = 0;
            Panel_login.Left = 0;
            Panel_login.Height = this.Height;
            Panel_login.Width = this.Width;
        }

        private void viewEditProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount myAccount = new frmAccount(UserID, -1, 2,UserAccess);
            myAccount.Show();
        }

        private void logoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            dropLogin.Text = "No user";
            myLogHangle.insertChange(UserID, "Logout");
            toolStrip.Visible = false;
            Panel_login.Visible = true;
        }

        private void editUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount myAccount = new frmAccount(-1,UserID,0,UserAccess);
            myAccount.Show();
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount myAccount = new frmAccount(-1, UserID, 1, UserAccess);
            myAccount.Show();
        }

        private void viewAuditLogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReports frmReport = new frmReports();
            frmReport.Show();
        }

        private void removeUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount myAccount = new frmAccount(-1, UserID, 4, UserAccess);
            myAccount.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Panel_login.Visible == false)
                logoutToolStripMenuItem1_Click(sender,e);
        }

        private void btnCreatePost_Click(object sender, EventArgs e)
        {
            frmPostcs myAccount = new frmPostcs(UserID,this);
            myAccount.Show();
        }

        private void lstHistory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstHistory.SelectedIndex > -1)
            {
                if (lstHistory.Items.Count > 0)
                {
                    System.Data.DataRowView myRow = (System.Data.DataRowView)lstHistory.SelectedItem;

                    lblHeading.Text = myRow[3].ToString();
                    red1.Text = myRow[4].ToString();
                    lblDate.Text = myLogHangle.covertDateStringToString(myRow[2].ToString());

                    bb_userTableAdapter1.FillByUserID(bBLABSDataSet.bb_user, (int)myRow[1]);
                    lblPostedBy.Text = bBLABSDataSet.bb_user.Rows[0]["USERNAME"].ToString();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmEvent myForm = new frmEvent(UserID,edtUsername.Text, this);
            myForm.Show();

        }

        private void lstEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            string parts = "",user="";

            if (lstEvents.SelectedIndex>-1)
                if (lstEvents.Items.Count > 0)
                {
                    System.Data.DataRowView myRow = (System.Data.DataRowView)lstEvents.SelectedItem;
                    txtEventName.Text = myRow[8].ToString();
                    lblCreatedDate.Text = myLogHangle.covertDateStringToString(myRow[3].ToString());

                    bb_userTableAdapter1.FillByUserID(bBLABSDataSet.bb_user, (int)myRow[1]);
                    lblCreator.Text = bBLABSDataSet.bb_user.Rows[0]["USERNAME"].ToString();

                    bb_userTableAdapter1.FillByUserID(bBLABSDataSet.bb_user, (int)myRow[7]);
                    lblRespPerson.Text = bBLABSDataSet.bb_user.Rows[0]["USERNAME"].ToString();

                    dateEvent.Value = Convert.ToDateTime(myRow[4].ToString());
                    //calendarEvent.SetDate(Convert.ToDateTime(myRow[4].ToString()));

                    if ((int)myRow[6] == 1)
                        chkOpen.Checked = false;
                    else
                        chkOpen.Checked = true;
                    chkParticipants.Items.Clear();
                    parts = myRow[5].ToString();
                    while (parts.Contains(','))
                    {
                        user = parts.Substring(0, parts.IndexOf(','));
                        parts = parts.Remove(0, parts.IndexOf(',') + 1);
                        chkParticipants.Items.Add(user);
                    }
                    //lblCount.Text = chkParticipants.Items.Count.ToString();
                    redSummary.Text = myRow[2].ToString();
                    txtVenue.Text = myRow[9].ToString();
                }
        }

        private void chkOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (chkOpen.Checked == true)
            {
                btnJoin.Enabled = true;
            }
            else
                btnJoin.Enabled = false;
        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            System.Data.DataRowView myRow = (System.Data.DataRowView) lstEvents.SelectedItem;
            if (lstEvents.SelectedIndex > -1)
            {
                if (lstEvents.Items.Count > 0)
                {
                    String querytString = "DELETE FROM event WHERE EVENT_ID =" + (int)lstEvents.SelectedValue;
                    if (myLogHangle.doQuery(querytString))
                    {
                        myLogHangle.insertChange(UserID, "Removed event: " + myRow[8].ToString());
                        eventTableAdapter.Fill(bBLABSDataSet._event);
                    } else
                        MessageBox.Show("Could not remove event", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            frmDevice myForm = new frmDevice(UserID,this);
            myForm.Show();
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            frmDevice myForm = new frmDevice(UserID,this);
            myForm.Show();
        }

        private void fillAllAvailableToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.deviceTableAdapter.FillAllAvailable(this.bBLABSDataSet.device);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void lstDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstDevices.SelectedIndex > -1)
            {
                Device selected = new Device((System.Data.DataRowView)lstDevices.SelectedItem);
                //btnAdd.Visible = false;
                btnEditEvent.Visible = true;
                if (selected.iBlobID>0)
                {
                    imgDevice.Image = selected.myImage.imgImage;
                    if (imgDevice.Image.Tag != null)
                        lblCaption.Text = (string)imgDevice.Image.Tag;
                }
                else
                {
                    imgDevice.Image = imgList.Images[3];
                    lblCaption.Text = "";
                }
                lblTel.Text = selected.sTel;
                lblIMIE.Text = selected.sIMIE;
                lblName.Text = selected.sName;
                lblSerial.Text = selected.sSerial;
                lblPin.Text = selected.sPin;
                lblEmail.Text = selected.sEmail;
                lblPassw.Text = selected.sPassw;
                lblModel.Text = selected.sModel;
                if (selected.iCategory == 1)
                    lblCat.Text = "Phone";
                else if (selected.iCategory == 2)
                    lblCat.Text = "Tablet";
                else
                    lblCat.Text = "Other";
                if (selected.sTel.Length < 1)
                    lblDTel.Visible = false;
                else
                    lblDTel.Visible = true;
                if (selected.sIMIE.Length < 1)
                    lblDIMIE.Visible = false;
                else
                    lblDIMIE.Visible = true;
                if (selected.sSerial.Length < 1)
                    lblDSerial.Visible = false;
                else
                    lblDSerial.Visible = true;
                if (selected.sPin.Length < 1)
                    lblDPin.Visible = false;
                else
                    lblDPin.Visible = true;
                if (selected.sPassw.Length < 1)
                    lblDPassW.Visible = false;
                else
                    lblDPassW.Visible = true;
                if (selected.sEmail.Length < 1)
                    lblDEmail.Visible = false;
                else
                    lblDEmail.Visible = true;
                if (selected.sModel.Length < 1)
                    lblDModel.Visible = false;
                else
                    lblDModel.Visible = true;
            }
        }

        private void btnDeviceEdit_Click(object sender, EventArgs e)
        {
            if (lstDevices.SelectedIndex > -1)
            {
                frmDevice myForm = new frmDevice(UserID, new Device((System.Data.DataRowView)lstDevices.SelectedItem), this);
                myForm.Show();
            }
        }

        private void fillPhonesToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.deviceTableAdapter.FillPhones(this.bBLABSDataSet.device);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked == true)
            {
                if (cbkAvailable.Checked == true)
                    deviceTableAdapter.FillAllAvailable(bBLABSDataSet.device);
                else
                    deviceTableAdapter.FillAll(bBLABSDataSet.device);
                lstDevices_SelectedIndexChanged(sender, e);
            }
        }

        private void rdbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhone.Checked == true)
            {
                if (cbkAvailable.Checked == true)
                    deviceTableAdapter.FillPhones(bBLABSDataSet.device);
                else
                    deviceTableAdapter.FillAllPhones(bBLABSDataSet.device);
                lstDevices_SelectedIndexChanged(sender, e);
            }
        }

        private void rdbTablet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTablet.Checked == true)
            {
                if (cbkAvailable.Checked == true)
                    deviceTableAdapter.FillTablets(bBLABSDataSet.device);
                else
                    deviceTableAdapter.FillAllTablets(bBLABSDataSet.device);
                lstDevices_SelectedIndexChanged(sender, e);
            }
        }

        private void rdbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOther.Checked == true)
            {
                if (cbkAvailable.Checked == true)
                    deviceTableAdapter.FillOther(bBLABSDataSet.device);
                else
                    deviceTableAdapter.FillAllOther(bBLABSDataSet.device);
                lstDevices_SelectedIndexChanged(sender, e);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstEvents.SelectedIndex > -1)
            {
                frmEvent myForm = new frmEvent(UserID,edtUsername.Text, (System.Data.DataRowView)lstEvents.SelectedItem, this);
                myForm.Show();
            }
        }

        private void chkSName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSName.Checked == true)
                txtSEventName.Visible = true;
            else
                txtSEventName.Visible = false;

            if (chkSDate.Checked && chkSName.Checked)
                lblANDOR.Text = "and";
            else
                lblANDOR.Text = "";
        }

        private void chkSDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSDate.Checked == true)
                dateTimeSEvent.Visible = true;
            else
                dateTimeSEvent.Visible = false;

            if (chkSDate.Checked && chkSName.Checked)
                lblANDOR.Text = "and";
            else
                lblANDOR.Text = "";
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void chkSUserName_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSUserName.Checked == true)
                txtSName.Visible = true;
            else
                txtSName.Visible = false;

            if (chkSUserName.Checked && chkSName.Checked)
                lblANDOR.Text = "and";
            else
                lblANDOR.Text = "";
        }

        private void btnSEvents_Click(object sender, EventArgs e)
        {

        }

        private void btnLockersAdmin_Click(object sender, EventArgs e)
        {
            frmLockers myForm = new frmLockers(UserID);
            myForm.Show();
        }

        private void btnLockersOpen_Click(object sender, EventArgs e)
        {
            frmOpenLocker myForm = new frmOpenLocker(UserID,this);
            myForm.Show();
         
        }

        private void lstOpenLockers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOpenLockers.SelectedIndex > -1)
            {
                chosenLocker = new Locker((int)lstOpenLockers.SelectedValue);

                lblLockerName.Text = chosenLocker.getName();
                lblLockerAdmin.Text = chosenLocker.getKeyHolder1();
                lblLockerLabUser.Text = chosenLocker.getKeyHolder2();
                lblDateFrom.Text = myLogHangle.covertDateStringToString(chosenLocker.getDateFrom().ToString());
                chosenLocker.assignDeviceList(lstLockerDevices);
                dateLockerTo.TodayDate = chosenLocker.getDateTo();
                dateLockerTo.SetDate(chosenLocker.getDateTo());
                TimeSpan temp = chosenLocker.getDateTo() - DateTime.Today;
                lblLockersDLeft.Text = temp.Days.ToString() + " days left";

                if (lstLockerDevices.Items.Count > 0)
                {
                    lstLockerDevices.SelectedIndex = 0;
                    lstLockerDevices_SelectedIndexChanged(sender, e);
                }
                else
                {
                    lblLockerDName.Text = "";
                    lblLockerDIMIE.Text = "";
                    lblLockerDModel.Text = "";
                    lblLockerDSerial.Text = "";
                    imgLockerDimg.Image = imgList.Images[3];
                }
            }
            else
            {
                lblLockerName.Text = "";
                lblLockerAdmin.Text = "";
                lblLockerLabUser.Text = "";

                lblDateFrom.Text = "";
                dateLockerTo.TodayDate = DateTime.Now;
                dateLockerTo.SetDate(DateTime.Now);
                lblLockersDLeft.Text = "";

                lblLockerDName.Text = "";
                lblLockerDIMIE.Text = "";
                lblLockerDModel.Text = "";
                lblLockerDSerial.Text = "";
                imgLockerDimg.Image = imgList.Images[3];
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void lstLockerDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLockerDevices.SelectedIndex > -1)
            {
                lblLockerDName.Text = ((Device)(lstLockerDevices.SelectedItem)).sName;

                lblLockerDIMIE.Text = ((Device)(lstLockerDevices.SelectedItem)).sIMIE;
                lblLockerDModel.Text = ((Device)(lstLockerDevices.SelectedItem)).sModel;
                lblLockerDSerial.Text = ((Device)(lstLockerDevices.SelectedItem)).sSerial;
                imgLockerDimg.Image = ((Device)(lstLockerDevices.SelectedItem)).myImage.imgImage;
            }
        }

        private void btnReturnDevice_Click(object sender, EventArgs e)
        {
            if ((lstLockerDevices.Items.Count > 0) && (lstLockerDevices.SelectedIndex > -1))
            {
                if (MessageBox.Show("Check List\n\n1. Has the device been wiped clean?\n2. Is it still in full working condition?\n\n", "Sign in Device", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sQuery = "DELETE FROM lockerItem WHERE DEVICE_ID = " + ((Device)(lstLockerDevices.SelectedItem)).recordID;
                    sQuery += " UPDATE device SET DEVICE_STATUS = 1 WHERE DEVICE_ID = " + ((Device)(lstLockerDevices.SelectedItem)).recordID + " ";
                    if (myLogHangle.doQuery(sQuery))
                    {
                        myLogHangle.insertChange(UserID, "Signed in Device. ID: " + ((Device)(lstLockerDevices.SelectedItem)).recordID + ", Name: " + ((Device)(lstLockerDevices.SelectedItem)).sName + " for lab user: " + lblLockerLabUser.Text);
                        lstOpenLockers_SelectedIndexChanged(sender, e);
                        if (lstLockerDevices.Items.Count < 1)
                        {
                            sQuery = "UPDATE locker SET KEY_ONE_USER=null, KEY_TWO_USER=null, LOCKER_STATUS=1, DATE_FROM=null, DATE_TO=null WHERE LOCKER_ID=" + chosenLocker.recordID;
                            if (myLogHangle.doQuery(sQuery))
                            {
                                myLogHangle.insertChange(UserID, "Closed locker: " + lblLockerName.Text + " for lab user: " + lblLockerLabUser.Text);
                                lockerTableAdapter.FillAllOpen(bBLABSDataSet.locker);
                                lstLockerDevices.Items.Clear();
                                lblLockerDName.Text = "";
                                lblLockerDIMIE.Text = "";
                                lblLockerDModel.Text = "";
                                lblLockerDSerial.Text = "";
                                imgLockerDimg.Image = imgList.Images[3];
                                lstOpenLockers_SelectedIndexChanged(sender, e);
                            }
                        }
                        else
                            lstLockerDevices_SelectedIndexChanged(sender, e);
                    }
                }
            }
            else
            {
                //No device selected
                MessageBox.Show("No device selected to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnCloseLocker_Click(object sender, EventArgs e)
        {
            if (lstOpenLockers.Items.Count > 0 && lstOpenLockers.SelectedIndex > 0)
            {
                if (MessageBox.Show("Check List for all devices in this locker\n\n1. Has all the the devices been wiped clean?\n2. Are they still in full working condition?\n\n", "Close Locker", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sQuery;
                    for (int i = 0; i < lstLockerDevices.Items.Count; i++)
                    {
                        sQuery = "DELETE FROM lockerItem WHERE DEVICE_ID = " + ((Device)(lstLockerDevices.Items[i])).recordID;
                        sQuery += " UPDATE device SET DEVICE_STATUS = 1 WHERE DEVICE_ID = " + ((Device)(lstLockerDevices.Items[i])).recordID + " ";
                        if (myLogHangle.doQuery(sQuery))
                            myLogHangle.insertChange(UserID, "Signed in Device. ID: " + ((Device)(lstLockerDevices.Items[i])).recordID + ", Name: " + ((Device)(lstLockerDevices.Items[i])).sName + " for lab user: " + lblLockerLabUser.Text);
                    }
                    sQuery = "UPDATE locker SET KEY_ONE_USER=null, KEY_TWO_USER=null, LOCKER_STATUS=1, DATE_FROM=null, DATE_TO=null WHERE LOCKER_ID=" + chosenLocker.recordID;
                    if (myLogHangle.doQuery(sQuery))
                    {
                        myLogHangle.insertChange(UserID, "Closed locker: " + lblLockerName.Text + " for lab user: " + lblLockerLabUser.Text);
                        lockerTableAdapter.FillAllOpen(bBLABSDataSet.locker);
                        lstLockerDevices.Items.Clear();
                        lblLockerDName.Text = "";
                        lblLockerDIMIE.Text = "";
                        lblLockerDModel.Text = "";
                        lblLockerDSerial.Text = "";
                        imgLockerDimg.Image = imgList.Images[3];
                        lstOpenLockers_SelectedIndexChanged(sender, e);
                    }
                    else
                    {
                        //MessageBox.Show("No device selected to return", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("No locker selected to close", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbkAvailable_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAll.Checked)
                rdbAll_CheckedChanged(sender, e);
            else if (rdbPhone.Checked)
                rdbPhone_CheckedChanged(sender, e);
            else if (rdbTablet.Checked)
                rdbTablet_CheckedChanged(sender, e);
            else if (rdbOther.Checked)
                rdbOther_CheckedChanged(sender, e);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            String conStr = @"BACKUP DATABASE BBLABS TO DISK='C:\Users\Hendrik32\Desktop\mostRecent.bak' WITH FORMAT";
            if (myLogHangle.doQuery(conStr))
                MessageBox.Show("Backed up");
            else
                MessageBox.Show("Failed");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            String conStr= @"RESTORE DATABASE BBLABS FROM DISK=N'C:\Users\Hendrik32\Desktop\myBackup.bak'";
            if (myLogHangle.doQuery(conStr))
                MessageBox.Show("Restored");
            else
                MessageBox.Show("Failed");
        }

        private void chkSTel_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEvents.Checked)
                grpEvents.Visible = true;
            else
                grpEvents.Visible = false;
        }

        private void rdbDevices_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbDevices.Checked)
                grpDevices.Visible = true;
            else
                grpDevices.Visible = false;
        }

        private void rdbUsers_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUsers.Checked)
                grpUsers.Visible = true;
            else
                grpUsers.Visible = false;
        }


    }
}