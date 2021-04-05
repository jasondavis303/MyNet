
namespace MyNet
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnImport = new System.Windows.Forms.ToolStripButton();
            this.btnExport = new System.Windows.Forms.ToolStripButton();
            this.lbNodes = new System.Windows.Forms.ListBox();
            this.tlpMain = new System.Windows.Forms.TableLayoutPanel();
            this.tbSSHKeyFile = new System.Windows.Forms.TextBox();
            this.tbWinSCPProfile = new System.Windows.Forms.TextBox();
            this.tbPuttyProfile = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRD = new System.Windows.Forms.Button();
            this.btnNet = new System.Windows.Forms.Button();
            this.btnWinSCP = new System.Windows.Forms.Button();
            this.btnPuTTY = new System.Windows.Forms.Button();
            this.cmdCopyPassword = new System.Windows.Forms.Button();
            this.chkUsePuttyProfile = new System.Windows.Forms.CheckBox();
            this.chkWinSCPProfile = new System.Windows.Forms.CheckBox();
            this.chkSSHKey = new System.Windows.Forms.CheckBox();
            this.ofdImport = new System.Windows.Forms.OpenFileDialog();
            this.sfdExport = new System.Windows.Forms.SaveFileDialog();
            this.ofdLocateExe = new System.Windows.Forms.OpenFileDialog();
            this.sfdSSHKey = new System.Windows.Forms.SaveFileDialog();
            this.toolStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnImport,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(664, 39);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(36, 36);
            this.btnAdd.ToolTipText = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(36, 36);
            this.btnEdit.ToolTipText = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 36);
            this.btnDelete.ToolTipText = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(36, 36);
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Margin = new System.Windows.Forms.Padding(8, 1, 8, 2);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(36, 36);
            this.btnExport.ToolTipText = "Export";
            // 
            // lbNodes
            // 
            this.lbNodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNodes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNodes.FormattingEnabled = true;
            this.lbNodes.IntegralHeight = false;
            this.lbNodes.ItemHeight = 21;
            this.lbNodes.Location = new System.Drawing.Point(0, 39);
            this.lbNodes.Name = "lbNodes";
            this.lbNodes.Size = new System.Drawing.Size(272, 432);
            this.lbNodes.TabIndex = 1;
            this.lbNodes.SelectedIndexChanged += new System.EventHandler(this.lbNodes_SelectedIndexChanged);
            // 
            // tlpMain
            // 
            this.tlpMain.ColumnCount = 5;
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpMain.Controls.Add(this.tbSSHKeyFile, 2, 13);
            this.tlpMain.Controls.Add(this.tbWinSCPProfile, 2, 11);
            this.tlpMain.Controls.Add(this.tbPuttyProfile, 2, 9);
            this.tlpMain.Controls.Add(this.label1, 1, 1);
            this.tlpMain.Controls.Add(this.tbName, 2, 1);
            this.tlpMain.Controls.Add(this.label2, 1, 3);
            this.tlpMain.Controls.Add(this.tbIP, 2, 3);
            this.tlpMain.Controls.Add(this.label3, 1, 5);
            this.tlpMain.Controls.Add(this.tbUser, 2, 5);
            this.tlpMain.Controls.Add(this.label4, 1, 7);
            this.tlpMain.Controls.Add(this.tbPass, 2, 7);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 1, 16);
            this.tlpMain.Controls.Add(this.cmdCopyPassword, 3, 7);
            this.tlpMain.Controls.Add(this.chkUsePuttyProfile, 1, 9);
            this.tlpMain.Controls.Add(this.chkWinSCPProfile, 1, 11);
            this.tlpMain.Controls.Add(this.chkSSHKey, 1, 13);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Enabled = false;
            this.tlpMain.Location = new System.Drawing.Point(272, 39);
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
            this.tlpMain.Size = new System.Drawing.Size(392, 432);
            this.tlpMain.TabIndex = 2;
            // 
            // tbSSHKeyFile
            // 
            this.tbSSHKeyFile.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbSSHKeyFile, 2);
            this.tbSSHKeyFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbSSHKeyFile.Location = new System.Drawing.Point(137, 317);
            this.tbSSHKeyFile.Name = "tbSSHKeyFile";
            this.tbSSHKeyFile.ReadOnly = true;
            this.tbSSHKeyFile.Size = new System.Drawing.Size(232, 23);
            this.tbSSHKeyFile.TabIndex = 14;
            // 
            // tbWinSCPProfile
            // 
            this.tbWinSCPProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbWinSCPProfile, 2);
            this.tbWinSCPProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbWinSCPProfile.Location = new System.Drawing.Point(137, 268);
            this.tbWinSCPProfile.Name = "tbWinSCPProfile";
            this.tbWinSCPProfile.ReadOnly = true;
            this.tbWinSCPProfile.Size = new System.Drawing.Size(232, 23);
            this.tbWinSCPProfile.TabIndex = 13;
            // 
            // tbPuttyProfile
            // 
            this.tbPuttyProfile.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbPuttyProfile, 2);
            this.tbPuttyProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPuttyProfile.Location = new System.Drawing.Point(137, 219);
            this.tbPuttyProfile.Name = "tbPuttyProfile";
            this.tbPuttyProfile.ReadOnly = true;
            this.tbPuttyProfile.Size = new System.Drawing.Size(232, 23);
            this.tbPuttyProfile.TabIndex = 12;
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
            this.tbName.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbName, 2);
            this.tbName.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbName.Location = new System.Drawing.Point(137, 23);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(232, 23);
            this.tbName.TabIndex = 1;
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
            this.tbIP.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbIP, 2);
            this.tbIP.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbIP.Location = new System.Drawing.Point(137, 72);
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Size = new System.Drawing.Size(232, 23);
            this.tbIP.TabIndex = 3;
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
            this.tbUser.BackColor = System.Drawing.SystemColors.Window;
            this.tlpMain.SetColumnSpan(this.tbUser, 2);
            this.tbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbUser.Location = new System.Drawing.Point(137, 121);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(232, 23);
            this.tbUser.TabIndex = 5;
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
            this.tbPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPass.Location = new System.Drawing.Point(137, 170);
            this.tbPass.Name = "tbPass";
            this.tbPass.ReadOnly = true;
            this.tbPass.Size = new System.Drawing.Size(203, 23);
            this.tbPass.TabIndex = 7;
            this.tbPass.UseSystemPasswordChar = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tlpMain.SetColumnSpan(this.tableLayoutPanel2, 3);
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.btnRD, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNet, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnWinSCP, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnPuTTY, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 383);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 29);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // btnRD
            // 
            this.btnRD.Location = new System.Drawing.Point(3, 3);
            this.btnRD.Name = "btnRD";
            this.btnRD.Size = new System.Drawing.Size(75, 23);
            this.btnRD.TabIndex = 0;
            this.btnRD.Text = "RD";
            this.btnRD.UseVisualStyleBackColor = true;
            this.btnRD.Click += new System.EventHandler(this.btnRD_Click);
            // 
            // btnNet
            // 
            this.btnNet.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnNet.Location = new System.Drawing.Point(94, 3);
            this.btnNet.Name = "btnNet";
            this.btnNet.Size = new System.Drawing.Size(75, 23);
            this.btnNet.TabIndex = 1;
            this.btnNet.Text = "Net";
            this.btnNet.UseVisualStyleBackColor = true;
            this.btnNet.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // btnWinSCP
            // 
            this.btnWinSCP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnWinSCP.Location = new System.Drawing.Point(182, 3);
            this.btnWinSCP.Name = "btnWinSCP";
            this.btnWinSCP.Size = new System.Drawing.Size(75, 23);
            this.btnWinSCP.TabIndex = 2;
            this.btnWinSCP.Text = "WinSCP";
            this.btnWinSCP.UseVisualStyleBackColor = true;
            this.btnWinSCP.Click += new System.EventHandler(this.btnWinSCP_Click);
            // 
            // btnPuTTY
            // 
            this.btnPuTTY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPuTTY.Location = new System.Drawing.Point(274, 3);
            this.btnPuTTY.Name = "btnPuTTY";
            this.btnPuTTY.Size = new System.Drawing.Size(75, 23);
            this.btnPuTTY.TabIndex = 3;
            this.btnPuTTY.Text = "PuTTY";
            this.btnPuTTY.UseVisualStyleBackColor = true;
            this.btnPuTTY.Click += new System.EventHandler(this.btnPuTTY_Click);
            // 
            // cmdCopyPassword
            // 
            this.cmdCopyPassword.Location = new System.Drawing.Point(346, 170);
            this.cmdCopyPassword.Name = "cmdCopyPassword";
            this.cmdCopyPassword.Size = new System.Drawing.Size(23, 23);
            this.cmdCopyPassword.TabIndex = 10;
            this.cmdCopyPassword.UseVisualStyleBackColor = true;
            this.cmdCopyPassword.Click += new System.EventHandler(this.cmdCopyPassword_Click);
            // 
            // chkUsePuttyProfile
            // 
            this.chkUsePuttyProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkUsePuttyProfile.AutoSize = true;
            this.chkUsePuttyProfile.Enabled = false;
            this.chkUsePuttyProfile.Location = new System.Drawing.Point(23, 221);
            this.chkUsePuttyProfile.Name = "chkUsePuttyProfile";
            this.chkUsePuttyProfile.Size = new System.Drawing.Size(99, 19);
            this.chkUsePuttyProfile.TabIndex = 11;
            this.chkUsePuttyProfile.Text = "PuTTY Profile:";
            this.chkUsePuttyProfile.UseVisualStyleBackColor = true;
            // 
            // chkWinSCPProfile
            // 
            this.chkWinSCPProfile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkWinSCPProfile.AutoSize = true;
            this.chkWinSCPProfile.Enabled = false;
            this.chkWinSCPProfile.Location = new System.Drawing.Point(23, 270);
            this.chkWinSCPProfile.Name = "chkWinSCPProfile";
            this.chkWinSCPProfile.Size = new System.Drawing.Size(108, 19);
            this.chkWinSCPProfile.TabIndex = 15;
            this.chkWinSCPProfile.Text = "WinSCP Profile:";
            this.chkWinSCPProfile.UseVisualStyleBackColor = true;
            // 
            // chkSSHKey
            // 
            this.chkSSHKey.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.chkSSHKey.AutoSize = true;
            this.chkSSHKey.Enabled = false;
            this.chkSSHKey.Location = new System.Drawing.Point(23, 319);
            this.chkSSHKey.Name = "chkSSHKey";
            this.chkSSHKey.Size = new System.Drawing.Size(72, 19);
            this.chkSSHKey.TabIndex = 16;
            this.chkSSHKey.Text = "SSH Key:";
            this.chkSSHKey.UseVisualStyleBackColor = true;
            // 
            // ofdImport
            // 
            this.ofdImport.Filter = "MyNet Files (*.json)|*.json";
            // 
            // sfdExport
            // 
            this.sfdExport.Filter = "MyNet Files (*.json)|*.json";
            // 
            // ofdLocateExe
            // 
            this.ofdLocateExe.Filter = "putty.exe|putty.exe";
            // 
            // sfdSSHKey
            // 
            this.sfdSSHKey.Filter = "PuTTY Key Files (*.ppk)|*.ppk";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 471);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.lbNodes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(680, 510);
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "MyNet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tlpMain.ResumeLayout(false);
            this.tlpMain.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ListBox lbNodes;
        private System.Windows.Forms.TableLayoutPanel tlpMain;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button btnRD;
        private System.Windows.Forms.Button btnNet;
        private System.Windows.Forms.Button btnWinSCP;
        private System.Windows.Forms.Button btnPuTTY;
        private System.Windows.Forms.Button cmdCopyPassword;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnImport;
        private System.Windows.Forms.ToolStripButton btnExport;
        private System.Windows.Forms.OpenFileDialog ofdImport;
        private System.Windows.Forms.SaveFileDialog sfdExport;
        private System.Windows.Forms.TextBox tbSSHKeyFile;
        private System.Windows.Forms.TextBox tbWinSCPProfile;
        private System.Windows.Forms.TextBox tbPuttyProfile;
        private System.Windows.Forms.CheckBox chkUsePuttyProfile;
        private System.Windows.Forms.CheckBox chkWinSCPProfile;
        private System.Windows.Forms.CheckBox chkSSHKey;
        private System.Windows.Forms.OpenFileDialog ofdLocateExe;
        private System.Windows.Forms.SaveFileDialog sfdSSHKey;
    }
}

