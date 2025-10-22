using ClasesTP.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesTP.Repositories;

namespace FrontTP
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var lista = ProductoRepository.ObtenerProductosConStockMenorA(int.Parse(textBox1.Text))
                .Select(p => new
                {
                    p.Nombre,
                    p.Precio,
                    p.Stock
                })
                .ToList();
            dataGridView1.DataSource = lista;
        }
    }
}
