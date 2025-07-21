using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Veterinaria2
{
    internal class clsLoginV
    {
        clsConexion clsConexion = new clsConexion();

        /// <summary>
        /// Valida un usuario por nombre y contraseña.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contraseña">Contraseña</param>
        /// <param name="rol">Devuelve el rol si es válido</param>
        /// <returns>true si las credenciales son correctas y el usuario está activo</returns>
        public bool ValidarCredenciales(string usuario, string contraseña, out int vrRol)
        {
            vrRol = -1;

            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT ROLID FROM UsuarioSistema WHERE CODIGO = @codUser AND CLAVE = @password", clsConexion.sc))
                {
                    cmd.Parameters.AddWithValue("@codUser", usuario);
                    cmd.Parameters.AddWithValue("@password", contraseña);

                    clsConexion.Abrir(); // Open connection before executing

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        vrRol = Convert.ToInt32(result);
                        //MessageBox.Show("Login exitoso. Rol: " + vrRol, "Acceso permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return true;
                    }
                    else
                    {
                        //MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de conexión: " + ex.Message, "Estado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            //using (SqlConnection conn = new SqlConnection(conexion.cadena))
            //{
            //    conn.Open();
            //    string query = "SELECT Rol FROM UsuarioSistema WHERE Nombre = @Nombre AND Contraseña = @Contraseña AND Estado = 'Activo'";

            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.AddWithValue("@Nombre", usuario);
            //        cmd.Parameters.AddWithValue("@Contraseña", contraseña);

            //        var resultado = cmd.ExecuteScalar();

            //        if (resultado != null)
            //        {
            //            rol = resultado.ToString();
            //            return true;
            //        }
            //        else
            //        {
            //            return false;
            //        }
            //    }

            //}
        }
    }
}
