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
            Form2 FormAltaProducto = new Form2();
            FormAltaProducto.Show();
            this.Hide();
        }
    }
}
