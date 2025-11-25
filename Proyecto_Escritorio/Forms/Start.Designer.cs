namespace Proyecto_Escritorio
{
    partial class Start
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
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button_Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Logo
            // 
            this.Logo.Image = global::Proyecto_Escritorio.Properties.Resources.nanoskills_logo;
            this.Logo.Location = new System.Drawing.Point(325, 92);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(153, 114);
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // button_Entrar
            // 
            this.button_Entrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Entrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Entrar.Location = new System.Drawing.Point(308, 240);
            this.button_Entrar.Name = "button_Entrar";
            this.button_Entrar.Size = new System.Drawing.Size(194, 40);
            this.button_Entrar.TabIndex = 7;
            this.button_Entrar.Text = "Entrar";
            this.button_Entrar.UseVisualStyleBackColor = false;
            this.button_Entrar.Click += new System.EventHandler(this.button_Entrar_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Entrar);
            this.Controls.Add(this.Logo);
            this.Name = "Start";
            this.Text = "Start";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button_Entrar;
    }
}