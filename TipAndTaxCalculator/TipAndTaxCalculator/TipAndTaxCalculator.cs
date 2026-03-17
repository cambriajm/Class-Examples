namespace TipAndTaxCalculator
{
    public partial class TipAndTaxCalculator : Form
    {
        public TipAndTaxCalculator()
        {
            InitializeComponent();
        }
        
        //custom methods------------------------------------------------------
        void SetDefaults()
        {
            DollarAmountTextBox.Text = "";
        }

        //Event Handlers Below-------------------------------------------------
        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close(); //close
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {

        }
    }
}
