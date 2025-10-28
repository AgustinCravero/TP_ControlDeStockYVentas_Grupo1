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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ProveedorRepository.ObtenerProveedores();
            comboBox1.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un proveedor antes de eliminar.");
                return;
            }
            Proveedor proveedor = (Proveedor)comboBox1.SelectedItem;
            ProveedorRepository.EliminarProveedor(proveedor);
            MessageBox.Show("Proveedor eliminado con exito");
            comboBox1.DataSource = null;
            comboBox1.DataSource = ProveedorRepository.ObtenerProveedores();
            comboBox1.DisplayMember = "Nombre";
            comboBox1.SelectedItem = null;
        }
    }
}
