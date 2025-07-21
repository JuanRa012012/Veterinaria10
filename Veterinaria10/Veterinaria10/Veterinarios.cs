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
    public partial class Veterinarios : Form
    {
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsVeterinariosConexion clsConexion = new clsVeterinariosConexion();
        int RowIndex = 0;
        int vrIdItemSeleccionado = 0;

        private void mtdLimpiar()
        {
            txtNombre.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtDireccion.Text = string.Empty;
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
            else if (txtTelefono.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un teléfono", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
            }
            else if (txtCorreo.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese un correo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCorreo.Focus();
            }
            else if (txtDireccion.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese una dirección", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDireccion.Focus();
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
                    String vrNombre = txtNombre.Text;
                    String vrTelefono = txtTelefono.Text;
                    String vrCorreo = txtCorreo.Text;
                    String vrDireccion = txtDireccion.Text;

                    if (vrAccion == 1)
                        clsConexion.Insert(grdVeterinarios, vrNombre, vrTelefono, vrCorreo, vrDireccion);
                    else
                        clsConexion.Update(grdVeterinarios, vrNombre, vrTelefono, vrCorreo, vrDireccion, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }

        public Veterinarios()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Veterinarios_Load(object sender, EventArgs e)
        {
            clsConexion.CargarDatos(grdVeterinarios);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String vrTexto = textBox1.Text;

            clsConexion.Buscar(grdVeterinarios, vrTexto);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloEnteros(e);
        }

        private void txtCorreo_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloLetras(e);
        }

        private void cmdGuardar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(1);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(2);
        }

        private void grdVeterinarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                vrIdItemSeleccionado = Convert.ToInt32(grdVeterinarios.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = grdVeterinarios.CurrentRow.Cells[1].Value.ToString();
                txtTelefono.Text = grdVeterinarios.CurrentRow.Cells[2].Value.ToString();
                txtCorreo.Text = grdVeterinarios.CurrentRow.Cells[3].Value.ToString();
                txtDireccion.Text = grdVeterinarios.CurrentRow.Cells[4].Value.ToString();
                cmdCancelar.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void grdVeterinarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                    clsConexion.Delete(grdVeterinarios, vrIdItemSeleccionado);
                    mtdLimpiar();
                }
            }
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }
    }
}
