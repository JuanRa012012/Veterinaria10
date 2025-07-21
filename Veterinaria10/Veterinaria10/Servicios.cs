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
        clsValidaciones clsValidaciones = new clsValidaciones();
        ClsServiciosConexion clsConexion = new ClsServiciosConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

        private void mtdLimpiar()
        {
            txtNombre.Text = string.Empty;
            txtPrecio.Text = "0.00";
            txtNombre.Focus();
            RowIndex = 0;
            vrIdItemSeleccionado = 0;
            cmdCancelar.Visible = false;
        }

        public Servicios()
        {
            InitializeComponent();
            clsConexion.CargarDatos(grdServicios);
        }

        private void mtdInsertUpdate(int vrAccion)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre para el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (Convert.ToDecimal(txtPrecio.Text) == 0)
            {
                MessageBox.Show("Por favor escriba el precio para el servicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrecio.Focus();
            }
            else if (vrIdItemSeleccionado == 0 && vrAccion == 2)
            {
                MessageBox.Show("Para realizar una modificación, primero debe seleccionar un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else
            {
                DialogResult vrRespuesta = MessageBox.Show("Está seguro que los datos son correctos?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrRespuesta == DialogResult.Yes)
                {
                    String vrNombre = txtNombre.Text;
                    decimal vrPrecio = Convert.ToDecimal(txtPrecio.Text);

                    if (vrAccion == 1)
                        clsConexion.Insert(grdServicios, vrNombre, vrPrecio);
                    else
                        clsConexion.Update(grdServicios, vrNombre, vrPrecio, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(1);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(2);
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
                    clsConexion.Delete(grdServicios, vrIdItemSeleccionado);
                    mtdLimpiar();
                }
            }
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    idActual = Convert.ToInt32(grdServicios.Rows[e.RowIndex].Cells["ID"].Value);
            //    txtNombre.Text = grdServicios.Rows[e.RowIndex].Cells["NOMBRESERVICIO"].Value.ToString();
            //    txtPrecio.Text = grdServicios.Rows[e.RowIndex].Cells["PRECIO"].Value.ToString();
            //}

            try
            {
                RowIndex = e.RowIndex;

                vrIdItemSeleccionado = Convert.ToInt32(grdServicios.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = grdServicios.CurrentRow.Cells[1].Value.ToString();
                txtPrecio.Text = grdServicios.CurrentRow.Cells[2].Value.ToString();
                cmdCancelar.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloReales(e);
        }
    }
}
