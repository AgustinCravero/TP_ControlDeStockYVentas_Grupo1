namespace FrontTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 FormProducto = new Form3();
            FormProducto.Show();
            this.Hide();
        }
    }
}
