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
    public partial class FrmUserInfo : Form
    {
        public FrmUserInfo(string uid, 
            string username, 
            string email, 
            string userType, 
            string deptName)
        {
            InitializeComponent();
            txtUserId.Text = uid;
            txtUsername.Text = username;
            txtEmail.Text = email;
            txtType.Text = userType;
            txtDept.Text = deptName;
        }

        public static FrmUserInfo GetUserInfoWnd(string uid, string username, string email, string userType, string deptName)
        {
            FrmUserInfo uInfoFrm = new FrmUserInfo(uid, username, email, userType, deptName);
            return uInfoFrm;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
