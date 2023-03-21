namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredString = textBox1.Text;
            var checkString = IsPalindrom(enteredString);

            textBox1.Text += Environment.NewLine + checkString;

        }

        static bool IsPalindrom(string str)
        {
            str = str.Replace(" ", "").ToLower();
            return str.Equals(new string(str.Reverse().ToArray()));
        }
    }
}