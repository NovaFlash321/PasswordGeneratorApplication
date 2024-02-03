namespace Password_Generator
{
    partial class Form1
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
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Olivers Barney", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            button1.Location = new Point(226, 189);
            button1.Name = "button1";
            button1.Size = new Size(201, 96);
            button1.TabIndex = 0;
            button1.Text = "Click to Generate Password";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BorderStyle = BorderStyle.FixedSingle;
            richTextBox1.Font = new Font("Olivers Barney", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            richTextBox1.Location = new Point(12, 12);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.ScrollBars = RichTextBoxScrollBars.None;
            richTextBox1.Size = new Size(620, 65);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "Password Generator\n";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(647, 297);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Password Generator";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private RichTextBox richTextBox1;
    }
}
