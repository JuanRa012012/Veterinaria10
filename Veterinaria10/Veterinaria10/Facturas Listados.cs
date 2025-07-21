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
        clsFacturas_ListadosConexion conexion = new clsFacturas_ListadosConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

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
            try
            {
                //grdListasFacturas.DataSource = conexion.ObtenerFacturas();

                conexion.ObtenerFacturas(grdListasFacturas);
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
            Facturas fact = new Facturas();
            fact.ShowDialog();
            CargarFacturas();
        }

        private void cmdModificarLF_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Funcionalidad para modificar factura seleccionada");
        }

        private void cmdAnular_Click(object sender, EventArgs e)
        {
            DialogResult vrRespuesta = MessageBox.Show("Está seguro que desea anular este ítem?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrRespuesta == DialogResult.Yes)
            {
                if (vrIdItemSeleccionado == 0)
                    MessageBox.Show("Por favor seleccione un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    conexion.Delete(vrIdItemSeleccionado);
                    CargarFacturas();
                }
            }
        }

        private void grdListasFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                vrIdItemSeleccionado = Convert.ToInt32(grdListasFacturas.CurrentRow.Cells[0].Value.ToString());
            }
            catch (Exception ex)
            {
            }
        }
    }
}