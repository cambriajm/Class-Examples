namespace ListExamples
{
    partial class ListExamples
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
            SubmitButton = new Button();
            ClearButton = new Button();
            ExitButton = new Button();
            OutPutBox = new GroupBox();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            OutPutBox.SuspendLayout();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(504, 466);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(139, 63);
            SubmitButton.TabIndex = 0;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(649, 466);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(139, 63);
            ClearButton.TabIndex = 1;
            ClearButton.Text = "&Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(794, 466);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(139, 63);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // OutPutBox
            // 
            OutPutBox.Controls.Add(listBox1);
            OutPutBox.Controls.Add(comboBox1);
            OutPutBox.Location = new Point(380, 5);
            OutPutBox.Name = "OutPutBox";
            OutPutBox.Size = new Size(555, 455);
            OutPutBox.TabIndex = 3;
            OutPutBox.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(35, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(399, 28);
            comboBox1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(13, 80);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(532, 364);
            listBox1.TabIndex = 1;
            // 
            // ListExamples
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(940, 534);
            Controls.Add(OutPutBox);
            Controls.Add(ExitButton);
            Controls.Add(ClearButton);
            Controls.Add(SubmitButton);
            Name = "ListExamples";
            Text = "Form1";
            OutPutBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button SubmitButton;
        private Button ClearButton;
        private Button ExitButton;
        private GroupBox OutPutBox;
        private ListBox listBox1;
        private ComboBox comboBox1;
    }
}
