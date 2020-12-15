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
    public partial class ModifyEmployeeForm : Form
    {
        private Service service;
        private DataGridViewRow row;

        public ModifyEmployeeForm(Service service, DataGridViewRow row) {
            this.service = service;
            this.row = row;
            InitializeComponent();
        }

        private void modifyButton_Click(object sender, EventArgs e) {
            int companyID = this.service.GetCompany(companyTextBox.Text).ID;
            this.service.UpdateEmployee(Convert.ToInt32(row.Cells[0].Value), nameTextBox.Text, companyID, birthdateTextBox.Text, Convert.ToInt32(grossSalaryTextBox.Text), Convert.ToInt32(instalmentsValueTextBox.Text), Convert.ToInt32(monthsForInstalments.Text));
        }
    }
}
