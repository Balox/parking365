namespace Sistema.Ventas.Catalogos
{
    partial class CatCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatCitas));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnConcretar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dHora = new System.Windows.Forms.DateTimePicker();
            this.FFecha = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboProveedor = new System.Windows.Forms.ComboBox();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.HoraFin = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.HoraInicio = new System.Windows.Forms.DateTimePicker();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(935, 442);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GridDatos);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(927, 416);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Generación Citas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GridDatos
            // 
            this.GridDatos.AllowUserToAddRows = false;
            this.GridDatos.AllowUserToDeleteRows = false;
            this.GridDatos.BackgroundColor = System.Drawing.Color.White;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(7, 6);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.ReadOnly = true;
            this.GridDatos.Size = new System.Drawing.Size(562, 404);
            this.GridDatos.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnConcretar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dHora);
            this.groupBox1.Controls.Add(this.FFecha);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ComboProveedor);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(573, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(351, 408);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalles";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(175, 318);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(136, 36);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar Cita";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnConcretar
            // 
            this.btnConcretar.Image = ((System.Drawing.Image)(resources.GetObject("btnConcretar.Image")));
            this.btnConcretar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConcretar.Location = new System.Drawing.Point(57, 374);
            this.btnConcretar.Name = "btnConcretar";
            this.btnConcretar.Size = new System.Drawing.Size(124, 23);
            this.btnConcretar.TabIndex = 17;
            this.btnConcretar.Text = "Concretar Cita";
            this.btnConcretar.UseVisualStyleBackColor = true;
            this.btnConcretar.Click += new System.EventHandler(this.btnConcretar_Click_1);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(187, 374);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(124, 23);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar Cita";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 339);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 14);
            this.label4.TabIndex = 15;
            this.label4.Text = "Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 14);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha:";
            // 
            // dHora
            // 
            this.dHora.CustomFormat = "hh:mm tt";
            this.dHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dHora.Location = new System.Drawing.Point(57, 333);
            this.dHora.Name = "dHora";
            this.dHora.ShowUpDown = true;
            this.dHora.Size = new System.Drawing.Size(110, 20);
            this.dHora.TabIndex = 13;
            // 
            // FFecha
            // 
            this.FFecha.Location = new System.Drawing.Point(63, 144);
            this.FFecha.Name = "FFecha";
            this.FFecha.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 14);
            this.label2.TabIndex = 10;
            this.label2.Text = "Proveedor:";
            // 
            // ComboProveedor
            // 
            this.ComboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboProveedor.FormattingEnabled = true;
            this.ComboProveedor.Location = new System.Drawing.Point(63, 19);
            this.ComboProveedor.Name = "ComboProveedor";
            this.ComboProveedor.Size = new System.Drawing.Size(248, 21);
            this.ComboProveedor.TabIndex = 9;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(63, 46);
            this.txtObservaciones.MaxLength = 250;
            this.txtObservaciones.Multiline = true;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(248, 95);
            this.txtObservaciones.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 14);
            this.label1.TabIndex = 7;
            this.label1.Text = "Observ:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportar);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.HoraFin);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.HoraInicio);
            this.tabPage2.Controls.Add(this.Datos);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.fFinal);
            this.tabPage2.Controls.Add(this.fInicial);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(927, 416);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Calendario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(521, 6);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(99, 45);
            this.btnExportar.TabIndex = 20;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(225, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Hora Fin:";
            // 
            // HoraFin
            // 
            this.HoraFin.CustomFormat = "hh:mm tt";
            this.HoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraFin.Location = new System.Drawing.Point(281, 31);
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ShowUpDown = true;
            this.HoraFin.Size = new System.Drawing.Size(124, 20);
            this.HoraFin.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(215, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 14);
            this.label7.TabIndex = 17;
            this.label7.Text = "Hora Inicio:";
            // 
            // HoraInicio
            // 
            this.HoraInicio.CustomFormat = "hh:mm tt";
            this.HoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.HoraInicio.Location = new System.Drawing.Point(281, 6);
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ShowUpDown = true;
            this.HoraInicio.Size = new System.Drawing.Size(124, 20);
            this.HoraInicio.TabIndex = 16;
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.BackgroundColor = System.Drawing.Color.White;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(10, 62);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(797, 348);
            this.Datos.TabIndex = 11;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(430, 6);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 45);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(86, 36);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 7;
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(86, 6);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Final :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Fecha Inicial :";
            // 
            // CatCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(938, 449);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "CatCitas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas Proveedores";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnConcretar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dHora;
        private System.Windows.Forms.MonthCalendar FFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboProveedor;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker HoraFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker HoraInicio;
        private System.Windows.Forms.Button btnExportar;

    }
}