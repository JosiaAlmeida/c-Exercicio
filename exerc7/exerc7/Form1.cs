namespace exerc7
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random random = new Random();
        int valor = 0;
        public Form1()
        {
            valor = random.Next(1, 10);
            InitializeComponent();
        }
        private void jogarbtn_Click(object sender, EventArgs e)
        {
            if(valuetxt.Text == valor.ToString())
            {
                MessageBox.Show("Parabens, você ganhou");
            }
            else
            {
                count++;
                if(int.Parse(valuetxt.Text) > valor)
                {
                    MessageBox.Show("O numero digitado é maior");
                }
                if (int.Parse(valuetxt.Text) < valor)
                {
                    MessageBox.Show("O numero digitado é menor");
                }
            }
            if(count >= 3)
            {
                MessageBox.Show("Você perdeu");
                this.Close();
            }
        }
    }
}