using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSignGUI
{
    public partial class FrmLogin : MetroFramework.Forms.MetroForm
    {

        private static CookieContainer httpCookies = new CookieContainer();
        private static HttpClientHandler clientHandle = new HttpClientHandler() { CookieContainer = httpCookies }; 
        private static HttpClient httpClient = null;
        public FrmLogin()
        {
            InitializeComponent();
            this.StyleManager = msManager;
            msManager.Theme = MetroFramework.MetroThemeStyle.Light;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show(this, "Please provide the required credentials to login.", "Credentials Required!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (cbxPassThru.Checked)
            {
                Helper.DS_API_URL = "http://202.124.178.115:8080/DocSignWAR_war_exploded/process.ds?op=";
                Helper.DS_DOWNLOAD_URL = "http://202.124.178.115:8080/DocSignWAR_war_exploded/download.ds?fn={0}&d_fn={1}";
            }
            else
            {
                Helper.DS_API_URL = "http://172.16.60.165:8080/DocSignWAR_war_exploded/process.ds?op=";
                Helper.DS_DOWNLOAD_URL = "http://172.16.60.165:8080/DocSignWAR_war_exploded/download.ds?fn={0}&d_fn={1}";
            }

            try
            {
                httpClient = new HttpClient(clientHandle);
                httpClient.DefaultRequestHeaders.UserAgent.ParseAdd(@"FC534F2C988CBF7755D677F7C86EA331A17C98F1124D8182A4F61EB485");
                Helper.HttpHandler = httpClient;
                if (Helper.HttpClientAuthenticate(txtUsername.Text, txtPassword.Text) == 0)
                {
                    FrmMain mainFrm = new FrmMain();
                    mainFrm.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, @"Exception", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }


        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            this.TopMost = false;
            this.Activate();
            this.ActiveControl = txtUsername;
            this.AcceptButton = btnLogin;
        }

        private void pbxLogo_Click(object sender, EventArgs e)
        {
        }

        private void pbxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            int mX = e.Location.X;
            int mY = e.Location.Y;

            if (mX < 32 || mX > 39)
                return;

            if (mY < 11 || mY > 17)
                return;

            FrmScreen.InitScreen(this);
        }
    }
}
