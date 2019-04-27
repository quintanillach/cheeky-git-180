using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Globalization;

namespace StandardExceptions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Calculate the tip.
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                PerformCalculation();
            }
            catch (Exception ex)
            {
                txtTipAmount.Clear();
                MessageBox.Show(ex.Message);
            }
        }

        private void PerformCalculation()
        {
            // Parse the cost.
            decimal cost;
            if (!decimal.TryParse(txtCost.Text,
                NumberStyles.Currency, null, out cost))
                throw new FormatException("Cost must be a monetary amount.");

            // Validate the cost.
            if ((cost < 0.01m) || (cost > 500m))
                throw new ArgumentOutOfRangeException(
                    "Cost must be between $0.01 and $500.00.");

            // Parse the tip percentage.
            string percent_string = txtPercentTip.Text;
            if (percent_string.StartsWith("%"))
                percent_string = percent_string.Substring(1);
            else if (percent_string.EndsWith("%"))
                percent_string = percent_string.Substring(0, percent_string.Length - 1);
            decimal tip_percent;
            if (!decimal.TryParse(percent_string, out tip_percent))
                throw new FormatException("% Tip must be a numeric value.");

            // If the original value contained a % symbol, divide by 100.
            if (txtPercentTip.Text.Contains("%")) tip_percent /= 100m;

            // Validate the percentage.
            if ((tip_percent < 0) || (tip_percent > 100))
                throw new ArgumentOutOfRangeException(
                    "% Tip must be between 0% and 100%.");

            // Everything's valid. Perform the calculation.
            decimal tip_amount = cost * tip_percent;
            txtTipAmount.Text = tip_amount.ToString("C");
        }
    }
}
