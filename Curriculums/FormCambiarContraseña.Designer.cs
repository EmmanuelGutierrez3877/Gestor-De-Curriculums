namespace Curriculums
{
    partial class FormCambiarContraseña
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCambiarContraseña));
            this.textBoxAnterior = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNueva = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNueva2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonCambiar = new System.Windows.Forms.Button();
            this.labelVerificarNueva = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxAnterior
            // 
            this.textBoxAnterior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxAnterior.Location = new System.Drawing.Point(245, 41);
            this.textBoxAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxAnterior.Name = "textBoxAnterior";
            this.textBoxAnterior.Size = new System.Drawing.Size(323, 30);
            this.textBoxAnterior.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Contraseña anterior : ";
            // 
            // textBoxNueva
            // 
            this.textBoxNueva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNueva.Location = new System.Drawing.Point(245, 80);
            this.textBoxNueva.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNueva.Name = "textBoxNueva";
            this.textBoxNueva.Size = new System.Drawing.Size(323, 30);
            this.textBoxNueva.TabIndex = 9;
            this.textBoxNueva.TextChanged += new System.EventHandler(this.textBoxNueva_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(143, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nueva : ";
            // 
            // textBoxNueva2
            // 
            this.textBoxNueva2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxNueva2.Location = new System.Drawing.Point(245, 119);
            this.textBoxNueva2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxNueva2.Name = "textBoxNueva2";
            this.textBoxNueva2.Size = new System.Drawing.Size(323, 30);
            this.textBoxNueva2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(111, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "De nuevo : ";
            // 
            // buttonCambiar
            // 
            this.buttonCambiar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCambiar.Location = new System.Drawing.Point(273, 172);
            this.buttonCambiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonCambiar.Name = "buttonCambiar";
            this.buttonCambiar.Size = new System.Drawing.Size(119, 43);
            this.buttonCambiar.TabIndex = 13;
            this.buttonCambiar.Text = "Cambiar";
            this.buttonCambiar.UseVisualStyleBackColor = true;
            this.buttonCambiar.Click += new System.EventHandler(this.buttonCambiar_Click);
            // 
            // labelVerificarNueva
            // 
            this.labelVerificarNueva.AutoSize = true;
            this.labelVerificarNueva.BackColor = System.Drawing.Color.Transparent;
            this.labelVerificarNueva.Location = new System.Drawing.Point(576, 89);
            this.labelVerificarNueva.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVerificarNueva.Name = "labelVerificarNueva";
            this.labelVerificarNueva.Size = new System.Drawing.Size(46, 17);
            this.labelVerificarNueva.TabIndex = 14;
            this.labelVerificarNueva.Text = "label1";
            // 
            // FormCambiarContraseña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Curriculums.Properties.Resources.Fondo_abstracto_HTC_10_700x463;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(697, 247);
            this.Controls.Add(this.labelVerificarNueva);
            this.Controls.Add(this.buttonCambiar);
            this.Controls.Add(this.textBoxNueva2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNueva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxAnterior);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FormCambiarContraseña";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCambiarContraseña_FormClosed);
            this.Load += new System.EventHandler(this.FormCambiarContraseña_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNueva;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNueva2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonCambiar;
        private System.Windows.Forms.Label labelVerificarNueva;
    }
}