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
    public partial class Servicios : Form
    {
        ClsServiciosConexion obj = new ClsServiciosConexion();
        int idActual = 0;

        public Servicios()
        {
            InitializeComponent();
            obj.CargarDatos(grdServicios);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "")
            {
                decimal precio;
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    obj.InsertServicio(grdServicios, txtNombre.Text, precio);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido.");
                }
            }
            else
            {
                MessageBox.Show("Complete todos los campos.");
            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" && txtPrecio.Text != "" && idActual != 0)
            {
                decimal precio;
                if (decimal.TryParse(txtPrecio.Text, out precio))
                {
                    obj.UpdateServicio(grdServicios, txtNombre.Text, precio, idActual);
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese un precio válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un servicio de la lista para modificar.");
            }
        }

        private void cmdAnular_Click(object sender, EventArgs e)
        {
            if (idActual != 0)
            {
                obj.DeleteServicio(grdServicios, idActual);
                Limpiar();
            }
            else
            {
                MessageBox.Show("Seleccione un servicio de la lista para anular.");
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                idActual = Convert.ToInt32(grdServicios.Rows[e.RowIndex].Cells["ID"].Value);
                txtNombre.Text = grdServicios.Rows[e.RowIndex].Cells["NOMBRESERVICIO"].Value.ToString();
                txtPrecio.Text = grdServicios.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString();
            }
        }

        private void Limpiar()
        {
            txtNombre.Clear();
            txtPrecio.Clear();
            idActual = 0;
        }
    }
}
