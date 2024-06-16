using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSignGUI
{
    public partial class FrmScreen : Form
    {
        private static int x1Pos = 0;
        private static int y1Pos = 10;

        private static int x2Pos;
        private static int y2Pos = 10;

        private static bool doOver = false;

        private static Color frColor;
        private static Color reColor;

        private static Bitmap backBitmap;
        private static int msgPosition = 0;

        private SoundPlayer wmPlayer;
        private static List<string> msgList = new List<string>()
        {
            "A man cannot unsee the truth.",
            "He cannot willingly return to darkness,",
            "Or go blind once he has the gift of sight,",
            "Anymore than he can be unborn.",
            "We are the only species capable of self-reflection.",
            "The only species with the toxin of self-doubt written into our genetic code.",
            "Unequal to our gifts, we build, we buy, and we consume.",
            "We wrap ourselves in the illusion of material success.",
            "We cheat and deceive as we claw our way to the pinnacle of what we define as acheivement;",
            "Superiority to other men."
        };

        public FrmScreen()
        {
            InitializeComponent();
            frColor = ColorTranslator.FromHtml("#ffffff");
            reColor = ColorTranslator.FromHtml("#ffffff");
            backBitmap = Properties.Resources.acfw;
            msgPanel.BackColor = Color.Transparent;
            wmPlayer = new SoundPlayer(Properties.Resources.acfw_aud);
            wmPlayer.Play();
            //drawTimer.Start();
        }

        private void drawTimer_Tick(object sender, EventArgs e)
        {
            Graphics graphicObj = this.CreateGraphics();
            graphicObj.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            Pen frLinePen = new Pen(new SolidBrush(frColor), 10);
            Pen reLinePen = new Pen(new SolidBrush(reColor), 10);
            
            graphicObj.DrawLine(frLinePen, x1Pos, y1Pos, x2Pos, y2Pos);
            graphicObj.DrawLine(reLinePen, x1Pos, y1Pos - 10, x2Pos, y2Pos - 10);
            if (y1Pos <= this.Height && !doOver)
            {
                doOver = false;
                y1Pos += 10;
                y2Pos += 10;
            }
            else
            {
                doOver = true;
                y1Pos -= 10;
                y2Pos -= 10;
            }
            frColor = Color.FromArgb((frColor.R > 0) ? frColor.R - 1 : 0, (frColor.G > 0) ? frColor.G - 1 : 0, (frColor.B > 0) ? frColor.B - 1 : 0);
            reColor = Color.FromArgb((reColor.R > 0) ? reColor.R - 1 : 0, (reColor.G > 0) ? reColor.G - 1 : 0, (reColor.B > 0) ? reColor.B - 1 : 0);
            if((frColor.R + frColor.G + frColor.B + reColor.R + reColor.G + reColor.B) <= 0 && y2Pos > this.Height)
            {
                imgTimer.Start();
                drawTimer.Stop();
                msgTimer.Start();
            }

            if (y1Pos <= 0)
                doOver = false;
        }

        private void FrmScreen_Load(object sender, EventArgs e)
        {
            x2Pos = this.Width;
            drawTimer.Start();
        }

        private void imgTimer_Tick(object sender, EventArgs e)
        {
            Graphics graphicObj = this.CreateGraphics();
            graphicObj.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;
            int randX = GetRandomInt(0, backBitmap.Width);
            int randY = GetRandomInt(0, backBitmap.Height);
            
            for (int i = 0; i <= 20; i++)
            {
                for (int j = 0; j <= 20; j++)
                {
                    if ((j + randY) >= backBitmap.Height || (i + randX) >= backBitmap.Width)
                        continue;
                    graphicObj.FillRectangle(new SolidBrush(backBitmap.GetPixel(i + randX, j + randY)), i + randX, j + randY, 1, 1);
                }
            }
            
            
            
        }

        private static int GetRandomInt(int start, int end)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                byte[] buffer = new byte[4];

                rng.GetBytes(buffer);
                int result = BitConverter.ToInt32(buffer, 0);

                return new Random(result).Next(start, end);
            }
        }

        private void msgTimer_Tick(object sender, EventArgs e)
        {
            if (msgPosition == 0)
                Thread.Sleep(2000);
            GhostPanel invPanel = new GhostPanel();
            invPanel.Dock = DockStyle.Fill;
            
            Graphics graphicObj = msgPanel.CreateGraphics();
            graphicObj.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighSpeed;

            graphicObj.FillRectangle(new SolidBrush(Color.Black), 0, (Height - 300) / 2, Width, 300);
            Font msgFont = new Font("Segoe Script", 75, FontStyle.Italic, GraphicsUnit.Pixel);
            if (msgPosition >= msgList.Count)
            {
                msgTimer.Stop();
                return;
            }
            graphicObj.DrawString(msgList[msgPosition], msgFont, new SolidBrush(Color.White), ClientRectangle, new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
            msgPosition++;
            Thread.Sleep(4750);
        }

        public static void InitScreen(IWin32Window owner)
        {
            FrmScreen screen = new FrmScreen();
            screen.TopMost = true;
            screen.ShowDialog(owner);
            screen.Dispose();
        }
    }
}
