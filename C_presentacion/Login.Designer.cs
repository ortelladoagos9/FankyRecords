namespace FankyRecords.C_presentacion
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.TBClave = new System.Windows.Forms.TextBox();
            this.TBDni = new System.Windows.Forms.TextBox();
            this.LDni = new System.Windows.Forms.Label();
            this.LClave = new System.Windows.Forms.Label();
            this.LIniciarSesion = new System.Windows.Forms.Label();
            this.Bsalir = new FontAwesome.Sharp.IconButton();
            this.Bingresar = new FontAwesome.Sharp.IconButton();
            this.picFankyRecordsAdministrador = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsAdministrador)).BeginInit();
            this.SuspendLayout();
            // 
            // TBClave
            // 
            this.TBClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBClave.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBClave.Location = new System.Drawing.Point(414, 495);
            this.TBClave.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.TBClave.MaxLength = 10;
            this.TBClave.Name = "TBClave";
            this.TBClave.PasswordChar = '*';
            this.TBClave.Size = new System.Drawing.Size(272, 40);
            this.TBClave.TabIndex = 1;
            // 
            // TBDni
            // 
            this.TBDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TBDni.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBDni.Location = new System.Drawing.Point(414, 369);
            this.TBDni.Margin = new System.Windows.Forms.Padding(8, 5, 8, 5);
            this.TBDni.MaxLength = 8;
            this.TBDni.Name = "TBDni";
            this.TBDni.Size = new System.Drawing.Size(272, 40);
            this.TBDni.TabIndex = 0;
            this.TBDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TBDni_KeyPress);
            // 
            // LDni
            // 
            this.LDni.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LDni.AutoSize = true;
            this.LDni.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LDni.Location = new System.Drawing.Point(414, 320);
            this.LDni.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LDni.Name = "LDni";
            this.LDni.Size = new System.Drawing.Size(73, 34);
            this.LDni.TabIndex = 10;
            this.LDni.Text = "DNI";
            // 
            // LClave
            // 
            this.LClave.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LClave.AutoSize = true;
            this.LClave.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LClave.Location = new System.Drawing.Point(414, 446);
            this.LClave.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(183, 34);
            this.LClave.TabIndex = 11;
            this.LClave.Text = "Contraseña";
            // 
            // LIniciarSesion
            // 
            this.LIniciarSesion.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.LIniciarSesion.Dock = System.Windows.Forms.DockStyle.Top;
            this.LIniciarSesion.Font = new System.Drawing.Font("Century Schoolbook", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LIniciarSesion.ForeColor = System.Drawing.Color.DarkRed;
            this.LIniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.LIniciarSesion.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.LIniciarSesion.Name = "LIniciarSesion";
            this.LIniciarSesion.Size = new System.Drawing.Size(1103, 320);
            this.LIniciarSesion.TabIndex = 15;
            this.LIniciarSesion.Text = "Iniciar Sesión";
            this.LIniciarSesion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Bsalir
            // 
            this.Bsalir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bsalir.BackColor = System.Drawing.Color.DarkRed;
            this.Bsalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bsalir.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bsalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bsalir.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bsalir.ForeColor = System.Drawing.Color.White;
            this.Bsalir.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.Bsalir.IconColor = System.Drawing.Color.White;
            this.Bsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bsalir.IconSize = 30;
            this.Bsalir.Location = new System.Drawing.Point(574, 600);
            this.Bsalir.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Bsalir.Name = "Bsalir";
            this.Bsalir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bsalir.Size = new System.Drawing.Size(162, 46);
            this.Bsalir.TabIndex = 14;
            this.Bsalir.Text = "Salir";
            this.Bsalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bsalir.UseVisualStyleBackColor = false;
            this.Bsalir.Click += new System.EventHandler(this.Bsalir_Click);
            // 
            // Bingresar
            // 
            this.Bingresar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Bingresar.BackColor = System.Drawing.Color.DarkGreen;
            this.Bingresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bingresar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.Bingresar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Bingresar.Font = new System.Drawing.Font("Century Schoolbook", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bingresar.ForeColor = System.Drawing.Color.White;
            this.Bingresar.IconChar = FontAwesome.Sharp.IconChar.Laugh;
            this.Bingresar.IconColor = System.Drawing.Color.White;
            this.Bingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bingresar.IconSize = 30;
            this.Bingresar.Location = new System.Drawing.Point(380, 600);
            this.Bingresar.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Bingresar.Name = "Bingresar";
            this.Bingresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Bingresar.Size = new System.Drawing.Size(162, 46);
            this.Bingresar.TabIndex = 12;
            this.Bingresar.Text = "Ingresar";
            this.Bingresar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Bingresar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bingresar.UseVisualStyleBackColor = false;
            this.Bingresar.Click += new System.EventHandler(this.Bingresar_Click);
            // 
            // picFankyRecordsAdministrador
            // 
            this.picFankyRecordsAdministrador.BackColor = System.Drawing.Color.DarkRed;
            this.picFankyRecordsAdministrador.Cursor = System.Windows.Forms.Cursors.Default;
            this.picFankyRecordsAdministrador.Dock = System.Windows.Forms.DockStyle.Right;
            this.picFankyRecordsAdministrador.Image = global::FankyRecords.Properties.Resources.Fanky_records1;
            this.picFankyRecordsAdministrador.Location = new System.Drawing.Point(1103, 0);
            this.picFankyRecordsAdministrador.Margin = new System.Windows.Forms.Padding(4);
            this.picFankyRecordsAdministrador.Name = "picFankyRecordsAdministrador";
            this.picFankyRecordsAdministrador.Size = new System.Drawing.Size(315, 916);
            this.picFankyRecordsAdministrador.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picFankyRecordsAdministrador.TabIndex = 16;
            this.picFankyRecordsAdministrador.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1418, 916);
            this.Controls.Add(this.LIniciarSesion);
            this.Controls.Add(this.picFankyRecordsAdministrador);
            this.Controls.Add(this.Bsalir);
            this.Controls.Add(this.Bingresar);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.LDni);
            this.Controls.Add(this.TBDni);
            this.Controls.Add(this.TBClave);
            this.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkRed;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fanky Records";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown_1);
            ((System.ComponentModel.ISupportInitialize)(this.picFankyRecordsAdministrador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox TBClave;
        public System.Windows.Forms.TextBox TBDni;
        public System.Windows.Forms.Label LDni;
        public System.Windows.Forms.Label LClave;
        public FontAwesome.Sharp.IconButton Bingresar;
        public FontAwesome.Sharp.IconButton Bsalir;
        public System.Windows.Forms.Label LIniciarSesion;
        private System.Windows.Forms.PictureBox picFankyRecordsAdministrador;
    }
}