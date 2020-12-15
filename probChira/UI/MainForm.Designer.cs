
namespace probChira
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.addEmployeeButton = new System.Windows.Forms.Button();
            this.showEmployeesButton = new System.Windows.Forms.Button();
            this.addCompanyButton = new System.Windows.Forms.Button();
            this.showCompaniesButton = new System.Windows.Forms.Button();
            this.monthlyTax = new System.Windows.Forms.Button();
            this.canRetire = new System.Windows.Forms.Button();
            this.lowSalaryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addEmployeeButton
            // 
            this.addEmployeeButton.Location = new System.Drawing.Point(12, 45);
            this.addEmployeeButton.Name = "addEmployeeButton";
            this.addEmployeeButton.Size = new System.Drawing.Size(139, 23);
            this.addEmployeeButton.TabIndex = 0;
            this.addEmployeeButton.Text = "Adauga angajat";
            this.addEmployeeButton.UseVisualStyleBackColor = true;
            this.addEmployeeButton.Click += new System.EventHandler(this.addEmployeeButton_Click);
            // 
            // showEmployeesButton
            // 
            this.showEmployeesButton.Location = new System.Drawing.Point(12, 74);
            this.showEmployeesButton.Name = "showEmployeesButton";
            this.showEmployeesButton.Size = new System.Drawing.Size(139, 23);
            this.showEmployeesButton.TabIndex = 1;
            this.showEmployeesButton.Text = "Tabel angajati";
            this.showEmployeesButton.UseVisualStyleBackColor = true;
            this.showEmployeesButton.Click += new System.EventHandler(this.showEmployeesButton_Click);
            // 
            // addCompanyButton
            // 
            this.addCompanyButton.Location = new System.Drawing.Point(213, 45);
            this.addCompanyButton.Name = "addCompanyButton";
            this.addCompanyButton.Size = new System.Drawing.Size(139, 23);
            this.addCompanyButton.TabIndex = 2;
            this.addCompanyButton.Text = "Adauga firma";
            this.addCompanyButton.UseVisualStyleBackColor = true;
            this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
            // 
            // showCompaniesButton
            // 
            this.showCompaniesButton.Location = new System.Drawing.Point(213, 74);
            this.showCompaniesButton.Name = "showCompaniesButton";
            this.showCompaniesButton.Size = new System.Drawing.Size(139, 23);
            this.showCompaniesButton.TabIndex = 3;
            this.showCompaniesButton.Text = "Tabel firme";
            this.showCompaniesButton.UseVisualStyleBackColor = true;
            this.showCompaniesButton.Click += new System.EventHandler(this.showCompaniesButton_Click);
            // 
            // monthlyTax
            // 
            this.monthlyTax.Location = new System.Drawing.Point(12, 266);
            this.monthlyTax.Name = "monthlyTax";
            this.monthlyTax.Size = new System.Drawing.Size(139, 50);
            this.monthlyTax.TabIndex = 7;
            this.monthlyTax.Text = "Tabel angajati cu rate lunare";
            this.monthlyTax.UseVisualStyleBackColor = true;
            this.monthlyTax.Click += new System.EventHandler(this.monthlyTax_Click);
            // 
            // canRetire
            // 
            this.canRetire.Location = new System.Drawing.Point(12, 210);
            this.canRetire.Name = "canRetire";
            this.canRetire.Size = new System.Drawing.Size(139, 50);
            this.canRetire.TabIndex = 5;
            this.canRetire.Text = "Tabel angajati care se pot pensiona in anul curent";
            this.canRetire.UseVisualStyleBackColor = true;
            this.canRetire.Click += new System.EventHandler(this.canRetire_Click);
            // 
            // lowSalaryButton
            // 
            this.lowSalaryButton.Location = new System.Drawing.Point(12, 154);
            this.lowSalaryButton.Name = "lowSalaryButton";
            this.lowSalaryButton.Size = new System.Drawing.Size(139, 50);
            this.lowSalaryButton.TabIndex = 4;
            this.lowSalaryButton.Text = "Tabel angajati cu salariu sub medie";
            this.lowSalaryButton.UseVisualStyleBackColor = true;
            this.lowSalaryButton.Click += new System.EventHandler(this.lowSalaryButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.monthlyTax);
            this.Controls.Add(this.canRetire);
            this.Controls.Add(this.lowSalaryButton);
            this.Controls.Add(this.showCompaniesButton);
            this.Controls.Add(this.addCompanyButton);
            this.Controls.Add(this.showEmployeesButton);
            this.Controls.Add(this.addEmployeeButton);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addEmployeeButton;
        private System.Windows.Forms.Button showEmployeesButton;
        private System.Windows.Forms.Button addCompanyButton;
        private System.Windows.Forms.Button showCompaniesButton;
        private System.Windows.Forms.Button monthlyTax;
        private System.Windows.Forms.Button canRetire;
        private System.Windows.Forms.Button lowSalaryButton;
    }
}

