
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
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
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
            this.addCompanyButton.Location = new System.Drawing.Point(236, 45);
            this.addCompanyButton.Name = "addCompanyButton";
            this.addCompanyButton.Size = new System.Drawing.Size(139, 23);
            this.addCompanyButton.TabIndex = 2;
            this.addCompanyButton.Text = "Adauga firma";
            this.addCompanyButton.UseVisualStyleBackColor = true;
            this.addCompanyButton.Click += new System.EventHandler(this.addCompanyButton_Click);
            // 
            // showCompaniesButton
            // 
            this.showCompaniesButton.Location = new System.Drawing.Point(236, 74);
            this.showCompaniesButton.Name = "showCompaniesButton";
            this.showCompaniesButton.Size = new System.Drawing.Size(139, 23);
            this.showCompaniesButton.TabIndex = 3;
            this.showCompaniesButton.Text = "Tabel firme";
            this.showCompaniesButton.UseVisualStyleBackColor = true;
            this.showCompaniesButton.Click += new System.EventHandler(this.showCompaniesButton_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(236, 259);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(139, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(236, 230);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(139, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 259);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(139, 23);
            this.button7.TabIndex = 5;
            this.button7.Text = "button7";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(12, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(139, 23);
            this.button8.TabIndex = 4;
            this.button8.Text = "button8";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
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
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
    }
}

