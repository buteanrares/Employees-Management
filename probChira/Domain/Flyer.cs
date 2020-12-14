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

        public Flyer() {
            this.Employee = new Employee();
            this.Company = new Company();
        }

        public Dictionary<String, double> GenerateData() {
            Dictionary<String, double> dataDictionary = new Dictionary<String, double>();

            dataDictionary.Add("Salariu de baza", Employee.GrossSalary);
            dataDictionary.Add("Ore standard", Employee.GrossSalary / 168);
            dataDictionary.Add("Salariu brut", Employee.GrossSalary);
            dataDictionary.Add("CAS", 25 * Employee.GrossSalary / 100);
            dataDictionary.Add("CASS", 10 * Employee.GrossSalary / 100);
            dataDictionary.Add("IV", 10 * Employee.GrossSalary / 100);
            dataDictionary.Add("Total taxe", 45  * Employee.GrossSalary / 100);
            dataDictionary.Add("Salariu net", 55 * Employee.GrossSalary / 100);
            dataDictionary.Add("Retineri", Employee.InstalmentsValue);
            dataDictionary.Add("Rest de plata", (55 * Employee.GrossSalary) / 100 - Employee.InstalmentsValue);

            return dataDictionary;
        }
    }
}