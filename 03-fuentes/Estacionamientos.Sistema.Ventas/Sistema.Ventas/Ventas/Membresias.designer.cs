namespace Sistema.Ventas
{
    partial class Membresias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Membresias));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnAnexar = new System.Windows.Forms.Button();
            this.txtFolioPago = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtServicios = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GridServicios = new System.Windows.Forms.DataGridView();
            this.iCveProductos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductoBusqueda = new System.Windows.Forms.TextBox();
            this.GridDatosBusqueda = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboNiveles = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.ComboClientesBusqueda = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.GridMembresiasBusqueda = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGuardaServicios = new System.Windows.Forms.Button();
            this.fMovimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.GridServiciosBusqueda = new System.Windows.Forms.DataGridView();
            this.Utilizado = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaUtilizado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridMembresiasBusqueda)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridServiciosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(947, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtTotal);
            this.tabPage1.Controls.Add(this.btnQuitar);
            this.tabPage1.Controls.Add(this.btnAnexar);
            this.tabPage1.Controls.Add(this.txtFolioPago);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.fInicial);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnAgregar);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.ComboNiveles);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ComboCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(939, 437);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Agregar Membresias";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 69;
            this.label6.Text = "Pago Total :";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(81, 110);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(103, 20);
            this.txtTotal.TabIndex = 68;
            // 
            // btnQuitar
            // 
            this.btnQuitar.Location = new System.Drawing.Point(442, 289);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(61, 23);
            this.btnQuitar.TabIndex = 67;
            this.btnQuitar.Text = "< < < <";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnAnexar
            // 
            this.btnAnexar.Location = new System.Drawing.Point(442, 260);
            this.btnAnexar.Name = "btnAnexar";
            this.btnAnexar.Size = new System.Drawing.Size(61, 23);
            this.btnAnexar.TabIndex = 66;
            this.btnAnexar.Text = "> > > >";
            this.btnAnexar.UseVisualStyleBackColor = true;
            this.btnAnexar.Click += new System.EventHandler(this.btnAnexar_Click);
            // 
            // txtFolioPago
            // 
            this.txtFolioPago.Location = new System.Drawing.Point(81, 87);
            this.txtFolioPago.Name = "txtFolioPago";
            this.txtFolioPago.Size = new System.Drawing.Size(103, 20);
            this.txtFolioPago.TabIndex = 65;
            this.txtFolioPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioPago_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Folio Pago :";
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(81, 64);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Fecha Inicial :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtServicios);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.GridServicios);
            this.groupBox2.Location = new System.Drawing.Point(509, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(420, 272);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mis Servicios";
            // 
            // txtServicios
            // 
            this.txtServicios.Enabled = false;
            this.txtServicios.Location = new System.Drawing.Point(119, 13);
            this.txtServicios.Name = "txtServicios";
            this.txtServicios.Size = new System.Drawing.Size(71, 20);
            this.txtServicios.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 14);
            this.label5.TabIndex = 68;
            this.label5.Text = "Servicios permitidos:";
            // 
            // GridServicios
            // 
            this.GridServicios.AllowUserToAddRows = false;
            this.GridServicios.AllowUserToDeleteRows = false;
            this.GridServicios.BackgroundColor = System.Drawing.Color.White;
            this.GridServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iCveProductos,
            this.Servicio});
            this.GridServicios.Location = new System.Drawing.Point(6, 44);
            this.GridServicios.Name = "GridServicios";
            this.GridServicios.ReadOnly = true;
            this.GridServicios.Size = new System.Drawing.Size(407, 222);
            this.GridServicios.TabIndex = 34;
            // 
            // iCveProductos
            // 
            this.iCveProductos.HeaderText = "iCveProductos";
            this.iCveProductos.Name = "iCveProductos";
            this.iCveProductos.ReadOnly = true;
            this.iCveProductos.Visible = false;
            this.iCveProductos.Width = 50;
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            this.Servicio.ReadOnly = true;
            this.Servicio.Width = 300;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtProductoBusqueda);
            this.groupBox1.Controls.Add(this.GridDatosBusqueda);
            this.groupBox1.Location = new System.Drawing.Point(11, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 272);
            this.groupBox1.TabIndex = 60;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Servicios";
            // 
            // txtProductoBusqueda
            // 
            this.txtProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoBusqueda.Location = new System.Drawing.Point(6, 14);
            this.txtProductoBusqueda.Name = "txtProductoBusqueda";
            this.txtProductoBusqueda.Size = new System.Drawing.Size(407, 23);
            this.txtProductoBusqueda.TabIndex = 34;
            this.txtProductoBusqueda.TextChanged += new System.EventHandler(this.txtProductoBusqueda_TextChanged_1);
            // 
            // GridDatosBusqueda
            // 
            this.GridDatosBusqueda.AllowUserToAddRows = false;
            this.GridDatosBusqueda.AllowUserToDeleteRows = false;
            this.GridDatosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.GridDatosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosBusqueda.Location = new System.Drawing.Point(6, 44);
            this.GridDatosBusqueda.Name = "GridDatosBusqueda";
            this.GridDatosBusqueda.ReadOnly = true;
            this.GridDatosBusqueda.Size = new System.Drawing.Size(407, 222);
            this.GridDatosBusqueda.TabIndex = 33;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(283, 92);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 37);
            this.btnAgregar.TabIndex = 59;
            this.btnAgregar.Text = "Guardar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 14);
            this.label2.TabIndex = 58;
            this.label2.Text = "Niveles:";
            // 
            // ComboNiveles
            // 
            this.ComboNiveles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboNiveles.FormattingEnabled = true;
            this.ComboNiveles.Location = new System.Drawing.Point(81, 35);
            this.ComboNiveles.Name = "ComboNiveles";
            this.ComboNiveles.Size = new System.Drawing.Size(108, 21);
            this.ComboNiveles.TabIndex = 57;
            this.ComboNiveles.SelectedIndexChanged += new System.EventHandler(this.ComboNiveles_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(36, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 56;
            this.label3.Text = "Cliente:";
            // 
            // ComboCliente
            // 
            this.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(81, 6);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(277, 21);
            this.ComboCliente.TabIndex = 55;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(939, 437);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Administrar Membresias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnImprimir);
            this.groupBox5.Controls.Add(this.fFinal);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.btnBuscar);
            this.groupBox5.Controls.Add(this.ComboClientesBusqueda);
            this.groupBox5.Controls.Add(this.dateTimePicker1);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(8, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(909, 78);
            this.groupBox5.TabIndex = 68;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Filtros";
            // 
            // btnImprimir
            // 
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(446, 18);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 45);
            this.btnImprimir.TabIndex = 71;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(236, 44);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 70;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(195, 52);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "Final :";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(355, 18);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 45);
            this.btnBuscar.TabIndex = 68;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ComboClientesBusqueda
            // 
            this.ComboClientesBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboClientesBusqueda.FormattingEnabled = true;
            this.ComboClientesBusqueda.Location = new System.Drawing.Point(62, 18);
            this.ComboClientesBusqueda.Name = "ComboClientesBusqueda";
            this.ComboClientesBusqueda.Size = new System.Drawing.Size(277, 21);
            this.ComboClientesBusqueda.TabIndex = 63;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(83, 45);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(103, 20);
            this.dateTimePicker1.TabIndex = 67;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 14);
            this.label8.TabIndex = 64;
            this.label8.Text = "Cliente:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 51);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 66;
            this.label10.Text = "Fecha Inicial :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.GridMembresiasBusqueda);
            this.groupBox4.Location = new System.Drawing.Point(8, 97);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(420, 333);
            this.groupBox4.TabIndex = 65;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Membresias";
            // 
            // GridMembresiasBusqueda
            // 
            this.GridMembresiasBusqueda.AllowUserToAddRows = false;
            this.GridMembresiasBusqueda.AllowUserToDeleteRows = false;
            this.GridMembresiasBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.GridMembresiasBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridMembresiasBusqueda.Location = new System.Drawing.Point(6, 44);
            this.GridMembresiasBusqueda.Name = "GridMembresiasBusqueda";
            this.GridMembresiasBusqueda.ReadOnly = true;
            this.GridMembresiasBusqueda.Size = new System.Drawing.Size(407, 283);
            this.GridMembresiasBusqueda.TabIndex = 34;
            this.GridMembresiasBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridMembresiasBusqueda_CellDoubleClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGuardaServicios);
            this.groupBox3.Controls.Add(this.fMovimiento);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.GridServiciosBusqueda);
            this.groupBox3.Location = new System.Drawing.Point(430, 97);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(487, 333);
            this.groupBox3.TabIndex = 62;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Mis Servicios";
            // 
            // btnGuardaServicios
            // 
            this.btnGuardaServicios.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardaServicios.Image")));
            this.btnGuardaServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardaServicios.Location = new System.Drawing.Point(406, 290);
            this.btnGuardaServicios.Name = "btnGuardaServicios";
            this.btnGuardaServicios.Size = new System.Drawing.Size(75, 37);
            this.btnGuardaServicios.TabIndex = 69;
            this.btnGuardaServicios.Text = "Guardar";
            this.btnGuardaServicios.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGuardaServicios.UseVisualStyleBackColor = true;
            this.btnGuardaServicios.Click += new System.EventHandler(this.btnGuardaServicios_Click);
            // 
            // fMovimiento
            // 
            this.fMovimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fMovimiento.Location = new System.Drawing.Point(102, 21);
            this.fMovimiento.Name = "fMovimiento";
            this.fMovimiento.Size = new System.Drawing.Size(103, 20);
            this.fMovimiento.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 71;
            this.label7.Text = "Fecha Movimiento:";
            // 
            // GridServiciosBusqueda
            // 
            this.GridServiciosBusqueda.AllowUserToAddRows = false;
            this.GridServiciosBusqueda.AllowUserToDeleteRows = false;
            this.GridServiciosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.GridServiciosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridServiciosBusqueda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Utilizado,
            this.dataGridViewTextBoxColumn2,
            this.FechaUtilizado,
            this.dataGridViewTextBoxColumn1});
            this.GridServiciosBusqueda.Location = new System.Drawing.Point(6, 43);
            this.GridServiciosBusqueda.Name = "GridServiciosBusqueda";
            this.GridServiciosBusqueda.ReadOnly = true;
            this.GridServiciosBusqueda.Size = new System.Drawing.Size(475, 244);
            this.GridServiciosBusqueda.TabIndex = 34;
            this.GridServiciosBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridServiciosBusqueda_CellContentClick);
            // 
            // Utilizado
            // 
            this.Utilizado.HeaderText = "";
            this.Utilizado.Name = "Utilizado";
            this.Utilizado.ReadOnly = true;
            this.Utilizado.Width = 30;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Servicio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // FechaUtilizado
            // 
            this.FechaUtilizado.HeaderText = "Fecha Utilizado";
            this.FechaUtilizado.Name = "FechaUtilizado";
            this.FechaUtilizado.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdMembresiaDetalle";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // Membresias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 465);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.Name = "Membresias";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Membresias...";
            this.Load += new System.EventHandler(this.Membresias_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridServicios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridMembresiasBusqueda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridServiciosBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnAnexar;
        private System.Windows.Forms.TextBox txtFolioPago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridServicios;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductoBusqueda;
        private System.Windows.Forms.DataGridView GridDatosBusqueda;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboNiveles;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServicios;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn iCveProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox ComboClientesBusqueda;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView GridServiciosBusqueda;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView GridMembresiasBusqueda;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnGuardaServicios;
        private System.Windows.Forms.DateTimePicker fMovimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Utilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaUtilizado;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnImprimir;

    }
}