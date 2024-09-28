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
            this.Bguardar = new FontAwesome.Sharp.IconButton();
            this.Beditar = new FontAwesome.Sharp.IconButton();
            this.Beliminar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RBiactivop = new System.Windows.Forms.RadioButton();
            this.RBactivop = new System.Windows.Forms.RadioButton();
            this.TBtelefono = new System.Windows.Forms.MaskedTextBox();
            this.TBcorreo = new System.Windows.Forms.TextBox();
            this.TBdomiciliop = new System.Windows.Forms.TextBox();
            this.TBcuit = new System.Windows.Forms.TextBox();
            this.TBrasonSocial = new System.Windows.Forms.TextBox();
            this.Lestadoproveedor = new System.Windows.Forms.Label();
            this.Lcorreoproveedor = new System.Windows.Forms.Label();
            this.Ltelefonoproveedor = new System.Windows.Forms.Label();
            this.LdomicilioProveedor = new System.Windows.Forms.Label();
            this.Lcuit = new System.Windows.Forms.Label();
            this.Lrazonsocial = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGlistaproveedores = new System.Windows.Forms.DataGridView();
            this.id_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuitProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.domicilioProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listaProveedores = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).BeginInit();
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
            this.Bguardar.Location = new System.Drawing.Point(16, 101);
            this.Bguardar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Bguardar.Name = "Bguardar";
            this.Bguardar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bguardar.Size = new System.Drawing.Size(244, 33);
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
            this.Beditar.Location = new System.Drawing.Point(16, 141);
            this.Beditar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beditar.Name = "Beditar";
            this.Beditar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beditar.Size = new System.Drawing.Size(244, 33);
            this.Beditar.TabIndex = 10;
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
            this.Beliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Beliminar.ForeColor = System.Drawing.Color.White;
            this.Beliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.Beliminar.IconColor = System.Drawing.Color.White;
            this.Beliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Beliminar.IconSize = 21;
            this.Beliminar.Location = new System.Drawing.Point(16, 181);
            this.Beliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Beliminar.Name = "Beliminar";
            this.Beliminar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Beliminar.Size = new System.Drawing.Size(244, 33);
            this.Beliminar.TabIndex = 11;
            this.Beliminar.Text = "Eliminar";
            this.Beliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Beliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Beliminar.UseVisualStyleBackColor = false;
            this.Beliminar.Click += new System.EventHandler(this.Beliminar_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.RBiactivop);
            this.panel1.Controls.Add(this.RBactivop);
            this.panel1.Controls.Add(this.TBtelefono);
            this.panel1.Controls.Add(this.TBcorreo);
            this.panel1.Controls.Add(this.TBdomiciliop);
            this.panel1.Controls.Add(this.TBcuit);
            this.panel1.Controls.Add(this.TBrasonSocial);
            this.panel1.Controls.Add(this.Lestadoproveedor);
            this.panel1.Controls.Add(this.Lcorreoproveedor);
            this.panel1.Controls.Add(this.Ltelefonoproveedor);
            this.panel1.Controls.Add(this.LdomicilioProveedor);
            this.panel1.Controls.Add(this.Lcuit);
            this.panel1.Controls.Add(this.Lrazonsocial);
            this.panel1.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(274, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 251);
            this.panel1.TabIndex = 12;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // RBiactivop
            // 
            this.RBiactivop.AutoSize = true;
            this.RBiactivop.Location = new System.Drawing.Point(561, 212);
            this.RBiactivop.Name = "RBiactivop";
            this.RBiactivop.Size = new System.Drawing.Size(90, 23);
            this.RBiactivop.TabIndex = 12;
            this.RBiactivop.Text = "Inactivo";
            this.RBiactivop.UseVisualStyleBackColor = true;
            // 
            // RBactivop
            // 
            this.RBactivop.AutoSize = true;
            this.RBactivop.Checked = true;
            this.RBactivop.Location = new System.Drawing.Point(414, 212);
            this.RBactivop.Name = "RBactivop";
            this.RBactivop.Size = new System.Drawing.Size(75, 23);
            this.RBactivop.TabIndex = 11;
            this.RBactivop.TabStop = true;
            this.RBactivop.Text = "Activo";
            this.RBactivop.UseVisualStyleBackColor = true;
            // 
            // TBtelefono
            // 
            this.TBtelefono.Location = new System.Drawing.Point(414, 140);
            this.TBtelefono.Mask = "(999)000-0000";
            this.TBtelefono.Name = "TBtelefono";
            this.TBtelefono.Size = new System.Drawing.Size(277, 26);
            this.TBtelefono.TabIndex = 10;
            // 
            // TBcorreo
            // 
            this.TBcorreo.Location = new System.Drawing.Point(414, 71);
            this.TBcorreo.Name = "TBcorreo";
            this.TBcorreo.Size = new System.Drawing.Size(277, 26);
            this.TBcorreo.TabIndex = 9;
            this.TBcorreo.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // TBdomiciliop
            // 
            this.TBdomiciliop.Location = new System.Drawing.Point(56, 209);
            this.TBdomiciliop.Name = "TBdomiciliop";
            this.TBdomiciliop.Size = new System.Drawing.Size(277, 26);
            this.TBdomiciliop.TabIndex = 8;
            // 
            // TBcuit
            // 
            this.TBcuit.Location = new System.Drawing.Point(56, 140);
            this.TBcuit.Name = "TBcuit";
            this.TBcuit.Size = new System.Drawing.Size(277, 26);
            this.TBcuit.TabIndex = 7;
            this.TBcuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtnumeros_KeyPress);
            // 
            // TBrasonSocial
            // 
            this.TBrasonSocial.Location = new System.Drawing.Point(56, 69);
            this.TBrasonSocial.Name = "TBrasonSocial";
            this.TBrasonSocial.Size = new System.Drawing.Size(277, 26);
            this.TBrasonSocial.TabIndex = 6;
            this.TBrasonSocial.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.TBrasonSocial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtpalabras_KeyPress);
            // 
            // Lestadoproveedor
            // 
            this.Lestadoproveedor.AutoSize = true;
            this.Lestadoproveedor.Location = new System.Drawing.Point(410, 187);
            this.Lestadoproveedor.Name = "Lestadoproveedor";
            this.Lestadoproveedor.Size = new System.Drawing.Size(62, 19);
            this.Lestadoproveedor.TabIndex = 5;
            this.Lestadoproveedor.Text = "Estado";
            // 
            // Lcorreoproveedor
            // 
            this.Lcorreoproveedor.AutoSize = true;
            this.Lcorreoproveedor.Location = new System.Drawing.Point(410, 43);
            this.Lcorreoproveedor.Name = "Lcorreoproveedor";
            this.Lcorreoproveedor.Size = new System.Drawing.Size(64, 19);
            this.Lcorreoproveedor.TabIndex = 4;
            this.Lcorreoproveedor.Text = "Correo";
            this.Lcorreoproveedor.Click += new System.EventHandler(this.label5_Click);
            // 
            // Ltelefonoproveedor
            // 
            this.Ltelefonoproveedor.AutoSize = true;
            this.Ltelefonoproveedor.Location = new System.Drawing.Point(410, 118);
            this.Ltelefonoproveedor.Name = "Ltelefonoproveedor";
            this.Ltelefonoproveedor.Size = new System.Drawing.Size(77, 19);
            this.Ltelefonoproveedor.TabIndex = 3;
            this.Ltelefonoproveedor.Text = "Telefono";
            // 
            // LdomicilioProveedor
            // 
            this.LdomicilioProveedor.AutoSize = true;
            this.LdomicilioProveedor.Location = new System.Drawing.Point(52, 187);
            this.LdomicilioProveedor.Name = "LdomicilioProveedor";
            this.LdomicilioProveedor.Size = new System.Drawing.Size(82, 19);
            this.LdomicilioProveedor.TabIndex = 2;
            this.LdomicilioProveedor.Text = "Domicilio";
            // 
            // Lcuit
            // 
            this.Lcuit.AutoSize = true;
            this.Lcuit.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lcuit.Location = new System.Drawing.Point(52, 118);
            this.Lcuit.Name = "Lcuit";
            this.Lcuit.Size = new System.Drawing.Size(42, 19);
            this.Lcuit.TabIndex = 1;
            this.Lcuit.Text = "Cuit";
            // 
            // Lrazonsocial
            // 
            this.Lrazonsocial.AutoSize = true;
            this.Lrazonsocial.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lrazonsocial.Location = new System.Drawing.Point(52, 38);
            this.Lrazonsocial.Name = "Lrazonsocial";
            this.Lrazonsocial.Size = new System.Drawing.Size(107, 19);
            this.Lrazonsocial.TabIndex = 0;
            this.Lrazonsocial.Text = "Razón Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(270, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 13;
            this.label1.Text = "Gestión Proveedores";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DGlistaproveedores
            // 
            this.DGlistaproveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGlistaproveedores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_proveedor,
            this.razonSocial,
            this.cuitProveedor,
            this.domicilioProveedor,
            this.correoProveedor,
            this.telefonoProveedor,
            this.estadoProveedor});
            this.DGlistaproveedores.Location = new System.Drawing.Point(145, 411);
            this.DGlistaproveedores.Name = "DGlistaproveedores";
            this.DGlistaproveedores.Size = new System.Drawing.Size(930, 235);
            this.DGlistaproveedores.TabIndex = 14;
            // 
            // id_proveedor
            // 
            this.id_proveedor.HeaderText = "ID";
            this.id_proveedor.Name = "id_proveedor";
            this.id_proveedor.Width = 50;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razon Social";
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.Width = 150;
            // 
            // cuitProveedor
            // 
            this.cuitProveedor.HeaderText = "Cuit";
            this.cuitProveedor.Name = "cuitProveedor";
            // 
            // domicilioProveedor
            // 
            this.domicilioProveedor.HeaderText = "Domicilio";
            this.domicilioProveedor.Name = "domicilioProveedor";
            this.domicilioProveedor.Width = 180;
            // 
            // correoProveedor
            // 
            this.correoProveedor.HeaderText = "Email";
            this.correoProveedor.Name = "correoProveedor";
            this.correoProveedor.Width = 180;
            // 
            // telefonoProveedor
            // 
            this.telefonoProveedor.HeaderText = "Telefono";
            this.telefonoProveedor.Name = "telefonoProveedor";
            this.telefonoProveedor.Width = 130;
            // 
            // estadoProveedor
            // 
            this.estadoProveedor.HeaderText = "Estado";
            this.estadoProveedor.Name = "estadoProveedor";
            // 
            // listaProveedores
            // 
            this.listaProveedores.AutoSize = true;
            this.listaProveedores.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaProveedores.Location = new System.Drawing.Point(152, 377);
            this.listaProveedores.Name = "listaProveedores";
            this.listaProveedores.Size = new System.Drawing.Size(233, 23);
            this.listaProveedores.TabIndex = 15;
            this.listaProveedores.Text = "Lsiata de Proveedores";
            // 
            // GestionProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1200, 658);
            this.Controls.Add(this.listaProveedores);
            this.Controls.Add(this.DGlistaproveedores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Beliminar);
            this.Controls.Add(this.Beditar);
            this.Controls.Add(this.Bguardar);
            this.Font = new System.Drawing.Font("Century Schoolbook", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "GestionProveedores";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGlistaproveedores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public FontAwesome.Sharp.IconButton Bguardar;
        public FontAwesome.Sharp.IconButton Beditar;
        public FontAwesome.Sharp.IconButton Beliminar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lestadoproveedor;
        private System.Windows.Forms.Label Lcorreoproveedor;
        private System.Windows.Forms.Label Ltelefonoproveedor;
        private System.Windows.Forms.Label LdomicilioProveedor;
        private System.Windows.Forms.Label Lcuit;
        private System.Windows.Forms.Label Lrazonsocial;
        private System.Windows.Forms.TextBox TBrasonSocial;
        private System.Windows.Forms.MaskedTextBox TBtelefono;
        private System.Windows.Forms.TextBox TBcorreo;
        private System.Windows.Forms.TextBox TBdomiciliop;
        private System.Windows.Forms.TextBox TBcuit;
        private System.Windows.Forms.RadioButton RBiactivop;
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
    }
}