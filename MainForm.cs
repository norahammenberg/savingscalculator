namespace SavingsCalculator
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// initialxing the application 
        /// and clearing all inputs
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGPU();
        }
        //updateGUI wih clear lines
        private void InitializeGPU()
        {
            textDeposit.Text = string.Empty;
            textYears.Text = string.Empty;
            paid.Text = string.Empty;
            balance.Text = string.Empty;
        }

        //read userinput deposit


        /// <summary>
        /// this method collecting the users input and checking if it is a valed number and returns it. Is it not valid a messege box pops up telling the
        /// user it is not a valid input. It setts the provided number by calling the setter method in the calcelating class
        /// </summary>
        /// <returns> the trhue value</returns>
        private bool readUserDeposit()
        {
            //deposit
            //local variables
            double userDeposit = 0.0;
            bool validatedValue = double.TryParse(textDeposit.Text, out userDeposit);
            if (!validatedValue)
            {
                MessageBox.Show("Invalid input");
            }
            /////setting the input to be used in the next class: 
            return validatedValue;
        }

        /// <summary>
        /// this method collecting the users input and checking if it is a valed number and returns it. Is it not valid a messege box pops up telling the
        /// user it is not a valid input. It setts the provided number by calling the setter method in the calcelating class
        /// </summary>
        /// <returns> the trhue value</returns>
        private bool readUserYears()
        {
            //year
            //local variables
            int userYears = 0;
            bool validatedValue = int.TryParse(textDeposit.Text, out userYears);
            if (!validatedValue)
            {
                MessageBox.Show("Invalid input");
            }
            /////setting the input to be used in the next class: 
            return validatedValue;
        }

        /// <summary>
        /// the method that calls all input methods:
        /// </summary>
        /// <returns>returns the validated iput that the user was providing.</returns>

        private bool readInput()
        {
            bool validatedDeposit = readUserDeposit();
            bool validatedYears = readUserYears();
            return validatedDeposit && validatedYears;
        }

        private void calcDisplayResult()
        {
            //calculate 
            //display
            //calling a calc method from said class
            // amount paid:
            ///xxxxxxx will call the method from the calc class
            double amoutPaid = xxxxxxx;
            paid.Text = amoutPaid.ToString("f2");
            // final balance:
            double finalBalance = xxxxxxx;
            balance.Text = finalBalance.ToString("f2");
        }

        /// <summary>
        /// When the user clicks the Calculating button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_Click(object sender, EventArgs e)
        {
            //calling the calc and display result method to show the result to the user:
            calcDisplayResult();

        }
    }
}