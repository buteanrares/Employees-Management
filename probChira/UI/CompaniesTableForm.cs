using probChira.Domain;
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
    public partial class CompaniesTableForm : Form
    {

        private Service service;
        public CompaniesTableForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void CompaniesTableForm_Load(object sender, EventArgs e) {
            foreach(Company company in this.service.GetCompanies()) {
                dataGridView1.Rows.Add(company.ID, company.Name);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            this.service.DeleteCompany(Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value));
            List<Employee> copyEmployees = new List<Employee>(this.service.GetEmployees());
            foreach(Employee emp in copyEmployees) {
                if (emp.EmployerID == Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value))
                    this.service.DeleteEmployee(emp.ID);
            }
        }

        private void modifyButton_Click(object sender, EventArgs e) {
            var modifyCompanyForm = new ModifyCompanyForm(service,dataGridView1.SelectedRows[0]);
            modifyCompanyForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
