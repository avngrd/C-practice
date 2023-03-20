namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text); 
            double z = Convert.ToDouble(textBox3.Text);

            textBox4.Text += "При X = " + textBox1.Text + Environment.NewLine;
            textBox4.Text += "При Y = " + textBox2.Text + Environment.NewLine;
            textBox4.Text += "При Z = " + textBox3.Text + Environment.NewLine;


            double g =  Math.Max(x * x + y + z, x * y * z) / Math.Min(x * x + y + z, x * y * z);

            textBox4.Text += Environment.NewLine + " G = " + g.ToString();
        }
    }
}