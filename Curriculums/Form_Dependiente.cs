﻿using System;
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
    public partial class Form_Dependiente : Form
    {
        Validador validar = new Validador();
        public Dependiente dependiente;
        public bool lleno = false;

        public Form_Dependiente()
        {
            InitializeComponent();
        }

        private void Form_Dependiente_Load(object sender, EventArgs e)
        {
            dateTimePickerNacimiento.MaxDate = DateTime.Today;
            labelVerificarApellidoP.Text = "";
            labelVerificarApellidoM.Text = "";
            labelVerificarNombre.Text = "";

            buttonAgregar.Enabled = false;
        }

        private void ActivarGuardar()
        {
            bool nom, aPa, aMa;
            nom = validar.ValidarTextBox(textBoxNombre, labelVerificarNombre, 't');
            aPa = validar.ValidarTextBox(textBoxApellidoP, labelVerificarApellidoP, 't');
            aMa = validar.ValidarTextBox(textBoxApellidoM, labelVerificarApellidoM, 't');


            if(nom && aPa && aMa )
            {
                buttonAgregar.Enabled = true;
            }
            else
            {
                buttonAgregar.Enabled = false;
            }

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void textBoxApellidoP_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void textBoxApellidoM_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void dateTimePickerNacimiento_ValueChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            dependiente = new Dependiente(textBoxNombre.Text,textBoxApellidoP.Text,textBoxApellidoM.Text,dateTimePickerNacimiento.Value);
            lleno = true;
            this.Close();
        }

        
    }
}
