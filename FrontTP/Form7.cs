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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 FormNuevaVenta = new Form8();
            FormNuevaVenta.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form10 FormReporteVentas = new Form10();
            FormReporteVentas.Show();
            this.Hide();
        }
    }
}
