namespace Proyecto_Escritorio
{
    partial class CrearProyecto
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
            this.label_CrearProyecto = new System.Windows.Forms.Label();
            this.textBox_NombreProyecto = new System.Windows.Forms.TextBox();
            this.label_NombreProyecto = new System.Windows.Forms.Label();
            this.label_DescripcionProyecto = new System.Windows.Forms.Label();
            this.textBox_DescripcionProyecto = new System.Windows.Forms.TextBox();
            this.labelCompartir = new System.Windows.Forms.Label();
            this.textBox_Compartir = new System.Windows.Forms.TextBox();
            this.button_CrearProyecto = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label_CrearProyecto
            // 
            this.label_CrearProyecto.AutoSize = true;
            this.label_CrearProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CrearProyecto.Location = new System.Drawing.Point(259, 9);
            this.label_CrearProyecto.Name = "label_CrearProyecto";
            this.label_CrearProyecto.Size = new System.Drawing.Size(315, 59);
            this.label_CrearProyecto.TabIndex = 6;
            this.label_CrearProyecto.Text = "Crear Proyecto";
            // 
            // textBox_NombreProyecto
            // 
            this.textBox_NombreProyecto.Location = new System.Drawing.Point(290, 108);
            this.textBox_NombreProyecto.Name = "textBox_NombreProyecto";
            this.textBox_NombreProyecto.Size = new System.Drawing.Size(246, 20);
            this.textBox_NombreProyecto.TabIndex = 7;
            // 
            // label_NombreProyecto
            // 
            this.label_NombreProyecto.AutoSize = true;
            this.label_NombreProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_NombreProyecto.Location = new System.Drawing.Point(286, 85);
            this.label_NombreProyecto.Name = "label_NombreProyecto";
            this.label_NombreProyecto.Size = new System.Drawing.Size(158, 20);
            this.label_NombreProyecto.TabIndex = 8;
            this.label_NombreProyecto.Text = "Nombre Del Proyecto";
            // 
            // label_DescripcionProyecto
            // 
            this.label_DescripcionProyecto.AutoSize = true;
            this.label_DescripcionProyecto.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DescripcionProyecto.Location = new System.Drawing.Point(286, 149);
            this.label_DescripcionProyecto.Name = "label_DescripcionProyecto";
            this.label_DescripcionProyecto.Size = new System.Drawing.Size(181, 20);
            this.label_DescripcionProyecto.TabIndex = 10;
            this.label_DescripcionProyecto.Text = "Descripción Del Proyecto";
            this.label_DescripcionProyecto.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_DescripcionProyecto
            // 
            this.textBox_DescripcionProyecto.Location = new System.Drawing.Point(290, 184);
            this.textBox_DescripcionProyecto.Multiline = true;
            this.textBox_DescripcionProyecto.Name = "textBox_DescripcionProyecto";
            this.textBox_DescripcionProyecto.Size = new System.Drawing.Size(246, 100);
            this.textBox_DescripcionProyecto.TabIndex = 9;
            this.textBox_DescripcionProyecto.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelCompartir
            // 
            this.labelCompartir.AutoSize = true;
            this.labelCompartir.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompartir.Location = new System.Drawing.Point(286, 309);
            this.labelCompartir.Name = "labelCompartir";
            this.labelCompartir.Size = new System.Drawing.Size(78, 20);
            this.labelCompartir.TabIndex = 12;
            this.labelCompartir.Text = "Compartir";
            // 
            // textBox_Compartir
            // 
            this.textBox_Compartir.Location = new System.Drawing.Point(290, 332);
            this.textBox_Compartir.Name = "textBox_Compartir";
            this.textBox_Compartir.Size = new System.Drawing.Size(246, 20);
            this.textBox_Compartir.TabIndex = 11;
            // 
            // button_CrearProyecto
            // 
            this.button_CrearProyecto.BackColor = System.Drawing.SystemColors.Highlight;
            this.button_CrearProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_CrearProyecto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_CrearProyecto.Location = new System.Drawing.Point(331, 381);
            this.button_CrearProyecto.Name = "button_CrearProyecto";
            this.button_CrearProyecto.Size = new System.Drawing.Size(176, 44);
            this.button_CrearProyecto.TabIndex = 13;
            this.button_CrearProyecto.Text = "Crear Proyecto";
            this.button_CrearProyecto.UseVisualStyleBackColor = false;
            this.button_CrearProyecto.Click += new System.EventHandler(this.button_CrearProyecto_Click);
            // 
            // CrearProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_CrearProyecto);
            this.Controls.Add(this.labelCompartir);
            this.Controls.Add(this.textBox_Compartir);
            this.Controls.Add(this.label_DescripcionProyecto);
            this.Controls.Add(this.textBox_DescripcionProyecto);
            this.Controls.Add(this.label_NombreProyecto);
            this.Controls.Add(this.textBox_NombreProyecto);
            this.Controls.Add(this.label_CrearProyecto);
            this.Controls.Add(this.pictureBox1);
            this.Name = "CrearProyecto";
            this.Text = "CrearProyecto";
            this.Load += new System.EventHandler(this.CrearProyecto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_CrearProyecto;
        private System.Windows.Forms.TextBox textBox_NombreProyecto;
        private System.Windows.Forms.Label label_NombreProyecto;
        private System.Windows.Forms.Label label_DescripcionProyecto;
        private System.Windows.Forms.Label labelCompartir;
        private System.Windows.Forms.TextBox textBox_Compartir;
        private System.Windows.Forms.Button button_CrearProyecto;
        public System.Windows.Forms.TextBox textBox_DescripcionProyecto;
    }
}