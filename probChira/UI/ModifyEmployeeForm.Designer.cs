
namespace probChira.UI
{
    partial class ModifyEmployeeForm
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
            this.modifyButton = new System.Windows.Forms.Button();
            this.monthsForInstalmentsTextBox = new System.Windows.Forms.TextBox();
            this.monthsForInstalments = new System.Windows.Forms.Label();
            this.instalmentsValueTextBox = new System.Windows.Forms.TextBox();
            this.grossSalaryTextBox = new System.Windows.Forms.TextBox();
            this.birthdateTextBox = new System.Windows.Forms.TextBox();
            this.companyTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.instalmentsLabel = new System.Windows.Forms.Label();
            this.grossSalaryLabel = new System.Windows.Forms.Label();
            this.birthdateLabel = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(478, 280);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(75, 23);
            this.modifyButton.TabIndex = 2;
            this.modifyButton.Text = "Modifica";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.modifyButton_Click);
            // 
            // monthsForInstalmentsTextBox
            // 
            this.monthsForInstalmentsTextBox.Location = new System.Drawing.Point(107, 181);
            this.monthsForInstalmentsTextBox.Name = "monthsForInstalmentsTextBox";
            this.monthsForInstalmentsTextBox.Size = new System.Drawing.Size(100, 20);
            this.monthsForInstalmentsTextBox.TabIndex = 27;
            // 
            // monthsForInstalments
            // 
            this.monthsForInstalments.AutoSize = true;
            this.monthsForInstalments.Location = new System.Drawing.Point(12, 184);
            this.monthsForInstalments.Name = "monthsForInstalments";
            this.monthsForInstalments.Size = new System.Drawing.Size(67, 13);
            this.monthsForInstalments.TabIndex = 26;
            this.monthsForInstalments.Text = "Durata (luni):";
            // 
            // instalmentsValueTextBox
            // 
            this.instalmentsValueTextBox.Location = new System.Drawing.Point(107, 150);
            this.instalmentsValueTextBox.Name = "instalmentsValueTextBox";
            this.instalmentsValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.instalmentsValueTextBox.TabIndex = 24;
            // 
            // grossSalaryTextBox
            // 
            this.grossSalaryTextBox.Location = new System.Drawing.Point(107, 115);
            this.grossSalaryTextBox.Name = "grossSalaryTextBox";
            this.grossSalaryTextBox.Size = new System.Drawing.Size(100, 20);
            this.grossSalaryTextBox.TabIndex = 23;
            // 
            // birthdateTextBox
            // 
            this.birthdateTextBox.Location = new System.Drawing.Point(107, 80);
            this.birthdateTextBox.Name = "birthdateTextBox";
            this.birthdateTextBox.Size = new System.Drawing.Size(100, 20);
            this.birthdateTextBox.TabIndex = 22;
            // 
            // companyTextBox
            // 
            this.companyTextBox.Location = new System.Drawing.Point(107, 48);
            this.companyTextBox.Name = "companyTextBox";
            this.companyTextBox.Size = new System.Drawing.Size(100, 20);
            this.companyTextBox.TabIndex = 21;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(107, 17);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 20;
            // 
            // instalmentsLabel
            // 
            this.instalmentsLabel.AutoSize = true;
            this.instalmentsLabel.Location = new System.Drawing.Point(12, 153);
            this.instalmentsLabel.Name = "instalmentsLabel";
            this.instalmentsLabel.Size = new System.Drawing.Size(65, 13);
            this.instalmentsLabel.TabIndex = 19;
            this.instalmentsLabel.Text = "Rata lunara:";
            // 
            // grossSalaryLabel
            // 
            this.grossSalaryLabel.AutoSize = true;
            this.grossSalaryLabel.Location = new System.Drawing.Point(12, 118);
            this.grossSalaryLabel.Name = "grossSalaryLabel";
            this.grossSalaryLabel.Size = new System.Drawing.Size(63, 13);
            this.grossSalaryLabel.TabIndex = 18;
            this.grossSalaryLabel.Text = "Salariu brut:";
            // 
            // birthdateLabel
            // 
            this.birthdateLabel.AutoSize = true;
            this.birthdateLabel.Location = new System.Drawing.Point(12, 83);
            this.birthdateLabel.Name = "birthdateLabel";
            this.birthdateLabel.Size = new System.Drawing.Size(69, 13);
            this.birthdateLabel.TabIndex = 17;
            this.birthdateLabel.Text = "Data nasterii:";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Location = new System.Drawing.Point(12, 51);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(35, 13);
            this.companyLabel.TabIndex = 16;
            this.companyLabel.Text = "Firma:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(12, 20);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 15;
            this.nameLabel.Text = "Nume:";
            // 
            // ModifyEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 315);
            this.Controls.Add(this.monthsForInstalmentsTextBox);
            this.Controls.Add(this.monthsForInstalments);
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
            this.Controls.Add(this.modifyButton);
            this.Name = "ModifyEmployeeForm";
            this.Text = "ModifyEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.TextBox monthsForInstalmentsTextBox;
        private System.Windows.Forms.Label monthsForInstalments;
        private System.Windows.Forms.TextBox instalmentsValueTextBox;
        private System.Windows.Forms.TextBox grossSalaryTextBox;
        private System.Windows.Forms.TextBox birthdateTextBox;
        private System.Windows.Forms.TextBox companyTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label instalmentsLabel;
        private System.Windows.Forms.Label grossSalaryLabel;
        private System.Windows.Forms.Label birthdateLabel;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label nameLabel;
    }
}