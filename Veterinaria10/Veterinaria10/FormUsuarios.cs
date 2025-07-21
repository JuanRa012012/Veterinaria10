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
    public partial class FormUsuarios : Form
    {
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsUsuariosConexion clsConexion = new clsUsuariosConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

        private void mtdLimpiar()
        {
            txtNombre.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtClave.Text = string.Empty;
            txtConfirmacionClave.Text = string.Empty;
            cboRoles.SelectedIndex = -1;
            RowIndex = 0;
            vrIdItemSeleccionado = 0;
            cmdCancelar.Visible = false;
        }

        private void mtdInsertUpdate(int vrAccion)
        {
            if (txtCodigo.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el código del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Focus();
            }
            else if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un nombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombre.Focus();
            }
            else if (txtClave.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese una clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClave.Focus();
            }
            else if (txtConfirmacionClave.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese la confirmación de la clave", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmacionClave.Focus();
            }
            else if (txtClave.Text != txtConfirmacionClave.Text)
            {
                MessageBox.Show("La clave y su confirmación no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmacionClave.Focus();
            }
            else if (cboRoles.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione el rol del usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboRoles.Focus();
            }
            else if (vrIdItemSeleccionado == 0 && vrAccion == 2)
            {
                MessageBox.Show("Para realizar una modificación, primero debe seleccionar un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult vrRespuesta = MessageBox.Show("Está seguro que los datos son correctos?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrRespuesta == DialogResult.Yes)
                {
                    String vrCodigo = txtCodigo.Text;
                    String vrNombre = txtNombre.Text;
                    String vrClave = txtClave.Text;
                    int vrIdRol = Convert.ToInt32(cboRoles.SelectedValue);

                    if (vrAccion == 1)
                        clsConexion.Insert(grdUsuarios, vrCodigo, vrNombre, vrClave, vrIdRol);
                    else
                        clsConexion.Update(grdUsuarios, vrCodigo, vrNombre, vrClave, vrIdRol, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }

        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            clsConexion.CargarDatos(grdUsuarios);
            clsConexion.CargarRoles(cboRoles);
            grdUsuarios.Columns[0].Visible = false;
            grdUsuarios.Columns[3].Visible = false;
            grdUsuarios.Columns[5].Visible = false;
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    clsConexion.Delete(grdUsuarios, vrIdItemSeleccionado);
                    mtdLimpiar();
                }
            }
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                vrIdItemSeleccionado = Convert.ToInt32(grdUsuarios.CurrentRow.Cells[0].Value.ToString());
                txtCodigo.Text = grdUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtNombre.Text = grdUsuarios.CurrentRow.Cells[2].Value.ToString();
                cboRoles.SelectedValue = Convert.ToInt32(grdUsuarios.CurrentRow.Cells[3].Value.ToString());
                txtClave.Text = grdUsuarios.CurrentRow.Cells[5].Value.ToString();
                txtConfirmacionClave.Text = grdUsuarios.CurrentRow.Cells[5].Value.ToString();
                cmdCancelar.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }
    }
}
