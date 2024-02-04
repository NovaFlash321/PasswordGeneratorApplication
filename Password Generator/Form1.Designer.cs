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
            buttonPassword = new Button();
            passwordLength = new TrackBar();
            label1 = new Label();
            passwordLengthDisplay = new Label();
            textBoxPassword = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)passwordLength).BeginInit();
            SuspendLayout();
            // 
            // buttonPassword
            // 
            buttonPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPassword.Font = new Font("Olivers Barney", 11.25F, FontStyle.Italic, GraphicsUnit.Point);
            buttonPassword.Location = new Point(12, 363);
            buttonPassword.Name = "buttonPassword";
            buttonPassword.Size = new Size(765, 96);
            buttonPassword.TabIndex = 0;
            buttonPassword.Text = "Click to Generate Password";
            buttonPassword.UseVisualStyleBackColor = true;
            buttonPassword.Click += button1_Click;
            // 
            // passwordLength
            // 
            passwordLength.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            passwordLength.Location = new Point(12, 70);
            passwordLength.Maximum = 25;
            passwordLength.Minimum = 13;
            passwordLength.Name = "passwordLength";
            passwordLength.Orientation = Orientation.Vertical;
            passwordLength.Size = new Size(45, 287);
            passwordLength.TabIndex = 3;
            passwordLength.TickStyle = TickStyle.Both;
            passwordLength.Value = 13;
            passwordLength.Scroll += trackBar1_Scroll;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Olivers Barney", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(623, 58);
            label1.TabIndex = 4;
            label1.Text = "Password Generator\n";
            // 
            // passwordLengthDisplay
            // 
            passwordLengthDisplay.AutoSize = true;
            passwordLengthDisplay.Font = new Font("Olivers Barney", 47.9999924F, FontStyle.Regular, GraphicsUnit.Point);
            passwordLengthDisplay.Location = new Point(63, 79);
            passwordLengthDisplay.Name = "passwordLengthDisplay";
            passwordLengthDisplay.Size = new Size(159, 77);
            passwordLengthDisplay.TabIndex = 6;
            passwordLengthDisplay.Text = "???";
            passwordLengthDisplay.Click += label2_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxPassword.BackColor = SystemColors.Menu;
            textBoxPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxPassword.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(63, 300);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(714, 57);
            textBoxPassword.TabIndex = 7;
            textBoxPassword.Text = "??????????????";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(789, 471);
            Controls.Add(textBoxPassword);
            Controls.Add(passwordLengthDisplay);
            Controls.Add(label1);
            Controls.Add(passwordLength);
            Controls.Add(buttonPassword);
            Name = "Form1";
            Text = "Password Generator";
            ((System.ComponentModel.ISupportInitialize)passwordLength).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPassword;
        private TrackBar passwordLength;
        private Label label1;
        private Label passwordLengthDisplay;
        private RichTextBox textBoxPassword;
    }
}
