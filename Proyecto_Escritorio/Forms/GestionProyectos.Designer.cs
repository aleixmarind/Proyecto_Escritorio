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
            this.label_GestionProyectos = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVerProyectos = new System.Windows.Forms.Button();
            this.btnMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_GestionProyectos
            // 
            this.label_GestionProyectos.AutoSize = true;
            this.label_GestionProyectos.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_GestionProyectos.Location = new System.Drawing.Point(217, 53);
            this.label_GestionProyectos.Name = "label_GestionProyectos";
            this.label_GestionProyectos.Size = new System.Drawing.Size(380, 59);
            this.label_GestionProyectos.TabIndex = 7;
            this.label_GestionProyectos.Text = "Gestion Proyectos";
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
            // btnVerProyectos
            // 
            this.btnVerProyectos.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnVerProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerProyectos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnVerProyectos.Location = new System.Drawing.Point(274, 168);
            this.btnVerProyectos.Name = "btnVerProyectos";
            this.btnVerProyectos.Size = new System.Drawing.Size(205, 39);
            this.btnVerProyectos.TabIndex = 8;
            this.btnVerProyectos.Text = "Ver proyectos";
            this.btnVerProyectos.UseVisualStyleBackColor = false;
            this.btnVerProyectos.Click += new System.EventHandler(this.btnVerProyectos_Click);
            // 
            // btnMenuPrincipal
            // 
            this.btnMenuPrincipal.BackColor = System.Drawing.Color.Firebrick;
            this.btnMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuPrincipal.Location = new System.Drawing.Point(274, 213);
            this.btnMenuPrincipal.Name = "btnMenuPrincipal";
            this.btnMenuPrincipal.Size = new System.Drawing.Size(205, 38);
            this.btnMenuPrincipal.TabIndex = 9;
            this.btnMenuPrincipal.Text = "Menu principal";
            this.btnMenuPrincipal.UseVisualStyleBackColor = false;
            this.btnMenuPrincipal.Click += new System.EventHandler(this.btnMenuPrincipal_Click);
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMenuPrincipal);
            this.Controls.Add(this.btnVerProyectos);
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
        private System.Windows.Forms.Button btnVerProyectos;
        private System.Windows.Forms.Button btnMenuPrincipal;
    }
}