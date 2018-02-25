using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justinMedia {
    static class Program {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check if initialization is required.
            string apiKey = Properties.Settings.Default.API_KEY;
            if (string.IsNullOrEmpty(apiKey))
                new Init().Show();
            else
                new Main().Show();

            Application.Run();

        }
    }
}
