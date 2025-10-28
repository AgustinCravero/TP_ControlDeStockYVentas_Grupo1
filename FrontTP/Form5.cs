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
using System.Runtime.InteropServices;

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
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged_1;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Ingrese un precio.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese un stock.");
                return;
            }
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un producto para modificarlo.");
                return;
            }
            int idSeleccionado = Convert.ToInt32(comboBox1.SelectedValue);
            var producto = ProductoRepository.ObtenerProductoPorId(idSeleccionado);

            producto.Nombre = textBox1.Text;
            producto.Precio = double.Parse(textBox2.Text);
            producto.Stock = int.Parse(textBox3.Text);

            ProductoRepository.ActualizarProducto(producto);
            MessageBox.Show("Producto actualizado correctamente");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
                return;

            int idSeleccionado;
            if (int.TryParse(comboBox1.SelectedValue.ToString(), out idSeleccionado))
            {
                var producto = ProductoRepository.ObtenerProductoPorId(idSeleccionado);

                if (producto != null)
                {
                    textBox1.Text = producto.Nombre;
                    textBox2.Text = producto.Precio.ToString("0.00");
                    textBox3.Text = producto.Stock.ToString();
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
            if (e.KeyChar == ',' && ((TextBox)sender).Text.Contains(","))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
