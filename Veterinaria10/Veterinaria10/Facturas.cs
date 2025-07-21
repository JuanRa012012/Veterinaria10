using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Veterinaria2
{
    public partial class Facturas : Form
    {
        clsFacturasConexion clsConexion = new clsFacturasConexion();

        public Facturas()
        {
            InitializeComponent();
        }

        private void Facturas_Load(object sender, EventArgs e)
        {
            clsConexion.CargarClientes(cbxClienteCF);
            cbxClienteCF.SelectedIndex = -1;
        }

        private void bttSalirCF_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxClienteCF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int vrIdEspecie = Convert.ToInt32(cbxClienteCF.SelectedValue);
                MessageBox.Show(vrIdEspecie.ToString());
                clsConexion.CargarMascotas_x_cliente(cboMascotas, vrIdEspecie);
            }
            catch (Exception ex) 
            { 
            }

            //int vrId = Convert.ToInt32(cbxClienteCF.SelectedValue);
            //MessageBox.Show(vrId.ToString());

            //if (cbxClienteCF.SelectedIndex != -1 && cbxClienteCF.SelectedText != string.Empty)
            //{
                //int vrId = Convert.ToInt32(cbxClienteCF.SelectedValue);
                //MessageBox.Show(vrId.ToString());
                //clsConexion.CargarMascotas_x_cliente(cbxMascotaDF, vrId);
                
            //}
            //MessageBox.Show(cbxClienteCF.SelectedText);


            //if (cbxClienteCF.SelectedText != string.Empty)
            //{
            //    int vrId = Convert.ToInt32(cbxClienteCF.SelectedValue);
            //    MessageBox.Show(cbxClienteCF.SelectedValue.ToString());
            //    MessageBox.Show(vrId.ToString());
            //    clsConexion.CargarMascotas_x_cliente(cbxMascotaDF, vrId);
            //}
        }

        private void cbxClienteCF_Click(object sender, EventArgs e)
        {
            //if (cbxClienteCF.SelectedIndex != -1)
            //{
            //    int vrId = Convert.ToInt32(cbxClienteCF.SelectedValue);
            //    clsConexion.CargarMascotas_x_cliente(cbxMascotaDF, vrId);
            //}
        }

        private void cbxClienteCF_MouseClick(object sender, MouseEventArgs e)
        {
            //if (cbxClienteCF.SelectedIndex != -1)
            //{
            //    int vrId = Convert.ToInt32(cbxClienteCF.SelectedValue);
            //    clsConexion.CargarMascotas_x_cliente(cbxMascotaDF, vrId);
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int vrIdEspecie = Convert.ToInt32(cbxClienteCF.SelectedValue);
            MessageBox.Show(vrIdEspecie.ToString());
        }
    }
}
