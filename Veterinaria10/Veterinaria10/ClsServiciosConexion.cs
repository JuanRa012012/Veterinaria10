using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria10;

namespace Veterinaria2
{
    internal class ClsServiciosConexion
    {
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE, PRECIO FROM SERVICIO WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BuscarServicio(DataGridView dgv, String vrBuscar)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE, PRECIO FROM SERVICIO WHERE NOMBRESERVICIO LIKE '%" + vrBuscar + "%' AND ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert(DataGridView dgv, String vrNombre, decimal vrPrecio)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO SERVICIO VALUES ('" + vrNombre + "'," + vrPrecio + ", 1, 1)", clsConexion.sc);
                cmd.ExecuteNonQuery();
                CargarDatos(dgv);
                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(DataGridView dgv, string vrNombre, decimal vrPrecio, int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE SERVICIO SET NOMBRE = '" + vrNombre + "', PRECIO = " + vrPrecio + " WHERE ID = " + vrID + ";", clsConexion.sc);
                cmd.Parameters.AddWithValue("@id", vrID);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido modificado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(DataGridView dgv, int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE SERVICIO SET ESTADO = 2 WHERE ID = @id", clsConexion.sc);
                cmd.Parameters.AddWithValue("@id", vrID);
                cmd.ExecuteNonQuery();

                MessageBox.Show("El ítem ha sido anulado correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
