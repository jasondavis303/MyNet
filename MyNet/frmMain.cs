﻿using System;
using System.Linq;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmMain : Form
    {
        private NetNodes _net;

        public frmMain()
        {
            InitializeComponent();
            btnAdd.Click += BtnAdd_Click;
            btnEdit.Click += BtnEdit_Click;
            btnDelete.Click += BtnDelete_Click;
            btnImport.Click += BtnImport_Click;
            btnExport.Click += BtnExport_Click;
        }

        
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadNodes(null);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _net.Save();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            using var f = new frmEditNode();
            if (f.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                _net.AddNode(f.TheNode);
                _net.Save();
                LoadNodes(f.TheNode.Name);
            }
            catch (Exception ex)
            {
                ShowEx(ex);
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            using var f = new frmEditNode(SelectedNode);
            if (f.ShowDialog() != DialogResult.OK)
                return;

            try
            {
                if (!SelectedNode.Name.Equals(f.TheNode.Name, StringComparison.CurrentCultureIgnoreCase))
                    if (_net.Any(item => item.Name.Equals(f.TheNode.Name, StringComparison.CurrentCultureIgnoreCase)))
                        throw new Exception($"Cannot rename node to {f.TheNode.Name}, another node with the same name already exists");
                f.TheNode.CopyTo(SelectedNode);
                _net.Save();
                LoadNodes(f.TheNode.Name);
            }
            catch (Exception ex)
            {
                ShowEx(ex);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var msg = $"Are you sure you want to delete the node {SelectedNode.Name}?";
            var ans = MessageBox.Show(msg, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (ans != DialogResult.Yes)
                return;
            _net.Remove(SelectedNode);
            _net.Save();
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void lbNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNodes.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                tlpMain.Enabled = false;
                return;
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            tlpMain.Enabled = true;
            tbName.Text = SelectedNode.Name;
            tbIP.Text = SelectedNode.IPAddress;
            tbUser.Text = SelectedNode.Username;
            tbPass.Text = SelectedNode.Password;
        }

        private void cmdCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SelectedNode.Password);
        }

        private void btnRD_Click(object sender, EventArgs e)
        {

        }

        private void btnNet_Click(object sender, EventArgs e)
        {

        }

        private void btnWinSCP_Click(object sender, EventArgs e)
        {

        }

        private void btnPuTTY_Click(object sender, EventArgs e)
        {

        }


        private void LoadNodes(string toSelect)
        {
            lbNodes.Items.Clear();
            
            _net = NetNodes.Load();
            _net.Sort();
            foreach (var node in _net)
            {
                lbNodes.Items.Add(node);
                if (!string.IsNullOrWhiteSpace(toSelect))
                    if (node.Name.Equals(toSelect, StringComparison.CurrentCultureIgnoreCase))
                        lbNodes.SelectedItem = node;
            }
        }

        private Node SelectedNode => (Node)lbNodes.SelectedItem;

        private void ShowEx(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
    }
}
