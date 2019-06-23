namespace DoctoDom.UI
{
    partial class frmRegisterUser
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.gbxDatosGenerales = new System.Windows.Forms.GroupBox();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.gbxCredenciales = new System.Windows.Forms.GroupBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.gbxInfoContacto = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbxDatosGenerales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.gbxCredenciales.SuspendLayout();
            this.gbxInfoContacto.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGuardar.BackColor = System.Drawing.Color.Navy;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(627, 441);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(127, 33);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // gbxDatosGenerales
            // 
            this.gbxDatosGenerales.Controls.Add(this.dtpFechaNacimiento);
            this.gbxDatosGenerales.Controls.Add(this.label5);
            this.gbxDatosGenerales.Controls.Add(this.txtApellidos);
            this.gbxDatosGenerales.Controls.Add(this.label4);
            this.gbxDatosGenerales.Controls.Add(this.txtNombres);
            this.gbxDatosGenerales.Controls.Add(this.label3);
            this.gbxDatosGenerales.Controls.Add(this.txtCedula);
            this.gbxDatosGenerales.Controls.Add(this.label2);
            this.gbxDatosGenerales.Controls.Add(this.label1);
            this.gbxDatosGenerales.Controls.Add(this.pbxFoto);
            this.gbxDatosGenerales.Location = new System.Drawing.Point(12, 12);
            this.gbxDatosGenerales.Name = "gbxDatosGenerales";
            this.gbxDatosGenerales.Size = new System.Drawing.Size(746, 144);
            this.gbxDatosGenerales.TabIndex = 1;
            this.gbxDatosGenerales.TabStop = false;
            this.gbxDatosGenerales.Text = "Datos generales";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(127, 110);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(472, 20);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Tag = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Fecha de nacimiento:*";
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(69, 84);
            this.txtApellidos.MaxLength = 80;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(530, 20);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Tag = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Apellidos:*";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(69, 58);
            this.txtNombres.MaxLength = 80;
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(530, 20);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Tag = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombres:*";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(69, 32);
            this.txtCedula.MaxLength = 13;
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(530, 20);
            this.txtCedula.TabIndex = 0;
            this.txtCedula.Tag = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula:*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(612, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Foto:";
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.Location = new System.Drawing.Point(615, 32);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(113, 98);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 0;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.DoubleClick += new System.EventHandler(this.pbxFoto_DoubleClick);
            // 
            // gbxCredenciales
            // 
            this.gbxCredenciales.Controls.Add(this.txtClave);
            this.gbxCredenciales.Controls.Add(this.label12);
            this.gbxCredenciales.Controls.Add(this.txtUsuario);
            this.gbxCredenciales.Controls.Add(this.label13);
            this.gbxCredenciales.Location = new System.Drawing.Point(12, 162);
            this.gbxCredenciales.Name = "gbxCredenciales";
            this.gbxCredenciales.Size = new System.Drawing.Size(746, 90);
            this.gbxCredenciales.TabIndex = 1;
            this.gbxCredenciales.TabStop = false;
            this.gbxCredenciales.Text = "Credenciales";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(69, 58);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '•';
            this.txtClave.Size = new System.Drawing.Size(530, 20);
            this.txtClave.TabIndex = 5;
            this.txtClave.Tag = "Clave";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 61);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Clave:*";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(69, 32);
            this.txtUsuario.MaxLength = 10;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(530, 20);
            this.txtUsuario.TabIndex = 4;
            this.txtUsuario.Tag = "Usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(6, 35);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Usuario:*";
            // 
            // gbxInfoContacto
            // 
            this.gbxInfoContacto.Controls.Add(this.txtEmail);
            this.gbxInfoContacto.Controls.Add(this.label9);
            this.gbxInfoContacto.Controls.Add(this.txtTelefono);
            this.gbxInfoContacto.Controls.Add(this.txtCelular);
            this.gbxInfoContacto.Controls.Add(this.label6);
            this.gbxInfoContacto.Controls.Add(this.label8);
            this.gbxInfoContacto.Controls.Add(this.txtDireccion);
            this.gbxInfoContacto.Controls.Add(this.label7);
            this.gbxInfoContacto.Location = new System.Drawing.Point(12, 258);
            this.gbxInfoContacto.Name = "gbxInfoContacto";
            this.gbxInfoContacto.Size = new System.Drawing.Size(746, 151);
            this.gbxInfoContacto.TabIndex = 5;
            this.gbxInfoContacto.TabStop = false;
            this.gbxInfoContacto.Text = "Información de contacto";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(108, 112);
            this.txtEmail.MaxLength = 60;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(491, 20);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.Tag = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 3;
            this.label9.Tag = "Correo electrónico:";
            this.label9.Text = "Correo electrónico:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(69, 58);
            this.txtTelefono.MaxLength = 20;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(530, 20);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Tag = "";
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(69, 86);
            this.txtCelular.MaxLength = 20;
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(530, 20);
            this.txtCelular.TabIndex = 8;
            this.txtCelular.Tag = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Teléfono:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Celular:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(69, 32);
            this.txtDireccion.MaxLength = 250;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(530, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.Tag = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Dirección:";
            // 
            // frmRegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(768, 475);
            this.Controls.Add(this.gbxInfoContacto);
            this.Controls.Add(this.gbxCredenciales);
            this.Controls.Add(this.gbxDatosGenerales);
            this.Controls.Add(this.btnGuardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmRegisterUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmRegisterUser_Load);
            this.gbxDatosGenerales.ResumeLayout(false);
            this.gbxDatosGenerales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.gbxCredenciales.ResumeLayout(false);
            this.gbxCredenciales.PerformLayout();
            this.gbxInfoContacto.ResumeLayout(false);
            this.gbxInfoContacto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox gbxDatosGenerales;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.GroupBox gbxCredenciales;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbxInfoContacto;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label7;
    }
}