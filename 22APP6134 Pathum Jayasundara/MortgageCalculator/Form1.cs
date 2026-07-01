using System;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtHomePrice.Text) ||
                string.IsNullOrWhiteSpace(txtDownPayment.Text))
            {
                MessageBox.Show("Please enter both Price of Home and Down Payment.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            double homePrice, downPayment;

            if (!double.TryParse(txtHomePrice.Text, out homePrice) || homePrice <= 0)
            {
                MessageBox.Show("Please enter a valid Price of Home.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDownPayment.Text, out downPayment) || downPayment < 0)
            {
                MessageBox.Show("Please enter a valid Down Payment.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (downPayment >= homePrice)
            {
                MessageBox.Show("Down Payment must be less than the Price of Home.",
                    "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            int years = 30;
            if (rb10Years.Checked) years = 10;
            else if (rb20Years.Checked) years = 20;
            else if (rb30Years.Checked) years = 30;

            
            double interestRate = double.Parse(cmbInterestRate.SelectedItem.ToString().Replace("%", "")) / 100.0;

            // Perform calculation
            saleCalculation(homePrice, downPayment, years, interestRate);
        }

        private void saleCalculation(double homePrice, double downPayment, int years, double interestRate)
        {
            // i. Total simple interest
            double interest = (homePrice - downPayment) * interestRate * years;

            // ii. Total price of home
            double totalPrice = homePrice + interest;

            // iii. Monthly payments
            int totalMonths = years * 12;
            double monthlyPayment = totalPrice / totalMonths;

            // Get interest rate string for display
            string interestRateStr = cmbInterestRate.SelectedItem.ToString();

            // Open output form
            Form2 outputForm = new Form2(homePrice, downPayment, years, interestRateStr,
                                         interest, totalPrice, monthlyPayment);
            outputForm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHomePrice.Clear();
            txtDownPayment.Clear();
            rb30Years.Checked = true;
            cmbInterestRate.SelectedIndex = 3; // 9.5%
            txtHomePrice.Focus();
        }
    }
}
