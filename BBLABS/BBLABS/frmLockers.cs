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
    public partial class frmLockers : Form
    {
        Locker lockItem;
        int AdminID;
        public frmLockers(int adminID)
        {
            InitializeComponent();
            lockerTableAdapter2.Fill(bblabsDataSet1.locker);
            AdminID = adminID;
        }

        private bool validate()
        {
            lbl0.Visible = false;
            if (txtLockerName.TextLength < 1)
            {
                lbl0.Visible = true;
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtLockerName.Text = "";
            lblLockerStatus.Text = "Open";
            btnAddNew.Visible = true;
            btnSave.Visible = false;
        }

        private void lstLockers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstLockers.SelectedIndex > -1)
            {
                btnAddNew.Visible = false;
                btnSave.Visible = true;
                lockItem = new Locker((int)lstLockers.SelectedValue);
                txtLockerName.Text = lockItem.getName();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (txtLockerName.TextLength > 0)
            {
                string querytString = "INSERT INTO locker (LOCKER_NAME,LOCKER_STATUS) VALUES " +
                                        "('" + txtLockerName.Text + "',1)";
                logHandle myLogHandle = new logHandle();
                if (myLogHandle.doQuery(querytString))
                {
                    myLogHandle.insertChange(AdminID, "Added new locker " + txtLockerName.Text);
                    lockerTableAdapter2.Fill(bblabsDataSet1.locker);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lstLockers.SelectedIndex > -1)
            {
                if (validate())
                    if (txtLockerName.TextLength > 0)
                    {
                       if (lockItem.update(AdminID, txtLockerName.Text))
                           lockerTableAdapter2.Fill(bblabsDataSet1.locker);
                    }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Code this");
        }
    }
}
