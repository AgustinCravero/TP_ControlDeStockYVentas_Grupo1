using ClasesTP.Models;
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

namespace FrontTP
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        private List<DetalleVenta> listaDetalles = new List<DetalleVenta>();
        private double montoTotal = 0;

        private void Form8_Load(object sender, EventArgs e)
        {
            var productos = ProductoRepository.ObtenerProductos();

            comboBox1.DataSource = productos;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
            label4.Text = "Monto Total: $0.00";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Ingrese una cantidad.");
                return;
            }
            int cantidad = int.Parse(textBox1.Text);
            int idSeleccionado = Convert.ToInt32(comboBox1.SelectedValue);
            var producto = ProductoRepository.ObtenerProductoPorId(idSeleccionado);
            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a cero.");
                return;
            }

            if (cantidad > producto.Stock)
            {
                MessageBox.Show("Stock insuficiente.");
                return;
            }
            var detalle = new DetalleVenta(producto.Id, cantidad, producto.Precio);
            detalle.Producto = producto;
            listaDetalles.Add(detalle);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaDetalles
                .Select(d => new
                {
                    Producto = d.Producto.Nombre,
                    d.Cantidad,
                    Precio = d.PrecioUnitario,
                    d.Subtotal
                })
                .ToList();
            montoTotal = listaDetalles.Sum(d => d.Subtotal);
            label4.Text = $"Monto Total: ${montoTotal:F2}";
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaDetalles.Count == 0)
            {
                MessageBox.Show("Agregue al menos un producto.");
                return;
            }
            var venta = new Venta(dateTimePicker1.Value, listaDetalles)
            {
                MontoTotal = montoTotal
            };

            VentaRepository.GuardarVenta(venta);
            MessageBox.Show("Venta guardada correctamente.");
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
