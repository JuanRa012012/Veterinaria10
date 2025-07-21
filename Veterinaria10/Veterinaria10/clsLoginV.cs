using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Veterinaria2
{
    class clsLoginV
    {
        private string conexion = "Data Source=CHRISTINA-PC\\SQLEXPRESS;Initial Catalog=BDVeterinaria;Integrated Security=true";

        /// <summary>
        /// Valida un usuario por nombre y contraseña.
        /// </summary>
        /// <param name="usuario">Nombre de usuario</param>
        /// <param name="contraseña">Contraseña</param>
        /// <param name="rol">Devuelve el rol si es válido</param>
        /// <returns>true si las credenciales son correctas y el usuario está activo</returns>
        public bool ValidarCredenciales(string usuario, string contraseña, out string rol)
        {
            rol = "";

            using (SqlConnection conn = new SqlConnection(conexion))
            {
                conn.Open();
                string query = "SELECT Rol FROM UsuarioSistema WHERE Nombre = @Nombre AND Contraseña = @Contraseña AND Estado = 'Activo'";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", contraseña);

                    var resultado = cmd.ExecuteScalar();

                    if (resultado != null)
                    {
                        rol = resultado.ToString();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }
    }
}
