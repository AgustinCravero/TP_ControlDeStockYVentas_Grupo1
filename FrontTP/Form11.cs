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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 FormNuevoProveedor = new Form12();
            FormNuevoProveedor.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form13 FormEliminarProveedor = new Form13();
            FormEliminarProveedor.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form14 FormModificarProveedor = new Form14();
            FormModificarProveedor.Show();
            this.Hide();
        }
    }
}
