namespace Lab_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.button1.Hide();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {
            lblBatter.Text = Properties.Resources.butter;
            this.button1.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
