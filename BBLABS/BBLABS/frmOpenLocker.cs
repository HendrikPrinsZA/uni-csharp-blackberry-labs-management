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
    public partial class frmOpenLocker : Form
    {
        Locker thisLocker;
        User Admin;
        Device dChosen;
        Form1 parentForm;

        private bool validate()
        {
            bool temp = true;
            lbl0.Visible = false;
            lbl1.Visible = false;
            if (dateFrom.Value >= dateTo.Value)
            {
                temp = false;
                lbl0.Visible = true;
            }
            if (lstAddedDevices.Items.Count < 1)
            {
                temp = false;
                lbl1.Visible = true;
            }
            return temp;
        }

        public frmOpenLocker(int id,Form1 frm)
        {
            InitializeComponent();

            deviceTableAdapter1.FillAllAvailable(bblabsDataSet1.device);
            bb_userTableAdapter1.FillByLabUsers(bblabsDataSet1.bb_user);
            lockerTableAdapter1.FillAllClosed(bblabsDataSet1.locker);
            if (cmbLockers.Items.Count < 1)
                MessageBox.Show("No lockers available.\n\nAll lockers might be in use\nYou can add new lockers by clicking on the'Add/Edit Lockers' button", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (cmbLabUsers.Items.Count<1)
                MessageBox.Show("No lab users available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (cmbDevices.Items.Count < 1)
                MessageBox.Show("No Devices available.\n\nAll devices seem to be in use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            parentForm = frm;
            Admin = new User(id);
            lblAdmin.Text = Admin.getUsername();
            //thisLocker = new Locker();
            lstAddedDevices.DisplayMember = cmbDevices.DisplayMember;
            lstAddedDevices.ValueMember = cmbDevices.ValueMember;

            if (cmbDevices.SelectedIndex > -1)
            {
                dChosen = new Device((System.Data.DataRowView)cmbDevices.SelectedItem);
                lblDeviceName.Text = dChosen.sName;
                imgDevice.Image = dChosen.myImage.imgImage;
            }
            if (cmbLockers.SelectedIndex > -1)
            {
                thisLocker = new Locker((int)cmbLockers.SelectedValue);
                groupBox1.Enabled = true;
            }
            
        }

        private void fillAllOpenToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.lockerTableAdapter1.FillAllOpen(this.bblabsDataSet1.locker);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void cmbDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbDevices.SelectedIndex > -1)
            {
                dChosen = new Device((System.Data.DataRowView)cmbDevices.SelectedItem);
                lblDeviceName.Text = dChosen.sName;
                imgDevice.Image = dChosen.myImage.imgImage;
            }
        }

        private void btnAddDevice_Click(object sender, EventArgs e)
        {
            if (cmbDevices.SelectedIndex > -1)
            {
                if (lstAddedDevices.Items.Contains(cmbDevices.SelectedItem) == true)
                {
                    MessageBox.Show("Item already added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    lstAddedDevices.Items.Add(cmbDevices.SelectedItem);
                    thisLocker.addDevice(dChosen);
                    btnCheckOut.Enabled = true;
                }
            }
        }

        private void lstAddedDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstAddedDevices.SelectedIndex > -1)
            {
                dChosen = new Device((System.Data.DataRowView)lstAddedDevices.SelectedItem);
                lblDeviceName.Text = dChosen.sName;
                imgDevice.Image = dChosen.myImage.imgImage;
            }
            else
            {
                if (cmbDevices.Items.Count > 0)
                {
                    cmbDevices.SelectedItem = 0;
                    cmbDevices_SelectedIndexChanged(sender, e);
                }
                else
                    dChosen = null;
            }
        }

        private void btnRemoveDevice_Click(object sender, EventArgs e)
        {
            if (lstAddedDevices.SelectedIndex > -1)
            {
                thisLocker.removeDevice(dChosen);
                lstAddedDevices.Items.Remove(lstAddedDevices.SelectedItem);
                if (lstAddedDevices.Items.Count > 0)
                {
                    lstAddedDevices.SelectedIndex = 0;
                    lstAddedDevices_SelectedIndexChanged(sender, e);
                }
            }
        }

        private void cmbLockers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLockers.SelectedIndex > -1)
            {
                thisLocker = new Locker((int)cmbLockers.SelectedValue);
                groupBox1.Enabled = true;
            }
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                thisLocker.setValues(Admin, new User((int)cmbLabUsers.SelectedValue), 2, dateFrom.Value, dateTo.Value);
                if (thisLocker.checkout())
                {
                    logHandle myLog = new logHandle();
                    myLog.insertChange(Admin.recordID, "Checked out devices for lab user: " + (new User((int)cmbLabUsers.SelectedValue).getUsername()));
                    parentForm.updateLockers();
                    this.Close();
                }
                else
                    MessageBox.Show("Could not perform checkout", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
