namespace MOD3
{
    public partial class Form1 : Form
    {
        String x = "";
        int a1, a2, sum;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text += "4";
            x += "4";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text += "2";
            x += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text += "3";
            x += "3";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text += "5";
            x += "5";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            label1.Text += "1";
            x += "1";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text += "6";
            x += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text += "7";
            x += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text += "8";
            x += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text += "9";
            x += "9";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label1.Text += "0";
            x += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
            a1 = Int32.Parse(x);
            label1.Text += "+";
            x = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            
            a2 = Int32.Parse(x);
            sum = a1 + a2;
            label1.Text = sum.ToString();
        }
    }
}
