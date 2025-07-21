using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }

        private void btnServicios_Click(object sender, EventArgs e)
        {
            Servicios ser = new Servicios();
            ser.ShowDialog();
        }

        private void btnMascotas_Click(object sender, EventArgs e)
        {
            Mascotas mascotas = new Mascotas();
            mascotas.ShowDialog();
        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            Facturas_Listados form = new Facturas_Listados();
            form.ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
