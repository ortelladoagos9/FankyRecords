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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.contenedorDatos = new System.Windows.Forms.Panel();
            this.TBtelefono = new System.Windows.Forms.TextBox();
            this.RBinactivop = new System.Windows.Forms.RadioButton();
            this.RBactivop = new System.Windows.Forms.RadioButton();
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
            this.proveedoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.listaProveedores = new System.Windows.Forms.Label();
            this.contenedorLista = new System.Windows.Forms.Panel();
            this.Lbuscar = new System.Windows.Forms.Label();
            this.TBBuscador = new System.Windows.Forms.TextBox();
            this.btnBuscar = new FontAwesome.Sharp.IconButton();
            this.contenedorBotones = new System.Windows.Forms.Panel();
            this.TBlimpiar = new FontAwesome.Sharp.IconButton();
            this.contenedorGestionUsuarios = new System.Windows.Forms.Panel();
            this.ID_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Domicilio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contenedorDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).BeginInit();
            this.contenedorLista.SuspendLayout();
            this.contenedorBotones.SuspendLayout();
            this.contenedorGestionUsuarios.SuspendLayout();
            this.SuspendLayout();
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
            this.Bguardar.Location = new System.Drawing.Point(77, 151);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(206, 46);
            this.Bguardar.TabIndex = 8;
            this.Bguardar.Text = "Guardar";
            this.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bguardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bguardar.UseVisualStyleBackColor = false;
            this.Bguardar.Click += new System.EventHandler(this.Bguardar_Click);
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
            this.Beditar.Location = new System.Drawing.Point(77, 209);
            this.Beditar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(206, 46);
            this.Beditar.TabIndex = 10;
            this.Beditar.Text = "Editar";
            this.Beditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beditar.UseVisualStyleBackColor = false;
            this.Beditar.Click += new System.EventHandler(this.Beditar_Click);
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
            this.Beliminar.Location = new System.Drawing.Point(77, 267);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(206, 46);
            this.Beliminar.TabIndex = 11;
            this.Beliminar.Text = "Desactivar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // contenedorDatos
            // 
            this.contenedorDatos.Controls.Add(this.TBtelefono);
            this.contenedorDatos.Controls.Add(this.RBinactivop);
            this.contenedorDatos.Controls.Add(this.RBactivop);
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
            this.contenedorDatos.Location = new System.Drawing.Point(359, 69);
            this.contenedorDatos.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.contenedorDatos.Name = "contenedorDatos";
            this.contenedorDatos.Size = new System.Drawing.Size(1059, 408);
            this.contenedorDatos.TabIndex = 12;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBtelefono.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBtelefono.Location = new System.Drawing.Point(615, 195);
            this.TBtelefono.Margin = new System.Windows.Forms.Padding(4);
            this.TBtelefono.MaxLength = 15;
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.ShortcutsEnabled = false;
            this.TBtelefono.Size = new System.Drawing.Size(293, 35);
            this.TBtelefono.TabIndex = 13;
            this.TBtelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // RBinactivop
            // 
            this.RBinactivop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBinactivop.AutoSize = true;
            this.RBinactivop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBinactivop.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBinactivop.ForeColor = System.Drawing.Color.DarkRed;
            this.RBinactivop.Location = new System.Drawing.Point(758, 283);
            this.RBinactivop.Margin = new System.Windows.Forms.Padding(4);
            this.RBinactivop.Name = "RBinactivop";
            this.RBinactivop.Size = new System.Drawing.Size(133, 31);
            this.RBinactivop.TabIndex = 12;
            this.RBinactivop.Text = "Inactivo";
            this.RBinactivop.UseVisualStyleBackColor = true;
            // 
            // RBactivop
            // 
            this.RBactivop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.RBactivop.AutoSize = true;
            this.RBactivop.Checked = true;
            this.RBactivop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RBactivop.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBactivop.ForeColor = System.Drawing.Color.DarkRed;
            this.RBactivop.Location = new System.Drawing.Point(639, 283);
            this.RBactivop.Margin = new System.Windows.Forms.Padding(4);
            this.RBactivop.Name = "RBactivop";
            this.RBactivop.Size = new System.Drawing.Size(110, 31);
            this.RBactivop.TabIndex = 11;
            this.RBactivop.TabStop = true;
            this.RBactivop.Text = "Activo";
            this.RBactivop.UseVisualStyleBackColor = true;
            // 
            // TBcorreo
            // 
            this.TBcorreo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBcorreo.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcorreo.Location = new System.Drawing.Point(615, 112);
            this.TBcorreo.Margin = new System.Windows.Forms.Padding(4);
            this.TBcorreo.MaxLength = 100;
            this.TBcorreo.Name = "TBcorreo";
            this.TBcorreo.ShortcutsEnabled = false;
            this.TBcorreo.Size = new System.Drawing.Size(293, 35);
            this.TBcorreo.TabIndex = 9;
            // 
            // TBdomiciliop
            // 
            this.TBdomiciliop.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBdomiciliop.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBdomiciliop.Location = new System.Drawing.Point(198, 279);
            this.TBdomiciliop.Margin = new System.Windows.Forms.Padding(4);
            this.TBdomiciliop.MaxLength = 200;
            this.TBdomiciliop.Name = "TBdomiciliop";
            this.TBdomiciliop.ShortcutsEnabled = false;
            this.TBdomiciliop.Size = new System.Drawing.Size(293, 35);
            this.TBdomiciliop.TabIndex = 8;
            // 
            // TBcuit
            // 
            this.TBcuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBcuit.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBcuit.Location = new System.Drawing.Point(198, 195);
            this.TBcuit.Margin = new System.Windows.Forms.Padding(4);
            this.TBcuit.MaxLength = 11;
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.ShortcutsEnabled = false;
            this.TBcuit.Size = new System.Drawing.Size(293, 35);
            this.TBcuit.TabIndex = 7;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBRazonSocial
            // 
            this.TBRazonSocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TBRazonSocial.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBRazonSocial.Location = new System.Drawing.Point(198, 112);
            this.TBRazonSocial.Margin = new System.Windows.Forms.Padding(4);
            this.TBRazonSocial.MaxLength = 200;
            this.TBRazonSocial.Name = "TBRazonSocial";
            this.TBRazonSocial.ShortcutsEnabled = false;
            this.TBRazonSocial.Size = new System.Drawing.Size(293, 35);
            this.TBRazonSocial.TabIndex = 6;
            // 
            // Lestadoproveedor
            // 
            this.Lestadoproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lestadoproveedor.AutoSize = true;
            this.Lestadoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lestadoproveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.Lestadoproveedor.Location = new System.Drawing.Point(615, 244);
            this.Lestadoproveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lestadoproveedor.Name = "Lestadoproveedor";
            this.Lestadoproveedor.Size = new System.Drawing.Size(94, 27);
            this.Lestadoproveedor.TabIndex = 5;
            this.Lestadoproveedor.Text = "Estado";
            // 
            // Lcorreoproveedor
            // 
            this.Lcorreoproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lcorreoproveedor.AutoSize = true;
            this.Lcorreoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcorreoproveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.Lcorreoproveedor.Location = new System.Drawing.Point(615, 77);
            this.Lcorreoproveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lcorreoproveedor.Name = "Lcorreoproveedor";
            this.Lcorreoproveedor.Size = new System.Drawing.Size(95, 27);
            this.Lcorreoproveedor.TabIndex = 4;
            this.Lcorreoproveedor.Text = "Correo";
            // 
            // Ltelefonoproveedor
            // 
            this.Ltelefonoproveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Ltelefonoproveedor.AutoSize = true;
            this.Ltelefonoproveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ltelefonoproveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.Ltelefonoproveedor.Location = new System.Drawing.Point(615, 160);
            this.Ltelefonoproveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Ltelefonoproveedor.Name = "Ltelefonoproveedor";
            this.Ltelefonoproveedor.Size = new System.Drawing.Size(116, 27);
            this.Ltelefonoproveedor.TabIndex = 3;
            this.Ltelefonoproveedor.Text = "Teléfono";
            // 
            // LdomicilioProveedor
            // 
            this.LdomicilioProveedor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LdomicilioProveedor.AutoSize = true;
            this.LdomicilioProveedor.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LdomicilioProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LdomicilioProveedor.Location = new System.Drawing.Point(198, 244);
            this.LdomicilioProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LdomicilioProveedor.Name = "LdomicilioProveedor";
            this.LdomicilioProveedor.Size = new System.Drawing.Size(129, 27);
            this.LdomicilioProveedor.TabIndex = 2;
            this.LdomicilioProveedor.Text = "Domicilio";
            // 
            // Lcuit
            // 
            this.Lcuit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lcuit.AutoSize = true;
            this.Lcuit.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcuit.ForeColor = System.Drawing.Color.DarkRed;
            this.Lcuit.Location = new System.Drawing.Point(198, 160);
            this.Lcuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lcuit.Name = "Lcuit";
            this.Lcuit.Size = new System.Drawing.Size(65, 27);
            this.Lcuit.TabIndex = 1;
            this.Lcuit.Text = "Cuit";
            // 
            // Lrazonsocial
            // 
            this.Lrazonsocial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Lrazonsocial.AutoSize = true;
            this.Lrazonsocial.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lrazonsocial.ForeColor = System.Drawing.Color.DarkRed;
            this.Lrazonsocial.Location = new System.Drawing.Point(198, 77);
            this.Lrazonsocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lrazonsocial.Name = "Lrazonsocial";
            this.Lrazonsocial.Size = new System.Drawing.Size(167, 27);
            this.Lrazonsocial.TabIndex = 0;
            this.Lrazonsocial.Text = "Razón Social";
            // 
            // LGestionProveedor
            // 
            this.LGestionProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.LGestionProveedor.Font = new System.Drawing.Font("Century Schoolbook", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LGestionProveedor.ForeColor = System.Drawing.Color.DarkRed;
            this.LGestionProveedor.Location = new System.Drawing.Point(0, 0);
            this.LGestionProveedor.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LGestionProveedor.Name = "LGestionProveedor";
            this.LGestionProveedor.Size = new System.Drawing.Size(1059, 69);
            this.LGestionProveedor.TabIndex = 13;
            this.LGestionProveedor.Text = "Gestión de Proveedores";
            this.LGestionProveedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // DGlistaproveedores
            // 
            this.DGlistaproveedores.AllowUserToAddRows = false;
            this.DGlistaproveedores.AutoGenerateColumns = false;
            this.DGlistaproveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGlistaproveedores.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGlistaproveedores.BackgroundColor = System.Drawing.Color.White;
            this.DGlistaproveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGlistaproveedores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGlistaproveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGlistaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_proveedor,
            this.RazonSocial,
            this.Correo,
            this.Telefono,
            this.Estado,
            this.Cuit,
            this.Domicilio});
            this.DGlistaproveedores.DataSource = this.proveedoresBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGlistaproveedores.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGlistaproveedores.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DGlistaproveedores.Location = new System.Drawing.Point(0, 508);
            this.DGlistaproveedores.Margin = new System.Windows.Forms.Padding(4);
            this.DGlistaproveedores.Name = "DGlistaproveedores";
            this.DGlistaproveedores.ReadOnly = true;
            this.DGlistaproveedores.RowHeadersWidth = 51;
            this.DGlistaproveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGlistaproveedores.Size = new System.Drawing.Size(1418, 231);
            this.DGlistaproveedores.TabIndex = 11;
            this.DGlistaproveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaproveedores_CellClick);
            this.DGlistaproveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGlistaproveedores_CellDoubleClick);
            // 
            // proveedoresBindingSource1
            // 
            this.proveedoresBindingSource1.DataSource = typeof(FankyRecords.C_entidad.Proveedores);
            // 
            // listaProveedores
            // 
            this.listaProveedores.AutoSize = true;
            this.listaProveedores.Dock = System.Windows.Forms.DockStyle.Left;
            this.listaProveedores.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProveedores.ForeColor = System.Drawing.Color.DarkRed;
            this.listaProveedores.Location = new System.Drawing.Point(0, 0);
            this.listaProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.listaProveedores.Name = "listaProveedores";
            this.listaProveedores.Size = new System.Drawing.Size(322, 34);
            this.listaProveedores.TabIndex = 15;
            this.listaProveedores.Text = "Lista de Proveedores";
            // 
            // contenedorLista
            // 
            this.contenedorLista.BackColor = System.Drawing.Color.White;
            this.contenedorLista.Controls.Add(this.Lbuscar);
            this.contenedorLista.Controls.Add(this.TBBuscador);
            this.contenedorLista.Controls.Add(this.listaProveedores);
            this.contenedorLista.Controls.Add(this.btnBuscar);
            this.contenedorLista.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.contenedorLista.Location = new System.Drawing.Point(0, 477);
            this.contenedorLista.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorLista.Name = "contenedorLista";
            this.contenedorLista.Size = new System.Drawing.Size(1418, 31);
            this.contenedorLista.TabIndex = 19;
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
            // TBBuscador
            // 
            this.TBBuscador.Dock = System.Windows.Forms.DockStyle.Right;
            this.TBBuscador.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBBuscador.ForeColor = System.Drawing.Color.Black;
            this.TBBuscador.Location = new System.Drawing.Point(1146, 0);
            this.TBBuscador.Margin = new System.Windows.Forms.Padding(14, 5, 5, 5);
            this.TBBuscador.Name = "TBBuscador";
            this.TBBuscador.Size = new System.Drawing.Size(204, 35);
            this.TBBuscador.TabIndex = 34;
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
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(68, 31);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // contenedorBotones
            // 
            this.contenedorBotones.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorBotones.Controls.Add(this.TBlimpiar);
            this.contenedorBotones.Controls.Add(this.Beditar);
            this.contenedorBotones.Controls.Add(this.Bguardar);
            this.contenedorBotones.Controls.Add(this.Beliminar);
            this.contenedorBotones.Dock = System.Windows.Forms.DockStyle.Left;
            this.contenedorBotones.ForeColor = System.Drawing.Color.Transparent;
            this.contenedorBotones.Location = new System.Drawing.Point(0, 0);
            this.contenedorBotones.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorBotones.Name = "contenedorBotones";
            this.contenedorBotones.Size = new System.Drawing.Size(359, 477);
            this.contenedorBotones.TabIndex = 20;
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
            this.TBlimpiar.Location = new System.Drawing.Point(77, 325);
            this.TBlimpiar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.TBlimpiar.Name = "TBlimpiar";
            this.TBlimpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TBlimpiar.Size = new System.Drawing.Size(206, 46);
            this.TBlimpiar.TabIndex = 12;
            this.TBlimpiar.Text = "Limpiar";
            this.TBlimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TBlimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TBlimpiar.UseVisualStyleBackColor = false;
            this.TBlimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // contenedorGestionUsuarios
            // 
            this.contenedorGestionUsuarios.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorGestionUsuarios.Controls.Add(this.LGestionProveedor);
            this.contenedorGestionUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorGestionUsuarios.Location = new System.Drawing.Point(359, 0);
            this.contenedorGestionUsuarios.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorGestionUsuarios.Name = "contenedorGestionUsuarios";
            this.contenedorGestionUsuarios.Size = new System.Drawing.Size(1059, 69);
            this.contenedorGestionUsuarios.TabIndex = 21;
            // 
            // ID_proveedor
            // 
            this.ID_proveedor.DataPropertyName = "ID_proveedor";
            this.ID_proveedor.HeaderText = "ID proveedor";
            this.ID_proveedor.MinimumWidth = 6;
            this.ID_proveedor.Name = "ID_proveedor";
            this.ID_proveedor.ReadOnly = true;
            // 
            // RazonSocial
            // 
            this.RazonSocial.DataPropertyName = "RazonSocial";
            this.RazonSocial.HeaderText = "Razón Social";
            this.RazonSocial.MinimumWidth = 6;
            this.RazonSocial.Name = "RazonSocial";
            this.RazonSocial.ReadOnly = true;
            // 
            // Correo
            // 
            this.Correo.DataPropertyName = "Correo";
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.ReadOnly = true;
            // 
            // Telefono
            // 
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Teléfono";
            this.Telefono.MinimumWidth = 6;
            this.Telefono.Name = "Telefono";
            this.Telefono.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.DataPropertyName = "Estado";
            this.Estado.HeaderText = "Estado";
            this.Estado.MinimumWidth = 6;
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            // 
            // Cuit
            // 
            this.Cuit.DataPropertyName = "Cuit";
            this.Cuit.HeaderText = "Cuit";
            this.Cuit.MinimumWidth = 6;
            this.Cuit.Name = "Cuit";
            this.Cuit.ReadOnly = true;
            // 
            // Domicilio
            // 
            this.Domicilio.DataPropertyName = "Domicilio";
            this.Domicilio.HeaderText = "Domicilio";
            this.Domicilio.MinimumWidth = 6;
            this.Domicilio.Name = "Domicilio";
            this.Domicilio.ReadOnly = true;
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 739);
            this.Controls.Add(this.contenedorDatos);
            this.Controls.Add(this.contenedorGestionUsuarios);
            this.Controls.Add(this.contenedorBotones);
            this.Controls.Add(this.contenedorLista);
            this.Controls.Add(this.DGlistaproveedores);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "GestionProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GestionProveedores";
            this.Load += new System.EventHandler(this.GestionProveedores_Load);
            this.contenedorDatos.ResumeLayout(false);
            this.contenedorDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedoresBindingSource1)).EndInit();
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
        private System.Windows.Forms.RadioButton RBinactivop;
        private System.Windows.Forms.RadioButton RBactivop;
        private System.Windows.Forms.Label listaProveedores;
        private System.Windows.Forms.Panel contenedorLista;
        private System.Windows.Forms.Label Lbuscar;
        public FontAwesome.Sharp.IconButton btnBuscar;
        private System.Windows.Forms.Panel contenedorBotones;
        private System.Windows.Forms.Panel contenedorGestionUsuarios;
        public System.Windows.Forms.TextBox TBBuscador;
        public FontAwesome.Sharp.IconButton TBlimpiar;
        public DataGridView DGlistaproveedores;
        public TextBox TBcuit;
        public TextBox TBRazonSocial;
        public TextBox TBcorreo;
        public TextBox TBdomiciliop;
        public TextBox TBtelefono;
        private BindingSource proveedoresBindingSource1;
        private DataGridViewTextBoxColumn ID_proveedor;
        private DataGridViewTextBoxColumn RazonSocial;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn Cuit;
        private DataGridViewTextBoxColumn Domicilio;
    }
}