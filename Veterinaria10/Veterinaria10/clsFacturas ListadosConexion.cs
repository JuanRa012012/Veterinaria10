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
    public class clsFacturas_ListadosConexion : clsConexion
    {
        private SqlConnection conexion = new SqlConnection();
        clsConexion clsConexion = new clsConexion();
        SqlDataAdapter da;
        DataTable dt;
        SqlCommand cmd;

        public void CargarDatos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT ID, DESCRIPCION FROM DETALLEFACTURAS WHERE ESTADO = 1", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ObtenerFacturas(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT A.ID NUMERO_FACTURA, A.FECHAFACTURA, D.NOMBRE NOMBRE_CLIENTE, E.NOMBRE VETERINARIO, F.NOMBRE MASCOTA, SUM(PRECIOUNITARIO * CANTIDAD) SUB_TOTAL, SUM(DESCUENTO * CANTIDAD) DESCUENTO,  SUM((PRECIOUNITARIO-DESCUENTO) * CANTIDAD) TOTAl FROM FACTURA A, DETALLEFACTURA B, SERVICIO C, CLIENTE D, VETERINARIO E, MASCOTA F WHERE A.ID = B.FACTURAID AND B.SERVICIOID = C.ID AND A.CLIENTEID = D.ID AND A.VETERINARIOID = E.ID AND A.MASCOTAID = F.ID AND A.ESTADO = 1 GROUP BY A.ID, A.FECHAFACTURA, D.NOMBRE, E.NOMBRE, F.NOMBRE", clsConexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Delete(int vrID)
        {
            try
            {
                clsConexion.Abrir();
                cmd = new SqlCommand("UPDATE FACTURA SET ESTADO = 2 WHERE ID = " + vrID + ";", clsConexion.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("El ítem ha sido anulado correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clsConexion.Abrir();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex, "State", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

