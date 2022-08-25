namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int not1, not2, not3;
            double ortalama;

            not1 = Convert.ToInt32(textBox1.Text);
            not2 = Convert.ToInt32(textBox2.Text);
            not3 = Convert.ToInt32(textBox3.Text);
            
            ortalama = (double) (not1 + not2 + not3) / 3 ;
            textBox4.Text =Convert.ToString (ortalama);
        }
    }
}