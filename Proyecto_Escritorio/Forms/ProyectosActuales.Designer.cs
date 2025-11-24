namespace Proyecto_Escritorio
{
    partial class ProyectosActuales
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
            this.label_Servicios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_Servicios
            // 
            this.label_Servicios.AutoSize = true;
            this.label_Servicios.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Servicios.Location = new System.Drawing.Point(196, 44);
            this.label_Servicios.Name = "label_Servicios";
            this.label_Servicios.Size = new System.Drawing.Size(388, 59);
            this.label_Servicios.TabIndex = 6;
            this.label_Servicios.Text = "Proyectos actuales";
            // 
            // ProyectosActuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_Servicios);
            this.Name = "ProyectosActuales";
            this.Text = "ProyectosActuales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Servicios;
    }
}