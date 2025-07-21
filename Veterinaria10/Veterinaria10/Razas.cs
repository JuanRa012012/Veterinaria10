using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class Razas : Form
    {
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsRazasConexion clsRazasConexion = new clsRazasConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

        private void mtdLimpiar()
        {
            txtNombre.Text = string.Empty;
            cboEspecie.SelectedIndex = -1;
            RowIndex = 0;
            vrIdItemSeleccionado = 0;
            cmdCancelar.Visible = false;
        }

        private void mtdInsertUpdate(int vrAccion)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (cboEspecie.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una especie de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEspecie.Focus();
            }
            else if (vrIdItemSeleccionado == 0 && vrAccion == 2)
            {
                MessageBox.Show("Para realizar una modificación, primero debe seleccionar un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboEspecie.Focus();
            }
            else
            {
                DialogResult vrRespuesta = MessageBox.Show("Está seguro que los datos son correctos?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrRespuesta == DialogResult.Yes)
                {
                    String vrNombre = txtNombre.Text;
                    int vrIdEspecie = Convert.ToInt32(cboEspecie.SelectedValue);

                    if (vrAccion == 1)
                        clsRazasConexion.InsertRaza(grdRazas, vrNombre, vrIdEspecie);
                    else
                        clsRazasConexion.UpdateRaza(grdRazas, vrNombre, vrIdEspecie, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }

        public Razas()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Razas_Load(object sender, EventArgs e)
        {
            clsRazasConexion.CargarDatos(grdRazas);
            clsRazasConexion.CargarEspecies(cboEspecie);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String vrTexto = textBox1.Text;

            clsRazasConexion.BuscarRaza(grdRazas, vrTexto);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(1);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void grdRazas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdRazas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                vrIdItemSeleccionado = Convert.ToInt32(grdRazas.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = grdRazas.CurrentRow.Cells[1].Value.ToString();
                cboEspecie.SelectedValue = Convert.ToInt32(grdRazas.CurrentRow.Cells[2].Value.ToString());
                cmdCancelar.Visible = true;
            }
            catch (Exception ex)
            {
            }

        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(2);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
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
                    clsRazasConexion.DeleteRaza(grdRazas, vrIdItemSeleccionado);
                    mtdLimpiar();
                }
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }
    }
}
