using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace justinMedia {
    public partial class Init : Form {

        bool openOther = false;

        public Init() {
            InitializeComponent();
            FormClosing += (s, e) => { if (!openOther) Application.Exit(); };
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string key = txtAPIKey.Text;
            if (key.Length != 32) {
                MessageBox.Show("Please enter a valid API Key.", "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Properties.Settings.Default.API_KEY = key;
            Properties.Settings.Default.API_URL = txtAPIURL.Text;
            Properties.Settings.Default.Save();
            openOther = true;
            new Main().Show();
            Close();
        }
    }
}
