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
            string usuario = txtUser.Text.Trim();
            string contraseña = txtClave.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contraseña))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            clsLoginV login = new clsLoginV();
            string rol;

            if (login.ValidarCredenciales(usuario, contraseña, out rol))
            {
                MessageBox.Show($"Bienvenido, {usuario}. Rol: {rol}");

                if (rol == "Administrador")
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
                MessageBox.Show("Usuario o contraseña incorrectos, o cuenta inactiva.");
            }
        }
    }
}
