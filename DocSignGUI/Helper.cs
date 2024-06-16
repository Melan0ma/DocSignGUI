using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Management;

namespace DocSignGUI
{
    internal class Helper
    {
        public static string DS_API_URL = "<?URLGOESHERE?>DocSignWAR_war_exploded/process.ds?op=";
        public static string DS_DOWNLOAD_URL = "<?URLGOESHERE?>DocSignWAR_war_exploded/download.ds?fn={0}&d_fn={1}";
        public const string DS_API_AUTH = "auth";
        public const string DS_API_OP_UPLOAD = "upl";
        public const string DS_API_OP_DOWNLOAD = "dwl";
        public const string DS_API_OP_ENC = "enc";
        public const string DS_API_OP_DEC = "dec";
        public const string DS_API_OP_MARK = "mark";
        public const string DS_API_OP_HEAD = "head";
        public const string DS_API_OP_VERIFY = "ver";
        public const string DS_API_OP_SESS = "sess";
        public const string DS_API_OP_USERGET = "usr_get";
        public const string DS_API_OP_USERADD = "usr_create";
        public const string DS_API_OP_GETMAILLIST = "usr_mailing";
        public const string DS_API_OP_UPDATEUSER = "usr_update";
        public const string DS_API_OP_DEPTGET = "dpt_get";
        public const string DS_API_OP_DEPTADD = "dpt_add";

        public static string ApiOperation = null;
        public static int OperationProgress = 0;
        public static string ApiDownloadFn = null;
        public static string ApiDownloadOrgFn = null;
        public static string HttpFuncOutput = null;


        public static CookieContainer Cookies = new CookieContainer();
        public static HttpClientHandler ClientHandler = new HttpClientHandler()
        {
            CookieContainer = Cookies
        };

        public static HttpClient HttpHandler = new HttpClient();

        public static DialogResult DialogFileOpen(IWin32Window owner, string initDir, string fileFilter, out string filePath)
        {
            filePath = null;
            using (OpenFileDialog openDlg = new OpenFileDialog()
            {
                CheckFileExists = true,
                CheckPathExists = true,
                InitialDirectory = initDir,
                ValidateNames = true,
                Title = "Open File Dialog",
                Filter = fileFilter
            })
            {
                DialogResult result = openDlg.ShowDialog(owner);
                filePath = openDlg.FileName;
                return result;
            }
        }

        public static DialogResult DialogSaveFile(IWin32Window owner, string initDir, string fileFilter, out string filePath)
        {
            filePath = null;
            using (SaveFileDialog saveDlg = new SaveFileDialog()
            {
                OverwritePrompt = true,
                InitialDirectory = initDir,
                Title = "Save File As...",
                Filter = fileFilter,
                ValidateNames = true,
            })
            {
                DialogResult result = saveDlg.ShowDialog(owner);
                filePath = saveDlg.FileName;
                return result;
            }
        }

        public static void DisableTiles(Control tileWnd)
        {
            foreach (Control tile in tileWnd.Controls)
            {
                if (tile is MetroFramework.Controls.MetroTile)
                    tile.Enabled = false;

                if(tile is GroupBox)
                    DisableTiles((GroupBox)tile);
            }
        }

        public static void EnableTiles(Control tileWnd, string dsuType)
        {
            if(dsuType == "A")
            {
                foreach (Control tile in tileWnd.Controls["gbxAdmin"].Controls)
                    tile.Enabled = true;

                foreach (Control tile in tileWnd.Controls["gbxMain"].Controls)
                    tile.Enabled = false;

                foreach (Control tile in tileWnd.Controls["gbxIntegrity"].Controls)
                    tile.Enabled = false;
            } else if(dsuType == "U")
            {
                foreach (Control tile in tileWnd.Controls["gbxAdmin"].Controls)
                    tile.Enabled = false;

                foreach (Control tile in tileWnd.Controls["gbxMain"].Controls)
                    tile.Enabled = true;

                foreach (Control tile in tileWnd.Controls["gbxIntegrity"].Controls)
                    tile.Enabled = true;
            }
        }

        public static void ShowProgressBar(Control tileWnd)
        {
            if (!tileWnd.Controls["lblStatus"].Visible && !tileWnd.Controls["prgMain"].Visible)
            {
                tileWnd.Controls["lblStatus"].Visible = true;
                tileWnd.Controls["prgMain"].Visible = true;
                tileWnd.Height = 734;
            }
        }

        public static void HideProgressBar(Control tileWnd)
        {
            if(tileWnd.Controls["lblStatus"].Visible && tileWnd.Controls["prgMain"].Visible)
            {
                tileWnd.Controls["lblStatus"].Visible = false;
                tileWnd.Controls["prgMain"].Visible = false;
                tileWnd.Height = 518;
            }
        }

        public static bool IsProgressVisible(Control tileWnd)
        {
            return (tileWnd.Controls["lblStatus"].Visible && tileWnd.Controls["lblStatus"].Visible);
        }

        public static string FormatUrl(string process, KeyValuePair<string, string>[] values)
        {
            StringBuilder urlBuild = new StringBuilder();
            urlBuild.Append(DS_API_URL).Append(process);

            if (values != null)
            {
                foreach (KeyValuePair<string, string> param in values)
                {
                    urlBuild.Append("&").Append(param.Key).Append("=").Append(param.Value);
                }
            }
            return urlBuild.ToString();
        }

        public static string FormatUrl(string fn, string dFn)
        {
            return string.Format(DS_DOWNLOAD_URL, fn, dFn);
        }

        public static string FormatUrl(string process)
        {
            return $"{DS_API_URL}{process}";
        }


        public static string HttpStreamRequest(string process, string file, KeyValuePair<string, string>[] paramValues, IWin32Window owner = null)
        {
            using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
            using (MultipartFormDataContent multipart = new MultipartFormDataContent())
            {
                ApiOperation = DS_API_OP_UPLOAD;
                OperationProgress = 100;
                StreamContent streamParam = new StreamContent(fs);
                multipart.Add(streamParam, "upload", Path.GetFileName(file));
                HttpRequestMessage reqMsg = new HttpRequestMessage(HttpMethod.Post, FormatUrl(process, paramValues))
                {
                    Content = multipart
                };
                HttpResponseMessage respMsg = HttpHandler.SendAsync(reqMsg, HttpCompletionOption.ResponseHeadersRead).Result;
                ApiOperation = process;
                OperationProgress = 0;
                Stream respStream = respMsg.Content.ReadAsStreamAsync().Result;
                string strBuffer = string.Empty;
                byte[] buffByte = new byte[1];
                int read = -1;
                try
                {
                    while ((read = respStream.Read(buffByte, 0, buffByte.Length)) > 0)
                    {
                        strBuffer += Encoding.UTF8.GetString(buffByte);
                        if (strBuffer.EndsWith("\n"))
                        {
                            string[] tmpExpand = strBuffer.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
                            OperationProgress = Convert.ToInt32(Convert.ToDouble(tmpExpand[1]));
                            ApiDownloadFn = tmpExpand[2];
                            ApiDownloadOrgFn = Path.GetFileName(file);
                            strBuffer = string.Empty;
                        }
                    }
                }
                catch (Exception ex)
                {

                }

                return strBuffer;
            }
            ApiOperation = null;
            OperationProgress = 0;
        }

        public static string HttpContentRequest(string process, string file, IWin32Window owner)
        {
            try
            {
                using (FileStream fs = File.Open(file, FileMode.Open, FileAccess.Read))
                using (MultipartFormDataContent multipart = new MultipartFormDataContent())
                {
                    ApiOperation = DS_API_OP_UPLOAD;
                    OperationProgress = 100;
                    StreamContent streamParam = new StreamContent(fs);
                    multipart.Add(streamParam, "upload", Path.GetFileName(file));
                    HttpRequestMessage reqMsg = new HttpRequestMessage(HttpMethod.Post, FormatUrl(process))
                    {
                        Content = multipart
                    };
                    HttpResponseMessage respMsg = HttpHandler.SendAsync(reqMsg, HttpCompletionOption.ResponseContentRead).Result;
                    ApiOperation = null;
                    OperationProgress = 0;
                    return respMsg.Content.ReadAsStringAsync().Result;
                }
            }
            catch (Exception ex)
            {
                ApiOperation = null;
                OperationProgress = 0;
                return "Error : " + ex.InnerException.Message;
            }
            
        }

        public static string HttpEncodedPost(string process, KeyValuePair<string, string>[] content)
        {
            FormUrlEncodedContent formFields = new FormUrlEncodedContent(content);
            HttpResponseMessage httpResp = HttpHandler.PostAsync(FormatUrl(process), formFields).Result;
            string respStr = httpResp.Content.ReadAsStringAsync().Result;
            return respStr;
        }

        public static string HttpStreamDownload(string file)
        {
            double contentLen = 0;
            using (FileStream downFs = File.Open(file, FileMode.OpenOrCreate, FileAccess.Write))
            {
                downFs.SetLength(0);
                ApiOperation = DS_API_OP_DOWNLOAD;
                OperationProgress = 0;
                HttpResponseMessage respMsg = HttpHandler.GetAsync(FormatUrl(ApiDownloadFn, "DownloadFilePDF"), HttpCompletionOption.ResponseHeadersRead).Result;
                contentLen = Convert.ToInt32(respMsg.Content.Headers.ContentLength);
                if (contentLen > 0 && respMsg.Content.Headers.GetValues("Content-Type").First() == "application/octet-stream")
                {
                    Stream downStream = respMsg.Content.ReadAsStreamAsync().Result;
                    byte[] buffByte = new byte[1024];
                    double readTotal = 0;
                    int read = 0;
                    while ((read = downStream.Read(buffByte, 0, buffByte.Length)) > 0)
                    {
                        readTotal += read;
                        OperationProgress = (int)Math.Round(((readTotal / contentLen) * 100));
                        downFs.Write(buffByte, 0, read);
                    }
                    ApiOperation = null;
                    OperationProgress = 0;
                    return null;
                }
                else
                {
                    ApiOperation = null;
                    OperationProgress = 0;
                    return respMsg.Content.ReadAsStringAsync().Result;
                }
            }
        }

        public static int HttpClientAuthenticate(string username, string password, IWin32Window owner = null)
        {
            FormUrlEncodedContent formFields = new FormUrlEncodedContent(new KeyValuePair<string, string>[] {
                new KeyValuePair<string, string>("username", username),
                new KeyValuePair<string, string>("password", password)
            });
            HttpHandler.Timeout = TimeSpan.FromSeconds(60);
            HttpResponseMessage httpResp = HttpHandler.PostAsync(FormatUrl(DS_API_AUTH), formFields).Result;
            string respStr = httpResp.Content.ReadAsStringAsync().Result;

            if(respStr.StartsWith("Error : "))
            {
                MessageBox.Show(owner, respStr.Replace("Error : ", ""), "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return -1;
            }
            MessageBox.Show(owner, respStr, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return 0;
        }

        public static string GetHttpFuncOutput(int timeout)
        {
            while (true)
            {
                Thread.Sleep(timeout);
                break;
            }
            
            if(HttpFuncOutput == null)
                return null;
            return (string)HttpFuncOutput;
        }

        public static void ConsoleOut(ref RichTextBox console, string text)
        {
            console.AppendText($"[{DateTime.Now.ToString("yyyy-MM-dd h:mm:ss tt")}]  {text}\n");
            console.ScrollToCaret();
        }

        public static void ClearTextBoxes(Control ctrl)
        {
            foreach (Control control in ctrl.Controls)
                if(control is TextBox)
                    ((TextBox)control).Clear();
        }

        public static string GetBioskeys()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT Product, SerialNumber FROM Win32_BaseBoard");

            ManagementObjectCollection information = searcher.Get();
            foreach (ManagementObject obj in information)
            {
                foreach (PropertyData data in obj.Properties)
                {
                    string final = "BIOS Serial : " + data.Value;
                    searcher.Dispose();
                    return final;
                }
            }
            return "N/A";
        }
    }

}
