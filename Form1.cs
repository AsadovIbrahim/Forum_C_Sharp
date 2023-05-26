namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        const string Username = "Ibrahim";
        const string Password = "12345678";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text==Username)
            {
                if (textBox2.Text == Password)
                {
                    label5.Text = "Login Succesfully!";
                    label5.ForeColor = Color.Green;
                }
            }
        }
    }
}