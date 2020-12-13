﻿using probChira.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probChira
{
    class Service {
        Repository repo;

        public Service(Repository repo) {
            this.repo = repo;
        }

        public void AddEmployee(String name, int employer, String birthdate, int grossSalary, int instalmentsValue) {
            Employee e = new Employee(GenerateEmployeeID(), name, employer, birthdate, grossSalary, instalmentsValue);
            this.repo.Create(e);
        }

        public void AddCompany(String name) {
            Company c = new Company(GenerateCompanyID(), name);
            this.repo.Create(c);
        }

        public void UpdateEmployee(int oldID, int id, String name, int employer, String birthdate, int grossSalary, int instalmentsValue) {
            Employee e = new Employee(id, name, employer, birthdate, grossSalary, instalmentsValue);
            this.repo.UpdateEmployee(oldID, e);
        }

        public void UpdateCompany(int oldID,int id, String name) {
            Company c = new Company(id, name);
            this.repo.UpdateCompany(oldID,c);
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
    }
}