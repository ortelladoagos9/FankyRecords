namespace FankyRecords.C_presentacion.Administrativo
{
    partial class MiUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MiUsuario));
            this.contenedorFotoBotones = new System.Windows.Forms.Panel();
            this.picFotoUsuario = new System.Windows.Forms.PictureBox();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.LMiUsuario = new System.Windows.Forms.Label();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.rutaFoto = new System.Windows.Forms.TextBox();
            this.Bfoto = new System.Windows.Forms.Button();
            this.TBconfirmarClave = new System.Windows.Forms.TextBox();
            this.TBclave = new System.Windows.Forms.TextBox();
            this.LConfirmarContraseña = new System.Windows.Forms.Label();
            this.LContraseña = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.DTFechanac = new System.Windows.Forms.DateTimePicker();
            this.LDireccion = new System.Windows.Forms.Label();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.LTelefono = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contenedorFotoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).BeginInit();
            this.contenedorDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // contenedorFotoBotones
            // 
            this.contenedorFotoBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorFotoBotones.Controls.Add(this.picFotoUsuario);
            this.contenedorFotoBotones.Controls.Add(this.Beditar);
            this.contenedorFotoBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorFotoBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorFotoBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorFotoBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorFotoBotones.Name = "contenedorFotoBotones";
            this.contenedorFotoBotones.Size = new System.Drawing.Size(359, 739);
            this.contenedorFotoBotones.TabIndex = 18;
            // 
            // picFotoUsuario
            // 
            this.picFotoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picFotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoUsuario.BackgroundImage")));
            this.picFotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFotoUsuario.Location = new System.Drawing.Point(110, 201);
            this.picFotoUsuario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picFotoUsuario.Name = "picFotoUsuario";
            this.picFotoUsuario.Size = new System.Drawing.Size(206, 206);
            this.picFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUsuario.TabIndex = 2;
            this.picFotoUsuario.TabStop = false;
            // 
            // Beditar
            // 
            this.Beditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Beditar.BackColor = System.Drawing.Color.Navy;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beditar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Beditar.IconColor = System.Drawing.Color.White;
            this.Beditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beditar.IconSize = 35;
            this.Beditar.Location = new System.Drawing.Point(110, 465);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(206, 76);
            this.Beditar.TabIndex = 9;
            this.Beditar.Text = "Guardar Cambios";
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // LMiUsuario
            // 
            this.LMiUsuario.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LMiUsuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.LMiUsuario.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LMiUsuario.ForeColor = System.Drawing.Color.DarkRed;
            this.LMiUsuario.Location = new System.Drawing.Point(359, 0);
            this.LMiUsuario.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LMiUsuario.Name = "LMiUsuario";
            this.LMiUsuario.Size = new System.Drawing.Size(1059, 69);
            this.LMiUsuario.TabIndex = 19;
            this.LMiUsuario.Text = "Mi Usuario";
            this.LMiUsuario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.rutaFoto);
            this.contenedorDatos.Controls.Add(this.Bfoto);
            this.contenedorDatos.Controls.Add(this.TBconfirmarClave);
            this.contenedorDatos.Controls.Add(this.TBclave);
            this.contenedorDatos.Controls.Add(this.LConfirmarContraseña);
            this.contenedorDatos.Controls.Add(this.LContraseña);
            this.contenedorDatos.Controls.Add(this.TBemail);
            this.contenedorDatos.Controls.Add(this.LEmail);
            this.contenedorDatos.Controls.Add(this.TBdireccion);
            this.contenedorDatos.Controls.Add(this.DTFechanac);
            this.contenedorDatos.Controls.Add(this.LDireccion);
            this.contenedorDatos.Controls.Add(this.TBdni);
            this.contenedorDatos.Controls.Add(this.TBapellido);
            this.contenedorDatos.Controls.Add(this.TBnombre);
            this.contenedorDatos.Controls.Add(this.LTelefono);
            this.contenedorDatos.Controls.Add(this.LFechaNac);
            this.contenedorDatos.Controls.Add(this.LDni);
            this.contenedorDatos.Controls.Add(this.LApellido);
            this.contenedorDatos.Controls.Add(this.LNombre);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.ForeColor = System.Drawing.Color.DarkRed;
            this.contenedorDatos.Location = new System.Drawing.Point(359, 69);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(1059, 670);
            this.contenedorDatos.TabIndex = 20;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(622, 226);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBtelefono.MaxLength = 10;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(293, 35);
            this.TBtelefono.TabIndex = 32;
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBtelefono_KeyPress);
            // 
            // rutaFoto
            // 
            this.rutaFoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rutaFoto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaFoto.Location = new System.Drawing.Point(706, 495);
            this.rutaFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rutaFoto.Name = "rutaFoto";
            this.rutaFoto.Size = new System.Drawing.Size(204, 35);
            this.rutaFoto.TabIndex = 31;
            // 
            // Bfoto
            // 
            this.Bfoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bfoto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bfoto.Location = new System.Drawing.Point(617, 495);
            this.Bfoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bfoto.Name = "Bfoto";
            this.Bfoto.Size = new System.Drawing.Size(81, 35);
            this.Bfoto.TabIndex = 30;
            this.Bfoto.Text = "Foto";
            this.Bfoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bfoto.UseVisualStyleBackColor = true;
            this.Bfoto.Click += new System.EventHandler(this.Bfoto_Click);
            // 
            // TBconfirmarClave
            // 
            this.TBconfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBconfirmarClave.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBconfirmarClave.Location = new System.Drawing.Point(617, 414);
            this.TBconfirmarClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBconfirmarClave.MaxLength = 10;
            this.TBconfirmarClave.Name = "TBconfirmarClave";
            this.TBconfirmarClave.PasswordChar = '*';
            this.TBconfirmarClave.ShortcutsEnabled = false;
            this.TBconfirmarClave.Size = new System.Drawing.Size(293, 35);
            this.TBconfirmarClave.TabIndex = 24;
            // 
            // TBclave
            // 
            this.TBclave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBclave.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclave.Location = new System.Drawing.Point(617, 320);
            this.TBclave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBclave.MaxLength = 10;
            this.TBclave.Name = "TBclave";
            this.TBclave.PasswordChar = '*';
            this.TBclave.ShortcutsEnabled = false;
            this.TBclave.Size = new System.Drawing.Size(293, 35);
            this.TBclave.TabIndex = 23;
            // 
            // LConfirmarContraseña
            // 
            this.LConfirmarContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LConfirmarContraseña.AutoSize = true;
            this.LConfirmarContraseña.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmarContraseña.Location = new System.Drawing.Point(617, 382);
            this.LConfirmarContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LConfirmarContraseña.Name = "LConfirmarContraseña";
            this.LConfirmarContraseña.Size = new System.Drawing.Size(284, 27);
            this.LConfirmarContraseña.TabIndex = 20;
            this.LConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // LContraseña
            // 
            this.LContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.Location = new System.Drawing.Point(617, 288);
            this.LContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(151, 27);
            this.LContraseña.TabIndex = 19;
            this.LContraseña.Text = "Contraseña";
            // 
            // TBemail
            // 
            this.TBemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBemail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(622, 132);
            this.TBemail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBemail.MaxLength = 100;
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(293, 35);
            this.TBemail.TabIndex = 18;
            // 
            // LEmail
            // 
            this.LEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(622, 100);
            this.LEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(82, 27);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // TBdireccion
            // 
            this.TBdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBdireccion.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdireccion.Location = new System.Drawing.Point(158, 508);
            this.TBdireccion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBdireccion.MaxLength = 200;
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(293, 35);
            this.TBdireccion.TabIndex = 16;
            this.TBdireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdireccion_KeyPress);
            // 
            // DTFechanac
            // 
            this.DTFechanac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTFechanac.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechanac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechanac.Location = new System.Drawing.Point(158, 414);
            this.DTFechanac.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DTFechanac.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.DTFechanac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTFechanac.Name = "DTFechanac";
            this.DTFechanac.Size = new System.Drawing.Size(293, 35);
            this.DTFechanac.TabIndex = 15;
            this.DTFechanac.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // LDireccion
            // 
            this.LDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(158, 476);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(130, 27);
            this.LDireccion.TabIndex = 10;
            this.LDireccion.Text = "Dirección";
            // 
            // TBdni
            // 
            this.TBdni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBdni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdni.Location = new System.Drawing.Point(158, 320);
            this.TBdni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBdni.MaxLength = 8;
            this.TBdni.Name = "TBdni";
            this.TBdni.ShortcutsEnabled = false;
            this.TBdni.Size = new System.Drawing.Size(293, 35);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBdni_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBapellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBapellido.Location = new System.Drawing.Point(158, 226);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBapellido.MaxLength = 100;
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.ShortcutsEnabled = false;
            this.TBapellido.Size = new System.Drawing.Size(293, 35);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBapellido_KeyPress);
            // 
            // TBnombre
            // 
            this.TBnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBnombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(158, 132);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBnombre.MaxLength = 100;
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.ShortcutsEnabled = false;
            this.TBnombre.Size = new System.Drawing.Size(293, 35);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBnombre_KeyPress);
            // 
            // LTelefono
            // 
            this.LTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(622, 194);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(116, 27);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono";
            // 
            // LFechaNac
            // 
            this.LFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNac.Location = new System.Drawing.Point(158, 382);
            this.LFechaNac.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(266, 27);
            this.LFechaNac.TabIndex = 3;
            this.LFechaNac.Text = "Fecha de Nacimiento";
            // 
            // LDni
            // 
            this.LDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(158, 288);
            this.LDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(60, 27);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(158, 194);
            this.LApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(111, 27);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LNombre
            // 
            this.LNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(158, 100);
            this.LNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(107, 27);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MiUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.LMiUsuario);
            this.Controls.Add(this.contenedorFotoBotones);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MiUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MiUsuario";
            this.Load += new System.EventHandler(this.MiUsuario_Load);
            this.contenedorFotoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).EndInit();
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel contenedorFotoBotones;
        public System.Windows.Forms.PictureBox picFotoUsuario;
        public FontAwesome.Sharp.IconButton Beditar;
        public System.Windows.Forms.Label LMiUsuario;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.TextBox TBtelefono;
        public System.Windows.Forms.TextBox rutaFoto;
        public System.Windows.Forms.Button Bfoto;
        public System.Windows.Forms.TextBox TBconfirmarClave;
        public System.Windows.Forms.TextBox TBclave;
        public System.Windows.Forms.Label LConfirmarContraseña;
        public System.Windows.Forms.Label LContraseña;
        public System.Windows.Forms.TextBox TBemail;
        public System.Windows.Forms.Label LEmail;
        public System.Windows.Forms.TextBox TBdireccion;
        public System.Windows.Forms.DateTimePicker DTFechanac;
        public System.Windows.Forms.Label LDireccion;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.TextBox TBapellido;
        public System.Windows.Forms.TextBox TBnombre;
        public System.Windows.Forms.Label LTelefono;
        public System.Windows.Forms.Label LFechaNac;
        public System.Windows.Forms.Label LDni;
        public System.Windows.Forms.Label LApellido;
        public System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}