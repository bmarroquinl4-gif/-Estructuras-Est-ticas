namespace ListaContactos
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
            this.gbLista = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnELiminar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lstContactos = new System.Windows.Forms.ListBox();
            this.btnVerTodos = new System.Windows.Forms.Button();
            this.gbTelefonos = new System.Windows.Forms.GroupBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.btnEliminarTelefono = new System.Windows.Forms.Button();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.lstTelefonos = new System.Windows.Forms.ListBox();
            this.gbPalabras = new System.Windows.Forms.GroupBox();
            this.txtPalabra = new System.Windows.Forms.TextBox();
            this.btnEliminarPalabra = new System.Windows.Forms.Button();
            this.btnAgregarPalabra = new System.Windows.Forms.Button();
            this.lstPalabras = new System.Windows.Forms.ListBox();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarContacto = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.gbLista.SuspendLayout();
            this.gbTelefonos.SuspendLayout();
            this.gbPalabras.SuspendLayout();
            this.gbDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLista
            // 
            this.gbLista.Controls.Add(this.txtBuscar);
            this.gbLista.Controls.Add(this.btnELiminar);
            this.gbLista.Controls.Add(this.btnVer);
            this.gbLista.Controls.Add(this.groupBox1);
            this.gbLista.Controls.Add(this.btnBuscar);
            this.gbLista.Controls.Add(this.lstContactos);
            this.gbLista.Controls.Add(this.btnVerTodos);
            this.gbLista.Location = new System.Drawing.Point(6, 12);
            this.gbLista.Name = "gbLista";
            this.gbLista.Size = new System.Drawing.Size(452, 189);
            this.gbLista.TabIndex = 0;
            this.gbLista.TabStop = false;
            this.gbLista.Text = "Lista de Contactos";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(288, 89);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(127, 22);
            this.txtBuscar.TabIndex = 10;
            // 
            // btnELiminar
            // 
            this.btnELiminar.Location = new System.Drawing.Point(325, 160);
            this.btnELiminar.Name = "btnELiminar";
            this.btnELiminar.Size = new System.Drawing.Size(75, 23);
            this.btnELiminar.TabIndex = 6;
            this.btnELiminar.Text = "Eliminar";
            this.btnELiminar.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(311, 124);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(106, 23);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(477, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(267, 60);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(172, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar por palabra clave";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click_1);
            // 
            // lstContactos
            // 
            this.lstContactos.FormattingEnabled = true;
            this.lstContactos.ItemHeight = 16;
            this.lstContactos.Location = new System.Drawing.Point(7, 22);
            this.lstContactos.Name = "lstContactos";
            this.lstContactos.Size = new System.Drawing.Size(254, 164);
            this.lstContactos.TabIndex = 0;
            this.lstContactos.SelectedIndexChanged += new System.EventHandler(this.lstContactos_SelectedIndexChanged_1);
            // 
            // btnVerTodos
            // 
            this.btnVerTodos.Location = new System.Drawing.Point(326, 22);
            this.btnVerTodos.Name = "btnVerTodos";
            this.btnVerTodos.Size = new System.Drawing.Size(75, 23);
            this.btnVerTodos.TabIndex = 5;
            this.btnVerTodos.Text = "Ver todos";
            this.btnVerTodos.UseVisualStyleBackColor = true;
            this.btnVerTodos.Click += new System.EventHandler(this.btnVerTodos_Click);
            // 
            // gbTelefonos
            // 
            this.gbTelefonos.Controls.Add(this.txtTelefono);
            this.gbTelefonos.Controls.Add(this.btnEliminarTelefono);
            this.gbTelefonos.Controls.Add(this.btnAgregarTelefono);
            this.gbTelefonos.Controls.Add(this.lstTelefonos);
            this.gbTelefonos.Location = new System.Drawing.Point(489, 12);
            this.gbTelefonos.Name = "gbTelefonos";
            this.gbTelefonos.Size = new System.Drawing.Size(441, 189);
            this.gbTelefonos.TabIndex = 2;
            this.gbTelefonos.TabStop = false;
            this.gbTelefonos.Text = "Telefonos";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(308, 73);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(127, 22);
            this.txtTelefono.TabIndex = 8;
            // 
            // btnEliminarTelefono
            // 
            this.btnEliminarTelefono.Location = new System.Drawing.Point(307, 118);
            this.btnEliminarTelefono.Name = "btnEliminarTelefono";
            this.btnEliminarTelefono.Size = new System.Drawing.Size(128, 34);
            this.btnEliminarTelefono.TabIndex = 7;
            this.btnEliminarTelefono.Text = "Eliminar telefono";
            this.btnEliminarTelefono.UseVisualStyleBackColor = true;
            this.btnEliminarTelefono.Click += new System.EventHandler(this.btnEliminarTelefono_Click);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.Location = new System.Drawing.Point(308, 22);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(128, 34);
            this.btnAgregarTelefono.TabIndex = 6;
            this.btnAgregarTelefono.Text = "Agregar Telefono";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // lstTelefonos
            // 
            this.lstTelefonos.FormattingEnabled = true;
            this.lstTelefonos.ItemHeight = 16;
            this.lstTelefonos.Location = new System.Drawing.Point(6, 35);
            this.lstTelefonos.Name = "lstTelefonos";
            this.lstTelefonos.Size = new System.Drawing.Size(265, 148);
            this.lstTelefonos.TabIndex = 1;
            // 
            // gbPalabras
            // 
            this.gbPalabras.Controls.Add(this.txtPalabra);
            this.gbPalabras.Controls.Add(this.btnEliminarPalabra);
            this.gbPalabras.Controls.Add(this.btnAgregarPalabra);
            this.gbPalabras.Controls.Add(this.lstPalabras);
            this.gbPalabras.Location = new System.Drawing.Point(955, 12);
            this.gbPalabras.Name = "gbPalabras";
            this.gbPalabras.Size = new System.Drawing.Size(462, 189);
            this.gbPalabras.TabIndex = 3;
            this.gbPalabras.TabStop = false;
            this.gbPalabras.Text = "Palabras Clave";
            // 
            // txtPalabra
            // 
            this.txtPalabra.Location = new System.Drawing.Point(303, 75);
            this.txtPalabra.Name = "txtPalabra";
            this.txtPalabra.Size = new System.Drawing.Size(127, 22);
            this.txtPalabra.TabIndex = 9;
            // 
            // btnEliminarPalabra
            // 
            this.btnEliminarPalabra.Location = new System.Drawing.Point(303, 118);
            this.btnEliminarPalabra.Name = "btnEliminarPalabra";
            this.btnEliminarPalabra.Size = new System.Drawing.Size(128, 34);
            this.btnEliminarPalabra.TabIndex = 8;
            this.btnEliminarPalabra.Text = "Eliminar Palabra";
            this.btnEliminarPalabra.UseVisualStyleBackColor = true;
            this.btnEliminarPalabra.Click += new System.EventHandler(this.btnEliminarPalabra_Click);
            // 
            // btnAgregarPalabra
            // 
            this.btnAgregarPalabra.Location = new System.Drawing.Point(303, 35);
            this.btnAgregarPalabra.Name = "btnAgregarPalabra";
            this.btnAgregarPalabra.Size = new System.Drawing.Size(128, 34);
            this.btnAgregarPalabra.TabIndex = 7;
            this.btnAgregarPalabra.Text = "Agregar Palabra";
            this.btnAgregarPalabra.UseVisualStyleBackColor = true;
            this.btnAgregarPalabra.Click += new System.EventHandler(this.btnAgregarPalabra_Click);
            // 
            // lstPalabras
            // 
            this.lstPalabras.FormattingEnabled = true;
            this.lstPalabras.ItemHeight = 16;
            this.lstPalabras.Location = new System.Drawing.Point(6, 35);
            this.lstPalabras.Name = "lstPalabras";
            this.lstPalabras.Size = new System.Drawing.Size(265, 148);
            this.lstPalabras.TabIndex = 1;
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.txtCorreo);
            this.gbDatos.Controls.Add(this.txtDireccion);
            this.gbDatos.Controls.Add(this.txtApellido);
            this.gbDatos.Controls.Add(this.txtNombre);
            this.gbDatos.Controls.Add(this.label4);
            this.gbDatos.Controls.Add(this.label3);
            this.gbDatos.Controls.Add(this.label2);
            this.gbDatos.Controls.Add(this.label1);
            this.gbDatos.Location = new System.Drawing.Point(332, 255);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(769, 189);
            this.gbDatos.TabIndex = 4;
            this.gbDatos.TabStop = false;
            this.gbDatos.Text = "Datos Personales";
            // 
            // txtCorreo
            // 
            this.txtCorreo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtCorreo.Location = new System.Drawing.Point(119, 147);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(420, 22);
            this.txtCorreo.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtDireccion.Location = new System.Drawing.Point(119, 112);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(420, 22);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtApellido.Location = new System.Drawing.Point(119, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(420, 22);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtNombre.Location = new System.Drawing.Point(119, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(420, 22);
            this.txtNombre.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Direccion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Correo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnAgregarContacto
            // 
            this.btnAgregarContacto.Location = new System.Drawing.Point(294, 207);
            this.btnAgregarContacto.Name = "btnAgregarContacto";
            this.btnAgregarContacto.Size = new System.Drawing.Size(164, 32);
            this.btnAgregarContacto.TabIndex = 7;
            this.btnAgregarContacto.Text = "Agregar Contacto";
            this.btnAgregarContacto.UseVisualStyleBackColor = true;
            this.btnAgregarContacto.Click += new System.EventHandler(this.btnAgregarContacto_Click);
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(669, 207);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(164, 32);
            this.btnModificarContacto.TabIndex = 8;
            this.btnModificarContacto.Text = "Modificar Contacto";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            this.btnModificarContacto.Click += new System.EventHandler(this.btnModificarContacto_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(999, 207);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 32);
            this.btnLimpiar.TabIndex = 9;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 491);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.btnAgregarContacto);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.gbPalabras);
            this.Controls.Add(this.gbTelefonos);
            this.Controls.Add(this.gbLista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbLista.ResumeLayout(false);
            this.gbLista.PerformLayout();
            this.gbTelefonos.ResumeLayout(false);
            this.gbTelefonos.PerformLayout();
            this.gbPalabras.ResumeLayout(false);
            this.gbPalabras.PerformLayout();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLista;
        private System.Windows.Forms.ListBox lstContactos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbTelefonos;
        private System.Windows.Forms.ListBox lstTelefonos;
        private System.Windows.Forms.GroupBox gbPalabras;
        private System.Windows.Forms.ListBox lstPalabras;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerTodos;
        private System.Windows.Forms.Button btnELiminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.Button btnEliminarTelefono;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Button btnAgregarPalabra;
        private System.Windows.Forms.Button btnEliminarPalabra;
        private System.Windows.Forms.Button btnAgregarContacto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.TextBox txtPalabra;
    }
}

