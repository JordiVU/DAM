namespace PruebaWindows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            string selOperator = (string)(cmbOperator.SelectedItem);

            if (txtNumber1.Text != "" && txtNumber2.Text != "" 
                && selOperator != null)
            {
                int number1 = Convert.ToInt32(txtNumber1.Text);
                int number2 = Convert.ToInt32(txtNumber2.Text);
                switch (selOperator)
                {
                    case "+":
                        lblResult.Text = "" + (number1 + number2);
                        break;
                    case "-":
                        lblResult.Text = "" + (number1 - number2);
                        break;
                    case "*":
                        lblResult.Text = "" + (number1 * number2);
                        break;
                    case "/":
                        lblResult.Text = "" + (number1 / number2);
                        break;
                }
            }
            else
            {
                MessageBox.Show("No operator is selected");
            }
        }
    }
}
