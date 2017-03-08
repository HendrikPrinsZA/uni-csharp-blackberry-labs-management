namespace BBLABS
{
    partial class frmAccount
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl12 = new System.Windows.Forms.Label();
            this.edtAddress = new System.Windows.Forms.TextBox();
            this.bblabsDataSet = new BBLABS.BBLABSDataSet();
            this.lbl11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbl9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.edtTel = new System.Windows.Forms.TextBox();
            this.edtEmail = new System.Windows.Forms.TextBox();
            this.edtCellPhone = new System.Windows.Forms.TextBox();
            this.edtIDNumber = new System.Windows.Forms.TextBox();
            this.edtPersonalNumber = new System.Windows.Forms.TextBox();
            this.edtStudentNmr = new System.Windows.Forms.TextBox();
            this.edtUsername = new System.Windows.Forms.TextBox();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.edtAccessLevel = new System.Windows.Forms.TextBox();
            this.edtType = new System.Windows.Forms.TextBox();
            this.edtName = new System.Windows.Forms.TextBox();
            this.edtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bb_userTableAdapter1 = new BBLABS.BBLABSDataSetTableAdapters.bb_userTableAdapter();
            this.contactTableAdapter1 = new BBLABS.BBLABSDataSetTableAdapters.contactTableAdapter();
            this.lblMode = new System.Windows.Forms.Label();
            this.cmbAccess = new System.Windows.Forms.ComboBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCloseAccount = new System.Windows.Forms.Button();
            this.cmbUserNames = new System.Windows.Forms.ComboBox();
            this.bb_userTableAdapter2 = new BBLABS.BBLABSDataSetTableAdapters.bb_userTableAdapter();
            this.bblabsDataSet1 = new BBLABS.BBLABSDataSet();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lbl0 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.lbl12);
            this.groupBox1.Controls.Add(this.edtAddress);
            this.groupBox1.Controls.Add(this.lbl11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbl10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lbl9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lbl8);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lbl7);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lbl6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.edtTel);
            this.groupBox1.Controls.Add(this.edtEmail);
            this.groupBox1.Controls.Add(this.edtCellPhone);
            this.groupBox1.Controls.Add(this.edtIDNumber);
            this.groupBox1.Controls.Add(this.edtPersonalNumber);
            this.groupBox1.Controls.Add(this.edtStudentNmr);
            this.groupBox1.Location = new System.Drawing.Point(19, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 231);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contact Information";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(22, 192);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Address";
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl12.ForeColor = System.Drawing.Color.Red;
            this.lbl12.Location = new System.Drawing.Point(275, 192);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(10, 13);
            this.lbl12.TabIndex = 34;
            this.lbl12.Text = "!";
            this.lbl12.Visible = false;
            // 
            // edtAddress
            // 
            this.edtAddress.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.ADDRESS", true));
            this.edtAddress.Location = new System.Drawing.Point(137, 189);
            this.edtAddress.MaxLength = 10;
            this.edtAddress.Name = "edtAddress";
            this.edtAddress.Size = new System.Drawing.Size(132, 20);
            this.edtAddress.TabIndex = 13;
            // 
            // bblabsDataSet
            // 
            this.bblabsDataSet.DataSetName = "BBLABSDataSet";
            this.bblabsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl11.ForeColor = System.Drawing.Color.Red;
            this.lbl11.Location = new System.Drawing.Point(275, 166);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(10, 13);
            this.lbl11.TabIndex = 33;
            this.lbl11.Text = "!";
            this.lbl11.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 25;
            this.label8.Text = "Tel Number";
            // 
            // lbl10
            // 
            this.lbl10.AutoSize = true;
            this.lbl10.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl10.ForeColor = System.Drawing.Color.Red;
            this.lbl10.Location = new System.Drawing.Point(275, 140);
            this.lbl10.Name = "lbl10";
            this.lbl10.Size = new System.Drawing.Size(10, 13);
            this.lbl10.TabIndex = 32;
            this.lbl10.Text = "!";
            this.lbl10.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Email";
            // 
            // lbl9
            // 
            this.lbl9.AutoSize = true;
            this.lbl9.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl9.ForeColor = System.Drawing.Color.Red;
            this.lbl9.Location = new System.Drawing.Point(275, 114);
            this.lbl9.Name = "lbl9";
            this.lbl9.Size = new System.Drawing.Size(10, 13);
            this.lbl9.TabIndex = 31;
            this.lbl9.Text = "!";
            this.lbl9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Cell Phone";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl8.ForeColor = System.Drawing.Color.Red;
            this.lbl8.Location = new System.Drawing.Point(275, 88);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(10, 13);
            this.lbl8.TabIndex = 30;
            this.lbl8.Text = "!";
            this.lbl8.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "ID Number";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl7.ForeColor = System.Drawing.Color.Red;
            this.lbl7.Location = new System.Drawing.Point(275, 62);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(10, 13);
            this.lbl7.TabIndex = 29;
            this.lbl7.Text = "!";
            this.lbl7.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 62);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Personal Number";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl6.ForeColor = System.Drawing.Color.Red;
            this.lbl6.Location = new System.Drawing.Point(275, 36);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(10, 13);
            this.lbl6.TabIndex = 28;
            this.lbl6.Text = "!";
            this.lbl6.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(22, 36);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Student Number";
            // 
            // edtTel
            // 
            this.edtTel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.TEL_NUMBER", true));
            this.edtTel.Location = new System.Drawing.Point(137, 163);
            this.edtTel.MaxLength = 10;
            this.edtTel.Name = "edtTel";
            this.edtTel.Size = new System.Drawing.Size(132, 20);
            this.edtTel.TabIndex = 12;
            // 
            // edtEmail
            // 
            this.edtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.EMAIL", true));
            this.edtEmail.Location = new System.Drawing.Point(137, 137);
            this.edtEmail.MaxLength = 40;
            this.edtEmail.Name = "edtEmail";
            this.edtEmail.Size = new System.Drawing.Size(132, 20);
            this.edtEmail.TabIndex = 11;
            // 
            // edtCellPhone
            // 
            this.edtCellPhone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.CELL_PHONE", true));
            this.edtCellPhone.Location = new System.Drawing.Point(137, 111);
            this.edtCellPhone.MaxLength = 10;
            this.edtCellPhone.Name = "edtCellPhone";
            this.edtCellPhone.Size = new System.Drawing.Size(132, 20);
            this.edtCellPhone.TabIndex = 10;
            // 
            // edtIDNumber
            // 
            this.edtIDNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.ID_NUMBER", true));
            this.edtIDNumber.Location = new System.Drawing.Point(137, 85);
            this.edtIDNumber.MaxLength = 13;
            this.edtIDNumber.Name = "edtIDNumber";
            this.edtIDNumber.Size = new System.Drawing.Size(132, 20);
            this.edtIDNumber.TabIndex = 9;
            // 
            // edtPersonalNumber
            // 
            this.edtPersonalNumber.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.PERSONAL_NUMBER", true));
            this.edtPersonalNumber.Location = new System.Drawing.Point(137, 59);
            this.edtPersonalNumber.MaxLength = 13;
            this.edtPersonalNumber.Name = "edtPersonalNumber";
            this.edtPersonalNumber.Size = new System.Drawing.Size(132, 20);
            this.edtPersonalNumber.TabIndex = 8;
            // 
            // edtStudentNmr
            // 
            this.edtStudentNmr.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "contact.STUDENT_NUMBER", true));
            this.edtStudentNmr.Location = new System.Drawing.Point(137, 33);
            this.edtStudentNmr.MaxLength = 8;
            this.edtStudentNmr.Name = "edtStudentNmr";
            this.edtStudentNmr.Size = new System.Drawing.Size(132, 20);
            this.edtStudentNmr.TabIndex = 7;
            // 
            // edtUsername
            // 
            this.edtUsername.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.USERNAME", true));
            this.edtUsername.Location = new System.Drawing.Point(156, 53);
            this.edtUsername.MaxLength = 30;
            this.edtUsername.Name = "edtUsername";
            this.edtUsername.Size = new System.Drawing.Size(132, 20);
            this.edtUsername.TabIndex = 0;
            // 
            // edtPassword
            // 
            this.edtPassword.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.PASSWORD", true));
            this.edtPassword.Location = new System.Drawing.Point(156, 79);
            this.edtPassword.MaxLength = 20;
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(132, 20);
            this.edtPassword.TabIndex = 1;
            // 
            // edtAccessLevel
            // 
            this.edtAccessLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.ACCESS_LEVEL", true));
            this.edtAccessLevel.Location = new System.Drawing.Point(253, 105);
            this.edtAccessLevel.Name = "edtAccessLevel";
            this.edtAccessLevel.Size = new System.Drawing.Size(35, 20);
            this.edtAccessLevel.TabIndex = 3;
            this.edtAccessLevel.Visible = false;
            this.edtAccessLevel.TextChanged += new System.EventHandler(this.edtAccessLevel_TextChanged);
            // 
            // edtType
            // 
            this.edtType.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.TYPE", true));
            this.edtType.Location = new System.Drawing.Point(253, 131);
            this.edtType.Name = "edtType";
            this.edtType.Size = new System.Drawing.Size(35, 20);
            this.edtType.TabIndex = 4;
            this.edtType.Visible = false;
            this.edtType.TextChanged += new System.EventHandler(this.edtType_TextChanged);
            // 
            // edtName
            // 
            this.edtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.NAME", true));
            this.edtName.Location = new System.Drawing.Point(156, 157);
            this.edtName.MaxLength = 30;
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(132, 20);
            this.edtName.TabIndex = 4;
            // 
            // edtSurname
            // 
            this.edtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bblabsDataSet, "bb_user.SURNAME", true));
            this.edtSurname.Location = new System.Drawing.Point(156, 183);
            this.edtSurname.MaxLength = 45;
            this.edtSurname.Name = "edtSurname";
            this.edtSurname.Size = new System.Drawing.Size(132, 20);
            this.edtSurname.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Access level";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Type";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Surname";
            // 
            // bb_userTableAdapter1
            // 
            this.bb_userTableAdapter1.ClearBeforeFill = true;
            // 
            // contactTableAdapter1
            // 
            this.contactTableAdapter1.ClearBeforeFill = true;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(40, 20);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(256, 20);
            this.lblMode.TabIndex = 14;
            this.lblMode.Text = "View/Edit Own Account Details";
            // 
            // cmbAccess
            // 
            this.cmbAccess.DisplayMember = "0";
            this.cmbAccess.FormattingEnabled = true;
            this.cmbAccess.Items.AddRange(new object[] {
            "Default User",
            "Administrator"});
            this.cmbAccess.Location = new System.Drawing.Point(156, 103);
            this.cmbAccess.Name = "cmbAccess";
            this.cmbAccess.Size = new System.Drawing.Size(132, 21);
            this.cmbAccess.TabIndex = 2;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "System User",
            "Lab User",
            "Both"});
            this.cmbType.Location = new System.Drawing.Point(156, 130);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(132, 21);
            this.cmbType.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(120, 465);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(192, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 465);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(192, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Account";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCloseAccount
            // 
            this.btnCloseAccount.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCloseAccount.Location = new System.Drawing.Point(19, 465);
            this.btnCloseAccount.Name = "btnCloseAccount";
            this.btnCloseAccount.Size = new System.Drawing.Size(75, 23);
            this.btnCloseAccount.TabIndex = 15;
            this.btnCloseAccount.Text = "Close";
            this.btnCloseAccount.UseVisualStyleBackColor = true;
            this.btnCloseAccount.Click += new System.EventHandler(this.btnCloseAccount_Click);
            // 
            // cmbUserNames
            // 
            this.cmbUserNames.DataSource = this.bblabsDataSet;
            this.cmbUserNames.DisplayMember = "bb_user.USERNAME";
            this.cmbUserNames.FormattingEnabled = true;
            this.cmbUserNames.Location = new System.Drawing.Point(157, 52);
            this.cmbUserNames.Name = "cmbUserNames";
            this.cmbUserNames.Size = new System.Drawing.Size(131, 21);
            this.cmbUserNames.TabIndex = 0;
            this.cmbUserNames.ValueMember = "bb_user.USER_ID";
            this.cmbUserNames.SelectedIndexChanged += new System.EventHandler(this.cmbUserNames_SelectedIndexChanged);
            // 
            // bb_userTableAdapter2
            // 
            this.bb_userTableAdapter2.ClearBeforeFill = true;
            // 
            // bblabsDataSet1
            // 
            this.bblabsDataSet1.DataSetName = "BBLABSDataSet";
            this.bblabsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(120, 465);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 23);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete User";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl0.ForeColor = System.Drawing.Color.Red;
            this.lbl0.Location = new System.Drawing.Point(294, 56);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(10, 13);
            this.lbl0.TabIndex = 22;
            this.lbl0.Text = "!";
            this.lbl0.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(294, 82);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 23;
            this.lbl1.Text = "!";
            this.lbl1.Visible = false;
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(294, 106);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(10, 13);
            this.lbl2.TabIndex = 24;
            this.lbl2.Text = "!";
            this.lbl2.Visible = false;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl3.ForeColor = System.Drawing.Color.Red;
            this.lbl3.Location = new System.Drawing.Point(294, 134);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(10, 13);
            this.lbl3.TabIndex = 25;
            this.lbl3.Text = "!";
            this.lbl3.Visible = false;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl4.ForeColor = System.Drawing.Color.Red;
            this.lbl4.Location = new System.Drawing.Point(294, 160);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(10, 13);
            this.lbl4.TabIndex = 26;
            this.lbl4.Text = "!";
            this.lbl4.Visible = false;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl5.ForeColor = System.Drawing.Color.Red;
            this.lbl5.Location = new System.Drawing.Point(294, 186);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(10, 13);
            this.lbl5.TabIndex = 27;
            this.lbl5.Text = "!";
            this.lbl5.Visible = false;
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCloseAccount;
            this.ClientSize = new System.Drawing.Size(341, 508);
            this.Controls.Add(this.lbl5);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.cmbUserNames);
            this.Controls.Add(this.btnCloseAccount);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.cmbAccess);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtSurname);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.edtType);
            this.Controls.Add(this.edtAccessLevel);
            this.Controls.Add(this.edtPassword);
            this.Controls.Add(this.edtUsername);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAccount";
            this.Text = "Account Info";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox edtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox edtTel;
        private System.Windows.Forms.TextBox edtEmail;
        private System.Windows.Forms.TextBox edtCellPhone;
        private System.Windows.Forms.TextBox edtIDNumber;
        private System.Windows.Forms.TextBox edtPersonalNumber;
        private System.Windows.Forms.TextBox edtStudentNmr;
        private System.Windows.Forms.TextBox edtUsername;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.TextBox edtAccessLevel;
        private System.Windows.Forms.TextBox edtType;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.TextBox edtSurname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private BBLABSDataSet bblabsDataSet;
        private BBLABSDataSetTableAdapters.bb_userTableAdapter bb_userTableAdapter1;
        private BBLABSDataSetTableAdapters.contactTableAdapter contactTableAdapter1;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ComboBox cmbAccess;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCloseAccount;
        private System.Windows.Forms.ComboBox cmbUserNames;
        private BBLABSDataSetTableAdapters.bb_userTableAdapter bb_userTableAdapter2;
        private BBLABSDataSet bblabsDataSet1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.Label lbl10;
        private System.Windows.Forms.Label lbl9;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl0;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl5;
    }
}