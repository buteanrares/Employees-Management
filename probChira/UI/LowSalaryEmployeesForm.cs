using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using probChira.Domain;

namespace probChira.UI
{
    public partial class LowSalaryEmployeesForm : Form
    {
        private Service service;
        public LowSalaryEmployeesForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void LowSalaryEmployeesForm_Load(object sender, EventArgs e) {
            foreach(Employee employee in service.GetEmployees()) {
                if (employee.GrossSalary <= this.service.getMeanSalary(employee.EmployerID)) {
                    LowSalaryEmployeesDGV_AddEmployee(employee);
                }
            }
        }

        private void LowSalaryEmployeesDGV_AddEmployee(Employee employee) {
            lowSalaryDGV.Rows.Add(employee.Name, this.service.GetCompany(employee.EmployerID).Name, employee.GrossSalary, this.service.getMeanSalary(employee.EmployerID));
        }
    }
}
