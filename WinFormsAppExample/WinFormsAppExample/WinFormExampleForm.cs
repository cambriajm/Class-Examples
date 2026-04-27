using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsAppExample
{
    public partial class WinFormExampleForm : Form
    {
        public WinFormExampleForm()
        {
            InitializeComponent();
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            SetDefaults();
        }
        string[,] CustomerData = new string[0, 0];
        void SetDefaults()
        {
            NameTextbox.Text = "";
            NameTextbox.BackColor = Color.LightYellow;
            AgeTextbox.Text = "";
            PhoneTextbox.Text = "";
            CityTextbox.Text = "";

           
            UpperCaseRadioButton.Checked = true;
            CityRadioButton.Checked = true;
            SubmitButton.Enabled = false;
            SubmitMenuItem.Enabled = false;

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
            if (message != "")
            {
                MessageBox.Show(message);
            }
            return true;
        }
        private string UpperCase(string toUpper)
        {
            if (UpperCaseRadioButton.Checked)
            {
                return toUpper.ToUpper();
            }
            else
            {
                return toUpper;
            }
        }
        private string lowerCase(string toLower)
        {
            if (LowerCase.Checked)
            {
                return toLower.ToLower();
            }
            else
            {
                return toLower;
            }
        }

        private string Reverse(string reverseThis)
        {
            if (ReverseRadioButton.Checked)
            {
                return new string(reverseThis.Reverse().ToArray());
            }
            else
            {
                return reverseThis;
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



        private void NameTextbox_TextChanged(object sender, EventArgs e)
        {
            if (NameTextbox.Text != "")
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

        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }
        void FileToArray(string filePath)
        {
            string[,] _customerData = new string[4, CountOfLinesIn(filePath)];
            string[] temp;
            int counter = 0;

            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    temp = testFile.ReadLine().Split(",");
                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\"", "");
                        _customerData[0, counter] = temp[0];
                        _customerData[1, counter] = temp[1];
                        _customerData[2, counter] = temp[2];
                        _customerData[3, counter] = temp[3];
                    }
                    counter++;
                } while (!testFile.EndOfStream);
            }
            this.CustomerData = _customerData;
        }
        void DisplayData()
        {
            string[,] data = this.CustomerData;
            string formattedRow = "";
            int filterColumn = 2;
            DisplayListBox.Items.Clear();

            switch (true)
            {
                case bool when CityRadioButton.Checked:
                    filterColumn = 2;
                    break;
                case bool when LastNameRadioButton.Checked:
                    filterColumn = 1;
                    break;
                case bool when FirstNameRadioButton.Checked:
                    filterColumn = 0;
                    break;
                    //default:
            }

            for (int row = 0; row < data.GetLength(1); row++)
            {
                for (int column = 0; column < data.GetLength(0); column++)
                {
                    if (data[column, row] != null && (data[filterColumn, row] == FilterComboBox.SelectedItem.ToString() || FilterComboBox.SelectedIndex == 0))
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
                }
                if (formattedRow != "")
                {
                    DisplayListBox.Items.Add(formattedRow);
                }
                formattedRow = "";
            }
        }
        void LoadFilterComboBox()
        {
            int column = 1;
            FilterComboBox.Items.Clear();

            switch (true)
            {
                case bool when CityRadioButton.Checked:
                    column = 2;
                    break;
                case bool when LastNameRadioButton.Checked:
                    column = 1;
                    break;
                case bool when FirstNameRadioButton.Checked:
                    column = 0;
                    break;
                    //default:
            }

            for (int row = 0; (row < this.CustomerData.GetUpperBound(1)); row++)
            {
                if (this.CustomerData[column, row] != null && FilterComboBox.Items.Contains(this.CustomerData[column, row]) != true)
                {

                    FilterComboBox.Items.Add(this.CustomerData[column, row]); //add city 
                }
            }
            FilterComboBox.Items.Add("~Select~");
            FilterComboBox.Sorted = true;
            FilterComboBox.SelectedIndex = 0;

        }
        private void OpenMenuItem_Click_1(object sender, EventArgs e)
        {
            string filePath = "";
            string[,] fileData;

            MainOpenFileDIalog.FileName = "";
            MainOpenFileDIalog.Filter = "txt files (*.txt)|*.txt|wav files (*.wav)|*.wav|All files (*.*)|*.*";
            // if the user hits ok open the file and display file contents
            if (MainOpenFileDIalog.ShowDialog() == DialogResult.OK)
            {
                filePath = MainOpenFileDIalog.FileName;
                FileToArray(filePath);
                DisplayData();

            }

        }
        private void FilterComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void CityRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilterComboBox();
        }
    }
}