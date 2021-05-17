using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WypożyczalniaVideo
{
    static class WypozyczalniaVideo
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
        static public int LoggerUserId = 0;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
