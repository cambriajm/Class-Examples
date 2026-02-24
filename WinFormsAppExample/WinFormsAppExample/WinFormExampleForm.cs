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
            AgeTextbox.Text = "";
            PhoneTextbox.Text = "";
            CityTextbox.Text = "";

            UpperCase.Checked = true;
        }

        //event handlers below 

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
             
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            this.Text = NameTextbox.Text;
        }

        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}



