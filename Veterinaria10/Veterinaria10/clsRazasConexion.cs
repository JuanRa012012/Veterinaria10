using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
 
namespace Veterinaria2
{
    internal class clsRazasConexion
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

        public void CargarEspecies(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, NOMBRE FROM ESPECIE WHERE ESTADO = 1", clsConexion.sc);
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

        public void BuscarRaza(DataGridView dgv, String vrBuscar)
        {
            try
            {
                da = new SqlDataAdapter("SELECT A.ID, A.NOMBRERAZA, B.ID ID_ESPECIE, B.NOMBRE NOMBRE_ESPECIE FROM RAZA A, ESPECIE B WHERE A.ESPECIEID = B.ID AND A.NOMBRERAZA LIKE '%" + vrBuscar + "%' AND A.ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void InsertRaza(DataGridView dgv, String vrNombre, int vrIdEspecie)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO RAZA VALUES ('" + vrNombre + "'," + vrIdEspecie + ", 1, 1);", clsConexion.sc);
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

        public void UpdateRaza(DataGridView dgv, String vrNombre, int vrIdEspecie, int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE RAZA SET NOMBRERAZA = '" + vrNombre + "', ESPECIEID = " + vrIdEspecie + " WHERE ID = " + vrID + ";", clsConexion.sc);
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

        public void DeleteRaza(DataGridView dgv, int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE RAZA SET ESTADO = 2 WHERE ID = " + vrID + ";", clsConexion.sc);
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
