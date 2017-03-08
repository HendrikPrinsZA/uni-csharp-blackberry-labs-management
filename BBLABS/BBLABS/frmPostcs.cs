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
    public partial class frmPostcs : Form 
    {
        int UserID;
        Form1 parentForm;

        logHandle myLogHangle = new logHandle();

        public frmPostcs(int userID, Form1 par)
        {
            InitializeComponent();
            UserID = userID;
            parentForm = par;
        }

        private void frmPostcs_Load(object sender, EventArgs e)
        {
            lblDate.Text = myLogHangle.covertDateStringToString(DateTime.Now.ToString());
        }

        private void btnPost_Click(object sender, EventArgs e)
        {
            String query;

            //MessageBox.Show(redBody.Text);
            string heading = txtHeading.Text.Replace("'", "`");
            heading = heading.Replace('"', '`');
            string body = redBody.Text.Replace("'", "`");
            body = body.Replace('"','`');

            query = "INSERT INTO announcement(USER_ID,DATE_POSTED,HEADING,MESSAGE) VALUES(" + UserID + ",'" + DateTime.Now.ToString() + "','" + txtHeading.Text.Replace("'", "`") + "','" + redBody.Text.Replace("'", "`") + "')";
            //MessageBox.Show(UserID.ToString());
            if (myLogHangle.doQuery(query))
            {
                myLogHangle.insertChange(UserID, "Added announcement: " + heading);
                MessageBox.Show("Post Added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                parentForm.updatePosts();
                this.Close();
            }
            else
                MessageBox.Show("Could not add post", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void redBody_TextChanged(object sender, EventArgs e)
        {
            txtTextL.Text = redBody.TextLength.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
