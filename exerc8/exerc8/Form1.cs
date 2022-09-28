namespace exerc8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void limparbtn_Click(object sender, EventArgs e)
        {
            nota1txt.Clear();
            nota2txt.Clear();
            nota3txt.Clear();
            nota4txt.Clear();
            resultadotxt.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double value1 = int.Parse(nota1txt.Text), value2 = int.Parse(nota2txt.Text), value3 = int.Parse(nota3txt.Text), value4 = int.Parse(nota4txt.Text);
            List<double> som =new List<double>() { value1, value2, value3, value4 };
            som.Sort();
            som.Remove(som[0]);
            double result = (som.Sum()) / 4;
            resultadotxt.Text = result.ToString();
        }
        
    }
}