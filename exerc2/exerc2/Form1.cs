namespace exerc2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {

            if (somarcb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) + Double.Parse(value2txt.Text)).ToString();
            }
            if (subtraircb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) - Double.Parse(value2txt.Text)).ToString();
            }
            if (dividircb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) / Double.Parse(value2txt.Text)).ToString();
            }
            if (multiplicarcb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) * Double.Parse(value2txt.Text)).ToString();
            }
        }

        private void novoCalculobtn_Click(object sender, EventArgs e)
        {
            resultadotxt.Clear();
            value1txt.Clear();
            value2txt.Clear();
        }

        private void sairbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}