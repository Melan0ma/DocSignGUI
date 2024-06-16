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
    public partial class FrmSelectDept : Form
    {
        private string selectedDeptName;
        public FrmSelectDept()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lvDepts.Items.Clear();
            string mailingList = Helper.HttpEncodedPost(Helper.DS_API_OP_GETMAILLIST, new KeyValuePair<string, string>[]
            {
                new KeyValuePair<string, string>("keyword", txtKeyword.Text)
            });

            if (mailingList.StartsWith(">^<__EMPTY__>^<"))
                return;

            string[] mails = mailingList.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (string mail in mails)
            {
                ListViewItem tmpLvi = new ListViewItem(mail.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries));
                lvDepts.Items.Add(tmpLvi);
            }
        }

        public static void OpenSelectDeptDialog(IWin32Window owner, out string deptName)
        {
            deptName = null;
            FrmSelectDept deptDlg = new FrmSelectDept();
            deptDlg.ShowDialog(owner);
            if(deptDlg.selectedDeptName != null)
                deptName = deptDlg.selectedDeptName;
            deptDlg.Dispose();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (lvDepts.SelectedItems.Count <= 0)
                return;
            selectedDeptName = lvDepts.SelectedItems[0].SubItems[1].Text;
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gbxDept_Enter(object sender, EventArgs e)
        {
            this.AcceptButton = btnSearch;
        }

        private void lvDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = btnSelect;
        }
    }
}
