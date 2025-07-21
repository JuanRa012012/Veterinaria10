using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    internal class clsUsuariosConexion
    {
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter(" SELECT A.ID, A.CODIGO, A.NOMBRE, B.ID ID_ROL, B.DESCRIPCION DESCRIPCION_ROL, A.CLAVE " +
                                        " FROM USUARIOSISTEMA A, USUARIOSROLES B " +
                                        " WHERE A.ROLID = B.ID " +
                                        " AND A.ESTADO = 1", 
                                        clsConexion.sc);

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
                da = new SqlDataAdapter(" SELECT A.ID, A.NOMBRE, B.ID ID_ROL, B.DESCRIPCION DESCRIPCION_ROL " +
                                        " FROM USUARIOSISTEMA A, USUARIOSROLES B " +
                                        " WHERE A.NOMBRE LIKE '%" + vrBuscar + "%' " +
                                        " A.ROLID = B.ID " +
                                        " AND A.ESTADO = 1",
                                        clsConexion.sc);

                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void CargarRoles(ComboBox cbo)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, DESCRIPCION FROM USUARIOSROLES ", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                cbo.DataSource = dt;
                cbo.DisplayMember = "DESCRIPCION";
                cbo.ValueMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Insert(DataGridView dgv, String vrCodigo, String vrNombre, String vrClave, int vrIdRol)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("INSERT INTO USUARIOSISTEMA (CODIGO, NOMBRE, CLAVE, ROLID, ESTADO, USUARIOID) VALUES ('" + vrCodigo + "','" + vrNombre + "','" + vrClave + "','" + vrIdRol + "', 1, 1);", clsConexion.sc);
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

        public void Update(DataGridView dgv, String vrCodigo, String vrNombre, String vrClave, int vrIdRol, int vrID)
        {
            try
            {
                clsConexion.Abrir();

                cmd = new SqlCommand("UPDATE USUARIOSISTEMA " +
                    "SET " +
                    "CODIGO = '" + vrCodigo + "', " +
                    "NOMBRE = '" + vrNombre + "', " +
                    "CLAVE = '" + vrClave + "', " +
                    "ROLID = '" + vrIdRol + "' " +
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
                cmd = new SqlCommand("UPDATE USUARIOSISTEMA SET ESTADO = 2 WHERE ID = " + vrID + ";", clsConexion.sc);
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
