namespace MortgageCalculator
{
    partial class Form2
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
            this.lblTicketTitle  = new System.Windows.Forms.Label();
            this.lblHomePrice    = new System.Windows.Forms.Label();
            this.lblDownPayment  = new System.Windows.Forms.Label();
            this.lblDuration     = new System.Windows.Forms.Label();
            this.lblInterestRate = new System.Windows.Forms.Label();
            this.lblInterest     = new System.Windows.Forms.Label();
            this.lblTotalPrice   = new System.Windows.Forms.Label();
            this.lblMonthly      = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // lblTicketTitle
            this.lblTicketTitle.AutoSize = true;
            this.lblTicketTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F,
                System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline);
            this.lblTicketTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTicketTitle.Name = "lblTicketTitle";
            this.lblTicketTitle.Text = "PAWN TICKET";

            // Helper: consistent label font
            System.Drawing.Font labelFont = new System.Drawing.Font("Microsoft Sans Serif", 10F,
                System.Drawing.FontStyle.Bold);

            // lblHomePrice
            this.lblHomePrice.AutoSize = true;
            this.lblHomePrice.Font = labelFont;
            this.lblHomePrice.Location = new System.Drawing.Point(20, 70);
            this.lblHomePrice.Name = "lblHomePrice";
            this.lblHomePrice.Text = "Price of Home:";

            // lblDownPayment
            this.lblDownPayment.AutoSize = true;
            this.lblDownPayment.Font = labelFont;
            this.lblDownPayment.Location = new System.Drawing.Point(20, 110);
            this.lblDownPayment.Name = "lblDownPayment";
            this.lblDownPayment.Text = "Down Payment:";

            // lblDuration
            this.lblDuration.AutoSize = true;
            this.lblDuration.Font = labelFont;
            this.lblDuration.Location = new System.Drawing.Point(20, 150);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Text = "Duration:";

            // lblInterestRate
            this.lblInterestRate.AutoSize = true;
            this.lblInterestRate.Font = labelFont;
            this.lblInterestRate.Location = new System.Drawing.Point(20, 190);
            this.lblInterestRate.Name = "lblInterestRate";
            this.lblInterestRate.Text = "Interest Rate:";

            // lblInterest
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = labelFont;
            this.lblInterest.Location = new System.Drawing.Point(20, 230);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Text = "Total Simple Interest:";

            // lblTotalPrice
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = labelFont;
            this.lblTotalPrice.Location = new System.Drawing.Point(20, 270);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Text = "Total Price of Home:";

            // lblMonthly
            this.lblMonthly.AutoSize = true;
            this.lblMonthly.Font = labelFont;
            this.lblMonthly.Location = new System.Drawing.Point(20, 310);
            this.lblMonthly.Name = "lblMonthly";
            this.lblMonthly.Text = "Monthly Payments:";

            // Form2
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 370);
            this.Controls.Add(this.lblTicketTitle);
            this.Controls.Add(this.lblHomePrice);
            this.Controls.Add(this.lblDownPayment);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.lblInterestRate);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblMonthly);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            // Position to the right of Form1
            this.Location = new System.Drawing.Point(
                System.Windows.Forms.Screen.PrimaryScreen.WorkingArea.Width / 2 + 20, 100);
            this.Text = "Pawn Ticket";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblTicketTitle;
        private System.Windows.Forms.Label lblHomePrice;
        private System.Windows.Forms.Label lblDownPayment;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.Label lblInterestRate;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblMonthly;
    }
}
