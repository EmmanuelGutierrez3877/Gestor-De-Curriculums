using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace Curriculums
{
    public partial class Form_Usuario : Form
    {
        Profesor p;
        Validador validar=new Validador();
        Form ant;

        //*/*//

        public FormacionAcademica fa;
        private int indiceFA;

        private ProduccionAcademica pa;
        private int indicePA;

        private Materia ma;
        private int indiceCA;

        private Tutorado tu;
        private int indiceTU;
        //*/*//

        public Form_Usuario(Profesor p, Form ant)
        {
            InitializeComponent();
            this.p = p;
            this.ant = ant;
            
        }

        private void Form_Usuario_Load(object sender, EventArgs e)
        {

            this.Text = p.codigo + " : " + p.apellidoP+ "  " + p.apellidoM+" " +p.nombre;
            dateTimePickerNacimiento.MaxDate = DateTime.Today;
            textBoxCodigo.Text = p.codigo;
            textBoxNombre.Text = p.nombre;
            textBoxApellidoP.Text = p.apellidoP;
            textBoxApellidoM.Text = p.apellidoM;
            textBoxContraseña.Text = p.contraseña;
            textBoxEmail.Text = p.email;
            textBoxDomicilio.Text = p.domicilio;
            textBoxTelefono.Text = p.telefono;
            textBoxCiudad.Text = p.ciudad;
            dateTimePickerNacimiento.Value = p.nacimiento ;
            

            pictureBoxFoto.Image = p.foto;
            textBoxContraseña.PasswordChar = '*';

            labelVerificarApellidoP.Text = "";
            labelVerificarApellidoM.Text = "";
            labelVerificarContraseña.Text = "";
            labelVerificarNombre.Text = "";
            labelVerificarDomicilio.Text = "";
            labelVerificarTelefono.Text = "";
            labelVerificarEmail.Text = "";
            labelVerificarCiudad.Text = "";

            CargarLista();

            buttonGuardar.Enabled = false;


            //Se establece la fecha limite al día actual (No se permite poner fechas futuras)
            dateTimePickerNacimiento.MaxDate = DateTime.Today;
            dtpFechaPA.MaxDate = DateTime.Today;
            dtpFinFA.MaxDate = DateTime.Today;
            dtpFinCA.MaxDate = DateTime.Today;
            dtpInicioFA.MaxDate = DateTime.Today;
            dtpInicioCA.MaxDate = DateTime.Today;
            dtpObtenciónFA.MaxDate = DateTime.Today;
            dtpInicioTU.MaxDate = DateTime.Today;
            dtpFinTU.MaxDate = DateTime.Today;



            //Carga pestañas de formación académica, producción académica

            actualizarFA();
            actualizarPA();
            actualizarCA();
            actualizarTU();

            //Oculta Pestañas Ocultas

            tabControl1.TabPages.Remove(tabPageControlFA);
            tabControl1.TabPages.Remove(tabPageControlPA);
            tabControl1.TabPages.Remove(tabPageControlCA);
            tabControl1.TabPages.Remove(tabPageControlTU);

            indiceCA = -1;
            indiceFA = 0;
            indicePA = 0;
            indiceTU = -1;

            ant.Visible = false;
        }

        private void CargarLista()
        {
            listViewDependientes.Clear();
            listViewDependientes.View = View.Details;
            listViewDependientes.FullRowSelect = true;
            listViewDependientes.GridLines = true;
            listViewDependientes.Columns.Add("Nombre", 250);
            listViewDependientes.Columns.Add("Edad", 120);
            

            foreach (Dependiente d in p.listDependientes)
            {
                listViewDependientes.Items.Add(d.nombre+" "+d.apellidoP+" "+d.apellidoM);
                listViewDependientes.Items[listViewDependientes.Items.Count - 1].SubItems.Add(d.getEdad().ToString());
            }
        }

        private void buttonFoto_Click(object sender, EventArgs e)
        {
            
            int newWidth = 150, newHeight = 200;
            OpenFileDialog Foto = new OpenFileDialog();
            Foto.Filter = "Imagenes|*.jpg;*.png;*.bmp;*.JPG;*.PNG;*.BMP";
            Foto.Title = "Selecciona una imagen (.jpg , .png , .bmp) :";
            Foto.ShowDialog();
            pictureBoxFoto.ImageLocation = Foto.FileName;

            if(Foto.FileName != "")
            {
                pictureBoxFoto.Load();
                var newImage = new Bitmap(newWidth, newHeight);
                using (var graphics = Graphics.FromImage(newImage))graphics.DrawImage(pictureBoxFoto.Image, 0, 0, newWidth, newHeight);
                p.foto = newImage;
            }
            
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            p.contraseña = textBoxContraseña.Text;
            p.nombre = textBoxNombre.Text;
            p.apellidoP = textBoxApellidoP.Text;
            p.apellidoM = textBoxApellidoM.Text;
            p.domicilio = textBoxDomicilio.Text;
            p.ciudad = textBoxCiudad.Text;
            p.telefono = textBoxTelefono.Text;
            p.email = textBoxEmail.Text;
            p.nacimiento = dateTimePickerNacimiento.Value;
            MessageBox.Show("Datos Guardados","Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Form_Usuario_Load(sender,e);
        }

        private void ActivarGuardar()
        {
            bool nom, aPa, con, aMa,dom,tel=false,ciu,email;
            nom = validar.ValidarTextBox(textBoxNombre, labelVerificarNombre, 't');
            aPa = validar.ValidarTextBox(textBoxApellidoP, labelVerificarApellidoP, 't');
            con = validar.ValidarTextBox(textBoxContraseña, labelVerificarContraseña, 'a');
            aMa = validar.ValidarTextBox(textBoxApellidoM, labelVerificarApellidoM, 't');
            dom = validar.ValidarTextBox(textBoxDomicilio, labelVerificarDomicilio, 'a');
            ciu = validar.ValidarTextBox(textBoxCiudad, labelVerificarCiudad, 't');
            email = validar.ValidarTextBox(textBoxEmail,labelVerificarEmail,'e');

            if(textBoxTelefono.Text.Length==8 || textBoxTelefono.Text.Length == 10)
            {
                tel = validar.ValidarTextBox(textBoxTelefono, labelVerificarTelefono, 'n');
            }
            else
            {
                labelVerificarTelefono.Text ="Invalido";
                labelVerificarTelefono.ForeColor = Color.Red;
            }



            if (nom && aPa && con && aMa && dom && tel && ciu && email)
            {
                buttonGuardar.Enabled = true;
            }
            else
            {
                buttonGuardar.Enabled = false;
            }
            
        }

        private void restauraPaginas()
        {
            tabControl1.TabPages.Add(tabPageDatosPersonales);
            tabControl1.TabPages.Add(tabPageFormaciónAcademica);
            tabControl1.TabPages.Add(tabPageProduccionAcademica);
            tabControl1.TabPages.Add(tabPageCargaAcademica);
            tabControl1.TabPages.Add(tabPageTutorados);
            tabControl1.TabPages.Add(tabPageCurriculum);


            tabControl1.TabPages.Remove(tabPageControlFA);
            tabControl1.TabPages.Remove(tabPageControlPA);
            tabControl1.TabPages.Remove(tabPageControlCA);
            tabControl1.TabPages.Remove(tabPageControlTU);

        }



        private void textBoxContraseña_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
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

        private void textBoxDomicilio_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void textBoxCuidad_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void textBoxTelefono_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            ActivarGuardar();
        }

        private void dateTimePickerNacimiento_ValueChanged(object sender, EventArgs e)
        {
            int edad = DateTime.Today.AddTicks(-dateTimePickerNacimiento.Value.Ticks).Year - 1;
            ActivarGuardar();
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            Form_Dependiente fd = new Form_Dependiente();
            fd.ShowDialog();
            if (fd.lleno)
            {
                p.listDependientes.Add(fd.dependiente);
                listViewDependientes.Items.Add(fd.dependiente.nombre+" "+ fd.dependiente.apellidoP+" "+ fd.dependiente.apellidoM);
                int edad = DateTime.Today.AddTicks(-fd.dependiente.nacimiento.Ticks).Year - 1;
                listViewDependientes.Items[listViewDependientes.Items.Count - 1].SubItems.Add(edad.ToString());
            }
        }

        private void listViewDependientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEliminar.Enabled = true;
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (listViewDependientes.SelectedIndices.Count != 0)
            {
                int i = listViewDependientes.SelectedIndices[0];
                p.listDependientes.Remove(p.listDependientes[i]);
                CargarLista();
            }
            buttonEliminar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        #region FORMACION ACADÉMICA

        private void activaPestañaControlFA()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPageControlFA);
        }
        private void actualizarFA()
        {
            tsmiSeleccionarFA.DropDownItems.Clear();
            if (p.listaFormacion.Count > 0)
            {
                foreach (FormacionAcademica fa in p.listaFormacion)
                {
                    tsmiSeleccionarFA.DropDownItems.Add(fa.nombre);
                }
                llenarLabelsFA(indiceFA);
            }

        }

        private void llenarFormularioFA()
        {
            txbNombreFA.Text = fa.nombre;
            txbInstitucion.Text = fa.institucion;
            txbCedulaFA.Text = fa.cedula;
            cboGradoAcademico.SelectedItem = fa.gradoAcademico;
            dtpInicioFA.Value = fa.fechaInicio;
            dtpFinFA.Value = fa.fechaFin;
            dtpObtenciónFA.Value = fa.fechaObtención;
        }
        private void limpiarFormularioFA()
        {
            txbNombreFA.Clear();
            txbInstitucion.Clear();
            txbCedulaFA.Clear();
            cboGradoAcademico.SelectedIndex = -1;
            dtpInicioFA.Value = DateTime.Today;
            dtpFinFA.Value = DateTime.Today;
            dtpObtenciónFA.Value = DateTime.Today;


        }

        private void llenarLabelsFA(int indice)
        {

            fa = p.listaFormacion.ElementAt(indice);
            lblTítuloGradoFA.Text = fa.gradoAcademico;
            lblTítuloNombreFA.Text = fa.nombre;
            lblInstitucionFA.Text = fa.institucion;
            lblTítuloCedulaFA.Text = fa.cedula;
            lblTítuloInicioFA.Text = fa.fechaInicio.ToShortDateString();
            lblTítuloFinFA.Text = fa.fechaFin.ToShortDateString();
            lblTítuloObtencionFA.Text = fa.fechaObtención.ToShortDateString();
        }
        private void limpiarLabelsFA()
        {
            lblTítuloGradoFA.Text = "";
            lblTítuloNombreFA.Text = "";
            lblTítuloCedulaFA.Text = "";
            lblTítuloInicioFA.Text = "";
            lblTítuloFinFA.Text = "";
            lblTítuloObtencionFA.Text = "";
        }

        #region CONTROLES TOOL STRIP MENU

        private void tsmiAgregarFA_Click(object sender, EventArgs e)
        {
            tabPageControlFA.Text = "Agregando Formación Académica";
            btnControlFA.Text = "Agregar";
            labelTítuloControlFA.Text = "Nueva Formación Académica: ";
            activaPestañaControlFA();
            limpiarFormularioFA();
        }
        private void tsmiSeleccionarFA_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            indiceFA = tsmiSeleccionarFA.DropDownItems.IndexOf(e.ClickedItem);

            llenarLabelsFA(indiceFA);
        }
        private void tsmiEliminarFA_Click(object sender, EventArgs e)
        {
            if (fa != null)
            {
                DialogResult dialog = MessageBox.Show("¿Estás seguro que deceas eliminar " + fa.nombre + "?", "¡CUIDAD0! Estás por eliminar la formación académica", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    int indice = p.listaFormacion.IndexOf(fa);
                    tsmiSeleccionarFA.DropDownItems.RemoveAt(indice);
                    p.listaFormacion.Remove(fa);
                    limpiarLabelsFA();
                    fa = null;
                    indiceFA = -1;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna Formación académica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void tsmiModificarFA_Click(object sender, EventArgs e)
        {
            if (fa != null)
            {
                tabPageControlFA.Text = "Modificar datos: " + fa.nombre;
                btnControlFA.Text = "Guardar";
                labelTítuloControlFA.Text = "Modificar datos: ";
                activaPestañaControlFA();
                llenarFormularioFA();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna Formación académica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        #endregion

        #region VALIDAR DATOS

        private void textBoxNombreFA_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();
        }

        private void textBoxInstitucion_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();
        }

        private void textBoxCédula_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();
        }
        private void dtpObtenciónFA_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();

        }

        private void dtpFinFA_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();

        }

        private void dtpInicioFA_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();

        }

        private void activarBtnControlFA()
        {
            bool a, b, c, d, e = true;
            a = validar.ValidarTextBox(txbNombreFA, lblVerificarNombreFA, 'a');
            b = validar.ValidarTextBox(txbInstitucion, lblVerificarInstitucion, 'a');
            c = validar.ValidarTextBox(txbCedulaFA, lblVerificarCedula, 'n');
            d = validar.ValidarComboBox(cboGradoAcademico, lblVerificarGA);
            if(dtpInicioFA.Value >= dtpFinFA.Value)
            {
                lblVerificarFechasInicioFin.Text = "La fecha de inicio no puede ser mayor a la de fin";
                lblVerificarFechasInicioFin.ForeColor = Color.Red;
                e = false;
            }
            else
            {
                lblVerificarFechasInicioFin.ForeColor = Color.Green;
                lblVerificarFechasInicioFin.Text = "válido";
                e = true;
            }
            if(dtpFinFA.Value >= dtpObtenciónFA.Value)
            {
                lblVerificarFechasFinObtencion.Text = "La fecha de fin no puede ser mayor a la de obtención";
                lblVerificarFechasFinObtencion.ForeColor = Color.Red;

                e = false;
            }
            else
            {
                lblVerificarFechasFinObtencion.Text = "válido";
                lblVerificarFechasFinObtencion.ForeColor = Color.Green;
                e = true;
            }
            if (a && b && c && d)
            {
                btnControlFA.Enabled = true;
            }
            else
            {
                btnControlFA.Enabled = false;
            }

        }

        #endregion



        private void btnControlFA_Click(object sender, EventArgs e)
        {
            if (btnControlFA.Text == "Agregar")
            {
                FormacionAcademica fa = new FormacionAcademica();
                fa.ActualizarFormacionAcademica(cboGradoAcademico.SelectedItem.ToString(), txbNombreFA.Text, txbInstitucion.Text, dtpInicioFA.Value, dtpFinFA.Value, dtpObtenciónFA.Value, txbCedulaFA.Text);
                p.listaFormacion.Add(fa);
                indiceFA = p.listaFormacion.IndexOf(fa);
            }
            else if (btnControlFA.Text == "Guardar")
            {
                fa.ActualizarFormacionAcademica(cboGradoAcademico.SelectedItem.ToString(), txbNombreFA.Text, txbInstitucion.Text, dtpInicioFA.Value, dtpFinFA.Value, dtpObtenciónFA.Value, txbCedulaFA.Text);
            }


            restauraPaginas();
            tabControl1.SelectedTab = tabPageFormaciónAcademica;
            actualizarFA();
        }
        private void btnCancelarFA_Click(object sender, EventArgs e)
        {
            restauraPaginas();
            tabControl1.SelectedTab = tabPageFormaciónAcademica;
        }



        #endregion

        #region PRODUCCIÓN ACADÉMICA
        private void activaPestañControlPA()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPageControlPA);
        }
        private void actualizarPA()
        {
            tsmiSeleccionarPA.DropDownItems.Clear();
            if (p.listaProduccionA.Count > 0)
            {
                foreach (ProduccionAcademica pa in p.listaProduccionA)
                {
                    tsmiSeleccionarPA.DropDownItems.Add(pa.titulo);
                }
                llenarLabelsPA(indicePA);
            }
        }

        private void limpiarFormularioPA()
        {
            cboCategoriaPA.SelectedIndex = -1;
            txbTituloPA.Clear();
            dtpFechaPA.Value = DateTime.Today;
            txbInstitucionPA.Clear();
            txbNRegistroPA.Clear();
            lvwAutoresPA.Items.Clear();
        }
        private void llenarFormularioPA()
        {
            cboCategoriaPA.SelectedItem = pa.categoria;
            txbTituloPA.Text = pa.titulo;
            dtpFechaPA.Value = pa.fecha;
            txbInstitucionPA.Text = pa.institucion;
            txbNRegistroPA.Text = pa.numeroRegistro;

            foreach (Autor autor in pa.listaAutores)
            {
                ListViewItem item = new ListViewItem(autor.nombre);
                item.SubItems.Add(autor.apellidoP);
                item.SubItems.Add(autor.apellidoM);
                lvwAutoresPA.Items.Add(item);
            }

        }

        private void llenarLabelsPA(int index)
        {
            if (index > -1)
            {
                pa = p.listaProduccionA.ElementAt(index);
                lblTituloCategoriaPA.Text = pa.categoria;
                lblTituloTituloPA.Text = pa.titulo;
                lblTituloFechaPA.Text = pa.fecha.ToShortDateString();
                lblTituloInstitucionPA.Text = pa.institucion;
                lblTituloNRegistroPA.Text = pa.numeroRegistro;

                listViewAutoresPA.Items.Clear();
                foreach (Autor a in pa.listaAutores)
                {
                    ListViewItem item = new ListViewItem(a.nombre);
                    item.SubItems.Add(a.apellidoP);
                    item.SubItems.Add(a.apellidoM);
                    listViewAutoresPA.Items.Add(item);
                }
            }

        }
        private void borrarLabelsPA()
        {
            lblTituloCategoriaPA.Text = "";
            lblTituloTituloPA.Text = "";
            lblTituloFechaPA.Text = "";
            lblTituloInstitucionPA.Text = "";
            lblTituloNRegistroPA.Text = "";

            listViewAutoresPA.Items.Clear();
        }

        #region VALIDAR DATOS
        private void txbNRegistroPA_TextChanged(object sender, EventArgs e)
        {
            activarbtnControlPA();
        }
        private void txbInstitucionPA_TextChanged(object sender, EventArgs e)
        {
            activarbtnControlPA();
        }
        private void txbTituloPA_TextChanged(object sender, EventArgs e)
        {
            activarbtnControlPA();
        }
        private void cboCategoriaPA_SelectedIndexChanged(object sender, EventArgs e)
        {
            activarbtnControlPA();
        }
        private void activarbtnControlPA()
        {
            bool a, b, c, d, e;
            a = validar.ValidarTextBox(txbInstitucionPA, lblVerificarInstitucionPA, 't');
            b = validar.ValidarTextBox(txbNRegistroPA, lblVerificarNRegistroPA, 'n');
            c = validar.ValidarTextBox(txbTituloPA, lblVerificarTituloPA, 'a');
            d = validar.ValidarComboBox(cboCategoriaPA, lblVerificarCategoriaPA);

            if (lvwAutoresPA.Items.Count > 0)
            {
                e = true;
                lblValidarAutores.Text = "";
            }
            else
            {
                e = false;
                lblValidarAutores.Text = "No ha agregado ningún autor";

            }

            if (a && b && c && d && e)
                btnControlPA.Enabled = true;
            else
                btnControlPA.Enabled = false;
        }
        #endregion

        #region CONTROLES TOOL MENU STRIP
        private void tsmiAgregarPA_Click(object sender, EventArgs e)
        {
            tabPageControlPA.Text = "Agregando Producción Académica";
            btnControlPA.Text = "Agregar";
            labelTituloPA.Text = "Nueva Formación Académica: ";

            ListViewItem item = new ListViewItem(p.nombre);
            item.SubItems.Add(p.apellidoP);
            item.SubItems.Add(p.apellidoM);
            lvwAutoresPA.Items.Add(item);

            activaPestañControlPA();
        }
        private void tsmiSeleccionarPA_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            indicePA = tsmiSeleccionarPA.DropDownItems.IndexOf(e.ClickedItem);

            llenarLabelsPA(indicePA);
        }
        private void tsmiModificarPA_Click(object sender, EventArgs e)
        {
            if (pa != null)
            {
                tabPageControlPA.Text = "Modificando Producción Académica";
                btnControlPA.Text = "Guardar";
                labelTituloPA.Text = "Actualizar Formación Académica: ";
                llenarFormularioPA();
                activaPestañControlPA();
                activarbtnControlPA();
            }

        }
        private void tsmiEliminarPA_Click(object sender, EventArgs e)
        {
            if (pa != null)
            {
                DialogResult dialog = MessageBox.Show("¿Estás seguro que deceas eliminar " + pa.titulo + "?", "¡CUIDAD0! Estás por eliminar la formación académica", MessageBoxButtons.YesNoCancel);
                if (dialog == DialogResult.Yes)
                {
                    int indice = p.listaProduccionA.IndexOf(pa);
                    tsmiSeleccionarPA.DropDownItems.RemoveAt(indice);
                    p.listaProduccionA.Remove(pa);
                    borrarLabelsPA();
                    pa = null;
                    indicePA = -1;
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ninguna Formación académica", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CONTROLES DEL CONTROL DE PRODUCCION ACADEMICA
        private void btnAgregarAutorPA_Click(object sender, EventArgs e)
        {
            FormAutor fa = new FormAutor();
            fa.ShowDialog();
            if (fa.lleno)
            {
                ListViewItem item = new ListViewItem(fa.autor.nombre);
                item.SubItems.Add(fa.autor.apellidoP);
                item.SubItems.Add(fa.autor.apellidoM);
                lvwAutoresPA.Items.Add(item);
            }
            activarbtnControlPA();
        }
        private void btnEliminarAutorPA_Click(object sender, EventArgs e)
        {
            lvwAutoresPA.Items.Remove(lvwAutoresPA.SelectedItems[0]);
            activarbtnControlPA();
        }
        private void lvwAutoresPA_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnEliminarAutorPA.Enabled = true;

        }

        private void btnCancelarAgregarPA_Click(object sender, EventArgs e)
        {
            restauraPaginas();
            tabControl1.SelectedTab = tabPageProduccionAcademica;
            limpiarFormularioPA();

        }
        private void btnControlPA_Click(object sender, EventArgs e)
        {

            if (btnControlPA.Text == "Agregar")
            {
                pa = new ProduccionAcademica();
                p.listaProduccionA.Add(pa);
                indicePA = p.listaProduccionA.IndexOf(pa);
            }

            pa.actualizarDatos(cboCategoriaPA.SelectedItem.ToString(), txbTituloPA.Text, dtpFechaPA.Value, txbInstitucionPA.Text, txbNRegistroPA.Text);
            pa.listaAutores.Clear();

            foreach (ListViewItem item in lvwAutoresPA.Items)
            {
                Autor autor = new Autor();
                autor.nombre = item.SubItems[0].Text;
                autor.apellidoP = item.SubItems[1].Text;
                autor.apellidoM = item.SubItems[2].Text;
                pa.listaAutores.Add(autor);
            }

            restauraPaginas();
            tabControl1.SelectedTab = tabPageProduccionAcademica;
            actualizarPA();
            limpiarFormularioPA();


        }



        #endregion

        #endregion

        #region CARGA ACADÉMICA

        private void actualizarCA()
        {
            lvwCargaAcademica.Items.Clear();
            if (p.listaMaterias.Count > 0)
            {
                foreach (Materia ma in p.listaMaterias)
                {
                    ListViewItem item = new ListViewItem(ma.nombre);
                    item.SubItems.Add(ma.inicio.ToShortDateString());
                    item.SubItems.Add(ma.fin.ToShortDateString());
                    item.SubItems.Add(ma.programa);
                    item.SubItems.Add(ma.cargahoraria);
                    lvwCargaAcademica.Items.Add(item);
                }
                btnEliminarCA.Enabled = true;
                btnModificarCA.Enabled = true;


            }
        }

        private void activaPestañaControlCA()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPageControlCA);
        }

        private void limpiarFormularioCA()
        {
            txbNombreCA.Clear();
            dtpInicioCA.Value = DateTime.Today;
            dtpFinCA.Value = DateTime.Today;
            txbProgramaEducativoCA.Clear();
            txbCargaHorariaCA.Clear();

        }
        private void llenarFormuarioCA()
        {
            txbNombreCA.Text = ma.nombre;
            dtpInicioCA.Value = ma.inicio;
            dtpFinCA.Value = ma.fin;
            txbProgramaEducativoCA.Text = ma.programa;
            txbCargaHorariaCA.Text = ma.cargahoraria;
        }

        private void btnAgregarCA_Click(object sender, EventArgs e)
        {
            tabPageControlCA.Text = "Agregando Carga Académica";
            btnControlCA.Text = "Agregar";
            labelTítuloControlCA.Text = "Nueva Materia: ";
            activaPestañaControlCA();
            limpiarFormularioCA();
        }

        private void btnEliminarCA_Click(object sender, EventArgs e)
        {
            if(indiceCA > -1)
            {
                p.listaMaterias.RemoveAt(indiceCA);
                actualizarCA();
                indiceCA = -1;
                if(p.listaMaterias.Count == 0)
                {
                    btnEliminarCA.Enabled = false;
                    btnModificarCA.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Seleccione la materia que decea eliminar.");
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (indiceCA > -1)
            {
                ma = p.listaMaterias.ElementAt(indiceCA);
                llenarFormuarioCA();
                tabPageControlCA.Text = "Modificando Materia";
                btnControlCA.Text = "Guardar";
                labelTítuloControlCA.Text = "Actualiza datos de la Materia: ";
                activaPestañaControlCA();
                indiceCA = -1;
            }
            else
            {
                MessageBox.Show("No se seleccionó ninguna materia.");
            }
        }



        private void btnControlCA_Click(object sender, EventArgs e)
        {
            if (btnControlCA.Text == "Agregar")
            {
                ma = new Materia();
                p.listaMaterias.Add(ma);
            }
            ma.actualizarDatos(txbNombreCA.Text, dtpInicioCA.Value, dtpFinCA.Value, txbProgramaEducativoCA.Text, txbCargaHorariaCA.Text);

            actualizarCA();

            restauraPaginas();
            tabControl1.SelectedTab = tabPageCargaAcademica;
            limpiarFormularioCA();
        }

        private void btnCancelarCA_Click(object sender, EventArgs e)
        {
            restauraPaginas();
            tabControl1.SelectedTab = tabPageCargaAcademica;
            limpiarFormularioCA();
        }


        private void txbNombreCA_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlCA();

        }

        private void txbProgramaEducativoCA_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlCA();

        }

        private void txbCargaHoraria_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlCA();

        }

        private void dtpInicioCA_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlCA();
        }

        private void dtpFinCA_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlCA();
        }

        private void activarBtnControlCA()
        {
            bool a, b, c, d;
            a = validar.ValidarTextBox(txbNombreCA, lblVerificarNombreCA, 'a');
            b = validar.ValidarTextBox(txbProgramaEducativoCA, lblVerificarProgramaEducativoCA, 'a');
            c = validar.ValidarTextBox(txbCargaHorariaCA, lblVerificarCargaHorariaCA, 'n');

            if (dtpInicioCA.Value >= dtpFinCA.Value)
            {
                d = false;
                lblVerificarFechasCA.Text = "fechas inconsistentes";
                lblVerificarFechasCA.ForeColor = Color.Red;
            }
            else
            {
                d = true;
                lblVerificarFechasCA.Text = "válido";
                lblVerificarFechasCA.ForeColor = Color.Green;
            }


            if (a && b && c && d)
            {
                btnControlCA.Enabled = true;
            }
            else
            {
                btnControlCA.Enabled = false;
            }

        }

        private void lvwCargaAcademica_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwCargaAcademica.SelectedIndices.Count > 0)
                indiceCA = lvwCargaAcademica.SelectedIndices[0];
            else
                indiceCA = -1;
        }

        #endregion

        #region TUTORADOS

        private void actualizarTU()
        {
            lvwTutorados.Items.Clear();
            if (p.listaAlumnos.Count > 0)
            {
                foreach (Tutorado tu in p.listaAlumnos)
                {
                    ListViewItem item = new ListViewItem(tu.codigo);
                    item.SubItems.Add(tu.nombre);
                    item.SubItems.Add(tu.apaterno);
                    item.SubItems.Add(tu.amaterno);
                    item.SubItems.Add(tu.horas);
                    item.SubItems.Add(tu.fechaInicio.ToShortDateString());
                    item.SubItems.Add(tu.fechaFin.ToShortDateString());

                    lvwTutorados.Items.Add(item);
                }
                btnEliminarTU.Enabled = true;
                btnModificarTU.Enabled = true;
            }
        }

        private void activaPestañaControlTU()
        {
            tabControl1.TabPages.Clear();
            tabControl1.TabPages.Add(tabPageControlTU);
        }

        private void limpiarFormularioTU()
        {
            txbCodigoTU.Clear();
            txbNombreTU.Clear();
            txbAPAternoTU.Clear();
            txbAMaternoTU.Clear();
            txbCargaHorariaTU.Clear();
            dtpInicioTU.Value = DateTime.Today;
            dtpFinTU.Value = DateTime.Today;
        }
        private void llenarFormuarioTU()
        {
            txbCodigoTU.Text = tu.codigo;
            txbNombreTU.Text = tu.nombre;
            txbAPAternoTU.Text = tu.apaterno;
            txbAMaternoTU.Text = tu.amaterno;
            txbCargaHorariaTU.Text = tu.horas;
            dtpInicioTU.Value = tu.fechaInicio;
            dtpFinTU.Value = tu.fechaFin;
        }

        private void btnAgregarTU_Click(object sender, EventArgs e)
        {
            tabPageControlTU.Text = "Agregando Tutorafo";
            btnControlTU.Text = "Agregar";
            labelTítuloControlTU.Text = "Nuevo Alumno: ";
            activaPestañaControlTU();
            limpiarFormularioTU();
        }

        private void btnEliminarTU_Click(object sender, EventArgs e)
        {
            if (indiceTU > -1)
            {
                p.listaAlumnos.RemoveAt(indiceTU);
                actualizarTU();
                indiceTU = -1;
                if (p.listaAlumnos.Count == 0)
                {
                    btnEliminarTU.Enabled = false;
                    btnModificarTU.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("No se seleccionó ning{un alumno.");
            }
        }

        private void btnModificarTU_Click(object sender, EventArgs e)
        {
            if (indiceTU > -1)
            {
                tu = p.listaAlumnos.ElementAt(indiceTU);
                llenarFormuarioTU();
                tabPageControlTU.Text = "Modificando Tutorado";
                btnControlTU.Text = "Guardar";
                labelTítuloControlTU.Text = "Actualiza datos del alumno: ";
                activaPestañaControlTU();
                indiceTU = -1;
            }
            else
            {
                MessageBox.Show("No se seleccionó ningún alumno.");
            }
        }



        private void btnControlTU_Click(object sender, EventArgs e)
        {
            if (btnControlTU.Text == "Agregar")
            {
                tu = new Tutorado();
                p.listaAlumnos.Add(tu);
            }
            tu.actualizarDatos(txbCodigoTU.Text, txbNombreTU.Text, txbAPAternoTU.Text, txbAMaternoTU.Text, txbCargaHorariaTU.Text, dtpInicioTU.Value, dtpFinTU.Value);

            actualizarTU();

            restauraPaginas();
            tabControl1.SelectedTab = tabPageTutorados;
            limpiarFormularioTU();
        }

        private void btnCancelarTU_Click(object sender, EventArgs e)
        {
            restauraPaginas();
            tabControl1.SelectedTab = tabPageTutorados;
            limpiarFormularioTU();
        }



        private void lvwTutorados_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwTutorados.SelectedIndices.Count > 0)
                indiceTU = lvwTutorados.SelectedIndices[0];
            else
                indiceTU = -1;
        }


        private void activarBtnControlTU()
        {
            bool a, b, c, d, e, f;
            a = validar.ValidarTextBox(txbCodigoTU, lblVerificarCodigoTU, 'n');
            b = validar.ValidarTextBox(txbNombreTU, lblVerificarNombreTU, 't');
            c = validar.ValidarTextBox(txbAPAternoTU, lblVerificarAPaternoTU, 't');
            d = validar.ValidarTextBox(txbAMaternoTU, lblVerificarAMaternoTU, 't');
            e = validar.ValidarTextBox(txbCargaHorariaTU, lblVerificarCargaHorariaTU, 'n');


            if (dtpInicioTU.Value >= dtpFinTU.Value)
            {
                f = false;
                lblVerificarFechasTU.Text = "fechas inconsistentes";
                lblVerificarFechasTU.ForeColor = Color.Red;
            }
            else
            {
                f = true;
                lblVerificarFechasTU.Text = "válido";
                lblVerificarFechasTU.ForeColor = Color.Green;
            }


            if (a && b && c && d && e && f)
            {
                btnControlTU.Enabled = true;
            }
            else
            {
                btnControlTU.Enabled = false;
            }

        }

        private void txbNombreTU_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();
        }

        private void txbAMaternoTU_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();
        }

        private void dtpFinTU_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();
        }

        private void dtpInicioTU_ValueChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();

        }

        private void txbAPAternoTU_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();

        }

        private void txbCodigoTU_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();

        }

        private void txbCargaHorariaTU_TextChanged(object sender, EventArgs e)
        {
            activarBtnControlTU();

        }

        private void buttonWord_Click(object sender, EventArgs e)
        {
            buttonWord.Enabled = false;
            buttonPDF.Enabled = false;
            buttonVistaPrevia.Enabled = false;
            arc = new Curriculum(p,1);
            buttonWord.Enabled = true;
            buttonPDF.Enabled = true;
            buttonVistaPrevia.Enabled = true;
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            buttonWord.Enabled = false;
            buttonPDF.Enabled = false;
            buttonVistaPrevia.Enabled = false;
            arc = new Curriculum(p,2);
            buttonWord.Enabled = true;
            buttonPDF.Enabled = true;
            buttonVistaPrevia.Enabled = true;
        }

        Curriculum arc;
        WebBrowser webBrowser1;

        private void buttonVistaPrevia_Click(object sender, EventArgs e)
        {
            System.Uri a;
            if (webBrowser1 != null)
            {
                
                this.tabPageCurriculum.Controls.Remove(webBrowser1);
                webBrowser1.Dispose();
                File.Delete(@Application.StartupPath.ToString() + "\\aux1.pdf");
                webBrowser1 = null;
            }
 
            buttonWord.Enabled = false;
            buttonPDF.Enabled = false;
            buttonVistaPrevia.Enabled = false;

            this.tabPageCurriculum.Cursor = Cursors.WaitCursor;

            webBrowser1 = new System.Windows.Forms.WebBrowser();
            webBrowser1.Location = new System.Drawing.Point(190, 16);
            webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            webBrowser1.Name = "webBrowser1";
            webBrowser1.Size = new System.Drawing.Size(600, 450);
            webBrowser1.TabIndex = 51;
            webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            webBrowser1.Show();
            this.tabPageCurriculum.Controls.Add(webBrowser1);
            //this.tabControl1.Refresh();

            arc = new Curriculum(p, 3);

            a = new System.Uri(@Application.StartupPath.ToString() + "\\aux1.pdf");
            //webBrowser1.Url = a ;
            webBrowser1.Navigate(a);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.tabPageCurriculum.Cursor = Cursors.Arrow;
            buttonWord.Enabled = true;
            buttonPDF.Enabled = true;
            buttonVistaPrevia.Enabled = true;
        }

        private void Form_Usuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (webBrowser1 != null)
            {
                this.tabPageCurriculum.Controls.Remove(webBrowser1);
                webBrowser1.Dispose();

                File.Delete(@Application.StartupPath.ToString() + "\\aux1.pdf");
                webBrowser1 = null;
            }
            if (File.Exists(Application.StartupPath.ToString() + "\\PlantillaWord.docx"))
            {
                File.Delete(Application.StartupPath.ToString() + "\\PlantillaWord.docx"); 
            }


            
            ant.WindowState = FormWindowState.Minimized;
            ant.WindowState = FormWindowState.Normal;
            ant.Visible = true;
        }

        private void cboGradoAcademico_SelectedIndexChanged(object sender, EventArgs e)
        {
            activarBtnControlFA();
        }
    }
}
#endregion