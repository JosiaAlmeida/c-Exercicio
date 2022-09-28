namespace exerc5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Gerarbtn_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < int.Parse(textbox1.Text); i++)
            {
                if(i%2==0)
                    listBox1.Items.Add(i);
            }
        }

        private void limpar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            textbox1.Clear();
        }
    }
}