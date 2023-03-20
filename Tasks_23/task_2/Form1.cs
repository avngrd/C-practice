namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "12,3";
            textBox2.Text = "15,4";
            textBox3.Text = "0,252";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            textBox4.Text += Environment.NewLine + " X = " + x.ToString();

            double y = double.Parse(textBox2.Text);
            textBox4.Text += Environment.NewLine + " Y = " + y.ToString();

            double z = double.Parse(textBox3.Text);
            textBox4.Text += Environment.NewLine + " Z = " + z.ToString();

            double g = Math.Pow(y,x + 1)/(3 * Math.Sqrt(Math.Abs(y - 2 )) + 3)  + ((x + (y/2)) / 2 * Math.Abs(x + y))*Math.Pow(x + 1, -1 / Math.Sin(z)) ;

            textBox4.Text += Environment.NewLine + " G = " + g.ToString();

        }
    }
}