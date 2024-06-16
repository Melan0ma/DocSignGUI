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
    public partial class FrmDistManager : Form
    {
        public FrmDistManager()
        {
            InitializeComponent();
            cbxViewData_CheckedChanged(null, EventArgs.Empty);
        }

        public static void ShowDistManageWnd(IWin32Window owner)
        {
            FrmDistManager frmDistMan = new FrmDistManager();
            frmDistMan.ShowDialog(owner);
            frmDistMan.Dispose();
        }

        private void cbxViewData_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxViewData.Checked)
            {
                foreach (Control ctrl in this.gbxListItem.Controls)
                    if (ctrl is TextBox || ctrl is Button)
                        ctrl.Enabled = true;

                foreach (Control ctrl in this.gbxDeptData.Controls)
                    if (ctrl is TextBox || ctrl is Button || ctrl is RichTextBox)
                        ctrl.Enabled = false;

                btnAdd.Enabled = false;
            } 
            else
            {
                foreach (Control ctrl in this.gbxListItem.Controls)
                    if (ctrl is TextBox || ctrl is Button)
                        ctrl.Enabled = false;

                foreach (Control ctrl in this.gbxDeptData.Controls)
                    if (ctrl is TextBox || ctrl is Button || ctrl is RichTextBox)
                        ctrl.Enabled = true;

                btnAdd.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDept.Text))
                return;

            string deptInfoStr = Helper.HttpEncodedPost(Helper.DS_API_OP_DEPTGET, new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("dept", txtDept.Text)
            });

            if(deptInfoStr.StartsWith("Error : "))
            {
                MessageBox.Show(this, deptInfoStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string[] deptInfo = deptInfoStr.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries);
            if(deptInfo.Length != 3)
            {
                MessageBox.Show(this, "Failed to parse the returned data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            txtDeptId.Text = deptInfo[0];
            txtDeptName.Text = deptInfo[1];
            rtxtDeptDesc.Text = deptInfo[2];
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtDeptName.Text) || string.IsNullOrEmpty(rtxtDeptDesc.Text))
            {
                MessageBox.Show(this, "Please provide a name and a description for the department.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }

            string deptAddStr = Helper.HttpEncodedPost(Helper.DS_API_OP_DEPTADD, new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("dname", txtDeptName.Text),
                new KeyValuePair<string, string>("ddesc", rtxtDeptDesc.Text)
            });

            if (deptAddStr.StartsWith("Error : "))
            {
                MessageBox.Show(this, deptAddStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            if (MessageBox.Show(this, $"Department added successfully. Do you want to add more departments?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                this.Close();
            else
                Helper.ClearTextBoxes(this.gbxDeptData);
        }

        private void gbxListItem_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnLoad;
        }

        private void gbxDeptData_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnAdd;
        }
    }
}
