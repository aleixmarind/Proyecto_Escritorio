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
            this.groupBox_Proyectos = new System.Windows.Forms.GroupBox();
            this.listBox_Proyectos = new System.Windows.Forms.ListBox();
            this.button_Recargar = new System.Windows.Forms.Button();
            this.button_EliminarProyecto = new System.Windows.Forms.Button();
            this.button_MenuPrincipal = new System.Windows.Forms.Button();
            this.listBox_Tareas = new System.Windows.Forms.ListBox();
            this.groupBox_Tareas = new System.Windows.Forms.GroupBox();
            this.button_EditarProyecto = new System.Windows.Forms.Button();
            this.groupBox_Proyectos.SuspendLayout();
            this.groupBox_Tareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_Proyectos
            // 
            this.groupBox_Proyectos.Controls.Add(this.listBox_Proyectos);
            this.groupBox_Proyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Proyectos.Location = new System.Drawing.Point(12, 12);
            this.groupBox_Proyectos.Name = "groupBox_Proyectos";
            this.groupBox_Proyectos.Size = new System.Drawing.Size(776, 125);
            this.groupBox_Proyectos.TabIndex = 1;
            this.groupBox_Proyectos.TabStop = false;
            this.groupBox_Proyectos.Text = "Proyectos";
            // 
            // listBox_Proyectos
            // 
            this.listBox_Proyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Proyectos.FormattingEnabled = true;
            this.listBox_Proyectos.Location = new System.Drawing.Point(6, 32);
            this.listBox_Proyectos.Name = "listBox_Proyectos";
            this.listBox_Proyectos.Size = new System.Drawing.Size(764, 82);
            this.listBox_Proyectos.TabIndex = 0;
            this.listBox_Proyectos.SelectedIndexChanged += new System.EventHandler(this.listBox_Proyectos_SelectedIndexChanged);
            // 
            // button_Recargar
            // 
            this.button_Recargar.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_Recargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Recargar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Recargar.Location = new System.Drawing.Point(18, 290);
            this.button_Recargar.Name = "button_Recargar";
            this.button_Recargar.Size = new System.Drawing.Size(142, 40);
            this.button_Recargar.TabIndex = 2;
            this.button_Recargar.Text = "Recargar";
            this.button_Recargar.UseVisualStyleBackColor = false;
            this.button_Recargar.Click += new System.EventHandler(this.button_Recargar_Click);
            // 
            // button_EliminarProyecto
            // 
            this.button_EliminarProyecto.BackColor = System.Drawing.Color.DodgerBlue;
            this.button_EliminarProyecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_EliminarProyecto.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_EliminarProyecto.Location = new System.Drawing.Point(353, 290);
            this.button_EliminarProyecto.Name = "button_EliminarProyecto";
            this.button_EliminarProyecto.Size = new System.Drawing.Size(139, 40);
            this.button_EliminarProyecto.TabIndex = 3;
            this.button_EliminarProyecto.Text = "Eliminar proyecto";
            this.button_EliminarProyecto.UseVisualStyleBackColor = false;
            this.button_EliminarProyecto.Click += new System.EventHandler(this.button_EliminarProyecto_Click);
            // 
            // button_MenuPrincipal
            // 
            this.button_MenuPrincipal.BackColor = System.Drawing.Color.Firebrick;
            this.button_MenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_MenuPrincipal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_MenuPrincipal.Location = new System.Drawing.Point(579, 290);
            this.button_MenuPrincipal.Name = "button_MenuPrincipal";
            this.button_MenuPrincipal.Size = new System.Drawing.Size(203, 40);
            this.button_MenuPrincipal.TabIndex = 4;
            this.button_MenuPrincipal.Text = "Menu principal";
            this.button_MenuPrincipal.UseVisualStyleBackColor = false;
            this.button_MenuPrincipal.Click += new System.EventHandler(this.button_MenuPrincipal_Click);
            // 
            // listBox_Tareas
            // 
            this.listBox_Tareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Tareas.FormattingEnabled = true;
            this.listBox_Tareas.Location = new System.Drawing.Point(15, 31);
            this.listBox_Tareas.Name = "listBox_Tareas";
            this.listBox_Tareas.Size = new System.Drawing.Size(755, 82);
            this.listBox_Tareas.TabIndex = 5;
            this.listBox_Tareas.SelectedIndexChanged += new System.EventHandler(this.listBox_Tareas_SelectedIndexChanged);
            // 
            // groupBox_Tareas
            // 
            this.groupBox_Tareas.Controls.Add(this.listBox_Tareas);
            this.groupBox_Tareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Tareas.Location = new System.Drawing.Point(12, 159);
            this.groupBox_Tareas.Name = "groupBox_Tareas";
            this.groupBox_Tareas.Size = new System.Drawing.Size(776, 125);
            this.groupBox_Tareas.TabIndex = 6;
            this.groupBox_Tareas.TabStop = false;
            this.groupBox_Tareas.Text = "Tareas asignadas";
            // 
            // button_EditarProyecto
            // 
            this.button_EditarProyecto.Location = new System.Drawing.Point(166, 291);
            this.button_EditarProyecto.Name = "button_EditarProyecto";
            this.button_EditarProyecto.Size = new System.Drawing.Size(181, 39);
            this.button_EditarProyecto.TabIndex = 7;
            this.button_EditarProyecto.Text = "Editar proyecto";
            this.button_EditarProyecto.UseVisualStyleBackColor = true;
            this.button_EditarProyecto.Click += new System.EventHandler(this.button_EditarProyecto_Click);
            // 
            // VerProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_EditarProyecto);
            this.Controls.Add(this.groupBox_Tareas);
            this.Controls.Add(this.button_MenuPrincipal);
            this.Controls.Add(this.button_EliminarProyecto);
            this.Controls.Add(this.button_Recargar);
            this.Controls.Add(this.groupBox_Proyectos);
            this.Name = "VerProyectos";
            this.Text = " ";
            this.Load += new System.EventHandler(this.VerProyectos_Load);
            this.groupBox_Proyectos.ResumeLayout(false);
            this.groupBox_Tareas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_Proyectos;
        private System.Windows.Forms.ListBox listBox_Proyectos;
        private System.Windows.Forms.Button button_Recargar;
        private System.Windows.Forms.Button button_EliminarProyecto;
        private System.Windows.Forms.Button button_MenuPrincipal;
        private System.Windows.Forms.ListBox listBox_Tareas;
        private System.Windows.Forms.GroupBox groupBox_Tareas;
        private System.Windows.Forms.Button button_EditarProyecto;
    }
}