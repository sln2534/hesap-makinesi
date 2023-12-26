namespace artık_ol
{
    public partial class Form1 : Form
    {
        int sayı1, sayı2;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = true;
                groupBox4.Enabled = false;
            }
            else if (radioButton2.Checked)
            {
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
                groupBox4.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                MessageBox.Show(Math.Pow(sayı1, sayı2).ToString());
            }
            else if (radioButton8.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(Math.Sqrt(sayı1).ToString());
            }
            else if (radioButton9.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                MessageBox.Show(Math.Abs(sayı1).ToString());
            }
            else if(radioButton3.Checked) 
            { 
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                int hesap = sayı1 + sayı2;
                MessageBox.Show(hesap.ToString());

            }
            else if( radioButton4.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                int hesap = sayı1 - sayı2;
                MessageBox.Show(hesap.ToString());
            }
            else if (radioButton5.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                int hesap = sayı2 * sayı1;
                MessageBox.Show(hesap.ToString());
            }
            else if (radioButton6.Checked)
            {
                int sayı1 = Convert.ToInt32(textBox1.Text);
                int sayı2 = Convert.ToInt32(textBox2.Text);
                double hesap = sayı1 / sayı2;
                MessageBox.Show(hesap.ToString());
            }
        }
    }
}