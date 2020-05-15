namespace Sistema.Ventas.Catalogos
{
    partial class Gastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gastos));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboGasto = new System.Windows.Forms.ComboBox();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboGasto2 = new System.Windows.Forms.ComboBox();
            this.btnCatalogo = new System.Windows.Forms.Button();
            this.FechaAbono = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ComboGasto);
            this.groupBox2.Controls.Add(this.fFinal);
            this.groupBox2.Controls.Add(this.fInicial);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(6, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(661, 83);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Gastos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(246, 42);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 38);
            this.btnBuscar.TabIndex = 51;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(201, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(39, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "Gasto:";
            // 
            // ComboGasto
            // 
            this.ComboGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGasto.FormattingEnabled = true;
            this.ComboGasto.Location = new System.Drawing.Point(246, 18);
            this.ComboGasto.Name = "ComboGasto";
            this.ComboGasto.Size = new System.Drawing.Size(268, 21);
            this.ComboGasto.TabIndex = 8;
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(84, 49);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 7;
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(84, 19);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Final :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Inicial :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(526, 342);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(572, 329);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(95, 27);
            this.txtTotal.TabIndex = 52;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.BackgroundColor = System.Drawing.Color.White;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(6, 91);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(661, 232);
            this.Datos.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(27, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 14);
            this.label8.TabIndex = 67;
            this.label8.Text = "Gasto $";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(3, 35);
            this.txtAbono.MaxLength = 10;
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(95, 27);
            this.txtAbono.TabIndex = 66;
            this.txtAbono.Text = "0";
            this.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAbonar
            // 
            this.btnAbonar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbonar.Image")));
            this.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonar.Location = new System.Drawing.Point(585, 27);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(78, 35);
            this.btnAbonar.TabIndex = 68;
            this.btnAbonar.Text = "Agregar";
            this.btnAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(172, 42);
            this.txtComentario.MaxLength = 240;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(407, 20);
            this.txtComentario.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(99, 48);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 14);
            this.label9.TabIndex = 70;
            this.label9.Text = "Comentario :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.FechaAbono);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ComboGasto2);
            this.groupBox1.Controls.Add(this.txtComentario);
            this.groupBox1.Controls.Add(this.txtAbono);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnAbonar);
            this.groupBox1.Location = new System.Drawing.Point(3, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(664, 73);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Insertar Gasto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(124, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 14);
            this.label4.TabIndex = 72;
            this.label4.Text = "Gasto :";
            // 
            // ComboGasto2
            // 
            this.ComboGasto2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboGasto2.FormattingEnabled = true;
            this.ComboGasto2.Location = new System.Drawing.Point(172, 15);
            this.ComboGasto2.Name = "ComboGasto2";
            this.ComboGasto2.Size = new System.Drawing.Size(262, 21);
            this.ComboGasto2.TabIndex = 71;
            // 
            // btnCatalogo
            // 
            this.btnCatalogo.Image = ((System.Drawing.Image)(resources.GetObject("btnCatalogo.Image")));
            this.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCatalogo.Location = new System.Drawing.Point(3, 435);
            this.btnCatalogo.Name = "btnCatalogo";
            this.btnCatalogo.Size = new System.Drawing.Size(124, 28);
            this.btnCatalogo.TabIndex = 52;
            this.btnCatalogo.Text = "Catalogo de Gastos";
            this.btnCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCatalogo.UseVisualStyleBackColor = true;
            this.btnCatalogo.Click += new System.EventHandler(this.btnCatalogo_Click);
            // 
            // FechaAbono
            // 
            this.FechaAbono.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FechaAbono.Location = new System.Drawing.Point(476, 15);
            this.FechaAbono.Name = "FechaAbono";
            this.FechaAbono.Size = new System.Drawing.Size(103, 20);
            this.FechaAbono.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(435, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "Fecha :";
            // 
            // Gastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(673, 465);
            this.Controls.Add(this.btnCatalogo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "Gastos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gastos";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboGasto;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCatalogo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboGasto2;
        private System.Windows.Forms.DateTimePicker FechaAbono;
        private System.Windows.Forms.Label label5;
    }
}