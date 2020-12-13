using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace probChira.Domain
{
    public class Company
    {
        public int ID { get; set; }

        public String Name { get; set; }

        public Company(int id, String name) {
            this.ID = id;
            this.Name = name;
        }

        public Company() {
            this.ID = -1;
            this.Name = "noname";
        }
    }
}