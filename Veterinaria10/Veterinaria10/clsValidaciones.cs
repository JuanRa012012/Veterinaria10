using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinaria2
{
    public class clsValidaciones
    {
        public void SoloEnteros(KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
                e.Handled = true;
            else
                e.Handled = false;
        }

        public void SoloLetras(KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != ' '))
                e.Handled = true;
            else
                e.Handled = false;
        }

        public void SoloReales(KeyPressEventArgs e)
        {
            if (!Char.IsControl(e.KeyChar) && !Char.IsDigit(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
                e.Handled = true;
            else
                e.Handled = false;
        }

    }
}
