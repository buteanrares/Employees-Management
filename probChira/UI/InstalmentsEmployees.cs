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
    public partial class InstalmentsEmployeesForm : Form
    {
        private Service service;
        public InstalmentsEmployeesForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void InstalmentsEmployees_Load(object sender, EventArgs e) {
            foreach(Employee emp in this.service.GetEmployees()) {
                if (emp.InstalmentsValue != 0) {
                    EmployeesDGV_AddEmployee(emp);
                }
            }
        }

        private void EmployeesDGV_AddEmployee(Employee emp) {
            dataGridView1.Rows.Add(emp.Name, emp.InstalmentsValue, emp.monthsForInstalments, emp.InstalmentsValue * emp.monthsForInstalments);
        }
    }
}
