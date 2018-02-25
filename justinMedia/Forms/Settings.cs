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
    public partial class Settings : Form {

        bool openOther = false;

        public Settings() {
            InitializeComponent();
            FormClosing += (s, e) => { if (!openOther) Application.Exit(); };
        }

        private void Settings_Load(object sender, EventArgs e) {
            txtAPIKey.Text = Properties.Settings.Default.API_KEY;
            txtAPIURL.Text = Properties.Settings.Default.API_URL;
            cbBalanaceAutoUpdate.Checked = Properties.Settings.Default.BALANCE_AUTO_UPDATE;
            nudBalanceInterval.Value = Properties.Settings.Default.BALANCE_UPDATE_INTERVAL;
        }

        private void btnSave_Click(object sender, EventArgs e) {
            string key = txtAPIKey.Text;
            if (key.Length != 32) {
                MessageBox.Show("Please enter a valid API Key.", "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Properties.Settings.Default.API_KEY = key;
            Properties.Settings.Default.API_URL = txtAPIURL.Text;
            Properties.Settings.Default.BALANCE_AUTO_UPDATE = cbBalanaceAutoUpdate.Checked;
            Properties.Settings.Default.BALANCE_UPDATE_INTERVAL = Convert.ToInt32(nudBalanceInterval.Value);
            Properties.Settings.Default.Save();
            openOther = true;
            new Main().Show();
            Close();
        }

        private void btnResetSettings_Click(object sender, EventArgs e) {
            DialogResult response = MessageBox.Show("Are you sure you want to delete your settings?", "justinMedia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (response == DialogResult.Yes) {
                Properties.Settings.Default.Reset();
                openOther = true;
                new Init().Show();
                Close();
            }
        }

    }
}
