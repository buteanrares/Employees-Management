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
    public partial class AddEmployeeForm : Form
    {
        private Service service;

        public AddEmployeeForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {
            String name = nameTextBox.Text;
            String companyName = companyTextBox.Text;
            int idCompany = this.service.GetCompany(companyName).ID;
            String birthdate = birthdateTextBox.Text;
            int grossSalary = Convert.ToInt32(grossSalaryTextBox.Text);
            int instalmentsValue = Convert.ToInt32(instalmentsValueTextBox.Text);
            int monthsForInstalments = Convert.ToInt32(monthsForInstalmentsTextBox.Text);

            this.service.AddEmployee(name, idCompany, birthdate, grossSalary, instalmentsValue, monthsForInstalments);
        }
    }
}
