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

        public DataTable ObtenerFacturas()
        {
            DataTable tabla = new DataTable();

            try
            {
                Abrir();
                string consulta = @"
                SELECT 
                    DF.ID, 
                    DF.FacturaID, 
                    DF.ServicioID, 
                    DF.PrecioUnitario, 
                    DF.Descuento, 
                    DF.Estado, 
                    DF.UsuarioID
                FROM DetalleFactura DF";

                SqlCommand cmd = new SqlCommand(consulta, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter(cmd);
                adaptador.Fill(tabla);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener los datos: " + ex.Message);
            }
            finally
            {
                Cerrar();
            }

            return tabla;
        }   
            
    }
}

