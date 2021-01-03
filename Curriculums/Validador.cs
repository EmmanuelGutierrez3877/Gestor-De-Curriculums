using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Curriculums
{
    public class Validador
    {
        char[] abecedario = { 'a' ,'b','c','d','e','f','g', 'h', 'i', 'j', 'k', 'm', 'l', 'n', 'ñ',
            'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z','A' ,'B','C','D','E','F',
            'G', 'H', 'I', 'J', 'K', 'M', 'L', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V',
            'W', 'X', 'Y', 'Z' ,' ', 'á', 'é', 'í', 'ó', 'ú', 'ü', 'Á', 'É' , 'Í', 'Ó', 'Ú', 'Ü'};

        public bool ValidarTextBox(TextBox tb, Label lb, Char tipo)
        {
            if (tb.Text != "")
            {
                if (tipo == 't')
                {
                    if (SoloTexto(tb.Text))
                    {
                        lb.Text = "Valido";
                        lb.ForeColor = Color.Green;
                        return true;
                    }
                }
                else if (tipo == 'n')
                {
                    if (SoloNumero(tb.Text))
                    {
                        lb.Text = "Valido";
                        lb.ForeColor = Color.Green;
                        return true;
                    }
                }
                else if (tipo == 'e')
                {
                    if (Email(tb.Text))
                    {
                        lb.Text = "Valido";
                        lb.ForeColor = Color.Green;
                        return true;
                    }
                }
                else if (tipo == 'a')
                {
                    lb.Text = "Valido";
                    lb.ForeColor = Color.Green;
                    return true;
                }
            }
            else
            {
                lb.Text = "Invalido";
                lb.ForeColor = Color.Red;
            }

            lb.Text = "Invalido";
            lb.ForeColor = Color.Red;
            return false;
        }

        private bool SoloTexto(String tx)
        {
            if (tx != "")
            {
                foreach (Char c in tx)
                {

                    if (!abecedario.Contains(c))
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private bool SoloNumero(String tx)
        {
            bool result;
            int number = -1;
            if (tx != "")
            {
                foreach (Char c in tx)
                {
                    result = Int32.TryParse(c.ToString(), out number);

                    if (!result)
                    {
                        return false;
                    }
                }
                if (number < 0)
                    return false;
                return true;
            }
            return false;
        }

        private bool Email(String tx)
        {
            int estado=0;

            foreach (Char c in tx)
            {
                if (c == ' ')
                {
                    return false;
                }

                switch (estado)
                {
                    case 0:
                        if(c!='.'&&c!='@')
                        {
                            estado = 1;
                        }
                        break;

                    case 1:
                        if (c == '@')
                        {
                            estado = 2;
                        }

                        break;

                    case 2:
                        if(c != '.' && c != '@')
                        {
                            estado = 3;
                        }
                        break;

                    case 3:
                        if (c == '.')
                        {
                            estado = 4;
                        }
                        else if (c=='@')
                        {
                            return false;
                        }

                        break;

                    case 4:
                        if (c!='.')
                        {
                            estado = 5;
                        }
                        else if (c == '@')
                        {
                            return false;
                        }
                        break;

                    case 5:
                        if (c=='.')
                        {
                            estado = 4;
                        }
                        break;
                }


            }

            if (estado == 5)
            {
                return true;
            }
            return false;
        }

        //*/*//

        public bool ValidarComboBox(ComboBox cb, Label lb)
        {
            if (cb.SelectedIndex > -1)
            {
                lb.Text = "Válido";
                lb.ForeColor = Color.Green;
                return true;


            }
            lb.Text = "Inválido";
            lb.ForeColor = Color.Red;
            return false;
        }

        //*/*//
    }
}
