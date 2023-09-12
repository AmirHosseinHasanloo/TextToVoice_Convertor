namespace VoiceToText_Convertor
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
            btnSpeak = new Button();
            richTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // btnSpeak
            // 
            btnSpeak.Location = new Point(12, 317);
            btnSpeak.Name = "btnSpeak";
            btnSpeak.Size = new Size(460, 32);
            btnSpeak.TabIndex = 0;
            btnSpeak.Text = "Speak";
            btnSpeak.UseVisualStyleBackColor = true;
            btnSpeak.Click += btnSpeak_Click;
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(12, 12);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(460, 299);
            richTextBox.TabIndex = 1;
            richTextBox.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 358);
            Controls.Add(richTextBox);
            Controls.Add(btnSpeak);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "Convert Text To Voice";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnSpeak;
        private RichTextBox richTextBox;
    }
}