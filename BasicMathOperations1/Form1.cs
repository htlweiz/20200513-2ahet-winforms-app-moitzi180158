using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicMathOperations1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double num1, num2, result;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            /* Version 1 (Runtime Error)
            number1 = Convert.ToInt32(txtNumber1.Text);
            number2 = Convert.ToInt32(txtNumber2.Text);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            /* Version 2 (Wert wird 0 gesetzt)
            Int32.TryParse(txtNumber1.Text, out number1);
            Int32.TryParse(txtNumber2.Text, out number2);
            result = number1 + number2;
            lblResult.Text = Convert.ToString(result);
            lblResultType.Text = "Summe";
            */

            try
            {
                num1 = Convert.ToDouble(txtNumber1.Text);
                num2 = Convert.ToDouble(txtNumber2.Text);
                result = num1 + num2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Summe";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "Kein numerischer Wert!";

                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtNumber1.Text);
                num2 = Convert.ToDouble(txtNumber2.Text);
                result = num1 - num2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "keine Gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtNumber1.Text);
                num2 = Convert.ToDouble(txtNumber2.Text);
                if (num2 == 0)
                {
                    lblResultType.Text = "Fehler";
                    lblResult.Text = "Nicht Definiert";

                    MessageBox.Show("Zahl 2 darf nicht 0 sein.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumber1.Focus();
                    txtNumber1.SelectAll();
                }
                else
                {
                    result = num1 / num2;
                    lblResult.Text = Convert.ToString(result);
                    lblResultType.Text = "Ergebnis";
                }
            }

            catch (Exception ex)
            {

                lblResultType.Text = "Fehler";
                lblResult.Text = "Keine gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear textboxes  and set  focus

            txtNumber1.Text = "0";
            txtNumber2.Text = "0";
            lblResultType.Text = "Ergebnis";
            lblResult.Text = "";
            txtNumber1.Focus();
            txtNumber1.SelectAll();
        }

        private void BtnMultiplication_Click(object sender, EventArgs e)
        {
            try
            {
                num1 = Convert.ToDouble(txtNumber1.Text);
                num2 = Convert.ToDouble(txtNumber2.Text);
                result = num1 * num2;
                lblResult.Text = Convert.ToString(result);
                lblResultType.Text = "Ergebnis";
            }
            catch (Exception ex)
            {
                lblResultType.Text = "Fehler";
                lblResult.Text = "keine Gültige Zahl";

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtNumber1.Focus();
                txtNumber1.SelectAll();
            }
        }

    }
}
