using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    internal static class StartupCode
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmBurgerBarn());
        }
    }
}
