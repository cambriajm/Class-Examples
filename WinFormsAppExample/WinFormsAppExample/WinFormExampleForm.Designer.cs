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
            ExitButton = new Button();
            ClearButton = new Button();
            NameLabel = new Label();
            NameTextbox = new TextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            Buttons = new GroupBox();
            UserInfo = new GroupBox();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox4 = new CheckBox();
            UpperCase = new RadioButton();
            LowerCase = new RadioButton();
            Reverse = new RadioButton();
            Buttons.SuspendLayout();
            UserInfo.SuspendLayout();
            groupBox1.SuspendLayout();
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
            ClearButton.Click += SubmitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(25, 23);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(49, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            NameLabel.Click += NameLabel_Click;
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(88, 20);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(230, 27);
            NameTextbox.TabIndex = 1;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 72);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 27);
            textBox1.TabIndex = 2;
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
            // textBox2
            // 
            textBox2.Location = new Point(88, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 27);
            textBox2.TabIndex = 3;
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
            // textBox3
            // 
            textBox3.Location = new Point(88, 182);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 27);
            textBox3.TabIndex = 4;
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
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(6, 26);
            button1.Name = "button1";
            button1.Size = new Size(148, 74);
            button1.TabIndex = 5;
            button1.Text = "&Submit";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Buttons
            // 
            Buttons.Controls.Add(button1);
            Buttons.Controls.Add(ClearButton);
            Buttons.Controls.Add(ExitButton);
            Buttons.Location = new Point(340, 326);
            Buttons.Name = "Buttons";
            Buttons.Size = new Size(448, 112);
            Buttons.TabIndex = 5;
            Buttons.TabStop = false;
            Buttons.Enter += groupBox1_Enter;
            // 
            // UserInfo
            // 
            UserInfo.Controls.Add(NameLabel);
            UserInfo.Controls.Add(NameTextbox);
            UserInfo.Controls.Add(textBox3);
            UserInfo.Controls.Add(label1);
            UserInfo.Controls.Add(label3);
            UserInfo.Controls.Add(textBox1);
            UserInfo.Controls.Add(textBox2);
            UserInfo.Controls.Add(label2);
            UserInfo.Location = new Point(24, 23);
            UserInfo.Name = "UserInfo";
            UserInfo.Size = new Size(356, 225);
            UserInfo.TabIndex = 0;
            UserInfo.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Location = new Point(386, 32);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(406, 216);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(33, 168);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(117, 24);
            radioButton3.TabIndex = 4;
            radioButton3.TabStop = true;
            radioButton3.Text = "radioButton3";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(33, 138);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(117, 24);
            radioButton2.TabIndex = 3;
            radioButton2.TabStop = true;
            radioButton2.Text = "radioButton2";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(33, 108);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(117, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "radioButton1";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(33, 67);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(101, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "checkBox2";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(33, 37);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(101, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "checkBox1";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(172, 326);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(101, 24);
            checkBox3.TabIndex = 3;
            checkBox3.Text = "checkBox3";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(172, 356);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(101, 24);
            checkBox4.TabIndex = 12;
            checkBox4.Text = "checkBox4";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // UpperCase
            // 
            UpperCase.AutoSize = true;
            UpperCase.Location = new Point(24, 280);
            UpperCase.Name = "UpperCase";
            UpperCase.Size = new Size(71, 24);
            UpperCase.TabIndex = 1;
            UpperCase.TabStop = true;
            UpperCase.Text = "Upper";
            UpperCase.UseVisualStyleBackColor = true;
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
            // Reverse
            // 
            Reverse.AutoSize = true;
            Reverse.Location = new Point(24, 340);
            Reverse.Name = "Reverse";
            Reverse.Size = new Size(81, 24);
            Reverse.TabIndex = 14;
            Reverse.TabStop = true;
            Reverse.Text = "Reverse";
            Reverse.UseVisualStyleBackColor = true;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reverse);
            Controls.Add(LowerCase);
            Controls.Add(UpperCase);
            Controls.Add(checkBox4);
            Controls.Add(checkBox3);
            Controls.Add(groupBox1);
            Controls.Add(UserInfo);
            Controls.Add(Buttons);
            ForeColor = SystemColors.Desktop;
            Name = "WinFormExampleForm";
            Text = "Form1";
            Buttons.ResumeLayout(false);
            UserInfo.ResumeLayout(false);
            UserInfo.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void NameLabel_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button ExitButton;
        private Button ClearButton;
        private Label NameLabel;
        private TextBox NameTextbox;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private Button button1;
        private GroupBox Buttons;
        private GroupBox UserInfo;
        private GroupBox groupBox1;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private CheckBox checkBox3;
        private CheckBox checkBox4;
        private RadioButton UpperCase;
        private RadioButton LowerCase;
        private RadioButton Reverse;
    }
}
