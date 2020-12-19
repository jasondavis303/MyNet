using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmMain : Form
    {
        private NetNodes _net;

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _net = NetNodes.Load();
            _net.Sort();
            foreach (var node in _net)
                lbNodes.Items.Add(node);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _net.Save();
        }

        private void lbNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNodes.SelectedIndex == -1)
            {
                tlpMain.Enabled = false;
                return;
            }

            tlpMain.Enabled = true;
            var node = (Node)lbNodes.SelectedItem;
            tbName.Text = node.Name;
            tbIP.Text = node.IPAddress;
            tbUser.Text = node.Username;
            tbPass.Text = node.Password;
        }
    }
}
