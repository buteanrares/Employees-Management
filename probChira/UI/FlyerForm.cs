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
    public partial class FlyerForm : Form
    {
        private Service Service;
        private DataGridViewRow EmployeeRow;


        public FlyerForm(Service service,DataGridViewRow EmployeeRow) {
            this.Service = service;
            this.EmployeeRow = EmployeeRow;
            InitializeComponent();
        }

        private void FlyerForm_Load(object sender, EventArgs e) {
            Employee employee = Service.GetEmployee(Convert.ToInt32(EmployeeRow.Cells[0].Value));
            Dictionary<String, double> FlyerData = new Dictionary<String, double>(Service.GenerateFlyer(employee.ID));
            
            companyName.Text = Service.GetCompany(employee.EmployerID).Name;
            employeeNamelabel.Text = "Nume salariat";
            employeeNameHolder.Text = employee.Name;
            currencyLabel.Text = "Lei";
            grossSalaryLabel.Text = "Salariu de baza";
            grossSalaryHolder.Text = Convert.ToString(FlyerData["Salariu de baza"]);
            hoursLabel.Text = "Ore standard";
            hoursHolder.Text = "168 (" + Convert.ToString(FlyerData["Ore standard"]) + " lei/ora)";
            grossSalaryLabel2.Text = "Salariu brut";
            grossSalaryHolder2.Text = grossSalaryHolder.Text;
            CASHolder.Text = Convert.ToString(FlyerData["CAS"]);
            CASSHolder.Text = Convert.ToString(FlyerData["CASS"]);
            IVHolder.Text = Convert.ToString(FlyerData["IV"]);
            TotalHolder.Text = Convert.ToString(FlyerData["Total taxe"]);
            netSalaryLabel.Text = "Salariu net";
            netSalaryHolder.Text = Convert.ToString(FlyerData["Salariu net"]);
            montlyTax.Text = "Retineri";
            monthlyTaxHolder.Text = Convert.ToString(FlyerData["Retineri"]);
            CashLabel.Text = "Rest de plata";
            cashValueHolder.Text = Convert.ToString(FlyerData["Rest de plata"]);
        }
    }
}
