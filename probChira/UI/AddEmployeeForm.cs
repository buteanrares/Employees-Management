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
    public partial class AddEmployeeForm : Form
    {
        private Service service;
        public AddEmployeeForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

    }
}
