namespace Password_Generator
{
    public partial class Form1 : Form
    {


        #region Variables
        int[] asciiCharacters = {33,34,35,36,37,38,39,40,41,42,43,45,46,47,48,49,
            50,51,52,53,54,55,56,57,58,63,64,65,66,67,68,69,70,71,72,73,74,75,76,
            77,78,79,80,81,82,83,84,85,85,87,88,89,90,91,92,93,97,98,99,100,101,
            102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,121,122};
        Random _rnGesus = new Random();
        #endregion








        public Form1()
        {
            InitializeComponent();
            passwordLengthDisplay.Text = passwordLength.Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPassword.Text = SetPassword(passwordLength.Value);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            passwordLengthDisplay.Text = passwordLength.Value.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private string SetPassword(int passwordLength)
        {
            string _password = "";
            for (int i = 0; i < passwordLength; i++)
            {
                _password += (char)asciiCharacters[_rnGesus.Next(0, asciiCharacters.Length)];
            }

            return _password;
        }

    }
}
