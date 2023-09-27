namespace Task2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        /*private void Form1_Load(object sender, EventArgs e)
        {
        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";

        }





        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                decimal classA = decimal.Parse(textBox2.Text) * 15;
                decimal classB = decimal.Parse(textBox3.Text) * 12;
                decimal classC = decimal.Parse(textBox4.Text) * 9;
                decimal total = classA + classB + classC;
                label14.Text = classA.ToString("C");
                label13.Text = classB.ToString("C");
                label12.Text = classC.ToString("C");
                label11.Text = total.ToString("C");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}