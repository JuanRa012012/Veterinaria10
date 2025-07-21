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
    public partial class Mascotas : Form
    {
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsMascotasConexion clsConexion = new clsMascotasConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

        private void mtdLimpiar()
        {
            txtNombre.Text = string.Empty;
            cboClientes.SelectedIndex = -1;
            cboEspecies.SelectedIndex = -1;
            cboRazas.SelectedIndex = -1;
            RowIndex = 0;
            vrIdItemSeleccionado = 0;

        }
        private void mtdInsertUpdate(int vrAccion)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }

            else if (cboClientes.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboClientes.Focus();
            }
            else if (cboEspecies.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una especie", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEspecies.Focus();
            }
            else if (cboRazas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una raza", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRazas.Focus();
            }
            else if (vrIdItemSeleccionado == 0 && vrAccion == 2)
            {
                MessageBox.Show("Para realizar una modificación, primero debe seleccionar un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult vrRespuesta = MessageBox.Show("¿Está seguro que los datos son correctos?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrRespuesta == DialogResult.Yes)
                {
                    string vrNombre = txtNombre.Text;
                    string vrFecha = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");
                    int vrClienteID = Convert.ToInt32(cboClientes.SelectedValue);
                    int vrEspecieID = Convert.ToInt32(cboEspecies.SelectedValue);
                    int vrRazaID = Convert.ToInt32(cboRazas.SelectedValue);

                    if (vrAccion == 1)
                        clsConexion.InsertMascota(grdMascotas, vrNombre, vrFecha, vrClienteID, vrEspecieID, vrRazaID);
                    else
                        clsConexion.UpdateMascota(grdMascotas, vrNombre, vrFecha, vrClienteID, vrEspecieID, vrRazaID, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }
        public Mascotas()
        {
            InitializeComponent();
        }


        private void grdMascotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                var fecha = grdMascotas.CurrentRow.Cells[2].Value;

                vrIdItemSeleccionado = Convert.ToInt32(grdMascotas.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = grdMascotas.CurrentRow.Cells[1].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(fecha);
                cboClientes.SelectedValue = Convert.ToInt32(grdMascotas.CurrentRow.Cells[3].Value);
                cboEspecies.SelectedValue = Convert.ToInt32(grdMascotas.CurrentRow.Cells[4].Value);
                cboRazas.SelectedValue = Convert.ToInt32(grdMascotas.CurrentRow.Cells[5].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al seleccionar una fila: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }

        private void bttSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Mascotas_Load_1(object sender, EventArgs e)
        {
            clsConexion.CargarDatos(grdMascotas);
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

        }

        private void cmdSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }
    }

}