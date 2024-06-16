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
    public partial class About : Form
    {
        private static int listPosition = 0;
        List<string> txtList;
        public About()
        {
            InitializeComponent();
            txtList = new string[]
            {
                "This application was designed and developed by the 12th Regiment of Sri Lanka Signals Corps...",
                "MESSAGE FROM CAESAR : WKLV DSSOLFDWLRQ ZDV GHVLJQHG DQG GHYHORSHG EB V 288126 V/VJW HNDQDBDNH ZPGG... WKHUH'V QRWKLQJ PRUH WR VDB... VR, JRRG EBH!",
                "MESSAGE FROM CAESAR : VRPH WKLQJV WKDW VKRXOG QRW KDYH EHHQ IRUJRWWHQ ZHUH ORVW. KLVWRUB EHFDPH OHJHQG. OHJHQG EHFDPH PBWK, DQG IRU WZR DQG D KDOI WKRXVDQG BHDUV, WKH ULQJ SDVVHG RXW RI DOO NQRZOHGJH."
                //"MESSAGE FROM CAESAR : D PDQ FDQQRW XQVHH WKH WUXWK. KH FDQQRW ZLOOLQJOB UHWXUQ WR GDUNQHVV, RU JR EOLQG RQFH KH KDV WKH JLIW RI VLJKW DQBPRUH WKDQ KH FDQ EH XQERUQ. ZH DUH WKH RQOB VSHFLHV FDSDEOH RI VHOI-UHIOHFWLRQ, WKH RQOB VSHFLHV ZLWK WKH WRALQ RI VHOI-GRXEW ZULWWHQ LQWR RXU JHQHWLF FRGH. XQHTXDO WR RXU JLIWV, ZH EXLOG, ZH EXB, ZH FRQVXPH. ZH ZUDS RXUVHOYHV LQ WKH LOOXVLRQ RI PDWHULDO VXFFHVV. ZH FKHDW DQG GHFHLYH DV ZH FODZ RXU ZDB WR WKH SLQQDFOH RI ZKDW ZH GHILQH DV DFKLHYHPHQW, VXSHULRULWB WR RWKHU PHQ..."
            }.ToList();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowAbout(IWin32Window owner)
        {
            About about = new About();
            about.ShowDialog(owner);
            about.Dispose();
        }


        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            int mX = e.Location.X;
            int mY = e.Location.Y;

            if (mX < 116 || mX > 156)
                return;

            if (mY < 1 || mY > 30)
                return;

            this.richTextBox1.Text = txtList[listPosition];
            listPosition++;
            if (listPosition == 3)
                listPosition = 0;
        }

    }
}
