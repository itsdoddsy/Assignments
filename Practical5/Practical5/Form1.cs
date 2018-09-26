using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string modifier = Convert.ToString(txtOperator.Text);
            string[] acceptedModifiers = { "+", "-", "/", "*" };

            if (!Decimal.TryParse(txtOp1.Text, out decimal operand1))
                if (txtOp1.Text == "")
                    MessageBox.Show("You didn't enter a value for operand 1!");
                else
                MessageBox.Show("Operand 1 is incorrect");

            if (!Decimal.TryParse(txtOp2.Text, out decimal operand2))
                if (txtOp2.Text == "")
                    MessageBox.Show("You didn't enter a value for operand 2!");
                else
                MessageBox.Show("Operand 2 is incorrect");

            if (!acceptedModifiers.Any(modifier.Contains))
                if (modifier == "")
                    MessageBox.Show("You didn't enter an operator. Do you know what you're doing?");
                else
                MessageBox.Show("You are not using an accepted operator. " +
                    "Accepted modifiers are: \n+, -, /, *");

            if (txtOp2.Text == "0" && modifier == "/")
                MessageBox.Show("Stop that.");


            DataTable dt = new DataTable();
            var result = dt.Compute(operand1 + modifier + operand2, "");
            
            txtResult.Text = Convert.ToString(result);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
