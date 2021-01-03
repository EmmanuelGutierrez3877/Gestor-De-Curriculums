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
    public partial class Form_Control_Usuarios : Form
    {
        ListaProfesores lp;
        Validador validar = new Validador();
        Form ant;

        public Form_Control_Usuarios(ListaProfesores lp,Form ant)
        {
            InitializeComponent();
            this.lp = lp;
            this.ant = ant;
        }

        private void Form_Control_Usuarios_Load(object sender, EventArgs e)
        {
            labelVerificarContraseña.Text = "";
            labelVerificarNombre.Text = "";
            labelVerificarApellidoP.Text = "";
            labelVerificarApellidoM.Text = "";
            CargarLista();
            textBoxCodigo.Text = CodigoDisponible().ToString();
            textBoxContraseña.PasswordChar = '*';

            ant.Visible = false;
        }

        void CargarLista()
        {
            listViewProfesores.Clear();
            listViewProfesores.View = View.Details;
            listViewProfesores.FullRowSelect = true;
            listViewProfesores.GridLines = true;
            listViewProfesores.Columns.Add("Codigo", 100);
            listViewProfesores.Columns.Add("Nombre(s)", 200);
            listViewProfesores.Columns.Add("Apellidos", 200);

            foreach (Profesor p in lp)
            {
                listViewProfesores.Items.Add(p.codigo);
                listViewProfesores.Items[listViewProfesores.Items.Count - 1].SubItems.Add(p.nombre);
                listViewProfesores.Items[listViewProfesores.Items.Count - 1].SubItems.Add(p.apellidoP+" "+p.apellidoM);
            }
        }

        int CodigoDisponible()
        {
            int cod=0;
            bool enc;

            for (cod=100001;cod<=999999;cod++)
            {
                enc = false;
                foreach (Profesor p in lp)
                {
                    if(p.codigo == cod.ToString())
                    {
                        enc = true;
                        break;
                    }
                    
                }
                if (!enc)
                {
                    break;
                }
            }

            return cod;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if (textBoxContraseña.Text != "" && textBoxNombre.Text != "")
            {
                lp.Add(new Profesor(textBoxCodigo.Text, textBoxNombre.Text, textBoxApellidoP.Text, textBoxApellidoM.Text,textBoxContraseña.Text));

                textBoxCodigo.Text = CodigoDisponible().ToString();
            }
            CargarLista();
            textBoxCodigo.Text = CodigoDisponible().ToString();
            textBoxContraseña.Text = "";
            textBoxNombre.Text = "";
            textBoxApellidoP.Text = "";
            textBoxApellidoM.Text = "";
            buttonAgregar.Enabled = false;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewProfesores.SelectedIndices.Count != 0)
            {
                int i = listViewProfesores.SelectedIndices[0];
                lp.Remove(lp[i]);
                CargarLista();
                textBoxCodigo.Text = CodigoDisponible().ToString();
            }

            buttonEliminar.Enabled = false;
        }

        private void listViewProfesores_DoubleClick(object sender, EventArgs e)
        {
            int i = listViewProfesores.SelectedIndices[0];
            Form_Usuario fu = new Form_Usuario(lp[i],this);
            fu.ShowDialog();
            CargarLista();
        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarAgregar();
        }

        private void textBoxApellidos_TextChanged(object sender, EventArgs e)
        {
            ActivarAgregar();
        }

        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            ActivarAgregar();
        }

        private void textBoxApellidoM_TextChanged(object sender, EventArgs e)
        {
            ActivarAgregar();
        }

        private void ActivarAgregar()
        {
            bool a, b, c,d;
            a = validar.ValidarTextBox(textBoxNombre, labelVerificarNombre, 't');
            b = validar.ValidarTextBox(textBoxApellidoP, labelVerificarApellidoP, 't');
            c = validar.ValidarTextBox(textBoxContraseña, labelVerificarContraseña, 'a');
            d = validar.ValidarTextBox(textBoxApellidoM, labelVerificarApellidoM, 't');
            if (a && b && c && d)
            {
                buttonAgregar.Enabled = true;
            }
            else
            {
                buttonAgregar.Enabled = false;
            }

        }

        private void listViewProfesores_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
            
        }

        private void Form_Control_Usuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            ant.WindowState = FormWindowState.Minimized;
            ant.WindowState = FormWindowState.Normal;
            ant.Visible = true;
        }

        private void buttonCambiarContraseña_Click(object sender, EventArgs e)
        {
            FormCambiarContraseña cc = new FormCambiarContraseña(lp);
            cc.ShowDialog();
        }

        private void Form_Control_Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        
    }
}
