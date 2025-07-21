using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{

    public partial class Facturas_Listados : Form
    {
        
        public Facturas_Listados()
        {
            InitializeComponent();
        }

        private void Facturas_Listados_Load(object sender, EventArgs e)
        {
            CargarFacturas();
        }

        private void CargarFacturas()
        {
            clsFacturas_ListadosConexion conexion = new clsFacturas_ListadosConexion();

            try
            {
                grdListasFacturas.DataSource = conexion.ObtenerFacturas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la información: " + ex.Message);
            }
        }

        private void cmdSalirLF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdNuevaLF_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad para agregar nueva factura");
        }

        private void cmdModificarLF_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Funcionalidad para modificar factura seleccionada");
        }
    }
}