namespace WinFormsAppExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            SetDefaults();
        }

        void SetDefaults()
        {
            NameTextbox.Text = "";
            NameTextbox.BackColor = Color.LightYellow;
            AgeTextbox.Text = "";
            PhoneTextbox.Text = "";
            CityTextbox.Text = "";

            UpperCase();
            Reverse();
            SubmitButton.Enabled = false;
        }


        private void UpperCase()
        {
            if (UpperCaseRadioButton.Checked)
            {
            NameTextbox.Text += NameTextbox.Text.ToUpper();

            }
        }

        private void Reverse()
        {
            if (ReverseRadioButton.Checked)
            {
                NameTextbox.Text = new string (NameTextbox.Text.Reverse().ToArray());

            }
        }
        //event handlers below -----------------------------------

        private bool ValidateFields()
        {
            bool valid = false;
            string message = "";

            if (CityTextbox.Text == "")
            {
                message = "City is required\n" + message;
                
            }

            if (PhoneTextbox.Text == "")
            {
                message = "Phone is required\n" + message;
                PhoneTextbox.Focus();
            }

            if (AgeTextbox.Text == "")
            {
                message = "Age is required\n" + message;
                AgeTextbox.Focus();
            }

            if (NameTextbox.Text == "")
            {
                message = "Name is required\n" + message;
                NameTextbox.Focus();
            }
            if(message != "")
            {
                MessageBox.Show(message);
            }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            SetDefaults(); 
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            ValidateFields();
            UpperCase();
            //this.Text = NameTextbox.Text;
        }

        

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if(NameTextbox.Text != "")
            {
                NameTextbox.BackColor = Color.Blue;
                SubmitButton.Enabled = true; 
            }
            else
            {
                NameTextbox.BackColor = Color.Red;
                SubmitButton.Enabled = false; 
            }
        }


        private void AgeTextbox_TextChanged(object sender, EventArgs e)
        {
            if (AgeTextbox.Text != "")
            {
                AgeTextbox.BackColor = Color.Blue;
                SubmitButton.Enabled = true;
            }
            else
            {
                AgeTextbox.BackColor = Color.Red;
                SubmitButton.Enabled = false;
            }
        }
    }
}



