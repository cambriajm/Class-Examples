namespace GraphicsExample
{
    partial class GraphicsForm
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
            DisplayPictureBox = new PictureBox();
            DrawButton = new Button();
            ExitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).BeginInit();
            SuspendLayout();
            // 
            // DisplayPictureBox
            // 
            DisplayPictureBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DisplayPictureBox.BackColor = SystemColors.ActiveCaption;
            DisplayPictureBox.Location = new Point(41, 38);
            DisplayPictureBox.Name = "DisplayPictureBox";
            DisplayPictureBox.Size = new Size(867, 423);
            DisplayPictureBox.TabIndex = 0;
            DisplayPictureBox.TabStop = false;
            // 
            // DrawButton
            // 
            DrawButton.Location = new Point(588, 481);
            DrawButton.Name = "DrawButton";
            DrawButton.Size = new Size(150, 59);
            DrawButton.TabIndex = 1;
            DrawButton.Text = "Draw";
            DrawButton.UseVisualStyleBackColor = true;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(758, 481);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 59);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "E&xit";
            ExitButton.UseVisualStyleBackColor = true;
            // 
            // GraphicsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(950, 552);
            Controls.Add(ExitButton);
            Controls.Add(DrawButton);
            Controls.Add(DisplayPictureBox);
            Name = "GraphicsForm";
            Text = "Graphics";
            ((System.ComponentModel.ISupportInitialize)DisplayPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox DisplayPictureBox;
        private Button DrawButton;
        private Button ExitButton;
    }
}
