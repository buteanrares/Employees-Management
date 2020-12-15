
namespace probChira.UI
{
    partial class LowSalaryEmployeesForm
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
            this.lowSalaryDGV = new System.Windows.Forms.DataGridView();
            this.employeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyMean = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lowSalaryDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // lowSalaryDGV
            // 
            this.lowSalaryDGV.AllowUserToAddRows = false;
            this.lowSalaryDGV.AllowUserToDeleteRows = false;
            this.lowSalaryDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lowSalaryDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employeeName,
            this.companyName,
            this.employeeSalary,
            this.companyMean});
            this.lowSalaryDGV.Location = new System.Drawing.Point(12, 12);
            this.lowSalaryDGV.Name = "lowSalaryDGV";
            this.lowSalaryDGV.ReadOnly = true;
            this.lowSalaryDGV.Size = new System.Drawing.Size(392, 426);
            this.lowSalaryDGV.TabIndex = 0;
            // 
            // employeeName
            // 
            this.employeeName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.employeeName.HeaderText = "Nume";
            this.employeeName.Name = "employeeName";
            this.employeeName.ReadOnly = true;
            this.employeeName.Width = 60;
            // 
            // companyName
            // 
            this.companyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.companyName.HeaderText = "Firma";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Width = 57;
            // 
            // employeeSalary
            // 
            this.employeeSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.employeeSalary.HeaderText = "Salariu";
            this.employeeSalary.Name = "employeeSalary";
            this.employeeSalary.ReadOnly = true;
            this.employeeSalary.Width = 64;
            // 
            // companyMean
            // 
            this.companyMean.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyMean.HeaderText = "Media salariului in firma";
            this.companyMean.Name = "companyMean";
            this.companyMean.ReadOnly = true;
            // 
            // LowSalaryEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.lowSalaryDGV);
            this.Name = "LowSalaryEmployeesForm";
            this.Text = "LowSalaryEmployeesForm";
            this.Load += new System.EventHandler(this.LowSalaryEmployeesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lowSalaryDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView lowSalaryDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeSalary;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyMean;
    }
}