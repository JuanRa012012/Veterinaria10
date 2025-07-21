using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Veterinaria2
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario = txtUser.Text.Trim();
                string contraseña = txtClave.Text.Trim();

                if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
                {
                    MessageBox.Show("Por favor, complete todos los campos.");
                    return;
                }

                clsLoginV login = new clsLoginV();
                int vrIdRol;

                if (login.ValidarCredenciales(usuario, contraseña, out vrIdRol))
                {
                    if (vrIdRol == 1)
                    {
                        new Admin().Show();
                    }
                    else
                    {
                        new Empleado().Show();
                    }

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos.", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
