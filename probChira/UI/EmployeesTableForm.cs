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
    public partial class EmployeesTableForm : Form
    {
        private Service service;

        public EmployeesTableForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void EmployeesTableForm_Load(object sender, EventArgs e) {
            foreach(Employee emp in this.service.GetEmployees()) {
                EmployeesTableForm_AddEmployeeRow(emp);
            }
        }

        private void EmployeesTableForm_AddEmployeeRow(Employee emp) {
            String companyName = this.service.GetCompany(emp.EmployerID).Name;
            employeesDGV.Rows.Add(emp.ID, emp.Name, companyName, emp.Birthdate, emp.GrossSalary);
        }

        private void searchEmployeeTextbox_TextChanged(object sender, EventArgs e) {
            employeesDGV.Rows.Clear();
            foreach(Employee emp in this.service.GetEmployees()) {
                if (emp.Name.ToLower().Contains(searchEmployeeTextbox.Text.ToLower()))
                    EmployeesTableForm_AddEmployeeRow(emp);
            }
        }

        private void updateButton_Click(object sender, EventArgs e) {
            var ModifyEmployeeForm = new ModifyEmployeeForm(service, this.employeesDGV.SelectedRows[0]);
            ModifyEmployeeForm.Show();
        }

        private void deleteButton_Click(object sender, EventArgs e) {
            int ID = Convert.ToInt32(employeesDGV.SelectedRows[0].Cells[0].Value);
            this.service.DeleteEmployee(ID);
        }

        private void generateFlyer_Click(object sender, EventArgs e) {
            var GenerateFlyerForm = new GenerateFlyerForm(this.service, this.employeesDGV.SelectedRows[0]);
            GenerateFlyerForm.Show();
        }

        private void closeButton_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
