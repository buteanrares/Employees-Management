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
        private int extraHours;
        private int extraMoney;
        private int payDock;
        private String month;


        public FlyerForm(Service service, DataGridViewRow EmployeeRow, int extraHours, int extraMoney, int payDock, String month) {
            this.Service = service;
            this.EmployeeRow = EmployeeRow;
            this.extraHours = extraHours;
            this.extraMoney = extraMoney;
            this.payDock = payDock;
            this.month = month;
            InitializeComponent();
        }

        private void FlyerForm_Load(object sender, EventArgs e) {
            Employee employee = Service.GetEmployee(Convert.ToInt32(EmployeeRow.Cells[0].Value));
            Dictionary<String, double> FlyerData = new Dictionary<String, double>(Service.GenerateFlyer(employee.ID,extraHours,extraMoney,payDock));
            
            companyName.Text = Service.GetCompany(employee.EmployerID).Name;
            dateLabel.Text = month + " / 2020";
            employeeNameHolder.Text = employee.Name;
            grossSalaryHolder.Text = Convert.ToString(FlyerData["Salariu de baza"]);
            hoursHolder.Text = "168 (" + Convert.ToString(FlyerData["Ore standard"]) + " lei/ora)";
            extraHoursHolder.Text = Convert.ToString(extraHours) + " (" + Convert.ToString(FlyerData["Ore suplimentare"]) + " lei/ora)";
            extraMoneyHolder.Text = Convert.ToString(FlyerData["Sporuri"]);
            grossSalaryHolder2.Text = Convert.ToString(FlyerData["Salariu brut"]);
            CASHolder.Text = Convert.ToString(FlyerData["CAS"]);
            CASSHolder.Text = Convert.ToString(FlyerData["CASS"]);
            IVHolder.Text = Convert.ToString(FlyerData["IV"]);
            TotalHolder.Text = Convert.ToString(FlyerData["Total taxe"]);
            netSalaryHolder.Text = Convert.ToString(FlyerData["Salariu net"]);
            monthlyTaxHolder.Text = Convert.ToString(FlyerData["Retineri"]);
            cashValueHolder.Text = Convert.ToString(FlyerData["Rest de plata"]);
        }

    }
}
