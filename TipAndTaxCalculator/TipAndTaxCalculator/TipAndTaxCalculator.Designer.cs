namespace TipAndTaxCalculator
{
    partial class TipAndTaxCalculator
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
            CalculateButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            DollarAmountTextBox = new TextBox();
            AmountLabel = new Label();
            DisplayLabel = new Label();
            Tip15RadioButton = new RadioButton();
            Tip18RadioButton = new RadioButton();
            Tip20RadioButton = new RadioButton();
            TipLabel = new Label();
            TipCustom = new RadioButton();
            DiscountAAACheckBox = new CheckBox();
            DiscountDCCheckBox = new CheckBox();
            DiscountLabel = new Label();
            TipCustomTextBox = new TextBox();
            TipCurrencyLabel = new Label();
            SuspendLayout();
            // 
            // CalculateButton
            // 
            CalculateButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CalculateButton.Location = new Point(465, 373);
            CalculateButton.Name = "CalculateButton";
            CalculateButton.Size = new Size(123, 65);
            CalculateButton.TabIndex = 0;
            CalculateButton.Text = "Calculate";
            CalculateButton.UseVisualStyleBackColor = true;
            CalculateButton.Click += CalculateButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ClearButton.Location = new Point(594, 373);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(94, 65);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ExitButton.Location = new Point(694, 373);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(94, 65);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // DollarAmountTextBox
            // 
            DollarAmountTextBox.Location = new Point(150, 71);
            DollarAmountTextBox.Name = "DollarAmountTextBox";
            DollarAmountTextBox.Size = new Size(253, 27);
            DollarAmountTextBox.TabIndex = 3;
            // 
            // AmountLabel
            // 
            AmountLabel.AutoSize = true;
            AmountLabel.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            AmountLabel.Location = new Point(4, 73);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(140, 22);
            AmountLabel.TabIndex = 4;
            AmountLabel.Text = "Dollar Amount";
            // 
            // DisplayLabel
            // 
            DisplayLabel.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DisplayLabel.Location = new Point(447, 34);
            DisplayLabel.Name = "DisplayLabel";
            DisplayLabel.Size = new Size(308, 308);
            DisplayLabel.TabIndex = 5;
            DisplayLabel.Text = " ";
            // 
            // Tip15RadioButton
            // 
            Tip15RadioButton.AutoSize = true;
            Tip15RadioButton.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tip15RadioButton.Location = new Point(117, 113);
            Tip15RadioButton.Name = "Tip15RadioButton";
            Tip15RadioButton.Size = new Size(61, 26);
            Tip15RadioButton.TabIndex = 6;
            Tip15RadioButton.TabStop = true;
            Tip15RadioButton.Text = "15%";
            Tip15RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip18RadioButton
            // 
            Tip18RadioButton.AutoSize = true;
            Tip18RadioButton.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tip18RadioButton.Location = new Point(117, 143);
            Tip18RadioButton.Name = "Tip18RadioButton";
            Tip18RadioButton.Size = new Size(61, 26);
            Tip18RadioButton.TabIndex = 7;
            Tip18RadioButton.TabStop = true;
            Tip18RadioButton.Text = "18%";
            Tip18RadioButton.UseVisualStyleBackColor = true;
            // 
            // Tip20RadioButton
            // 
            Tip20RadioButton.AutoSize = true;
            Tip20RadioButton.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tip20RadioButton.Location = new Point(117, 173);
            Tip20RadioButton.Name = "Tip20RadioButton";
            Tip20RadioButton.Size = new Size(61, 26);
            Tip20RadioButton.TabIndex = 8;
            Tip20RadioButton.TabStop = true;
            Tip20RadioButton.Text = "20%";
            Tip20RadioButton.UseVisualStyleBackColor = true;
            // 
            // TipLabel
            // 
            TipLabel.AutoSize = true;
            TipLabel.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TipLabel.Location = new Point(4, 114);
            TipLabel.Name = "TipLabel";
            TipLabel.Size = new Size(110, 22);
            TipLabel.TabIndex = 9;
            TipLabel.Text = "Tip Amount";
            // 
            // TipCustom
            // 
            TipCustom.AutoSize = true;
            TipCustom.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TipCustom.Location = new Point(117, 203);
            TipCustom.Name = "TipCustom";
            TipCustom.Size = new Size(91, 26);
            TipCustom.TabIndex = 10;
            TipCustom.TabStop = true;
            TipCustom.Text = "Custom";
            TipCustom.UseVisualStyleBackColor = true;
            // 
            // DiscountAAACheckBox
            // 
            DiscountAAACheckBox.AutoSize = true;
            DiscountAAACheckBox.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountAAACheckBox.Location = new Point(117, 248);
            DiscountAAACheckBox.Name = "DiscountAAACheckBox";
            DiscountAAACheckBox.Size = new Size(62, 26);
            DiscountAAACheckBox.TabIndex = 11;
            DiscountAAACheckBox.Text = "AAA";
            DiscountAAACheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountDCCheckBox
            // 
            DiscountDCCheckBox.AutoSize = true;
            DiscountDCCheckBox.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountDCCheckBox.Location = new Point(117, 278);
            DiscountDCCheckBox.Name = "DiscountDCCheckBox";
            DiscountDCCheckBox.Size = new Size(152, 26);
            DiscountDCCheckBox.TabIndex = 12;
            DiscountDCCheckBox.Text = "Diner's Card";
            DiscountDCCheckBox.UseVisualStyleBackColor = true;
            // 
            // DiscountLabel
            // 
            DiscountLabel.AutoSize = true;
            DiscountLabel.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DiscountLabel.Location = new Point(4, 248);
            DiscountLabel.Name = "DiscountLabel";
            DiscountLabel.Size = new Size(90, 22);
            DiscountLabel.TabIndex = 13;
            DiscountLabel.Text = "Discount";
            // 
            // TipCustomTextBox
            // 
            TipCustomTextBox.Location = new Point(251, 203);
            TipCustomTextBox.Name = "TipCustomTextBox";
            TipCustomTextBox.Size = new Size(124, 27);
            TipCustomTextBox.TabIndex = 14;
            TipCustomTextBox.TabStop = false;
            // 
            // TipCurrencyLabel
            // 
            TipCurrencyLabel.AutoSize = true;
            TipCurrencyLabel.Font = new Font("Consolas", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TipCurrencyLabel.Location = new Point(234, 205);
            TipCurrencyLabel.Name = "TipCurrencyLabel";
            TipCurrencyLabel.Size = new Size(20, 22);
            TipCurrencyLabel.TabIndex = 15;
            TipCurrencyLabel.Text = "$";
            // 
            // TipAndTaxCalculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TipCurrencyLabel);
            Controls.Add(TipCustomTextBox);
            Controls.Add(DiscountLabel);
            Controls.Add(DiscountDCCheckBox);
            Controls.Add(DiscountAAACheckBox);
            Controls.Add(TipCustom);
            Controls.Add(TipLabel);
            Controls.Add(Tip20RadioButton);
            Controls.Add(Tip18RadioButton);
            Controls.Add(Tip15RadioButton);
            Controls.Add(DisplayLabel);
            Controls.Add(AmountLabel);
            Controls.Add(DollarAmountTextBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(CalculateButton);
            Name = "TipAndTaxCalculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tip&Tax";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CalculateButton;
        private Button ClearButton;
        private Button ExitButton;
        private TextBox DollarAmountTextBox;
        private Label AmountLabel;
        private Label DisplayLabel;
        private RadioButton Tip15RadioButton;
        private RadioButton Tip18RadioButton;
        private RadioButton Tip20RadioButton;
        private Label TipLabel;
        private RadioButton TipCustom;
        private CheckBox DiscountAAACheckBox;
        private CheckBox DiscountDCCheckBox;
        private Label DiscountLabel;
        private TextBox TipCustomTextBox;
        private Label TipCurrencyLabel;
    }
}
