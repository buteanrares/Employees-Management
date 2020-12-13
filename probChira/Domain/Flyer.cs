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

        public Dictionary<String, int> GenerateData() {
            Dictionary<String, int> dataDictionary = new Dictionary<String, int>();

            dataDictionary.Add("Salariu de baza", Employee.GrossSalary);
            dataDictionary.Add("Ore standard", Employee.GrossSalary / 168);
            dataDictionary.Add("Salariu brut", Employee.GrossSalary);
            dataDictionary.Add("CAS", 25 / 100 * Employee.GrossSalary);
            dataDictionary.Add("CASS", 10 / 100 * Employee.GrossSalary);
            dataDictionary.Add("IV", 10 / 100 * Employee.GrossSalary);
            dataDictionary.Add("Total taxe", 45 / 100 * Employee.GrossSalary);
            dataDictionary.Add("Salariu net", 55 / 100 * Employee.GrossSalary);
            dataDictionary.Add("Retineri", Employee.InstalmentsValue);
            dataDictionary.Add("Rest de plata", 55 / 100 * Employee.GrossSalary - Employee.InstalmentsValue);

            return dataDictionary;
        }
    }
}