namespace CW_1
{
    public partial class Form1 : Form
    {
        private bool is_authed = false;

        public Form1()
        {
            InitializeComponent();
            Output.Text = "";
            Opacity = 0;
            ShowInTaskbar = false;
            RightToLeftLayout = true;
        }

        public void UserAuthed()
        {
            Opacity = 100;
            ShowInTaskbar = true;
            is_authed = true;
            this.Activate();
        }

        private void MakEncrypt_Click(object sender, EventArgs e)
        {
            string input = Input.Text;
            string keyText = Key.Text;
            int key;
            if (!int.TryParse(keyText, out key))
            {
                MessageBox.Show("Неверное значение ключа");
                return;
            }
            string encryptedText = comboBox1.SelectedIndex == 0 ? EncryptGronsfeld(input, key, "en") : EncryptGronsfeld(input, key, "ru");
            Output.Text = encryptedText;
        }

        private void MakeDeciph_Click(object sender, EventArgs e)
        {
            string result = "";
            string input = Input.Text;
            string keyText = Key.Text;
            int key;
            if (!int.TryParse(keyText, out key))
            {
                MessageBox.Show("Неверное значение ключа");
                return;
            }
            for (int i = 0; i < input.Length; i++)
            {
                char c = input[i];
                int shift = key % 10;
                result += (char)(c - shift);
            }
            Output.Text = result;
        }

        private string EncryptGronsfeld(string input, int key, string lang)
        {
            input = input.ToLower();
            string[] array = lang == "en" ? new string[] { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" }
            : new string[] { "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            string[] array2 = array.Skip(key).Concat(array.Take(array.Length - key)).ToArray();
            string encryptedText = "";
            foreach (char letter in input)
            {
                bool isFound = false;
                for (int i = 0; i < array.Length; i++)
                {
                    if (letter == array[i][0])
                    {
                        encryptedText += array2[i];
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    encryptedText += letter;
                }
            }
            return encryptedText;
        }


        private void Key_TextChanged(object sender, EventArgs e)
        {
            //string input = Input.Text;
            //string keyText = Key.Text;
            //int key;
            //if (!int.TryParse(keyText, out key))
            //{
            //    MessageBox.Show("Неверное значение ключа");
            //    return;
            //}
            //string encrypted = MakEncrypt_Click(input, key);
            //Console.WriteLine("Encrypted: " + encrypted);
            //string decrypted = MakeDeciph_Click(encrypted, key);
            //Console.WriteLine("Decrypted: " + decrypted);
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("en");
                    RightToLeftLayout = false;
                    break;
                case 1:
                    Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ru");
                    RightToLeftLayout = true;
                    break;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}