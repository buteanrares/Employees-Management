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
    public partial class RetiringEmployeesForm : Form
    {
        private Service service;

        public RetiringEmployeesForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void RentiringEmployeesForm_Load(object sender, EventArgs e) {
            foreach(Employee employee in this.service.GetEmployees()) {
                if (employee.RetirementThisYear()) {
                    EmployeesDGV_AddEmployee(employee);
                }
            }
        }

        private void EmployeesDGV_AddEmployee(Employee emp) {
            dataGridView1.Rows.Add(emp.Name, this.service.GetCompany(emp.EmployerID).Name, emp.Birthdate);
        }
    }
}
