
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpMortgage = new System.Windows.Forms.GroupBox();
            this.lblHomePrice = new System.Windows.Forms.Label();
            this.txtHomePrice = new System.Windows.Forms.TextBox();
            this.lblDownPayment = new System.Windows.Forms.Label();
            this.txtDownPayment = new System.Windows.Forms.TextBox();
            this.grpDuration = new System.Windows.Forms.GroupBox();
            this.rb10Years = new System.Windows.Forms.RadioButton();
            this.rb20Years = new System.Windows.Forms.RadioButton();
            this.rb30Years = new System.Windows.Forms.RadioButton();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.cmbInterestRate = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.grpMortgage.SuspendLayout();
            this.grpDuration.SuspendLayout();
            this.SuspendLayout();

       
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(73, 15);
            this.lblTitle.Text = "ABC BANK";

            this.grpMortgage.Controls.Add(this.lblHomePrice);
            this.grpMortgage.Controls.Add(this.txtHomePrice);
            this.grpMortgage.Controls.Add(this.lblDownPayment);
            this.grpMortgage.Controls.Add(this.txtDownPayment);
            this.grpMortgage.Controls.Add(this.grpDuration);
            this.grpMortgage.Controls.Add(this.lblInterestRate);
            this.grpMortgage.Controls.Add(this.cmbInterestRate);
            this.grpMortgage.Controls.Add(this.btnCalculate);
            this.grpMortgage.Controls.Add(this.btnClear);
            this.grpMortgage.Location = new System.Drawing.Point(12, 30);
            this.grpMortgage.Name = "grpMortgage";
            this.grpMortgage.Size = new System.Drawing.Size(360, 310);
            this.grpMortgage.Text = "Mortgage Interest Calculator";

            // lblHomePrice
            this.lblHomePrice.AutoSize = true;
            this.lblHomePrice.Location = new System.Drawing.Point(10, 30);
            this.lblHomePrice.Text = "Price of Home:";

            // txtHomePrice
            this.txtHomePrice.Location = new System.Drawing.Point(120, 27);
            this.txtHomePrice.Name = "txtHomePrice";
            this.txtHomePrice.Size = new System.Drawing.Size(150, 20);

            // lblDownPayment
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Location = new System.Drawing.Point(10, 65);
            this.lblDownPayment.Text = "Down Payment:";

            // txtDownPayment
            this.txtDownPayment.Location = new System.Drawing.Point(120, 62);
            this.txtDownPayment.Name = "txtDownPayment";
            this.txtDownPayment.Size = new System.Drawing.Size(150, 20);

            // grpDuration
            this.grpDuration.Controls.Add(this.rb10Years);
            this.grpDuration.Controls.Add(this.rb20Years);
            this.grpDuration.Controls.Add(this.rb30Years);
            this.grpDuration.Location = new System.Drawing.Point(10, 95);
            this.grpDuration.Name = "grpDuration";
            this.grpDuration.Size = new System.Drawing.Size(160, 110);
            this.grpDuration.Text = "Duration of Loan";

            // rb10Years
            this.rb10Years.AutoSize = true;
            this.rb10Years.Location = new System.Drawing.Point(15, 25);
            this.rb10Years.Name = "rb10Years";
            this.rb10Years.Text = "10 Years";

            // rb20Years
            this.rb20Years.AutoSize = true;
            this.rb20Years.Location = new System.Drawing.Point(15, 50);
            this.rb20Years.Name = "rb20Years";
            this.rb20Years.Text = "20 Years";

            // rb30Years
            this.rb30Years.AutoSize = true;
            this.rb30Years.Checked = true;
            this.rb30Years.Location = new System.Drawing.Point(15, 75);
            this.rb30Years.Name = "rb30Years";
            this.rb30Years.Text = "30 Years";

            // lblInterestRate
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Location = new System.Drawing.Point(10, 220);
            this.lblInterestRate.Text = "Interest Rate:";

            // cmbInterestRate
            this.cmbInterestRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbInterestRate.Items.AddRange(new object[] { "8%", "8.5%", "9%", "9.5%", "10%" });
            this.cmbInterestRate.Location = new System.Drawing.Point(90, 217);
            this.cmbInterestRate.Name = "cmbInterestRate";
            this.cmbInterestRate.Size = new System.Drawing.Size(70, 21);
            this.cmbInterestRate.SelectedIndex = 3; // Default 9.5%

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(10, 260);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // btnClear
            this.btnClear.Location = new System.Drawing.Point(100, 260);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 360);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grpMortgage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABC BANK - Mortgage Calculator";
            this.grpMortgage.ResumeLayout(false);
            this.grpMortgage.PerformLayout();
            this.grpDuration.ResumeLayout(false);
            this.grpDuration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpMortgage;
        private System.Windows.Forms.Label lblHomePrice;
        private System.Windows.Forms.TextBox txtHomePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.TextBox txtDownPayment;
        private System.Windows.Forms.GroupBox grpDuration;
        private System.Windows.Forms.RadioButton rb10Years;
        private System.Windows.Forms.RadioButton rb20Years;
        private System.Windows.Forms.RadioButton rb30Years;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.ComboBox cmbInterestRate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
    }
}
