namespace Proyecto_Escritorio
{
    partial class EditarProyecto
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
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.dateTimePicker_FechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_FechaFin = new System.Windows.Forms.DateTimePicker();
            this.checkedListBox_Usuarios = new System.Windows.Forms.CheckedListBox();
            this.button_Guardar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.listBox_Tareas = new System.Windows.Forms.ListBox();
            this.checkedListBox_UsuariosTarea = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(64, 94);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nombre.TabIndex = 0;
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Location = new System.Drawing.Point(84, 211);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(100, 20);
            this.textBox_Descripcion.TabIndex = 1;
            // 
            // dateTimePicker_FechaInicio
            // 
            this.dateTimePicker_FechaInicio.Location = new System.Drawing.Point(247, 81);
            this.dateTimePicker_FechaInicio.Name = "dateTimePicker_FechaInicio";
            this.dateTimePicker_FechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaInicio.TabIndex = 2;
            // 
            // dateTimePicker_FechaFin
            // 
            this.dateTimePicker_FechaFin.Location = new System.Drawing.Point(260, 134);
            this.dateTimePicker_FechaFin.Name = "dateTimePicker_FechaFin";
            this.dateTimePicker_FechaFin.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_FechaFin.TabIndex = 3;
            // 
            // checkedListBox_Usuarios
            // 
            this.checkedListBox_Usuarios.FormattingEnabled = true;
            this.checkedListBox_Usuarios.Location = new System.Drawing.Point(304, 211);
            this.checkedListBox_Usuarios.Name = "checkedListBox_Usuarios";
            this.checkedListBox_Usuarios.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_Usuarios.TabIndex = 4;
            // 
            // button_Guardar
            // 
            this.button_Guardar.Location = new System.Drawing.Point(236, 373);
            this.button_Guardar.Name = "button_Guardar";
            this.button_Guardar.Size = new System.Drawing.Size(75, 23);
            this.button_Guardar.TabIndex = 5;
            this.button_Guardar.Text = "Guardar";
            this.button_Guardar.UseVisualStyleBackColor = true;
            this.button_Guardar.Click += new System.EventHandler(this.button_Guardar_Click_1);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(385, 373);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 6;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click_1);
            // 
            // listBox_Tareas
            // 
            this.listBox_Tareas.FormattingEnabled = true;
            this.listBox_Tareas.Location = new System.Drawing.Point(620, 81);
            this.listBox_Tareas.Name = "listBox_Tareas";
            this.listBox_Tareas.Size = new System.Drawing.Size(120, 95);
            this.listBox_Tareas.TabIndex = 7;
            this.listBox_Tareas.SelectedIndexChanged += new System.EventHandler(this.listBox_Tareas_SelectedIndexChanged_1);
            // 
            // checkedListBox_UsuariosTarea
            // 
            this.checkedListBox_UsuariosTarea.FormattingEnabled = true;
            this.checkedListBox_UsuariosTarea.Location = new System.Drawing.Point(633, 211);
            this.checkedListBox_UsuariosTarea.Name = "checkedListBox_UsuariosTarea";
            this.checkedListBox_UsuariosTarea.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox_UsuariosTarea.TabIndex = 8;
            this.checkedListBox_UsuariosTarea.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox_UsuariosTarea_ItemCheck_1);
            this.checkedListBox_UsuariosTarea.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_UsuariosTareas_SelectedIndexChanged_1);
            // 
            // EditarProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBox_UsuariosTarea);
            this.Controls.Add(this.listBox_Tareas);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Guardar);
            this.Controls.Add(this.checkedListBox_Usuarios);
            this.Controls.Add(this.dateTimePicker_FechaFin);
            this.Controls.Add(this.dateTimePicker_FechaInicio);
            this.Controls.Add(this.textBox_Descripcion);
            this.Controls.Add(this.textBox_Nombre);
            this.Name = "EditarProyecto";
            this.Text = "EditarProyecto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePicker_FechaFin;
        private System.Windows.Forms.CheckedListBox checkedListBox_Usuarios;
        private System.Windows.Forms.Button button_Guardar;
        private System.Windows.Forms.Button button_Cancelar;
        private System.Windows.Forms.ListBox listBox_Tareas;
        private System.Windows.Forms.CheckedListBox checkedListBox_UsuariosTarea;
    }
}