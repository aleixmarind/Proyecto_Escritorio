namespace Proyecto_Escritorio
{
    partial class VerProyectos
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
            this.listBoxTareas = new System.Windows.Forms.ListBox();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.listBoxProyectos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBoxTareas
            // 
            this.listBoxTareas.FormattingEnabled = true;
            this.listBoxTareas.Location = new System.Drawing.Point(207, 119);
            this.listBoxTareas.Name = "listBoxTareas";
            this.listBoxTareas.Size = new System.Drawing.Size(120, 95);
            this.listBoxTareas.TabIndex = 0;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Location = new System.Drawing.Point(341, 255);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(75, 23);
            this.btnRefrescar.TabIndex = 1;
            this.btnRefrescar.Text = "button1";
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click_1);
            // 
            // listBoxProyectos
            // 
            this.listBoxProyectos.FormattingEnabled = true;
            this.listBoxProyectos.Location = new System.Drawing.Point(426, 119);
            this.listBoxProyectos.Name = "listBoxProyectos";
            this.listBoxProyectos.Size = new System.Drawing.Size(120, 95);
            this.listBoxProyectos.TabIndex = 2;
            // 
            // VerProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxProyectos);
            this.Controls.Add(this.btnRefrescar);
            this.Controls.Add(this.listBoxTareas);
            this.Name = "VerProyectos";
            this.Text = "VerProyectos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxTareas;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.ListBox listBoxProyectos;
    }
}