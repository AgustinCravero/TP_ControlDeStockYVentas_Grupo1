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
        }
    }
}
