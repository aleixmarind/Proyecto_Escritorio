namespace Proyecto_Escritorio
{
    partial class GestionProyectos
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
            this.label_GestionProyectos = new System.Windows.Forms.Label();
            this.label_NombreProyecto = new System.Windows.Forms.Label();
            this.textBox_NombreProyecto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_Comentarios = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Escritorio.Properties.Resources.nanoskills_logo;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 108);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label_GestionProyectos
            // 
            this.label_GestionProyectos.AutoSize = true;
            this.label_GestionProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GestionProyectos.Location = new System.Drawing.Point(208, 32);
            this.label_GestionProyectos.Name = "label_GestionProyectos";
            this.label_GestionProyectos.Size = new System.Drawing.Size(380, 59);
            this.label_GestionProyectos.TabIndex = 7;
            this.label_GestionProyectos.Text = "Gestion Proyectos";
            // 
            // label_NombreProyecto
            // 
            this.label_NombreProyecto.AutoSize = true;
            this.label_NombreProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreProyecto.Location = new System.Drawing.Point(279, 101);
            this.label_NombreProyecto.Name = "label_NombreProyecto";
            this.label_NombreProyecto.Size = new System.Drawing.Size(158, 20);
            this.label_NombreProyecto.TabIndex = 9;
            this.label_NombreProyecto.Text = "Nombre Del Proyecto";
            // 
            // textBox_NombreProyecto
            // 
            this.textBox_NombreProyecto.Location = new System.Drawing.Point(280, 125);
            this.textBox_NombreProyecto.Name = "textBox_NombreProyecto";
            this.textBox_NombreProyecto.Size = new System.Drawing.Size(246, 20);
            this.textBox_NombreProyecto.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Añadir Usuarios";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(280, 183);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label_Comentarios
            // 
            this.label_Comentarios.AutoSize = true;
            this.label_Comentarios.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Comentarios.Location = new System.Drawing.Point(279, 222);
            this.label_Comentarios.Name = "label_Comentarios";
            this.label_Comentarios.Size = new System.Drawing.Size(95, 20);
            this.label_Comentarios.TabIndex = 13;
            this.label_Comentarios.Text = "Comentarios";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(280, 245);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 20);
            this.textBox2.TabIndex = 14;
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_Comentarios);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_NombreProyecto);
            this.Controls.Add(this.label_NombreProyecto);
            this.Controls.Add(this.label_GestionProyectos);
            this.Controls.Add(this.pictureBox1);
            this.Name = "GestionProyectos";
            this.Text = "GestionProyectos";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_GestionProyectos;
        private System.Windows.Forms.Label label_NombreProyecto;
        private System.Windows.Forms.TextBox textBox_NombreProyecto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_Comentarios;
        private System.Windows.Forms.TextBox textBox2;
    }
}