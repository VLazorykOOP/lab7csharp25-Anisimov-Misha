using System;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtNumber1.Text);
                double num2 = double.Parse(txtNumber2.Text);
                double result = 0;

                if (rbAdd.Checked)
                    result = num1 + num2;
                else if (rbSubtract.Checked)
                    result = num1 - num2;
                else if (rbMultiply.Checked)
                    result = num1 * num2;
                else if (rbDivide.Checked)
                {
                    if (num2 == 0)
                        throw new DivideByZeroException("Не можна ділити на нуль.");
                    result = num1 / num2;
                }

                txtResult.Text = result.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Будь ласка, введіть коректні числа.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
