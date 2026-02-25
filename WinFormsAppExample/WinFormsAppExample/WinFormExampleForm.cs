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

            UpperCase.Checked = true;
            SubmitButton.Enabled = false;
        }

        //event handlers below 

        private void ValidateFields()
        {
            string message = "";

            if (CityTextbox.Text == "")
            {
                message = "City is required\n" + message;
                CityTextbox.Focus();
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
            //this.Text = NameTextbox.Text;
        }

        

        private void NameTextbox_TextChanged()
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
    }
}



