using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyect_Kardex
{
    class ValidacionText
    {
        public void soloNumeros(KeyPressEventArgs n)
        {
            try
            {
                if (char.IsDigit(n.KeyChar))
                {
                    n.Handled = false;
                }
               else if (char.IsControl(n.KeyChar))
                {
                   n.Handled = false;
                }
                else
                {
                    n.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        public void soloLetras(KeyPressEventArgs n)
        {
            try
            {
                if (char.IsLetter(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsControl(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsSeparator(n.KeyChar))
                {
                    n.Handled = false;
                }
                else
                {
                    n.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        public void soloLetrasYNumeros(KeyPressEventArgs n) 
        {
            try
            {
                if (char.IsLetter(n.KeyChar))
                {
                    n.Handled = false;
                }
               else if (char.IsDigit(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsControl(n.KeyChar))
                {
                    n.Handled = false;
                }
                else if (char.IsSeparator(n.KeyChar))
                {
                    n.Handled = false;
                }
                else
                {
                    n.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }

        public void Nada(KeyPressEventArgs n)
        {
            try
            {
                if (char.IsLetter(n.KeyChar))
                {
                    n.Handled = true;
                }
                else if (char.IsControl(n.KeyChar))
                {
                    n.Handled = true;
                }
                else if (char.IsPunctuation(n.KeyChar))
                {
                    n.Handled = true;
                }
                else if (char.IsSurrogate(n.KeyChar))
                {
                    n.Handled = true;
                }
                else if (char.IsSymbol(n.KeyChar))
                {
                    n.Handled = true;
                }
                else if (char.IsSeparator(n.KeyChar))
                {
                    n.Handled = true;
                }
                else
                {
                    n.Handled = true;
                }
            }
            catch (Exception)
            {

            }
        }
    }
}
