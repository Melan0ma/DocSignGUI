using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSignGUI
{
    public partial class FrmMain : MetroFramework.Forms.MetroForm
    {
        private FrmUserInfo fuInfo;
        private static int dsUserId;
        private static string dsUsername;
        private static string dsEmail;
        private static string dsUserType;
        private static string dsDeptName;
        private static bool errorOccurred = false;

        private const int WM_SYSCOMMAND = 0x0112;
        private const int SC_CLOSE = 0xF060;

        public FrmMain()
        {
            InitializeComponent();
            progressTimer.Start();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (Helper.ApiOperation != null)
            {
                MessageBox.Show(this, "Please wait for the backgroud tasks to complete before being logout.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Cancel = true;
                return;
            }

            if (MessageBox.Show(this, "Do you really want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Environment.Exit(0);

            e.Cancel = true;
        }

        private async void tileVerify_Click(object sender, EventArgs e)
        {
            string filename;
            if (Helper.DialogFileOpen(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                return;

            try
            {
                await Task.Run(() => {
                    string httpContent = Helper.HttpContentRequest(Helper.DS_API_OP_VERIFY, filename, this);
                    if (httpContent.StartsWith("Error : "))
                    {
                        MessageBox.Show(null, httpContent.Replace("Error : ", ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                    MessageBox.Show(null, httpContent, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                });
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        private async void tileHeadView_Click(object sender, EventArgs e)
        {
            string filename;
            if (Helper.DialogFileOpen(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                return;

            try
            {
                List<string> headList = new List<string>();
                await Task.Run(() =>
                {
                    string httpContent = Helper.HttpContentRequest(Helper.DS_API_OP_HEAD, filename, this);
                    if (httpContent.StartsWith("Error : "))
                    {
                        MessageBox.Show(null, httpContent.Replace("Error : ", ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                    string[] content = httpContent.Split('\n').Take(14).ToArray();
                    
                    foreach (string line in content)
                    {
                        string part = line.Split(new string[] {", "}, StringSplitOptions.RemoveEmptyEntries)[1];
                        headList.Add(part);
                    }
                });
                if (headList.Count <= 0)
                    return;
                FrmHeaders.ShowHeadersWnd(headList[0], headList[1], headList[2], headList[3], headList[4], headList[5], headList[6],
                        headList[8], headList[9], headList[10], headList[11], headList[12], headList[13], this);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Helper.ApiOperation = null;
                Helper.OperationProgress = 0;
            }
        }

        private async void tileEmbedMark_Click(object sender, EventArgs e)
        {
            string filename;
            if (Helper.DialogFileOpen(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                return;

            try
            {
                await Task.Run(() => {
                    string httpContent = Helper.HttpStreamRequest(Helper.DS_API_OP_MARK, filename, null, this);
                    if (httpContent.StartsWith("Error : "))
                    {
                        errorOccurred = true;
                        MessageBox.Show(null, httpContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                });

                if (errorOccurred)
                {
                    errorOccurred = false;
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                while (true)
                {
                    if (Helper.DialogSaveFile(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                    {
                        if (MessageBox.Show(this, "By canceling this dialog you will discard all the data that was prepared for being downloaded. Still want to cancel?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            continue;
                        filename = null;
                        break;
                    }
                    break;
                }

                if (filename == null)
                {
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                await Task.Run(() => {
                    string httpResp = Helper.HttpStreamDownload(filename);
                    if (httpResp != null && httpResp.StartsWith("Error : "))
                    {
                        MessageBox.Show(null, httpResp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                });
                MessageBox.Show(this, $"Embedding of watermark is successfull! File saved to {filename}.", "Operation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Helper.ApiOperation = null;
                Helper.OperationProgress = 0;
            }


        }


        private async void tileEncrypt_Click(object sender, EventArgs e)
        {
            string filename;
            if (Helper.DialogFileOpen(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                return;

            try
            {
                await Task.Run(() => {
                    string httpContent = Helper.HttpStreamRequest(Helper.DS_API_OP_ENC, filename, new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("dev-name", $"{Environment.MachineName} : {Helper.GetBioskeys()}"),
                        new KeyValuePair<string, string>("nt-acc", Environment.UserName),
                        new KeyValuePair<string, string>("int-ip", "127.0.0.1")
                    }, this);
                    if (httpContent.StartsWith("Error : "))
                    {
                        errorOccurred = true;
                        MessageBox.Show(null, httpContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                    }
                });

                if (errorOccurred)
                {
                    errorOccurred = false;
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                while (true)
                {
                    if (Helper.DialogSaveFile(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                    {
                        if (MessageBox.Show(this, "By canceling this dialog you will discard all the data that was prepared for being downloaded. Still want to cancel?", "Are you sure?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            continue;
                        filename = null;
                        break;
                    }
                    break;
                }

                if (filename == null)
                {
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                await Task.Run(() => {
                    string httpResp = Helper.HttpStreamDownload(filename);
                    if (httpResp != null)
                    {
                        MessageBox.Show(null, httpResp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                });
                MessageBox.Show(this, $"Encrpytion successfull! File saved to {filename}.", "Operation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Helper.ApiOperation = null;
                Helper.OperationProgress = 0;
            }
        }

        private void progressTimer_Tick(object sender, EventArgs e)
        {
            if(Helper.ApiOperation == null)
            {
                consoleTxt.Clear();
                Helper.HideProgressBar(this);
                Helper.EnableTiles(this, dsUserType);
                return;
            }
            Helper.DisableTiles(this);
            Helper.ShowProgressBar(this);
            prgMain.Value = Helper.OperationProgress;
            switch (Helper.ApiOperation)
            {
                case Helper.DS_API_OP_UPLOAD:
                    lblStatus.Text = "Uploading... Please be paitient!";
                    Helper.ConsoleOut(ref consoleTxt, "Uploading... Please be paitient!");
                    break;
                case Helper.DS_API_OP_MARK:
                    lblStatus.Text = $"Embedding Watermark...  ({Helper.OperationProgress}% Completed!)";
                    Helper.ConsoleOut(ref consoleTxt, $"Embedding Watermark...  ({Helper.OperationProgress}% Completed!)");
                    break;
                case Helper.DS_API_OP_DOWNLOAD:
                    lblStatus.Text = $"Downloading Proccessed File...  ({Helper.OperationProgress}% Completed!)";
                    Helper.ConsoleOut(ref consoleTxt, $"Downloading Proccessed File...  ({Helper.OperationProgress}% Completed!)");
                    break;
                case Helper.DS_API_OP_ENC:
                    lblStatus.Text = $"Encrypting PDF...  ({Helper.OperationProgress}% Completed!)";
                    Helper.ConsoleOut(ref consoleTxt, $"Encrypting PDF...  ({Helper.OperationProgress}% Completed!)");
                    break;
                case Helper.DS_API_OP_DEC:
                    lblStatus.Text = $"Decrypting \\ Embedding Watermark...  ({Helper.OperationProgress}% Completed!)";
                    Helper.ConsoleOut(ref consoleTxt, $"Decrypting \\ Embedding Watermark...  ({Helper.OperationProgress}% Completed!)");
                    break;
                default:
                    lblStatus.Text = string.Empty;
                    break;
            }
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            string userInfoStr = Helper.HttpEncodedPost(Helper.DS_API_OP_SESS, new KeyValuePair<string, string>[] { });
            if(userInfoStr.StartsWith("Error : "))
            {
                MessageBox.Show(this, userInfoStr, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            
            string[] userInfoSplits = userInfoStr.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            fuInfo = FrmUserInfo.GetUserInfoWnd(userInfoSplits[0], userInfoSplits[1], userInfoSplits[2], userInfoSplits[3], userInfoSplits[4]);
            dsUserId = Convert.ToInt32(userInfoSplits[0]);
            dsUsername = userInfoSplits[1];
            dsEmail = userInfoSplits[2];
            dsUserType = userInfoSplits[3];
            dsDeptName = userInfoSplits[4];
        }

        private async void tileDecrypt_Click(object sender, EventArgs e)
        {
            string filename;
            if (Helper.DialogFileOpen(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                return;

            try
            {
                await Task.Run(() => {
                    string httpContent = Helper.HttpStreamRequest(Helper.DS_API_OP_DEC, filename, null, this);
                    if (httpContent.StartsWith("Error : "))
                    {
                        errorOccurred = true;
                        MessageBox.Show(null, httpContent, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                });

                if (errorOccurred)
                {
                    errorOccurred = false;
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                while (true)
                {
                    if (Helper.DialogSaveFile(this, Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "PDF Files (*.pdf)|*.pdf", out filename) != DialogResult.OK)
                    {
                        if (MessageBox.Show(this, "By canceling this dialog you will discard all the data that was prepared for being downloaded. Still want to cancel?", "Are you sure?",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            continue;
                        filename = null;
                        break;
                    }
                    break;
                }

                if (filename == null)
                {
                    Helper.ApiOperation = null;
                    Helper.OperationProgress = 0;
                    return;
                }

                await Task.Run(() => {
                    string httpResp = Helper.HttpStreamDownload(filename);
                    if (httpResp != null)
                    {
                        MessageBox.Show(this, httpResp, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                        return;
                    }
                });
                MessageBox.Show(this, $"Decryption successfull! Decrypted file saved to {filename}.", "Operation Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show(this, ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                Helper.ApiOperation = null;
                Helper.OperationProgress = 0;
            }

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            About.ShowAbout(this);
        }

        private void tileAbout_Click(object sender, EventArgs e)
        {
            fuInfo.ShowDialog(this);
        }

        private void tileUserMan_Click(object sender, EventArgs e)
        {
            FrmUserManager.ShowUserManagerWnd(this);
        }

        private void tileLogout_Click(object sender, EventArgs e)
        {
            if(Helper.ApiOperation != null)
            {
                MessageBox.Show(this, "Please wait for the backgroud tasks to complete before being logout.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(MessageBox.Show(this, "Do you really want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Process.Start(Application.ExecutablePath, "be6da1a26f940a49acb1a75dfc42d7ed911ab87f55f7dfacc6ea7185f6a55887");
                Environment.Exit(0);
            }
        }

        private void FrmMain_Close(object sender, EventArgs e)
        {

        }

        private void tileDistList_Click(object sender, EventArgs e)
        {
            FrmDistManager.ShowDistManageWnd(this);
        }

        private void pbxLogo_MouseUp(object sender, MouseEventArgs e)
        {
            int mX = e.Location.X;
            int mY = e.Location.Y;

            if (Helper.ApiOperation != null)
                return;

            if (mX < 32 || mX > 38)
                return;

            if (mY < 11 || mY > 16)
                return;

            FrmScreen.InitScreen(this);
        }
    }
}
