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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = ProductoRepository.ObtenerProductos();
            comboBox1.DisplayMember = "Nombre";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Producto producto = (Producto)comboBox1.SelectedItem;
            ProductoRepository.EliminarProducto(producto);
            MessageBox.Show("Producto eliminado con exito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }
    }
}
