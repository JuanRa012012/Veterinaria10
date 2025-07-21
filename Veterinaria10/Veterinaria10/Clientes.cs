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
    public partial class Clientes : Form
    {
        clsValidaciones clsValidaciones = new clsValidaciones();
        clsClientesConexion clsConexion = new clsClientesConexion();
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
            else if (txtEdad.Text.Length == 0)
            {
                MessageBox.Show("Por favor seleccione una fecha de nacimiento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpFechaNacimiento.Focus();
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
                    DateTime vrFecha1 = dtpFechaNacimiento.Value.Date;
                    string vrFecha = dtpFechaNacimiento.Value.Date.ToString("yyyy-MM-dd");

                    if (vrAccion == 1)
                        clsConexion.Insert(grdClientes, vrNombre, vrFecha, vrTelefono, vrCorreo, vrDireccion);
                    else
                        clsConexion.Update(grdClientes, vrNombre, vrFecha, vrTelefono, vrCorreo, vrDireccion, vrIdItemSeleccionado);

                    mtdLimpiar();
                }
            }
        }

        public Clientes()
        {
            InitializeComponent();
        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {
            txtEdad.Text = (DateTime.Today.AddTicks(-dtpFechaNacimiento.Value.Ticks).Year - 1).ToString();
        }

        private void bttGuardarClientes_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(1);
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            mtdLimpiar();
        }

        private void Clientes_Load(object sender, EventArgs e)
        {
            clsConexion.CargarDatos(grdClientes);
        }

        private void bttSalirClientes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttModificarClientes_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(2);
        }

        private void bttAnularClientes_Click(object sender, EventArgs e)
        {
            DialogResult vrRespuesta = MessageBox.Show("Está seguro que desea anular este ítem?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrRespuesta == DialogResult.Yes)
            {
                if (vrIdItemSeleccionado == 0)
                    MessageBox.Show("Por favor seleccione un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    clsConexion.Delete(grdClientes, vrIdItemSeleccionado);
                    mtdLimpiar();
                }
            }
        }

        private void grdClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                RowIndex = e.RowIndex;

                var fecha = grdClientes.CurrentRow.Cells[2].Value;

                vrIdItemSeleccionado = Convert.ToInt32(grdClientes.CurrentRow.Cells[0].Value.ToString());
                txtNombre.Text = grdClientes.CurrentRow.Cells[1].Value.ToString();
                dtpFechaNacimiento.Value = Convert.ToDateTime(fecha);
                txtTelefono.Text = grdClientes.CurrentRow.Cells[4].Value.ToString();
                txtCorreo.Text = grdClientes.CurrentRow.Cells[5].Value.ToString();
                txtDireccion.Text = grdClientes.CurrentRow.Cells[6].Value.ToString();
                
                cmdCancelar.Visible = true;
            }
            catch (Exception ex)
            {
            }
        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {
            clsConexion.CargarDatos(grdClientes);
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
