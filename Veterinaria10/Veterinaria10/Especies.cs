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
    public partial class Especies : Form
    {
        clsEspeciesConexion clsEspeciesConexion = new clsEspeciesConexion();
        clsValidaciones clsValidaciones = new clsValidaciones();
        int especieIDSeleccionada = 0;
        int vrIdItemSeleccionado = 0;
        int RowIndex = 0;

        private void mtdLimpiar()
        {
            txtNombreEspecies.Text = string.Empty;
            RowIndex = 0;
            vrIdItemSeleccionado = 0;
        }


        public Especies()
        {
            InitializeComponent();
        }

        private void bttSalirEspecies_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Especies_Load(object sender, EventArgs e)
        {
            clsEspeciesConexion.CargarDatos(grdListaEspecies);
            grdListaEspecies.ClearSelection();
        }

        private void Limpiar()
        {
            txtNombreEspecies.Text = "";
            especieIDSeleccionada = 0;
            grdListaEspecies.ClearSelection();
        }

        private void bttGuardarEspecies_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreEspecies.Text))
            {
                MessageBox.Show("Ingrese un nombre valido para la especie.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsEspeciesConexion.InsertEspecie(grdListaEspecies, txtNombreEspecies.Text.Trim());
            Limpiar();

        }

        private void bttModificarEspecies_Click(object sender, EventArgs e)
        {
            if (especieIDSeleccionada == 0)
            {
                MessageBox.Show("Seleccione una especie para modificar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            clsEspeciesConexion.UpdateEspecie(grdListaEspecies, txtNombreEspecies.Text.Trim(), especieIDSeleccionada);
            Limpiar();
        }

        private void dgvListaEspecies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && grdListaEspecies.Rows[e.RowIndex].Cells["ID"].Value != null)
            {
                especieIDSeleccionada = Convert.ToInt32(grdListaEspecies.Rows[e.RowIndex].Cells["ID"].Value);
                txtNombreEspecies.Text = grdListaEspecies.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
            }
        }

        private void bttAnularEspecies_Click(object sender, EventArgs e)
        {
            if (vrIdItemSeleccionado == 0)
            {
                MessageBox.Show("Por favor seleccione un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult vrRespuesta = MessageBox.Show("Esta seguro que los datos son correctos?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vrRespuesta == DialogResult.Yes)
            {
                clsEspeciesConexion.DeleteEspecie(grdListaEspecies, vrIdItemSeleccionado);
                mtdLimpiar(); 
            }
        }
    }
}


 