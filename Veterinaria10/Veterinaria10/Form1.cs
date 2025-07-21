using Veterinaria2;

namespace Veterinaria10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        clsConexion clsConexion = new clsConexion();

        private void button1_Click(object sender, EventArgs e)
        {
            clsConexion.Abrir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsConexion.Cerrar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login form = new Login();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
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

        private void cmd_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
