namespace proyecto04
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblnombre = new System.Windows.Forms.Label();
            this.btborrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.gpGenero = new System.Windows.Forms.GroupBox();
            this.rbMujer = new System.Windows.Forms.RadioButton();
            this.rbHombre = new System.Windows.Forms.RadioButton();
            this.tbedad = new System.Windows.Forms.TextBox();
            this.tbestatura = new System.Windows.Forms.TextBox();
            this.tbtelefono = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbledad = new System.Windows.Forms.Label();
            this.lblestatura = new System.Windows.Forms.Label();
            this.lbltelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gpGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(135, 58);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(0, 13);
            this.lblnombre.TabIndex = 1;
            // 
            // btborrar
            // 
            this.btborrar.Location = new System.Drawing.Point(231, 402);
            this.btborrar.Name = "btborrar";
            this.btborrar.Size = new System.Drawing.Size(114, 44);
            this.btborrar.TabIndex = 27;
            this.btborrar.Text = "Borrar";
            this.btborrar.UseVisualStyleBackColor = true;
            this.btborrar.Click += new System.EventHandler(this.btborrar_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 45);
            this.button1.TabIndex = 26;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpGenero
            // 
            this.gpGenero.Controls.Add(this.rbMujer);
            this.gpGenero.Controls.Add(this.rbHombre);
            this.gpGenero.Location = new System.Drawing.Point(164, 224);
            this.gpGenero.Name = "gpGenero";
            this.gpGenero.Size = new System.Drawing.Size(200, 100);
            this.gpGenero.TabIndex = 25;
            this.gpGenero.TabStop = false;
            this.gpGenero.Text = "Genero";
            // 
            // rbMujer
            // 
            this.rbMujer.AutoSize = true;
            this.rbMujer.Location = new System.Drawing.Point(109, 34);
            this.rbMujer.Name = "rbMujer";
            this.rbMujer.Size = new System.Drawing.Size(51, 17);
            this.rbMujer.TabIndex = 13;
            this.rbMujer.TabStop = true;
            this.rbMujer.Text = "Mujer";
            this.rbMujer.UseVisualStyleBackColor = true;
            // 
            // rbHombre
            // 
            this.rbHombre.AutoSize = true;
            this.rbHombre.Location = new System.Drawing.Point(6, 34);
            this.rbHombre.Name = "rbHombre";
            this.rbHombre.Size = new System.Drawing.Size(65, 17);
            this.rbHombre.TabIndex = 12;
            this.rbHombre.TabStop = true;
            this.rbHombre.Text = "Hombre ";
            this.rbHombre.UseVisualStyleBackColor = true;
            // 
            // tbedad
            // 
            this.tbedad.Location = new System.Drawing.Point(245, 170);
            this.tbedad.Name = "tbedad";
            this.tbedad.Size = new System.Drawing.Size(100, 20);
            this.tbedad.TabIndex = 24;
            // 
            // tbestatura
            // 
            this.tbestatura.Location = new System.Drawing.Point(245, 135);
            this.tbestatura.Name = "tbestatura";
            this.tbestatura.Size = new System.Drawing.Size(100, 20);
            this.tbestatura.TabIndex = 23;
            // 
            // tbtelefono
            // 
            this.tbtelefono.Location = new System.Drawing.Point(245, 97);
            this.tbtelefono.Name = "tbtelefono";
            this.tbtelefono.Size = new System.Drawing.Size(100, 20);
            this.tbtelefono.TabIndex = 22;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(245, 57);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.Size = new System.Drawing.Size(100, 20);
            this.tbapellido.TabIndex = 21;
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(245, 26);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(306, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 19;
            // 
            // lbledad
            // 
            this.lbledad.AutoSize = true;
            this.lbledad.Location = new System.Drawing.Point(161, 170);
            this.lbledad.Name = "lbledad";
            this.lbledad.Size = new System.Drawing.Size(32, 13);
            this.lbledad.TabIndex = 18;
            this.lbledad.Text = "Edad";
            // 
            // lblestatura
            // 
            this.lblestatura.AutoSize = true;
            this.lblestatura.Location = new System.Drawing.Point(161, 135);
            this.lblestatura.Name = "lblestatura";
            this.lblestatura.Size = new System.Drawing.Size(46, 13);
            this.lblestatura.TabIndex = 17;
            this.lblestatura.Text = "Estatura";
            // 
            // lbltelefono
            // 
            this.lbltelefono.AutoSize = true;
            this.lbltelefono.Location = new System.Drawing.Point(161, 100);
            this.lbltelefono.Name = "lbltelefono";
            this.lbltelefono.Size = new System.Drawing.Size(49, 13);
            this.lbltelefono.TabIndex = 16;
            this.lbltelefono.Text = "Telefono";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(161, 60);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 15;
            this.lblApellido.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyecto04.Properties.Resources.Captura_de_pantalla__80_;
            this.ClientSize = new System.Drawing.Size(868, 482);
            this.Controls.Add(this.btborrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpGenero);
            this.Controls.Add(this.tbedad);
            this.Controls.Add(this.tbestatura);
            this.Controls.Add(this.tbtelefono);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbledad);
            this.Controls.Add(this.lblestatura);
            this.Controls.Add(this.lbltelefono);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gpGenero.ResumeLayout(false);
            this.gpGenero.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Button btborrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gpGenero;
        private System.Windows.Forms.RadioButton rbMujer;
        private System.Windows.Forms.RadioButton rbHombre;
        private System.Windows.Forms.TextBox tbedad;
        private System.Windows.Forms.TextBox tbestatura;
        private System.Windows.Forms.TextBox tbtelefono;
        private System.Windows.Forms.TextBox tbapellido;
        private System.Windows.Forms.TextBox tbnombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbledad;
        private System.Windows.Forms.Label lblestatura;
        private System.Windows.Forms.Label lbltelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label label1;
    }
}

