namespace DocSignGUI
{
    partial class FrmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserManager));
            this.gbxMain = new System.Windows.Forms.GroupBox();
            this.gbxUserData = new System.Windows.Forms.GroupBox();
            this.cbxUserType = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtUid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxEdit = new System.Windows.Forms.CheckBox();
            this.gbxLoad = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxMain.SuspendLayout();
            this.gbxUserData.SuspendLayout();
            this.gbxLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxMain
            // 
            this.gbxMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gbxMain.Controls.Add(this.gbxUserData);
            this.gbxMain.Controls.Add(this.cbxEdit);
            this.gbxMain.Controls.Add(this.gbxLoad);
            this.gbxMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbxMain.Location = new System.Drawing.Point(0, 0);
            this.gbxMain.Name = "gbxMain";
            this.gbxMain.Size = new System.Drawing.Size(414, 332);
            this.gbxMain.TabIndex = 0;
            this.gbxMain.TabStop = false;
            // 
            // gbxUserData
            // 
            this.gbxUserData.Controls.Add(this.cbxUserType);
            this.gbxUserData.Controls.Add(this.btnClose);
            this.gbxUserData.Controls.Add(this.btnUpdate);
            this.gbxUserData.Controls.Add(this.btnCreate);
            this.gbxUserData.Controls.Add(this.txtDeptName);
            this.gbxUserData.Controls.Add(this.txtPassword);
            this.gbxUserData.Controls.Add(this.txtEmail);
            this.gbxUserData.Controls.Add(this.txtUsername);
            this.gbxUserData.Controls.Add(this.txtUid);
            this.gbxUserData.Controls.Add(this.label7);
            this.gbxUserData.Controls.Add(this.label6);
            this.gbxUserData.Controls.Add(this.label5);
            this.gbxUserData.Controls.Add(this.label4);
            this.gbxUserData.Controls.Add(this.label3);
            this.gbxUserData.Controls.Add(this.label2);
            this.gbxUserData.Location = new System.Drawing.Point(12, 100);
            this.gbxUserData.Name = "gbxUserData";
            this.gbxUserData.Size = new System.Drawing.Size(390, 223);
            this.gbxUserData.TabIndex = 2;
            this.gbxUserData.TabStop = false;
            this.gbxUserData.Text = "User Data";
            this.gbxUserData.Enter += new System.EventHandler(this.gbxUserData_Enter);
            // 
            // cbxUserType
            // 
            this.cbxUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxUserType.FormattingEnabled = true;
            this.cbxUserType.Items.AddRange(new object[] {
            "ADMIN",
            "USER",
            "DISABLED"});
            this.cbxUserType.Location = new System.Drawing.Point(112, 138);
            this.cbxUserType.Name = "cbxUserType";
            this.cbxUserType.Size = new System.Drawing.Size(272, 21);
            this.cbxUserType.TabIndex = 12;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 190);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 11;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(193, 190);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(110, 23);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Update Details";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(112, 190);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 9;
            this.btnCreate.Text = "Create User";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(112, 164);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(272, 20);
            this.txtDeptName.TabIndex = 8;
            this.txtDeptName.Click += new System.EventHandler(this.txtDeptName_Clicked);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(112, 112);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(272, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(112, 86);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(272, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(112, 60);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(272, 20);
            this.txtUsername.TabIndex = 4;
            // 
            // txtUid
            // 
            this.txtUid.Location = new System.Drawing.Point(112, 35);
            this.txtUid.Name = "txtUid";
            this.txtUid.ReadOnly = true;
            this.txtUid.Size = new System.Drawing.Size(272, 20);
            this.txtUid.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Dept Name : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "User Type : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Password : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Username : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "User Id : ";
            // 
            // cbxEdit
            // 
            this.cbxEdit.AutoSize = true;
            this.cbxEdit.Location = new System.Drawing.Point(12, 77);
            this.cbxEdit.Name = "cbxEdit";
            this.cbxEdit.Size = new System.Drawing.Size(162, 17);
            this.cbxEdit.TabIndex = 3;
            this.cbxEdit.Text = "Edit an existing user account";
            this.cbxEdit.UseVisualStyleBackColor = true;
            this.cbxEdit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // gbxLoad
            // 
            this.gbxLoad.Controls.Add(this.btnLoad);
            this.gbxLoad.Controls.Add(this.txtUser);
            this.gbxLoad.Controls.Add(this.label1);
            this.gbxLoad.Location = new System.Drawing.Point(12, 19);
            this.gbxLoad.Name = "gbxLoad";
            this.gbxLoad.Size = new System.Drawing.Size(390, 52);
            this.gbxLoad.TabIndex = 0;
            this.gbxLoad.TabStop = false;
            this.gbxLoad.Text = "Load User By Username";
            this.gbxLoad.Enter += new System.EventHandler(this.gbxLoad_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(329, 22);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(55, 20);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(112, 22);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(211, 20);
            this.txtUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username : ";
            // 
            // FrmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 332);
            this.Controls.Add(this.gbxMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmUserManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Manager";
            this.Load += new System.EventHandler(this.FrmUserManager_Load);
            this.gbxMain.ResumeLayout(false);
            this.gbxMain.PerformLayout();
            this.gbxUserData.ResumeLayout(false);
            this.gbxUserData.PerformLayout();
            this.gbxLoad.ResumeLayout(false);
            this.gbxLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxMain;
        private System.Windows.Forms.GroupBox gbxLoad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.CheckBox cbxEdit;
        private System.Windows.Forms.GroupBox gbxUserData;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtUid;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cbxUserType;
    }
}