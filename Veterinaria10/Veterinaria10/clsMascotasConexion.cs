using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Veterinaria10;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Veterinaria2
{
    internal class clsMascotasConexion
    {
        clsConexion conexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {


                string query = @"SELECT M.ID, M.NOMBRE, M.FECHANACIMIENTO,
                                 C.ID AS CLIENTEID, C.NOMBRE AS NOMBRECLIENTE,
                                 E.ID AS ESPECIEID, E.NOMBRE AS NOMBREESPECIE,
                                 R.ID AS RAZAID, R.NOMBRERAZA AS NOMBRERAZA
                                 FROM MASCOTA M
                                 INNER JOIN CLIENTE C ON M.CLIENTEID = C.ID
                                 INNER JOIN ESPECIE E ON M.ESPECIEID = E.ID
                                 INNER JOIN RAZA R ON M.RAZAID = R.ID
                                 WHERE M.ESTADO = 1";
                da = new SqlDataAdapter(query, conexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarClientes(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM CLIENTE WHERE ESTADO = 1", conexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message);
            }
        }

        public void CargarEspecies(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM ESPECIE WHERE ESTADO = 1", conexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRE";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especies: " + ex.Message);
            }
        }

        public void CargarRazas(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRERAZA FROM RAZA WHERE ESTADO = 1", conexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "NOMBRERAZA";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar razas: " + ex.Message);
            }
        }

        public void InsertMascota(DataGridView dgv, string nombre, string fecha, int clienteID, int especieID, int razaID)
        {
            try
            {
                conexion.Abrir();
                cmd = new SqlCommand("INSERT INTO MASCOTA " +
                                    " (" +
                                    " NOMBRE, FECHANACIMIENTO, CLIENTEID, ESPECIEID, RAZAID, ESTADO, USUARIOID " +
                                    " )" +
                                    " VALUES " +
                                    " ( " +
                                    " '" + nombre + "','" + fecha + "','" + clienteID + "','" + especieID + "','" + razaID + "', 1, 1" +
                                    " );", conexion.sc);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Mascota guardada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                conexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar mascota: " + ex.Message);
            }
        }

        public void UpdateMascota(DataGridView dgv, string nombre, string fecha, int clienteID, int especieID, int razaID, int id)
        {
            try
            {
                conexion.Abrir();
         
                cmd = new SqlCommand("UPDATE MASCOTA " +
                    "SET " +
                    "NOMBRE = '" + nombre + "', " +
                    "FECHANACIMIENTO = '" + fecha + "', " +
                    "CLIENTEID = '" + clienteID + "', " +
                    "ESPECIEID = '" + especieID + "', " +
                    "RAZAID = '" + razaID + "' " +
                    "WHERE ID = " + id + ";", conexion.sc);
    
                cmd.ExecuteNonQuery();
                MessageBox.Show("Mascota modificada correctamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                conexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar mascota: " + ex.Message);
            }
        }

        public void DeleteMascota(DataGridView dgv, int id)
        {
            try
            {
                conexion.Abrir();
                cmd = new SqlCommand("UPDATE MASCOTA SET ESTADO = 2 WHERE ID = " + id + ";", conexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido anulado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                conexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
