using System.Speech.Synthesis;

namespace VoiceToText_Convertor
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer reader;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            reader = new SpeechSynthesizer();
            richTextBox.ScrollBars = RichTextBoxScrollBars.Both;
        }

        void reader_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            this.Text = "End !!!";
        }

        private void btnSpeak_Click(object sender, EventArgs e)
        {
            reader.Dispose();
            if (richTextBox.Text != "")
            {
                reader = new SpeechSynthesizer();
                reader.SpeakAsync(richTextBox.Text);
                this.Text = "Speaking !!!";

                reader.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(reader_SpeakCompleted);
            }
            else
            {
                MessageBox.Show("Please Insert Text !!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}