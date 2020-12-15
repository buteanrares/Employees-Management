﻿using System;
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
    public partial class AddCompanyForm : Form
    {
        private Service service;

        public AddCompanyForm(Service service) {
            this.service = service;
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e) {
            this.service.AddCompany(nameTextBox.Text);
        }
    }
}
