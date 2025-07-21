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
    public partial class Facturas : Form
    {
        clsFacturasConexion clsConexion = new clsFacturasConexion();
        
        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            clsConexion.CargarClientes(cbxClienteCF);
        }
    }
}
