namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        double firstValue, secondValue;
        String op;
        String errorMessage = "0";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnterNumbers(object sender, EventArgs e)
        {
            Button numericButton = (Button)sender;

            if (txtResult.Text == "0")
                txtResult.Text = "";
            {
                if (numericButton.Text == ".")
                {
                    if (!txtResult.Text.Contains("."))
                    {
                        txtResult.Text = txtResult.Text + numericButton.Text;
                    }
                }
                else
                {
                    txtResult.Text = txtResult.Text + numericButton.Text;
                }
            }
        }

        private void NumberOperators(object sender, EventArgs e)
        {
            Button operatorButton = (Button)sender;

            try
            {
                firstValue = Convert.ToDouble(txtResult.Text);
                op = operatorButton.Text;
                txtResult.Text = "";
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }

        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            try
            {
                secondValue = Convert.ToDouble(txtResult.Text);
                txtResult.Text = "";
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }

            switch (op)
            {
                case "+":
                    txtResult.Text = Convert.ToString(firstValue + secondValue);
                    break;
                case "-":
                    txtResult.Text = Convert.ToString(firstValue - secondValue);
                    break;
                case "*":
                    txtResult.Text = Convert.ToString(firstValue * secondValue);
                    break;
                case "/":
                    try
                    {
                        txtResult.Text = Convert.ToString(firstValue / secondValue);
                    }
                    catch (System.FormatException exception)
                    {
                        txtResult.Text = errorMessage;
                        Console.WriteLine(exception);
                    }
                    break;
                case "mod":
                    txtResult.Text = Convert.ToString(firstValue % secondValue);
                    break;
                default:
                    break;
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";
            firstValue = secondValue = 0;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtResult.Text = "0";

            String first = Convert.ToString(firstValue);
            String second = Convert.ToString(secondValue);

            first = "";
            second = "";
        }

        private void btnPlusMinus_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(txtResult.Text);
            txtResult.Text = Convert.ToString(-1 * value);
        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtResult.Text.Length > 0)
            {
                txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1);
            }

            if (txtResult.Text == "")
            {
                txtResult.Text = "0";
            }
        }

        private void exitCalculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPI_Click(object sender, EventArgs e)
        {
            txtResult.Text = "3.141592653589976323";
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Log10(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnSqrt_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Sqrt(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnExponential_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Exp(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnSine_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Sin(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Cos(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(value, 2);
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnHexadecimal_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(value, 16);
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnOcta_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtResult.Text);
                txtResult.Text = Convert.ToString(value, 8);
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnInverseLog_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(1 / Math.Log10(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnInverseSine_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Sinh(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnInverseCos_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Cosh(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString((int)value);
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnPower2_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Pow(value, 2));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnPower3_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Pow(value, 3));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnTangent_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Tan(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnInverseTangent_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(Math.Tanh(value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnModulo_Click(object sender, EventArgs e)
        {
            try
            {
                firstValue = Convert.ToDouble(txtResult.Text);
                op = "mod";
                txtResult.Text = "";
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(value / 100);
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }

        private void btnInverse_Click(object sender, EventArgs e)
        {
            try
            {
                double value = Convert.ToDouble(txtResult.Text);
                txtResult.Text = Convert.ToString(1 / (value));
            }
            catch (System.FormatException)
            {
                txtResult.Text = errorMessage;
            }
        }
    }
}
