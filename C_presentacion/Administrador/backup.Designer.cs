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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TBbaseDatos = new System.Windows.Forms.TextBox();
            this.TBrutaGuardar = new System.Windows.Forms.TextBox();
            this.Bconecta = new FontAwesome.Sharp.IconButton();
            this.Bruta = new FontAwesome.Sharp.IconButton();
            this.Bbackup = new FontAwesome.Sharp.IconButton();
            this.Bcancelar = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Bcancelar);
            this.panel1.Controls.Add(this.Bbackup);
            this.panel1.Controls.Add(this.Bruta);
            this.panel1.Controls.Add(this.Bconecta);
            this.panel1.Controls.Add(this.TBrutaGuardar);
            this.panel1.Controls.Add(this.TBbaseDatos);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(311, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(687, 321);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Backup";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Base de Datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ruta guardar:";
            // 
            // TBbaseDatos
            // 
            this.TBbaseDatos.Location = new System.Drawing.Point(219, 81);
            this.TBbaseDatos.Name = "TBbaseDatos";
            this.TBbaseDatos.Size = new System.Drawing.Size(250, 26);
            this.TBbaseDatos.TabIndex = 2;
            // 
            // TBrutaGuardar
            // 
            this.TBrutaGuardar.Location = new System.Drawing.Point(219, 121);
            this.TBrutaGuardar.Name = "TBrutaGuardar";
            this.TBrutaGuardar.Size = new System.Drawing.Size(250, 26);
            this.TBrutaGuardar.TabIndex = 3;
            // 
            // Bconecta
            // 
            this.Bconecta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bconecta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bconecta.IconChar = FontAwesome.Sharp.IconChar.Connectdevelop;
            this.Bconecta.IconColor = System.Drawing.Color.DarkRed;
            this.Bconecta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bconecta.IconSize = 20;
            this.Bconecta.Location = new System.Drawing.Point(521, 77);
            this.Bconecta.Name = "Bconecta";
            this.Bconecta.Size = new System.Drawing.Size(105, 33);
            this.Bconecta.TabIndex = 4;
            this.Bconecta.Text = "Conecta";
            this.Bconecta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bconecta.UseVisualStyleBackColor = true;
            // 
            // Bruta
            // 
            this.Bruta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bruta.IconChar = FontAwesome.Sharp.IconChar.Road;
            this.Bruta.IconColor = System.Drawing.Color.DarkRed;
            this.Bruta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bruta.IconSize = 20;
            this.Bruta.Location = new System.Drawing.Point(521, 116);
            this.Bruta.Name = "Bruta";
            this.Bruta.Size = new System.Drawing.Size(105, 33);
            this.Bruta.TabIndex = 5;
            this.Bruta.Text = "Ruta";
            this.Bruta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Bruta.UseVisualStyleBackColor = true;
            // 
            // Bbackup
            // 
            this.Bbackup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bbackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bbackup.IconChar = FontAwesome.Sharp.IconChar.CircleUp;
            this.Bbackup.IconColor = System.Drawing.Color.DarkRed;
            this.Bbackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bbackup.IconSize = 30;
            this.Bbackup.Location = new System.Drawing.Point(182, 207);
            this.Bbackup.Name = "Bbackup";
            this.Bbackup.Size = new System.Drawing.Size(147, 53);
            this.Bbackup.TabIndex = 6;
            this.Bbackup.Text = "Backup";
            this.Bbackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bbackup.UseVisualStyleBackColor = true;
            // 
            // Bcancelar
            // 
            this.Bcancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bcancelar.IconChar = FontAwesome.Sharp.IconChar.CircleXmark;
            this.Bcancelar.IconColor = System.Drawing.Color.DarkRed;
            this.Bcancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Bcancelar.IconSize = 30;
            this.Bcancelar.Location = new System.Drawing.Point(350, 207);
            this.Bcancelar.Name = "Bcancelar";
            this.Bcancelar.Size = new System.Drawing.Size(147, 53);
            this.Bcancelar.TabIndex = 7;
            this.Bcancelar.Text = "Cancelar";
            this.Bcancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.Bcancelar.UseVisualStyleBackColor = true;
            // 
            // backup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.ClientSize = new System.Drawing.Size(1386, 788);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Bconecta;
        private System.Windows.Forms.TextBox TBrutaGuardar;
        private System.Windows.Forms.TextBox TBbaseDatos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Bbackup;
        private FontAwesome.Sharp.IconButton Bruta;
        private FontAwesome.Sharp.IconButton Bcancelar;
    }
}