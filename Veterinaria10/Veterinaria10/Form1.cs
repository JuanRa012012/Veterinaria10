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
            string usuario = txtUser.Text.Trim();
            string contrase�a = txtClave.Text.Trim();

            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(contrase�a))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            clsLoginV login = new clsLoginV();
            string rol;

            if (login.ValidarCredenciales(usuario, contrase�a, out rol))
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
                MessageBox.Show("Usuario o contrase�a incorrectos, o cuenta inactiva.");
            }
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
