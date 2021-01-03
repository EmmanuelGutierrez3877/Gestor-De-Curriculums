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
    public partial class FormCambiarContraseña : Form
    {
        ListaProfesores lp;
        Validador validar = new Validador();

        public FormCambiarContraseña(ListaProfesores lp)
        {
            InitializeComponent();
            textBoxAnterior.PasswordChar = '*';
            textBoxNueva.PasswordChar = '*';
            textBoxNueva2.PasswordChar = '*';
            labelVerificarNueva.Text = " ";
            this.lp = lp;
        
        }

        private void FormCambiarContraseña_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            if ( (textBoxAnterior.Text == lp.contraseñaAdmin) && (textBoxNueva.Text == textBoxNueva2.Text)&& validar.ValidarTextBox(textBoxNueva, labelVerificarNueva, 'a'))
            {
                lp.contraseñaAdmin = textBoxNueva.Text;
                MessageBox.Show("Contraseña cambiada correctamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Contraseña no cambiada\n(algun dato puede estar mal)", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormCambiarContraseña_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void textBoxNueva_TextChanged(object sender, EventArgs e)
        {
            validar.ValidarTextBox(textBoxNueva,labelVerificarNueva,'a');
        }
    }
}
