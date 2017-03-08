namespace BBLABS
{
    partial class frmPostcs
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
            this.redBody = new System.Windows.Forms.RichTextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHeading = new System.Windows.Forms.TextBox();
            this.btnPost = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtTextL = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // redBody
            // 
            this.redBody.BackColor = System.Drawing.SystemColors.Window;
            this.redBody.Location = new System.Drawing.Point(24, 57);
            this.redBody.MaxLength = 1500;
            this.redBody.Name = "redBody";
            this.redBody.Size = new System.Drawing.Size(509, 312);
            this.redBody.TabIndex = 1;
            this.redBody.Text = "";
            this.redBody.TextChanged += new System.EventHandler(this.redBody_TextChanged);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(440, 24);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 7;
            this.lblDate.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Heading";
            // 
            // txtHeading
            // 
            this.txtHeading.Location = new System.Drawing.Point(74, 21);
            this.txtHeading.MaxLength = 30;
            this.txtHeading.Name = "txtHeading";
            this.txtHeading.Size = new System.Drawing.Size(343, 20);
            this.txtHeading.TabIndex = 0;
            // 
            // btnPost
            // 
            this.btnPost.Location = new System.Drawing.Point(116, 394);
            this.btnPost.Name = "btnPost";
            this.btnPost.Size = new System.Drawing.Size(417, 23);
            this.btnPost.TabIndex = 2;
            this.btnPost.Text = "Post";
            this.btnPost.UseVisualStyleBackColor = true;
            this.btnPost.Click += new System.EventHandler(this.btnPost_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(24, 394);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtTextL
            // 
            this.txtTextL.AutoSize = true;
            this.txtTextL.Location = new System.Drawing.Point(469, 372);
            this.txtTextL.Name = "txtTextL";
            this.txtTextL.Size = new System.Drawing.Size(13, 13);
            this.txtTextL.TabIndex = 13;
            this.txtTextL.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(497, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "/1500";
            // 
            // frmPostcs
            // 
            this.AcceptButton = this.btnPost;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(561, 430);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTextL);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnPost);
            this.Controls.Add(this.txtHeading);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.redBody);
            this.Controls.Add(this.lblDate);
            this.Name = "frmPostcs";
            this.Text = "Create new post";
            this.Load += new System.EventHandler(this.frmPostcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox redBody;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHeading;
        private System.Windows.Forms.Button btnPost;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label txtTextL;
        private System.Windows.Forms.Label label3;
    }
}