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
    public partial class ModifyCompanyForm : Form
    {
        private Service service;
        private DataGridViewRow row;

        public ModifyCompanyForm(Service service,DataGridViewRow row) {
            this.row = row;
            this.service = service;
            InitializeComponent();
        }

        private void modifyButton_Click(object sender, EventArgs e) {
            int id = Convert.ToInt32(row.Cells[0].Value);
            this.service.UpdateCompany(id, nameTextBox.Text);
        }
    }
}
