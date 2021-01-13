using probChira.Domain;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace probChira
{
    public class Repository
    {
        private String DatabasePath;
        private List<Employee> Employees = new List<Employee>();
        private List<Company> Companies = new List<Company>();
        
        public Repository(String databasePath) {
            this.DatabasePath = databasePath;
        }

        private void SaveEmployees() {
            String employeesFilePath = @DatabasePath + "\\employees.csv";
            if (File.Exists(employeesFilePath)) {
                File.WriteAllText(employeesFilePath, String.Empty);
                using (StreamWriter sw = File.AppendText(employeesFilePath)) {
                    foreach (Employee employee in Employees) {
                        sw.WriteLine(employee.ToCSV());
                    }
                }
            }
        }

        private void SaveCompanies() {
            String companiesFilePath = @DatabasePath + "\\companies.csv";
            if (File.Exists(companiesFilePath)) {
                File.WriteAllText(companiesFilePath, String.Empty);
                using (StreamWriter sw = File.AppendText(companiesFilePath)) {
                    foreach (Company company in Companies) {
                        sw.WriteLine(company.ID+","+company.Name);
                    }
                }
            }
        }

        public void LoadData() {
            String EmployeesFilepath = @DatabasePath + "\\employees.csv";
            String CompaniesFilepath = @DatabasePath + "\\companies.csv";
            Employees.Clear();
            Companies.Clear();
            if (File.Exists(EmployeesFilepath)) {
                foreach (var line in File.ReadAllLines(EmployeesFilepath)) {
                    String[] personData = line.Split(',');
                    int ID = Convert.ToInt32(personData[0]);
                    String name = personData[1];
                    int empID = Convert.ToInt32(personData[2]);
                    String bd = personData[3];
                    int gs = Convert.ToInt32(personData[4]);
                    int iv = Convert.ToInt32(personData[5]);
                    int miv = Convert.ToInt32(personData[6]);

                    Employee emp = new Employee(ID, name, empID, bd, gs, iv, miv);
                    Employees.Add(emp);
                }
            }
            if (File.Exists(CompaniesFilepath)) {
                foreach (var line in File.ReadAllLines(CompaniesFilepath)) {
                    String[] companyData = line.Split(',');
                    int id = Convert.ToInt32(companyData[0]);
                    String name = companyData[1];
                    Companies.Add(new Company(id, name));
                }
            }

        }

        public void Create(Employee e) {
            this.Employees.Add(e);
            this.SaveEmployees();
        }

        public void Create(Company c) {
            this.Companies.Add(c);
            this.SaveCompanies();
        }

        public Employee ReadEmployee(int ID) {
            int index = Employees.FindIndex(emp => emp.ID == ID);
            if (index >= 0)
                return Employees[index];
            return new Employee();
            
        }

        public Company ReadCompany(int ID) {
            int index = Companies.FindIndex(c => c.ID == ID);
            if (index >= 0)
                return Companies[index];
            return new Company();
        }

        public void UpdateEmployee(int ID, Employee e) {
            int index = Employees.FindIndex(emp => emp.ID == e.ID);
            if (index >= 0) {
                Employees[index] = e;
                SaveEmployees();
            }
            return;
        }

        public void UpdateCompany(int ID,Company c) {
            int index = Companies.FindIndex(cmp => cmp.ID == c.ID);
            if (index >= 0) {
                Companies[index] = c;
                SaveCompanies();
            }
            return;
        }

        public void DeleteEmployee(int ID) {
            int index = Employees.FindIndex(emp => emp.ID == ID);
            if (index >= 0) {
                Employees.RemoveAt(index);
                SaveEmployees();
            }
            return;
        }

        public void DeleteCompany(int ID) {
            int index = Companies.FindIndex(c => c.ID == ID);
            if (index >= 0) {
                Companies.RemoveAt(index);
                SaveCompanies();
            }
            return;
        }

        public List<Employee> GetEmployees() {
            return this.Employees;
        }

        public List<Company> GetCompanies() {
            return this.Companies;
        }
    }
}