namespace Proyecto_Escritorio
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_InicioSesion = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.textBoxContrasena = new System.Windows.Forms.TextBox();
            this.button_IniciarSesion = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.label_Contraseña = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_InicioSesion
            // 
            this.label_InicioSesion.AutoSize = true;
            this.label_InicioSesion.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_InicioSesion.Location = new System.Drawing.Point(255, 143);
            this.label_InicioSesion.Name = "label_InicioSesion";
            this.label_InicioSesion.Size = new System.Drawing.Size(271, 54);
            this.label_InicioSesion.TabIndex = 1;
            this.label_InicioSesion.Text = "Iniciar Sesion";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(264, 237);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(235, 20);
            this.textBoxCorreo.TabIndex = 2;
            // 
            // textBoxContrasena
            // 
            this.textBoxContrasena.Location = new System.Drawing.Point(264, 287);
            this.textBoxContrasena.Name = "textBoxContrasena";
            this.textBoxContrasena.Size = new System.Drawing.Size(235, 20);
            this.textBoxContrasena.TabIndex = 4;
            // 
            // button_IniciarSesion
            // 
            this.button_IniciarSesion.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_IniciarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_IniciarSesion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_IniciarSesion.Location = new System.Drawing.Point(306, 353);
            this.button_IniciarSesion.Name = "button_IniciarSesion";
            this.button_IniciarSesion.Size = new System.Drawing.Size(163, 35);
            this.button_IniciarSesion.TabIndex = 6;
            this.button_IniciarSesion.Text = "Iniciar Sesión";
            this.button_IniciarSesion.UseVisualStyleBackColor = false;
            this.button_IniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Escritorio.Properties.Resources.Captura_de_pantalla_2025_10_20_190643;
            this.pictureBox2.Location = new System.Drawing.Point(494, 287);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(23, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Escritorio.Properties.Resources.Captura_de_pantalla_2025_10_20_190627;
            this.pictureBox1.Location = new System.Drawing.Point(494, 237);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Logo
            // 
            this.Logo.Image = global::Proyecto_Escritorio.Properties.Resources.nanoskills_logo;
            this.Logo.Location = new System.Drawing.Point(306, 12);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(156, 128);
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(264, 218);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(40, 17);
            this.label_Email.TabIndex = 7;
            this.label_Email.Text = "Email";
            // 
            // label_Contraseña
            // 
            this.label_Contraseña.AutoSize = true;
            this.label_Contraseña.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Contraseña.Location = new System.Drawing.Point(264, 267);
            this.label_Contraseña.Name = "label_Contraseña";
            this.label_Contraseña.Size = new System.Drawing.Size(77, 17);
            this.label_Contraseña.TabIndex = 8;
            this.label_Contraseña.Text = "Contraseña";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Contraseña);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.button_IniciarSesion);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxContrasena);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.label_InicioSesion);
            this.Controls.Add(this.Logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label_InicioSesion;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBoxContrasena;
        private System.Windows.Forms.Button button_IniciarSesion;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Label label_Contraseña;
    }
}

