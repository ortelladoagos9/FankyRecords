using System.Windows.Forms;

namespace FankyRecords.C_presentacion.Administrador
{
    partial class GestionProveedores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.RBinactivop = new System.Windows.Forms.RadioButton();
            this.RBactivop = new System.Windows.Forms.RadioButton();
            this.TBtelefono = new System.Windows.Forms.MaskedTextBox();
            this.TBcorreo = new System.Windows.Forms.TextBox();
            this.TBdomiciliop = new System.Windows.Forms.TextBox();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.TBRazonSocial = new System.Windows.Forms.TextBox();
            this.Lestadoproveedor = new System.Windows.Forms.Label();
            this.Lcorreoproveedor = new System.Windows.Forms.Label();
            this.Ltelefonoproveedor = new System.Windows.Forms.Label();
            this.LdomicilioProveedor = new System.Windows.Forms.Label();
            this.Lcuit = new System.Windows.Forms.Label();
            this.Lrazonsocial = new System.Windows.Forms.Label();
            this.LGestionProveedor = new System.Windows.Forms.Label();
            this.DGlistaproveedores = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaProveedores = new System.Windows.Forms.Label();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.CBbuscar = new System.Windows.Forms.ComboBox();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.contenedorGestionUsuarios = new System.Windows.Forms.Panel();
            this.contenedorDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            this.contenedorGestionUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bguardar
            // 
            this.Bguardar.BackColor = System.Drawing.Color.DarkGreen;
            this.Bguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bguardar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bguardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bguardar.ForeColor = System.Drawing.Color.White;
            this.Bguardar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bguardar.IconColor = System.Drawing.Color.White;
            this.Bguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bguardar.IconSize = 25;
            this.Bguardar.Location = new System.Drawing.Point(44, 139);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(183, 31);
            this.Bguardar.TabIndex = 8;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
            // 
            // Beditar
            // 
            this.Beditar.BackColor = System.Drawing.Color.Navy;
            this.Beditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beditar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beditar.ForeColor = System.Drawing.Color.White;
            this.Beditar.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.Beditar.IconColor = System.Drawing.Color.White;
            this.Beditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beditar.IconSize = 25;
            this.Beditar.Location = new System.Drawing.Point(44, 192);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(183, 31);
            this.Beditar.TabIndex = 10;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
            // 
            // Beliminar
            // 
            this.Beliminar.BackColor = System.Drawing.Color.DarkRed;
            this.Beliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Beliminar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(44, 245);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(183, 31);
            this.Beliminar.TabIndex = 11;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.Controls.Add(this.RBinactivop);
            this.contenedorDatos.Controls.Add(this.RBactivop);
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.TBcorreo);
            this.contenedorDatos.Controls.Add(this.TBdomiciliop);
            this.contenedorDatos.Controls.Add(this.TBcuit);
            this.contenedorDatos.Controls.Add(this.TBRazonSocial);
            this.contenedorDatos.Controls.Add(this.Lestadoproveedor);
            this.contenedorDatos.Controls.Add(this.Lcorreoproveedor);
            this.contenedorDatos.Controls.Add(this.Ltelefonoproveedor);
            this.contenedorDatos.Controls.Add(this.LdomicilioProveedor);
            this.contenedorDatos.Controls.Add(this.Lcuit);
            this.contenedorDatos.Controls.Add(this.Lrazonsocial);
            this.contenedorDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contenedorDatos.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contenedorDatos.Location = new System.Drawing.Point(261, 62);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(921, 355);
            this.contenedorDatos.TabIndex = 12;
            // 
            // RBinactivop
            // 
            this.RBinactivop.AutoSize = true;
            this.RBinactivop.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBinactivop.Location = new System.Drawing.Point(604, 221);
            this.RBinactivop.Name = "RBinactivop";
            this.RBinactivop.Size = new System.Drawing.Size(103, 25);
            this.RBinactivop.TabIndex = 12;
            this.RBinactivop.Text = "Inactivo";
            this.RBinactivop.UseVisualStyleBackColor = true;
            // 
            // RBactivop
            // 
            this.RBactivop.AutoSize = true;
            this.RBactivop.Checked = true;
            this.RBactivop.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBactivop.Location = new System.Drawing.Point(490, 221);
            this.RBactivop.Name = "RBactivop";
            this.RBactivop.Size = new System.Drawing.Size(86, 25);
            this.RBactivop.TabIndex = 11;
            this.RBactivop.TabStop = true;
            this.RBactivop.Text = "Activo";
            this.RBactivop.UseVisualStyleBackColor = true;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(470, 141);
            this.TBtelefono.Mask = "(9999)000000";
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(242, 28);
            this.TBtelefono.TabIndex = 10;
            // 
            // TBcorreo
            // 
            this.TBcorreo.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcorreo.Location = new System.Drawing.Point(470, 64);
            this.TBcorreo.MaxLength = 100;
            this.TBcorreo.Name = "TBcorreo";
            this.TBcorreo.Size = new System.Drawing.Size(242, 28);
            this.TBcorreo.TabIndex = 9;
            // 
            // TBdomiciliop
            // 
            this.TBdomiciliop.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdomiciliop.Location = new System.Drawing.Point(134, 218);
            this.TBdomiciliop.MaxLength = 200;
            this.TBdomiciliop.Name = "TBdomiciliop";
            this.TBdomiciliop.Size = new System.Drawing.Size(242, 28);
            this.TBdomiciliop.TabIndex = 8;
            // 
            // TBcuit
            // 
            this.TBcuit.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcuit.Location = new System.Drawing.Point(134, 141);
            this.TBcuit.MaxLength = 11;
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.Size = new System.Drawing.Size(242, 28);
            this.TBcuit.TabIndex = 7;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocial.Location = new System.Drawing.Point(134, 64);
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.Size = new System.Drawing.Size(242, 28);
            this.TBRazonSocial.TabIndex = 6;
            this.TBRazonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // Lestadoproveedor
            // 
            this.Lestadoproveedor.AutoSize = true;
            this.Lestadoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestadoproveedor.Location = new System.Drawing.Point(470, 183);
            this.Lestadoproveedor.Name = "Lestadoproveedor";
            this.Lestadoproveedor.Size = new System.Drawing.Size(70, 21);
            this.Lestadoproveedor.TabIndex = 5;
            this.Lestadoproveedor.Text = "Estado";
            // 
            // Lcorreoproveedor
            // 
            this.Lcorreoproveedor.AutoSize = true;
            this.Lcorreoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcorreoproveedor.Location = new System.Drawing.Point(470, 30);
            this.Lcorreoproveedor.Name = "Lcorreoproveedor";
            this.Lcorreoproveedor.Size = new System.Drawing.Size(71, 21);
            this.Lcorreoproveedor.TabIndex = 4;
            this.Lcorreoproveedor.Text = "Correo";
            // 
            // Ltelefonoproveedor
            // 
            this.Ltelefonoproveedor.AutoSize = true;
            this.Ltelefonoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltelefonoproveedor.Location = new System.Drawing.Point(470, 106);
            this.Ltelefonoproveedor.Name = "Ltelefonoproveedor";
            this.Ltelefonoproveedor.Size = new System.Drawing.Size(87, 21);
            this.Ltelefonoproveedor.TabIndex = 3;
            this.Ltelefonoproveedor.Text = "Telefono";
            // 
            // LdomicilioProveedor
            // 
            this.LdomicilioProveedor.AutoSize = true;
            this.LdomicilioProveedor.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdomicilioProveedor.Location = new System.Drawing.Point(134, 183);
            this.LdomicilioProveedor.Name = "LdomicilioProveedor";
            this.LdomicilioProveedor.Size = new System.Drawing.Size(93, 21);
            this.LdomicilioProveedor.TabIndex = 2;
            this.LdomicilioProveedor.Text = "Domicilio";
            // 
            // Lcuit
            // 
            this.Lcuit.AutoSize = true;
            this.Lcuit.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcuit.Location = new System.Drawing.Point(134, 106);
            this.Lcuit.Name = "Lcuit";
            this.Lcuit.Size = new System.Drawing.Size(48, 21);
            this.Lcuit.TabIndex = 1;
            this.Lcuit.Text = "Cuit";
            // 
            // Lrazonsocial
            // 
            this.Lrazonsocial.AutoSize = true;
            this.Lrazonsocial.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lrazonsocial.Location = new System.Drawing.Point(134, 29);
            this.Lrazonsocial.Name = "Lrazonsocial";
            this.Lrazonsocial.Size = new System.Drawing.Size(122, 21);
            this.Lrazonsocial.TabIndex = 0;
            this.Lrazonsocial.Text = "Razón Social";
            // 
            // LGestionProveedor
            // 
            this.LGestionProveedor.Dock = System.Windows.Forms.DockStyle.Left;
            this.LGestionProveedor.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionProveedor.Location = new System.Drawing.Point(0, 0);
            this.LGestionProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LGestionProveedor.Name = "LGestionProveedor";
            this.LGestionProveedor.Size = new System.Drawing.Size(310, 62);
            this.LGestionProveedor.TabIndex = 13;
            this.LGestionProveedor.Text = "Gestión de Proveedores";
            this.LGestionProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DGlistaproveedores
            // 
            this.DGlistaproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGlistaproveedores.BackgroundColor = System.Drawing.Color.White;
            this.DGlistaproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGlistaproveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DGlistaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.razonSocial,
            this.cuitProveedor,
            this.domicilioProveedor,
            this.correoProveedor,
            this.telefonoProveedor,
            this.estadoProveedor});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistaproveedores.DefaultCellStyle = dataGridViewCellStyle4;
            this.DGlistaproveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGlistaproveedores.GridColor = System.Drawing.SystemColors.Window;
            this.DGlistaproveedores.Location = new System.Drawing.Point(0, 445);
            this.DGlistaproveedores.Name = "DGlistaproveedores";
            this.DGlistaproveedores.RowHeadersWidth = 51;
            this.DGlistaproveedores.Size = new System.Drawing.Size(1182, 209);
            this.DGlistaproveedores.TabIndex = 11;
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "ID";
            this.id_proveedor.MinimumWidth = 6;
            this.id_proveedor.Name = "id_proveedor";
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.HeaderText = "Cuit";
            this.cuitProveedor.MinimumWidth = 6;
            this.cuitProveedor.Name = "cuitProveedor";
            // 
            // domicilioProveedor
            // 
            this.domicilioProveedor.HeaderText = "Domicilio";
            this.domicilioProveedor.MinimumWidth = 6;
            this.domicilioProveedor.Name = "domicilioProveedor";
            // 
            // correoProveedor
            // 
            this.correoProveedor.HeaderText = "Email";
            this.correoProveedor.MinimumWidth = 6;
            this.correoProveedor.Name = "correoProveedor";
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.HeaderText = "Telefono";
            this.telefonoProveedor.MinimumWidth = 6;
            this.telefonoProveedor.Name = "telefonoProveedor";
            // 
            // estadoProveedor
            // 
            this.estadoProveedor.HeaderText = "Estado";
            this.estadoProveedor.MinimumWidth = 6;
            this.estadoProveedor.Name = "estadoProveedor";
            // 
            // listaProveedores
            // 
            this.listaProveedores.AutoSize = true;
            this.listaProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaProveedores.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProveedores.Location = new System.Drawing.Point(0, 0);
            this.listaProveedores.Name = "listaProveedores";
            this.listaProveedores.Size = new System.Drawing.Size(227, 25);
            this.listaProveedores.TabIndex = 15;
            this.listaProveedores.Text = "Lista de Proveedores";
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.CBbuscar);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.listaProveedores);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Controls.Add(this.btnLimpiar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 417);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1182, 28);
            this.contenedorLista.TabIndex = 19;
            // 
            // Lbuscar
            // 
            this.Lbuscar.BackColor = System.Drawing.SystemColors.Window;
            this.Lbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.Lbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold);
            this.Lbuscar.Location = new System.Drawing.Point(611, 0);
            this.Lbuscar.Name = "Lbuscar";
            this.Lbuscar.Size = new System.Drawing.Size(115, 28);
            this.Lbuscar.TabIndex = 0;
            this.Lbuscar.Text = "Buscar por:";
            this.Lbuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBbuscar
            // 
            this.CBbuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBbuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.CBbuscar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBbuscar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold);
            this.CBbuscar.ForeColor = System.Drawing.Color.Black;
            this.CBbuscar.FormattingEnabled = true;
            this.CBbuscar.IntegralHeight = false;
            this.CBbuscar.Items.AddRange(new object[] {
            "Nro ID",
            "Razon social",
            "Cuit"});
            this.CBbuscar.Location = new System.Drawing.Point(726, 0);
            this.CBbuscar.Name = "CBbuscar";
            this.CBbuscar.Size = new System.Drawing.Size(171, 29);
            this.CBbuscar.TabIndex = 1;
            // 
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(897, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(12, 4, 4, 4);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(171, 28);
            this.TBBuscador.TabIndex = 34;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnBuscar.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscar.IconColor = System.Drawing.Color.DarkRed;
            this.btnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscar.IconSize = 18;
            this.btnBuscar.Location = new System.Drawing.Point(1068, 0);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(57, 28);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.White;
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.btnLimpiar.IconColor = System.Drawing.Color.DarkRed;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 18;
            this.btnLimpiar.Location = new System.Drawing.Point(1125, 0);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(57, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.Beditar);
            this.contenedorBotones.Controls.Add(this.Bguardar);
            this.contenedorBotones.Controls.Add(this.Beliminar);
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(261, 417);
            this.contenedorBotones.TabIndex = 20;
            // 
            // contenedorGestionUsuarios
            // 
            this.contenedorGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionUsuarios.Controls.Add(this.LGestionProveedor);
            this.contenedorGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionUsuarios.Location = new System.Drawing.Point(261, 0);
            this.contenedorGestionUsuarios.Name = "contenedorGestionUsuarios";
            this.contenedorGestionUsuarios.Size = new System.Drawing.Size(921, 62);
            this.contenedorGestionUsuarios.TabIndex = 21;
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionUsuarios);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.DGlistaproveedores);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).EndInit();
            this.contenedorLista.ResumeLayout(false);
            this.contenedorLista.PerformLayout();
            this.contenedorBotones.ResumeLayout(false);
            this.contenedorGestionUsuarios.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public FontAwesome.Sharp.IconButton Bguardar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Beliminar;
        private System.Windows.Forms.Panel contenedorDatos;
        private System.Windows.Forms.Label LGestionProveedor;
        private System.Windows.Forms.Label Lestadoproveedor;
        private System.Windows.Forms.Label Lcorreoproveedor;
        private System.Windows.Forms.Label Ltelefonoproveedor;
        private System.Windows.Forms.Label LdomicilioProveedor;
        private System.Windows.Forms.Label Lcuit;
        private System.Windows.Forms.Label Lrazonsocial;
        private System.Windows.Forms.TextBox TBRazonSocial;
        private System.Windows.Forms.MaskedTextBox TBtelefono;
        private System.Windows.Forms.TextBox TBcorreo;
        private System.Windows.Forms.TextBox TBdomiciliop;
        private System.Windows.Forms.TextBox TBcuit;
        private System.Windows.Forms.RadioButton RBinactivop;
        private System.Windows.Forms.RadioButton RBactivop;
        private System.Windows.Forms.DataGridView DGlistaproveedores;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuitProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn domicilioProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoProveedor;
        private System.Windows.Forms.Label listaProveedores;
        private System.Windows.Forms.Panel contenedorLista;
        private System.Windows.Forms.Label Lbuscar;
        private System.Windows.Forms.ComboBox CBbuscar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        public FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Panel contenedorBotones;
        private System.Windows.Forms.Panel contenedorGestionUsuarios;
        public System.Windows.Forms.TextBox TBBuscador;
    }
}