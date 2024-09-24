namespace FankyRecords.C_presentacion.Administrador
{
    partial class GestionUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.LGestionUsuarios = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LNumTel = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TBnumTel = new System.Windows.Forms.MaskedTextBox();
            this.DTFechanac = new System.Windows.Forms.DateTimePicker();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.Lemail = new System.Windows.Forms.Label();
            this.TBmail = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.LConfContraseña = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.Lestado = new System.Windows.Forms.Label();
            this.TBcontraseña = new System.Windows.Forms.TextBox();
            this.TBconfcontraseña = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.Bfoto = new System.Windows.Forms.Button();
            this.BTfoto = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contraseña = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LGestionUsuarios
            // 
            this.LGestionUsuarios.AutoSize = true;
            this.LGestionUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionUsuarios.Location = new System.Drawing.Point(417, 24);
            this.LGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGestionUsuarios.Name = "LGestionUsuarios";
            this.LGestionUsuarios.Size = new System.Drawing.Size(182, 23);
            this.LGestionUsuarios.TabIndex = 0;
            this.LGestionUsuarios.Text = "Gestión Usuarios";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(46, 65);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 189);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(47, 29);
            this.LNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(57, 15);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            this.LNombre.Click += new System.EventHandler(this.LNombre_Click);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(47, 82);
            this.LApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(58, 15);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.AutoSize = true;
            this.LDni.Location = new System.Drawing.Point(47, 138);
            this.LDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(32, 15);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LFechaNac
            // 
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Location = new System.Drawing.Point(47, 192);
            this.LFechaNac.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(137, 15);
            this.LFechaNac.TabIndex = 3;
            this.LFechaNac.Text = "Fecha de Nacimiento";
            // 
            // LNumTel
            // 
            this.LNumTel.AutoSize = true;
            this.LNumTel.Location = new System.Drawing.Point(47, 235);
            this.LNumTel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LNumTel.Name = "LNumTel";
            this.LNumTel.Size = new System.Drawing.Size(94, 15);
            this.LNumTel.TabIndex = 4;
            this.LNumTel.Text = "Num Telefono";
            this.LNumTel.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBnombre
            // 
            this.TBnombre.Location = new System.Drawing.Point(50, 47);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.Size = new System.Drawing.Size(242, 22);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.TextChanged += new System.EventHandler(this.TBdni_TextChanged);
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnom_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Location = new System.Drawing.Point(50, 100);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.Size = new System.Drawing.Size(242, 22);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnom_KeyPress);
            // 
            // TBdni
            // 
            this.TBdni.Location = new System.Drawing.Point(50, 156);
            this.TBdni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBdni.Name = "TBdni";
            this.TBdni.Size = new System.Drawing.Size(242, 22);
            this.TBdni.TabIndex = 7;
            this.TBdni.TextChanged += new System.EventHandler(this.TBdni_TextChanged);
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnum_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dirección";
            // 
            // TBnumTel
            // 
            this.TBnumTel.Location = new System.Drawing.Point(50, 249);
            this.TBnumTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBnumTel.Mask = "(000)0000000";
            this.TBnumTel.Name = "TBnumTel";
            this.TBnumTel.Size = new System.Drawing.Size(112, 22);
            this.TBnumTel.TabIndex = 11;
            // 
            // DTFechanac
            // 
            this.DTFechanac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechanac.Location = new System.Drawing.Point(50, 210);
            this.DTFechanac.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.DTFechanac.Name = "DTFechanac";
            this.DTFechanac.Size = new System.Drawing.Size(112, 22);
            this.DTFechanac.TabIndex = 15;
            // 
            // TBdireccion
            // 
            this.TBdireccion.Location = new System.Drawing.Point(397, 47);
            this.TBdireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(242, 22);
            this.TBdireccion.TabIndex = 16;
            this.TBdireccion.TextChanged += new System.EventHandler(this.TBdireccion_TextChanged);
            // 
            // Lemail
            // 
            this.Lemail.AutoSize = true;
            this.Lemail.Location = new System.Drawing.Point(394, 82);
            this.Lemail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lemail.Name = "Lemail";
            this.Lemail.Size = new System.Drawing.Size(45, 15);
            this.Lemail.TabIndex = 17;
            this.Lemail.Text = "e-mail";
            // 
            // TBmail
            // 
            this.TBmail.Location = new System.Drawing.Point(397, 100);
            this.TBmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBmail.Name = "TBmail";
            this.TBmail.Size = new System.Drawing.Size(242, 22);
            this.TBmail.TabIndex = 18;
            // 
            // LContraseña
            // 
            this.LContraseña.AutoSize = true;
            this.LContraseña.Location = new System.Drawing.Point(394, 138);
            this.LContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(77, 15);
            this.LContraseña.TabIndex = 19;
            this.LContraseña.Text = "Contraseña";
            // 
            // LConfContraseña
            // 
            this.LConfContraseña.AutoSize = true;
            this.LConfContraseña.Location = new System.Drawing.Point(394, 192);
            this.LConfContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LConfContraseña.Name = "LConfContraseña";
            this.LConfContraseña.Size = new System.Drawing.Size(144, 15);
            this.LConfContraseña.TabIndex = 20;
            this.LConfContraseña.Text = "Confirmar Contraseña";
            // 
            // LRol
            // 
            this.LRol.AutoSize = true;
            this.LRol.Location = new System.Drawing.Point(394, 235);
            this.LRol.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(28, 15);
            this.LRol.TabIndex = 21;
            this.LRol.Text = "Rol";
            // 
            // Lestado
            // 
            this.Lestado.AutoSize = true;
            this.Lestado.Location = new System.Drawing.Point(394, 279);
            this.Lestado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lestado.Name = "Lestado";
            this.Lestado.Size = new System.Drawing.Size(49, 15);
            this.Lestado.TabIndex = 22;
            this.Lestado.Text = "Estado";
            // 
            // TBcontraseña
            // 
            this.TBcontraseña.Location = new System.Drawing.Point(397, 159);
            this.TBcontraseña.Name = "TBcontraseña";
            this.TBcontraseña.Size = new System.Drawing.Size(242, 22);
            this.TBcontraseña.TabIndex = 23;
            this.TBcontraseña.TextChanged += new System.EventHandler(this.TBcontraseña_TextChanged);
            // 
            // TBconfcontraseña
            // 
            this.TBconfcontraseña.Location = new System.Drawing.Point(397, 210);
            this.TBconfcontraseña.Name = "TBconfcontraseña";
            this.TBconfcontraseña.Size = new System.Drawing.Size(242, 22);
            this.TBconfcontraseña.TabIndex = 24;
            this.TBconfcontraseña.TextChanged += new System.EventHandler(this.TBconfcontraseña_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.panel1.Controls.Add(this.BTfoto);
            this.panel1.Controls.Add(this.Bfoto);
            this.panel1.Controls.Add(this.CBRol);
            this.panel1.Controls.Add(this.rBinactivo);
            this.panel1.Controls.Add(this.rBactivo);
            this.panel1.Controls.Add(this.TBconfcontraseña);
            this.panel1.Controls.Add(this.TBcontraseña);
            this.panel1.Controls.Add(this.Lestado);
            this.panel1.Controls.Add(this.LRol);
            this.panel1.Controls.Add(this.LConfContraseña);
            this.panel1.Controls.Add(this.LContraseña);
            this.panel1.Controls.Add(this.TBmail);
            this.panel1.Controls.Add(this.Lemail);
            this.panel1.Controls.Add(this.TBdireccion);
            this.panel1.Controls.Add(this.DTFechanac);
            this.panel1.Controls.Add(this.TBnumTel);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.TBdni);
            this.panel1.Controls.Add(this.TBapellido);
            this.panel1.Controls.Add(this.TBnombre);
            this.panel1.Controls.Add(this.LNumTel);
            this.panel1.Controls.Add(this.LFechaNac);
            this.panel1.Controls.Add(this.LDni);
            this.panel1.Controls.Add(this.LApellido);
            this.panel1.Controls.Add(this.LNombre);
            this.panel1.Location = new System.Drawing.Point(261, 54);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(773, 310);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CBRol
            // 
            this.CBRol.ForeColor = System.Drawing.Color.DarkRed;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Items.AddRange(new object[] {
            "Administrativo",
            "Vendedor",
            "Administrador"});
            this.CBRol.Location = new System.Drawing.Point(397, 249);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(121, 23);
            this.CBRol.TabIndex = 29;
            // 
            // rBinactivo
            // 
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Location = new System.Drawing.Point(564, 279);
            this.rBinactivo.Name = "rBinactivo";
            this.rBinactivo.Size = new System.Drawing.Size(75, 19);
            this.rBinactivo.TabIndex = 27;
            this.rBinactivo.TabStop = true;
            this.rBinactivo.Text = "Inactivo";
            this.rBinactivo.UseVisualStyleBackColor = true;
            // 
            // rBactivo
            // 
            this.rBactivo.AutoSize = true;
            this.rBactivo.Checked = true;
            this.rBactivo.Location = new System.Drawing.Point(474, 279);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(64, 19);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // Bguardar
            // 
            this.Bguardar.BackColor = System.Drawing.Color.OliveDrab;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bguardar.ForeColor = System.Drawing.Color.White;
            this.Bguardar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bguardar.IconColor = System.Drawing.Color.White;
            this.Bguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bguardar.IconSize = 25;
            this.Bguardar.Location = new System.Drawing.Point(46, 260);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(183, 29);
            this.Bguardar.TabIndex = 7;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.Color.DodgerBlue;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Beditar.IconColor = System.Drawing.Color.White;
            this.Beditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beditar.IconSize = 25;
            this.Beditar.Location = new System.Drawing.Point(46, 295);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 9;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            // 
            // Beliminar
            // 
            this.Beliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Beliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(46, 333);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(183, 27);
            this.Beliminar.TabIndex = 10;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_usuario,
            this.dni,
            this.apellido,
            this.nombre,
            this.FechaNac,
            this.direccion,
            this.mail,
            this.telefono,
            this.contraseña,
            this.rol,
            this.Estado});
            this.dataGridView1.Location = new System.Drawing.Point(-1, 408);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1004, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(221, 380);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(578, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Lista de Usuarios";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Bfoto
            // 
            this.Bfoto.Location = new System.Drawing.Point(50, 281);
            this.Bfoto.Name = "Bfoto";
            this.Bfoto.Size = new System.Drawing.Size(75, 23);
            this.Bfoto.TabIndex = 30;
            this.Bfoto.Text = "Foto";
            this.Bfoto.UseVisualStyleBackColor = true;
            this.Bfoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // BTfoto
            // 
            this.BTfoto.Location = new System.Drawing.Point(131, 280);
            this.BTfoto.Name = "BTfoto";
            this.BTfoto.Size = new System.Drawing.Size(161, 22);
            this.BTfoto.TabIndex = 31;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "ID ";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.Width = 50;
            // 
            // dni
            // 
            this.dni.HeaderText = "DNI";
            this.dni.Name = "dni";
            // 
            // apellido
            // 
            this.apellido.HeaderText = "Apellido";
            this.apellido.Name = "apellido";
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // FechaNac
            // 
            this.FechaNac.HeaderText = "Fecha Nacimiento";
            this.FechaNac.Name = "FechaNac";
            this.FechaNac.Width = 80;
            // 
            // direccion
            // 
            this.direccion.HeaderText = "Direccion";
            this.direccion.Name = "direccion";
            // 
            // mail
            // 
            this.mail.HeaderText = "Email";
            this.mail.Name = "mail";
            this.mail.Width = 130;
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Telefono";
            this.telefono.Name = "telefono";
            // 
            // contraseña
            // 
            this.contraseña.HeaderText = "Contraseña";
            this.contraseña.Name = "contraseña";
            this.contraseña.Visible = false;
            // 
            // rol
            // 
            this.rol.HeaderText = "Rol";
            this.rol.Name = "rol";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1005, 647);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.Bguardar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LGestionUsuarios);
            this.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LGestionUsuarios;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.Label LDni;
        private System.Windows.Forms.Label LFechaNac;
        private System.Windows.Forms.Label LNumTel;
        private System.Windows.Forms.TextBox TBnombre;
        private System.Windows.Forms.TextBox TBapellido;
        private System.Windows.Forms.TextBox TBdni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox TBnumTel;
        private System.Windows.Forms.DateTimePicker DTFechanac;
        private System.Windows.Forms.TextBox TBdireccion;
        private System.Windows.Forms.Label Lemail;
        private System.Windows.Forms.TextBox TBmail;
        private System.Windows.Forms.Label LContraseña;
        private System.Windows.Forms.Label LConfContraseña;
        private System.Windows.Forms.Label LRol;
        private System.Windows.Forms.Label Lestado;
        private System.Windows.Forms.TextBox TBcontraseña;
        private System.Windows.Forms.TextBox TBconfcontraseña;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rBactivo;
        private System.Windows.Forms.RadioButton rBinactivo;
        private System.Windows.Forms.ComboBox CBRol;
        private FontAwesome.Sharp.IconButton Bguardar;
        private FontAwesome.Sharp.IconButton Beditar;
        private FontAwesome.Sharp.IconButton Beliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox BTfoto;
        private System.Windows.Forms.Button Bfoto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn contraseña;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}