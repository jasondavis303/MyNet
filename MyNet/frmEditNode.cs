using System;
using System.IO;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmEditNode : Form
    {
        public frmEditNode()
        {
            InitializeComponent();
            Icon = Properties.Resources.network;
            Text = "Add Node";
            InitControls();
        }

        public frmEditNode(Node node)
        {
            InitializeComponent();
            Text = "Edit Node";
            node.CopyTo(TheNode);
            InitControls();
        }

        public Node TheNode { get; } = new Node();

        private void InitControls()
        {
            tbName.Text = TheNode.Name;
            tbIP.Text = TheNode.IPAddress;
            tbUser.Text = TheNode.Username;
            tbPass.Text = TheNode.Password;

            chkUsePuttyProfile.Checked = TheNode.UsePuttyProfile;
            tbPuttyProfile.Enabled = TheNode.UsePuttyProfile;
            tbPuttyProfile.Text = TheNode.PuttyProfile;
            chkUseWinSCPProfile.Checked = TheNode.UseWinScpProfile;
            tbWinSCPProfile.Enabled = TheNode.UseWinScpProfile;
            tbWinSCPProfile.Text = TheNode.WinScpProfile;
            chkUseSSHKey.Checked = TheNode.UseSshKey;
            tlpSSH.Enabled = TheNode.UseSshKey;

            btnSave.Enabled = false;
        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            TheNode.Name = tbName.Text.Trim();
            EnableSave();
        }

        private void tbIP_TextChanged(object sender, EventArgs e)
        {
            TheNode.IPAddress = tbIP.Text.Trim();
            EnableSave();
        }

        private void tbUser_TextChanged(object sender, EventArgs e)
        {
            TheNode.Username = tbUser.Text.Trim();
            EnableSave();
        }

        private void tbPass_TextChanged(object sender, EventArgs e)
        {
            TheNode.Password = tbPass.Text.Trim();
            EnableSave();
        }

        private void chkUsePuttyProfile_CheckedChanged(object sender, EventArgs e)
        {
            TheNode.UsePuttyProfile = chkUsePuttyProfile.Checked;
            tbPuttyProfile.Enabled = chkUsePuttyProfile.Checked;
            EnableSave();
        }

        private void tbPuttyProfile_TextChanged(object sender, EventArgs e)
        {
            TheNode.PuttyProfile = tbPuttyProfile.Text;
            EnableSave();
        }

        private void chkUseWinSCPProfile_CheckedChanged(object sender, EventArgs e)
        {
            TheNode.UseWinScpProfile = chkUseWinSCPProfile.Checked;
            tbWinSCPProfile.Enabled = chkUseWinSCPProfile.Checked;
            EnableSave();
        }

        private void tbWinSCPProfile_TextChanged(object sender, EventArgs e)
        {
            TheNode.WinScpProfile = tbWinSCPProfile.Text;
            EnableSave();
        }

        private void chkUseSSHKey_CheckedChanged(object sender, EventArgs e)
        {
            TheNode.UseSshKey = chkUseSSHKey.Checked;
            tlpSSH.Enabled = chkUseSSHKey.Checked;
            EnableSave();
        }

        private void btnImportSSH_Click(object sender, EventArgs e)
        {
            if (ofdSSH.ShowDialog() != DialogResult.OK)
                return;

            TheNode.SshKeyFile = ofdSSH.FileName;
            TheNode.SshKeyData = File.ReadAllText(ofdSSH.FileName);           
            EnableSave();
        }

        private void btnEditSSH_Click(object sender, EventArgs e)
        {
            using var f = new frmSSHKey(TheNode);
            f.ShowDialog();
            EnableSave();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }





        private void EnableSave()
        {
            btnSave.Enabled = CanEnableSave();
        }
        
        private bool CanEnableSave()
        {
            if (string.IsNullOrWhiteSpace(tbName.Text.Trim()))
                return false;

            if (string.IsNullOrWhiteSpace(tbIP.Text.Trim()))
                return false;

            if (!string.IsNullOrWhiteSpace(tbUser.Text.Trim()))
                if (!chkUseSSHKey.Checked)
                    if (string.IsNullOrWhiteSpace(tbPass.Text.Trim()))
                        return false;
                
            if (chkUsePuttyProfile.Checked)
                if (string.IsNullOrWhiteSpace(tbPuttyProfile.Text.Trim()))
                    return false;

            if (chkUseWinSCPProfile.Checked)
                if (string.IsNullOrWhiteSpace(tbWinSCPProfile.Text.Trim()))
                    return false;

            if (chkUseSSHKey.Checked)
                if (string.IsNullOrWhiteSpace((TheNode.SshKeyData + string.Empty).Trim()))
                    return false;

            return true;
        }

        
    }
}
