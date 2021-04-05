using System;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmSSHKey : Form
    {
        private readonly Node _node;
        private bool _buttonClicked = false;

        public frmSSHKey(Node node)
        {
            InitializeComponent();
            Icon = Properties.Resources.network;
            _node = node;
            tbKey.Text = _node.SshKeyData;
        }

        private void frmSSHKey_FormClosing(object sender, FormClosingEventArgs e)
        {
            //This handles closing if other than the 2 buttons
            if (_buttonClicked)
                return;

            if(tbKey.Text != _node.SshKeyData)
            {
                var msg = "Do you want to save your changes?";
                var ans = MessageBox.Show(msg, "Key Data Changed", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if(ans == DialogResult.Cancel)
                {
                    e.Cancel = true;
                    return;
                }
                if (ans == DialogResult.Yes)
                    _node.SshKeyData = tbKey.Text;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            tbKey.Text = _node.SshKeyData;
            _buttonClicked = true;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _node.SshKeyData = tbKey.Text;
            _buttonClicked = true;
            Close();
        }
    }
}
