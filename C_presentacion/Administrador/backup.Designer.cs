namespace FankyRecords.C_presentacion.Administrador
{
    partial class backup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Bcancelar = new FontAwesome.Sharp.IconButton();
            this.Bbackup = new FontAwesome.Sharp.IconButton();
            this.TBrutaGuardar = new System.Windows.Forms.TextBox();
            this.TBbaseDatos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.contenedorDetalleCompra = new System.Windows.Forms.Panel();
            this.BtnNavegar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.contenedorDetalleCompra.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnNavegar);
            this.panel1.Controls.Add(this.Bcancelar);
            this.panel1.Controls.Add(this.Bbackup);
            this.panel1.Controls.Add(this.TBrutaGuardar);
            this.panel1.Controls.Add(this.TBbaseDatos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 654);
            this.panel1.TabIndex = 0;
            // 
            // Bcancelar
            // 
            this.Bcancelar.BackColor = System.Drawing.Color.White;
            this.Bcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bcancelar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bcancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.Bcancelar.IconColor = System.Drawing.Color.DarkRed;
            this.Bcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bcancelar.IconSize = 25;
            this.Bcancelar.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Bcancelar.Location = new System.Drawing.Point(712, 374);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(128, 30);
            this.Bcancelar.TabIndex = 7;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bcancelar.UseVisualStyleBackColor = false;
            this.Bcancelar.Click += new System.EventHandler(this.Bcancelar_Click);
            // 
            // Bbackup
            // 
            this.Bbackup.BackColor = System.Drawing.Color.White;
            this.Bbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbackup.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bbackup.IconChar = FontAwesome.Sharp.IconChar.CircleUp;
            this.Bbackup.IconColor = System.Drawing.Color.DarkRed;
            this.Bbackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bbackup.IconSize = 25;
            this.Bbackup.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.Bbackup.Location = new System.Drawing.Point(712, 315);
            this.Bbackup.Name = "Bbackup";
            this.Bbackup.Size = new System.Drawing.Size(128, 30);
            this.Bbackup.TabIndex = 6;
            this.Bbackup.Text = "Backup";
            this.Bbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bbackup.UseVisualStyleBackColor = false;
            this.Bbackup.Click += new System.EventHandler(this.Bbackup_Click);
            // 
            // TBrutaGuardar
            // 
            this.TBrutaGuardar.Location = new System.Drawing.Point(487, 257);
            this.TBrutaGuardar.Name = "TBrutaGuardar";
            this.TBrutaGuardar.Size = new System.Drawing.Size(210, 30);
            this.TBrutaGuardar.TabIndex = 3;
            // 
            // TBbaseDatos
            // 
            this.TBbaseDatos.Location = new System.Drawing.Point(487, 315);
            this.TBbaseDatos.Name = "TBbaseDatos";
            this.TBbaseDatos.Size = new System.Drawing.Size(210, 30);
            this.TBbaseDatos.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(283, 266);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 21);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ruta donde guardar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre de base de datos:";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // contenedorDetalleCompra
            // 
            this.contenedorDetalleCompra.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.contenedorDetalleCompra.Controls.Add(this.label1);
            this.contenedorDetalleCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.contenedorDetalleCompra.Location = new System.Drawing.Point(0, 0);
            this.contenedorDetalleCompra.Margin = new System.Windows.Forms.Padding(4);
            this.contenedorDetalleCompra.Name = "contenedorDetalleCompra";
            this.contenedorDetalleCompra.Size = new System.Drawing.Size(1182, 74);
            this.contenedorDetalleCompra.TabIndex = 24;
            // 
            // BtnNavegar
            // 
            this.BtnNavegar.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNavegar.Location = new System.Drawing.Point(712, 257);
            this.BtnNavegar.Name = "BtnNavegar";
            this.BtnNavegar.Size = new System.Drawing.Size(128, 30);
            this.BtnNavegar.TabIndex = 8;
            this.BtnNavegar.Text = "Navegar";
            this.BtnNavegar.UseVisualStyleBackColor = true;
            this.BtnNavegar.Click += new System.EventHandler(this.BtnNavegar_Click);
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1182, 654);
            this.Controls.Add(this.contenedorDetalleCompra);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "backup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "backup";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contenedorDetalleCompra.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox TBrutaGuardar;
        private System.Windows.Forms.TextBox TBbaseDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Bbackup;
        private FontAwesome.Sharp.IconButton Bcancelar;
        public System.Windows.Forms.Panel contenedorDetalleCompra;
        private System.Windows.Forms.Button BtnNavegar;
    }
}