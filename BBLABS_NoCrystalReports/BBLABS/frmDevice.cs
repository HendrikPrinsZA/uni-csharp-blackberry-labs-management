using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using System.Data.SqlClient;

namespace BBLABS
{
    public partial class frmDevice : Form
    {
        logHandle myLogHangle = new logHandle();
        Device myDevice;
        Form1 parentForm;
        int UserID = -1;

        Random random = new Random();

        int iCat;
        bool checkPicChange;

        public frmDevice(int id, Form1 par)
        {
            iCat = 1;
            InitializeComponent();
            parentForm = par;
            UserID = id;
            myDevice = null;

            btnAdd.Visible = true;
            btnSave.Visible = false;
        }

        public frmDevice(int id, Device device, Form1 par)
        {
            myDevice = device;
            parentForm = par;
            UserID = id;
            InitializeComponent();
            btnAdd.Visible = false;
            btnSave.Visible = true;
            if (device.myImage.recordID > 0)
            {
                imgDevice.Image = device.myImage.imgImage;
                if (imgDevice.Image.Tag != null)
                    txtCaption.Text = (string)imgDevice.Image.Tag;
            }
            txtTel.Text = myDevice.sTel;
            txtIMIE.Text = myDevice.sIMIE;
            txtName.Text = myDevice.sName;
            txtSerial.Text = myDevice.sSerial;
            txtPin.Text = myDevice.sPin;
            txtEmail.Text = myDevice.sEmail;
            txtPassword.Text = myDevice.sPassw;
            txtModel.Text = myDevice.sModel;
            if (myDevice.iCategory == 1)
            {
                iCat = 1;
                rdbPhone.Checked = true;
            }
            else if (myDevice.iCategory == 2)
            {
                iCat = 2;
                rdbTablet.Checked = true;
            }
            else
            {
                iCat = 3;
                rdbOther.Checked = true;
            }
        }

        bool validateForm()
        {
            bool temp = true;
            lbl1.Visible = false;
            lbl3.Visible = false;
            lbl15.Visible = false;
            lbl8.Visible = false;
            if (txtName.TextLength < 1)
            {
                lbl1.Visible = true;
                temp = false;
            }

            if (txtEmail.TextLength > 0)
            {
                if (!(txtEmail.Text.Contains('@') && (txtEmail.Text.Contains('.'))))
                {
                    lbl3.Visible = true;
                    temp = false;
                }
            }
            int test;

            if (txtTel.TextLength > 0)
                if (txtTel.TextLength < 10)
                {
                    lbl15.Visible = true;
                    temp = false;
                }
                else if (!Int32.TryParse((txtTel.Text.Substring(0, 5)), out test) || !Int32.TryParse((txtTel.Text.Substring(5, 5)), out test))
                {
                    lbl15.Visible = true;
                    temp = false;
                }
            if (txtFilename.TextLength > 0)
                if (!File.Exists(txtFilename.Text))
                {
                    lbl8.Visible = true;
                    temp = false;
                }
            return temp;
        }

        private void textBox9_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Find Image";
            //dlg.Filter = "JPEG (*.jpg)|*.jpg";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtFilename.Text = dlg.FileName;
                imgDevice.ImageLocation = txtFilename.Text;
                string temp;
                temp = txtFilename.Text;
                temp = temp.Remove(0,temp.LastIndexOf(@"\")+1);
                temp = temp.Remove(temp.LastIndexOf('.'));
                txtCaption.Text = temp;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                int imgID = -1;
                if (txtFilename.TextLength > 0)
                {
                    imgID = myLogHangle.insertImage(@txtFilename.Text, txtCaption.Text);
                }

                string sIMIE = txtIMIE.Text,
                    sName = txtName.Text,
                    sSerial = txtSerial.Text,
                    sPin = txtPin.Text,
                    sEmail = txtEmail.Text,
                    sPass = txtPassword.Text,
                    sModel = txtModel.Text,
                    sTel = txtTel.Text;

                String querytString = "";
                if (imgID == -1)
                {
                    querytString = "INSERT INTO device (CATEGORY,IMIE_NUMBER,DEVICE_TEL,DEVICE_NAME,SERIAL,DEVICE_PIN,DEVICE_EMAIL,DEVICE_PASSWORD,MODEL_NUMBER,DATE_ADDED) VALUES " +
                                        "(" + iCat + ",'" + sIMIE + "','" + sTel + "','" + sName + "','" + sSerial + "','" + sPin + "','" + sEmail + "','" + sPass + "','" + sModel + ",'" + DateTime.Now.ToString() + "')";
                } else
                    querytString = "INSERT INTO device (CATEGORY,IMIE_NUMBER,DEVICE_TEL,DEVICE_NAME,SERIAL,DEVICE_PIN,DEVICE_EMAIL,DEVICE_PASSWORD,MODEL_NUMBER,BLOBID,DATE_ADDED) VALUES " +
                                        "(" + iCat + ",'" + sIMIE + "','" + sTel + "','" + sName + "','" + sSerial + "','" + sPin + "','" + sEmail + "','" + sPass + "','" + sModel + "'," + imgID + ",'" + DateTime.Now.ToString() + "')";
                
                if (myLogHangle.doQuery(querytString))
                {
                    myLogHangle.insertChange(UserID, "Added device " + sName,sIMIE);
                    MessageBox.Show("Device added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentForm.updateDevices();
                    //this.Close();
                } else
                    MessageBox.Show("Could not add Device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdbPhone_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbPhone.Checked == true)
                iCat = 1;
        }

        private void rdbTablet_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTablet.Checked == true)
                iCat = 2;
        }

        private void rdbOther_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOther.Checked == true)
                iCat = 3;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (validateForm())
            {
                string sIMIE = txtIMIE.Text,
                        sName = txtName.Text,
                        sSerial = txtSerial.Text,
                        sPin = txtPin.Text,
                        sEmail = txtEmail.Text,
                        sPass = txtPassword.Text,
                        sModel = txtModel.Text,
                        sTel = txtTel.Text;
                int imgID = -1;
                int prevImgID = -1;
                bool insertedNewImage = false;
                //
                string querytString;
                if (checkPicChange == true)
                {
                    if (myDevice.iBlobID > 0)
                    {
                        prevImgID = myDevice.iBlobID;
                    }
                    if (txtFilename.TextLength > 0)
                    {
                        imgID = myLogHangle.insertImage(@txtFilename.Text, txtCaption.Text);
                    }
                }

                if (imgID > 0)
                {
                    querytString = "UPDATE device SET CATEGORY=" + iCat + ",IMIE_NUMBER='" + sIMIE + "',DEVICE_NAME='" + sName + "',SERIAL='" + sSerial + "',DEVICE_PIN='" + sPin + "',DEVICE_EMAIL='" + sEmail + "',DEVICE_PASSWORD='" + sPass + "',DEVICE_TEL='" + sTel + "',MODEL_NUMBER='" + sModel + "',BLOBID=" + imgID + " " +
                                       "WHERE DEVICE_ID=" + myDevice.recordID;
                    insertedNewImage = true;
                }
                else
                    querytString = "UPDATE device SET CATEGORY=" + iCat + ",IMIE_NUMBER='" + sIMIE + "',DEVICE_NAME='" + sName + "',SERIAL='" + sSerial + "',DEVICE_PIN='" + sPin + "',DEVICE_EMAIL='" + sEmail + "',DEVICE_PASSWORD='" + sPass + "',DEVICE_TEL='" + sTel + "',MODEL_NUMBER='" + sModel + "'" +
                                       "WHERE DEVICE_ID=" + myDevice.recordID;
                if (myLogHangle.doQuery(querytString))
                {
                    if (prevImgID > 0 && insertedNewImage == true)
                    {
                        querytString = "DELETE FROM tblBLOB WHERE BLOBID = " + prevImgID;
                        myLogHangle.doQuery(querytString);
                    }
                    myLogHangle.insertChange(UserID, "Updated device: " + sName, sIMIE);
                    MessageBox.Show("Device updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    parentForm.updateDevices();
                    this.Close();
                }
                else
                    MessageBox.Show("Could not update device", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void imgDevice_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
            checkPicChange = true;
        }

        private void frmDevice_Load(object sender, EventArgs e)
        {

        }

        private void txtFilename_TextChanged(object sender, EventArgs e)
        {

        }

        private string RandomString(int size, int iCase)
        {
            StringBuilder builder = new StringBuilder();
            //Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (iCase == 1)
                return builder.ToString().ToLower();
            else if (iCase == 2)
                return builder.ToString().ToUpper();
            return builder.ToString();
        }

        public string GetPassword()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomString(4, 2));
            builder.Append(random.Next(1000, 9999));
            builder.Append(RandomString(2, 2));
            return builder.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string temp = "082";

            for (int i = 0; i < 7; i++)
                temp += random.Next(0, 9).ToString();
            txtTel.Text = temp;

            txtEmail.Text = txtName.Text.ToLower();
            txtEmail.Text = txtEmail.Text.Replace(" ", "");
            txtEmail.Text += "@bb.co.za";
            txtEmail.Text = txtEmail.Text.Replace("™","");

            temp = "";
            for (int i = 0; i < 6; i++)
                temp += random.Next(0, 9).ToString();
            temp += RandomString(2, 2);
            txtPin.Text = temp;
            txtPassword.Text = GetPassword();

            temp = "";
            for (int i = 0; i < 15; i++)
                temp += random.Next(0, 9).ToString();
            txtIMIE.Text = temp;

            temp = "";
            temp += RandomString(1, 2);
            temp += random.Next(0, 9).ToString();
            temp += RandomString(4, 2);
            temp += random.Next(0, 9).ToString();
            temp += random.Next(0, 9).ToString();
            temp += RandomString(2, 2);
            txtSerial.Text = temp;

            temp = txtName.Text;

            txtModel.Text = txtName.Text.Substring(txtName.Text.IndexOf("™") + 2);

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string sourceDir = @"E:\Personal\Universiteit\3de Jaar\Sem 2\INF 272\Project\NewImages\phones\";
            string[] fileEntries = Directory.GetFiles(sourceDir);
            string filename = fileEntries[0];
            int size = fileEntries.Length;
            for (int i = 0; i < size; i++)
            {
                txtFilename.Text = fileEntries[i];
                imgDevice.ImageLocation = txtFilename.Text;
                string temp;
                temp = txtFilename.Text;
                temp = temp.Remove(0, temp.LastIndexOf(@"\") + 1);
                temp = temp.Remove(temp.LastIndexOf('.'));
                txtCaption.Text = temp;
                txtName.Text = temp.Insert(temp.IndexOf(" "), "™");
                button1_Click(sender, e);
                btnAdd_Click(sender, e);
            }
        }


    }
}
