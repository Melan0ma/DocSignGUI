using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSignGUI
{
    public partial class FrmUserManager : Form
    {
        private static string tmpUid, 
            tmpUn, 
            tmpPassword, 
            tmpEmail, 
            tmpDept;
        public FrmUserManager()
        {
            InitializeComponent();
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbxLoad.Controls)
                if(ctrl is TextBox)
                    ((TextBox) ctrl).Clear();

            foreach (Control ctrl in gbxUserData.Controls)
                if (ctrl is TextBox)
                    ((TextBox)ctrl).Clear();

            if (cbxEdit.Checked)
            {
                foreach (Control ctrl in gbxLoad.Controls)
                    ctrl.Enabled = true;
                btnCreate.Enabled = false;
                btnUpdate.Enabled = true;
                txtUsername.Enabled = false;
                txtEmail.Enabled = false;
                txtDeptName.Enabled = false;
            }
            else
            {
                foreach (Control ctrl in gbxLoad.Controls)
                    ctrl.Enabled = false;

                btnCreate.Enabled = true;
                btnUpdate.Enabled = false;
                txtUsername.Enabled = true;
                txtEmail.Enabled = true;
                txtDeptName.Enabled = true;
            }
        }

        public static void ShowUserManagerWnd(IWin32Window owner)
        {
            FrmUserManager userMan = new FrmUserManager();
            userMan.ShowDialog(owner);
            userMan.Dispose();
        }

        private void FrmUserManager_Load(object sender, EventArgs e)
        {
            checkBox1_CheckedChanged(sender, e);
            cbxUserType.SelectedIndex = 0;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (txtUser.Text == String.Empty)
                return;

            string userInfoStr = Helper.HttpEncodedPost(Helper.DS_API_OP_USERGET, new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("user", txtUser.Text)
            });

            if(userInfoStr.StartsWith("Error : "))
            {
                MessageBox.Show(this, userInfoStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string[] userDetails = userInfoStr.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            if (userDetails.Length != 5)
            {
                MessageBox.Show(this, "Failed to parse the returned data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            txtUid.Text = userDetails[0];
            txtUsername.Text = userDetails[1];
            txtEmail.Text = userDetails[2];
            cbxUserType.Text = userDetails[3];
            if(userDetails[3] == "U")
                cbxUserType.SelectedIndex = 1;
            else if(userDetails[3] == "A")
                cbxUserType.SelectedIndex = 0;
            else if(userDetails[3] =="D")
                cbxUserType.SelectedIndex = 2;

            txtDeptName.Text = userDetails[4];
            tmpUid = txtUid.Text;
            tmpUn = txtUsername.Text;
            tmpEmail = txtEmail.Text;
            tmpPassword = txtPassword.Text;
            tmpDept = txtDeptName.Text;
        }

        private void gbxLoad_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoad;
        }

        private void gbxUserData_Enter(object sender, EventArgs e)
        {
            if (cbxEdit.Checked && btnUpdate.Enabled)
            {
                this.AcceptButton = btnUpdate;
                return;
            }
            this.AcceptButton = btnCreate;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in gbxUserData.Controls)
            {
                if (ctrl is TextBox)
                    if(((TextBox)ctrl).Text == String.Empty && ((TextBox)ctrl).ReadOnly == false)
                    {
                        MessageBox.Show(this, "All the required data to perform the requested operation were not provided.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        return;
                    }
            }

            string userCreateOp = Helper.HttpEncodedPost(Helper.DS_API_OP_USERADD, new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("username", txtUsername.Text),
                new KeyValuePair<string, string>("email", txtEmail.Text),
                new KeyValuePair<string, string>("password", txtPassword.Text),
                new KeyValuePair<string, string>("userType", cbxUserType.Text.ElementAt(0).ToString()),
                new KeyValuePair<string, string>("deptName", txtDeptName.Text),
            });

            if (userCreateOp.StartsWith("Error : "))
            {
                MessageBox.Show(this, userCreateOp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show(this, $"Creation of the new user account is successful. Do you want to add more users?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Close();
            else
                Helper.ClearTextBoxes(this.gbxUserData);
        }

        private void txtDeptName_Clicked(object sender, EventArgs e)
        {
            string deptName = "";
            FrmSelectDept.OpenSelectDeptDialog(this, out deptName);
            if (string.IsNullOrEmpty(deptName))
                return;
            txtDeptName.Text = deptName;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string userUpdateOp = Helper.HttpEncodedPost(Helper.DS_API_OP_UPDATEUSER, new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("uid", txtUid.Text),
                new KeyValuePair<string, string>("pwd", txtPassword.Text),
                new KeyValuePair<string, string>("utype", cbxUserType.Text)
            });

            if(userUpdateOp.StartsWith("Error : "))
            {
                MessageBox.Show(this, userUpdateOp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            MessageBox.Show(this, userUpdateOp, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Helper.ClearTextBoxes(this.gbxUserData);

        }

        private void txtDeptName_Focused(object sender, EventArgs e)
        {

        }
    }
}
