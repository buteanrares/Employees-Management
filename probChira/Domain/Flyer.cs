using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probChira.Domain
{
    public class Flyer
    {
        public Employee Employee { get; set; }

        public Company Company { get; set; }

        public Flyer(Employee employee, Company company) {
            this.Employee = employee;
            this.Company = company;
        }


        public Dictionary<String, double> GenerateData(int extraHours, int extraMoney, int payDock) {
            Dictionary<String, double> dataDictionary = new Dictionary<String, double>();

            double payPerHour = Math.Round((double)Employee.GrossSalary/168,4);
            double payPerExtraHour = Math.Round((double)175 * payPerHour / 100,4);
            double preTaxSalary = Math.Round((double)Employee.GrossSalary + payPerExtraHour * extraHours + extraMoney,4);

            dataDictionary.Add("Salariu de baza", Employee.GrossSalary);
            dataDictionary.Add("Ore standard", payPerHour);
            dataDictionary.Add("Ore suplimentare", payPerExtraHour);
            dataDictionary.Add("Sporuri", extraMoney);
            dataDictionary.Add("Salariu brut", preTaxSalary);
            dataDictionary.Add("CAS", 25 * preTaxSalary / 100);
            dataDictionary.Add("CASS", 10 * preTaxSalary / 100);
            dataDictionary.Add("IV", 10 * preTaxSalary / 100);
            dataDictionary.Add("Total taxe", 45  * preTaxSalary / 100);
            dataDictionary.Add("Salariu net", 55 * preTaxSalary / 100);
            dataDictionary.Add("Retineri", payDock);
            dataDictionary.Add("Rest de plata", (55 * preTaxSalary) / 100 - payDock);

            return dataDictionary;
        }
    }
}