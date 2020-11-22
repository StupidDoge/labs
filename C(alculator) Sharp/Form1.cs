using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_alculator__Sharp
{
    public partial class Form1 : Form
    {
        Calculator calculator;

        public Form1()
        {
            InitializeComponent();

            calculator = new Calculator();
            resultLabel.Text = "0";
        }

        private void CorrectNumber()
        {
            if (resultLabel.Text.IndexOf("∞") != -1)
                resultLabel.Text = resultLabel.Text.Substring(0, resultLabel.Text.Length - 1);

            if (resultLabel.Text[0] == '0' && (resultLabel.Text.IndexOf(",") != 1))
                resultLabel.Text = resultLabel.Text.Remove(0, 1);

            if (resultLabel.Text[0] == '-')
                if (resultLabel.Text[1] == '0' && (resultLabel.Text.IndexOf(",") != 2))
                    resultLabel.Text = resultLabel.Text.Remove(1, 1);
        }

        private bool IsActive()
        {

            if (!multiplication.Enabled)
                return false;

            if (!division.Enabled)
                return false;

            if (!addition.Enabled)
                return false;

            if (!subtraction.Enabled)
                return false;

            if (!logXY.Enabled)
                return false;

            if (!xDegreeY.Enabled)
                return false;

            if (!mod.Enabled)
                return false;

            if (!arbitraryRoot.Enabled)
                return false;

            return true;
        }

        private void MakeActive()
        {
            multiplication.Enabled = true;
            division.Enabled = true;
            addition.Enabled = true;
            subtraction.Enabled = true;
            logXY.Enabled = true;
            xDegreeY.Enabled = true;
            mod.Enabled = true;
            arbitraryRoot.Enabled = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "0";
            calculator.DeleteNumber();
            MakeActive();
        }

        private void changeSign_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(resultLabel.Text);
            number = number * -1;
            resultLabel.Text = number.ToString();
        }

        private void fraction_Click(object sender, EventArgs e)
        {
            if ((resultLabel.Text.IndexOf(",") == -1) && (resultLabel.Text.IndexOf("∞") == -1))
                resultLabel.Text += ",";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "0";
            CorrectNumber();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "1";
            CorrectNumber();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "2";
            CorrectNumber();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "3";
            CorrectNumber();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "4";
            CorrectNumber();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "5";
            CorrectNumber();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "6";
            CorrectNumber();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "7";
            CorrectNumber();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "8";
            CorrectNumber();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            resultLabel.Text += "9";
            CorrectNumber();
        }

        private void addition_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                addition.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                multiplication.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                button0.Enabled = false;
                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                division.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void subtraction_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                subtraction.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void mod_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                mod.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void xDegreeY_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {

                calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                xDegreeY.Enabled = false;
                resultLabel.Text = "0";
            }
        }

        private void arbitraryRoot_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                if (Convert.ToDouble(resultLabel.Text) >= 0)
                {
                    calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                    arbitraryRoot.Enabled = false;
                    resultLabel.Text = "0";
                }
                else
                {
                    resultLabel.Text = "0";
                    MessageBox.Show(
                        "Никаких корней из отрицательных чисел в мою смену!",
                        "Ну что это за глупости такие???",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void logXY_Click(object sender, EventArgs e)
        {
            if (IsActive())
            {
                if (Convert.ToDouble(resultLabel.Text) > 0)
                {
                    calculator.PutNumber(Convert.ToDouble(resultLabel.Text));
                    logXY.Enabled = false;
                    resultLabel.Text = "0";
                }
                else
                {
                    resultLabel.Text = "0";
                    MessageBox.Show(
                        "Отрицательное число под знаком логарифма?..",
                        "Ну что это за глупости такие???",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            if (!addition.Enabled)
                resultLabel.Text = calculator.Addition(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!multiplication.Enabled)
                resultLabel.Text = calculator.Multiplication(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!division.Enabled)
                resultLabel.Text = calculator.Division(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!subtraction.Enabled)
                resultLabel.Text = calculator.Subtraction(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!mod.Enabled)
                resultLabel.Text = calculator.Modulo(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!xDegreeY.Enabled)
                resultLabel.Text = calculator.XDegreeY(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!arbitraryRoot.Enabled)
                resultLabel.Text = calculator.ArbitraryRoot(Convert.ToDouble(resultLabel.Text)).ToString();

            if (!logXY.Enabled)
            {
                if (Convert.ToDouble(resultLabel.Text) > 0 && Convert.ToDouble(resultLabel.Text) != 1)
                    resultLabel.Text = calculator.LogXY(Convert.ToDouble(resultLabel.Text)).ToString();
                else
                {
                    resultLabel.Text = "0";
                    MessageBox.Show(
                        "Что за неуважение к основанию логарифма?!",
                        "Ну что это за глупости такие???",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
                }
            }

            button0.Enabled = true;
            calculator.DeleteNumber();
            MakeActive();
        }

        private void pi_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.Pi().ToString();
        }

        private void e_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.E().ToString();
        }

        private void absolute_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.Absolute(Convert.ToDouble(resultLabel.Text)).ToString();
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(resultLabel.Text) >= 0)
                resultLabel.Text = calculator.Sqrt(Convert.ToDouble(resultLabel.Text)).ToString();
            else
            {
                resultLabel.Text = "0";
                MessageBox.Show(
                    "Никаких корней из отрицательных чисел в мою смену!",
                    "Ну что это за глупости такие???",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.Factorial(Convert.ToDouble(resultLabel.Text)).ToString();
        }

        private void division1X_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.Division1X(Convert.ToDouble(resultLabel.Text)).ToString();
        }

        private void xPower2_Click(object sender, EventArgs e)
        {
            resultLabel.Text = calculator.Square(Convert.ToDouble(resultLabel.Text)).ToString();
        }

        private void naturalLog_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(resultLabel.Text) > 0)
            {
                resultLabel.Text = calculator.NaturalLog(Convert.ToDouble(resultLabel.Text)).ToString();
            }
            else
            {
                resultLabel.Text = "0";
                MessageBox.Show(
                    "Отрицательное число под знаком логарифма?..",
                    "Ну что это за глупости такие???",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1,
                    MessageBoxOptions.DefaultDesktopOnly);
            }
        }
    }
}
