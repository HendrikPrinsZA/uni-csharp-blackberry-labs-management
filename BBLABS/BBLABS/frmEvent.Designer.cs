namespace BBLABS
{
    partial class frmEvent
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
            this.grpParticipants = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.chkParticipants = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbUserNamesPartic = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtUsernamePart = new System.Windows.Forms.TextBox();
            this.lblOR = new System.Windows.Forms.Label();
            this.txtVenue = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkOpen = new System.Windows.Forms.CheckBox();
            this.dateEvent = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.lblCreator = new System.Windows.Forms.Label();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.cmbResponsible = new System.Windows.Forms.ComboBox();
            this.bblabsDataSet = new BBLABS.BBLABSDataSet();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.redSummary = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.bb_userTableAdapter = new BBLABS.BBLABSDataSetTableAdapters.bb_userTableAdapter();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl0 = new System.Windows.Forms.Label();
            this.grpParticipants.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // grpParticipants
            // 
            this.grpParticipants.Controls.Add(this.label16);
            this.grpParticipants.Controls.Add(this.lblCount);
            this.grpParticipants.Controls.Add(this.btnAddPart);
            this.grpParticipants.Controls.Add(this.label14);
            this.grpParticipants.Controls.Add(this.chkParticipants);
            this.grpParticipants.Controls.Add(this.label12);
            this.grpParticipants.Controls.Add(this.cmbUserNamesPartic);
            this.grpParticipants.Controls.Add(this.label15);
            this.grpParticipants.Controls.Add(this.txtUsernamePart);
            this.grpParticipants.Controls.Add(this.lblOR);
            this.grpParticipants.Location = new System.Drawing.Point(12, 148);
            this.grpParticipants.Name = "grpParticipants";
            this.grpParticipants.Size = new System.Drawing.Size(473, 100);
            this.grpParticipants.TabIndex = 50;
            this.grpParticipants.TabStop = false;
            this.grpParticipants.Text = "Participants";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(337, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Count";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Location = new System.Drawing.Point(381, 69);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(13, 13);
            this.lblCount.TabIndex = 34;
            this.lblCount.Text = "0";
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(222, 41);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(93, 23);
            this.btnAddPart.TabIndex = 33;
            this.btnAddPart.Text = "Add Participant";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(337, 27);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Current Participants";
            // 
            // chkParticipants
            // 
            this.chkParticipants.FormattingEnabled = true;
            this.chkParticipants.Location = new System.Drawing.Point(340, 43);
            this.chkParticipants.Name = "chkParticipants";
            this.chkParticipants.Size = new System.Drawing.Size(121, 21);
            this.chkParticipants.TabIndex = 31;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 65);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Enter name";
            // 
            // cmbUserNamesPartic
            // 
            this.cmbUserNamesPartic.FormattingEnabled = true;
            this.cmbUserNamesPartic.Location = new System.Drawing.Point(82, 22);
            this.cmbUserNamesPartic.Name = "cmbUserNamesPartic";
            this.cmbUserNamesPartic.Size = new System.Drawing.Size(121, 21);
            this.cmbUserNamesPartic.TabIndex = 25;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(13, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Select";
            // 
            // txtUsernamePart
            // 
            this.txtUsernamePart.Location = new System.Drawing.Point(82, 62);
            this.txtUsernamePart.Name = "txtUsernamePart";
            this.txtUsernamePart.Size = new System.Drawing.Size(121, 20);
            this.txtUsernamePart.TabIndex = 27;
            this.txtUsernamePart.TextChanged += new System.EventHandler(this.txtUsernamePart_TextChanged);
            // 
            // lblOR
            // 
            this.lblOR.AutoSize = true;
            this.lblOR.Location = new System.Drawing.Point(128, 46);
            this.lblOR.Name = "lblOR";
            this.lblOR.Size = new System.Drawing.Size(23, 13);
            this.lblOR.TabIndex = 26;
            this.lblOR.Text = "OR";
            // 
            // txtVenue
            // 
            this.txtVenue.Location = new System.Drawing.Point(352, 94);
            this.txtVenue.Name = "txtVenue";
            this.txtVenue.Size = new System.Drawing.Size(133, 20);
            this.txtVenue.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Venue";
            // 
            // chkOpen
            // 
            this.chkOpen.AutoSize = true;
            this.chkOpen.Location = new System.Drawing.Point(396, 134);
            this.chkOpen.Name = "chkOpen";
            this.chkOpen.Size = new System.Drawing.Size(89, 17);
            this.chkOpen.TabIndex = 47;
            this.chkOpen.Text = "Open Event?";
            this.chkOpen.UseVisualStyleBackColor = true;
            // 
            // dateEvent
            // 
            this.dateEvent.Location = new System.Drawing.Point(94, 91);
            this.dateEvent.Name = "dateEvent";
            this.dateEvent.Size = new System.Drawing.Size(203, 20);
            this.dateEvent.TabIndex = 46;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 92);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(72, 13);
            this.label13.TabIndex = 45;
            this.label13.Text = "Date of event";
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Location = new System.Drawing.Point(91, 58);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(36, 13);
            this.lblCreator.TabIndex = 44;
            this.lblCreator.Text = "Admin";
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(94, 25);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(133, 20);
            this.txtEventName.TabIndex = 43;
            // 
            // cmbResponsible
            // 
            this.cmbResponsible.DataSource = this.bblabsDataSet;
            this.cmbResponsible.DisplayMember = "bb_user.USERNAME";
            this.cmbResponsible.FormattingEnabled = true;
            this.cmbResponsible.Location = new System.Drawing.Point(352, 55);
            this.cmbResponsible.Name = "cmbResponsible";
            this.cmbResponsible.Size = new System.Drawing.Size(133, 21);
            this.cmbResponsible.TabIndex = 42;
            this.cmbResponsible.ValueMember = "bb_user.USER_ID";
            // 
            // bblabsDataSet
            // 
            this.bblabsDataSet.DataSetName = "BBLABSDataSet";
            this.bblabsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(246, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Resposible Person";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 265);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Summary";
            // 
            // redSummary
            // 
            this.redSummary.Location = new System.Drawing.Point(15, 281);
            this.redSummary.MaxLength = 500;
            this.redSummary.Name = "redSummary";
            this.redSummary.Size = new System.Drawing.Size(470, 114);
            this.redSummary.TabIndex = 39;
            this.redSummary.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Created by";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(272, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Date created";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Location = new System.Drawing.Point(417, 28);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(59, 13);
            this.lblCreatedDate.TabIndex = 37;
            this.lblCreatedDate.Text = "2012/12/1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Event name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(106, 412);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(300, 23);
            this.btnAdd.TabIndex = 52;
            this.btnAdd.Text = "Save new event";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(185, 412);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(300, 23);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // bb_userTableAdapter
            // 
            this.bb_userTableAdapter.ClearBeforeFill = true;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(78, 92);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(10, 13);
            this.lbl1.TabIndex = 54;
            this.lbl1.Text = "!";
            this.lbl1.Visible = false;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Cursor = System.Windows.Forms.Cursors.Help;
            this.lbl0.ForeColor = System.Drawing.Color.Red;
            this.lbl0.Location = new System.Drawing.Point(233, 28);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(10, 13);
            this.lbl0.TabIndex = 53;
            this.lbl0.Text = "!";
            this.lbl0.Visible = false;
            // 
            // frmEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 446);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpParticipants);
            this.Controls.Add(this.txtVenue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkOpen);
            this.Controls.Add(this.dateEvent);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.txtEventName);
            this.Controls.Add(this.cmbResponsible);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.redSummary);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.label6);
            this.Name = "frmEvent";
            this.Text = "frmEvent";
            this.grpParticipants.ResumeLayout(false);
            this.grpParticipants.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpParticipants;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox chkParticipants;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbUserNamesPartic;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtUsernamePart;
        private System.Windows.Forms.Label lblOR;
        private System.Windows.Forms.TextBox txtVenue;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkOpen;
        private System.Windows.Forms.DateTimePicker dateEvent;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.ComboBox cmbResponsible;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.RichTextBox redSummary;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private BBLABSDataSetTableAdapters.bb_userTableAdapter bb_userTableAdapter;
        private BBLABSDataSet bblabsDataSet;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl0;
    }
}