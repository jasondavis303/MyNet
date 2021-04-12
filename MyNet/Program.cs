using System;
using System.Windows.Forms;

namespace MyNet
{
    static class Program
    {
        public const string APP_ID = "3DD9B4C4-6090-4A95-B9DB-5C9BF731A704";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                if (SelfUpdatingApp.Installer.IsUpdateAvailableAsync(APP_ID).Result)
                {
                    SelfUpdatingApp.Installer.Launch(APP_ID);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Application.Run(new frmMain());
        }
    }
}
