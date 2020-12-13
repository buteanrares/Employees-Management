
namespace probChira.UI
{
    partial class EmployeesTableForm
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
            this.employeesDGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grossSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.generateFlyer = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.searchEmployeeLabel = new System.Windows.Forms.Label();
            this.searchEmployeeTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // employeesDGV
            // 
            this.employeesDGV.AllowUserToAddRows = false;
            this.employeesDGV.AllowUserToDeleteRows = false;
            this.employeesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeesDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.name,
            this.companyName,
            this.birthdate,
            this.grossSalary});
            this.employeesDGV.Location = new System.Drawing.Point(12, 94);
            this.employeesDGV.Name = "employeesDGV";
            this.employeesDGV.ReadOnly = true;
            this.employeesDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.employeesDGV.Size = new System.Drawing.Size(446, 479);
            this.employeesDGV.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 43;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.name.HeaderText = "Nume";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 60;
            // 
            // companyName
            // 
            this.companyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.companyName.HeaderText = "Firma";
            this.companyName.Name = "companyName";
            this.companyName.ReadOnly = true;
            this.companyName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.companyName.Width = 57;
            // 
            // birthdate
            // 
            this.birthdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.birthdate.HeaderText = "Data nasterii";
            this.birthdate.Name = "birthdate";
            this.birthdate.ReadOnly = true;
            this.birthdate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.birthdate.Width = 91;
            // 
            // grossSalary
            // 
            this.grossSalary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.grossSalary.HeaderText = "Salariu brut";
            this.grossSalary.Name = "grossSalary";
            this.grossSalary.ReadOnly = true;
            this.grossSalary.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 605);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(85, 23);
            this.deleteButton.TabIndex = 1;
            this.deleteButton.Text = "Sterge";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(12, 634);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(85, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Modifica";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // generateFlyer
            // 
            this.generateFlyer.Location = new System.Drawing.Point(12, 678);
            this.generateFlyer.Name = "generateFlyer";
            this.generateFlyer.Size = new System.Drawing.Size(85, 47);
            this.generateFlyer.TabIndex = 3;
            this.generateFlyer.Text = "Genereaza fluturas salariu";
            this.generateFlyer.UseVisualStyleBackColor = true;
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(383, 702);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 4;
            this.closeButton.Text = "Inchide";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // searchEmployeeLabel
            // 
            this.searchEmployeeLabel.AutoSize = true;
            this.searchEmployeeLabel.Location = new System.Drawing.Point(12, 25);
            this.searchEmployeeLabel.Name = "searchEmployeeLabel";
            this.searchEmployeeLabel.Size = new System.Drawing.Size(85, 13);
            this.searchEmployeeLabel.TabIndex = 5;
            this.searchEmployeeLabel.Text = "Cautare angajat:";
            // 
            // searchEmployeeTextbox
            // 
            this.searchEmployeeTextbox.Location = new System.Drawing.Point(103, 22);
            this.searchEmployeeTextbox.Name = "searchEmployeeTextbox";
            this.searchEmployeeTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchEmployeeTextbox.TabIndex = 6;
            this.searchEmployeeTextbox.TextChanged += new System.EventHandler(this.searchEmployeeTextbox_TextChanged);
            // 
            // EmployeesTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 737);
            this.Controls.Add(this.searchEmployeeTextbox);
            this.Controls.Add(this.searchEmployeeLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.generateFlyer);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.employeesDGV);
            this.Name = "EmployeesTableForm";
            this.Text = "EmployeesTableForm";
            this.Load += new System.EventHandler(this.EmployeesTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView employeesDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn grossSalary;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button generateFlyer;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label searchEmployeeLabel;
        private System.Windows.Forms.TextBox searchEmployeeTextbox;
    }
}