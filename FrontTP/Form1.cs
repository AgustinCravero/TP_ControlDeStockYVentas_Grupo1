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

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 FormVenta = new Form7();
            FormVenta.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form11 FormProveedor = new Form11();
            FormProveedor.Show();
            this.Hide();
        }
    }
}
