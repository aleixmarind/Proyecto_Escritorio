namespace Proyecto_Escritorio.Forms
{
    partial class Crear_Usuario
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
            this.label_CrearUsuario = new System.Windows.Forms.Label();
            this.label_NombreUsuario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_CrearUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_CrearUsuario
            // 
            this.label_CrearUsuario.AutoSize = true;
            this.label_CrearUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CrearUsuario.Location = new System.Drawing.Point(244, 9);
            this.label_CrearUsuario.Name = "label_CrearUsuario";
            this.label_CrearUsuario.Size = new System.Drawing.Size(290, 59);
            this.label_CrearUsuario.TabIndex = 7;
            this.label_CrearUsuario.Text = "Crear Usuario";
            // 
            // label_NombreUsuario
            // 
            this.label_NombreUsuario.AutoSize = true;
            this.label_NombreUsuario.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreUsuario.Location = new System.Drawing.Point(250, 96);
            this.label_NombreUsuario.Name = "label_NombreUsuario";
            this.label_NombreUsuario.Size = new System.Drawing.Size(150, 20);
            this.label_NombreUsuario.TabIndex = 10;
            this.label_NombreUsuario.Text = "Nombre Del Usuario";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(254, 119);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(246, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // label_Email
            // 
            this.label_Email.AutoSize = true;
            this.label_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Email.Location = new System.Drawing.Point(250, 163);
            this.label_Email.Name = "label_Email";
            this.label_Email.Size = new System.Drawing.Size(46, 20);
            this.label_Email.TabIndex = 12;
            this.label_Email.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(254, 186);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(250, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 249);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(246, 20);
            this.txtPassword.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Escritorio.Properties.Resources.nanoskills_logo;
            this.pictureBox1.Location = new System.Drawing.Point(671, 330);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // button_CrearUsuario
            // 
            this.button_CrearUsuario.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_CrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CrearUsuario.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_CrearUsuario.Location = new System.Drawing.Point(279, 290);
            this.button_CrearUsuario.Name = "button_CrearUsuario";
            this.button_CrearUsuario.Size = new System.Drawing.Size(194, 40);
            this.button_CrearUsuario.TabIndex = 15;
            this.button_CrearUsuario.Text = "Crear usuario";
            this.button_CrearUsuario.UseVisualStyleBackColor = false;
            this.button_CrearUsuario.Click += new System.EventHandler(this.button_CrearUsuario_Click);
            // 
            // Crear_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 431);
            this.Controls.Add(this.button_CrearUsuario);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label_NombreUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label_CrearUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Crear_Usuario";
            this.Text = "Crear_Usuario";
            this.Load += new System.EventHandler(this.Crear_Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_CrearUsuario;
        private System.Windows.Forms.Label label_NombreUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button_CrearUsuario;
    }
}