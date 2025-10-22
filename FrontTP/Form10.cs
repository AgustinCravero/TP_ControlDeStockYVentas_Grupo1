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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FrontTP
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Application.OpenForms["Form1"].Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker1.Value.Date;
            DateTime hasta = dateTimePicker2.Value.Date;
            if (desde > hasta)
            {
                MessageBox.Show("La fecha 'Desde' no puede ser posterior a la fecha 'Hasta'.");
                return;
            }

            var lista = VentaRepository.ObtenerVentasPorRango(desde, hasta)
                .Select(v => new
                {
                    Fecha = v.Fecha.ToShortDateString(),
                    MontoTotal = v.MontoTotal
                })
                .ToList();
            dataGridView1.DataSource = lista;
            if (lista.Count == 0)
            {
                MessageBox.Show("No se registraron ventas en el período seleccionado.");
            }
        }
    }
}
