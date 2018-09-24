using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            // Initialise our first variables
            decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;


            // Basic logic checking
            if (subtotal >= 500)
                // .2m equates to 20% as a decimal variable
                discountPercent = .2m;
            else if (subtotal >= 250 && subtotal < 500)
                // Equates to 15% as a decimal variable
                discountPercent = .15m;
            else if (subtotal >= 100 && subtotal < 250)
                //Equates to 10% as a decimal variable
                discountPercent = .1m;

            // Initialising our next set of variables
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            // Setting our text boxes to equal the above 
            // variables as text instead of as numbers

            // "p1" equates to a percentage with one decimal place
            txtDiscountPercent.Text = discountPercent.ToString("p1");

            // "c" equates to a Currency format which automatically
            // localises to whatever language the computer is running in
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");

            // Focus the subtotal text box so it can keep being
            // typed in even after clicking Calculate
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
