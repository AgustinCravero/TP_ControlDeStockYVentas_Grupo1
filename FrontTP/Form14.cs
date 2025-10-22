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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void Form14_Load(object sender, EventArgs e)
        {
            var proveedores = ProveedorRepository.ObtenerProveedores();

            comboBox1.DataSource = proveedores;
            comboBox1.DisplayMember = "Nombre";
            comboBox1.ValueMember = "Id";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue == null || comboBox1.SelectedValue is DataRowView)
                return;

            int idSeleccionado;
            if (int.TryParse(comboBox1.SelectedValue.ToString(), out idSeleccionado))
            {
                var proveedor = ProveedorRepository.ObtenerProveedorPorId(idSeleccionado);

                if (proveedor != null)
                {
                    textBox1.Text = proveedor.Nombre;
                    textBox2.Text = proveedor.Telefono;
                    textBox3.Text = proveedor.Email;
                    textBox4.Text = proveedor.Direccion;
                }
            }
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
                MessageBox.Show("Ingrese un teléfono.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese un email.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Ingrese una dirección.");
                return;
            }
            int idSeleccionado = Convert.ToInt32(comboBox1.SelectedValue);
            var proveedor = ProveedorRepository.ObtenerProveedorPorId(idSeleccionado);

            proveedor.Nombre = textBox1.Text;
            proveedor.Telefono = textBox2.Text;
            proveedor.Email = textBox3.Text;
            proveedor.Direccion = textBox4.Text;

            ProveedorRepository.ActualizarProveedor(proveedor);
            MessageBox.Show("Proveedor actualizado correctamente");
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }
    }
}
