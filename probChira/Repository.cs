using probChira.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace probChira
{
    class Repository
    {
        private String DatabasePath;
        private List<Employee> Employees = new List<Employee>();
        private List<Company> Companies = new List<Company>();

        public Repository(String databasePath) {
            this.DatabasePath = databasePath;
        }

        private void SaveEmployees() {


        }

        private void SaveCompanies() {


        }

        private void LoadData() {
            String EmployeesFilepath = @DatabasePath + "\\employees.csv";
            String CompaniesFilepath = @DatabasePath + "\\companies.csv";
            Employees.Clear();
            Companies.Clear();
            if (File.Exists(DatabasePath)) {
                Employees.Clear();
                foreach (var line in File.ReadAllLines(EmployeesFilepath)) {
                    String[] personData = line.Split(',');
                    Employee emp = new Employee(personData);
                    Employees.Add(emp);
                }
            }
            if (File.Exists(apartmentsFilepath)) {
                apartments.Clear();
                foreach (var line in File.ReadAllLines(apartmentsFilepath)) {
                    String[] apartmentData = line.Split(',');
                    Apartment apartment = new Apartment(apartmentData);
                    apartments.Add(apartment);
                }
            }

        }
    }
}