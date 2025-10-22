using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontTP
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 FormNuevoProducto = new Form2();
            FormNuevoProducto.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 FormEliminarProducto = new Form4();
            FormEliminarProducto.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 FormModificarProducto = new Form5();
            FormModificarProducto.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 FormVerProducto = new Form6();
            FormVerProducto.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form9 FormReporteStockBajo = new Form9();
            FormReporteStockBajo.Show();
            this.Hide();
        }
    }
}
