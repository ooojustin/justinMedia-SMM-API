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

    public partial class Main : Form {

        SMM api;
        SMM.OrderList orders;
        List<Panel> panels;
        bool openOther = false;

        public Main() {
            InitializeComponent();
            FormClosing += (s, e) => { if (!openOther) Application.Exit(); };
            api = new SMM(Properties.Settings.Default.API_URL, Properties.Settings.Default.API_KEY);
            orders = new SMM.OrderList(Properties.Settings.Default.ORDER_LIST);
            UpdateBalance();
            UpdateOrders();
            if (Properties.Settings.Default.BALANCE_AUTO_UPDATE) {
                timerBalanceUpdate.Interval = Properties.Settings.Default.BALANCE_UPDATE_INTERVAL * 1000;
                timerBalanceUpdate.Start();
            }
            panels = new List<Panel>();
            panels.Add(pnlInstagramFollowers);
            panels.Add(pnlInstagramFollowers);
            panels.Add(pnlInstagramLikes);
            panels.Add(pnlYoutubeLikes);
            panels.Add(pnlYoutubeDislikes);
            foreach (Panel p in panels)
                p.Visible = false;
            cmbService.SelectedIndex = 0;
        }

        private void cmbService_DrawItem(object sender, DrawItemEventArgs e) { DrawComboBoxCentered(sender, e); }
        private void UpdateBalance() { lblBalance.Text = "$" + api.GetBalance(); }
        private void timerBalanceUpdate_Tick(object sender, EventArgs e) { UpdateBalance(); }
        private void OpenOrder(SMM.Order order) { new OrderInfo(api, order).Show(); }
        private void btnOpenOrder_Click(object sender, EventArgs e) { OpenSelectedOrder(); }
        private void lbOrders_DoubleClick(object sender, EventArgs e) { OpenSelectedOrder(); }

        private void UpdateOrders() {
            lbOrders.Items.Clear();
            foreach (SMM.Order order in orders.GetList()) {
                int orderID = order.GetID();
                string orderType = order.GetOrderType();
                lbOrders.Items.Add(orderID + " | " + orderType);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e) {
            openOther = true;
            new Settings().Show();
            Close();
        }

        private void cmbService_SelectedIndexChanged(object sender, EventArgs e) {
            foreach (Panel p in panels)
                p.Visible = false;
            panels[cmbService.SelectedIndex].Visible = true;
            switch (cmbService.SelectedIndex) {
                case 0: nudInstagramFollowers.LimitValues(100, 45000); break;
                case 1: nudInstagramFollowers.LimitValues(100, 10000); break;
                case 2: nudInstagramLikes.LimitValues(50, 15000); break;
                case 3: nudYoutubeLikes.LimitValues(50, 5000); break;
                case 4: nudYoutubeDislikes.LimitValues(20, 5000); break;
            }
            txtDummy.Focus();
        }
        
        private void btnInstagramAddFollowers_Click(object sender, EventArgs e) {
            bool refill = cmbService.SelectedIndex == 1;
            int id = api.InstagramFollowers(txtInstagramFollowersUsername.Text, Convert.ToInt32(nudInstagramFollowers.Value), refill);
            SMM.Order order = new SMM.Order(id, refill ? "Instagram Followers w/ Refill" : "Instagram Followers");
            OrderPlaced(order);
            MessageBox.Show("Order placed successfully.\nID: " + id, "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAddLikes_Click(object sender, EventArgs e) {
            int id = api.InstagramLikes(txtInstagramLikesPicture.Text, Convert.ToInt32(nudInstagramLikes.Value));
            SMM.Order order = new SMM.Order(id, "Instagram Likes");
            OrderPlaced(order);
            MessageBox.Show("Order placed successfully.\nID: " + id, "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OrderPlaced(SMM.Order order) {
            orders.AddOrder(order);
            orders.SaveOrders();
            UpdateBalance();
            UpdateOrders();
        }

        private void OpenSelectedOrder() {
            if (lbOrders.SelectedIndex < 0) {
                MessageBox.Show("Please select a valid order.", "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string[] data = lbOrders.SelectedItem.ToString().Split(new char[] { '|' });
            int orderID = Convert.ToInt32(data[0].Trim());
            SMM.Order order = orders.GetList().Find(o => o.GetID() == orderID);
            order.UpdateData(api);
            OpenOrder(order);
        }

        public static void DrawComboBoxCentered(object sender, DrawItemEventArgs e) {
            ComboBox combo = (ComboBox)sender;
            if (combo == null) return;
            e.DrawBackground();
            if (e.Index >= 0) {
                StringFormat sf = new StringFormat();
                sf.LineAlignment = StringAlignment.Center;
                sf.Alignment = StringAlignment.Center;
                Brush brush = new SolidBrush(combo.ForeColor);
                if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                    brush = SystemBrushes.HighlightText;
                e.Graphics.DrawString(combo.Items[e.Index].ToString(), combo.Font, brush, e.Bounds, sf);
            }
        }

        private void btnYoutubeDislikes_Click(object sender, EventArgs e) {
            int id = api.YoutubeLikes(txtInstagramLikesPicture.Text, Convert.ToInt32(nudInstagramLikes.Value), true);
            SMM.Order order = new SMM.Order(id, "Youtube Dislikes");
            OrderPlaced(order);
            MessageBox.Show("Order placed successfully.\nID: " + id, "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnYoutubeLikes_Click(object sender, EventArgs e) {
            int id = api.YoutubeLikes(txtInstagramLikesPicture.Text, Convert.ToInt32(nudInstagramLikes.Value));
            SMM.Order order = new SMM.Order(id, "Youtube Likes");
            OrderPlaced(order);
            MessageBox.Show("Order placed successfully.\nID: " + id, "justinMedia", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

public static class Extensions {
    public static void LimitValues(this NumericUpDown nud, int min, int max) {
        nud.Minimum = min;
        nud.Maximum = max;
        nud.Value = min;
    }
}