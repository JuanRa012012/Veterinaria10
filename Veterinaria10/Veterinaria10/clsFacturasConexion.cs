using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria2;

namespace Veterinaria2
{
    internal class clsFacturasConexion
    {
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT A.ID, A.NOMBRERAZA, B.ID ID_ESPECIE, B.NOMBRE NOMBRE_ESPECIE FROM RAZA A, ESPECIE B WHERE A.ESPECIEID = B.ID AND A.ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarClientes(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM CLIENTE WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarMascotas_x_cliente(ComboBox cbo, int vrIdCliente)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM MASCOTA WHERE CLIENTEID = " + vrIdCliente + " AND ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarVeterinarios(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM VETERINARIO WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarServicios(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE, PRECIO FROM SERVICIO WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert(int vrIdCliente, int vrIdMascota, int vrIdVeterinario, String vrFechaInicio, String vrFechaEstimada, String vrFechaReal, out int vrId)
        {
            vrId = -1;
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO FACTURA OUTPUT INSERTED.ID VALUES (" + vrIdCliente + "," + vrIdMascota + "," + vrIdVeterinario + ",'" + vrFechaInicio + "','" + vrFechaEstimada + "','" + vrFechaReal + "', GETDATE(), 1, 1);", clsConexion.sc);
                vrId = Convert.ToInt32(cmd.ExecuteScalar());

                MessageBox.Show("la factura ha sido guardada correctamente " + vrId.ToString(), "Veterinaria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertDetalle(int vrIdFactura, int vrIdServicio, decimal vrPrecio, decimal vrDescuento, int vrCantidad)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO DETALLEFACTURA (FACTURAID, SERVICIOID, PRECIOUNITARIO, DESCUENTO, CANTIDAD, ESTADO, USUARIOID) VALUES (" +
                                    vrIdFactura + "," + vrIdServicio + "," + vrPrecio + "," + vrDescuento + "," + vrCantidad + ", 1, 1);", clsConexion.sc);
                cmd.ExecuteNonQuery();
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(int vrId, int vrIdCliente, int vrIdMascota, int vrIdVeterinario, String vrFechaInicio, String vrFechaEstimada, String vrFechaReal)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE RAZA SET NOMBRERAZA = '" + vrIdCliente + "', ESPECIEID = " + vrIdVeterinario + " WHERE ID = " + vrIdVeterinario + ";", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido modificado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(DataGridView dgv, int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE RAZA SET ESTADO = 2 WHERE ID = " + vrID + ";", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido anulado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
