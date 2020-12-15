
namespace probChira.UI
{
    partial class GenerateFlyerForm
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
            this.extraHoursLabel = new System.Windows.Forms.Label();
            this.extraHoursTextBox = new System.Windows.Forms.TextBox();
            this.extraMoneyTextBox = new System.Windows.Forms.TextBox();
            this.extraMoney = new System.Windows.Forms.Label();
            this.payDock = new System.Windows.Forms.Label();
            this.payDockTextBox = new System.Windows.Forms.TextBox();
            this.generateFlyer = new System.Windows.Forms.Button();
            this.monthLabel = new System.Windows.Forms.Label();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // extraHoursLabel
            // 
            this.extraHoursLabel.AutoSize = true;
            this.extraHoursLabel.Location = new System.Drawing.Point(12, 23);
            this.extraHoursLabel.Name = "extraHoursLabel";
            this.extraHoursLabel.Size = new System.Drawing.Size(89, 13);
            this.extraHoursLabel.TabIndex = 18;
            this.extraHoursLabel.Text = "Ore suplimentare:";
            // 
            // extraHoursTextBox
            // 
            this.extraHoursTextBox.Location = new System.Drawing.Point(107, 20);
            this.extraHoursTextBox.Name = "extraHoursTextBox";
            this.extraHoursTextBox.Size = new System.Drawing.Size(115, 20);
            this.extraHoursTextBox.TabIndex = 19;
            // 
            // extraMoneyTextBox
            // 
            this.extraMoneyTextBox.Location = new System.Drawing.Point(107, 46);
            this.extraMoneyTextBox.Name = "extraMoneyTextBox";
            this.extraMoneyTextBox.Size = new System.Drawing.Size(115, 20);
            this.extraMoneyTextBox.TabIndex = 20;
            // 
            // extraMoney
            // 
            this.extraMoney.AutoSize = true;
            this.extraMoney.Location = new System.Drawing.Point(12, 49);
            this.extraMoney.Name = "extraMoney";
            this.extraMoney.Size = new System.Drawing.Size(43, 13);
            this.extraMoney.TabIndex = 21;
            this.extraMoney.Text = "Sporuri:";
            // 
            // payDock
            // 
            this.payDock.AutoSize = true;
            this.payDock.Location = new System.Drawing.Point(12, 77);
            this.payDock.Name = "payDock";
            this.payDock.Size = new System.Drawing.Size(46, 13);
            this.payDock.TabIndex = 22;
            this.payDock.Text = "Retineri:";
            // 
            // payDockTextBox
            // 
            this.payDockTextBox.Location = new System.Drawing.Point(107, 74);
            this.payDockTextBox.Name = "payDockTextBox";
            this.payDockTextBox.Size = new System.Drawing.Size(115, 20);
            this.payDockTextBox.TabIndex = 23;
            // 
            // generateFlyer
            // 
            this.generateFlyer.Location = new System.Drawing.Point(323, 165);
            this.generateFlyer.Name = "generateFlyer";
            this.generateFlyer.Size = new System.Drawing.Size(87, 42);
            this.generateFlyer.TabIndex = 24;
            this.generateFlyer.Text = "Genereaza fluturas salariu";
            this.generateFlyer.UseVisualStyleBackColor = true;
            this.generateFlyer.Click += new System.EventHandler(this.generateFlyer_Click);
            // 
            // monthLabel
            // 
            this.monthLabel.AutoSize = true;
            this.monthLabel.Location = new System.Drawing.Point(12, 105);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(31, 13);
            this.monthLabel.TabIndex = 25;
            this.monthLabel.Text = "Luna";
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "Ianuarie",
            "Februarie",
            "Martie",
            "Aprilie",
            "Mai",
            "Iunie",
            "Iulie",
            "August",
            "Septembrie",
            "Octombrie",
            "Noiembrie",
            "Decembrie"});
            this.monthComboBox.Location = new System.Drawing.Point(107, 102);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(115, 21);
            this.monthComboBox.TabIndex = 26;
            this.monthComboBox.Text = "Ianuarie";
            // 
            // GenerateFlyerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 219);
            this.Controls.Add(this.monthComboBox);
            this.Controls.Add(this.monthLabel);
            this.Controls.Add(this.generateFlyer);
            this.Controls.Add(this.payDockTextBox);
            this.Controls.Add(this.payDock);
            this.Controls.Add(this.extraMoney);
            this.Controls.Add(this.extraMoneyTextBox);
            this.Controls.Add(this.extraHoursTextBox);
            this.Controls.Add(this.extraHoursLabel);
            this.Name = "GenerateFlyerForm";
            this.Text = "GenerateFlyerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label extraHoursLabel;
        private System.Windows.Forms.TextBox extraHoursTextBox;
        private System.Windows.Forms.TextBox extraMoneyTextBox;
        private System.Windows.Forms.Label extraMoney;
        private System.Windows.Forms.Label payDock;
        private System.Windows.Forms.TextBox payDockTextBox;
        private System.Windows.Forms.Button generateFlyer;
        private System.Windows.Forms.Label monthLabel;
        private System.Windows.Forms.ComboBox monthComboBox;
    }
}