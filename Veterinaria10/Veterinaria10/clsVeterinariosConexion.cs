using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    internal class clsVeterinariosConexion
    {
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT A.ID, A.NOMBRE, A.TELEFONO, A.CORREO, A.DIRECCION FROM VETERINARIO A WHERE A.ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Buscar(DataGridView dgv, String vrBuscar)
        {
            try
            {
                da = new SqlDataAdapter("SELECT A.ID, A.NOMBRE, A.TELEFONO, A.CORREO, A.DIRECCION FROM VETERINARIO A WHERE (A.NOMBRE LIKE '%" + vrBuscar + "%' OR A.TELEFONO LIKE '%" + vrBuscar + "%' OR A.CORREO LIKE '%" + vrBuscar + "%') AND A.ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert(DataGridView dgv, String vrNombre, String vrTelefono, String vrCorreo, String vrDireccion)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO VETERINARIO VALUES ('" + vrNombre + "','" + vrTelefono + "','" + vrCorreo + "','" + vrDireccion + "', 1, 1);", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El nuevo ítem ha sido agregado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Update(DataGridView dgv, String vrNombre, String vrTelefono, String vrCorreo, String vrDireccion, int vrID)
        {
            try
            {
                clsConexion.Abrir();
            
                cmd = new SqlCommand("UPDATE VETERINARIO " +
                    "SET " +
                    "NOMBRE = '" + vrNombre + "', " +
                    "TELEFONO = '" + vrTelefono + "', " +
                    "CORREO = '" + vrCorreo + "', " +
                    "DIRECCION = '" + vrDireccion + "' " +
                    "WHERE ID = " + vrID + ";", clsConexion.sc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido modificado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Abrir();
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
                cmd = new SqlCommand("UPDATE VETERINARIO SET ESTADO = 2 WHERE ID = " + vrID + ";", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido anulado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
