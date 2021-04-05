using System;
using System.Diagnostics;
using System.IO;
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
            Icon = Properties.Resources.network;
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
                    if (_net.Exists(f.TheNode.Name))
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
            LoadNodes(null);
        }

        private void BtnImport_Click(object sender, EventArgs e)
        {
            if (ofdImport.ShowDialog() != DialogResult.OK)
                return;

            var newNodes = NetNodes.Import(ofdImport.FileName);
            var toAdd = new NetNodes();
            foreach (var newNode in newNodes)
            {
                var existingNode = _net.FirstOrDefault(item => item.Name.Equals(newNode.Name, StringComparison.CurrentCultureIgnoreCase));
                if (existingNode != null && !existingNode.IsIdenticalTo(newNode))
                {
                    string suggestedName;
                    int cnt = 0;
                    while (true)
                    {
                        cnt++;
                        suggestedName = $"{newNode.Name} - {cnt}";
                        if (!_net.Exists(suggestedName))
                            break;
                    }
                    var msg = $"The node '{newNode.Name}' already exists. Do you want to import it as '{suggestedName}'?";
                    var ans = MessageBox.Show(msg, "Confirm Rename", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (ans == DialogResult.Cancel)
                        return;
                    if (ans == DialogResult.Yes)
                    {
                        newNode.Name = suggestedName;
                        toAdd.Add(newNode);
                    }
                }
                else
                {
                    toAdd.Add(newNode);
                }
            }

            foreach (var newNode in toAdd)
                _net.Add(newNode);
            _net.Save();
            LoadNodes(SelectedNode?.Name);
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            if (sfdExport.ShowDialog() != DialogResult.OK)
                return;

            _net.Export(sfdExport.FileName);
            MessageBox.Show("Passwords in the exported file are NOT encrypted!\r\n\r\nMake sure you keep the file secure", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lbNodes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbNodes.SelectedIndex == -1)
            {
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                tlpMain.Enabled = false;
                tbName.Text = null;
                tbIP.Text = null;
                tbUser.Text = null;
                tbPass.Text = null;
                chkUsePuttyProfile.Checked = false;
                tbPuttyProfile.Text = null;
                chkWinSCPProfile.Checked = false;
                tbWinSCPProfile.Text = null;
                chkSSHKey.Checked = false;
                tbSSHKeyFile.Text = null;
                return;
            }

            btnEdit.Enabled = true;
            btnDelete.Enabled = true;
            tlpMain.Enabled = true;
            tbName.Text = SelectedNode.Name;
            tbIP.Text = SelectedNode.IPAddress;
            tbUser.Text = SelectedNode.Username;
            tbPass.Text = SelectedNode.Password;
            chkUsePuttyProfile.Checked = SelectedNode.UsePuttyProfile;
            tbPuttyProfile.Text = SelectedNode.PuttyProfile;
            chkWinSCPProfile.Checked = SelectedNode.UseWinScpProfile;
            tbWinSCPProfile.Text = SelectedNode.WinScpProfile;
            chkSSHKey.Checked = SelectedNode.UseSshKey;
            if (string.IsNullOrWhiteSpace(SelectedNode.SshKeyFile))
            {
                tbSSHKeyFile.Text = null;
            }
            else
            {
                if (File.Exists(SelectedNode.SshKeyFile))
                    tbSSHKeyFile.Text = SelectedNode.SshKeyFile;
                else
                    tbSSHKeyFile.Text = null;
            }
        }

        private void cmdCopyPassword_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(SelectedNode.Password);
        }

        private void btnRD_Click(object sender, EventArgs e)
        {
            CreateSystemCredentials();
            string template = Properties.Resources.rdtemplate
                .Replace("{user}", SelectedNode.Username)
                .Replace("{ip}", SelectedNode.IPAddress);

            string tempFile = Path.Combine(Path.GetTempPath(), SelectedNode.HashName() + ".rdp");
            File.WriteAllText(tempFile, template);

            Process.Start("mstsc.exe", tempFile);
        }

        private void btnNet_Click(object sender, EventArgs e)
        {
            CreateSystemCredentials();
            Process.Start("explorer.exe", $@"/n, /e, \\{SelectedNode.IPAddress}");
        }

        private void btnWinSCP_Click(object sender, EventArgs e)
        {
            const string LOC1 = @"C:\Program Files\MartinPikryl\WinSCP\winscp.exe";
            const string LOC2 = @"C:\Program Files (x86)\MartinPikryl\WinSCP\winscp.exe";

            string args = null;
            if (SelectedNode.UseWinScpProfile)
            {
                args = $"\"{SelectedNode.WinScpProfile}\"";
            }
            else
            {
                args = $"{SelectedNode.Username}@{SelectedNode.IPAddress} ";
                if (SelectedNode.UseSshKey)
                    args += $"/privatekey=\"{SelectedNode.SshKeyFile}\"";
                else
                    args += $"/password=\"{SelectedNode.Password}\"";
            }

            string userDefinedPath = Properties.Settings.Default.WinSCP;
            if(RunExe("WinSCP", "winscp.exe", LOC1, LOC2, args, ref userDefinedPath))
            {
                Properties.Settings.Default.WinSCP = userDefinedPath;
                Properties.Settings.Default.Save();
            }

        }

        private void btnPuTTY_Click(object sender, EventArgs e)
        {
            const string LOC1 = @"C:\Program Files\PuTTY\putty.exe";
            const string LOC2 = @"C:\Program Files (x86)\PuTTY\putty.exe";

            string args = null;
            if (SelectedNode.UsePuttyProfile)
            {
                args = $"-load \"{SelectedNode.PuttyProfile}\"";
            }
            else
            {
                args = $"-ssh {SelectedNode.Username}@{SelectedNode.IPAddress} ";
                if (SelectedNode.UseSshKey)
                    args += $"-i \"{SelectedNode.SshKeyFile}\"";
                else
                    args += $"-pw \"{SelectedNode.Password}\"";
            }

            string userDefinedPath = Properties.Settings.Default.PuTTY;
            if (RunExe("PuTTY", "putty.exe", LOC1, LOC2, args, ref userDefinedPath))
            {
                Properties.Settings.Default.PuTTY = userDefinedPath;
                Properties.Settings.Default.Save();
            }
        }




        private void LoadNodes(string toSelect)
        {
            lbNodes.Items.Clear();

            _net = NetNodes.Load();
            _net.Sort();

            bool manuallySelected = false;
            foreach (var node in _net)
            {
                lbNodes.Items.Add(node);
                if (!string.IsNullOrWhiteSpace(toSelect))
                    if (node.Name.Equals(toSelect, StringComparison.CurrentCultureIgnoreCase))
                    {
                        lbNodes.SelectedItem = node;
                        manuallySelected = true;
                    }
            }

            if(!manuallySelected)
                if(lbNodes.Items.Count > 0)
                {
                    lbNodes.SelectedIndex = 0;
                    manuallySelected = true;
                }

            if(!manuallySelected)
                lbNodes_SelectedIndexChanged(lbNodes, EventArgs.Empty);
        }

        private Node SelectedNode => (Node)lbNodes.SelectedItem;

        private void ShowEx(Exception ex) => MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        private void CreateSystemCredentials()
        {
            if (string.IsNullOrWhiteSpace(SelectedNode.Username))
                return;

            string args = $"/add:{SelectedNode.IPAddress} /user:\"{SelectedNode.Username}\" /pass:\"{SelectedNode.Password}\"";
            var psi = new ProcessStartInfo("cmdkey", args) { CreateNoWindow = true };
            var proc = new Process
            {
                StartInfo = new ProcessStartInfo("cmdkey", args)
                {
                    CreateNoWindow = true
                }
            };
            proc.Start();
            proc.WaitForExit();
        }

        private bool SaveKeyIfNeeded()
        {
            if (!SelectedNode.UseSshKey)
                return true;

            if (!string.IsNullOrWhiteSpace(SelectedNode.SshKeyFile))
                if (File.Exists(SelectedNode.SshKeyFile))
                    return true;

            if (sfdSSHKey.ShowDialog() != DialogResult.OK)
                return false;

            return true;
        }

        private bool RunExe(string name, string exe, string altLoc1, string altLoc2, string args, ref string userDefinedPath)
        {
            bool success = false;
            if (!string.IsNullOrWhiteSpace(userDefinedPath))
                success = RunProgram(userDefinedPath, args);

            if (!success)
                success = RunProgram(exe, args);

            if (!success)
                success = RunProgram(altLoc1, args);

            if (!success)
                success = RunProgram(altLoc2, args);

            if (!success)
            {
                MessageBox.Show($"Could not find {exe}. Please specify it's location", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                ofdLocateExe.Filter = $"{exe}|{exe}";
                ofdLocateExe.FileName = null;
                if (ofdLocateExe.ShowDialog() != DialogResult.OK)
                    return false;

                userDefinedPath = ofdLocateExe.FileName;

                success = RunProgram(ofdLocateExe.FileName, args);
            }

            if (!success)
                ShowEx(new Exception($"Could not find {exe}"));

            return success;
        }

        private bool RunProgram(string filename, string args)
        {
            if (string.IsNullOrWhiteSpace(filename))
                return false;

            try
            {
                Process.Start(filename, args);
                return true;
            }
            catch { }
            return false;
        }
    }
}
