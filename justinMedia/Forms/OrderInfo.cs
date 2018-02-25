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
    public partial class OrderInfo : Form {

        SMM api;
        SMM.Order order;

        public OrderInfo(SMM api, SMM.Order order) {
            InitializeComponent();
            this.api = api;
            this.order = order;
            //this.Text += order.GetID();
            UpdateForm();
        }

        private void UpdateForm() {
            this.Text = "justinMedia - Order #" + order.GetID();
            lblOrderID.Text = Convert.ToString(order.GetID());
            lblOrderType.Text = order.GetOrderType();
            lblOrderCharge.Text = "$" + order.GetCharge();
            lblStartCount.Text = Convert.ToString(order.GetStartCount());
            lblRemaining.Text = Convert.ToString(order.GetRemaining());
            lblCompleted.Text = order.IsCompleted() ? "True" : "False";
            lblLastUpdate.Text = Convert.ToString(order.GetLastUpdate());
        }

        private void btnForceUpdate_Click(object sender, EventArgs e) {
            order.UpdateData(api);
            UpdateForm();
        }

    }
}
