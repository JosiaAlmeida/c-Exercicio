namespace exerc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcularbtn_Click(object sender, EventArgs e)
        {
            if (somarb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) + Double.Parse(value2txt.Text)).ToString(); 
            }
            if (subtrairb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) - Double.Parse(value2txt.Text)).ToString();
            }
            if (dividirb.Checked)
            {
                resultadotxt.Text = (Double.Parse(value1txt.Text) / Double.Parse(value2txt.Text)).ToString();
            }
            if (multiplicarb.Checked)
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