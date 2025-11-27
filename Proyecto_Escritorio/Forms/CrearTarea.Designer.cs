namespace Proyecto_Escritorio
{
    partial class CrearTarea
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
            this.labelNombreTarea = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.textBox_Descripcion = new System.Windows.Forms.TextBox();
            this.labelDescripcion = new System.Windows.Forms.Label();
            this.checkedListBox_Compartir = new System.Windows.Forms.CheckedListBox();
            this.labelEncargados = new System.Windows.Forms.Label();
            this.groupBox_CrearTarea = new System.Windows.Forms.GroupBox();
            this.groupBox_Detalles = new System.Windows.Forms.GroupBox();
            this.checkedListBox_Estado = new System.Windows.Forms.CheckedListBox();
            this.labelEstado = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.labelHorasEstimadas = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFinalización = new System.Windows.Forms.DateTimePicker();
            this.labelFechaFinalizacion = new System.Windows.Forms.Label();
            this.labelFechaInicio = new System.Windows.Forms.Label();
            this.dateTimePickerFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.checkedListBoxPrioridad = new System.Windows.Forms.CheckedListBox();
            this.labelPrioridad = new System.Windows.Forms.Label();
            this.buttonAñadirTarea = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.groupBox_CrearTarea.SuspendLayout();
            this.groupBox_Detalles.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNombreTarea
            // 
            this.labelNombreTarea.AutoSize = true;
            this.labelNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreTarea.Location = new System.Drawing.Point(18, 29);
            this.labelNombreTarea.Name = "labelNombreTarea";
            this.labelNombreTarea.Size = new System.Drawing.Size(44, 13);
            this.labelNombreTarea.TabIndex = 0;
            this.labelNombreTarea.Text = "Nombre";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(93, 32);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Tarea";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Nombre.Location = new System.Drawing.Point(21, 45);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(217, 20);
            this.textBox_Nombre.TabIndex = 2;
            this.textBox_Nombre.TextChanged += new System.EventHandler(this.textBox_Nombre_TextChanged);
            // 
            // textBox_Descripcion
            // 
            this.textBox_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Descripcion.Location = new System.Drawing.Point(21, 103);
            this.textBox_Descripcion.Name = "textBox_Descripcion";
            this.textBox_Descripcion.Size = new System.Drawing.Size(217, 20);
            this.textBox_Descripcion.TabIndex = 3;
            this.textBox_Descripcion.TextChanged += new System.EventHandler(this.textBox_Descripcion_TextChanged);
            // 
            // labelDescripcion
            // 
            this.labelDescripcion.AutoSize = true;
            this.labelDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescripcion.Location = new System.Drawing.Point(18, 87);
            this.labelDescripcion.Name = "labelDescripcion";
            this.labelDescripcion.Size = new System.Drawing.Size(63, 13);
            this.labelDescripcion.TabIndex = 4;
            this.labelDescripcion.Text = "Descripción";
            // 
            // checkedListBox_Compartir
            // 
            this.checkedListBox_Compartir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Compartir.FormattingEnabled = true;
            this.checkedListBox_Compartir.Location = new System.Drawing.Point(21, 158);
            this.checkedListBox_Compartir.Name = "checkedListBox_Compartir";
            this.checkedListBox_Compartir.Size = new System.Drawing.Size(217, 94);
            this.checkedListBox_Compartir.TabIndex = 5;
            this.checkedListBox_Compartir.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Compartir_SelectedIndexChanged);
            // 
            // labelEncargados
            // 
            this.labelEncargados.AutoSize = true;
            this.labelEncargados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEncargados.Location = new System.Drawing.Point(18, 142);
            this.labelEncargados.Name = "labelEncargados";
            this.labelEncargados.Size = new System.Drawing.Size(64, 13);
            this.labelEncargados.TabIndex = 6;
            this.labelEncargados.Text = "Encargados";
            // 
            // groupBox_CrearTarea
            // 
            this.groupBox_CrearTarea.Controls.Add(this.labelNombreTarea);
            this.groupBox_CrearTarea.Controls.Add(this.checkedListBox_Compartir);
            this.groupBox_CrearTarea.Controls.Add(this.labelEncargados);
            this.groupBox_CrearTarea.Controls.Add(this.textBox_Nombre);
            this.groupBox_CrearTarea.Controls.Add(this.labelDescripcion);
            this.groupBox_CrearTarea.Controls.Add(this.textBox_Descripcion);
            this.groupBox_CrearTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_CrearTarea.Location = new System.Drawing.Point(18, 59);
            this.groupBox_CrearTarea.Name = "groupBox_CrearTarea";
            this.groupBox_CrearTarea.Size = new System.Drawing.Size(254, 268);
            this.groupBox_CrearTarea.TabIndex = 7;
            this.groupBox_CrearTarea.TabStop = false;
            this.groupBox_CrearTarea.Text = "Principal";
            // 
            // groupBox_Detalles
            // 
            this.groupBox_Detalles.Controls.Add(this.checkedListBox_Estado);
            this.groupBox_Detalles.Controls.Add(this.labelEstado);
            this.groupBox_Detalles.Controls.Add(this.dateTimePicker1);
            this.groupBox_Detalles.Controls.Add(this.labelHorasEstimadas);
            this.groupBox_Detalles.Controls.Add(this.dateTimePickerFechaFinalización);
            this.groupBox_Detalles.Controls.Add(this.labelFechaFinalizacion);
            this.groupBox_Detalles.Controls.Add(this.labelFechaInicio);
            this.groupBox_Detalles.Controls.Add(this.dateTimePickerFechaInicio);
            this.groupBox_Detalles.Controls.Add(this.checkedListBoxPrioridad);
            this.groupBox_Detalles.Controls.Add(this.labelPrioridad);
            this.groupBox_Detalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Detalles.Location = new System.Drawing.Point(299, 59);
            this.groupBox_Detalles.Name = "groupBox_Detalles";
            this.groupBox_Detalles.Size = new System.Drawing.Size(489, 268);
            this.groupBox_Detalles.TabIndex = 8;
            this.groupBox_Detalles.TabStop = false;
            this.groupBox_Detalles.Text = "Detalles";
            this.groupBox_Detalles.Enter += new System.EventHandler(this.groupBox_Detalles_Enter);
            // 
            // checkedListBox_Estado
            // 
            this.checkedListBox_Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_Estado.FormattingEnabled = true;
            this.checkedListBox_Estado.Items.AddRange(new object[] {
            "Completado",
            "En progreso",
            "Testeando",
            "Bloqueado",
            "Reabierto",
            "En revision",
            "Por hacer"});
            this.checkedListBox_Estado.Location = new System.Drawing.Point(22, 135);
            this.checkedListBox_Estado.Name = "checkedListBox_Estado";
            this.checkedListBox_Estado.Size = new System.Drawing.Size(200, 124);
            this.checkedListBox_Estado.TabIndex = 10;
            this.checkedListBox_Estado.SelectedIndexChanged += new System.EventHandler(this.checkedListBox_Estado_SelectedIndexChanged);
            // 
            // labelEstado
            // 
            this.labelEstado.AutoSize = true;
            this.labelEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstado.Location = new System.Drawing.Point(19, 119);
            this.labelEstado.Name = "labelEstado";
            this.labelEstado.Size = new System.Drawing.Size(40, 13);
            this.labelEstado.TabIndex = 9;
            this.labelEstado.Text = "Estado";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(261, 162);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 8;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // labelHorasEstimadas
            // 
            this.labelHorasEstimadas.AutoSize = true;
            this.labelHorasEstimadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHorasEstimadas.Location = new System.Drawing.Point(258, 146);
            this.labelHorasEstimadas.Name = "labelHorasEstimadas";
            this.labelHorasEstimadas.Size = new System.Drawing.Size(85, 13);
            this.labelHorasEstimadas.TabIndex = 7;
            this.labelHorasEstimadas.Text = "Horas estimadas";
            // 
            // dateTimePickerFechaFinalización
            // 
            this.dateTimePickerFechaFinalización.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaFinalización.Location = new System.Drawing.Point(261, 109);
            this.dateTimePickerFechaFinalización.Name = "dateTimePickerFechaFinalización";
            this.dateTimePickerFechaFinalización.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaFinalización.TabIndex = 5;
            this.dateTimePickerFechaFinalización.ValueChanged += new System.EventHandler(this.dateTimePickerFechaFinalización_ValueChanged);
            // 
            // labelFechaFinalizacion
            // 
            this.labelFechaFinalizacion.AutoSize = true;
            this.labelFechaFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaFinalizacion.Location = new System.Drawing.Point(258, 91);
            this.labelFechaFinalizacion.Name = "labelFechaFinalizacion";
            this.labelFechaFinalizacion.Size = new System.Drawing.Size(92, 13);
            this.labelFechaFinalizacion.TabIndex = 4;
            this.labelFechaFinalizacion.Text = "Fecha finalización";
            // 
            // labelFechaInicio
            // 
            this.labelFechaInicio.AutoSize = true;
            this.labelFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFechaInicio.Location = new System.Drawing.Point(258, 36);
            this.labelFechaInicio.Name = "labelFechaInicio";
            this.labelFechaInicio.Size = new System.Drawing.Size(64, 13);
            this.labelFechaInicio.TabIndex = 3;
            this.labelFechaInicio.Text = "Fecha inicio";
            // 
            // dateTimePickerFechaInicio
            // 
            this.dateTimePickerFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerFechaInicio.Location = new System.Drawing.Point(261, 54);
            this.dateTimePickerFechaInicio.Name = "dateTimePickerFechaInicio";
            this.dateTimePickerFechaInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFechaInicio.TabIndex = 2;
            this.dateTimePickerFechaInicio.ValueChanged += new System.EventHandler(this.dateTimePickerFechaInicio_ValueChanged);
            // 
            // checkedListBoxPrioridad
            // 
            this.checkedListBoxPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBoxPrioridad.FormattingEnabled = true;
            this.checkedListBoxPrioridad.Items.AddRange(new object[] {
            "Muy alta",
            "Alta",
            "Media",
            "Baja"});
            this.checkedListBoxPrioridad.Location = new System.Drawing.Point(22, 45);
            this.checkedListBoxPrioridad.MultiColumn = true;
            this.checkedListBoxPrioridad.Name = "checkedListBoxPrioridad";
            this.checkedListBoxPrioridad.Size = new System.Drawing.Size(200, 64);
            this.checkedListBoxPrioridad.TabIndex = 1;
            this.checkedListBoxPrioridad.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPrioridad_SelectedIndexChanged);
            // 
            // labelPrioridad
            // 
            this.labelPrioridad.AutoSize = true;
            this.labelPrioridad.Location = new System.Drawing.Point(19, 29);
            this.labelPrioridad.Name = "labelPrioridad";
            this.labelPrioridad.Size = new System.Drawing.Size(48, 13);
            this.labelPrioridad.TabIndex = 0;
            this.labelPrioridad.Text = "Prioridad";
            // 
            // buttonAñadirTarea
            // 
            this.buttonAñadirTarea.Location = new System.Drawing.Point(29, 348);
            this.buttonAñadirTarea.Name = "buttonAñadirTarea";
            this.buttonAñadirTarea.Size = new System.Drawing.Size(164, 51);
            this.buttonAñadirTarea.TabIndex = 9;
            this.buttonAñadirTarea.Text = "Añadir";
            this.buttonAñadirTarea.UseVisualStyleBackColor = true;
            this.buttonAñadirTarea.Click += new System.EventHandler(this.buttonAñadirTarea_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(212, 348);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(165, 51);
            this.buttonCancelar.TabIndex = 10;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // CrearTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAñadirTarea);
            this.Controls.Add(this.groupBox_Detalles);
            this.Controls.Add(this.groupBox_CrearTarea);
            this.Controls.Add(this.labelTitulo);
            this.Name = "CrearTarea";
            this.Text = "CrearTarea";
            this.Load += new System.EventHandler(this.CrearTarea_Load);
            this.groupBox_CrearTarea.ResumeLayout(false);
            this.groupBox_CrearTarea.PerformLayout();
            this.groupBox_Detalles.ResumeLayout(false);
            this.groupBox_Detalles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNombreTarea;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.TextBox textBox_Nombre;
        private System.Windows.Forms.TextBox textBox_Descripcion;
        private System.Windows.Forms.Label labelDescripcion;
        private System.Windows.Forms.CheckedListBox checkedListBox_Compartir;
        private System.Windows.Forms.Label labelEncargados;
        private System.Windows.Forms.GroupBox groupBox_CrearTarea;
        private System.Windows.Forms.GroupBox groupBox_Detalles;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrioridad;
        private System.Windows.Forms.Label labelPrioridad;
        private System.Windows.Forms.Label labelHorasEstimadas;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFinalización;
        private System.Windows.Forms.Label labelFechaFinalizacion;
        private System.Windows.Forms.Label labelFechaInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaInicio;
        private System.Windows.Forms.CheckedListBox checkedListBox_Estado;
        private System.Windows.Forms.Label labelEstado;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonAñadirTarea;
        private System.Windows.Forms.Button buttonCancelar;
    }
}