using System;
using System.Windows.Forms;

namespace MyNet
{
    public partial class frmCheckingUpdates : Form
    {
        public frmCheckingUpdates()
        {
            InitializeComponent();
        }

        public bool UpdateAvailable { get; set; }

        private async void frmCheckingUpdates_Load(object sender, EventArgs e)
        {
            try
            {
                if (await SelfUpdatingApp.Installer.IsUpdateAvailableAsync(Program.APP_ID))
                    UpdateAvailable = true;
            }
            catch (AggregateException aex)
            {
                foreach(var ex in aex.InnerExceptions)
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }
    }
}
