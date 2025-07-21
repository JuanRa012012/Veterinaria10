using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    internal class clsEspeciesConexion
    {
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM ESPECIE WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar especies: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

      
        public void BuscarEspecie(DataGridView dgv, string nombreBuscar)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM ESPECIE WHERE NOMBRE LIKE @nombre AND ESTADO = 1", clsConexion.sc);
                da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombreBuscar + "%");
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar especie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        public void InsertEspecie(DataGridView dgv, string nombre)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO ESPECIE (NOMBRE, ESTADO) VALUES (@nombre, 1)", clsConexion.sc);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La especie ha sido agregada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar especie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        public void UpdateEspecie(DataGridView dgv, string nombre, int id)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE ESPECIE SET NOMBRE = @nombre WHERE ID = @id", clsConexion.sc);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La especie ha sido modificada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar especie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void DeleteEspecie(DataGridView dgv, int id)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("DELETE ESPECIE SET ESTADO = 2 WHERE ID = @id", clsConexion.sc);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("La especie ha sido anulada correctamente.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarDatos(dgv);
                clsConexion.Cerrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al anular especie: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}