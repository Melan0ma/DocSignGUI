namespace DocSignGUI
{
    partial class FrmDistManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDistManager));
            this.gbxListItem = new System.Windows.Forms.GroupBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtDept = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbxDeptData = new System.Windows.Forms.GroupBox();
            this.rtxtDeptDesc = new System.Windows.Forms.RichTextBox();
            this.txtDeptName = new System.Windows.Forms.TextBox();
            this.txtDeptId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxViewData = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbxListItem.SuspendLayout();
            this.gbxDeptData.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxListItem
            // 
            this.gbxListItem.Controls.Add(this.btnLoad);
            this.gbxListItem.Controls.Add(this.txtDept);
            this.gbxListItem.Controls.Add(this.label1);
            this.gbxListItem.Location = new System.Drawing.Point(12, 12);
            this.gbxListItem.Name = "gbxListItem";
            this.gbxListItem.Size = new System.Drawing.Size(447, 63);
            this.gbxListItem.TabIndex = 0;
            this.gbxListItem.TabStop = false;
            this.gbxListItem.Text = "Load Distribution List Item";
            this.gbxListItem.Enter += new System.EventHandler(this.gbxListItem_Enter);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(388, 25);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(53, 20);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtDept
            // 
            this.txtDept.Location = new System.Drawing.Point(114, 25);
            this.txtDept.Name = "txtDept";
            this.txtDept.Size = new System.Drawing.Size(268, 20);
            this.txtDept.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dept Name : ";
            // 
            // gbxDeptData
            // 
            this.gbxDeptData.Controls.Add(this.rtxtDeptDesc);
            this.gbxDeptData.Controls.Add(this.txtDeptName);
            this.gbxDeptData.Controls.Add(this.txtDeptId);
            this.gbxDeptData.Controls.Add(this.label4);
            this.gbxDeptData.Controls.Add(this.label3);
            this.gbxDeptData.Controls.Add(this.label2);
            this.gbxDeptData.Location = new System.Drawing.Point(12, 104);
            this.gbxDeptData.Name = "gbxDeptData";
            this.gbxDeptData.Size = new System.Drawing.Size(447, 199);
            this.gbxDeptData.TabIndex = 1;
            this.gbxDeptData.TabStop = false;
            this.gbxDeptData.Text = "Department Data";
            this.gbxDeptData.Enter += new System.EventHandler(this.gbxDeptData_Enter);
            // 
            // rtxtDeptDesc
            // 
            this.rtxtDeptDesc.Location = new System.Drawing.Point(114, 89);
            this.rtxtDeptDesc.Name = "rtxtDeptDesc";
            this.rtxtDeptDesc.Size = new System.Drawing.Size(268, 96);
            this.rtxtDeptDesc.TabIndex = 2;
            this.rtxtDeptDesc.Text = "";
            // 
            // txtDeptName
            // 
            this.txtDeptName.Location = new System.Drawing.Point(114, 60);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Size = new System.Drawing.Size(268, 20);
            this.txtDeptName.TabIndex = 1;
            // 
            // txtDeptId
            // 
            this.txtDeptId.Location = new System.Drawing.Point(114, 34);
            this.txtDeptId.Name = "txtDeptId";
            this.txtDeptId.ReadOnly = true;
            this.txtDeptId.Size = new System.Drawing.Size(268, 20);
            this.txtDeptId.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Dept Desc : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Dept Name : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Dept Id : ";
            // 
            // cbxViewData
            // 
            this.cbxViewData.AutoSize = true;
            this.cbxViewData.Location = new System.Drawing.Point(12, 81);
            this.cbxViewData.Name = "cbxViewData";
            this.cbxViewData.Size = new System.Drawing.Size(167, 17);
            this.cbxViewData.TabIndex = 2;
            this.cbxViewData.Text = "View existing department data";
            this.cbxViewData.UseVisualStyleBackColor = true;
            this.cbxViewData.CheckedChanged += new System.EventHandler(this.cbxViewData_CheckedChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(278, 309);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Department";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(384, 309);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmDistManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(471, 338);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cbxViewData);
            this.Controls.Add(this.gbxDeptData);
            this.Controls.Add(this.gbxListItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDistManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Distribution List Manager";
            this.gbxListItem.ResumeLayout(false);
            this.gbxListItem.PerformLayout();
            this.gbxDeptData.ResumeLayout(false);
            this.gbxDeptData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxListItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDept;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox gbxDeptData;
        private System.Windows.Forms.CheckBox cbxViewData;
        private System.Windows.Forms.RichTextBox rtxtDeptDesc;
        private System.Windows.Forms.TextBox txtDeptName;
        private System.Windows.Forms.TextBox txtDeptId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClose;
    }
}