
namespace probChira.UI
{
    partial class AddEmployeeForm
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.grossSalaryLabel = new System.Windows.Forms.Label();
            this.instalmentsLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.birthdateTextBox = new System.Windows.Forms.TextBox();
            this.grossSalaryTextBox = new System.Windows.Forms.TextBox();
            this.instalmentsValueTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.monthsForInstalments = new System.Windows.Forms.Label();
            this.monthsForInstalmentsTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 37);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Nume:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(12, 68);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(35, 13);
            this.companyLabel.TabIndex = 1;
            this.companyLabel.Text = "Firma:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 100);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(69, 13);
            this.birthdateLabel.TabIndex = 2;
            this.birthdateLabel.Text = "Data nasterii:";
            // 
            // grossSalaryLabel
            // 
            this.grossSalaryLabel.AutoSize = true;
            this.grossSalaryLabel.Location = new System.Drawing.Point(12, 135);
            this.grossSalaryLabel.Name = "grossSalaryLabel";
            this.grossSalaryLabel.Size = new System.Drawing.Size(63, 13);
            this.grossSalaryLabel.TabIndex = 3;
            this.grossSalaryLabel.Text = "Salariu brut:";
            // 
            // instalmentsLabel
            // 
            this.instalmentsLabel.AutoSize = true;
            this.instalmentsLabel.Location = new System.Drawing.Point(12, 170);
            this.instalmentsLabel.Name = "instalmentsLabel";
            this.instalmentsLabel.Size = new System.Drawing.Size(65, 13);
            this.instalmentsLabel.TabIndex = 5;
            this.instalmentsLabel.Text = "Rata lunara:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 34);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 6;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(107, 65);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 7;
            // 
            // birthdateTextBox
            // 
            this.birthdateTextBox.Location = new System.Drawing.Point(107, 97);
            this.birthdateTextBox.Name = "birthdateTextBox";
            this.birthdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthdateTextBox.TabIndex = 8;
            // 
            // grossSalaryTextBox
            // 
            this.grossSalaryTextBox.Location = new System.Drawing.Point(107, 132);
            this.grossSalaryTextBox.Name = "grossSalaryTextBox";
            this.grossSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossSalaryTextBox.TabIndex = 9;
            // 
            // instalmentsValueTextBox
            // 
            this.instalmentsValueTextBox.Location = new System.Drawing.Point(107, 167);
            this.instalmentsValueTextBox.Name = "instalmentsValueTextBox";
            this.instalmentsValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.instalmentsValueTextBox.TabIndex = 11;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(474, 317);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(68, 22);
            this.addButton.TabIndex = 12;
            this.addButton.Text = "Adauga";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // monthsForInstalments
            // 
            this.monthsForInstalments.AutoSize = true;
            this.monthsForInstalments.Location = new System.Drawing.Point(12, 201);
            this.monthsForInstalments.Name = "monthsForInstalments";
            this.monthsForInstalments.Size = new System.Drawing.Size(67, 13);
            this.monthsForInstalments.TabIndex = 13;
            this.monthsForInstalments.Text = "Durata (luni):";
            // 
            // monthsForInstalmentsTextBox
            // 
            this.monthsForInstalmentsTextBox.Location = new System.Drawing.Point(107, 198);
            this.monthsForInstalmentsTextBox.Name = "monthsForInstalmentsTextBox";
            this.monthsForInstalmentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsForInstalmentsTextBox.TabIndex = 14;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 351);
            this.Controls.Add(this.monthsForInstalmentsTextBox);
            this.Controls.Add(this.monthsForInstalments);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.instalmentsValueTextBox);
            this.Controls.Add(this.grossSalaryTextBox);
            this.Controls.Add(this.birthdateTextBox);
            this.Controls.Add(this.companyTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.instalmentsLabel);
            this.Controls.Add(this.grossSalaryLabel);
            this.Controls.Add(this.birthdateLabel);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label grossSalaryLabel;
        private System.Windows.Forms.Label instalmentsLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox birthdateTextBox;
        private System.Windows.Forms.TextBox grossSalaryTextBox;
        private System.Windows.Forms.TextBox instalmentsValueTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label monthsForInstalments;
        private System.Windows.Forms.TextBox monthsForInstalmentsTextBox;
    }
}