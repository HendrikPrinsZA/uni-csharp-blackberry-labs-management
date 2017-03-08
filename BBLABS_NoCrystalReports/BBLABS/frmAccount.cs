using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BBLABS
{
    public partial class frmAccount : Form
    {
        public int UserID = -1;
        public int UserAccess = -1;
        public int AdminID = -1;
        logHandle myLogHangle = new logHandle();

        private bool validateForm()
        {
            bool check = true;
            int test;
            lbl0.Visible = false;
            lbl1.Visible = false;
            lbl2.Visible = false;
            lbl3.Visible = false;
            lbl4.Visible = false;
            lbl5.Visible = false;
            lbl6.Visible = false;
            lbl7.Visible = false;
            lbl8.Visible = false;
            lbl9.Visible = false;
            lbl10.Visible = false;
            lbl11.Visible = false;
            lbl12.Visible = false;

            if (cmbUserNames.Visible == false)
            {
                if (edtUsername.TextLength < 1)
                {
                    lbl0.Visible = true;
                    check = false;
                }
            }
            if (edtPassword.TextLength < 1)
            {
                lbl1.Visible = true;
                check = false;
            }
            if (cmbAccess.SelectedIndex < 0)
            {
                lbl2.Visible = true;
                check = false;
            }
            if (cmbType.SelectedIndex < 0)
            {
                lbl3.Visible = true;
                check = false;
            }
            if (edtName.TextLength < 1)
            {
                lbl4.Visible = true;
                check = false;
            }
            if (edtSurname.TextLength < 1)
            {
                lbl5.Visible = true;
                check = false;
            }

            if (edtStudentNmr.TextLength > 0)
                if (edtStudentNmr.TextLength < 7)
                {
                    lbl6.Visible = true;
                    check = false;
                }
            if (edtPersonalNumber.TextLength > 0)
                if (edtPersonalNumber.TextLength < 7)
                {
                    lbl7.Visible = true;
                    check = false;
                }
            if (edtIDNumber.TextLength > 0)
                if (edtIDNumber.TextLength != 13)
                {
                    lbl8.Visible = true;
                    check = false;
                }
                else if (!Int32.TryParse((edtIDNumber.Text.Substring(0, 6)), out test) || !Int32.TryParse((edtIDNumber.Text.Substring(6, 7)), out test))
                {
                    lbl8.Visible = true;
                    check = false;
                }
            if (edtCellPhone.TextLength>0)
                if (edtCellPhone.TextLength < 10)
                {
                    lbl9.Visible = true;
                    check = false;
                }
                else if (!Int32.TryParse((edtCellPhone.Text.Substring(0, 5)), out test) || !Int32.TryParse((edtCellPhone.Text.Substring(5, 5)), out test))
                {
                    lbl9.Visible = true;
                    check = false;
                }
            if (edtEmail.TextLength > 0)
            {
                if (!(edtEmail.Text.Contains('@')&&(edtEmail.Text.Contains('.'))))
                {
                    lbl10.Visible = true;
                    check = false;
                }
            }
            if (edtTel.TextLength > 0)
                if (edtTel.TextLength < 10)
                {
                    lbl11.Visible = true;
                    check = false;
                }
                else if (!Int32.TryParse((edtTel.Text.Substring(0, 5)), out test) || !Int32.TryParse((edtTel.Text.Substring(5, 5)), out test))
                {
                    lbl11.Visible = true;
                    check = false;
                }

            return check;
        }

        private void adaptForm(int type)
        {
            //MessageBox.Show("WOW");
            btnSave.Visible = false;
            btnAdd.Visible = false;
            btnDelete.Visible = false;
            cmbUserNames.Visible = false;
            edtUsername.Visible = false;
            if (type == 0)
            {
                //Edits own info (Not admin)
                lblMode.Text = "Own Account Details";
                edtUsername.Visible = true;
                edtUsername.Enabled = false;
                cmbAccess.Enabled = false;
                cmbType.Enabled = false;
                cmbType.Enabled = false;
                edtName.Enabled = false;
                edtSurname.Enabled = false;
                groupBox1.Enabled = true;
                btnSave.Visible = true;
            }
            else if (type == 1)
            {
                //Edits own ifo (Admin)
                lblMode.Text = "Own Account Details";
                edtUsername.Visible = true;
                edtUsername.Enabled = true;
                cmbAccess.Enabled = true;
                cmbType.Enabled = true;
                cmbType.Enabled = true;
                edtName.Enabled = true;
                edtSurname.Enabled = true;
                groupBox1.Enabled = true;
                btnSave.Visible = true;
            }
            else if (type == 2)
            {
                //Edits other from list
                lblMode.Text = "All Account Details";
                cmbUserNames.Visible = true;
                edtUsername.Enabled = true;
                cmbAccess.Enabled = true;
                cmbType.Enabled = true;
                cmbType.Enabled = true;
                edtName.Enabled = true;
                edtSurname.Enabled = true;
                groupBox1.Enabled = true;
                btnSave.Visible = true;
            }
            else if (type == 3)
            {
                //Add user
                lblMode.Text = "Add New User";
                edtUsername.Visible = true;
                edtUsername.Enabled = true;
                cmbAccess.Enabled = true;
                cmbType.Enabled = true;
                cmbType.Enabled = true;
                edtName.Enabled = true;
                edtSurname.Enabled = true;
                groupBox1.Enabled = true;
                btnAdd.Visible = true;
            }
            else if (type == 4)
            {
                lblMode.Text = "Delete User";
                cmbUserNames.Visible = true;
                edtPassword.Enabled = false;
                cmbAccess.Enabled = false;
                cmbType.Enabled = false;
                cmbType.Enabled = false;
                edtName.Enabled = false;
                edtSurname.Enabled = false;
                groupBox1.Enabled = false;
                btnDelete.Visible = true;
            }
        }

        public frmAccount(int admin, int id)
        {
            UserID = admin;
            InitializeComponent();
            User selected = new User(id);
            edtUsername.Text = selected.getUsername();
            edtName.Text = selected.sName;
            edtSurname.Text = selected.sSurname;
            edtPassword.Text = selected.sPassw;
            edtStudentNmr.Text = selected.userContact.sStudNmr;
            edtPersonalNumber.Text = selected.userContact.sPersNmr;

            edtIDNumber.Text = selected.userContact.sID;
            edtCellPhone.Text = selected.userContact.sCell;
            edtEmail.Text = selected.userContact.sEmail;
            edtTel.Text = selected.userContact.sTel;
            edtAddress.Text = selected.userContact.sAddress;

            int iType, iAccess;

            iType = selected.iType;
            iAccess = selected.iAccess;

            if (iAccess == 1)
                cmbAccess.SelectedIndex = 0;
            else
                cmbAccess.SelectedIndex = 1;

            if (iType == 1)
                cmbType.SelectedIndex = 0;
            else if (iType == 2)
                cmbType.SelectedIndex = 1;
            else
                cmbType.SelectedIndex = 2;
            adaptForm(2);
            cmbUserNames.Visible = false;
            edtUsername.Visible = true;

        }

        public frmAccount(int id, int admin, int type, int access)
        {
            //TYPE
            //0: Edit Other, 1: Add new User, 2: Edit Own, 3: Admin chooses other acc to edit directly
            //If admin chooses to edit accounts
            UserID = id;
            UserAccess = access;
            AdminID = admin;

            InitializeComponent();
            if (type == 0)//Edit other
            {
                adaptForm(2);
                bb_userTableAdapter1.FillByNotAdminID(bblabsDataSet.bb_user, AdminID);
                contactTableAdapter1.FillByNotAdminID(bblabsDataSet.contact, AdminID);
            }
            else if (type == 1)//Add new user
            {
                adaptForm(3);
                cmbAccess.SelectedIndex = 0;
                cmbType.SelectedIndex = 0;
            }
            else if (type == 2)
            {
                //If user chooses his own account
                bb_userTableAdapter1.FillByUserID(bblabsDataSet.bb_user, UserID);
                contactTableAdapter1.FillByContactID(bblabsDataSet.contact, UserID);
                if (UserAccess == 1)
                    adaptForm(0);
                else
                    adaptForm(1);
            }
            else if (type == 3)
            {
                //If admin chooses account to edit
                bb_userTableAdapter1.FillByUserID(bblabsDataSet.bb_user, UserID);
                contactTableAdapter1.FillByContactID(bblabsDataSet.contact, UserID);
                adaptForm(2);
            }
            else if (type == 4)
            {
                //If admin chooses account to delete
                bb_userTableAdapter1.FillByNotAdminID(bblabsDataSet.bb_user,AdminID);
                contactTableAdapter1.FillByNotAdminID(bblabsDataSet.contact,AdminID);
                adaptForm(4);
            }
        }

        private void edtAccessLevel_TextChanged(object sender, EventArgs e)
        {
            cmbAccess.SelectedIndex = Int32.Parse(edtAccessLevel.Text)-1;
        }

        private void edtType_TextChanged(object sender, EventArgs e)
        {
            cmbType.SelectedIndex = Int32.Parse(edtType.Text) -1;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int iType, iAccess;
            iType = cmbType.SelectedIndex;
            iAccess = cmbAccess.SelectedIndex;

            bool result = true;
            if (iType == 0)
            {
                if ((edtCellPhone.TextLength != 10)&&(edtEmail.TextLength<3))
                {
                    MessageBox.Show("System user requires a valid cellphone number or email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            else if (iType == 1)
            {
                if ((edtStudentNmr.TextLength < 7) && (edtPersonalNumber.TextLength < 7) && (edtIDNumber.TextLength != 13))
                {
                    MessageBox.Show("Lab user requires either a valid student number, personal number or ID number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
            else if (iType == 2)
            {
                if (((edtStudentNmr.TextLength < 7) && (edtPersonalNumber.TextLength < 7) && (edtIDNumber.TextLength != 13)) && ((edtCellPhone.TextLength != 10) && (edtEmail.TextLength < 3)))
                {
                    MessageBox.Show("System user requires a valid cellphone number or email address\nLab user requires either a valid student number, personal number or ID number\n", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }

            if (result == true && validateForm()==true)
            {
                //CHECK IF USERNAME EXISTS
                bb_userTableAdapter1.FillByUserName(bblabsDataSet1.bb_user, edtUsername.Text);
                if (bblabsDataSet1.bb_user.Rows.Count < 1)
                {
                    //DO THIS
                    String querytString = "INSERT INTO contact (STUDENT_NUMBER,PERSONAL_NUMBER,ID_NUMBER,CELL_PHONE,EMAIL,TEL_NUMBER,ADDRESS) VALUES " +
                                        "('" + edtStudentNmr.Text + "', '" + edtPersonalNumber.Text + "','" + edtIDNumber.Text + "','" + edtCellPhone.Text + "','" + edtEmail.Text + "','" + edtTel.Text + "','" + edtAddress.Text + "')";
                    if (myLogHangle.doQuery(querytString))
                    {
                        querytString = "INSERT INTO bb_user (USERNAME, PASSWORD, ACCESS_LEVEL, TYPE, NAME, SURNAME, STATUS) VALUES " +
                                        "('" + edtUsername.Text + "', '" + edtPassword.Text + "', " + (iAccess + 1) + ", " + (iType + 1) + ", '" + edtName.Text + "', '" + edtSurname.Text + "', 1)";
                        if (myLogHangle.doQuery(querytString))
                        {
                            MessageBox.Show("Successfully added user", "Added User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            myLogHangle.insertChange(AdminID, "Added user: " + edtUsername.Text);
                        }
                        else
                        {
                            MessageBox.Show("Fatal error please check XXXX", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Could not add user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }
                else
                {
                    lbl0.Visible = true;
                    MessageBox.Show("That username exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cmbUserNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            contactTableAdapter1.FillByContactID(bblabsDataSet.contact,(int)cmbUserNames.SelectedValue);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int changeID = -1;
            if (cmbUserNames.Visible == true)
                changeID = (int)cmbUserNames.SelectedValue;
            else
                changeID = UserID;
            if (validateForm() == true)
            {
                int access, type;

                if (cmbAccess.Items[cmbAccess.SelectedIndex].ToString() == "Administrator")
                    access = 2;
                else
                    access = 1;

                if (cmbType.Items[cmbType.SelectedIndex].ToString() == "Syster User")
                    type = 1;
                else if (cmbType.Items[cmbType.SelectedIndex].ToString() == "Lab User")
                    type = 2;
                else type = 3;

                String querytString = "BEGIN TRANSACTION "+
                                       "UPDATE bb_user "+
                                          "SET PASSWORD = '" + edtPassword.Text + "', ACCESS_LEVEL = " + access + ", TYPE = " + type + ", NAME = '" + edtName.Text + "', SURNAME = '" + edtSurname.Text + "' " +
                                        "WHERE USER_ID = " + changeID +
                                        " UPDATE contact "+
                                        "SET STUDENT_NUMBER = '" + edtStudentNmr.Text + "', PERSONAL_NUMBER = '" + edtPersonalNumber.Text + "', ID_NUMBER = '" + edtIDNumber.Text + "', CELL_PHONE = '" + edtCellPhone.Text + "', EMAIL = '" + edtEmail.Text + "', TEL_NUMBER = '" + edtTel.Text + "', ADDRESS = '" + edtAddress.Text + "'"+
                                        "WHERE CONTACT_ID = " + changeID +
                                        " COMMIT";

                if (myLogHangle.doQuery(querytString)==true)
                {
                    if (UserID>0)
                        myLogHangle.insertChange(UserID, "Updated user: " + edtUsername.Text);
                    else
                        myLogHangle.insertChange(AdminID, "Updated user: " + cmbUserNames.GetItemText(cmbUserNames.SelectedItem));
                    MessageBox.Show("Saved", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Could not update user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String querytString = "Update bb_user SET bb_user.STATUS = 0 WHERE USER_ID = " + cmbUserNames.SelectedValue;
                if (myLogHangle.doQuery(querytString))
                    myLogHangle.insertChange(AdminID, "Deleted user: " + cmbUserNames.GetItemText(cmbUserNames.SelectedItem));
                else
                    MessageBox.Show("Could not delete user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCloseAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
