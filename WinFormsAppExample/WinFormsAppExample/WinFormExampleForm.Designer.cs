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
            SubmitButton = new Button();
            NameLabel = new Label();
            NameTextbox = new TextBox();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.BackColor = Color.Cyan;
            ExitButton.ImageKey = "(none)";
            ExitButton.Location = new Point(640, 364);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(148, 74);
            ExitButton.TabIndex = 0;
            ExitButton.Text = "&Exit";
            ExitButton.UseVisualStyleBackColor = false;
            ExitButton.Click += ExitButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.BackColor = Color.CadetBlue;
            SubmitButton.Location = new Point(486, 364);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(148, 74);
            SubmitButton.TabIndex = 1;
            SubmitButton.Text = "&Submit";
            SubmitButton.UseVisualStyleBackColor = false;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(201, 121);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(57, 20);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Label 1";
            // 
            // NameTextbox
            // 
            NameTextbox.Location = new Point(264, 118);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(175, 27);
            NameTextbox.TabIndex = 3;
            NameTextbox.TextChanged += this.NameTextbox_TextChanged;
            // 
            // WinFormExampleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(NameTextbox);
            Controls.Add(NameLabel);
            Controls.Add(SubmitButton);
            Controls.Add(ExitButton);
            ForeColor = SystemColors.Desktop;
            Name = "WinFormExampleForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ExitButton;
        private Button SubmitButton;
        private Label NameLabel;
        private TextBox NameTextbox;

        public EventHandler NameTextbox_TextChanged { get; private set; }
    }
}
