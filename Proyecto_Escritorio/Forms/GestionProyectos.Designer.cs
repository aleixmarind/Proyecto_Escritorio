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
            this.button_VerProyectos = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
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
            // button_VerProyectos
            // 
            this.button_VerProyectos.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_VerProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_VerProyectos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_VerProyectos.Location = new System.Drawing.Point(276, 131);
            this.button_VerProyectos.Name = "button_VerProyectos";
            this.button_VerProyectos.Size = new System.Drawing.Size(246, 44);
            this.button_VerProyectos.TabIndex = 16;
            this.button_VerProyectos.Text = "Ver proyectos";
            this.button_VerProyectos.UseVisualStyleBackColor = false;
            this.button_VerProyectos.Click += new System.EventHandler(this.button_VerProyectos_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(276, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 40);
            this.button1.TabIndex = 17;
            this.button1.Text = "Eliminar proyecto";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Firebrick;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(276, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 40);
            this.button2.TabIndex = 18;
            this.button2.Text = "Menu principal";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // GestionProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_VerProyectos);
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
        private System.Windows.Forms.Button button_VerProyectos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}