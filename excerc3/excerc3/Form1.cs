namespace excerc3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random random = new Random();

        private void gerarbtn_Click(object sender, EventArgs e)
        {
            resultlb.Items.Clear();
            if (value1Txt.Text != "")
            {
                gerarRandom(int.Parse(value1Txt.Text));
            }
            if (value31Txt.Text != "" && value32Txt.Text != "" && value32Txt.Text != "")
            {
                gerarRandons(int.Parse(value31Txt.Text), int.Parse(value32Txt.Text), int.Parse(value33Txt.Text));
            }
            value1Txt.Clear();
            value31Txt.Clear();
            value32Txt.Clear();
            value33Txt.Clear();
        }

        private void gerarRandom(int value)
        {

            for (int i = 0; i < 4; i++)
            {
                resultlb.Items.Add(random.Next(value));
            }
        }
        private void gerarRandons(int valueMin, int valueMax, int valueTotal)
        {
            for (int i = 0; i < valueTotal; i++)
            {
                resultlb.Items.Add(random.Next(valueMin, valueMax));
            }
        }
    }
}