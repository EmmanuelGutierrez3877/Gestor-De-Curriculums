using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Curriculums
{
    public partial class Form_Loging : Form
    {
        ListaProfesores lp;
        

        public Form_Loging(ListaProfesores lp, String contraseñaAdmin)
        {
            InitializeComponent();

            this.lp = lp;
            textBoxContraseña.PasswordChar = '*';
            labelVerificarCodigo.Text = "";
            labelVerificarContraseña.Text = "";
            /////datos de prueba
            //textBoxCodigo.Text = "000000";
            //textBoxContraseña.Text = contraseñaAdmin;
            //////
        }

        private void Form_Loging_Load(object sender, EventArgs e)
        {

        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            labelVerificarContraseña.Text = "";
            if (textBoxCodigo.Text == "000000" )
            {
                if (textBoxContraseña.Text == lp.contraseñaAdmin)
                {
                    Form_Control_Usuarios FCU = new Form_Control_Usuarios(lp,this);
                    FCU.ShowDialog();
                    //////////////////////////////////////////////////////////////////////////////////iniciar como admin
                    textBoxContraseña.Text = "";
                }
                else
                {
                    labelVerificarContraseña.Text = "Contraseña invalida";
                    labelVerificarContraseña.ForeColor = Color.Red;
                }
            }
            else
            {
                int pos = VerificarCodigo();
                if (pos != -1)
                {
                    if(VerificarContraseña())
                    {
                        ///////////////////////////////////////////////////////////////////////////iniciar como profesor
                        Form_Usuario fu = new Form_Usuario(lp[pos],this);
                        fu.ShowDialog();
                        textBoxContraseña.Text = "";
                    }
                    else
                    {
                        labelVerificarContraseña.Text = "Contraseña invalida";
                        labelVerificarContraseña.ForeColor = Color.Red;
                    }
                } 
            }
        }

        private void textBoxCodigo_TextChanged(object sender, EventArgs e)
        {
            if (textBoxCodigo.Text != "000000")
            {
                labelVerificarCodigo.Text = "";
                VerificarCodigo();
            }
            else
            {
                labelVerificarCodigo.Text = "Administrador";
                labelVerificarCodigo.ForeColor = Color.Green;
            }
        }

        int VerificarCodigo()
        {
            int i = 0;
            labelVerificarCodigo.Text = "Codigo invalido";
            labelVerificarCodigo.ForeColor = Color.Red;
            if (textBoxCodigo.Text.Length == 6)
            {
                for(i=0;i<lp.Count;i++)
                {
                    if (lp[i].codigo == textBoxCodigo.Text)
                    {
                        labelVerificarCodigo.Text = "Codigo correcto";
                        labelVerificarCodigo.ForeColor = Color.Green;
                        return i;
                    }
                }
            }
            return -1;
        }

        bool VerificarContraseña()
        {
            int pos = VerificarCodigo();
            if (pos != -1)
            {
                
                if (lp[pos].codigo == textBoxCodigo.Text)
                {
                    if (lp[pos].contraseña == textBoxContraseña.Text)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        
    }
}
