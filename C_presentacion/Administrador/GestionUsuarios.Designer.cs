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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionUsuarios));
            this.LGestionUsuarios = new System.Windows.Forms.Label();
            this.LNombre = new System.Windows.Forms.Label();
            this.LApellido = new System.Windows.Forms.Label();
            this.LDni = new System.Windows.Forms.Label();
            this.LFechaNac = new System.Windows.Forms.Label();
            this.LTelefono = new System.Windows.Forms.Label();
            this.TBnombre = new System.Windows.Forms.TextBox();
            this.TBapellido = new System.Windows.Forms.TextBox();
            this.TBdni = new System.Windows.Forms.TextBox();
            this.LDireccion = new System.Windows.Forms.Label();
            this.DTFechanac = new System.Windows.Forms.DateTimePicker();
            this.TBdireccion = new System.Windows.Forms.TextBox();
            this.LEmail = new System.Windows.Forms.Label();
            this.TBemail = new System.Windows.Forms.TextBox();
            this.LContraseña = new System.Windows.Forms.Label();
            this.LConfirmarContraseña = new System.Windows.Forms.Label();
            this.LRol = new System.Windows.Forms.Label();
            this.LEstado = new System.Windows.Forms.Label();
            this.TBclave = new System.Windows.Forms.TextBox();
            this.TBconfirmarClave = new System.Windows.Forms.TextBox();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.lblMessage = new System.Windows.Forms.Label();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.rutaFoto = new System.Windows.Forms.TextBox();
            this.Bfoto = new System.Windows.Forms.Button();
            this.CBRol = new System.Windows.Forms.ComboBox();
            this.rBinactivo = new System.Windows.Forms.RadioButton();
            this.rBactivo = new System.Windows.Forms.RadioButton();
            this.listadoUsuarios = new System.Windows.Forms.DataGridView();
            this.ID_usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNacimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RolDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.LListaUsuarios = new System.Windows.Forms.Label();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.contenedorFotoBotones = new System.Windows.Forms.Panel();
            this.TBlimpiar = new FontAwesome.Sharp.IconButton();
            this.picFotoUsuario = new System.Windows.Forms.PictureBox();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.contenedorGestionUsuarios = new System.Windows.Forms.Panel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contenedorDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).BeginInit();
            this.contenedorFotoBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.contenedorGestionUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LGestionUsuarios
            // 
            this.LGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LGestionUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LGestionUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LGestionUsuarios.Name = "LGestionUsuarios";
            this.LGestionUsuarios.Size = new System.Drawing.Size(1059, 69);
            this.LGestionUsuarios.TabIndex = 0;
            this.LGestionUsuarios.Text = "Gestión de Usuarios";
            this.LGestionUsuarios.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // LNombre
            // 
            this.LNombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LNombre.AutoSize = true;
            this.LNombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNombre.ForeColor = System.Drawing.Color.DarkRed;
            this.LNombre.Location = new System.Drawing.Point(45, 41);
            this.LNombre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(107, 27);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            this.LApellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LApellido.AutoSize = true;
            this.LApellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LApellido.Location = new System.Drawing.Point(45, 126);
            this.LApellido.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(111, 27);
            this.LApellido.TabIndex = 1;
            this.LApellido.Text = "Apellido";
            // 
            // LDni
            // 
            this.LDni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(45, 211);
            this.LDni.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(60, 27);
            this.LDni.TabIndex = 2;
            this.LDni.Text = "DNI";
            // 
            // LFechaNac
            // 
            this.LFechaNac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LFechaNac.AutoSize = true;
            this.LFechaNac.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LFechaNac.Location = new System.Drawing.Point(45, 296);
            this.LFechaNac.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LFechaNac.Name = "LFechaNac";
            this.LFechaNac.Size = new System.Drawing.Size(266, 27);
            this.LFechaNac.TabIndex = 3;
            this.LFechaNac.Text = "Fecha de Nacimiento";
            // 
            // LTelefono
            // 
            this.LTelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LTelefono.AutoSize = true;
            this.LTelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LTelefono.Location = new System.Drawing.Point(733, 41);
            this.LTelefono.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LTelefono.Name = "LTelefono";
            this.LTelefono.Size = new System.Drawing.Size(116, 27);
            this.LTelefono.TabIndex = 4;
            this.LTelefono.Text = "Teléfono";
            // 
            // TBnombre
            // 
            this.TBnombre.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBnombre.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBnombre.Location = new System.Drawing.Point(45, 73);
            this.TBnombre.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBnombre.MaxLength = 100;
            this.TBnombre.Name = "TBnombre";
            this.TBnombre.ShortcutsEnabled = false;
            this.TBnombre.Size = new System.Drawing.Size(293, 35);
            this.TBnombre.TabIndex = 5;
            this.TBnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBapellido
            // 
            this.TBapellido.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBapellido.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBapellido.Location = new System.Drawing.Point(45, 159);
            this.TBapellido.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBapellido.MaxLength = 100;
            this.TBapellido.Name = "TBapellido";
            this.TBapellido.ShortcutsEnabled = false;
            this.TBapellido.Size = new System.Drawing.Size(293, 35);
            this.TBapellido.TabIndex = 6;
            this.TBapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // TBdni
            // 
            this.TBdni.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TBdni.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdni.Location = new System.Drawing.Point(45, 242);
            this.TBdni.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBdni.MaxLength = 8;
            this.TBdni.Name = "TBdni";
            this.TBdni.ShortcutsEnabled = false;
            this.TBdni.Size = new System.Drawing.Size(293, 35);
            this.TBdni.TabIndex = 7;
            this.TBdni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // LDireccion
            // 
            this.LDireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LDireccion.AutoSize = true;
            this.LDireccion.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDireccion.Location = new System.Drawing.Point(389, 41);
            this.LDireccion.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LDireccion.Name = "LDireccion";
            this.LDireccion.Size = new System.Drawing.Size(130, 27);
            this.LDireccion.TabIndex = 10;
            this.LDireccion.Text = "Dirección";
            // 
            // DTFechanac
            // 
            this.DTFechanac.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.DTFechanac.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DTFechanac.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTFechanac.Location = new System.Drawing.Point(45, 328);
            this.DTFechanac.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.DTFechanac.MaxDate = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            this.DTFechanac.MinDate = new System.DateTime(1950, 1, 1, 0, 0, 0, 0);
            this.DTFechanac.Name = "DTFechanac";
            this.DTFechanac.Size = new System.Drawing.Size(293, 35);
            this.DTFechanac.TabIndex = 15;
            this.DTFechanac.Value = new System.DateTime(2006, 12, 31, 0, 0, 0, 0);
            // 
            // TBdireccion
            // 
            this.TBdireccion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBdireccion.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdireccion.Location = new System.Drawing.Point(389, 73);
            this.TBdireccion.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBdireccion.MaxLength = 200;
            this.TBdireccion.Name = "TBdireccion";
            this.TBdireccion.Size = new System.Drawing.Size(293, 35);
            this.TBdireccion.TabIndex = 16;
            // 
            // LEmail
            // 
            this.LEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LEmail.AutoSize = true;
            this.LEmail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEmail.Location = new System.Drawing.Point(389, 126);
            this.LEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEmail.Name = "LEmail";
            this.LEmail.Size = new System.Drawing.Size(82, 27);
            this.LEmail.TabIndex = 17;
            this.LEmail.Text = "Email";
            // 
            // TBemail
            // 
            this.TBemail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBemail.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBemail.Location = new System.Drawing.Point(389, 159);
            this.TBemail.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBemail.MaxLength = 100;
            this.TBemail.Name = "TBemail";
            this.TBemail.Size = new System.Drawing.Size(293, 35);
            this.TBemail.TabIndex = 18;
            // 
            // LContraseña
            // 
            this.LContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LContraseña.AutoSize = true;
            this.LContraseña.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LContraseña.Location = new System.Drawing.Point(389, 211);
            this.LContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LContraseña.Name = "LContraseña";
            this.LContraseña.Size = new System.Drawing.Size(151, 27);
            this.LContraseña.TabIndex = 19;
            this.LContraseña.Text = "Contraseña";
            // 
            // LConfirmarContraseña
            // 
            this.LConfirmarContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LConfirmarContraseña.AutoSize = true;
            this.LConfirmarContraseña.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LConfirmarContraseña.Location = new System.Drawing.Point(389, 296);
            this.LConfirmarContraseña.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LConfirmarContraseña.Name = "LConfirmarContraseña";
            this.LConfirmarContraseña.Size = new System.Drawing.Size(284, 27);
            this.LConfirmarContraseña.TabIndex = 20;
            this.LConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // LRol
            // 
            this.LRol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LRol.AutoSize = true;
            this.LRol.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LRol.Location = new System.Drawing.Point(733, 126);
            this.LRol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LRol.Name = "LRol";
            this.LRol.Size = new System.Drawing.Size(53, 27);
            this.LRol.TabIndex = 21;
            this.LRol.Text = "Rol";
            // 
            // LEstado
            // 
            this.LEstado.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LEstado.AutoSize = true;
            this.LEstado.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LEstado.Location = new System.Drawing.Point(733, 296);
            this.LEstado.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LEstado.Name = "LEstado";
            this.LEstado.Size = new System.Drawing.Size(94, 27);
            this.LEstado.TabIndex = 22;
            this.LEstado.Text = "Estado";
            // 
            // TBclave
            // 
            this.TBclave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBclave.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBclave.Location = new System.Drawing.Point(389, 242);
            this.TBclave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBclave.MaxLength = 10;
            this.TBclave.Name = "TBclave";
            this.TBclave.PasswordChar = '*';
            this.TBclave.ShortcutsEnabled = false;
            this.TBclave.Size = new System.Drawing.Size(293, 35);
            this.TBclave.TabIndex = 23;
            // 
            // TBconfirmarClave
            // 
            this.TBconfirmarClave.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBconfirmarClave.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBconfirmarClave.Location = new System.Drawing.Point(389, 328);
            this.TBconfirmarClave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.TBconfirmarClave.MaxLength = 10;
            this.TBconfirmarClave.Name = "TBconfirmarClave";
            this.TBconfirmarClave.PasswordChar = '*';
            this.TBconfirmarClave.ShortcutsEnabled = false;
            this.TBconfirmarClave.Size = new System.Drawing.Size(293, 35);
            this.TBconfirmarClave.TabIndex = 24;
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDatos.Controls.Add(this.lblMessage);
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.rutaFoto);
            this.contenedorDatos.Controls.Add(this.Bfoto);
            this.contenedorDatos.Controls.Add(this.CBRol);
            this.contenedorDatos.Controls.Add(this.rBinactivo);
            this.contenedorDatos.Controls.Add(this.rBactivo);
            this.contenedorDatos.Controls.Add(this.TBconfirmarClave);
            this.contenedorDatos.Controls.Add(this.TBclave);
            this.contenedorDatos.Controls.Add(this.LEstado);
            this.contenedorDatos.Controls.Add(this.LRol);
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
            this.contenedorDatos.Size = new System.Drawing.Size(1059, 408);
            this.contenedorDatos.TabIndex = 1;
            // 
            // lblMessage
            // 
            this.lblMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(527, 315);
            this.lblMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 21);
            this.lblMessage.TabIndex = 33;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(733, 73);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBtelefono.MaxLength = 10;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(293, 35);
            this.TBtelefono.TabIndex = 32;
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // rutaFoto
            // 
            this.rutaFoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rutaFoto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaFoto.Location = new System.Drawing.Point(822, 242);
            this.rutaFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rutaFoto.Name = "rutaFoto";
            this.rutaFoto.Size = new System.Drawing.Size(204, 35);
            this.rutaFoto.TabIndex = 31;
            // 
            // Bfoto
            // 
            this.Bfoto.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Bfoto.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bfoto.Location = new System.Drawing.Point(733, 242);
            this.Bfoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bfoto.Name = "Bfoto";
            this.Bfoto.Size = new System.Drawing.Size(81, 35);
            this.Bfoto.TabIndex = 30;
            this.Bfoto.Text = "Foto";
            this.Bfoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Bfoto.UseVisualStyleBackColor = true;
            this.Bfoto.Click += new System.EventHandler(this.BFoto_Click);
            // 
            // CBRol
            // 
            this.CBRol.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CBRol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBRol.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBRol.ForeColor = System.Drawing.Color.Black;
            this.CBRol.FormattingEnabled = true;
            this.CBRol.Location = new System.Drawing.Point(733, 159);
            this.CBRol.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CBRol.Name = "CBRol";
            this.CBRol.Size = new System.Drawing.Size(293, 35);
            this.CBRol.TabIndex = 29;
            // 
            // rBinactivo
            // 
            this.rBinactivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rBinactivo.AutoSize = true;
            this.rBinactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBinactivo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBinactivo.Location = new System.Drawing.Point(886, 332);
            this.rBinactivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBinactivo.Name = "rBinactivo";
            this.rBinactivo.Size = new System.Drawing.Size(133, 31);
            this.rBinactivo.TabIndex = 27;
            this.rBinactivo.TabStop = true;
            this.rBinactivo.Text = "Inactivo";
            this.rBinactivo.UseVisualStyleBackColor = true;
            // 
            // rBactivo
            // 
            this.rBactivo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.rBactivo.AutoSize = true;
            this.rBactivo.Checked = true;
            this.rBactivo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rBactivo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBactivo.Location = new System.Drawing.Point(768, 332);
            this.rBactivo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rBactivo.Name = "rBactivo";
            this.rBactivo.Size = new System.Drawing.Size(110, 31);
            this.rBactivo.TabIndex = 26;
            this.rBactivo.TabStop = true;
            this.rBactivo.Text = "Activo";
            this.rBactivo.UseVisualStyleBackColor = true;
            // 
            // listadoUsuarios
            // 
            this.listadoUsuarios.AllowUserToAddRows = false;
            this.listadoUsuarios.AutoGenerateColumns = false;
            this.listadoUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.listadoUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.listadoUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.listadoUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listadoUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.listadoUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadoUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_usuarios,
            this.Dni,
            this.Nombre,
            this.Apellido,
            this.Correo,
            this.Clave,
            this.Direccion,
            this.Telefono,
            this.FechaNacimiento,
            this.FechaCreacion,
            this.Estado,
            this.RolDescripcion});
            this.listadoUsuarios.DataSource = this.usuariosBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.listadoUsuarios.DefaultCellStyle = dataGridViewCellStyle2;
            this.listadoUsuarios.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listadoUsuarios.Location = new System.Drawing.Point(0, 508);
            this.listadoUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listadoUsuarios.Name = "listadoUsuarios";
            this.listadoUsuarios.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.listadoUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.listadoUsuarios.RowHeadersWidth = 51;
            this.listadoUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadoUsuarios.Size = new System.Drawing.Size(1418, 231);
            this.listadoUsuarios.TabIndex = 11;
            this.listadoUsuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoUsuarios_CellClick);
            this.listadoUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoUsuarios_CellClick);
            this.listadoUsuarios.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.listadoUsuarios_CellDoubleClick);
            // 
            // ID_usuarios
            // 
            this.ID_usuarios.DataPropertyName = "ID_usuarios";
            this.ID_usuarios.HeaderText = "ID_usuarios";
            this.ID_usuarios.MinimumWidth = 6;
            this.ID_usuarios.Name = "ID_usuarios";
            this.ID_usuarios.ReadOnly = true;
            this.ID_usuarios.Visible = false;
            // 
            // Dni
            // 
            this.Dni.DataPropertyName = "Dni";
            this.Dni.HeaderText = "Dni";
            this.Dni.MinimumWidth = 6;
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.DataPropertyName = "Apellido";
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Clave
            // 
            this.Clave.DataPropertyName = "Clave";
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.ReadOnly = true;
            this.Clave.Visible = false;
            // 
            // Direccion
            // 
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Dirección";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // FechaNacimiento
            // 
            this.FechaNacimiento.DataPropertyName = "FechaNacimiento";
            this.FechaNacimiento.HeaderText = "Fecha Nacimiento";
            this.FechaNacimiento.MinimumWidth = 6;
            this.FechaNacimiento.Name = "FechaNacimiento";
            this.FechaNacimiento.ReadOnly = true;
            // 
            // FechaCreacion
            // 
            this.FechaCreacion.DataPropertyName = "FechaCreacion";
            this.FechaCreacion.HeaderText = "FechaCreacion";
            this.FechaCreacion.MinimumWidth = 6;
            this.FechaCreacion.Name = "FechaCreacion";
            this.FechaCreacion.ReadOnly = true;
            this.FechaCreacion.Visible = false;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // RolDescripcion
            // 
            this.RolDescripcion.DataPropertyName = "RolDescripcion";
            this.RolDescripcion.HeaderText = "Rol";
            this.RolDescripcion.MinimumWidth = 6;
            this.RolDescripcion.Name = "RolDescripcion";
            this.RolDescripcion.ReadOnly = true;
            // 
            // usuariosBindingSource1
            // 
            this.usuariosBindingSource1.DataSource = typeof(FankyRecords.C_entidad.Usuarios);
            // 
            // LListaUsuarios
            // 
            this.LListaUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.LListaUsuarios.Dock = System.Windows.Forms.DockStyle.Left;
            this.LListaUsuarios.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LListaUsuarios.ForeColor = System.Drawing.Color.DarkRed;
            this.LListaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.LListaUsuarios.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LListaUsuarios.Name = "LListaUsuarios";
            this.LListaUsuarios.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.LListaUsuarios.Size = new System.Drawing.Size(313, 31);
            this.LListaUsuarios.TabIndex = 12;
            this.LListaUsuarios.Text = "Lista de Usuarios";
            this.LListaUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbuscar.ForeColor = System.Drawing.Color.DarkRed;
            this.Lbuscar.Location = new System.Drawing.Point(1008, 0);
            this.Lbuscar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(138, 31);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contenedorFotoBotones
            // 
            this.contenedorFotoBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorFotoBotones.Controls.Add(this.TBlimpiar);
            this.contenedorFotoBotones.Controls.Add(this.picFotoUsuario);
            this.contenedorFotoBotones.Controls.Add(this.Bguardar);
            this.contenedorFotoBotones.Controls.Add(this.Beliminar);
            this.contenedorFotoBotones.Controls.Add(this.Beditar);
            this.contenedorFotoBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorFotoBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorFotoBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorFotoBotones.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorFotoBotones.Name = "contenedorFotoBotones";
            this.contenedorFotoBotones.Size = new System.Drawing.Size(359, 477);
            this.contenedorFotoBotones.TabIndex = 17;
            // 
            // TBlimpiar
            // 
            this.TBlimpiar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TBlimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.TBlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TBlimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.TBlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TBlimpiar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBlimpiar.ForeColor = System.Drawing.Color.White;
            this.TBlimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.TBlimpiar.IconColor = System.Drawing.Color.White;
            this.TBlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.TBlimpiar.IconSize = 21;
            this.TBlimpiar.Location = new System.Drawing.Point(79, 405);
            this.TBlimpiar.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.TBlimpiar.Name = "TBlimpiar";
            this.TBlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBlimpiar.Size = new System.Drawing.Size(206, 46);
            this.TBlimpiar.TabIndex = 33;
            this.TBlimpiar.Text = "Limpiar";
            this.TBlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TBlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TBlimpiar.UseVisualStyleBackColor = false;
            this.TBlimpiar.Click += new System.EventHandler(this.TBlimpiar_Click);
            // 
            // picFotoUsuario
            // 
            this.picFotoUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.picFotoUsuario.BackColor = System.Drawing.Color.Transparent;
            this.picFotoUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picFotoUsuario.BackgroundImage")));
            this.picFotoUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picFotoUsuario.Location = new System.Drawing.Point(78, 7);
            this.picFotoUsuario.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.picFotoUsuario.Name = "picFotoUsuario";
            this.picFotoUsuario.Size = new System.Drawing.Size(206, 206);
            this.picFotoUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFotoUsuario.TabIndex = 2;
            this.picFotoUsuario.TabStop = false;
            // 
            // Bguardar
            // 
            this.Bguardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Bguardar.BackColor = System.Drawing.Color.DarkGreen;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bguardar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bguardar.ForeColor = System.Drawing.Color.White;
            this.Bguardar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bguardar.IconColor = System.Drawing.Color.White;
            this.Bguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bguardar.IconSize = 25;
            this.Bguardar.Location = new System.Drawing.Point(79, 225);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(206, 46);
            this.Bguardar.TabIndex = 7;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Beliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Beliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beliminar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(79, 345);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(206, 46);
            this.Beliminar.TabIndex = 10;
            this.Beliminar.Text = "Desactivar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
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
            this.Beditar.IconSize = 25;
            this.Beditar.Location = new System.Drawing.Point(79, 285);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(206, 46);
            this.Beditar.TabIndex = 9;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.LListaUsuarios);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 477);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1418, 31);
            this.contenedorLista.TabIndex = 18;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(1146, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 3, 4, 3);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(204, 35);
            this.TBBuscador.TabIndex = 32;
            this.TBBuscador.TextChanged += new System.EventHandler(this.TBBuscador_TextChanged);
            this.TBBuscador.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TBBuscador_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 20;
            this.btnBuscar.Location = new System.Drawing.Point(1350, 0);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // contenedorGestionUsuarios
            // 
            this.contenedorGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionUsuarios.Controls.Add(this.LGestionUsuarios);
            this.contenedorGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionUsuarios.Location = new System.Drawing.Point(359, 0);
            this.contenedorGestionUsuarios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorGestionUsuarios.Name = "contenedorGestionUsuarios";
            this.contenedorGestionUsuarios.Size = new System.Drawing.Size(1059, 69);
            this.contenedorGestionUsuarios.TabIndex = 19;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataSource = typeof(FankyRecords.C_entidad.Usuarios);
            // 
            // GestionUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionUsuarios);
            this.Controls.Add(this.contenedorFotoBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.listadoUsuarios);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.Name = "GestionUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.GestionUsuarios_Load);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listadoUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource1)).EndInit();
            this.contenedorFotoBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFotoUsuario)).EndInit();
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            this.contenedorGestionUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.PictureBox picFotoUsuario;
        public FontAwesome.Sharp.IconButton Bguardar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Beliminar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public System.Windows.Forms.Panel contenedorFotoBotones;
        public System.Windows.Forms.Panel contenedorGestionUsuarios;
        public System.Windows.Forms.DataGridView listadoUsuarios;
        public System.Windows.Forms.Panel contenedorLista;
        public System.Windows.Forms.Label Lbuscar;
        public System.Windows.Forms.Panel contenedorDatos;
        public System.Windows.Forms.Label LListaUsuarios;
        public System.Windows.Forms.Label LGestionUsuarios;
        public System.Windows.Forms.Label LNombre;
        public System.Windows.Forms.Label LApellido;
        public System.Windows.Forms.Label LDni;
        public System.Windows.Forms.Label LFechaNac;
        public System.Windows.Forms.Label LTelefono;
        public System.Windows.Forms.TextBox TBnombre;
        public System.Windows.Forms.TextBox TBapellido;
        public System.Windows.Forms.TextBox TBdni;
        public System.Windows.Forms.Label LDireccion;
        public System.Windows.Forms.DateTimePicker DTFechanac;
        public System.Windows.Forms.TextBox TBdireccion;
        public System.Windows.Forms.Label LEmail;
        public System.Windows.Forms.TextBox TBemail;
        public System.Windows.Forms.Label LContraseña;
        public System.Windows.Forms.Label LConfirmarContraseña;
        public System.Windows.Forms.Label LRol;
        public System.Windows.Forms.Label LEstado;
        public System.Windows.Forms.TextBox TBclave;
        public System.Windows.Forms.TextBox TBconfirmarClave;
        public System.Windows.Forms.RadioButton rBactivo;
        public System.Windows.Forms.RadioButton rBinactivo;
        public System.Windows.Forms.ComboBox CBRol;
        public System.Windows.Forms.TextBox rutaFoto;
        public System.Windows.Forms.Button Bfoto;
        public System.Windows.Forms.TextBox TBBuscador;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        public FontAwesome.Sharp.IconButton TBlimpiar;
        public System.Windows.Forms.TextBox TBtelefono;
        private System.Windows.Forms.Label lblMessage;
      
        private System.Windows.Forms.BindingSource usuariosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNacimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn RolDescripcion;
    }
}