namespace DocSignGUI
{
    partial class FrmHeaders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHeaders));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxUserInfo = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.txtUserType = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.txtNtAcc = new System.Windows.Forms.TextBox();
            this.txtExtIp = new System.Windows.Forms.TextBox();
            this.txtIntIp = new System.Windows.Forms.TextBox();
            this.txtDevName = new System.Windows.Forms.TextBox();
            this.txtPdf = new System.Windows.Forms.TextBox();
            this.txtEncPdf = new System.Windows.Forms.TextBox();
            this.txtMagic = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.gbxUserInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.gbxUserInfo);
            this.groupBox1.Controls.Add(this.txtNtAcc);
            this.groupBox1.Controls.Add(this.txtExtIp);
            this.groupBox1.Controls.Add(this.txtIntIp);
            this.groupBox1.Controls.Add(this.txtDevName);
            this.groupBox1.Controls.Add(this.txtPdf);
            this.groupBox1.Controls.Add(this.txtEncPdf);
            this.groupBox1.Controls.Add(this.txtMagic);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(426, 473);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(339, 443);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbxUserInfo
            // 
            this.gbxUserInfo.Controls.Add(this.label13);
            this.gbxUserInfo.Controls.Add(this.label12);
            this.gbxUserInfo.Controls.Add(this.label11);
            this.gbxUserInfo.Controls.Add(this.label10);
            this.gbxUserInfo.Controls.Add(this.label9);
            this.gbxUserInfo.Controls.Add(this.label8);
            this.gbxUserInfo.Controls.Add(this.txtDeptName);
            this.gbxUserInfo.Controls.Add(this.txtDeptId);
            this.gbxUserInfo.Controls.Add(this.txtUserType);
            this.gbxUserInfo.Controls.Add(this.txtEmail);
            this.gbxUserInfo.Controls.Add(this.txtUsername);
            this.gbxUserInfo.Controls.Add(this.txtUserId);
            this.gbxUserInfo.Location = new System.Drawing.Point(12, 240);
            this.gbxUserInfo.Name = "gbxUserInfo";
            this.gbxUserInfo.Size = new System.Drawing.Size(402, 197);
            this.gbxUserInfo.TabIndex = 11;
            this.gbxUserInfo.TabStop = false;
            this.gbxUserInfo.Text = "User Information";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 163);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Dept Name : ";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(35, 137);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Dept Id : ";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "User Type : ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(45, 85);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Email : ";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 59);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Username : ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "User Id : ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(98, 160);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(298, 20);
            this.txtDeptName.TabIndex = 10;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(98, 134);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.Size = new System.Drawing.Size(298, 20);
            this.txtDeptId.TabIndex = 10;
            // 
            // txtUserType
            // 
            this.txtUserType.Location = new System.Drawing.Point(98, 108);
            this.txtUserType.Name = "txtUserType";
            this.txtUserType.ReadOnly = true;
            this.txtUserType.Size = new System.Drawing.Size(298, 20);
            this.txtUserType.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(98, 82);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(298, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(98, 56);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(298, 20);
            this.txtUsername.TabIndex = 10;
            // 
            // txtUserId
            // 
            this.txtUserId.Location = new System.Drawing.Point(98, 30);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(298, 20);
            this.txtUserId.TabIndex = 10;
            // 
            // txtNtAcc
            // 
            this.txtNtAcc.Location = new System.Drawing.Point(116, 195);
            this.txtNtAcc.Name = "txtNtAcc";
            this.txtNtAcc.ReadOnly = true;
            this.txtNtAcc.Size = new System.Drawing.Size(298, 20);
            this.txtNtAcc.TabIndex = 10;
            // 
            // txtExtIp
            // 
            this.txtExtIp.Location = new System.Drawing.Point(116, 169);
            this.txtExtIp.Name = "txtExtIp";
            this.txtExtIp.ReadOnly = true;
            this.txtExtIp.Size = new System.Drawing.Size(298, 20);
            this.txtExtIp.TabIndex = 10;
            // 
            // txtIntIp
            // 
            this.txtIntIp.Location = new System.Drawing.Point(116, 143);
            this.txtIntIp.Name = "txtIntIp";
            this.txtIntIp.ReadOnly = true;
            this.txtIntIp.Size = new System.Drawing.Size(298, 20);
            this.txtIntIp.TabIndex = 9;
            // 
            // txtDevName
            // 
            this.txtDevName.Location = new System.Drawing.Point(116, 113);
            this.txtDevName.Name = "txtDevName";
            this.txtDevName.ReadOnly = true;
            this.txtDevName.Size = new System.Drawing.Size(298, 20);
            this.txtDevName.TabIndex = 8;
            // 
            // txtPdf
            // 
            this.txtPdf.Location = new System.Drawing.Point(116, 87);
            this.txtPdf.Name = "txtPdf";
            this.txtPdf.ReadOnly = true;
            this.txtPdf.Size = new System.Drawing.Size(298, 20);
            this.txtPdf.TabIndex = 7;
            // 
            // txtEncPdf
            // 
            this.txtEncPdf.Location = new System.Drawing.Point(116, 61);
            this.txtEncPdf.Name = "txtEncPdf";
            this.txtEncPdf.ReadOnly = true;
            this.txtEncPdf.Size = new System.Drawing.Size(298, 20);
            this.txtEncPdf.TabIndex = 6;
            // 
            // txtMagic
            // 
            this.txtMagic.Location = new System.Drawing.Point(116, 35);
            this.txtMagic.Name = "txtMagic";
            this.txtMagic.ReadOnly = true;
            this.txtMagic.Size = new System.Drawing.Size(298, 20);
            this.txtMagic.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "PDF Hash : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ENCPDF Hash : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Nt Account : ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Dev. Ext. IP : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Dev. Int. IP : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Device Name : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Magic No : ";
            // 
            // FrmHeaders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 473);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmHeaders";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Header Information";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxUserInfo.ResumeLayout(false);
            this.gbxUserInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtExtIp;
        private System.Windows.Forms.TextBox txtIntIp;
        private System.Windows.Forms.TextBox txtDevName;
        private System.Windows.Forms.TextBox txtPdf;
        private System.Windows.Forms.TextBox txtEncPdf;
        private System.Windows.Forms.TextBox txtMagic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNtAcc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbxUserInfo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtUserType;
    }
}