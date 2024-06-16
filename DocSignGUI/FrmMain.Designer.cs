namespace DocSignGUI
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.progressTimer = new System.Windows.Forms.Timer(this.components);
            this.prgMain = new MetroFramework.Controls.MetroProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.gbxIntegrity = new System.Windows.Forms.GroupBox();
            this.gbxAdmin = new System.Windows.Forms.GroupBox();
            this.dashPanel = new System.Windows.Forms.Panel();
            this.consoleTxt = new System.Windows.Forms.RichTextBox();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.tileLogout = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.tileAbout = new MetroFramework.Controls.MetroTile();
            this.tileDistList = new MetroFramework.Controls.MetroTile();
            this.tileUserMan = new MetroFramework.Controls.MetroTile();
            this.tileVerify = new MetroFramework.Controls.MetroTile();
            this.tileHeadView = new MetroFramework.Controls.MetroTile();
            this.tileEncrypt = new MetroFramework.Controls.MetroTile();
            this.tileDecrypt = new MetroFramework.Controls.MetroTile();
            this.tileEmbedMark = new MetroFramework.Controls.MetroTile();
            this.gbxMain.SuspendLayout();
            this.gbxIntegrity.SuspendLayout();
            this.gbxAdmin.SuspendLayout();
            this.dashPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // progressTimer
            // 
            this.progressTimer.Interval = 30;
            this.progressTimer.Tick += new System.EventHandler(this.progressTimer_Tick);
            // 
            // prgMain
            // 
            this.prgMain.Location = new System.Drawing.Point(26, 691);
            this.prgMain.Name = "prgMain";
            this.prgMain.Size = new System.Drawing.Size(845, 31);
            this.prgMain.TabIndex = 11;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(23, 672);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 16);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "Status : ";
            // 
            // gbxMain
            // 
            this.gbxMain.Controls.Add(this.tileEncrypt);
            this.gbxMain.Controls.Add(this.tileDecrypt);
            this.gbxMain.Controls.Add(this.tileEmbedMark);
            this.gbxMain.Location = new System.Drawing.Point(26, 63);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(269, 441);
            this.gbxMain.TabIndex = 13;
            this.gbxMain.TabStop = false;
            this.gbxMain.Text = "Encrypt / Decrypt /Embed Watermark";
            // 
            // gbxIntegrity
            // 
            this.gbxIntegrity.Controls.Add(this.tileVerify);
            this.gbxIntegrity.Controls.Add(this.tileHeadView);
            this.gbxIntegrity.Location = new System.Drawing.Point(347, 63);
            this.gbxIntegrity.Name = "gbxIntegrity";
            this.gbxIntegrity.Size = new System.Drawing.Size(310, 155);
            this.gbxIntegrity.TabIndex = 14;
            this.gbxIntegrity.TabStop = false;
            this.gbxIntegrity.Text = "File Integrity";
            // 
            // gbxAdmin
            // 
            this.gbxAdmin.Controls.Add(this.tileDistList);
            this.gbxAdmin.Controls.Add(this.tileUserMan);
            this.gbxAdmin.Location = new System.Drawing.Point(347, 224);
            this.gbxAdmin.Name = "gbxAdmin";
            this.gbxAdmin.Size = new System.Drawing.Size(310, 280);
            this.gbxAdmin.TabIndex = 15;
            this.gbxAdmin.TabStop = false;
            this.gbxAdmin.Text = "Administration";
            // 
            // dashPanel
            // 
            this.dashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.dashPanel.Controls.Add(this.tileLogout);
            this.dashPanel.Controls.Add(this.metroTile1);
            this.dashPanel.Controls.Add(this.tileAbout);
            this.dashPanel.Location = new System.Drawing.Point(781, 63);
            this.dashPanel.Name = "dashPanel";
            this.dashPanel.Size = new System.Drawing.Size(90, 441);
            this.dashPanel.TabIndex = 16;
            // 
            // consoleTxt
            // 
            this.consoleTxt.BackColor = System.Drawing.SystemColors.WindowText;
            this.consoleTxt.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTxt.ForeColor = System.Drawing.SystemColors.Window;
            this.consoleTxt.Location = new System.Drawing.Point(26, 529);
            this.consoleTxt.Name = "consoleTxt";
            this.consoleTxt.ReadOnly = true;
            this.consoleTxt.Size = new System.Drawing.Size(845, 140);
            this.consoleTxt.TabIndex = 17;
            this.consoleTxt.Text = "";
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogo.Image")));
            this.pbxLogo.Location = new System.Drawing.Point(5, 6);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(71, 51);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 18;
            this.pbxLogo.TabStop = false;
            this.pbxLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbxLogo_MouseUp);
            // 
            // tileLogout
            // 
            this.tileLogout.ActiveControl = null;
            this.tileLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileLogout.Location = new System.Drawing.Point(3, 180);
            this.tileLogout.Name = "tileLogout";
            this.tileLogout.Size = new System.Drawing.Size(84, 82);
            this.tileLogout.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileLogout.TabIndex = 8;
            this.tileLogout.Text = "Logout";
            this.tileLogout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileLogout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileLogout.TileImage = ((System.Drawing.Image)(resources.GetObject("tileLogout.TileImage")));
            this.tileLogout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileLogout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileLogout.UseSelectable = true;
            this.tileLogout.UseTileImage = true;
            this.tileLogout.Click += new System.EventHandler(this.tileLogout_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroTile1.Location = new System.Drawing.Point(3, 91);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(84, 82);
            this.metroTile1.Style = MetroFramework.MetroColorStyle.Silver;
            this.metroTile1.TabIndex = 8;
            this.metroTile1.Text = "About";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroTile1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTile1.TileImage = ((System.Drawing.Image)(resources.GetObject("metroTile1.TileImage")));
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // tileAbout
            // 
            this.tileAbout.ActiveControl = null;
            this.tileAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileAbout.Location = new System.Drawing.Point(3, 3);
            this.tileAbout.Name = "tileAbout";
            this.tileAbout.Size = new System.Drawing.Size(84, 82);
            this.tileAbout.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileAbout.TabIndex = 8;
            this.tileAbout.Text = "User Info.";
            this.tileAbout.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileAbout.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.tileAbout.TileImage = ((System.Drawing.Image)(resources.GetObject("tileAbout.TileImage")));
            this.tileAbout.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileAbout.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileAbout.UseSelectable = true;
            this.tileAbout.UseTileImage = true;
            this.tileAbout.Click += new System.EventHandler(this.tileAbout_Click);
            // 
            // tileDistList
            // 
            this.tileDistList.ActiveControl = null;
            this.tileDistList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDistList.Location = new System.Drawing.Point(17, 147);
            this.tileDistList.Name = "tileDistList";
            this.tileDistList.Size = new System.Drawing.Size(276, 123);
            this.tileDistList.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileDistList.TabIndex = 8;
            this.tileDistList.Text = "Manage Distribution List";
            this.tileDistList.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDistList.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDistList.TileImage")));
            this.tileDistList.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDistList.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileDistList.UseSelectable = true;
            this.tileDistList.UseTileImage = true;
            this.tileDistList.Click += new System.EventHandler(this.tileDistList_Click);
            // 
            // tileUserMan
            // 
            this.tileUserMan.ActiveControl = null;
            this.tileUserMan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileUserMan.Location = new System.Drawing.Point(17, 19);
            this.tileUserMan.Name = "tileUserMan";
            this.tileUserMan.Size = new System.Drawing.Size(276, 123);
            this.tileUserMan.Style = MetroFramework.MetroColorStyle.Purple;
            this.tileUserMan.TabIndex = 8;
            this.tileUserMan.Text = "User Manager";
            this.tileUserMan.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileUserMan.TileImage = ((System.Drawing.Image)(resources.GetObject("tileUserMan.TileImage")));
            this.tileUserMan.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileUserMan.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileUserMan.UseSelectable = true;
            this.tileUserMan.UseTileImage = true;
            this.tileUserMan.Click += new System.EventHandler(this.tileUserMan_Click);
            // 
            // tileVerify
            // 
            this.tileVerify.ActiveControl = null;
            this.tileVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileVerify.Location = new System.Drawing.Point(17, 23);
            this.tileVerify.Name = "tileVerify";
            this.tileVerify.Size = new System.Drawing.Size(135, 117);
            this.tileVerify.Style = MetroFramework.MetroColorStyle.Silver;
            this.tileVerify.TabIndex = 0;
            this.tileVerify.Text = "Verify File";
            this.tileVerify.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileVerify.TileImage = ((System.Drawing.Image)(resources.GetObject("tileVerify.TileImage")));
            this.tileVerify.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVerify.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileVerify.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileVerify.UseSelectable = true;
            this.tileVerify.UseTileImage = true;
            this.tileVerify.Click += new System.EventHandler(this.tileVerify_Click);
            // 
            // tileHeadView
            // 
            this.tileHeadView.ActiveControl = null;
            this.tileHeadView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileHeadView.Location = new System.Drawing.Point(158, 23);
            this.tileHeadView.Name = "tileHeadView";
            this.tileHeadView.Size = new System.Drawing.Size(135, 117);
            this.tileHeadView.Style = MetroFramework.MetroColorStyle.Orange;
            this.tileHeadView.TabIndex = 1;
            this.tileHeadView.Text = "View Headers";
            this.tileHeadView.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileHeadView.TileImage = ((System.Drawing.Image)(resources.GetObject("tileHeadView.TileImage")));
            this.tileHeadView.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileHeadView.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.tileHeadView.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileHeadView.UseSelectable = true;
            this.tileHeadView.UseTileImage = true;
            this.tileHeadView.Click += new System.EventHandler(this.tileHeadView_Click);
            // 
            // tileEncrypt
            // 
            this.tileEncrypt.ActiveControl = null;
            this.tileEncrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileEncrypt.Location = new System.Drawing.Point(6, 23);
            this.tileEncrypt.Name = "tileEncrypt";
            this.tileEncrypt.Size = new System.Drawing.Size(257, 132);
            this.tileEncrypt.TabIndex = 9;
            this.tileEncrypt.Text = "Encrypt PDF";
            this.tileEncrypt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileEncrypt.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEncrypt.TileImage")));
            this.tileEncrypt.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEncrypt.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileEncrypt.UseSelectable = true;
            this.tileEncrypt.UseTileImage = true;
            this.tileEncrypt.Click += new System.EventHandler(this.tileEncrypt_Click);
            // 
            // tileDecrypt
            // 
            this.tileDecrypt.ActiveControl = null;
            this.tileDecrypt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileDecrypt.Location = new System.Drawing.Point(6, 161);
            this.tileDecrypt.Name = "tileDecrypt";
            this.tileDecrypt.Size = new System.Drawing.Size(257, 132);
            this.tileDecrypt.Style = MetroFramework.MetroColorStyle.Green;
            this.tileDecrypt.TabIndex = 10;
            this.tileDecrypt.Text = "Decrypt PDF";
            this.tileDecrypt.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileDecrypt.TileImage = ((System.Drawing.Image)(resources.GetObject("tileDecrypt.TileImage")));
            this.tileDecrypt.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileDecrypt.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileDecrypt.UseSelectable = true;
            this.tileDecrypt.UseTileImage = true;
            this.tileDecrypt.Click += new System.EventHandler(this.tileDecrypt_Click);
            // 
            // tileEmbedMark
            // 
            this.tileEmbedMark.ActiveControl = null;
            this.tileEmbedMark.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tileEmbedMark.Location = new System.Drawing.Point(6, 299);
            this.tileEmbedMark.Name = "tileEmbedMark";
            this.tileEmbedMark.Size = new System.Drawing.Size(257, 132);
            this.tileEmbedMark.Style = MetroFramework.MetroColorStyle.Teal;
            this.tileEmbedMark.TabIndex = 2;
            this.tileEmbedMark.Text = "Embed Watermark";
            this.tileEmbedMark.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tileEmbedMark.TileImage = ((System.Drawing.Image)(resources.GetObject("tileEmbedMark.TileImage")));
            this.tileEmbedMark.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileEmbedMark.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.tileEmbedMark.UseSelectable = true;
            this.tileEmbedMark.UseTileImage = true;
            this.tileEmbedMark.Click += new System.EventHandler(this.tileEmbedMark_Click);
            // 
            // FrmMain
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 734);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.consoleTxt);
            this.Controls.Add(this.dashPanel);
            this.Controls.Add(this.gbxAdmin);
            this.Controls.Add(this.gbxIntegrity);
            this.Controls.Add(this.gbxMain);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.prgMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.Resizable = false;
            this.Text = "DocSign GUI - Dashboard";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.gbxMain.ResumeLayout(false);
            this.gbxIntegrity.ResumeLayout(false);
            this.gbxAdmin.ResumeLayout(false);
            this.dashPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile tileVerify;
        private MetroFramework.Controls.MetroTile tileHeadView;
        private MetroFramework.Controls.MetroTile tileEmbedMark;
        private MetroFramework.Controls.MetroTile tileUserMan;
        private MetroFramework.Controls.MetroTile tileEncrypt;
        private MetroFramework.Controls.MetroTile tileDecrypt;
        private System.Windows.Forms.Timer progressTimer;
        private MetroFramework.Controls.MetroProgressBar prgMain;
        private System.Windows.Forms.Label lblStatus;
        private MetroFramework.Controls.MetroTile tileAbout;
        private MetroFramework.Controls.MetroTile tileLogout;
        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.GroupBox gbxIntegrity;
        private System.Windows.Forms.GroupBox gbxAdmin;
        private MetroFramework.Controls.MetroTile tileDistList;
        private System.Windows.Forms.Panel dashPanel;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.RichTextBox consoleTxt;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}