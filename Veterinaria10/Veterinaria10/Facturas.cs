using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Veterinaria2
{
    public partial class Facturas : Form
    {
        clsFacturasConexion clsConexion = new clsFacturasConexion();
        clsValidaciones clsValidaciones = new clsValidaciones();
        DataTable dt = new DataTable();

        public Facturas()
        {
            InitializeComponent();
        }

        private void mtdTotal()
        {
            Decimal vrCantidad = Convert.ToDecimal(txtCantidad.Text);
            Decimal vrPrecio = Convert.ToDecimal(txtPrecio.Text);
            Decimal vrDescuento = Convert.ToDecimal(txtDescuento.Text);

            txtTotal.Text = ((vrPrecio - vrDescuento) * vrCantidad).ToString();
        }

        private void mtdLimpiar()
        {
            cbxClienteCF.SelectedIndex = -1;
            cboMascotas.SelectedIndex = -1;
            cbxVeterinarioCF.SelectedIndex = -1;

            dt.Rows.Clear();
        }

        private void mtdLimpiarDetalle()
        {
            cboServicios.SelectedIndex = -1;
            txtCantidad.Text = "0";
            txtPrecio.Text = "0.00";
            txtDescuento.Text = "0.00";
            txtTotal.Text = "0.00";
            cboServicios.Focus();
        }

        private void mtd_grid()
        {
            // Add columns
            dt.Columns.Add("ID", typeof(int));
            dt.Columns.Add("IDSERVICIO", typeof(int));
            dt.Columns.Add("Nombre", typeof(string));
            dt.Columns.Add("Cantidad", typeof(decimal));
            dt.Columns.Add("Precio", typeof(decimal));
            dt.Columns.Add("Descuento", typeof(decimal));
            dt.Columns.Add("Total", typeof(decimal));

            grdDetalle.DataSource = dt;
            grdDetalle.Columns[1].Visible = false;
        }

        private void mtdInsertUpdate(int vrAccion)
        {
            if (cbxClienteCF.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un cliente de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxClienteCF.Focus();
            }
            else if (cboMascotas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione una mascota de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboMascotas.Focus();
            }
            else if (cbxVeterinarioCF.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor seleccione un veterinario(a) de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbxVeterinarioCF.Focus();
            }
            else if (grdDetalle.Rows.Count == 0)
            {
                MessageBox.Show("Por favor ingrese ingrese el detalle de servicios a la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboServicios.Focus();
            }
            //else if (vrIdItemSeleccionado == 0 && vrAccion == 2)
            //{
            //    MessageBox.Show("Para realizar una modificación, primero debe seleccionar un ítem de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            else
            {
                DialogResult vrRespuesta = MessageBox.Show("Está seguro que los datos son correctos?", "Veterinaria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vrRespuesta == DialogResult.Yes)
                {
                    int vrIdCliente = Convert.ToInt32(cbxClienteCF.SelectedValue);
                    int vrIdMascota = Convert.ToInt32(cboMascotas.SelectedValue);
                    int vrIdVeterinario = Convert.ToInt32(cbxVeterinarioCF.SelectedValue);
                    int vrId = 0;
                    //DateTime vrFechaInicio1 = dtpFechaInicioCF.Value.Date;
                    string vrFechaInicio = dtpFechaInicioCF.Value.Date.ToString("yyyy-MM-dd");
                    string vrFechaEstimada = dtpFechaEstimadaCF.Value.Date.ToString("yyyy-MM-dd");
                    string vrFechaReal = dtpFechaEntregaCF.Value.Date.ToString("yyyy-MM-dd");

                    if (vrAccion == 1)
                        clsConexion.Insert(vrIdCliente, vrIdMascota, vrIdVeterinario, vrFechaInicio, vrFechaEstimada, vrFechaReal, out vrId);
                    else
                        clsConexion.Update(0, vrIdCliente, vrIdMascota, vrIdVeterinario, vrFechaInicio, vrFechaEstimada, vrFechaReal);

                    foreach (DataRow row in dt.Rows)
                    {
                        string nombre = row["Nombre"].ToString();
                        int cantidad = Convert.ToInt32(row["Cantidad"]);
                        decimal precio = Convert.ToDecimal(row["Precio"]);
                        decimal descuento = Convert.ToDecimal(row["Descuento"]);
                        decimal total = Convert.ToDecimal(row["Total"]);
                        int vrIdServicio = Convert.ToInt32(row["IdServicio"]);

                        clsConexion.InsertDetalle(vrId, vrIdServicio, precio, descuento, cantidad);
                    }


                    mtdLimpiar();
                }
            }
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            clsConexion.CargarClientes(cbxClienteCF);
            cbxClienteCF.SelectedIndex = -1;
            clsConexion.CargarVeterinarios(cbxVeterinarioCF);
            cbxVeterinarioCF.SelectedIndex = -1;
            clsConexion.CargarServicios(cboServicios);
            cboServicios.SelectedIndex = -1;
            mtd_grid();
            dtpFechaEntregaCF.MinDate = DateTime.Today;
            dtpFechaEstimadaCF.MinDate = DateTime.Today;
            dtpFechaInicioCF.MinDate = DateTime.Today;
        }

        private void bttSalirCF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxClienteCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int vrIdEspecie = Convert.ToInt32(cbxClienteCF.SelectedValue);

                clsConexion.CargarMascotas_x_cliente(cboMascotas, vrIdEspecie);
            }
            catch (Exception ex)
            {
            }
        }

        private void cbxClienteCF_Click(object sender, EventArgs e)
        {
        }

        private void cbxClienteCF_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vrIdEspecie = Convert.ToInt32(cbxClienteCF.SelectedValue);
            MessageBox.Show(vrIdEspecie.ToString());
        }

        private void dgvServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cboServicios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboServicios.SelectedIndex != -1)
                {
                    if (cboServicios.SelectedItem is DataRowView row)
                    {
                        decimal precio = Convert.ToDecimal(row["PRECIO"]);
                        txtPrecio.Text = precio.ToString("N2");

                        mtdTotal();
                    }
                }
                else
                    txtPrecio.Text = "0.00";

            }
            catch (Exception ex)
            {
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            mtdTotal();
        }

        private void bttAgregarDF_Click(object sender, EventArgs e)
        {
            try
            {
                int vrId = dt.Rows.Count + 1;

                // Input parsing: make sure the TextBoxes contain valid decimal values
                decimal vrCantidad = Convert.ToDecimal(txtCantidad.Text);
                decimal vrPrecio = Convert.ToDecimal(txtPrecio.Text);
                decimal vrDescuento = Convert.ToDecimal(txtDescuento.Text);
                int vrIdServicio = Convert.ToInt32(cboServicios.SelectedValue);

                // Compute total
                decimal vrTotal = (vrPrecio - vrDescuento) * vrCantidad;
                txtTotal.Text = vrTotal.ToString("F2"); // Format as 2 decimals

                // 👇 Issue: you're using SelectedText instead of SelectedItem or SelectedValue
                string nombreServicio = cboServicios.Text; // or cboServicios.SelectedItem?.ToString()

                // ✅ Add row with correct column order
                dt.Rows.Add(vrId, vrIdServicio, nombreServicio, vrCantidad, vrPrecio, vrDescuento, vrTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            mtdLimpiarDetalle();
        }

        private void grdDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = grdDetalle.CurrentRow.Index;
            DataTable dt = (DataTable)grdDetalle.DataSource;
            dt.Rows.RemoveAt(rowIndex);
        }

        private void bttGuardarCF_Click(object sender, EventArgs e)
        {
            mtdInsertUpdate(1);
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {
            mtdTotal();
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloEnteros(e);
        }

        private void txtDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidaciones.SoloReales(e);
        }
    }
}
