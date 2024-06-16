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
    public partial class FrmHeaders : Form
    {
        public FrmHeaders()
        {
            InitializeComponent();
        }

        public static void ShowHeadersWnd(
                string magic,
                string encHash,
                string pdfHash,
                string srcPc,
                string srcIntIp,
                string srcExtIp,
                string ntAccount,
                string uId,
                string username,
                string email,
                string userType,
                string deptId,
                string deptName,
                IWin32Window owner
            ) {
            FrmHeaders fh = new FrmHeaders();
            fh.InitControls(magic, encHash, pdfHash, srcPc, srcIntIp, srcExtIp, ntAccount, uId, username, email, userType, deptId, deptName);
            fh.ShowDialog(owner);
            fh.Dispose();
        }

        public void InitControls(string magic,
                string encHash,
                string pdfHash,
                string srcPc,
                string srcIntIp,
                string srcExtIp,
                string ntAccount,
                string uId,
                string username,
                string email,
                string userType,
                string deptId,
                string deptName)
        {
            txtMagic.Text = magic;
            txtEncPdf.Text = encHash;
            txtPdf.Text = pdfHash;
            txtDevName.Text = srcPc;
            txtIntIp.Text = srcIntIp;
            txtExtIp.Text = srcExtIp;
            txtNtAcc.Text = ntAccount;
            txtUserId.Text = uId;
            txtUsername.Text = username;
            txtEmail.Text = email; 
            txtUserType.Text = userType;
            txtDeptId.Text = deptId;
            txtDeptName.Text = deptName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
