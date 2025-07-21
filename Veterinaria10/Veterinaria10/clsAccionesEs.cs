using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Veterinaria2
{
    internal class clsAccionesEs
    {

        clsConexion conexion = new clsConexion();
       
        SqlDataAdapter da;

        DataTable dt;

        public void CargarDatosEs(DataGridView dgv, string nametable)
        {
            try
            {
                da = new SqlDataAdapter("Select * from " + nametable, conexion.sc);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            } catch (Exception ex)
            {
                MessageBox.Show("" + ex);
       
            }
        }


    }
 }
