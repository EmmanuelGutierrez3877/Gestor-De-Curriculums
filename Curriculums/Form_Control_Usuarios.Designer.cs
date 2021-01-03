namespace Curriculums
{
    partial class Form_Control_Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Control_Usuarios));
            this.listViewProfesores = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCodigo = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.labelCodigo = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.labelApellidoP = new System.Windows.Forms.Label();
            this.textBoxApellidoP = new System.Windows.Forms.TextBox();
            this.labelVerificarNombre = new System.Windows.Forms.Label();
            this.labelVerificarApellidoP = new System.Windows.Forms.Label();
            this.labelVerificarContraseña = new System.Windows.Forms.Label();
            this.labelVerificarApellidoM = new System.Windows.Forms.Label();
            this.labelApellidoM = new System.Windows.Forms.Label();
            this.textBoxApellidoM = new System.Windows.Forms.TextBox();
            this.buttonCambiarContraseña = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listViewProfesores
            // 
            this.listViewProfesores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewProfesores.ImeMode = System.Windows.Forms.ImeMode.On;
            this.listViewProfesores.Location = new System.Drawing.Point(595, 15);
            this.listViewProfesores.Margin = new System.Windows.Forms.Padding(4);
            this.listViewProfesores.MultiSelect = false;
            this.listViewProfesores.Name = "listViewProfesores";
            this.listViewProfesores.Size = new System.Drawing.Size(689, 568);
            this.listViewProfesores.TabIndex = 0;
            this.listViewProfesores.UseCompatibleStateImageBehavior = false;
            this.listViewProfesores.View = System.Windows.Forms.View.Details;
            this.listViewProfesores.SelectedIndexChanged += new System.EventHandler(this.listViewProfesores_SelectedIndexChanged);
            this.listViewProfesores.DoubleClick += new System.EventHandler(this.listViewProfesores_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nuevo Profesor : ";
            // 
            // textBoxCodigo
            // 
            this.textBoxCodigo.Enabled = false;
            this.textBoxCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCodigo.Location = new System.Drawing.Point(169, 119);
            this.textBoxCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCodigo.Name = "textBoxCodigo";
            this.textBoxCodigo.Size = new System.Drawing.Size(347, 30);
            this.textBoxCodigo.TabIndex = 2;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNombre.Location = new System.Drawing.Point(171, 158);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(347, 30);
            this.textBoxNombre.TabIndex = 3;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxContraseña.Location = new System.Drawing.Point(169, 271);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(347, 30);
            this.textBoxContraseña.TabIndex = 6;
            this.textBoxContraseña.TextChanged += new System.EventHandler(this.textBoxContraseña_TextChanged);
            // 
            // labelCodigo
            // 
            this.labelCodigo.AutoSize = true;
            this.labelCodigo.BackColor = System.Drawing.Color.Transparent;
            this.labelCodigo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigo.Location = new System.Drawing.Point(56, 123);
            this.labelCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCodigo.Name = "labelCodigo";
            this.labelCodigo.Size = new System.Drawing.Size(96, 24);
            this.labelCodigo.TabIndex = 5;
            this.labelCodigo.Text = "Codigo : ";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(25, 161);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(128, 24);
            this.labelNombre.TabIndex = 6;
            this.labelNombre.Text = "Nombre(s) : ";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContraseña.Location = new System.Drawing.Point(11, 276);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(138, 24);
            this.labelContraseña.TabIndex = 7;
            this.labelContraseña.Text = "Contraseña : ";
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Enabled = false;
            this.buttonAgregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAgregar.Location = new System.Drawing.Point(225, 324);
            this.buttonAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(117, 41);
            this.buttonAgregar.TabIndex = 7;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Enabled = false;
            this.buttonEliminar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEliminar.Location = new System.Drawing.Point(463, 542);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(117, 41);
            this.buttonEliminar.TabIndex = 9;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // labelApellidoP
            // 
            this.labelApellidoP.AutoSize = true;
            this.labelApellidoP.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoP.Location = new System.Drawing.Point(25, 199);
            this.labelApellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoP.Name = "labelApellidoP";
            this.labelApellidoP.Size = new System.Drawing.Size(128, 24);
            this.labelApellidoP.TabIndex = 11;
            this.labelApellidoP.Text = "A. Paterno : ";
            // 
            // textBoxApellidoP
            // 
            this.textBoxApellidoP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoP.Location = new System.Drawing.Point(171, 194);
            this.textBoxApellidoP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoP.Name = "textBoxApellidoP";
            this.textBoxApellidoP.Size = new System.Drawing.Size(347, 30);
            this.textBoxApellidoP.TabIndex = 4;
            this.textBoxApellidoP.TextChanged += new System.EventHandler(this.textBoxApellidos_TextChanged);
            // 
            // labelVerificarNombre
            // 
            this.labelVerificarNombre.AutoSize = true;
            this.labelVerificarNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelVerificarNombre.Location = new System.Drawing.Point(525, 166);
            this.labelVerificarNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificarNombre.Name = "labelVerificarNombre";
            this.labelVerificarNombre.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarNombre.TabIndex = 12;
            this.labelVerificarNombre.Text = "label1";
            // 
            // labelVerificarApellidoP
            // 
            this.labelVerificarApellidoP.AutoSize = true;
            this.labelVerificarApellidoP.BackColor = System.Drawing.Color.Transparent;
            this.labelVerificarApellidoP.Location = new System.Drawing.Point(525, 204);
            this.labelVerificarApellidoP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificarApellidoP.Name = "labelVerificarApellidoP";
            this.labelVerificarApellidoP.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarApellidoP.TabIndex = 13;
            this.labelVerificarApellidoP.Text = "label2";
            // 
            // labelVerificarContraseña
            // 
            this.labelVerificarContraseña.AutoSize = true;
            this.labelVerificarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.labelVerificarContraseña.Location = new System.Drawing.Point(524, 281);
            this.labelVerificarContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificarContraseña.Name = "labelVerificarContraseña";
            this.labelVerificarContraseña.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarContraseña.TabIndex = 14;
            this.labelVerificarContraseña.Text = "label3";
            // 
            // labelVerificarApellidoM
            // 
            this.labelVerificarApellidoM.AutoSize = true;
            this.labelVerificarApellidoM.BackColor = System.Drawing.Color.Transparent;
            this.labelVerificarApellidoM.Location = new System.Drawing.Point(525, 242);
            this.labelVerificarApellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificarApellidoM.Name = "labelVerificarApellidoM";
            this.labelVerificarApellidoM.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarApellidoM.TabIndex = 17;
            this.labelVerificarApellidoM.Text = "label2";
            // 
            // labelApellidoM
            // 
            this.labelApellidoM.AutoSize = true;
            this.labelApellidoM.BackColor = System.Drawing.Color.Transparent;
            this.labelApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidoM.Location = new System.Drawing.Point(21, 238);
            this.labelApellidoM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidoM.Name = "labelApellidoM";
            this.labelApellidoM.Size = new System.Drawing.Size(132, 24);
            this.labelApellidoM.TabIndex = 16;
            this.labelApellidoM.Text = "A. Maertno : ";
            // 
            // textBoxApellidoM
            // 
            this.textBoxApellidoM.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxApellidoM.Location = new System.Drawing.Point(171, 233);
            this.textBoxApellidoM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxApellidoM.Name = "textBoxApellidoM";
            this.textBoxApellidoM.Size = new System.Drawing.Size(347, 30);
            this.textBoxApellidoM.TabIndex = 5;
            this.textBoxApellidoM.TextChanged += new System.EventHandler(this.textBoxApellidoM_TextChanged);
            // 
            // buttonCambiarContraseña
            // 
            this.buttonCambiarContraseña.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiarContraseña.Location = new System.Drawing.Point(16, 523);
            this.buttonCambiarContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCambiarContraseña.Name = "buttonCambiarContraseña";
            this.buttonCambiarContraseña.Size = new System.Drawing.Size(229, 59);
            this.buttonCambiarContraseña.TabIndex = 18;
            this.buttonCambiarContraseña.Text = "Cambiar contraseña del administrador";
            this.buttonCambiarContraseña.UseVisualStyleBackColor = true;
            this.buttonCambiarContraseña.Click += new System.EventHandler(this.buttonCambiarContraseña_Click);
            // 
            // Form_Control_Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.ClientSize = new System.Drawing.Size(1301, 598);
            this.Controls.Add(this.buttonCambiarContraseña);
            this.Controls.Add(this.labelVerificarApellidoM);
            this.Controls.Add(this.labelApellidoM);
            this.Controls.Add(this.textBoxApellidoM);
            this.Controls.Add(this.labelVerificarContraseña);
            this.Controls.Add(this.labelVerificarApellidoP);
            this.Controls.Add(this.labelVerificarNombre);
            this.Controls.Add(this.labelApellidoP);
            this.Controls.Add(this.textBoxApellidoP);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelCodigo);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listViewProfesores);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_Control_Usuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control De Usuarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Control_Usuarios_FormClosed);
            this.Load += new System.EventHandler(this.Form_Control_Usuarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewProfesores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCodigo;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Label labelCodigo;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Label labelApellidoP;
        private System.Windows.Forms.TextBox textBoxApellidoP;
        private System.Windows.Forms.Label labelVerificarNombre;
        private System.Windows.Forms.Label labelVerificarApellidoP;
        private System.Windows.Forms.Label labelVerificarContraseña;
        private System.Windows.Forms.Label labelVerificarApellidoM;
        private System.Windows.Forms.Label labelApellidoM;
        private System.Windows.Forms.TextBox textBoxApellidoM;
        private System.Windows.Forms.Button buttonCambiarContraseña;
    }
}