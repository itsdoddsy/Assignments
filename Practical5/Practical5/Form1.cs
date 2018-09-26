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

            

            if (IsPresent(txtOp1, "Operand 1") && IsValid(txtOp1, "Operand 1") &&
            IsPresent(txtOp2, "Operand 2") && IsValid(txtOp2, "Operand 2") &&
            IsPresent(txtOperator, "the Operator"))
            {

                if (txtOp2.Text == "0" && modifier == "/")
                    MessageBox.Show("Stop that.");

                if (!acceptedModifiers.Any(modifier.Contains))
                    MessageBox.Show("You are not using an accepted operator. " +
                        "Accepted modifiers are: \n+, -, /, *");
                else
                {
                    DataTable dt = new DataTable();
                    var result = dt.Compute(txtOp1.Text + txtOperator.Text + txtOp2.Text, "");
                    txtResult.Text = Convert.ToString(result);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool IsPresent(TextBox txtBox, string text)
        {
            bool present = false;
            if (txtBox.Text == "")
                MessageBox.Show($"You didn't enter a value for {text}!");
            else present = true;
            return present;
        }

        private bool IsValid(TextBox txtBox, string text)
        {
            bool valid = false;
            if (!Decimal.TryParse(txtBox.Text, out decimal dec))
                MessageBox.Show($"You've entered an incorrect value for {text}!");
            else valid = true;
            return valid;
        }
    }
}
