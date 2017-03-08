namespace BBLABS
{
    partial class frmLockers
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLockerName = new System.Windows.Forms.TextBox();
            this.lstLockers = new System.Windows.Forms.ListBox();
            this.bblabsDataSet1 = new BBLABS.BBLABSDataSet();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLockerStatus = new System.Windows.Forms.Label();
            this.lockerTableAdapter2 = new BBLABS.BBLABSDataSetTableAdapters.lockerTableAdapter();
            this.lbl0 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name/Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Current Lockers";
            // 
            // txtLockerName
            // 
            this.txtLockerName.Location = new System.Drawing.Point(245, 82);
            this.txtLockerName.MaxLength = 30;
            this.txtLockerName.Name = "txtLockerName";
            this.txtLockerName.Size = new System.Drawing.Size(100, 20);
            this.txtLockerName.TabIndex = 7;
            // 
            // lstLockers
            // 
            this.lstLockers.DataSource = this.bblabsDataSet1;
            this.lstLockers.DisplayMember = "locker.LOCKER_NAME";
            this.lstLockers.FormattingEnabled = true;
            this.lstLockers.Location = new System.Drawing.Point(12, 27);
            this.lstLockers.Name = "lstLockers";
            this.lstLockers.Size = new System.Drawing.Size(120, 186);
            this.lstLockers.TabIndex = 13;
            this.lstLockers.ValueMember = "locker.LOCKER_ID";
            this.lstLockers.SelectedIndexChanged += new System.EventHandler(this.lstLockers_SelectedIndexChanged);
            // 
            // bblabsDataSet1
            // 
            this.bblabsDataSet1.DataSetName = "BBLABSDataSet";
            this.bblabsDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 23);
            this.btnAdd.TabIndex = 14;
            this.btnAdd.Text = "Add Locker";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(165, 142);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Changes";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(165, 142);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(180, 23);
            this.btnAddNew.TabIndex = 16;
            this.btnAddNew.Text = "Save New Locker";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 248);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(120, 23);
            this.btnRemove.TabIndex = 17;
            this.btnRemove.Text = "Remove Locker";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Locker Status";
            // 
            // lblLockerStatus
            // 
            this.lblLockerStatus.AutoSize = true;
            this.lblLockerStatus.Location = new System.Drawing.Point(242, 113);
            this.lblLockerStatus.Name = "lblLockerStatus";
            this.lblLockerStatus.Size = new System.Drawing.Size(33, 13);
            this.lblLockerStatus.TabIndex = 19;
            this.lblLockerStatus.Text = "Open";
            // 
            // lockerTableAdapter2
            // 
            this.lockerTableAdapter2.ClearBeforeFill = true;
            // 
            // lbl0
            // 
            this.lbl0.AutoSize = true;
            this.lbl0.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl0.ForeColor = System.Drawing.Color.Red;
            this.lbl0.Location = new System.Drawing.Point(353, 85);
            this.lbl0.Name = "lbl0";
            this.lbl0.Size = new System.Drawing.Size(10, 13);
            this.lbl0.TabIndex = 20;
            this.lbl0.Text = "!";
            this.lbl0.Visible = false;
            // 
            // frmLockers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 289);
            this.Controls.Add(this.lbl0);
            this.Controls.Add(this.lblLockerStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstLockers);
            this.Controls.Add(this.txtLockerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmLockers";
            this.Text = "Locker Control";
            ((System.ComponentModel.ISupportInitialize)(this.bblabsDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLockerName;
        private System.Windows.Forms.ListBox lstLockers;
        //private BBLABSDataSetTableAdapters.lockerTableAdapter lockerTableAdapter1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLockerStatus;
        private BBLABSDataSet bblabsDataSet1;
        private BBLABSDataSetTableAdapters.lockerTableAdapter lockerTableAdapter2;
        private System.Windows.Forms.Label lbl0;
    }
}