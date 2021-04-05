
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
            this.toolStrip1.SuspendLayout();
            this.tlpMain.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnEdit,
            this.btnDelete,
            this.toolStripSeparator1,
            this.btnImport,
            this.btnExport});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(723, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.ToolTipText = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(23, 22);
            this.btnEdit.ToolTipText = "Edit";
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(23, 22);
            this.btnDelete.ToolTipText = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnImport
            // 
            this.btnImport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnImport.Image = ((System.Drawing.Image)(resources.GetObject("btnImport.Image")));
            this.btnImport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(23, 22);
            this.btnImport.ToolTipText = "Import";
            // 
            // btnExport
            // 
            this.btnExport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(23, 22);
            this.btnExport.ToolTipText = "Export";
            // 
            // lbNodes
            // 
            this.lbNodes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbNodes.FormattingEnabled = true;
            this.lbNodes.IntegralHeight = false;
            this.lbNodes.ItemHeight = 15;
            this.lbNodes.Location = new System.Drawing.Point(0, 25);
            this.lbNodes.Name = "lbNodes";
            this.lbNodes.Size = new System.Drawing.Size(272, 465);
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
            this.tlpMain.Controls.Add(this.label1, 1, 1);
            this.tlpMain.Controls.Add(this.tbName, 2, 1);
            this.tlpMain.Controls.Add(this.label2, 1, 3);
            this.tlpMain.Controls.Add(this.tbIP, 2, 3);
            this.tlpMain.Controls.Add(this.label3, 1, 5);
            this.tlpMain.Controls.Add(this.tbUser, 2, 5);
            this.tlpMain.Controls.Add(this.label4, 1, 7);
            this.tlpMain.Controls.Add(this.tbPass, 2, 7);
            this.tlpMain.Controls.Add(this.tableLayoutPanel2, 1, 9);
            this.tlpMain.Controls.Add(this.cmdCopyPassword, 3, 7);
            this.tlpMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpMain.Enabled = false;
            this.tlpMain.Location = new System.Drawing.Point(272, 25);
            this.tlpMain.Name = "tlpMain";
            this.tlpMain.RowCount = 10;
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
            this.tlpMain.Size = new System.Drawing.Size(451, 465);
            this.tlpMain.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
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
            this.tbName.Location = new System.Drawing.Point(94, 23);
            this.tbName.Name = "tbName";
            this.tbName.ReadOnly = true;
            this.tbName.Size = new System.Drawing.Size(334, 23);
            this.tbName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
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
            this.tbIP.Location = new System.Drawing.Point(94, 72);
            this.tbIP.Name = "tbIP";
            this.tbIP.ReadOnly = true;
            this.tbIP.Size = new System.Drawing.Size(334, 23);
            this.tbIP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 126);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
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
            this.tbUser.Location = new System.Drawing.Point(94, 121);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(334, 23);
            this.tbUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 8, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password:";
            // 
            // tbPass
            // 
            this.tbPass.BackColor = System.Drawing.SystemColors.Window;
            this.tbPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbPass.Location = new System.Drawing.Point(94, 170);
            this.tbPass.Name = "tbPass";
            this.tbPass.ReadOnly = true;
            this.tbPass.Size = new System.Drawing.Size(305, 23);
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 216);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(411, 29);
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
            this.btnNet.Location = new System.Drawing.Point(115, 3);
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
            this.btnWinSCP.Location = new System.Drawing.Point(217, 3);
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
            this.btnPuTTY.Location = new System.Drawing.Point(333, 3);
            this.btnPuTTY.Name = "btnPuTTY";
            this.btnPuTTY.Size = new System.Drawing.Size(75, 23);
            this.btnPuTTY.TabIndex = 3;
            this.btnPuTTY.Text = "PuTTY";
            this.btnPuTTY.UseVisualStyleBackColor = true;
            this.btnPuTTY.Click += new System.EventHandler(this.btnPuTTY_Click);
            // 
            // cmdCopyPassword
            // 
            this.cmdCopyPassword.Location = new System.Drawing.Point(405, 170);
            this.cmdCopyPassword.Name = "cmdCopyPassword";
            this.cmdCopyPassword.Size = new System.Drawing.Size(23, 23);
            this.cmdCopyPassword.TabIndex = 10;
            this.cmdCopyPassword.UseVisualStyleBackColor = true;
            this.cmdCopyPassword.Click += new System.EventHandler(this.cmdCopyPassword_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 490);
            this.Controls.Add(this.tlpMain);
            this.Controls.Add(this.lbNodes);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
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
    }
}

