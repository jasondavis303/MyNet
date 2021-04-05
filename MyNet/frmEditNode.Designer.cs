
namespace MyNet
{
    partial class frmEditNode
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
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbWinSCPProfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.chkUsePuttyProfile = new System.Windows.Forms.CheckBox();
            this.tbPuttyProfile = new System.Windows.Forms.TextBox();
            this.chkUseWinSCPProfile = new System.Windows.Forms.CheckBox();
            this.chkUseSSHKey = new System.Windows.Forms.CheckBox();
            this.tlpSSH = new System.Windows.Forms.TableLayoutPanel();
            this.btnImportSSH = new System.Windows.Forms.Button();
            this.btnEditSSH = new System.Windows.Forms.Button();
            this.ofdSSH = new System.Windows.Forms.OpenFileDialog();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tlpSSH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 4;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tbWinSCPProfile, 2, 11);
            this.tlpMain.Controls.Add(this.label1, 1, 1);
            this.tlpMain.Controls.Add(this.tbName, 2, 1);
            this.tlpMain.Controls.Add(this.label2, 1, 3);
            this.tlpMain.Controls.Add(this.tbIP, 2, 3);
            this.tlpMain.Controls.Add(this.label3, 1, 5);
            this.tlpMain.Controls.Add(this.tbUser, 2, 5);
            this.tlpMain.Controls.Add(this.label4, 1, 7);
            this.tlpMain.Controls.Add(this.tbPass, 2, 7);
            this.tlpMain.Controls.Add(this.tableLayoutPanel1, 1, 16);
            this.tlpMain.Controls.Add(this.chkUsePuttyProfile, 1, 9);
            this.tlpMain.Controls.Add(this.tbPuttyProfile, 2, 9);
            this.tlpMain.Controls.Add(this.chkUseWinSCPProfile, 1, 11);
            this.tlpMain.Controls.Add(this.chkUseSSHKey, 1, 13);
            this.tlpMain.Controls.Add(this.tlpSSH, 2, 13);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Location = new System.Drawing.Point(0, 0);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 19;
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Size = new System.Drawing.Size(419, 440);
            this.tlpMain.TabIndex = 3;
            // 
            // tbWinSCPProfile
            // 
            this.tbWinSCPProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbWinSCPProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tbWinSCPProfile.Location = new System.Drawing.Point(137, 268);
            this.tbWinSCPProfile.Name = "tbWinSCPProfile";
            this.tbWinSCPProfile.Size = new System.Drawing.Size(259, 23);
            this.tbWinSCPProfile.TabIndex = 12;
            this.tbWinSCPProfile.TextChanged += new System.EventHandler(this.tbWinSCPProfile_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tbName.Location = new System.Drawing.Point(137, 23);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(259, 23);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "IP Address:";
            // 
            // tbIP
            // 
            this.tbIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbIP.BackColor = System.Drawing.SystemColors.Window;
            this.tbIP.Location = new System.Drawing.Point(137, 72);
            this.tbIP.Name = "tbIP";
            this.tbIP.Size = new System.Drawing.Size(259, 23);
            this.tbIP.TabIndex = 3;
            this.tbIP.TextChanged += new System.EventHandler(this.tbIP_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Username:";
            // 
            // tbUser
            // 
            this.tbUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbUser.BackColor = System.Drawing.SystemColors.Window;
            this.tbUser.Location = new System.Drawing.Point(137, 121);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(259, 23);
            this.tbUser.TabIndex = 5;
            this.tbUser.TextChanged += new System.EventHandler(this.tbUser_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbPass.Location = new System.Drawing.Point(137, 170);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(259, 23);
            this.tbPass.TabIndex = 7;
            this.tbPass.UseSystemPasswordChar = true;
            this.tbPass.TextChanged += new System.EventHandler(this.tbPass_TextChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnSave, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(23, 386);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(373, 29);
            this.tableLayoutPanel1.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(194, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(295, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // chkUsePuttyProfile
            // 
            this.chkUsePuttyProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUsePuttyProfile.AutoSize = true;
            this.chkUsePuttyProfile.Location = new System.Drawing.Point(23, 221);
            this.chkUsePuttyProfile.Name = "chkUsePuttyProfile";
            this.chkUsePuttyProfile.Size = new System.Drawing.Size(99, 19);
            this.chkUsePuttyProfile.TabIndex = 9;
            this.chkUsePuttyProfile.Text = "PuTTY Profile:";
            this.chkUsePuttyProfile.UseVisualStyleBackColor = true;
            this.chkUsePuttyProfile.CheckedChanged += new System.EventHandler(this.chkUsePuttyProfile_CheckedChanged);
            // 
            // tbPuttyProfile
            // 
            this.tbPuttyProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbPuttyProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tbPuttyProfile.Location = new System.Drawing.Point(137, 219);
            this.tbPuttyProfile.Name = "tbPuttyProfile";
            this.tbPuttyProfile.Size = new System.Drawing.Size(259, 23);
            this.tbPuttyProfile.TabIndex = 10;
            this.tbPuttyProfile.TextChanged += new System.EventHandler(this.tbPuttyProfile_TextChanged);
            // 
            // chkUseWinSCPProfile
            // 
            this.chkUseWinSCPProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseWinSCPProfile.AutoSize = true;
            this.chkUseWinSCPProfile.Location = new System.Drawing.Point(23, 270);
            this.chkUseWinSCPProfile.Name = "chkUseWinSCPProfile";
            this.chkUseWinSCPProfile.Size = new System.Drawing.Size(108, 19);
            this.chkUseWinSCPProfile.TabIndex = 11;
            this.chkUseWinSCPProfile.Text = "WinSCP Profile:";
            this.chkUseWinSCPProfile.UseVisualStyleBackColor = true;
            this.chkUseWinSCPProfile.CheckedChanged += new System.EventHandler(this.chkUseWinSCPProfile_CheckedChanged);
            // 
            // chkUseSSHKey
            // 
            this.chkUseSSHKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUseSSHKey.AutoSize = true;
            this.chkUseSSHKey.Location = new System.Drawing.Point(23, 319);
            this.chkUseSSHKey.Name = "chkUseSSHKey";
            this.chkUseSSHKey.Size = new System.Drawing.Size(72, 19);
            this.chkUseSSHKey.TabIndex = 13;
            this.chkUseSSHKey.Text = "SSH Key:";
            this.chkUseSSHKey.UseVisualStyleBackColor = true;
            this.chkUseSSHKey.CheckedChanged += new System.EventHandler(this.chkUseSSHKey_CheckedChanged);
            // 
            // tlpSSH
            // 
            this.tlpSSH.AutoSize = true;
            this.tlpSSH.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tlpSSH.ColumnCount = 2;
            this.tlpSSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSSH.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpSSH.Controls.Add(this.btnImportSSH, 0, 0);
            this.tlpSSH.Controls.Add(this.btnEditSSH, 1, 0);
            this.tlpSSH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpSSH.Enabled = false;
            this.tlpSSH.Location = new System.Drawing.Point(134, 314);
            this.tlpSSH.Margin = new System.Windows.Forms.Padding(0);
            this.tlpSSH.Name = "tlpSSH";
            this.tlpSSH.RowCount = 1;
            this.tlpSSH.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpSSH.Size = new System.Drawing.Size(265, 29);
            this.tlpSSH.TabIndex = 17;
            // 
            // btnImportSSH
            // 
            this.btnImportSSH.Location = new System.Drawing.Point(3, 3);
            this.btnImportSSH.Name = "btnImportSSH";
            this.btnImportSSH.Size = new System.Drawing.Size(75, 23);
            this.btnImportSSH.TabIndex = 14;
            this.btnImportSSH.Text = "Import";
            this.btnImportSSH.UseVisualStyleBackColor = true;
            this.btnImportSSH.Click += new System.EventHandler(this.btnImportSSH_Click);
            // 
            // btnEditSSH
            // 
            this.btnEditSSH.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditSSH.Location = new System.Drawing.Point(187, 3);
            this.btnEditSSH.Name = "btnEditSSH";
            this.btnEditSSH.Size = new System.Drawing.Size(75, 23);
            this.btnEditSSH.TabIndex = 15;
            this.btnEditSSH.Text = "Edit";
            this.btnEditSSH.UseVisualStyleBackColor = true;
            this.btnEditSSH.Click += new System.EventHandler(this.btnEditSSH_Click);
            // 
            // ofdSSH
            // 
            this.ofdSSH.Filter = "PuTTy Key Files (*.ppk)|*.ppk";
            // 
            // frmEditNode
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(419, 440);
            this.Controls.Add(this.tlpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditNode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmEditNode";
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tlpSSH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TextBox tbWinSCPProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.CheckBox chkUsePuttyProfile;
        private System.Windows.Forms.TextBox tbPuttyProfile;
        private System.Windows.Forms.CheckBox chkUseWinSCPProfile;
        private System.Windows.Forms.CheckBox chkUseSSHKey;
        private System.Windows.Forms.TableLayoutPanel tlpSSH;
        private System.Windows.Forms.Button btnImportSSH;
        private System.Windows.Forms.Button btnEditSSH;
        private System.Windows.Forms.OpenFileDialog ofdSSH;
    }
}