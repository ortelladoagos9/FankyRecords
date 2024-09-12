namespace FankyRecords.C_presentacion.Administrador
{
    partial class menuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuAdmin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnGestUser = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkRed;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.BtnGestUser);
            this.panel1.Location = new System.Drawing.Point(729, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(314, 757);
            this.panel1.TabIndex = 0;
            // 
            // BtnGestUser
            // 
            this.BtnGestUser.BackColor = System.Drawing.Color.LightPink;
            this.BtnGestUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGestUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGestUser.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGestUser.ForeColor = System.Drawing.Color.DarkRed;
            this.BtnGestUser.Image = global::FankyRecords.Properties.Resources.vinilo1;
            this.BtnGestUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGestUser.Location = new System.Drawing.Point(-3, 71);
            this.BtnGestUser.Name = "BtnGestUser";
            this.BtnGestUser.Size = new System.Drawing.Size(323, 48);
            this.BtnGestUser.TabIndex = 0;
            this.BtnGestUser.Text = "Gestionar Usuarios";
            this.BtnGestUser.UseVisualStyleBackColor = false;
            this.BtnGestUser.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightPink;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkRed;
            this.button1.Image = global::FankyRecords.Properties.Resources.vinilo1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(-3, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(323, 48);
            this.button1.TabIndex = 1;
            this.button1.Text = "Gestionar Proveedores";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightPink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.DarkRed;
            this.button2.Image = global::FankyRecords.Properties.Resources.vinilo1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(-3, 213);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(323, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Gestionar Proveedores";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1042, 753);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "menuAdmin";
            this.Text = "Menu Administrador";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnGestUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}