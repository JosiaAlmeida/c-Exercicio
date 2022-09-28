namespace exerc4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void calcbtn_Click(object sender, EventArgs e)
        {
            double value1 = int.Parse(atxt.Text), value2 = int.Parse(btxt.Text), value3 = int.Parse(ctxt.Text);
            double delta = (value2 * value2) - 4 * value1 * value3;
            if(delta < 0)
            {
                MessageBox.Show("Sem Delta");
            }
            if(delta == 0)
            {
                deltatxt.Text = delta.ToString();
            }
            if(delta > 0)
            {
                deltatxt.Text = delta.ToString();
                x1txt.Text = ((value2 - Math.Sqrt(delta))/ 2 * value1).ToString();
                x2txt.Text = ((value2 + Math.Sqrt(delta)) / 2 * value1).ToString();
            }
        }

        private void novoCalcbtn_Click(object sender, EventArgs e)
        {
            deltatxt.Clear();
            x1txt.Clear();
            x2txt.Clear();
            atxt.Clear();
            btxt.Clear();
            ctxt.Clear();
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}