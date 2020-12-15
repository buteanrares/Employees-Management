using probChira.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probChira
{
    public class Service {
        Repository repo;

        public Service(Repository repo) {
            this.repo = repo;
        }

        public void AddEmployee(String name, int employer, String birthdate, int grossSalary, int instalmentsValue,int monthsForInstalments) {
            Employee e = new Employee(GenerateEmployeeID(), name, employer, birthdate, grossSalary, instalmentsValue, monthsForInstalments);
            this.repo.Create(e);
        }

        public void AddCompany(String name) {
            Company c = new Company(GenerateCompanyID(), name);
            this.repo.Create(c);
        }

        public void UpdateEmployee(int ID, String name, int employer, String birthdate, int grossSalary, int instalmentsValue,int monthsForInstalments) {
            Employee e = new Employee(ID, name, employer, birthdate, grossSalary, instalmentsValue, monthsForInstalments);
            this.repo.UpdateEmployee(ID, e);
        }

        public void UpdateCompany(int ID, String name) {
            Company c = new Company(ID, name);
            this.repo.UpdateCompany(ID,c);
        }

        public void DeleteEmployee(int id) {
            this.repo.DeleteEmployee(id);
        }

        public void DeleteCompany(int id) {
            this.repo.DeleteCompany(id);
        }

        private int GenerateEmployeeID() {
            int id = 1;
            while (this.repo.ReadEmployee(id).ID != -1)
                id++;
            return id;
        }

        private int GenerateCompanyID() {
            int id = 1;
            while (this.repo.ReadCompany(id).ID != -1)
                id++;
            return id;
        }

        public List<Employee> GetEmployees() {
            return this.repo.GetEmployees();
        }

        public List<Company> GetCompanies() {
            return this.repo.GetCompanies();
        }

        public Company GetCompany(int id) {
            return this.repo.ReadCompany(id);
        }

        public Company GetCompany(String name) {
            return this.GetCompanies().Find(company => company.Name == name);
        }

        public Dictionary<String, double> GenerateFlyer(int ID,int extraHours, int extraMoney, int payDock) {
            Flyer flyer = new Flyer(repo.ReadEmployee(ID), repo.ReadCompany(repo.ReadEmployee(ID).EmployerID));
            return flyer.GenerateData(extraHours,extraMoney,payDock);
        }

        public Employee GetEmployee(int ID) {
            return repo.ReadEmployee(ID);
        }
    }
}
