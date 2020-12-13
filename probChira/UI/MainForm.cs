using probChira.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace probChira
{
    public partial class MainForm : Form
    {
        private Service service;

        public MainForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void addEmployeeButton_Click(object sender, EventArgs e) {
            var AddEmployeeForm = new AddEmployeeForm(service);
            AddEmployeeForm.Show();
        }

        private void showEmployeesButton_Click(object sender, EventArgs e) {
            var EmployeesTableForm = new EmployeesTableForm(service);
            EmployeesTableForm.Show();
        }

        private void addCompanyButton_Click(object sender, EventArgs e) {
            var AddCompanyForm = new AddCompanyForm(service);
            AddCompanyForm.Show();
        }

        private void showCompaniesButton_Click(object sender, EventArgs e) {
            var CompaniesTableForm = new CompaniesTableForm(service);
            CompaniesTableForm.Show();
        }


    }
}
