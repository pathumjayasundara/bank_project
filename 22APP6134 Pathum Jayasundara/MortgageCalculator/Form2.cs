using System;
using System.Windows.Forms;

namespace MortgageCalculator
{
    public partial class Form2 : Form
    {
        public Form2(double homePrice, double downPayment, int years,
                     string interestRateStr, double interest,
                     double totalPrice, double monthlyPayment)
        {
            InitializeComponent();

            // Populate labels with calculated values
            lblHomePrice.Text    = $"Price of Home: {homePrice:C}";
            lblDownPayment.Text  = $"Down Payment: {downPayment:C}";
            lblDuration.Text     = $"Duration: {years} years";
            lblInterestRate.Text = $"Interest Rate: {interestRateStr}";
            lblInterest.Text     = $"Total Simple Interest: {interest:C}";
            lblTotalPrice.Text   = $"Total Price of Home: {totalPrice:C}";
            lblMonthly.Text      = $"Monthly Payments: {monthlyPayment:C}";
        }
    }
}
