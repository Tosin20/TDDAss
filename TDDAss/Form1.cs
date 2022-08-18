namespace TDDAss
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void labelCal_Click(object sender, EventArgs e)
        {
            try
            {
                double diagonal1, diagonal2;
                bool first = double.TryParse(textBoxDiag1.Text, out diagonal1);
                bool second = double.TryParse(textBox2Diag2.Text, out diagonal2);
                if(first && second)
                {
                    if((diagonal1 > 0) && (diagonal2 > 0))
                    {
                        double result = Area(diagonal1, diagonal2);
                        textBoxResult.Text = result.ToString();
                    }
                    else
                    {
                        textBoxResult.Text = "Enter Positive Number";
                    }
                                     
                }
                else
                {
                    textBoxResult.Text = "Invalid input";
                }
            }
            catch (Exception)
            {

                textBoxResult.Text = "Try Again";
            }

        }

        public double Area(double d1, double d2)
        {
            return (d1 * d2)/2;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }
    }
}