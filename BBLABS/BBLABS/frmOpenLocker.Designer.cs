namespace BBLABS
{
    partial class frmOpenLocker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOpenLocker));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbLabUsers = new System.Windows.Forms.ComboBox();
            this.bblabsDataSet1 = new BBLABS.BBLABSDataSet();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.btnRemoveDevice = new System.Windows.Forms.Button();
            this.imgDevice = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbDevices = new System.Windows.Forms.ComboBox();
            this.lstAddedDevices = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bb_userTableAdapter1 = new BBLABS.BBLABSDataSetTableAdapters.bb_userTableAdapter();
            this.deviceTableAdapter1 = new BBLABS.BBLABSDataSetTableAdapters.deviceTableAdapter();
            this.cmbLockers = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lockerTableAdapter1 = new BBLABS.BBLABSDataSetTableAdapters.lockerTableAdapter();
            this.lbl0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(20, 435);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Enabled = false;
            this.btnCheckOut.Location = new System.Drawing.Point(178, 435);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(249, 23);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Checkout";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(88, 57);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(89, 20);
            this.dateFrom.TabIndex = 2;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(338, 57);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(89, 20);
            this.dateTo.TabIndex = 3;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Location = new System.Drawing.Point(85, 20);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(73, 13);
            this.lblAdmin.TabIndex = 5;
            this.lblAdmin.Text = "PersonIssuing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Admin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Lab User";
            // 
            // cmbLabUsers
            // 
            this.cmbLabUsers.DataSource = this.bblabsDataSet1;
            this.cmbLabUsers.DisplayMember = "bb_user.USERNAME";
            this.cmbLabUsers.FormattingEnabled = true;
            this.cmbLabUsers.Location = new System.Drawing.Point(88, 83);
            this.cmbLabUsers.Name = "cmbLabUsers";
            this.cmbLabUsers.Size = new System.Drawing.Size(89, 21);
            this.cmbLabUsers.TabIndex = 8;
            this.cmbLabUsers.ValueMember = "bb_user.USER_ID";
            // 
            // bblabsDataSet1
            // 
            this.bblabsDataSet1.DataSetName = "BBLABSDataSet";
            this.bblabsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl1);
            this.groupBox1.Controls.Add(this.lblDeviceName);
            this.groupBox1.Controls.Add(this.btnAddDevice);
            this.groupBox1.Controls.Add(this.btnRemoveDevice);
            this.groupBox1.Controls.Add(this.imgDevice);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbDevices);
            this.groupBox1.Controls.Add(this.lstAddedDevices);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(20, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 319);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Devices in locker";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(141, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 39;
            this.lbl1.Text = "!";
            this.lbl1.Visible = false;
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Location = new System.Drawing.Point(155, 22);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(69, 13);
            this.lblDeviceName.TabIndex = 14;
            this.lblDeviceName.Text = "DeviceName";
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(15, 65);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(120, 23);
            this.btnAddDevice.TabIndex = 13;
            this.btnAddDevice.Text = "Add Device";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            this.btnAddDevice.Click += new System.EventHandler(this.btnAddDevice_Click);
            // 
            // btnRemoveDevice
            // 
            this.btnRemoveDevice.Location = new System.Drawing.Point(15, 280);
            this.btnRemoveDevice.Name = "btnRemoveDevice";
            this.btnRemoveDevice.Size = new System.Drawing.Size(120, 23);
            this.btnRemoveDevice.TabIndex = 12;
            this.btnRemoveDevice.Text = "Remove Device";
            this.btnRemoveDevice.UseVisualStyleBackColor = true;
            this.btnRemoveDevice.Click += new System.EventHandler(this.btnRemoveDevice_Click);
            // 
            // imgDevice
            // 
            this.imgDevice.Image = ((System.Drawing.Image)(resources.GetObject("imgDevice.Image")));
            this.imgDevice.Location = new System.Drawing.Point(158, 38);
            this.imgDevice.Name = "imgDevice";
            this.imgDevice.Size = new System.Drawing.Size(230, 265);
            this.imgDevice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDevice.TabIndex = 11;
            this.imgDevice.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Choose Device to Add";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Devices to check out";
            // 
            // cmbDevices
            // 
            this.cmbDevices.DataSource = this.bblabsDataSet1;
            this.cmbDevices.DisplayMember = "device.DEVICE_NAME";
            this.cmbDevices.FormattingEnabled = true;
            this.cmbDevices.Location = new System.Drawing.Point(15, 38);
            this.cmbDevices.Name = "cmbDevices";
            this.cmbDevices.Size = new System.Drawing.Size(120, 21);
            this.cmbDevices.TabIndex = 1;
            this.cmbDevices.SelectedIndexChanged += new System.EventHandler(this.cmbDevices_SelectedIndexChanged);
            // 
            // lstAddedDevices
            // 
            this.lstAddedDevices.DisplayMember = "DEVICE_ID";
            this.lstAddedDevices.FormattingEnabled = true;
            this.lstAddedDevices.Location = new System.Drawing.Point(15, 119);
            this.lstAddedDevices.Name = "lstAddedDevices";
            this.lstAddedDevices.Size = new System.Drawing.Size(120, 160);
            this.lstAddedDevices.TabIndex = 0;
            this.lstAddedDevices.ValueMember = "DEVICE_ID";
            this.lstAddedDevices.SelectedIndexChanged += new System.EventHandler(this.lstAddedDevices_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(268, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "To";
            // 
            // bb_userTableAdapter1
            // 
            this.bb_userTableAdapter1.ClearBeforeFill = true;
            // 
            // deviceTableAdapter1
            // 
            this.deviceTableAdapter1.ClearBeforeFill = true;
            // 
            // cmbLockers
            // 
            this.cmbLockers.DataSource = this.bblabsDataSet1;
            this.cmbLockers.DisplayMember = "locker.LOCKER_NAME";
            this.cmbLockers.FormattingEnabled = true;
            this.cmbLockers.Location = new System.Drawing.Point(338, 83);
            this.cmbLockers.Name = "cmbLockers";
            this.cmbLockers.Size = new System.Drawing.Size(89, 21);
            this.cmbLockers.TabIndex = 13;
            this.cmbLockers.ValueMember = "locker.LOCKER_ID";
            this.cmbLockers.SelectedIndexChanged += new System.EventHandler(this.cmbLockers_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(267, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Locker";
            // 
            // lockerTableAdapter1
            // 
            this.lockerTableAdapter1.ClearBeforeFill = true;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl0.ForeColor = System.Drawing.Color.Red;
            this.lbl0.Location = new System.Drawing.Point(430, 63);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(10, 13);
            this.lbl0.TabIndex = 38;
            this.lbl0.Text = "!";
            this.lbl0.Visible = false;
            // 
            // frmOpenLocker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 480);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.cmbLockers);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLabUsers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblAdmin);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnCancel);
            this.Name = "frmOpenLocker";
            this.Text = "Device Checkout";
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgDevice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbLabUsers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.Button btnRemoveDevice;
        private System.Windows.Forms.PictureBox imgDevice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDevices;
        private System.Windows.Forms.ListBox lstAddedDevices;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BBLABSDataSet bblabsDataSet1;
        private BBLABSDataSetTableAdapters.bb_userTableAdapter bb_userTableAdapter1;
        private BBLABSDataSetTableAdapters.deviceTableAdapter deviceTableAdapter1;
        private System.Windows.Forms.ComboBox cmbLockers;
        private System.Windows.Forms.Label label8;
        private BBLABSDataSetTableAdapters.lockerTableAdapter lockerTableAdapter1;
        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl0;
    }
}