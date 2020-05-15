namespace Sistema.Ventas.Catalogos
{
    partial class PorCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorCobrar));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckPagado = new System.Windows.Forms.CheckBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Datos = new System.Windows.Forms.DataGridView();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtArticulosVendidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GridAbonos = new System.Windows.Forms.DataGridView();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPorCobrar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txticve = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.btnPendiente = new System.Windows.Forms.Button();
            this.btnEntregado = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbonos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEntregado);
            this.groupBox2.Controls.Add(this.btnPendiente);
            this.groupBox2.Controls.Add(this.CheckPagado);
            this.groupBox2.Controls.Add(this.txtFolio);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.fFinal);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.fInicial);
            this.groupBox2.Controls.Add(this.ComboCliente);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(0, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 78);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            // 
            // CheckPagado
            // 
            this.CheckPagado.AutoSize = true;
            this.CheckPagado.Location = new System.Drawing.Point(351, 53);
            this.CheckPagado.Name = "CheckPagado";
            this.CheckPagado.Size = new System.Drawing.Size(63, 17);
            this.CheckPagado.TabIndex = 58;
            this.CheckPagado.Text = "Pagado";
            this.CheckPagado.UseVisualStyleBackColor = true;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(267, 49);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 57;
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(230, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 56;
            this.label4.Text = "Folio:";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(466, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 33);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(85, 48);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 54;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(220, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "Cliente:";
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(85, 18);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 53;
            // 
            // ComboCliente
            // 
            this.ComboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(267, 13);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(284, 24);
            this.ComboCliente.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 52;
            this.label2.Text = "Final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Fecha Inicial :";
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.BackgroundColor = System.Drawing.Color.White;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(0, 84);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(756, 323);
            this.Datos.TabIndex = 56;
            this.Datos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Datos_CellDoubleClick);
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtUtilidad.Location = new System.Drawing.Point(607, 451);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.ReadOnly = true;
            this.txtUtilidad.Size = new System.Drawing.Size(127, 30);
            this.txtUtilidad.TabIndex = 66;
            this.txtUtilidad.Text = "0.00";
            this.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(608, 423);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 65;
            this.label10.Text = "Utilidad $";
            // 
            // txtArticulosVendidos
            // 
            this.txtArticulosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulosVendidos.Location = new System.Drawing.Point(7, 454);
            this.txtArticulosVendidos.Name = "txtArticulosVendidos";
            this.txtArticulosVendidos.ReadOnly = true;
            this.txtArticulosVendidos.Size = new System.Drawing.Size(127, 27);
            this.txtArticulosVendidos.TabIndex = 64;
            this.txtArticulosVendidos.Text = "0";
            this.txtArticulosVendidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(3, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 63;
            this.label9.Text = "Art. Vendidos";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(451, 451);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 30);
            this.txtTotal.TabIndex = 62;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoTotal.Location = new System.Drawing.Point(313, 454);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.ReadOnly = true;
            this.txtDescuentoTotal.Size = new System.Drawing.Size(127, 27);
            this.txtDescuentoTotal.TabIndex = 61;
            this.txtDescuentoTotal.Text = "0.00";
            this.txtDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(170, 454);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(127, 27);
            this.txtSubtotal.TabIndex = 60;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(452, 423);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 59;
            this.label6.Text = "Total $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(309, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 58;
            this.label7.Text = "Descuento $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(166, 423);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 57;
            this.label8.Text = "SubTotal $";
            // 
            // GridAbonos
            // 
            this.GridAbonos.AllowUserToAddRows = false;
            this.GridAbonos.AllowUserToDeleteRows = false;
            this.GridAbonos.BackgroundColor = System.Drawing.Color.White;
            this.GridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAbonos.Location = new System.Drawing.Point(768, 84);
            this.GridAbonos.Name = "GridAbonos";
            this.GridAbonos.ReadOnly = true;
            this.GridAbonos.Size = new System.Drawing.Size(576, 323);
            this.GridAbonos.TabIndex = 67;
            // 
            // txtAbonos
            // 
            this.txtAbonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonos.ForeColor = System.Drawing.Color.Maroon;
            this.txtAbonos.Location = new System.Drawing.Point(776, 450);
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.ReadOnly = true;
            this.txtAbonos.Size = new System.Drawing.Size(127, 30);
            this.txtAbonos.TabIndex = 69;
            this.txtAbonos.Text = "0.00";
            this.txtAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(777, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 21);
            this.label3.TabIndex = 68;
            this.label3.Text = "Total Abonos$";
            // 
            // txtPorCobrar
            // 
            this.txtPorCobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPorCobrar.ForeColor = System.Drawing.Color.Maroon;
            this.txtPorCobrar.Location = new System.Drawing.Point(1217, 451);
            this.txtPorCobrar.Name = "txtPorCobrar";
            this.txtPorCobrar.ReadOnly = true;
            this.txtPorCobrar.Size = new System.Drawing.Size(127, 30);
            this.txtPorCobrar.TabIndex = 71;
            this.txtPorCobrar.Text = "0.00";
            this.txtPorCobrar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(1230, 419);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 70;
            this.label5.Text = "Por Cobrar$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(765, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 14);
            this.label11.TabIndex = 83;
            this.label11.Text = "No Venta :";
            // 
            // txticve
            // 
            this.txticve.Enabled = false;
            this.txticve.Location = new System.Drawing.Point(837, 2);
            this.txticve.MaxLength = 240;
            this.txticve.Name = "txticve";
            this.txticve.Size = new System.Drawing.Size(50, 20);
            this.txticve.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(894, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 14);
            this.label12.TabIndex = 81;
            this.label12.Text = "Producto :";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(956, 2);
            this.txtProducto.MaxLength = 240;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(388, 20);
            this.txtProducto.TabIndex = 80;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(883, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 14);
            this.label13.TabIndex = 79;
            this.label13.Text = "Comentario del abono";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(886, 61);
            this.txtComentario.MaxLength = 240;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(458, 20);
            this.txtComentario.TabIndex = 78;
            // 
            // btnAbonar
            // 
            this.btnAbonar.Image = ((System.Drawing.Image)(resources.GetObject("btnAbonar.Image")));
            this.btnAbonar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbonar.Location = new System.Drawing.Point(1266, 25);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(78, 35);
            this.btnAbonar.TabIndex = 77;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(792, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 14);
            this.label15.TabIndex = 76;
            this.label15.Text = "Abonar";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(768, 54);
            this.txtAbono.MaxLength = 10;
            this.txtAbono.Name = "txtAbono";
            this.txtAbono.Size = new System.Drawing.Size(95, 27);
            this.txtAbono.TabIndex = 75;
            this.txtAbono.Text = "0";
            this.txtAbono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPendiente
            // 
            this.btnPendiente.BackColor = System.Drawing.Color.Red;
            this.btnPendiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPendiente.ForeColor = System.Drawing.Color.White;
            this.btnPendiente.Location = new System.Drawing.Point(596, 45);
            this.btnPendiente.Name = "btnPendiente";
            this.btnPendiente.Size = new System.Drawing.Size(74, 23);
            this.btnPendiente.TabIndex = 59;
            this.btnPendiente.Text = "Pendiente";
            this.btnPendiente.UseVisualStyleBackColor = false;
            this.btnPendiente.Click += new System.EventHandler(this.btnPendiente_Click);
            // 
            // btnEntregado
            // 
            this.btnEntregado.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEntregado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntregado.ForeColor = System.Drawing.Color.Black;
            this.btnEntregado.Location = new System.Drawing.Point(676, 45);
            this.btnEntregado.Name = "btnEntregado";
            this.btnEntregado.Size = new System.Drawing.Size(74, 23);
            this.btnEntregado.TabIndex = 60;
            this.btnEntregado.Text = "Entregado";
            this.btnEntregado.UseVisualStyleBackColor = false;
            this.btnEntregado.Click += new System.EventHandler(this.btnEntregado_Click);
            // 
            // PorCobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 510);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txticve);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.txtPorCobrar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAbonos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GridAbonos);
            this.Controls.Add(this.txtUtilidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtArticulosVendidos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuentoTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Datos);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.Name = "PorCobrar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por Cobrar";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtArticulosVendidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox CheckPagado;
        private System.Windows.Forms.DataGridView GridAbonos;
        private System.Windows.Forms.TextBox txtAbonos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPorCobrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txticve;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Button btnEntregado;
        private System.Windows.Forms.Button btnPendiente;
    }
}