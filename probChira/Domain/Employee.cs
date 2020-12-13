using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probChira.Domain
{
    public class Employee
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public int EmployerID { get; set; }

        public String Birthdate { get; set; }

        public int GrossSalary { get; set; }

        public int InstalmentsValue { get; set; }

        public Employee(int id, String name, int employer, String birthdate, int grossSalary, int instalmentsValue) {
            this.ID = id;
            this.Name = name;
            this.EmployerID = employer;
            this.Birthdate = birthdate;
            this.GrossSalary = grossSalary;
            this.InstalmentsValue = instalmentsValue;
        }

        public Employee() {
            this.ID = -1;
            this.Name = "noname";
            this.EmployerID = -1;
            this.Birthdate = "00/00/0000";
            this.InstalmentsValue = 0;
        }

        public String ToCSV() {
            return ID + "," + Name + "," + EmployerID + "," + Birthdate + "," + GrossSalary + "," + InstalmentsValue;
        }

        private DateTime GetAge() {
            String[] BirthdateData = this.Birthdate.Split('/');
            int day = Convert.ToInt32(BirthdateData[0]);
            int month = Convert.ToInt32(BirthdateData[1]);
            int year = Convert.ToInt32(BirthdateData[2]);

            return new DateTime(year, month, day);
        }

        public bool RetirementThisYear() {
            if (DateTime.Now.Year - this.GetAge().Year >= 65)
                return true;
            return false;
        }
    }
}