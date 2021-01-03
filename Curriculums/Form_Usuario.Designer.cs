using System;
using System.Collections.Specialized;

namespace Curriculums
{
    partial class Form_Usuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Usuario));
            this.tabPageDatosPersonales = new System.Windows.Forms.TabPage();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.listViewDependientes = new System.Windows.Forms.ListView();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxDomicilio = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxCiudad = new System.Windows.Forms.TextBox();
            this.textBoxApellidoM = new System.Windows.Forms.TextBox();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxApellidoP = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerNacimiento = new System.Windows.Forms.DateTimePicker();
            this.labelVerificarTelefono = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.labelVerificarCiudad = new System.Windows.Forms.Label();
            this.labelVerificarDomicilio = new System.Windows.Forms.Label();
            this.labelVerificarEmail = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.labelVerificarApellidoM = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelVerificarApellidoP = new System.Windows.Forms.Label();
            this.pictureBoxFoto = new System.Windows.Forms.PictureBox();
            this.labelVerificarNombre = new System.Windows.Forms.Label();
            this.labelVerificarContraseña = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonFoto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFormaciónAcademica = new System.Windows.Forms.TabPage();
            this.lblInstitucionFA = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.lblTítuloObtencionFA = new System.Windows.Forms.Label();
            this.lblTítuloFinFA = new System.Windows.Forms.Label();
            this.lblTítuloInicioFA = new System.Windows.Forms.Label();
            this.lblTítuloCedulaFA = new System.Windows.Forms.Label();
            this.lblTítuloNombreFA = new System.Windows.Forms.Label();
            this.lblTítuloGradoFA = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.msFA = new System.Windows.Forms.MenuStrip();
            this.tsmiAgregarFA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeleccionarFA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarFA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarFA = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageProduccionAcademica = new System.Windows.Forms.TabPage();
            this.label22 = new System.Windows.Forms.Label();
            this.listViewAutoresPA = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTituloNRegistroPA = new System.Windows.Forms.Label();
            this.lblTituloInstitucionPA = new System.Windows.Forms.Label();
            this.lblTituloFechaPA = new System.Windows.Forms.Label();
            this.lblTituloTituloPA = new System.Windows.Forms.Label();
            this.lblTituloCategoriaPA = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.msPA = new System.Windows.Forms.MenuStrip();
            this.tsmiAgregarPA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSeleccionarPA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEliminarPA = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModificarPA = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageCargaAcademica = new System.Windows.Forms.TabPage();
            this.btnModificarCA = new System.Windows.Forms.Button();
            this.btnEliminarCA = new System.Windows.Forms.Button();
            this.btnAgregarCA = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.lvwCargaAcademica = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageControlFA = new System.Windows.Forms.TabPage();
            this.lblVerificarFechasFinObtencion = new System.Windows.Forms.Label();
            this.lblVerificarFechasInicioFin = new System.Windows.Forms.Label();
            this.btnCancelarFA = new System.Windows.Forms.Button();
            this.cboGradoAcademico = new System.Windows.Forms.ComboBox();
            this.lblVerificarCedula = new System.Windows.Forms.Label();
            this.dtpObtenciónFA = new System.Windows.Forms.DateTimePicker();
            this.dtpFinFA = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioFA = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.labelApellidoM = new System.Windows.Forms.Label();
            this.lblVerificarInstitucion = new System.Windows.Forms.Label();
            this.lblVerificarNombreFA = new System.Windows.Forms.Label();
            this.lblVerificarGA = new System.Windows.Forms.Label();
            this.labelApellidoP = new System.Windows.Forms.Label();
            this.txbInstitucion = new System.Windows.Forms.TextBox();
            this.btnControlFA = new System.Windows.Forms.Button();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.txbCedulaFA = new System.Windows.Forms.TextBox();
            this.txbNombreFA = new System.Windows.Forms.TextBox();
            this.labelTítuloControlFA = new System.Windows.Forms.Label();
            this.tabPageControlPA = new System.Windows.Forms.TabPage();
            this.lblValidarAutores = new System.Windows.Forms.Label();
            this.btnEliminarAutorPA = new System.Windows.Forms.Button();
            this.lvwAutoresPA = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnAgregarAutorPA = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaPA = new System.Windows.Forms.DateTimePicker();
            this.lblVerificarInstitucionPA = new System.Windows.Forms.Label();
            this.txbInstitucionPA = new System.Windows.Forms.TextBox();
            this.btnCancelarAgregarPA = new System.Windows.Forms.Button();
            this.cboCategoriaPA = new System.Windows.Forms.ComboBox();
            this.lblVerificarNRegistroPA = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblVerificarTituloPA = new System.Windows.Forms.Label();
            this.lblVerificarCategoriaPA = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.btnControlPA = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.txbNRegistroPA = new System.Windows.Forms.TextBox();
            this.txbTituloPA = new System.Windows.Forms.TextBox();
            this.labelTituloPA = new System.Windows.Forms.Label();
            this.tabPageControlCA = new System.Windows.Forms.TabPage();
            this.labelTítuloControlCA = new System.Windows.Forms.Label();
            this.btnCancelarCA = new System.Windows.Forms.Button();
            this.btnControlCA = new System.Windows.Forms.Button();
            this.dtpFinCA = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioCA = new System.Windows.Forms.DateTimePicker();
            this.txbProgramaEducativoCA = new System.Windows.Forms.TextBox();
            this.txbNombreCA = new System.Windows.Forms.TextBox();
            this.txbCargaHorariaCA = new System.Windows.Forms.TextBox();
            this.lblVerificarProgramaEducativoCA = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblVerificarFechasCA = new System.Windows.Forms.Label();
            this.lblVerificarNombreCA = new System.Windows.Forms.Label();
            this.lblVerificarCargaHorariaCA = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.tabPageTutorados = new System.Windows.Forms.TabPage();
            this.btnModificarTU = new System.Windows.Forms.Button();
            this.btnEliminarTU = new System.Windows.Forms.Button();
            this.btnAgregarTU = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.lvwTutorados = new System.Windows.Forms.ListView();
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageControlTU = new System.Windows.Forms.TabPage();
            this.label52 = new System.Windows.Forms.Label();
            this.txbNombreTU = new System.Windows.Forms.TextBox();
            this.lblVerificarNombreTU = new System.Windows.Forms.Label();
            this.txbAMaternoTU = new System.Windows.Forms.TextBox();
            this.lblVerificarAMaternoTU = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.labelTítuloControlTU = new System.Windows.Forms.Label();
            this.btnCancelarTU = new System.Windows.Forms.Button();
            this.btnControlTU = new System.Windows.Forms.Button();
            this.dtpFinTU = new System.Windows.Forms.DateTimePicker();
            this.dtpInicioTU = new System.Windows.Forms.DateTimePicker();
            this.txbAPAternoTU = new System.Windows.Forms.TextBox();
            this.txbCodigoTU = new System.Windows.Forms.TextBox();
            this.txbCargaHorariaTU = new System.Windows.Forms.TextBox();
            this.lblVerificarAPaternoTU = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.lblVerificarFechasTU = new System.Windows.Forms.Label();
            this.lblVerificarCodigoTU = new System.Windows.Forms.Label();
            this.lblVerificarCargaHorariaTU = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.tabPageCurriculum = new System.Windows.Forms.TabPage();
            this.buttonVistaPrevia = new System.Windows.Forms.Button();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.buttonWord = new System.Windows.Forms.Button();
            this.tabPageDatosPersonales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPageFormaciónAcademica.SuspendLayout();
            this.msFA.SuspendLayout();
            this.tabPageProduccionAcademica.SuspendLayout();
            this.msPA.SuspendLayout();
            this.tabPageCargaAcademica.SuspendLayout();
            this.tabPageControlFA.SuspendLayout();
            this.tabPageControlPA.SuspendLayout();
            this.tabPageControlCA.SuspendLayout();
            this.tabPageTutorados.SuspendLayout();
            this.tabPageControlTU.SuspendLayout();
            this.tabPageCurriculum.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDatosPersonales
            // 
            this.tabPageDatosPersonales.BackColor = System.Drawing.Color.Transparent;
            this.tabPageDatosPersonales.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageDatosPersonales.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageDatosPersonales.Controls.Add(this.buttonEliminar);
            this.tabPageDatosPersonales.Controls.Add(this.listViewDependientes);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxTelefono);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxDomicilio);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxEmail);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxCiudad);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxApellidoM);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxCodigo);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxNombre);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxContraseña);
            this.tabPageDatosPersonales.Controls.Add(this.textBoxApellidoP);
            this.tabPageDatosPersonales.Controls.Add(this.buttonAgregar);
            this.tabPageDatosPersonales.Controls.Add(this.label7);
            this.tabPageDatosPersonales.Controls.Add(this.label5);
            this.tabPageDatosPersonales.Controls.Add(this.dateTimePickerNacimiento);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarTelefono);
            this.tabPageDatosPersonales.Controls.Add(this.label15);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarCiudad);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarDomicilio);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarEmail);
            this.tabPageDatosPersonales.Controls.Add(this.label19);
            this.tabPageDatosPersonales.Controls.Add(this.label20);
            this.tabPageDatosPersonales.Controls.Add(this.label21);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarApellidoM);
            this.tabPageDatosPersonales.Controls.Add(this.label6);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarApellidoP);
            this.tabPageDatosPersonales.Controls.Add(this.pictureBoxFoto);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarNombre);
            this.tabPageDatosPersonales.Controls.Add(this.labelVerificarContraseña);
            this.tabPageDatosPersonales.Controls.Add(this.label3);
            this.tabPageDatosPersonales.Controls.Add(this.label4);
            this.tabPageDatosPersonales.Controls.Add(this.buttonFoto);
            this.tabPageDatosPersonales.Controls.Add(this.label2);
            this.tabPageDatosPersonales.Controls.Add(this.buttonGuardar);
            this.tabPageDatosPersonales.Controls.Add(this.label1);
            this.tabPageDatosPersonales.Location = new System.Drawing.Point(4, 60);
            this.tabPageDatosPersonales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDatosPersonales.Name = "tabPageDatosPersonales";
            this.tabPageDatosPersonales.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageDatosPersonales.Size = new System.Drawing.Size(1101, 599);
            this.tabPageDatosPersonales.TabIndex = 0;
            this.tabPageDatosPersonales.Text = " Datos Personales ";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(847, 544);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(113, 42);
            this.buttonEliminar.TabIndex = 12;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // listViewDependientes
            // 
            this.listViewDependientes.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listViewDependientes.Location = new System.Drawing.Point(569, 246);
            this.listViewDependientes.Margin = new System.Windows.Forms.Padding(4);
            this.listViewDependientes.MultiSelect = false;
            this.listViewDependientes.Name = "listViewDependientes";
            this.listViewDependientes.Size = new System.Drawing.Size(509, 291);
            this.listViewDependientes.TabIndex = 46;
            this.listViewDependientes.UseCompatibleStateImageBehavior = false;
            this.listViewDependientes.View = System.Windows.Forms.View.Details;
            this.listViewDependientes.SelectedIndexChanged += new System.EventHandler(this.listViewDependientes_SelectedIndexChanged);
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTelefono.Location = new System.Drawing.Point(149, 405);
            this.textBoxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.Size = new System.Drawing.Size(323, 30);
            this.textBoxTelefono.TabIndex = 8;
            this.textBoxTelefono.TextChanged += new System.EventHandler(this.textBoxTelefono_TextChanged);
            // 
            // textBoxDomicilio
            // 
            this.textBoxDomicilio.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDomicilio.Location = new System.Drawing.Point(149, 288);
            this.textBoxDomicilio.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDomicilio.Name = "textBoxDomicilio";
            this.textBoxDomicilio.Size = new System.Drawing.Size(323, 30);
            this.textBoxDomicilio.TabIndex = 5;
            this.textBoxDomicilio.TextChanged += new System.EventHandler(this.textBoxDomicilio_TextChanged);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEmail.Location = new System.Drawing.Point(149, 443);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(323, 30);
            this.textBoxEmail.TabIndex = 9;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxCiudad
            // 
            this.textBoxCiudad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCiudad.Location = new System.Drawing.Point(149, 326);
            this.textBoxCiudad.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCiudad.Name = "textBoxCiudad";
            this.textBoxCiudad.Size = new System.Drawing.Size(323, 30);
            this.textBoxCiudad.TabIndex = 6;
            this.textBoxCiudad.TextChanged += new System.EventHandler(this.textBoxCuidad_TextChanged);
            // 
            // textBoxApellidoM
            // 
            this.textBoxApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoM.Location = new System.Drawing.Point(149, 210);
            this.textBoxApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoM.Name = "textBoxApellidoM";
            this.textBoxApellidoM.Size = new System.Drawing.Size(323, 30);
            this.textBoxApellidoM.TabIndex = 3;
            this.textBoxApellidoM.TextChanged += new System.EventHandler(this.textBoxApellidoM_TextChanged);
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(149, 97);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(323, 30);
            this.textBoxCodigo.TabIndex = 0;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(149, 135);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(323, 30);
            this.textBoxNombre.TabIndex = 1;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(149, 249);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(323, 30);
            this.textBoxContraseña.TabIndex = 4;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // textBoxApellidoP
            // 
            this.textBoxApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoP.Location = new System.Drawing.Point(149, 174);
            this.textBoxApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoP.Name = "textBoxApellidoP";
            this.textBoxApellidoP.Size = new System.Drawing.Size(323, 30);
            this.textBoxApellidoP.TabIndex = 2;
            this.textBoxApellidoP.TextChanged += new System.EventHandler(this.textBoxApellidoP_TextChanged);
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(684, 544);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(113, 42);
            this.buttonAgregar.TabIndex = 11;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(136, 23);
            this.label7.TabIndex = 44;
            this.label7.Text = "Dependientes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 374);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 24);
            this.label5.TabIndex = 42;
            this.label5.Text = "Nacimiento : ";
            // 
            // dateTimePickerNacimiento
            // 
            this.dateTimePickerNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNacimiento.Location = new System.Drawing.Point(149, 366);
            this.dateTimePickerNacimiento.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerNacimiento.MaxDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.MinDate = new System.DateTime(1950, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.Name = "dateTimePickerNacimiento";
            this.dateTimePickerNacimiento.Size = new System.Drawing.Size(163, 30);
            this.dateTimePickerNacimiento.TabIndex = 7;
            this.dateTimePickerNacimiento.Value = new System.DateTime(2018, 4, 29, 0, 0, 0, 0);
            this.dateTimePickerNacimiento.ValueChanged += new System.EventHandler(this.dateTimePickerNacimiento_ValueChanged);
            // 
            // labelVerificarTelefono
            // 
            this.labelVerificarTelefono.AutoSize = true;
            this.labelVerificarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarTelefono.Location = new System.Drawing.Point(480, 415);
            this.labelVerificarTelefono.Name = "labelVerificarTelefono";
            this.labelVerificarTelefono.Size = new System.Drawing.Size(56, 17);
            this.labelVerificarTelefono.TabIndex = 39;
            this.labelVerificarTelefono.Text = "invalido";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(29, 410);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 24);
            this.label15.TabIndex = 38;
            this.label15.Text = "Telefono : ";
            // 
            // labelVerificarCiudad
            // 
            this.labelVerificarCiudad.AutoSize = true;
            this.labelVerificarCiudad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarCiudad.Location = new System.Drawing.Point(480, 335);
            this.labelVerificarCiudad.Name = "labelVerificarCiudad";
            this.labelVerificarCiudad.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarCiudad.TabIndex = 37;
            this.labelVerificarCiudad.Text = "label7";
            // 
            // labelVerificarDomicilio
            // 
            this.labelVerificarDomicilio.AutoSize = true;
            this.labelVerificarDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarDomicilio.Location = new System.Drawing.Point(480, 297);
            this.labelVerificarDomicilio.Name = "labelVerificarDomicilio";
            this.labelVerificarDomicilio.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarDomicilio.TabIndex = 36;
            this.labelVerificarDomicilio.Text = "label6";
            // 
            // labelVerificarEmail
            // 
            this.labelVerificarEmail.AutoSize = true;
            this.labelVerificarEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarEmail.Location = new System.Drawing.Point(480, 453);
            this.labelVerificarEmail.Name = "labelVerificarEmail";
            this.labelVerificarEmail.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarEmail.TabIndex = 35;
            this.labelVerificarEmail.Text = "label5";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(39, 330);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(95, 24);
            this.label19.TabIndex = 34;
            this.label19.Text = "Ciudad : ";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(19, 293);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(115, 24);
            this.label20.TabIndex = 33;
            this.label20.Text = "Domicilio : ";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(43, 449);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(81, 24);
            this.label21.TabIndex = 32;
            this.label21.Text = "E-mail :";
            // 
            // labelVerificarApellidoM
            // 
            this.labelVerificarApellidoM.AutoSize = true;
            this.labelVerificarApellidoM.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarApellidoM.Location = new System.Drawing.Point(480, 220);
            this.labelVerificarApellidoM.Name = "labelVerificarApellidoM";
            this.labelVerificarApellidoM.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarApellidoM.TabIndex = 15;
            this.labelVerificarApellidoM.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "A. Materno : ";
            // 
            // labelVerificarApellidoP
            // 
            this.labelVerificarApellidoP.AutoSize = true;
            this.labelVerificarApellidoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarApellidoP.Location = new System.Drawing.Point(480, 182);
            this.labelVerificarApellidoP.Name = "labelVerificarApellidoP";
            this.labelVerificarApellidoP.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarApellidoP.TabIndex = 12;
            this.labelVerificarApellidoP.Text = "label7";
            // 
            // pictureBoxFoto
            // 
            this.pictureBoxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxFoto.Location = new System.Drawing.Point(632, 4);
            this.pictureBoxFoto.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxFoto.Name = "pictureBoxFoto";
            this.pictureBoxFoto.Size = new System.Drawing.Size(150, 180);
            this.pictureBoxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFoto.TabIndex = 0;
            this.pictureBoxFoto.TabStop = false;
            // 
            // labelVerificarNombre
            // 
            this.labelVerificarNombre.AutoSize = true;
            this.labelVerificarNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarNombre.Location = new System.Drawing.Point(480, 144);
            this.labelVerificarNombre.Name = "labelVerificarNombre";
            this.labelVerificarNombre.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarNombre.TabIndex = 11;
            this.labelVerificarNombre.Text = "label6";
            // 
            // labelVerificarContraseña
            // 
            this.labelVerificarContraseña.AutoSize = true;
            this.labelVerificarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.labelVerificarContraseña.Location = new System.Drawing.Point(480, 258);
            this.labelVerificarContraseña.Name = "labelVerificarContraseña";
            this.labelVerificarContraseña.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarContraseña.TabIndex = 10;
            this.labelVerificarContraseña.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "A. Paterno : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nombre(s) : ";
            // 
            // buttonFoto
            // 
            this.buttonFoto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFoto.Location = new System.Drawing.Point(805, 110);
            this.buttonFoto.Margin = new System.Windows.Forms.Padding(4);
            this.buttonFoto.Name = "buttonFoto";
            this.buttonFoto.Size = new System.Drawing.Size(155, 58);
            this.buttonFoto.TabIndex = 10;
            this.buttonFoto.Text = "Seleccionar fotografia";
            this.buttonFoto.UseVisualStyleBackColor = true;
            this.buttonFoto.Click += new System.EventHandler(this.buttonFoto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Contraseña : ";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardar.Location = new System.Drawing.Point(252, 481);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(113, 42);
            this.buttonGuardar.TabIndex = 13;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Codigo : ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageDatosPersonales);
            this.tabControl1.Controls.Add(this.tabPageFormaciónAcademica);
            this.tabControl1.Controls.Add(this.tabPageProduccionAcademica);
            this.tabControl1.Controls.Add(this.tabPageCargaAcademica);
            this.tabControl1.Controls.Add(this.tabPageControlFA);
            this.tabControl1.Controls.Add(this.tabPageControlPA);
            this.tabControl1.Controls.Add(this.tabPageControlCA);
            this.tabControl1.Controls.Add(this.tabPageTutorados);
            this.tabControl1.Controls.Add(this.tabPageControlTU);
            this.tabControl1.Controls.Add(this.tabPageCurriculum);
            this.tabControl1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1109, 663);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPageFormaciónAcademica
            // 
            this.tabPageFormaciónAcademica.BackColor = System.Drawing.Color.Transparent;
            this.tabPageFormaciónAcademica.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageFormaciónAcademica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageFormaciónAcademica.Controls.Add(this.lblInstitucionFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.label32);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloObtencionFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloFinFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloInicioFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloCedulaFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloNombreFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.lblTítuloGradoFA);
            this.tabPageFormaciónAcademica.Controls.Add(this.label14);
            this.tabPageFormaciónAcademica.Controls.Add(this.label13);
            this.tabPageFormaciónAcademica.Controls.Add(this.label12);
            this.tabPageFormaciónAcademica.Controls.Add(this.label9);
            this.tabPageFormaciónAcademica.Controls.Add(this.label8);
            this.tabPageFormaciónAcademica.Controls.Add(this.label10);
            this.tabPageFormaciónAcademica.Controls.Add(this.msFA);
            this.tabPageFormaciónAcademica.Location = new System.Drawing.Point(4, 60);
            this.tabPageFormaciónAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageFormaciónAcademica.Name = "tabPageFormaciónAcademica";
            this.tabPageFormaciónAcademica.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageFormaciónAcademica.Size = new System.Drawing.Size(1101, 599);
            this.tabPageFormaciónAcademica.TabIndex = 3;
            this.tabPageFormaciónAcademica.Text = "Formación Académica";
            // 
            // lblInstitucionFA
            // 
            this.lblInstitucionFA.AutoSize = true;
            this.lblInstitucionFA.Location = new System.Drawing.Point(381, 181);
            this.lblInstitucionFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblInstitucionFA.Name = "lblInstitucionFA";
            this.lblInstitucionFA.Size = new System.Drawing.Size(0, 23);
            this.lblInstitucionFA.TabIndex = 14;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.Location = new System.Drawing.Point(25, 181);
            this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(325, 24);
            this.label32.TabIndex = 13;
            this.label32.Text = "INSTITUCIÓN DE PROCEDENCIA:";
            // 
            // lblTítuloObtencionFA
            // 
            this.lblTítuloObtencionFA.AutoSize = true;
            this.lblTítuloObtencionFA.Location = new System.Drawing.Point(180, 398);
            this.lblTítuloObtencionFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloObtencionFA.Name = "lblTítuloObtencionFA";
            this.lblTítuloObtencionFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloObtencionFA.TabIndex = 12;
            // 
            // lblTítuloFinFA
            // 
            this.lblTítuloFinFA.AutoSize = true;
            this.lblTítuloFinFA.Location = new System.Drawing.Point(89, 347);
            this.lblTítuloFinFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloFinFA.Name = "lblTítuloFinFA";
            this.lblTítuloFinFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloFinFA.TabIndex = 11;
            // 
            // lblTítuloInicioFA
            // 
            this.lblTítuloInicioFA.AutoSize = true;
            this.lblTítuloInicioFA.Location = new System.Drawing.Point(116, 287);
            this.lblTítuloInicioFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloInicioFA.Name = "lblTítuloInicioFA";
            this.lblTítuloInicioFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloInicioFA.TabIndex = 10;
            // 
            // lblTítuloCedulaFA
            // 
            this.lblTítuloCedulaFA.AutoSize = true;
            this.lblTítuloCedulaFA.Location = new System.Drawing.Point(145, 234);
            this.lblTítuloCedulaFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloCedulaFA.Name = "lblTítuloCedulaFA";
            this.lblTítuloCedulaFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloCedulaFA.TabIndex = 9;
            // 
            // lblTítuloNombreFA
            // 
            this.lblTítuloNombreFA.AutoSize = true;
            this.lblTítuloNombreFA.Location = new System.Drawing.Point(149, 128);
            this.lblTítuloNombreFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloNombreFA.Name = "lblTítuloNombreFA";
            this.lblTítuloNombreFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloNombreFA.TabIndex = 8;
            // 
            // lblTítuloGradoFA
            // 
            this.lblTítuloGradoFA.AutoSize = true;
            this.lblTítuloGradoFA.Location = new System.Drawing.Point(268, 73);
            this.lblTítuloGradoFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTítuloGradoFA.Name = "lblTítuloGradoFA";
            this.lblTítuloGradoFA.Size = new System.Drawing.Size(0, 23);
            this.lblTítuloGradoFA.TabIndex = 7;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(25, 398);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(136, 24);
            this.label14.TabIndex = 6;
            this.label14.Text = "OBTENCIÓN:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 347);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(48, 24);
            this.label13.TabIndex = 5;
            this.label13.Text = "FIN:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 287);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 24);
            this.label12.TabIndex = 4;
            this.label12.Text = "INICIO:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 234);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 24);
            this.label9.TabIndex = 3;
            this.label9.Text = "CÉDULA:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 128);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 2;
            this.label8.Text = "NOMBRE:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(25, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "GRADO ACADÉMICO:";
            // 
            // msFA
            // 
            this.msFA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msFA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarFA,
            this.tsmiSeleccionarFA,
            this.tsmiEliminarFA,
            this.tsmiModificarFA});
            this.msFA.Location = new System.Drawing.Point(4, 4);
            this.msFA.Name = "msFA";
            this.msFA.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msFA.Size = new System.Drawing.Size(1093, 28);
            this.msFA.TabIndex = 0;
            this.msFA.Text = "menuStrip1";
            // 
            // tsmiAgregarFA
            // 
            this.tsmiAgregarFA.Name = "tsmiAgregarFA";
            this.tsmiAgregarFA.Size = new System.Drawing.Size(87, 24);
            this.tsmiAgregarFA.Text = "AGREGAR";
            this.tsmiAgregarFA.Click += new System.EventHandler(this.tsmiAgregarFA_Click);
            // 
            // tsmiSeleccionarFA
            // 
            this.tsmiSeleccionarFA.Name = "tsmiSeleccionarFA";
            this.tsmiSeleccionarFA.Size = new System.Drawing.Size(115, 24);
            this.tsmiSeleccionarFA.Text = "SELECCIONAR";
            this.tsmiSeleccionarFA.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiSeleccionarFA_DropDownItemClicked);
            // 
            // tsmiEliminarFA
            // 
            this.tsmiEliminarFA.Name = "tsmiEliminarFA";
            this.tsmiEliminarFA.Size = new System.Drawing.Size(87, 24);
            this.tsmiEliminarFA.Text = "ELIMINAR";
            this.tsmiEliminarFA.Click += new System.EventHandler(this.tsmiEliminarFA_Click);
            // 
            // tsmiModificarFA
            // 
            this.tsmiModificarFA.Name = "tsmiModificarFA";
            this.tsmiModificarFA.Size = new System.Drawing.Size(99, 24);
            this.tsmiModificarFA.Text = "MODIFICAR";
            this.tsmiModificarFA.Click += new System.EventHandler(this.tsmiModificarFA_Click);
            // 
            // tabPageProduccionAcademica
            // 
            this.tabPageProduccionAcademica.BackColor = System.Drawing.Color.Transparent;
            this.tabPageProduccionAcademica.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageProduccionAcademica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageProduccionAcademica.Controls.Add(this.label22);
            this.tabPageProduccionAcademica.Controls.Add(this.listViewAutoresPA);
            this.tabPageProduccionAcademica.Controls.Add(this.lblTituloNRegistroPA);
            this.tabPageProduccionAcademica.Controls.Add(this.lblTituloInstitucionPA);
            this.tabPageProduccionAcademica.Controls.Add(this.lblTituloFechaPA);
            this.tabPageProduccionAcademica.Controls.Add(this.lblTituloTituloPA);
            this.tabPageProduccionAcademica.Controls.Add(this.lblTituloCategoriaPA);
            this.tabPageProduccionAcademica.Controls.Add(this.label26);
            this.tabPageProduccionAcademica.Controls.Add(this.label27);
            this.tabPageProduccionAcademica.Controls.Add(this.label29);
            this.tabPageProduccionAcademica.Controls.Add(this.label30);
            this.tabPageProduccionAcademica.Controls.Add(this.label31);
            this.tabPageProduccionAcademica.Controls.Add(this.msPA);
            this.tabPageProduccionAcademica.Location = new System.Drawing.Point(4, 60);
            this.tabPageProduccionAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageProduccionAcademica.Name = "tabPageProduccionAcademica";
            this.tabPageProduccionAcademica.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageProduccionAcademica.Size = new System.Drawing.Size(1101, 599);
            this.tabPageProduccionAcademica.TabIndex = 5;
            this.tabPageProduccionAcademica.Text = "Producción Académica";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(557, 73);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(113, 24);
            this.label22.TabIndex = 73;
            this.label22.Text = "AUTORES:";
            // 
            // listViewAutoresPA
            // 
            this.listViewAutoresPA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listViewAutoresPA.FullRowSelect = true;
            this.listViewAutoresPA.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listViewAutoresPA.Location = new System.Drawing.Point(563, 112);
            this.listViewAutoresPA.Margin = new System.Windows.Forms.Padding(4);
            this.listViewAutoresPA.MultiSelect = false;
            this.listViewAutoresPA.Name = "listViewAutoresPA";
            this.listViewAutoresPA.Size = new System.Drawing.Size(509, 291);
            this.listViewAutoresPA.TabIndex = 72;
            this.listViewAutoresPA.UseCompatibleStateImageBehavior = false;
            this.listViewAutoresPA.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nombre";
            this.columnHeader4.Width = 116;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Apellido Paterno";
            this.columnHeader5.Width = 132;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Apellido Materno";
            this.columnHeader6.Width = 131;
            // 
            // lblTituloNRegistroPA
            // 
            this.lblTituloNRegistroPA.AutoSize = true;
            this.lblTituloNRegistroPA.Location = new System.Drawing.Point(301, 298);
            this.lblTituloNRegistroPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloNRegistroPA.Name = "lblTituloNRegistroPA";
            this.lblTituloNRegistroPA.Size = new System.Drawing.Size(0, 23);
            this.lblTituloNRegistroPA.TabIndex = 24;
            // 
            // lblTituloInstitucionPA
            // 
            this.lblTituloInstitucionPA.AutoSize = true;
            this.lblTituloInstitucionPA.Location = new System.Drawing.Point(188, 240);
            this.lblTituloInstitucionPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloInstitucionPA.Name = "lblTituloInstitucionPA";
            this.lblTituloInstitucionPA.Size = new System.Drawing.Size(0, 23);
            this.lblTituloInstitucionPA.TabIndex = 23;
            // 
            // lblTituloFechaPA
            // 
            this.lblTituloFechaPA.AutoSize = true;
            this.lblTituloFechaPA.Location = new System.Drawing.Point(131, 181);
            this.lblTituloFechaPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloFechaPA.Name = "lblTituloFechaPA";
            this.lblTituloFechaPA.Size = new System.Drawing.Size(0, 23);
            this.lblTituloFechaPA.TabIndex = 21;
            // 
            // lblTituloTituloPA
            // 
            this.lblTituloTituloPA.AutoSize = true;
            this.lblTituloTituloPA.Location = new System.Drawing.Point(128, 128);
            this.lblTituloTituloPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloTituloPA.Name = "lblTituloTituloPA";
            this.lblTituloTituloPA.Size = new System.Drawing.Size(0, 23);
            this.lblTituloTituloPA.TabIndex = 20;
            // 
            // lblTituloCategoriaPA
            // 
            this.lblTituloCategoriaPA.AutoSize = true;
            this.lblTituloCategoriaPA.Location = new System.Drawing.Point(180, 73);
            this.lblTituloCategoriaPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTituloCategoriaPA.Name = "lblTituloCategoriaPA";
            this.lblTituloCategoriaPA.Size = new System.Drawing.Size(0, 23);
            this.lblTituloCategoriaPA.TabIndex = 19;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(32, 298);
            this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(248, 24);
            this.label26.TabIndex = 18;
            this.label26.Text = "NÚMERO DE REGISTRO:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(32, 240);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(143, 24);
            this.label27.TabIndex = 17;
            this.label27.Text = "INSTITUCIÓN:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(28, 181);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 24);
            this.label29.TabIndex = 15;
            this.label29.Text = "FECHA:";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(28, 128);
            this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(91, 24);
            this.label30.TabIndex = 14;
            this.label30.Text = "TÍTULO:";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(28, 73);
            this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(134, 24);
            this.label31.TabIndex = 13;
            this.label31.Text = "CATEGORÍA:";
            // 
            // msPA
            // 
            this.msPA.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.msPA.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAgregarPA,
            this.tsmiSeleccionarPA,
            this.tsmiEliminarPA,
            this.tsmiModificarPA});
            this.msPA.Location = new System.Drawing.Point(4, 4);
            this.msPA.Name = "msPA";
            this.msPA.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.msPA.Size = new System.Drawing.Size(1093, 28);
            this.msPA.TabIndex = 1;
            this.msPA.Text = "menuStrip1";
            // 
            // tsmiAgregarPA
            // 
            this.tsmiAgregarPA.Name = "tsmiAgregarPA";
            this.tsmiAgregarPA.Size = new System.Drawing.Size(87, 24);
            this.tsmiAgregarPA.Text = "AGREGAR";
            this.tsmiAgregarPA.Click += new System.EventHandler(this.tsmiAgregarPA_Click);
            // 
            // tsmiSeleccionarPA
            // 
            this.tsmiSeleccionarPA.Name = "tsmiSeleccionarPA";
            this.tsmiSeleccionarPA.Size = new System.Drawing.Size(115, 24);
            this.tsmiSeleccionarPA.Text = "SELECCIONAR";
            this.tsmiSeleccionarPA.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsmiSeleccionarPA_DropDownItemClicked);
            // 
            // tsmiEliminarPA
            // 
            this.tsmiEliminarPA.Name = "tsmiEliminarPA";
            this.tsmiEliminarPA.Size = new System.Drawing.Size(87, 24);
            this.tsmiEliminarPA.Text = "ELIMINAR";
            this.tsmiEliminarPA.Click += new System.EventHandler(this.tsmiEliminarPA_Click);
            // 
            // tsmiModificarPA
            // 
            this.tsmiModificarPA.Name = "tsmiModificarPA";
            this.tsmiModificarPA.Size = new System.Drawing.Size(99, 24);
            this.tsmiModificarPA.Text = "MODIFICAR";
            this.tsmiModificarPA.Click += new System.EventHandler(this.tsmiModificarPA_Click);
            // 
            // tabPageCargaAcademica
            // 
            this.tabPageCargaAcademica.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCargaAcademica.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageCargaAcademica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCargaAcademica.Controls.Add(this.btnModificarCA);
            this.tabPageCargaAcademica.Controls.Add(this.btnEliminarCA);
            this.tabPageCargaAcademica.Controls.Add(this.btnAgregarCA);
            this.tabPageCargaAcademica.Controls.Add(this.label23);
            this.tabPageCargaAcademica.Controls.Add(this.lvwCargaAcademica);
            this.tabPageCargaAcademica.Location = new System.Drawing.Point(4, 60);
            this.tabPageCargaAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCargaAcademica.Name = "tabPageCargaAcademica";
            this.tabPageCargaAcademica.Size = new System.Drawing.Size(1101, 599);
            this.tabPageCargaAcademica.TabIndex = 7;
            this.tabPageCargaAcademica.Text = "Carga Académica";
            // 
            // btnModificarCA
            // 
            this.btnModificarCA.Enabled = false;
            this.btnModificarCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCA.Location = new System.Drawing.Point(283, 469);
            this.btnModificarCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarCA.Name = "btnModificarCA";
            this.btnModificarCA.Size = new System.Drawing.Size(124, 44);
            this.btnModificarCA.TabIndex = 91;
            this.btnModificarCA.Text = "Modificar";
            this.btnModificarCA.UseVisualStyleBackColor = true;
            this.btnModificarCA.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarCA
            // 
            this.btnEliminarCA.Enabled = false;
            this.btnEliminarCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarCA.Location = new System.Drawing.Point(149, 469);
            this.btnEliminarCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarCA.Name = "btnEliminarCA";
            this.btnEliminarCA.Size = new System.Drawing.Size(109, 44);
            this.btnEliminarCA.TabIndex = 90;
            this.btnEliminarCA.Text = "Eliminar";
            this.btnEliminarCA.UseVisualStyleBackColor = true;
            this.btnEliminarCA.Click += new System.EventHandler(this.btnEliminarCA_Click);
            // 
            // btnAgregarCA
            // 
            this.btnAgregarCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCA.Location = new System.Drawing.Point(16, 469);
            this.btnAgregarCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarCA.Name = "btnAgregarCA";
            this.btnAgregarCA.Size = new System.Drawing.Size(111, 44);
            this.btnAgregarCA.TabIndex = 89;
            this.btnAgregarCA.Text = "Agregar";
            this.btnAgregarCA.UseVisualStyleBackColor = true;
            this.btnAgregarCA.Click += new System.EventHandler(this.btnAgregarCA_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(12, 41);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(212, 24);
            this.label23.TabIndex = 88;
            this.label23.Text = "CARGA   ACADÉMICA";
            // 
            // lvwCargaAcademica
            // 
            this.lvwCargaAcademica.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11});
            this.lvwCargaAcademica.FullRowSelect = true;
            this.lvwCargaAcademica.Location = new System.Drawing.Point(16, 81);
            this.lvwCargaAcademica.Margin = new System.Windows.Forms.Padding(4);
            this.lvwCargaAcademica.MultiSelect = false;
            this.lvwCargaAcademica.Name = "lvwCargaAcademica";
            this.lvwCargaAcademica.Size = new System.Drawing.Size(1040, 366);
            this.lvwCargaAcademica.TabIndex = 87;
            this.lvwCargaAcademica.UseCompatibleStateImageBehavior = false;
            this.lvwCargaAcademica.View = System.Windows.Forms.View.Details;
            this.lvwCargaAcademica.SelectedIndexChanged += new System.EventHandler(this.lvwCargaAcademica_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "NOMBRE";
            this.columnHeader7.Width = 204;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "FECHA INICIO";
            this.columnHeader8.Width = 115;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "FECHA FIN";
            this.columnHeader9.Width = 112;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "PROGRAMA EDUCATIVO";
            this.columnHeader10.Width = 200;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "CARGA HORARIA";
            this.columnHeader11.Width = 146;
            // 
            // tabPageControlFA
            // 
            this.tabPageControlFA.BackColor = System.Drawing.Color.Transparent;
            this.tabPageControlFA.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageControlFA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageControlFA.Controls.Add(this.lblVerificarFechasFinObtencion);
            this.tabPageControlFA.Controls.Add(this.lblVerificarFechasInicioFin);
            this.tabPageControlFA.Controls.Add(this.btnCancelarFA);
            this.tabPageControlFA.Controls.Add(this.cboGradoAcademico);
            this.tabPageControlFA.Controls.Add(this.lblVerificarCedula);
            this.tabPageControlFA.Controls.Add(this.dtpObtenciónFA);
            this.tabPageControlFA.Controls.Add(this.dtpFinFA);
            this.tabPageControlFA.Controls.Add(this.dtpInicioFA);
            this.tabPageControlFA.Controls.Add(this.label11);
            this.tabPageControlFA.Controls.Add(this.label16);
            this.tabPageControlFA.Controls.Add(this.labelApellidoM);
            this.tabPageControlFA.Controls.Add(this.lblVerificarInstitucion);
            this.tabPageControlFA.Controls.Add(this.lblVerificarNombreFA);
            this.tabPageControlFA.Controls.Add(this.lblVerificarGA);
            this.tabPageControlFA.Controls.Add(this.labelApellidoP);
            this.tabPageControlFA.Controls.Add(this.txbInstitucion);
            this.tabPageControlFA.Controls.Add(this.btnControlFA);
            this.tabPageControlFA.Controls.Add(this.labelContraseña);
            this.tabPageControlFA.Controls.Add(this.labelNombre);
            this.tabPageControlFA.Controls.Add(this.labelCodigo);
            this.tabPageControlFA.Controls.Add(this.txbCedulaFA);
            this.tabPageControlFA.Controls.Add(this.txbNombreFA);
            this.tabPageControlFA.Controls.Add(this.labelTítuloControlFA);
            this.tabPageControlFA.Location = new System.Drawing.Point(4, 60);
            this.tabPageControlFA.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageControlFA.Name = "tabPageControlFA";
            this.tabPageControlFA.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageControlFA.Size = new System.Drawing.Size(1101, 599);
            this.tabPageControlFA.TabIndex = 4;
            this.tabPageControlFA.Text = "Control FA";
            // 
            // lblVerificarFechasFinObtencion
            // 
            this.lblVerificarFechasFinObtencion.AutoSize = true;
            this.lblVerificarFechasFinObtencion.Location = new System.Drawing.Point(557, 309);
            this.lblVerificarFechasFinObtencion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarFechasFinObtencion.Name = "lblVerificarFechasFinObtencion";
            this.lblVerificarFechasFinObtencion.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarFechasFinObtencion.TabIndex = 42;
            // 
            // lblVerificarFechasInicioFin
            // 
            this.lblVerificarFechasInicioFin.AutoSize = true;
            this.lblVerificarFechasInicioFin.Location = new System.Drawing.Point(557, 270);
            this.lblVerificarFechasInicioFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarFechasInicioFin.Name = "lblVerificarFechasInicioFin";
            this.lblVerificarFechasInicioFin.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarFechasInicioFin.TabIndex = 41;
            // 
            // btnCancelarFA
            // 
            this.btnCancelarFA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarFA.Location = new System.Drawing.Point(543, 410);
            this.btnCancelarFA.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarFA.Name = "btnCancelarFA";
            this.btnCancelarFA.Size = new System.Drawing.Size(117, 41);
            this.btnCancelarFA.TabIndex = 8;
            this.btnCancelarFA.Text = "Cancelar";
            this.btnCancelarFA.UseVisualStyleBackColor = true;
            this.btnCancelarFA.Click += new System.EventHandler(this.btnCancelarFA_Click);
            // 
            // cboGradoAcademico
            // 
            this.cboGradoAcademico.FormattingEnabled = true;
            this.cboGradoAcademico.Items.AddRange(new object[] {
            "LICENCIATURA",
            "ESPECIALIDAD",
            "MAESTRÍA",
            "DOCTORADO"});
            this.cboGradoAcademico.Location = new System.Drawing.Point(416, 105);
            this.cboGradoAcademico.Margin = new System.Windows.Forms.Padding(4);
            this.cboGradoAcademico.Name = "cboGradoAcademico";
            this.cboGradoAcademico.Size = new System.Drawing.Size(256, 31);
            this.cboGradoAcademico.TabIndex = 0;
            this.cboGradoAcademico.SelectedIndexChanged += new System.EventHandler(this.cboGradoAcademico_SelectedIndexChanged);
            // 
            // lblVerificarCedula
            // 
            this.lblVerificarCedula.AutoSize = true;
            this.lblVerificarCedula.Location = new System.Drawing.Point(675, 351);
            this.lblVerificarCedula.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarCedula.Name = "lblVerificarCedula";
            this.lblVerificarCedula.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarCedula.TabIndex = 38;
            // 
            // dtpObtenciónFA
            // 
            this.dtpObtenciónFA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpObtenciónFA.Location = new System.Drawing.Point(417, 302);
            this.dtpObtenciónFA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpObtenciónFA.MaxDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.dtpObtenciónFA.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpObtenciónFA.Name = "dtpObtenciónFA";
            this.dtpObtenciónFA.Size = new System.Drawing.Size(131, 30);
            this.dtpObtenciónFA.TabIndex = 5;
            this.dtpObtenciónFA.Value = new System.DateTime(2018, 5, 14, 0, 0, 0, 0);
            this.dtpObtenciónFA.ValueChanged += new System.EventHandler(this.dtpObtenciónFA_ValueChanged);
            // 
            // dtpFinFA
            // 
            this.dtpFinFA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinFA.Location = new System.Drawing.Point(417, 262);
            this.dtpFinFA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinFA.MaxDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.dtpFinFA.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpFinFA.Name = "dtpFinFA";
            this.dtpFinFA.Size = new System.Drawing.Size(131, 30);
            this.dtpFinFA.TabIndex = 4;
            this.dtpFinFA.Value = new System.DateTime(2018, 5, 14, 0, 0, 0, 0);
            this.dtpFinFA.ValueChanged += new System.EventHandler(this.dtpFinFA_ValueChanged);
            // 
            // dtpInicioFA
            // 
            this.dtpInicioFA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioFA.Location = new System.Drawing.Point(417, 223);
            this.dtpInicioFA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicioFA.MaxDate = new System.DateTime(2018, 5, 15, 0, 0, 0, 0);
            this.dtpInicioFA.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.dtpInicioFA.Name = "dtpInicioFA";
            this.dtpInicioFA.Size = new System.Drawing.Size(131, 30);
            this.dtpInicioFA.TabIndex = 3;
            this.dtpInicioFA.Value = new System.DateTime(2018, 5, 14, 0, 0, 0, 0);
            this.dtpInicioFA.ValueChanged += new System.EventHandler(this.dtpInicioFA_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(267, 308);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 24);
            this.label11.TabIndex = 34;
            this.label11.Text = "Obtención:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(340, 271);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 24);
            this.label16.TabIndex = 33;
            this.label16.Text = "Fin:";
            // 
            // labelApellidoM
            // 
            this.labelApellidoM.AutoSize = true;
            this.labelApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoM.Location = new System.Drawing.Point(317, 230);
            this.labelApellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoM.Name = "labelApellidoM";
            this.labelApellidoM.Size = new System.Drawing.Size(67, 24);
            this.labelApellidoM.TabIndex = 32;
            this.labelApellidoM.Text = "Inicio:";
            // 
            // lblVerificarInstitucion
            // 
            this.lblVerificarInstitucion.AutoSize = true;
            this.lblVerificarInstitucion.Location = new System.Drawing.Point(696, 187);
            this.lblVerificarInstitucion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarInstitucion.Name = "lblVerificarInstitucion";
            this.lblVerificarInstitucion.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarInstitucion.TabIndex = 31;
            // 
            // lblVerificarNombreFA
            // 
            this.lblVerificarNombreFA.AutoSize = true;
            this.lblVerificarNombreFA.Location = new System.Drawing.Point(696, 151);
            this.lblVerificarNombreFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarNombreFA.Name = "lblVerificarNombreFA";
            this.lblVerificarNombreFA.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarNombreFA.TabIndex = 30;
            // 
            // lblVerificarGA
            // 
            this.lblVerificarGA.AutoSize = true;
            this.lblVerificarGA.Location = new System.Drawing.Point(696, 110);
            this.lblVerificarGA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarGA.Name = "lblVerificarGA";
            this.lblVerificarGA.Size = new System.Drawing.Size(0, 23);
            this.lblVerificarGA.TabIndex = 29;
            // 
            // labelApellidoP
            // 
            this.labelApellidoP.AutoSize = true;
            this.labelApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoP.Location = new System.Drawing.Point(101, 187);
            this.labelApellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoP.Name = "labelApellidoP";
            this.labelApellidoP.Size = new System.Drawing.Size(268, 24);
            this.labelApellidoP.TabIndex = 28;
            this.labelApellidoP.Text = "Institución de Procedencia:";
            // 
            // txbInstitucion
            // 
            this.txbInstitucion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInstitucion.Location = new System.Drawing.Point(416, 183);
            this.txbInstitucion.Margin = new System.Windows.Forms.Padding(4);
            this.txbInstitucion.Name = "txbInstitucion";
            this.txbInstitucion.Size = new System.Drawing.Size(257, 30);
            this.txbInstitucion.TabIndex = 2;
            this.txbInstitucion.TextChanged += new System.EventHandler(this.textBoxInstitucion_TextChanged);
            // 
            // btnControlFA
            // 
            this.btnControlFA.Enabled = false;
            this.btnControlFA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlFA.Location = new System.Drawing.Point(417, 410);
            this.btnControlFA.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlFA.Name = "btnControlFA";
            this.btnControlFA.Size = new System.Drawing.Size(117, 41);
            this.btnControlFA.TabIndex = 7;
            this.btnControlFA.Text = "button";
            this.btnControlFA.UseVisualStyleBackColor = true;
            this.btnControlFA.Click += new System.EventHandler(this.btnControlFA_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(179, 345);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(195, 24);
            this.labelContraseña.TabIndex = 27;
            this.labelContraseña.Text = "Cédula Profesional:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(291, 148);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(91, 24);
            this.labelNombre.TabIndex = 24;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(192, 108);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(184, 24);
            this.labelCodigo.TabIndex = 23;
            this.labelCodigo.Text = "Grado Académico:";
            // 
            // txbCedulaFA
            // 
            this.txbCedulaFA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCedulaFA.Location = new System.Drawing.Point(417, 341);
            this.txbCedulaFA.Margin = new System.Windows.Forms.Padding(4);
            this.txbCedulaFA.Name = "txbCedulaFA";
            this.txbCedulaFA.Size = new System.Drawing.Size(256, 30);
            this.txbCedulaFA.TabIndex = 6;
            this.txbCedulaFA.TextChanged += new System.EventHandler(this.textBoxCédula_TextChanged);
            // 
            // txbNombreFA
            // 
            this.txbNombreFA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreFA.Location = new System.Drawing.Point(416, 144);
            this.txbNombreFA.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombreFA.Name = "txbNombreFA";
            this.txbNombreFA.Size = new System.Drawing.Size(257, 30);
            this.txbNombreFA.TabIndex = 1;
            this.txbNombreFA.TextChanged += new System.EventHandler(this.textBoxNombreFA_TextChanged);
            // 
            // labelTítuloControlFA
            // 
            this.labelTítuloControlFA.AutoSize = true;
            this.labelTítuloControlFA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítuloControlFA.Location = new System.Drawing.Point(380, 34);
            this.labelTítuloControlFA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTítuloControlFA.Name = "labelTítuloControlFA";
            this.labelTítuloControlFA.Size = new System.Drawing.Size(65, 24);
            this.labelTítuloControlFA.TabIndex = 18;
            this.labelTítuloControlFA.Text = "Título";
            // 
            // tabPageControlPA
            // 
            this.tabPageControlPA.BackColor = System.Drawing.Color.Transparent;
            this.tabPageControlPA.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageControlPA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageControlPA.Controls.Add(this.lblValidarAutores);
            this.tabPageControlPA.Controls.Add(this.btnEliminarAutorPA);
            this.tabPageControlPA.Controls.Add(this.lvwAutoresPA);
            this.tabPageControlPA.Controls.Add(this.btnAgregarAutorPA);
            this.tabPageControlPA.Controls.Add(this.label17);
            this.tabPageControlPA.Controls.Add(this.dtpFechaPA);
            this.tabPageControlPA.Controls.Add(this.lblVerificarInstitucionPA);
            this.tabPageControlPA.Controls.Add(this.txbInstitucionPA);
            this.tabPageControlPA.Controls.Add(this.btnCancelarAgregarPA);
            this.tabPageControlPA.Controls.Add(this.cboCategoriaPA);
            this.tabPageControlPA.Controls.Add(this.lblVerificarNRegistroPA);
            this.tabPageControlPA.Controls.Add(this.label18);
            this.tabPageControlPA.Controls.Add(this.lblVerificarTituloPA);
            this.tabPageControlPA.Controls.Add(this.lblVerificarCategoriaPA);
            this.tabPageControlPA.Controls.Add(this.label33);
            this.tabPageControlPA.Controls.Add(this.btnControlPA);
            this.tabPageControlPA.Controls.Add(this.label34);
            this.tabPageControlPA.Controls.Add(this.label35);
            this.tabPageControlPA.Controls.Add(this.label36);
            this.tabPageControlPA.Controls.Add(this.txbNRegistroPA);
            this.tabPageControlPA.Controls.Add(this.txbTituloPA);
            this.tabPageControlPA.Controls.Add(this.labelTituloPA);
            this.tabPageControlPA.Location = new System.Drawing.Point(4, 60);
            this.tabPageControlPA.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageControlPA.Name = "tabPageControlPA";
            this.tabPageControlPA.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageControlPA.Size = new System.Drawing.Size(1101, 599);
            this.tabPageControlPA.TabIndex = 6;
            this.tabPageControlPA.Text = "Control PA";
            // 
            // lblValidarAutores
            // 
            this.lblValidarAutores.AutoSize = true;
            this.lblValidarAutores.ForeColor = System.Drawing.Color.Red;
            this.lblValidarAutores.Location = new System.Drawing.Point(724, 37);
            this.lblValidarAutores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblValidarAutores.Name = "lblValidarAutores";
            this.lblValidarAutores.Size = new System.Drawing.Size(10, 23);
            this.lblValidarAutores.TabIndex = 73;
            this.lblValidarAutores.Text = "\r\n";
            // 
            // btnEliminarAutorPA
            // 
            this.btnEliminarAutorPA.Enabled = false;
            this.btnEliminarAutorPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAutorPA.Location = new System.Drawing.Point(839, 361);
            this.btnEliminarAutorPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarAutorPA.Name = "btnEliminarAutorPA";
            this.btnEliminarAutorPA.Size = new System.Drawing.Size(113, 42);
            this.btnEliminarAutorPA.TabIndex = 8;
            this.btnEliminarAutorPA.Text = "Eliminar";
            this.btnEliminarAutorPA.UseVisualStyleBackColor = true;
            this.btnEliminarAutorPA.Click += new System.EventHandler(this.btnEliminarAutorPA_Click);
            // 
            // lvwAutoresPA
            // 
            this.lvwAutoresPA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvwAutoresPA.FullRowSelect = true;
            this.lvwAutoresPA.ImeMode = System.Windows.Forms.ImeMode.On;
            this.lvwAutoresPA.Location = new System.Drawing.Point(561, 63);
            this.lvwAutoresPA.Margin = new System.Windows.Forms.Padding(4);
            this.lvwAutoresPA.MultiSelect = false;
            this.lvwAutoresPA.Name = "lvwAutoresPA";
            this.lvwAutoresPA.Size = new System.Drawing.Size(509, 291);
            this.lvwAutoresPA.TabIndex = 71;
            this.lvwAutoresPA.UseCompatibleStateImageBehavior = false;
            this.lvwAutoresPA.View = System.Windows.Forms.View.Details;
            this.lvwAutoresPA.SelectedIndexChanged += new System.EventHandler(this.lvwAutoresPA_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nombre";
            this.columnHeader1.Width = 116;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Apellido Paterno";
            this.columnHeader2.Width = 132;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Apellido Materno";
            this.columnHeader3.Width = 131;
            // 
            // btnAgregarAutorPA
            // 
            this.btnAgregarAutorPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAutorPA.Location = new System.Drawing.Point(676, 361);
            this.btnAgregarAutorPA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarAutorPA.Name = "btnAgregarAutorPA";
            this.btnAgregarAutorPA.Size = new System.Drawing.Size(113, 42);
            this.btnAgregarAutorPA.TabIndex = 7;
            this.btnAgregarAutorPA.Text = "Agregar";
            this.btnAgregarAutorPA.UseVisualStyleBackColor = true;
            this.btnAgregarAutorPA.Click += new System.EventHandler(this.btnAgregarAutorPA_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(628, 37);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(91, 24);
            this.label17.TabIndex = 69;
            this.label17.Text = "Autores:";
            // 
            // dtpFechaPA
            // 
            this.dtpFechaPA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaPA.Location = new System.Drawing.Point(244, 142);
            this.dtpFechaPA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPA.Name = "dtpFechaPA";
            this.dtpFechaPA.Size = new System.Drawing.Size(208, 30);
            this.dtpFechaPA.TabIndex = 2;
            // 
            // lblVerificarInstitucionPA
            // 
            this.lblVerificarInstitucionPA.AutoSize = true;
            this.lblVerificarInstitucionPA.Location = new System.Drawing.Point(461, 185);
            this.lblVerificarInstitucionPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarInstitucionPA.Name = "lblVerificarInstitucionPA";
            this.lblVerificarInstitucionPA.Size = new System.Drawing.Size(10, 23);
            this.lblVerificarInstitucionPA.TabIndex = 67;
            this.lblVerificarInstitucionPA.Text = "\r\n";
            // 
            // txbInstitucionPA
            // 
            this.txbInstitucionPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbInstitucionPA.Location = new System.Drawing.Point(244, 181);
            this.txbInstitucionPA.Margin = new System.Windows.Forms.Padding(4);
            this.txbInstitucionPA.Name = "txbInstitucionPA";
            this.txbInstitucionPA.Size = new System.Drawing.Size(209, 30);
            this.txbInstitucionPA.TabIndex = 3;
            this.txbInstitucionPA.TextChanged += new System.EventHandler(this.txbInstitucionPA_TextChanged);
            // 
            // btnCancelarAgregarPA
            // 
            this.btnCancelarAgregarPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarAgregarPA.Location = new System.Drawing.Point(281, 293);
            this.btnCancelarAgregarPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarAgregarPA.Name = "btnCancelarAgregarPA";
            this.btnCancelarAgregarPA.Size = new System.Drawing.Size(117, 41);
            this.btnCancelarAgregarPA.TabIndex = 6;
            this.btnCancelarAgregarPA.Text = "Cancelar";
            this.btnCancelarAgregarPA.UseVisualStyleBackColor = true;
            this.btnCancelarAgregarPA.Click += new System.EventHandler(this.btnCancelarAgregarPA_Click);
            // 
            // cboCategoriaPA
            // 
            this.cboCategoriaPA.FormattingEnabled = true;
            this.cboCategoriaPA.Items.AddRange(new object[] {
            "CAPÍTULO DE LIBRO",
            "LIBRO",
            "ARTÍCULO",
            "INFORME",
            "DESARROLLO DE SOFTWARE"});
            this.cboCategoriaPA.Location = new System.Drawing.Point(243, 63);
            this.cboCategoriaPA.Margin = new System.Windows.Forms.Padding(4);
            this.cboCategoriaPA.Name = "cboCategoriaPA";
            this.cboCategoriaPA.Size = new System.Drawing.Size(211, 31);
            this.cboCategoriaPA.TabIndex = 0;
            this.cboCategoriaPA.SelectedIndexChanged += new System.EventHandler(this.cboCategoriaPA_SelectedIndexChanged);
            // 
            // lblVerificarNRegistroPA
            // 
            this.lblVerificarNRegistroPA.AutoSize = true;
            this.lblVerificarNRegistroPA.Location = new System.Drawing.Point(461, 226);
            this.lblVerificarNRegistroPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarNRegistroPA.Name = "lblVerificarNRegistroPA";
            this.lblVerificarNRegistroPA.Size = new System.Drawing.Size(10, 23);
            this.lblVerificarNRegistroPA.TabIndex = 59;
            this.lblVerificarNRegistroPA.Text = "\r\n";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(103, 190);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(116, 24);
            this.label18.TabIndex = 55;
            this.label18.Text = "Institución:";
            // 
            // lblVerificarTituloPA
            // 
            this.lblVerificarTituloPA.AutoSize = true;
            this.lblVerificarTituloPA.Location = new System.Drawing.Point(461, 106);
            this.lblVerificarTituloPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarTituloPA.Name = "lblVerificarTituloPA";
            this.lblVerificarTituloPA.Size = new System.Drawing.Size(10, 23);
            this.lblVerificarTituloPA.TabIndex = 51;
            this.lblVerificarTituloPA.Text = "\r\n";
            // 
            // lblVerificarCategoriaPA
            // 
            this.lblVerificarCategoriaPA.AutoSize = true;
            this.lblVerificarCategoriaPA.Location = new System.Drawing.Point(461, 66);
            this.lblVerificarCategoriaPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificarCategoriaPA.Name = "lblVerificarCategoriaPA";
            this.lblVerificarCategoriaPA.Size = new System.Drawing.Size(10, 23);
            this.lblVerificarCategoriaPA.TabIndex = 50;
            this.lblVerificarCategoriaPA.Text = "\r\n";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(147, 149);
            this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 24);
            this.label33.TabIndex = 49;
            this.label33.Text = "Fecha:";
            // 
            // btnControlPA
            // 
            this.btnControlPA.Enabled = false;
            this.btnControlPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlPA.Location = new System.Drawing.Point(156, 293);
            this.btnControlPA.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlPA.Name = "btnControlPA";
            this.btnControlPA.Size = new System.Drawing.Size(117, 41);
            this.btnControlPA.TabIndex = 5;
            this.btnControlPA.Text = "button";
            this.btnControlPA.UseVisualStyleBackColor = true;
            this.btnControlPA.Click += new System.EventHandler(this.btnControlPA_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label34.Location = new System.Drawing.Point(5, 226);
            this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(206, 24);
            this.label34.TabIndex = 48;
            this.label34.Text = "Número de Registro:";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(152, 106);
            this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(72, 24);
            this.label35.TabIndex = 45;
            this.label35.Text = "Título:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label36.Location = new System.Drawing.Point(111, 66);
            this.label36.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(109, 24);
            this.label36.TabIndex = 44;
            this.label36.Text = "Categoría:";
            // 
            // txbNRegistroPA
            // 
            this.txbNRegistroPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNRegistroPA.Location = new System.Drawing.Point(244, 223);
            this.txbNRegistroPA.Margin = new System.Windows.Forms.Padding(4);
            this.txbNRegistroPA.Name = "txbNRegistroPA";
            this.txbNRegistroPA.Size = new System.Drawing.Size(208, 30);
            this.txbNRegistroPA.TabIndex = 4;
            this.txbNRegistroPA.TextChanged += new System.EventHandler(this.txbNRegistroPA_TextChanged);
            // 
            // txbTituloPA
            // 
            this.txbTituloPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTituloPA.Location = new System.Drawing.Point(243, 102);
            this.txbTituloPA.Margin = new System.Windows.Forms.Padding(4);
            this.txbTituloPA.Name = "txbTituloPA";
            this.txbTituloPA.Size = new System.Drawing.Size(209, 30);
            this.txbTituloPA.TabIndex = 1;
            this.txbTituloPA.TextChanged += new System.EventHandler(this.txbTituloPA_TextChanged);
            // 
            // labelTituloPA
            // 
            this.labelTituloPA.AutoSize = true;
            this.labelTituloPA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTituloPA.Location = new System.Drawing.Point(21, 31);
            this.labelTituloPA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloPA.Name = "labelTituloPA";
            this.labelTituloPA.Size = new System.Drawing.Size(65, 24);
            this.labelTituloPA.TabIndex = 41;
            this.labelTituloPA.Text = "Título";
            // 
            // tabPageControlCA
            // 
            this.tabPageControlCA.BackColor = System.Drawing.Color.Transparent;
            this.tabPageControlCA.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageControlCA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageControlCA.Controls.Add(this.labelTítuloControlCA);
            this.tabPageControlCA.Controls.Add(this.btnCancelarCA);
            this.tabPageControlCA.Controls.Add(this.btnControlCA);
            this.tabPageControlCA.Controls.Add(this.dtpFinCA);
            this.tabPageControlCA.Controls.Add(this.dtpInicioCA);
            this.tabPageControlCA.Controls.Add(this.txbProgramaEducativoCA);
            this.tabPageControlCA.Controls.Add(this.txbNombreCA);
            this.tabPageControlCA.Controls.Add(this.txbCargaHorariaCA);
            this.tabPageControlCA.Controls.Add(this.lblVerificarProgramaEducativoCA);
            this.tabPageControlCA.Controls.Add(this.label25);
            this.tabPageControlCA.Controls.Add(this.lblVerificarFechasCA);
            this.tabPageControlCA.Controls.Add(this.lblVerificarNombreCA);
            this.tabPageControlCA.Controls.Add(this.lblVerificarCargaHorariaCA);
            this.tabPageControlCA.Controls.Add(this.label38);
            this.tabPageControlCA.Controls.Add(this.label39);
            this.tabPageControlCA.Controls.Add(this.label40);
            this.tabPageControlCA.Controls.Add(this.label41);
            this.tabPageControlCA.Location = new System.Drawing.Point(4, 60);
            this.tabPageControlCA.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageControlCA.Name = "tabPageControlCA";
            this.tabPageControlCA.Size = new System.Drawing.Size(1101, 599);
            this.tabPageControlCA.TabIndex = 8;
            this.tabPageControlCA.Text = "Control CA";
            // 
            // labelTítuloControlCA
            // 
            this.labelTítuloControlCA.AutoSize = true;
            this.labelTítuloControlCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítuloControlCA.Location = new System.Drawing.Point(35, 20);
            this.labelTítuloControlCA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTítuloControlCA.Name = "labelTítuloControlCA";
            this.labelTítuloControlCA.Size = new System.Drawing.Size(76, 24);
            this.labelTítuloControlCA.TabIndex = 43;
            this.labelTítuloControlCA.Text = "label24";
            // 
            // btnCancelarCA
            // 
            this.btnCancelarCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarCA.Location = new System.Drawing.Point(404, 288);
            this.btnCancelarCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarCA.Name = "btnCancelarCA";
            this.btnCancelarCA.Size = new System.Drawing.Size(117, 41);
            this.btnCancelarCA.TabIndex = 6;
            this.btnCancelarCA.Text = "Cancelar";
            this.btnCancelarCA.UseVisualStyleBackColor = true;
            this.btnCancelarCA.Click += new System.EventHandler(this.btnCancelarCA_Click);
            // 
            // btnControlCA
            // 
            this.btnControlCA.Enabled = false;
            this.btnControlCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlCA.Location = new System.Drawing.Point(263, 288);
            this.btnControlCA.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlCA.Name = "btnControlCA";
            this.btnControlCA.Size = new System.Drawing.Size(117, 41);
            this.btnControlCA.TabIndex = 5;
            this.btnControlCA.Text = "button";
            this.btnControlCA.UseVisualStyleBackColor = true;
            this.btnControlCA.Click += new System.EventHandler(this.btnControlCA_Click);
            // 
            // dtpFinCA
            // 
            this.dtpFinCA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinCA.Location = new System.Drawing.Point(301, 139);
            this.dtpFinCA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinCA.Name = "dtpFinCA";
            this.dtpFinCA.Size = new System.Drawing.Size(141, 30);
            this.dtpFinCA.TabIndex = 2;
            this.dtpFinCA.ValueChanged += new System.EventHandler(this.dtpFinCA_ValueChanged);
            // 
            // dtpInicioCA
            // 
            this.dtpInicioCA.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioCA.Location = new System.Drawing.Point(301, 100);
            this.dtpInicioCA.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicioCA.Name = "dtpInicioCA";
            this.dtpInicioCA.Size = new System.Drawing.Size(141, 30);
            this.dtpInicioCA.TabIndex = 1;
            this.dtpInicioCA.ValueChanged += new System.EventHandler(this.dtpInicioCA_ValueChanged);
            // 
            // txbProgramaEducativoCA
            // 
            this.txbProgramaEducativoCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbProgramaEducativoCA.Location = new System.Drawing.Point(301, 178);
            this.txbProgramaEducativoCA.Margin = new System.Windows.Forms.Padding(4);
            this.txbProgramaEducativoCA.Name = "txbProgramaEducativoCA";
            this.txbProgramaEducativoCA.Size = new System.Drawing.Size(323, 30);
            this.txbProgramaEducativoCA.TabIndex = 3;
            this.txbProgramaEducativoCA.TextChanged += new System.EventHandler(this.txbProgramaEducativoCA_TextChanged);
            // 
            // txbNombreCA
            // 
            this.txbNombreCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreCA.Location = new System.Drawing.Point(301, 60);
            this.txbNombreCA.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombreCA.Name = "txbNombreCA";
            this.txbNombreCA.Size = new System.Drawing.Size(323, 30);
            this.txbNombreCA.TabIndex = 0;
            this.txbNombreCA.TextChanged += new System.EventHandler(this.txbNombreCA_TextChanged);
            // 
            // txbCargaHorariaCA
            // 
            this.txbCargaHorariaCA.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCargaHorariaCA.Location = new System.Drawing.Point(301, 218);
            this.txbCargaHorariaCA.Margin = new System.Windows.Forms.Padding(4);
            this.txbCargaHorariaCA.Name = "txbCargaHorariaCA";
            this.txbCargaHorariaCA.Size = new System.Drawing.Size(113, 30);
            this.txbCargaHorariaCA.TabIndex = 4;
            this.txbCargaHorariaCA.TextChanged += new System.EventHandler(this.txbCargaHoraria_TextChanged);
            // 
            // lblVerificarProgramaEducativoCA
            // 
            this.lblVerificarProgramaEducativoCA.AutoSize = true;
            this.lblVerificarProgramaEducativoCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarProgramaEducativoCA.Location = new System.Drawing.Point(632, 187);
            this.lblVerificarProgramaEducativoCA.Name = "lblVerificarProgramaEducativoCA";
            this.lblVerificarProgramaEducativoCA.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarProgramaEducativoCA.TabIndex = 29;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(55, 182);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(209, 24);
            this.label25.TabIndex = 28;
            this.label25.Text = "Programa Educativo:";
            // 
            // lblVerificarFechasCA
            // 
            this.lblVerificarFechasCA.AutoSize = true;
            this.lblVerificarFechasCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarFechasCA.Location = new System.Drawing.Point(451, 128);
            this.lblVerificarFechasCA.Name = "lblVerificarFechasCA";
            this.lblVerificarFechasCA.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarFechasCA.TabIndex = 27;
            // 
            // lblVerificarNombreCA
            // 
            this.lblVerificarNombreCA.AutoSize = true;
            this.lblVerificarNombreCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarNombreCA.Location = new System.Drawing.Point(632, 70);
            this.lblVerificarNombreCA.Name = "lblVerificarNombreCA";
            this.lblVerificarNombreCA.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarNombreCA.TabIndex = 26;
            // 
            // lblVerificarCargaHorariaCA
            // 
            this.lblVerificarCargaHorariaCA.AutoSize = true;
            this.lblVerificarCargaHorariaCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarCargaHorariaCA.Location = new System.Drawing.Point(423, 228);
            this.lblVerificarCargaHorariaCA.Name = "lblVerificarCargaHorariaCA";
            this.lblVerificarCargaHorariaCA.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarCargaHorariaCA.TabIndex = 25;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label38.Location = new System.Drawing.Point(231, 146);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(46, 24);
            this.label38.TabIndex = 24;
            this.label38.Text = "Fin:";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label39.Location = new System.Drawing.Point(208, 107);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(67, 24);
            this.label39.TabIndex = 23;
            this.label39.Text = "Inicio:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label40.Location = new System.Drawing.Point(35, 220);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(234, 24);
            this.label40.TabIndex = 22;
            this.label40.Text = "Carga Horaria Semanal:";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label41.Location = new System.Drawing.Point(176, 69);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(97, 24);
            this.label41.TabIndex = 21;
            this.label41.Text = "Nombre: ";
            // 
            // tabPageTutorados
            // 
            this.tabPageTutorados.BackColor = System.Drawing.Color.Transparent;
            this.tabPageTutorados.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageTutorados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageTutorados.Controls.Add(this.btnModificarTU);
            this.tabPageTutorados.Controls.Add(this.btnEliminarTU);
            this.tabPageTutorados.Controls.Add(this.btnAgregarTU);
            this.tabPageTutorados.Controls.Add(this.label24);
            this.tabPageTutorados.Controls.Add(this.lvwTutorados);
            this.tabPageTutorados.Location = new System.Drawing.Point(4, 60);
            this.tabPageTutorados.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageTutorados.Name = "tabPageTutorados";
            this.tabPageTutorados.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageTutorados.Size = new System.Drawing.Size(1101, 599);
            this.tabPageTutorados.TabIndex = 9;
            this.tabPageTutorados.Text = "Tutorados";
            // 
            // btnModificarTU
            // 
            this.btnModificarTU.Enabled = false;
            this.btnModificarTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarTU.Location = new System.Drawing.Point(273, 469);
            this.btnModificarTU.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificarTU.Name = "btnModificarTU";
            this.btnModificarTU.Size = new System.Drawing.Size(129, 44);
            this.btnModificarTU.TabIndex = 96;
            this.btnModificarTU.Text = "Modificar";
            this.btnModificarTU.UseVisualStyleBackColor = true;
            this.btnModificarTU.Click += new System.EventHandler(this.btnModificarTU_Click);
            // 
            // btnEliminarTU
            // 
            this.btnEliminarTU.Enabled = false;
            this.btnEliminarTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTU.Location = new System.Drawing.Point(148, 469);
            this.btnEliminarTU.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarTU.Name = "btnEliminarTU";
            this.btnEliminarTU.Size = new System.Drawing.Size(117, 44);
            this.btnEliminarTU.TabIndex = 95;
            this.btnEliminarTU.Text = "Eliminar";
            this.btnEliminarTU.UseVisualStyleBackColor = true;
            this.btnEliminarTU.Click += new System.EventHandler(this.btnEliminarTU_Click);
            // 
            // btnAgregarTU
            // 
            this.btnAgregarTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTU.Location = new System.Drawing.Point(16, 469);
            this.btnAgregarTU.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregarTU.Name = "btnAgregarTU";
            this.btnAgregarTU.Size = new System.Drawing.Size(105, 44);
            this.btnAgregarTU.TabIndex = 94;
            this.btnAgregarTU.Text = "Agregar";
            this.btnAgregarTU.UseVisualStyleBackColor = true;
            this.btnAgregarTU.Click += new System.EventHandler(this.btnAgregarTU_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(12, 41);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(248, 24);
            this.label24.TabIndex = 93;
            this.label24.Text = "ALUMNOS TUTORADOS:";
            // 
            // lvwTutorados
            // 
            this.lvwTutorados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23});
            this.lvwTutorados.FullRowSelect = true;
            this.lvwTutorados.Location = new System.Drawing.Point(16, 81);
            this.lvwTutorados.Margin = new System.Windows.Forms.Padding(4);
            this.lvwTutorados.MultiSelect = false;
            this.lvwTutorados.Name = "lvwTutorados";
            this.lvwTutorados.Size = new System.Drawing.Size(1040, 366);
            this.lvwTutorados.TabIndex = 92;
            this.lvwTutorados.UseCompatibleStateImageBehavior = false;
            this.lvwTutorados.View = System.Windows.Forms.View.Details;
            this.lvwTutorados.SelectedIndexChanged += new System.EventHandler(this.lvwTutorados_SelectedIndexChanged);
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Código";
            this.columnHeader17.Width = 92;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Nombre";
            this.columnHeader18.Width = 122;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Apellido Paterno";
            this.columnHeader19.Width = 134;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Apellido Materno";
            this.columnHeader20.Width = 142;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Horas P/sem";
            this.columnHeader21.Width = 93;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Inicio";
            this.columnHeader22.Width = 99;
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "Fin";
            this.columnHeader23.Width = 93;
            // 
            // tabPageControlTU
            // 
            this.tabPageControlTU.BackColor = System.Drawing.Color.Transparent;
            this.tabPageControlTU.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageControlTU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageControlTU.Controls.Add(this.label52);
            this.tabPageControlTU.Controls.Add(this.txbNombreTU);
            this.tabPageControlTU.Controls.Add(this.lblVerificarNombreTU);
            this.tabPageControlTU.Controls.Add(this.txbAMaternoTU);
            this.tabPageControlTU.Controls.Add(this.lblVerificarAMaternoTU);
            this.tabPageControlTU.Controls.Add(this.label50);
            this.tabPageControlTU.Controls.Add(this.labelTítuloControlTU);
            this.tabPageControlTU.Controls.Add(this.btnCancelarTU);
            this.tabPageControlTU.Controls.Add(this.btnControlTU);
            this.tabPageControlTU.Controls.Add(this.dtpFinTU);
            this.tabPageControlTU.Controls.Add(this.dtpInicioTU);
            this.tabPageControlTU.Controls.Add(this.txbAPAternoTU);
            this.tabPageControlTU.Controls.Add(this.txbCodigoTU);
            this.tabPageControlTU.Controls.Add(this.txbCargaHorariaTU);
            this.tabPageControlTU.Controls.Add(this.lblVerificarAPaternoTU);
            this.tabPageControlTU.Controls.Add(this.label37);
            this.tabPageControlTU.Controls.Add(this.lblVerificarFechasTU);
            this.tabPageControlTU.Controls.Add(this.lblVerificarCodigoTU);
            this.tabPageControlTU.Controls.Add(this.lblVerificarCargaHorariaTU);
            this.tabPageControlTU.Controls.Add(this.label45);
            this.tabPageControlTU.Controls.Add(this.label46);
            this.tabPageControlTU.Controls.Add(this.label47);
            this.tabPageControlTU.Controls.Add(this.label48);
            this.tabPageControlTU.Location = new System.Drawing.Point(4, 60);
            this.tabPageControlTU.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageControlTU.Name = "tabPageControlTU";
            this.tabPageControlTU.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageControlTU.Size = new System.Drawing.Size(1101, 599);
            this.tabPageControlTU.TabIndex = 10;
            this.tabPageControlTU.Text = "Control TU";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label52.Location = new System.Drawing.Point(216, 263);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(67, 24);
            this.label52.TabIndex = 66;
            this.label52.Text = "Inicio:";
            // 
            // txbNombreTU
            // 
            this.txbNombreTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNombreTU.Location = new System.Drawing.Point(311, 98);
            this.txbNombreTU.Margin = new System.Windows.Forms.Padding(4);
            this.txbNombreTU.Name = "txbNombreTU";
            this.txbNombreTU.Size = new System.Drawing.Size(323, 30);
            this.txbNombreTU.TabIndex = 1;
            this.txbNombreTU.TextChanged += new System.EventHandler(this.txbNombreTU_TextChanged);
            // 
            // lblVerificarNombreTU
            // 
            this.lblVerificarNombreTU.AutoSize = true;
            this.lblVerificarNombreTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarNombreTU.Location = new System.Drawing.Point(637, 108);
            this.lblVerificarNombreTU.Name = "lblVerificarNombreTU";
            this.lblVerificarNombreTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarNombreTU.TabIndex = 65;
            // 
            // txbAMaternoTU
            // 
            this.txbAMaternoTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAMaternoTU.Location = new System.Drawing.Point(311, 177);
            this.txbAMaternoTU.Margin = new System.Windows.Forms.Padding(4);
            this.txbAMaternoTU.Name = "txbAMaternoTU";
            this.txbAMaternoTU.Size = new System.Drawing.Size(323, 30);
            this.txbAMaternoTU.TabIndex = 3;
            this.txbAMaternoTU.TextChanged += new System.EventHandler(this.txbAMaternoTU_TextChanged);
            // 
            // lblVerificarAMaternoTU
            // 
            this.lblVerificarAMaternoTU.AutoSize = true;
            this.lblVerificarAMaternoTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarAMaternoTU.Location = new System.Drawing.Point(637, 186);
            this.lblVerificarAMaternoTU.Name = "lblVerificarAMaternoTU";
            this.lblVerificarAMaternoTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarAMaternoTU.TabIndex = 63;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label50.Location = new System.Drawing.Point(100, 181);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(176, 24);
            this.label50.TabIndex = 62;
            this.label50.Text = "Apellido Materno:";
            // 
            // labelTítuloControlTU
            // 
            this.labelTítuloControlTU.AutoSize = true;
            this.labelTítuloControlTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTítuloControlTU.Location = new System.Drawing.Point(40, 18);
            this.labelTítuloControlTU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTítuloControlTU.Name = "labelTítuloControlTU";
            this.labelTítuloControlTU.Size = new System.Drawing.Size(76, 24);
            this.labelTítuloControlTU.TabIndex = 60;
            this.labelTítuloControlTU.Text = "label24";
            // 
            // btnCancelarTU
            // 
            this.btnCancelarTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarTU.Location = new System.Drawing.Point(439, 361);
            this.btnCancelarTU.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancelarTU.Name = "btnCancelarTU";
            this.btnCancelarTU.Size = new System.Drawing.Size(117, 41);
            this.btnCancelarTU.TabIndex = 8;
            this.btnCancelarTU.Text = "Cancelar";
            this.btnCancelarTU.UseVisualStyleBackColor = true;
            this.btnCancelarTU.Click += new System.EventHandler(this.btnCancelarTU_Click);
            // 
            // btnControlTU
            // 
            this.btnControlTU.Enabled = false;
            this.btnControlTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControlTU.Location = new System.Drawing.Point(287, 361);
            this.btnControlTU.Margin = new System.Windows.Forms.Padding(4);
            this.btnControlTU.Name = "btnControlTU";
            this.btnControlTU.Size = new System.Drawing.Size(117, 41);
            this.btnControlTU.TabIndex = 7;
            this.btnControlTU.Text = "button";
            this.btnControlTU.UseVisualStyleBackColor = true;
            this.btnControlTU.Click += new System.EventHandler(this.btnControlTU_Click);
            // 
            // dtpFinTU
            // 
            this.dtpFinTU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFinTU.Location = new System.Drawing.Point(313, 295);
            this.dtpFinTU.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinTU.Name = "dtpFinTU";
            this.dtpFinTU.Size = new System.Drawing.Size(141, 30);
            this.dtpFinTU.TabIndex = 6;
            this.dtpFinTU.ValueChanged += new System.EventHandler(this.dtpFinTU_ValueChanged);
            // 
            // dtpInicioTU
            // 
            this.dtpInicioTU.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpInicioTU.Location = new System.Drawing.Point(313, 256);
            this.dtpInicioTU.Margin = new System.Windows.Forms.Padding(4);
            this.dtpInicioTU.Name = "dtpInicioTU";
            this.dtpInicioTU.Size = new System.Drawing.Size(141, 30);
            this.dtpInicioTU.TabIndex = 5;
            this.dtpInicioTU.ValueChanged += new System.EventHandler(this.dtpInicioTU_ValueChanged);
            // 
            // txbAPAternoTU
            // 
            this.txbAPAternoTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbAPAternoTU.Location = new System.Drawing.Point(311, 138);
            this.txbAPAternoTU.Margin = new System.Windows.Forms.Padding(4);
            this.txbAPAternoTU.Name = "txbAPAternoTU";
            this.txbAPAternoTU.Size = new System.Drawing.Size(323, 30);
            this.txbAPAternoTU.TabIndex = 2;
            this.txbAPAternoTU.TextChanged += new System.EventHandler(this.txbAPAternoTU_TextChanged);
            // 
            // txbCodigoTU
            // 
            this.txbCodigoTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCodigoTU.Location = new System.Drawing.Point(311, 59);
            this.txbCodigoTU.Margin = new System.Windows.Forms.Padding(4);
            this.txbCodigoTU.Name = "txbCodigoTU";
            this.txbCodigoTU.Size = new System.Drawing.Size(323, 30);
            this.txbCodigoTU.TabIndex = 0;
            this.txbCodigoTU.TextChanged += new System.EventHandler(this.txbCodigoTU_TextChanged);
            // 
            // txbCargaHorariaTU
            // 
            this.txbCargaHorariaTU.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbCargaHorariaTU.Location = new System.Drawing.Point(313, 217);
            this.txbCargaHorariaTU.Margin = new System.Windows.Forms.Padding(4);
            this.txbCargaHorariaTU.Name = "txbCargaHorariaTU";
            this.txbCargaHorariaTU.Size = new System.Drawing.Size(113, 30);
            this.txbCargaHorariaTU.TabIndex = 4;
            this.txbCargaHorariaTU.TextChanged += new System.EventHandler(this.txbCargaHorariaTU_TextChanged);
            // 
            // lblVerificarAPaternoTU
            // 
            this.lblVerificarAPaternoTU.AutoSize = true;
            this.lblVerificarAPaternoTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarAPaternoTU.Location = new System.Drawing.Point(637, 146);
            this.lblVerificarAPaternoTU.Name = "lblVerificarAPaternoTU";
            this.lblVerificarAPaternoTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarAPaternoTU.TabIndex = 55;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.Location = new System.Drawing.Point(107, 140);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(172, 24);
            this.label37.TabIndex = 54;
            this.label37.Text = "Apellido Paterno:";
            // 
            // lblVerificarFechasTU
            // 
            this.lblVerificarFechasTU.AutoSize = true;
            this.lblVerificarFechasTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarFechasTU.Location = new System.Drawing.Point(463, 284);
            this.lblVerificarFechasTU.Name = "lblVerificarFechasTU";
            this.lblVerificarFechasTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarFechasTU.TabIndex = 53;
            // 
            // lblVerificarCodigoTU
            // 
            this.lblVerificarCodigoTU.AutoSize = true;
            this.lblVerificarCodigoTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarCodigoTU.Location = new System.Drawing.Point(637, 69);
            this.lblVerificarCodigoTU.Name = "lblVerificarCodigoTU";
            this.lblVerificarCodigoTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarCodigoTU.TabIndex = 52;
            // 
            // lblVerificarCargaHorariaTU
            // 
            this.lblVerificarCargaHorariaTU.AutoSize = true;
            this.lblVerificarCargaHorariaTU.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.lblVerificarCargaHorariaTU.Location = new System.Drawing.Point(435, 226);
            this.lblVerificarCargaHorariaTU.Name = "lblVerificarCargaHorariaTU";
            this.lblVerificarCargaHorariaTU.Size = new System.Drawing.Size(0, 17);
            this.lblVerificarCargaHorariaTU.TabIndex = 51;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label45.Location = new System.Drawing.Point(239, 303);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(46, 24);
            this.label45.TabIndex = 50;
            this.label45.Text = "Fin:";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label46.Location = new System.Drawing.Point(171, 103);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(116, 24);
            this.label46.TabIndex = 49;
            this.label46.Text = "Nombre(s):";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label47.Location = new System.Drawing.Point(43, 219);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(234, 24);
            this.label47.TabIndex = 48;
            this.label47.Text = "Carga Horaria Semanal:";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label48.Location = new System.Drawing.Point(196, 59);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(84, 24);
            this.label48.TabIndex = 47;
            this.label48.Text = "Código:";
            // 
            // tabPageCurriculum
            // 
            this.tabPageCurriculum.BackColor = System.Drawing.Color.Transparent;
            this.tabPageCurriculum.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.tabPageCurriculum.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPageCurriculum.Controls.Add(this.buttonVistaPrevia);
            this.tabPageCurriculum.Controls.Add(this.buttonPDF);
            this.tabPageCurriculum.Controls.Add(this.buttonWord);
            this.tabPageCurriculum.Location = new System.Drawing.Point(4, 60);
            this.tabPageCurriculum.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCurriculum.Name = "tabPageCurriculum";
            this.tabPageCurriculum.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCurriculum.Size = new System.Drawing.Size(1101, 599);
            this.tabPageCurriculum.TabIndex = 11;
            this.tabPageCurriculum.Text = "Curriculum";
            // 
            // buttonVistaPrevia
            // 
            this.buttonVistaPrevia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVistaPrevia.Location = new System.Drawing.Point(24, 176);
            this.buttonVistaPrevia.Margin = new System.Windows.Forms.Padding(4);
            this.buttonVistaPrevia.Name = "buttonVistaPrevia";
            this.buttonVistaPrevia.Size = new System.Drawing.Size(143, 33);
            this.buttonVistaPrevia.TabIndex = 51;
            this.buttonVistaPrevia.Text = "Vista Previa";
            this.buttonVistaPrevia.UseVisualStyleBackColor = true;
            this.buttonVistaPrevia.Click += new System.EventHandler(this.buttonVistaPrevia_Click);
            // 
            // buttonPDF
            // 
            this.buttonPDF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPDF.Location = new System.Drawing.Point(24, 295);
            this.buttonPDF.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(143, 33);
            this.buttonPDF.TabIndex = 50;
            this.buttonPDF.Text = "PDF";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // buttonWord
            // 
            this.buttonWord.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonWord.Location = new System.Drawing.Point(24, 234);
            this.buttonWord.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(143, 33);
            this.buttonWord.TabIndex = 49;
            this.buttonWord.Text = "Word";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // Form_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 673);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Usuario";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Usuario_FormClosed);
            this.Load += new System.EventHandler(this.Form_Usuario_Load);
            this.tabPageDatosPersonales.ResumeLayout(false);
            this.tabPageDatosPersonales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFoto)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPageFormaciónAcademica.ResumeLayout(false);
            this.tabPageFormaciónAcademica.PerformLayout();
            this.msFA.ResumeLayout(false);
            this.msFA.PerformLayout();
            this.tabPageProduccionAcademica.ResumeLayout(false);
            this.tabPageProduccionAcademica.PerformLayout();
            this.msPA.ResumeLayout(false);
            this.msPA.PerformLayout();
            this.tabPageCargaAcademica.ResumeLayout(false);
            this.tabPageCargaAcademica.PerformLayout();
            this.tabPageControlFA.ResumeLayout(false);
            this.tabPageControlFA.PerformLayout();
            this.tabPageControlPA.ResumeLayout(false);
            this.tabPageControlPA.PerformLayout();
            this.tabPageControlCA.ResumeLayout(false);
            this.tabPageControlCA.PerformLayout();
            this.tabPageTutorados.ResumeLayout(false);
            this.tabPageTutorados.PerformLayout();
            this.tabPageControlTU.ResumeLayout(false);
            this.tabPageControlTU.PerformLayout();
            this.tabPageCurriculum.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDatosPersonales;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.ListView listViewDependientes;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxDomicilio;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxCiudad;
        private System.Windows.Forms.TextBox textBoxApellidoM;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxApellidoP;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePickerNacimiento;
        private System.Windows.Forms.Label labelVerificarTelefono;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label labelVerificarCiudad;
        private System.Windows.Forms.Label labelVerificarDomicilio;
        private System.Windows.Forms.Label labelVerificarEmail;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label labelVerificarApellidoM;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelVerificarApellidoP;
        private System.Windows.Forms.PictureBox pictureBoxFoto;
        private System.Windows.Forms.Label labelVerificarNombre;
        private System.Windows.Forms.Label labelVerificarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonFoto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFormaciónAcademica;
        private System.Windows.Forms.Label lblTítuloObtencionFA;
        private System.Windows.Forms.Label lblTítuloFinFA;
        private System.Windows.Forms.Label lblTítuloInicioFA;
        private System.Windows.Forms.Label lblTítuloCedulaFA;
        private System.Windows.Forms.Label lblTítuloNombreFA;
        private System.Windows.Forms.Label lblTítuloGradoFA;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MenuStrip msFA;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarFA;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeleccionarFA;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarFA;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarFA;
        private System.Windows.Forms.TabPage tabPageControlFA;
        private System.Windows.Forms.Button btnCancelarFA;
        private System.Windows.Forms.ComboBox cboGradoAcademico;
        private System.Windows.Forms.Label lblVerificarCedula;
        private System.Windows.Forms.DateTimePicker dtpObtenciónFA;
        private System.Windows.Forms.DateTimePicker dtpFinFA;
        private System.Windows.Forms.DateTimePicker dtpInicioFA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelApellidoM;
        private System.Windows.Forms.Label lblVerificarInstitucion;
        private System.Windows.Forms.Label lblVerificarNombreFA;
        private System.Windows.Forms.Label lblVerificarGA;
        private System.Windows.Forms.Label labelApellidoP;
        private System.Windows.Forms.TextBox txbInstitucion;
        private System.Windows.Forms.Button btnControlFA;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.TextBox txbCedulaFA;
        private System.Windows.Forms.TextBox txbNombreFA;
        private System.Windows.Forms.Label labelTítuloControlFA;
        private System.Windows.Forms.TabPage tabPageProduccionAcademica;
        private System.Windows.Forms.Label lblTituloNRegistroPA;
        private System.Windows.Forms.Label lblTituloInstitucionPA;
        private System.Windows.Forms.Label lblTituloFechaPA;
        private System.Windows.Forms.Label lblTituloTituloPA;
        private System.Windows.Forms.Label lblTituloCategoriaPA;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.MenuStrip msPA;
        private System.Windows.Forms.ToolStripMenuItem tsmiAgregarPA;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeleccionarPA;
        private System.Windows.Forms.ToolStripMenuItem tsmiEliminarPA;
        private System.Windows.Forms.ToolStripMenuItem tsmiModificarPA;
        private System.Windows.Forms.TabPage tabPageControlPA;
        private System.Windows.Forms.Button btnCancelarAgregarPA;
        private System.Windows.Forms.ComboBox cboCategoriaPA;
        private System.Windows.Forms.Label lblVerificarNRegistroPA;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblVerificarTituloPA;
        private System.Windows.Forms.Label lblVerificarCategoriaPA;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnControlPA;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txbNRegistroPA;
        private System.Windows.Forms.TextBox txbTituloPA;
        private System.Windows.Forms.Label labelTituloPA;
        private System.Windows.Forms.Label lblVerificarInstitucionPA;
        private System.Windows.Forms.TextBox txbInstitucionPA;
        private System.Windows.Forms.DateTimePicker dtpFechaPA;
        private System.Windows.Forms.Button btnEliminarAutorPA;
        private System.Windows.Forms.ListView lvwAutoresPA;
        private System.Windows.Forms.Button btnAgregarAutorPA;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ListView listViewAutoresPA;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label lblValidarAutores;
        private System.Windows.Forms.TabPage tabPageCargaAcademica;
        private System.Windows.Forms.TabPage tabPageControlCA;
        private System.Windows.Forms.Button btnEliminarCA;
        private System.Windows.Forms.Button btnAgregarCA;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ListView lvwCargaAcademica;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.DateTimePicker dtpFinCA;
        private System.Windows.Forms.DateTimePicker dtpInicioCA;
        private System.Windows.Forms.TextBox txbProgramaEducativoCA;
        private System.Windows.Forms.TextBox txbNombreCA;
        private System.Windows.Forms.TextBox txbCargaHorariaCA;
        private System.Windows.Forms.Label lblVerificarProgramaEducativoCA;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblVerificarFechasCA;
        private System.Windows.Forms.Label lblVerificarNombreCA;
        private System.Windows.Forms.Label lblVerificarCargaHorariaCA;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Button btnCancelarCA;
        private System.Windows.Forms.Button btnControlCA;
        private System.Windows.Forms.Label labelTítuloControlCA;
        private System.Windows.Forms.Button btnModificarCA;
        private System.Windows.Forms.TabPage tabPageTutorados;
        private System.Windows.Forms.TabPage tabPageControlTU;
        private System.Windows.Forms.Button btnModificarTU;
        private System.Windows.Forms.Button btnEliminarTU;
        private System.Windows.Forms.Button btnAgregarTU;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ListView lvwTutorados;
        private System.Windows.Forms.Label labelTítuloControlTU;
        private System.Windows.Forms.Button btnCancelarTU;
        private System.Windows.Forms.Button btnControlTU;
        private System.Windows.Forms.DateTimePicker dtpFinTU;
        private System.Windows.Forms.DateTimePicker dtpInicioTU;
        private System.Windows.Forms.TextBox txbAPAternoTU;
        private System.Windows.Forms.TextBox txbCodigoTU;
        private System.Windows.Forms.TextBox txbCargaHorariaTU;
        private System.Windows.Forms.Label lblVerificarAPaternoTU;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label lblVerificarFechasTU;
        private System.Windows.Forms.Label lblVerificarCodigoTU;
        private System.Windows.Forms.Label lblVerificarCargaHorariaTU;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.TextBox txbNombreTU;
        private System.Windows.Forms.Label lblVerificarNombreTU;
        private System.Windows.Forms.TextBox txbAMaternoTU;
        private System.Windows.Forms.Label lblVerificarAMaternoTU;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.TabPage tabPageCurriculum;
        private System.Windows.Forms.Button buttonPDF;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.Label lblInstitucionFA;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label lblVerificarFechasFinObtencion;
        private System.Windows.Forms.Label lblVerificarFechasInicioFin;
        private System.Windows.Forms.Button buttonVistaPrevia;
    }
}