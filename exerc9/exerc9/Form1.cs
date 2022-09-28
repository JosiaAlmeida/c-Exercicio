namespace exerc9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calendario.SelectionRange.Start = new DateTime(DateTime.Now.Year, int.Parse(mesTxt.Text), DateTime.Now.Day);
            calendario.SelectionRange.End = new DateTime(DateTime.Now.Year, int.Parse(mesTxt.Text), DateTime.Now.Day);
        }
    }
}