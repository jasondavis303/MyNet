using System;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmEditNode : Form
    {
        public frmEditNode()
        {
            InitializeComponent();
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
                if (string.IsNullOrWhiteSpace(tbPass.Text.Trim()))
                    return false;

            return true;
        }
    }
}
