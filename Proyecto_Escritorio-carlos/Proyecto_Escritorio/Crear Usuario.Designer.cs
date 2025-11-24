namespace Proyecto_Escritorio
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label_CrearUsuario = new System.Windows.Forms.Label();
            this.label_NombreUsuario = new System.Windows.Forms.Label();
            this.textBox_NombreUsuario = new System.Windows.Forms.TextBox();
            this.label_Email = new System.Windows.Forms.Label();
            this.textBox_EmailUsuario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Escritorio.Properties.Resources.nanoskills_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            // textBox_NombreUsuario
            // 
            this.textBox_NombreUsuario.Location = new System.Drawing.Point(254, 119);
            this.textBox_NombreUsuario.Name = "textBox_NombreUsuario";
            this.textBox_NombreUsuario.Size = new System.Drawing.Size(246, 20);
            this.textBox_NombreUsuario.TabIndex = 9;
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
            // textBox_EmailUsuario
            // 
            this.textBox_EmailUsuario.Location = new System.Drawing.Point(254, 186);
            this.textBox_EmailUsuario.Name = "textBox_EmailUsuario";
            this.textBox_EmailUsuario.Size = new System.Drawing.Size(246, 20);
            this.textBox_EmailUsuario.TabIndex = 11;
            // 
            // Crear_Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.textBox_EmailUsuario);
            this.Controls.Add(this.label_NombreUsuario);
            this.Controls.Add(this.textBox_NombreUsuario);
            this.Controls.Add(this.label_CrearUsuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Crear_Usuario";
            this.Text = "Crear_Usuario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_CrearUsuario;
        private System.Windows.Forms.Label label_NombreUsuario;
        private System.Windows.Forms.TextBox textBox_NombreUsuario;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.TextBox textBox_EmailUsuario;
    }
}