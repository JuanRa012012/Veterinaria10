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
           Admin form = new Admin();
            form.Show();
        }
    }
}
