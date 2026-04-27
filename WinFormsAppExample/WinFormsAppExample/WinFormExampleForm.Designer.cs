namespace WinFormsAppExample
{
    partial class WinFormExampleForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ExitButton = new Button();
            ClearButton = new Button();
            NameLabel = new Label();
            NameTextbox = new TextBox();
            AgeTextbox = new TextBox();
            label1 = new Label();
            PhoneTextbox = new TextBox();
            label2 = new Label();
            CityTextbox = new TextBox();
            label3 = new Label();
            SubmitButton = new Button();
            Buttons = new GroupBox();
            UserInfo = new GroupBox();
            UpperCaseRadioButton = new RadioButton();
            LowerCase = new RadioButton();
            ReverseRadioButton = new RadioButton();
            ToolTip = new ToolTip(components);
            MainOpenFileDIalog = new OpenFileDialog();
            menuStrip1 = new MenuStrip();
            FileMenuItem = new ToolStripMenuItem();
            OpenMenuItem = new ToolStripMenuItem();
            SubmitMenuItem = new ToolStripMenuItem();
            ClearMenuItem = new ToolStripMenuItem();
            ExitMenuItem = new ToolStripMenuItem();
            HelpMenuItem = new ToolStripMenuItem();
            DisplayListBox = new ListBox();
            FilterGroupBox = new GroupBox();
            LastNameRadioButton = new RadioButton();
            FirstNameRadioButton = new RadioButton();
            CityRadioButton = new RadioButton();
            FilterComboBox = new ComboBox();
            Buttons.SuspendLayout();
            UserInfo.SuspendLayout();
            menuStrip1.SuspendLayout();
            FilterGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Cyan;
            ExitButton.ImageKey = "(none)";
            ExitButton.Location = new Point(294, 26);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 74);
            ExitButton.TabIndex = 7;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.BackColor = Color.CadetBlue;
            ClearButton.Location = new Point(148, 26);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(148, 74);
            ClearButton.TabIndex = 6;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = false;
            ClearButton.Click += ClearButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(25, 23);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(88, 20);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(230, 27);
            NameTextbox.TabIndex = 1;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            // 
            // AgeTextbox
            // 
            AgeTextbox.Location = new Point(88, 72);
            AgeTextbox.Name = "AgeTextbox";
            AgeTextbox.Size = new Size(230, 27);
            AgeTextbox.TabIndex = 2;
            AgeTextbox.TextChanged += AgeTextbox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 75);
            label1.Name = "label1";
            label1.Size = new Size(36, 20);
            label1.TabIndex = 4;
            label1.Text = "Age";
            // 
            // PhoneTextbox
            // 
            PhoneTextbox.Location = new Point(88, 127);
            PhoneTextbox.Name = "PhoneTextbox";
            PhoneTextbox.Size = new Size(230, 27);
            PhoneTextbox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 130);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 6;
            label2.Text = "Phone";
            // 
            // CityTextbox
            // 
            CityTextbox.Location = new Point(88, 182);
            CityTextbox.Name = "CityTextbox";
            CityTextbox.Size = new Size(230, 27);
            CityTextbox.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 185);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 8;
            label3.Text = "City";
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.CadetBlue;
            SubmitButton.Location = new Point(6, 26);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(148, 74);
            SubmitButton.TabIndex = 5;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // Buttons
            // 
            Buttons.Controls.Add(SubmitButton);
            Buttons.Controls.Add(ClearButton);
            Buttons.Controls.Add(ExitButton);
            Buttons.Location = new Point(340, 326);
            Buttons.Name = "Buttons";
            Buttons.Size = new Size(448, 112);
            Buttons.TabIndex = 5;
            Buttons.TabStop = false;
            // 
            // UserInfo
            // 
            UserInfo.Controls.Add(NameLabel);
            UserInfo.Controls.Add(NameTextbox);
            UserInfo.Controls.Add(CityTextbox);
            UserInfo.Controls.Add(label1);
            UserInfo.Controls.Add(label3);
            UserInfo.Controls.Add(AgeTextbox);
            UserInfo.Controls.Add(PhoneTextbox);
            UserInfo.Controls.Add(label2);
            UserInfo.Location = new Point(24, 23);
            UserInfo.Name = "UserInfo";
            UserInfo.Size = new Size(356, 225);
            UserInfo.TabIndex = 0;
            UserInfo.TabStop = false;
            // 
            // UpperCaseRadioButton
            // 
            UpperCaseRadioButton.AutoSize = true;
            UpperCaseRadioButton.Location = new Point(24, 280);
            UpperCaseRadioButton.Name = "UpperCaseRadioButton";
            UpperCaseRadioButton.Size = new Size(71, 24);
            UpperCaseRadioButton.TabIndex = 1;
            UpperCaseRadioButton.TabStop = true;
            UpperCaseRadioButton.Text = "Upper";
            UpperCaseRadioButton.UseVisualStyleBackColor = true;
            // 
            // LowerCase
            // 
            LowerCase.AutoSize = true;
            LowerCase.Location = new Point(24, 310);
            LowerCase.Name = "LowerCase";
            LowerCase.Size = new Size(70, 24);
            LowerCase.TabIndex = 2;
            LowerCase.TabStop = true;
            LowerCase.Text = "Lower";
            LowerCase.UseVisualStyleBackColor = true;
            // 
            // ReverseRadioButton
            // 
            ReverseRadioButton.AutoSize = true;
            ReverseRadioButton.Location = new Point(24, 340);
            ReverseRadioButton.Name = "ReverseRadioButton";
            ReverseRadioButton.Size = new Size(81, 24);
            ReverseRadioButton.TabIndex = 14;
            ReverseRadioButton.TabStop = true;
            ReverseRadioButton.Text = "Reverse";
            ReverseRadioButton.UseVisualStyleBackColor = true;
            // 
            // MainOpenFileDIalog
            // 
            MainOpenFileDIalog.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { FileMenuItem, HelpMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // FileMenuItem
            // 
            FileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { OpenMenuItem, SubmitMenuItem, ClearMenuItem, ExitMenuItem });
            FileMenuItem.Name = "FileMenuItem";
            FileMenuItem.Size = new Size(46, 24);
            FileMenuItem.Text = "File";
            // 
            // OpenMenuItem
            // 
            OpenMenuItem.Name = "OpenMenuItem";
            OpenMenuItem.Size = new Size(139, 26);
            OpenMenuItem.Text = "&Open";
            OpenMenuItem.Click += OpenMenuItem_Click_1;
            // 
            // SubmitMenuItem
            // 
            SubmitMenuItem.Name = "SubmitMenuItem";
            SubmitMenuItem.Size = new Size(139, 26);
            SubmitMenuItem.Text = "&Submit";
            // 
            // ClearMenuItem
            // 
            ClearMenuItem.Name = "ClearMenuItem";
            ClearMenuItem.Size = new Size(139, 26);
            ClearMenuItem.Text = "&Clear";
            // 
            // ExitMenuItem
            // 
            ExitMenuItem.Name = "ExitMenuItem";
            ExitMenuItem.Size = new Size(139, 26);
            ExitMenuItem.Text = "E&xit";
            // 
            // HelpMenuItem
            // 
            HelpMenuItem.Name = "HelpMenuItem";
            HelpMenuItem.Size = new Size(55, 24);
            HelpMenuItem.Text = "Help";
            // 
            // DisplayListBox
            // 
            DisplayListBox.FormattingEnabled = true;
            DisplayListBox.Location = new Point(388, 44);
            DisplayListBox.Name = "DisplayListBox";
            DisplayListBox.Size = new Size(375, 244);
            DisplayListBox.TabIndex = 16;
            // 
            // FilterGroupBox
            // 
            FilterGroupBox.Controls.Add(LastNameRadioButton);
            FilterGroupBox.Controls.Add(FirstNameRadioButton);
            FilterGroupBox.Controls.Add(CityRadioButton);
            FilterGroupBox.Location = new Point(152, 274);
            FilterGroupBox.Name = "FilterGroupBox";
            FilterGroupBox.Size = new Size(160, 144);
            FilterGroupBox.TabIndex = 17;
            FilterGroupBox.TabStop = false;
            FilterGroupBox.Text = "Filter";
            // 
            // LastNameRadioButton
            // 
            LastNameRadioButton.AutoSize = true;
            LastNameRadioButton.Location = new Point(26, 96);
            LastNameRadioButton.Name = "LastNameRadioButton";
            LastNameRadioButton.Size = new Size(100, 24);
            LastNameRadioButton.TabIndex = 20;
            LastNameRadioButton.TabStop = true;
            LastNameRadioButton.Text = "Last Name";
            LastNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // FirstNameRadioButton
            // 
            FirstNameRadioButton.AutoSize = true;
            FirstNameRadioButton.Location = new Point(26, 66);
            FirstNameRadioButton.Name = "FirstNameRadioButton";
            FirstNameRadioButton.Size = new Size(101, 24);
            FirstNameRadioButton.TabIndex = 19;
            FirstNameRadioButton.TabStop = true;
            FirstNameRadioButton.Text = "First Name";
            FirstNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // CityRadioButton
            // 
            CityRadioButton.AutoSize = true;
            CityRadioButton.Location = new Point(26, 36);
            CityRadioButton.Name = "CityRadioButton";
            CityRadioButton.Size = new Size(55, 24);
            CityRadioButton.TabIndex = 18;
            CityRadioButton.TabStop = true;
            CityRadioButton.Text = "City";
            CityRadioButton.UseVisualStyleBackColor = true;
            CityRadioButton.CheckedChanged += CityRadioButton_CheckedChanged;
            // 
            // FilterComboBox
            // 
            FilterComboBox.FormattingEnabled = true;
            FilterComboBox.Location = new Point(416, 5);
            FilterComboBox.Name = "FilterComboBox";
            FilterComboBox.Size = new Size(171, 28);
            FilterComboBox.TabIndex = 18;
            FilterComboBox.Text = "Filter";
            FilterComboBox.SelectedIndexChanged += FilterComboBox_SelectedIndexChanged;
            // 
            // WinFormExampleForm
            // 
            AcceptButton = SubmitButton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = ClearButton;
            ClientSize = new Size(800, 450);
            Controls.Add(FilterComboBox);
            Controls.Add(FilterGroupBox);
            Controls.Add(DisplayListBox);
            Controls.Add(ReverseRadioButton);
            Controls.Add(LowerCase);
            Controls.Add(UpperCaseRadioButton);
            Controls.Add(UserInfo);
            Controls.Add(Buttons);
            Controls.Add(menuStrip1);
            ForeColor = SystemColors.Desktop;
            MainMenuStrip = menuStrip1;
            Name = "WinFormExampleForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Example Form";
            Buttons.ResumeLayout(false);
            UserInfo.ResumeLayout(false);
            UserInfo.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            FilterGroupBox.ResumeLayout(false);
            FilterGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }






        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Label NameLabel;
        private TextBox NameTextbox;
        private TextBox AgeTextbox;
        private Label label1;
        private TextBox PhoneTextbox;
        private Label label2;
        private TextBox CityTextbox;
        private Label label3;
        private Button SubmitButton;
        private GroupBox Buttons;
        private GroupBox UserInfo;
        private RadioButton UpperCaseRadioButton;
        private RadioButton LowerCase;
        private RadioButton ReverseRadioButton;
        private ToolTip ToolTip;
        private OpenFileDialog MainOpenFileDIalog;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem FileMenuItem;
        private ToolStripMenuItem OpenMenuItem;
        private ToolStripMenuItem SubmitMenuItem;
        private ToolStripMenuItem ClearMenuItem;
        private ToolStripMenuItem ExitMenuItem;
        private ToolStripMenuItem HelpMenuItem;
        private ListBox DisplayListBox;
        private GroupBox FilterGroupBox;
        private RadioButton LastNameRadioButton;
        private RadioButton FirstNameRadioButton;
        private RadioButton CityRadioButton;
        private ComboBox FilterComboBox;
    }
}
