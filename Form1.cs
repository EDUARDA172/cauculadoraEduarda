namespace cauculadoraEduarda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float number = float.Parse(textBox1.Text);

            float number2 = float.Parse(textBox2.Text);

            float resultado = number + number2;

            textBox3.Text = resultado.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            int number = int.Parse(textBox1.Text);

            float number2 = int.Parse(textBox2.Text);

            float resultado = number - number2;

            textBox3.Text = resultado.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            float number = float.Parse(textBox1.Text);

            float number2 = float.Parse(textBox2.Text);

            float resultado = number * number2;

            textBox3.Text = resultado.ToString();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            float number = float.Parse(textBox1.Text);

            float number2 = float.Parse(textBox2.Text);

            float resultado = number / number2;

            textBox3.Text = resultado.ToString();

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
    }
}