namespace BBLABS
{
    partial class frmDevice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.imgDevice = new System.Windows.Forms.PictureBox();
            this.grpCat = new System.Windows.Forms.GroupBox();
            this.rdbOther = new System.Windows.Forms.RadioButton();
            this.rdbTablet = new System.Windows.Forms.RadioButton();
            this.rdbPhone = new System.Windows.Forms.RadioButton();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIMIE = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCaption = new System.Windows.Forms.TextBox();
            this.grpImage = new System.Windows.Forms.GroupBox();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl15 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).BeginInit();
            this.grpCat.SuspendLayout();
            this.grpImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // imgDevice
            // 
            this.imgDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.imgDevice.Location = new System.Drawing.Point(6, 14);
            this.imgDevice.Name = "imgDevice";
            this.imgDevice.Size = new System.Drawing.Size(208, 237);
            this.imgDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDevice.TabIndex = 5;
            this.imgDevice.TabStop = false;
            this.imgDevice.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgDevice_LoadCompleted);
            // 
            // grpCat
            // 
            this.grpCat.Controls.Add(this.rdbOther);
            this.grpCat.Controls.Add(this.rdbTablet);
            this.grpCat.Controls.Add(this.rdbPhone);
            this.grpCat.ForeColor = System.Drawing.Color.Black;
            this.grpCat.Location = new System.Drawing.Point(12, 79);
            this.grpCat.Name = "grpCat";
            this.grpCat.Size = new System.Drawing.Size(303, 53);
            this.grpCat.TabIndex = 1;
            this.grpCat.TabStop = false;
            this.grpCat.Text = "Category";
            // 
            // rdbOther
            // 
            this.rdbOther.AutoSize = true;
            this.rdbOther.Location = new System.Drawing.Point(204, 19);
            this.rdbOther.Name = "rdbOther";
            this.rdbOther.Size = new System.Drawing.Size(51, 17);
            this.rdbOther.TabIndex = 2;
            this.rdbOther.Text = "Other";
            this.rdbOther.UseVisualStyleBackColor = true;
            this.rdbOther.CheckedChanged += new System.EventHandler(this.rdbOther_CheckedChanged);
            // 
            // rdbTablet
            // 
            this.rdbTablet.AutoSize = true;
            this.rdbTablet.Location = new System.Drawing.Point(111, 19);
            this.rdbTablet.Name = "rdbTablet";
            this.rdbTablet.Size = new System.Drawing.Size(55, 17);
            this.rdbTablet.TabIndex = 1;
            this.rdbTablet.Text = "Tablet";
            this.rdbTablet.UseVisualStyleBackColor = true;
            this.rdbTablet.CheckedChanged += new System.EventHandler(this.rdbTablet_CheckedChanged);
            // 
            // rdbPhone
            // 
            this.rdbPhone.AutoSize = true;
            this.rdbPhone.Checked = true;
            this.rdbPhone.Location = new System.Drawing.Point(16, 19);
            this.rdbPhone.Name = "rdbPhone";
            this.rdbPhone.Size = new System.Drawing.Size(56, 17);
            this.rdbPhone.TabIndex = 0;
            this.rdbPhone.TabStop = true;
            this.rdbPhone.Text = "Phone";
            this.rdbPhone.UseVisualStyleBackColor = true;
            this.rdbPhone.CheckedChanged += new System.EventHandler(this.rdbPhone_CheckedChanged);
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(112, 225);
            this.txtPin.MaxLength = 30;
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(183, 20);
            this.txtPin.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(112, 46);
            this.txtName.MaxLength = 30;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(183, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtIMIE
            // 
            this.txtIMIE.Location = new System.Drawing.Point(112, 277);
            this.txtIMIE.MaxLength = 30;
            this.txtIMIE.Name = "txtIMIE";
            this.txtIMIE.Size = new System.Drawing.Size(183, 20);
            this.txtIMIE.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 199);
            this.txtEmail.MaxLength = 30;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(183, 20);
            this.txtEmail.TabIndex = 3;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(112, 173);
            this.txtModel.MaxLength = 30;
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(183, 20);
            this.txtModel.TabIndex = 2;
            // 
            // txtSerial
            // 
            this.txtSerial.Location = new System.Drawing.Point(112, 303);
            this.txtSerial.MaxLength = 30;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(183, 20);
            this.txtSerial.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Model Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Device Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Device Pin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Serial Number";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "IMIE Number";
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(15, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(100, 20);
            this.lblHeading.TabIndex = 23;
            this.lblHeading.Text = "Add Device";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Device Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 251);
            this.txtPassword.MaxLength = 30;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(183, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Caption";
            // 
            // txtCaption
            // 
            this.txtCaption.Location = new System.Drawing.Point(64, 280);
            this.txtCaption.MaxLength = 30;
            this.txtCaption.Name = "txtCaption";
            this.txtCaption.Size = new System.Drawing.Size(124, 20);
            this.txtCaption.TabIndex = 9;
            // 
            // grpImage
            // 
            this.grpImage.Controls.Add(this.lbl8);
            this.grpImage.Controls.Add(this.label9);
            this.grpImage.Controls.Add(this.txtFilename);
            this.grpImage.Controls.Add(this.imgDevice);
            this.grpImage.Controls.Add(this.label8);
            this.grpImage.Controls.Add(this.txtCaption);
            this.grpImage.Location = new System.Drawing.Point(331, 16);
            this.grpImage.Name = "grpImage";
            this.grpImage.Size = new System.Drawing.Size(220, 307);
            this.grpImage.TabIndex = 8;
            this.grpImage.TabStop = false;
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl8.ForeColor = System.Drawing.Color.Red;
            this.lbl8.Location = new System.Drawing.Point(194, 260);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(10, 13);
            this.lbl8.TabIndex = 38;
            this.lbl8.Text = "!";
            this.lbl8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Filename";
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(64, 257);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.Size = new System.Drawing.Size(124, 20);
            this.txtFilename.TabIndex = 8;
            this.txtFilename.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox9_MouseClick);
            this.txtFilename.TextChanged += new System.EventHandler(this.txtFilename_TextChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(19, 349);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(146, 349);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(405, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add Device";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(305, 49);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 31;
            this.lbl1.Text = "!";
            this.lbl1.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(306, 202);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(10, 13);
            this.lbl3.TabIndex = 33;
            this.lbl3.Text = "!";
            this.lbl3.Visible = false;
            // 
            // lbl15
            // 
            this.lbl15.AutoSize = true;
            this.lbl15.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl15.ForeColor = System.Drawing.Color.Red;
            this.lbl15.Location = new System.Drawing.Point(306, 150);
            this.lbl15.Name = "lbl15";
            this.lbl15.Size = new System.Drawing.Size(10, 13);
            this.lbl15.TabIndex = 37;
            this.lbl15.Text = "!";
            this.lbl15.Visible = false;
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(146, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(405, 23);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save Device";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Tel Number";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(112, 147);
            this.txtTel.MaxLength = 30;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(183, 20);
            this.txtTel.TabIndex = 2;
            // 
            // frmDevice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(563, 384);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lbl15);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpImage);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtIMIE);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.grpCat);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frmDevice";
            this.Text = "frmDevice";
            this.Load += new System.EventHandler(this.frmDevice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).EndInit();
            this.grpCat.ResumeLayout(false);
            this.grpCat.PerformLayout();
            this.grpImage.ResumeLayout(false);
            this.grpImage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgDevice;
        private System.Windows.Forms.GroupBox grpCat;
        private System.Windows.Forms.RadioButton rdbOther;
        private System.Windows.Forms.RadioButton rdbTablet;
        private System.Windows.Forms.RadioButton rdbPhone;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIMIE;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCaption;
        private System.Windows.Forms.GroupBox grpImage;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl15;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTel;
    }
}