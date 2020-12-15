using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probChira.UI
{
    public partial class GenerateFlyerForm : Form
    {
        private Service service;
        private DataGridViewRow row;

        public GenerateFlyerForm(Service service, DataGridViewRow row) {
            this.service = service;
            this.row = row;
            InitializeComponent();
        }

        private void generateFlyer_Click(object sender, EventArgs e) {
            int extraHours = Convert.ToInt32(extraHoursTextBox.Text);
            int extraMoney = Convert.ToInt32(extraMoneyTextBox.Text);
            int payDock = Convert.ToInt32(payDockTextBox.Text);
            var FlyerForm = new FlyerForm(service,row,extraHours,extraMoney,payDock,monthComboBox.Text);
            FlyerForm.Show();
        }
    }
}
