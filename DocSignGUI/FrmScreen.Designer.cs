namespace DocSignGUI
{
    partial class FrmScreen
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
            this.drawTimer = new System.Windows.Forms.Timer(this.components);
            this.imgTimer = new System.Windows.Forms.Timer(this.components);
            this.msgPanel = new DocSignGUI.GhostPanel();
            this.msgTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // drawTimer
            // 
            this.drawTimer.Interval = 1;
            this.drawTimer.Tick += new System.EventHandler(this.drawTimer_Tick);
            // 
            // imgTimer
            // 
            this.imgTimer.Interval = 1;
            this.imgTimer.Tick += new System.EventHandler(this.imgTimer_Tick);
            // 
            // msgPanel
            // 
            this.msgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msgPanel.Location = new System.Drawing.Point(0, 0);
            this.msgPanel.Name = "msgPanel";
            this.msgPanel.Size = new System.Drawing.Size(800, 450);
            this.msgPanel.TabIndex = 0;
            // 
            // msgTimer
            // 
            this.msgTimer.Interval = 3000;
            this.msgTimer.Tick += new System.EventHandler(this.msgTimer_Tick);
            // 
            // FrmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.msgPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmScreen";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmScreen_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer drawTimer;
        private System.Windows.Forms.Timer imgTimer;
        private System.Windows.Forms.Timer msgTimer;
        private GhostPanel msgPanel;
    }
}