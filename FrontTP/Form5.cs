using ClasesTP.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClasesTP.Models;
using ClasesTP.Repositories;

namespace FrontTP
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            var productos = ProductoRepository.ObtenerProductos();
            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idSeleccionado = (int)comboBox1.SelectedValue;
            var producto = ProductoRepository.ObtenerProductoPorId(idSeleccionado);

            if (producto != null)
            {
                textBox1.Text = producto.Nombre;
                textBox2.Text = producto.Precio.ToString();
                textBox3.Text = producto.Stock.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idSeleccionado = (int)comboBox1.SelectedValue;
            var producto = ProductoRepository.ObtenerProductoPorId(idSeleccionado);

            producto.Nombre = textBox1.Text;
            producto.Precio = double.Parse(textBox2.Text);
            producto.Stock = int.Parse(textBox3.Text);

            ProductoRepository.ActualizarProducto(producto);
            MessageBox.Show("Producto actualizado correctamente");
        }
    }
}
