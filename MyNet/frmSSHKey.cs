using System;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmSSHKey : Form
    {
        private readonly Node _node;

        public frmSSHKey(Node node)
        {
            InitializeComponent();
            _node = node;
            tbKey.Text = _node.SshKeyData;
        }

        private void frmSSHKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This handles closing if other than the 2 buttons
            if(tbKey.Text.Trim() != _node.SshKeyData)
            {
                var msg = "Do you want to save your changes?";
                var ans = MessageBox.Show(msg, "Key Data Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(ans == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (ans == DialogResult.Yes)
                    _node.SshKeyData = tbKey.Text.Trim();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbKey.Text = _node.SshKeyData;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _node.SshKeyData = tbKey.Text.Trim();
            Close();
        }
    }
}
