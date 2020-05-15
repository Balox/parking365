namespace Sistema.Ventas
{
    partial class Estacionar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estacionar));
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.CheckRegistro = new System.Windows.Forms.CheckBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboModelo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ComboMarca = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCostoHora = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtDisponibles = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVehiculos = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCupo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.GridHistorial = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ComboColor = new System.Windows.Forms.ComboBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtColorSalida = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.CheckImprimir = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ComboTicket = new System.Windows.Forms.ComboBox();
            this.lblMinutos = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtPlacas2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTicket = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(298, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(174, 46);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3600000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora Actual :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 46);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha Actual :";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(298, 55);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(218, 46);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "11/10/2017";
            // 
            // CheckRegistro
            // 
            this.CheckRegistro.AutoSize = true;
            this.CheckRegistro.Checked = true;
            this.CheckRegistro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckRegistro.ForeColor = System.Drawing.Color.Black;
            this.CheckRegistro.Location = new System.Drawing.Point(88, 216);
            this.CheckRegistro.Name = "CheckRegistro";
            this.CheckRegistro.Size = new System.Drawing.Size(94, 17);
            this.CheckRegistro.TabIndex = 63;
            this.CheckRegistro.Text = "Imprimir Ticket";
            this.CheckRegistro.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(88, 239);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(117, 35);
            this.btnAgregar.TabIndex = 60;
            this.btnAgregar.Text = "Registrar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtPlacas
            // 
            this.txtPlacas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas.Location = new System.Drawing.Point(88, 98);
            this.txtPlacas.MaxLength = 10;
            this.txtPlacas.Name = "txtPlacas";
            this.txtPlacas.Size = new System.Drawing.Size(192, 30);
            this.txtPlacas.TabIndex = 46;
            this.txtPlacas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 45;
            this.label5.Text = "Placas:";
            // 
            // ComboModelo
            // 
            this.ComboModelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboModelo.FormattingEnabled = true;
            this.ComboModelo.Location = new System.Drawing.Point(88, 56);
            this.ComboModelo.Name = "ComboModelo";
            this.ComboModelo.Size = new System.Drawing.Size(192, 33);
            this.ComboModelo.TabIndex = 44;
            this.ComboModelo.SelectedIndexChanged += new System.EventHandler(this.ComboModelo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 23);
            this.label4.TabIndex = 43;
            this.label4.Text = "Modelo:";
            // 
            // ComboMarca
            // 
            this.ComboMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMarca.FormattingEnabled = true;
            this.ComboMarca.Location = new System.Drawing.Point(88, 17);
            this.ComboMarca.Name = "ComboMarca";
            this.ComboMarca.Size = new System.Drawing.Size(192, 33);
            this.ComboMarca.TabIndex = 42;
            this.ComboMarca.SelectedIndexChanged += new System.EventHandler(this.ComboMarca_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 23);
            this.label3.TabIndex = 41;
            this.label3.Text = "Marca:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(56, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 42;
            this.label6.Text = "Cupo Total :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCostoHora);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txtDisponibles);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtVehiculos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCupo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(583, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 100);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // txtCostoHora
            // 
            this.txtCostoHora.Enabled = false;
            this.txtCostoHora.Location = new System.Drawing.Point(304, 34);
            this.txtCostoHora.Name = "txtCostoHora";
            this.txtCostoHora.Size = new System.Drawing.Size(65, 20);
            this.txtCostoHora.TabIndex = 49;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(234, 36);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(63, 18);
            this.label17.TabIndex = 48;
            this.label17.Text = "Hora $ :";
            // 
            // txtDisponibles
            // 
            this.txtDisponibles.Enabled = false;
            this.txtDisponibles.Location = new System.Drawing.Point(146, 66);
            this.txtDisponibles.Name = "txtDisponibles";
            this.txtDisponibles.Size = new System.Drawing.Size(59, 20);
            this.txtDisponibles.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(133, 18);
            this.label8.TabIndex = 46;
            this.label8.Text = "Cupo Disponible :";
            // 
            // txtVehiculos
            // 
            this.txtVehiculos.Enabled = false;
            this.txtVehiculos.Location = new System.Drawing.Point(146, 40);
            this.txtVehiculos.Name = "txtVehiculos";
            this.txtVehiculos.Size = new System.Drawing.Size(59, 20);
            this.txtVehiculos.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(63, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 44;
            this.label7.Text = "Vehiculos :";
            // 
            // txtCupo
            // 
            this.txtCupo.Enabled = false;
            this.txtCupo.Location = new System.Drawing.Point(146, 14);
            this.txtCupo.Name = "txtCupo";
            this.txtCupo.Size = new System.Drawing.Size(59, 20);
            this.txtCupo.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.fFinal);
            this.groupBox2.Controls.Add(this.fInicial);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.GridHistorial);
            this.groupBox2.Location = new System.Drawing.Point(794, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(415, 353);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Historial del estacionamiento";
            // 
            // btnBuscar
            // 
            this.btnBuscar.ForeColor = System.Drawing.Color.Black;
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(338, 10);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 38);
            this.btnBuscar.TabIndex = 55;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(226, 17);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 54;
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(78, 17);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 53;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(185, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 52;
            this.label15.Text = "Final :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(3, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 13);
            this.label16.TabIndex = 51;
            this.label16.Text = "Fecha Inicial :";
            // 
            // GridHistorial
            // 
            this.GridHistorial.AllowUserToAddRows = false;
            this.GridHistorial.AllowUserToDeleteRows = false;
            this.GridHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.GridHistorial.BackgroundColor = System.Drawing.Color.White;
            this.GridHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridHistorial.Location = new System.Drawing.Point(6, 49);
            this.GridHistorial.Name = "GridHistorial";
            this.GridHistorial.ReadOnly = true;
            this.GridHistorial.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.GridHistorial.Size = new System.Drawing.Size(404, 296);
            this.GridHistorial.TabIndex = 50;
            // 
            // panelResultado
            // 
            this.panelResultado.Location = new System.Drawing.Point(522, 18);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(43, 43);
            this.panelResultado.TabIndex = 51;
            this.panelResultado.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.White;
            this.groupBox4.CausesValidation = false;
            this.groupBox4.Controls.Add(this.ComboColor);
            this.groupBox4.Controls.Add(this.txtColor);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.CheckRegistro);
            this.groupBox4.Controls.Add(this.ComboMarca);
            this.groupBox4.Controls.Add(this.btnAgregar);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtPlacas);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.ComboModelo);
            this.groupBox4.Location = new System.Drawing.Point(2, 118);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(286, 364);
            this.groupBox4.TabIndex = 52;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Entradas";
            // 
            // ComboColor
            // 
            this.ComboColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboColor.FormattingEnabled = true;
            this.ComboColor.Location = new System.Drawing.Point(88, 131);
            this.ComboColor.Name = "ComboColor";
            this.ComboColor.Size = new System.Drawing.Size(192, 33);
            this.ComboColor.TabIndex = 66;
            this.ComboColor.SelectedIndexChanged += new System.EventHandler(this.ComboColor_SelectedIndexChanged);
            // 
            // txtColor
            // 
            this.txtColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColor.Location = new System.Drawing.Point(88, 180);
            this.txtColor.MaxLength = 30;
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(192, 30);
            this.txtColor.TabIndex = 65;
            this.txtColor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtColor.Visible = false;
            this.txtColor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtColor_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.Black;
            this.label21.Location = new System.Drawing.Point(25, 141);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(63, 23);
            this.label21.TabIndex = 64;
            this.label21.Text = "Color:";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.txtColorSalida);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.lblMinutos);
            this.groupBox3.Controls.Add(this.lblHoras);
            this.groupBox3.Controls.Add(this.txtEntrada);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtModelo);
            this.groupBox3.Controls.Add(this.txtMarca);
            this.groupBox3.Controls.Add(this.txtPlacas2);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtTicket);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(298, 117);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(490, 365);
            this.groupBox3.TabIndex = 53;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Salidas";
            // 
            // txtColorSalida
            // 
            this.txtColorSalida.Enabled = false;
            this.txtColorSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColorSalida.Location = new System.Drawing.Point(86, 157);
            this.txtColorSalida.MaxLength = 10;
            this.txtColorSalida.Name = "txtColorSalida";
            this.txtColorSalida.Size = new System.Drawing.Size(277, 30);
            this.txtColorSalida.TabIndex = 97;
            this.txtColorSalida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(25, 164);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(63, 23);
            this.label22.TabIndex = 96;
            this.label22.Text = "Color:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.lblTotal);
            this.groupBox5.Controls.Add(this.txtCambio);
            this.groupBox5.Controls.Add(this.btnCobrar);
            this.groupBox5.Controls.Add(this.txtPago);
            this.groupBox5.Controls.Add(this.CheckImprimir);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.ComboTicket);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(3, 225);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(479, 135);
            this.groupBox5.TabIndex = 95;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pago";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Black;
            this.label20.Location = new System.Drawing.Point(204, 20);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(69, 21);
            this.label20.TabIndex = 67;
            this.label20.Text = "Pago $";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(336, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 21);
            this.label19.TabIndex = 68;
            this.label19.Text = "Cambio $";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(135, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 39);
            this.label14.TabIndex = 57;
            this.label14.Text = "TOTAL $";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Red;
            this.lblTotal.Location = new System.Drawing.Point(291, 91);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(187, 39);
            this.lblTotal.TabIndex = 58;
            this.lblTotal.Text = "000,000.00";
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCambio.Location = new System.Drawing.Point(340, 44);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(127, 27);
            this.txtCambio.TabIndex = 66;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.White;
            this.btnCobrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.Black;
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(2, 83);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(113, 44);
            this.btnCobrar.TabIndex = 59;
            this.btnCobrar.Text = "&Cobrar";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click_1);
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.Black;
            this.txtPago.Location = new System.Drawing.Point(208, 44);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(127, 27);
            this.txtPago.TabIndex = 65;
            this.txtPago.Text = "0.00";
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged_1);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // CheckImprimir
            // 
            this.CheckImprimir.AutoSize = true;
            this.CheckImprimir.Checked = true;
            this.CheckImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckImprimir.ForeColor = System.Drawing.Color.Black;
            this.CheckImprimir.Location = new System.Drawing.Point(2, 54);
            this.CheckImprimir.Name = "CheckImprimir";
            this.CheckImprimir.Size = new System.Drawing.Size(94, 17);
            this.CheckImprimir.TabIndex = 62;
            this.CheckImprimir.Text = "Imprimir Ticket";
            this.CheckImprimir.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(93, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 15);
            this.label18.TabIndex = 64;
            this.label18.Text = "Impre.";
            // 
            // ComboTicket
            // 
            this.ComboTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboTicket.FormattingEnabled = true;
            this.ComboTicket.Location = new System.Drawing.Point(142, 50);
            this.ComboTicket.Name = "ComboTicket";
            this.ComboTicket.Size = new System.Drawing.Size(47, 21);
            this.ComboTicket.TabIndex = 63;
            this.ComboTicket.SelectedIndexChanged += new System.EventHandler(this.ComboTicket_SelectedIndexChanged);
            // 
            // lblMinutos
            // 
            this.lblMinutos.AutoSize = true;
            this.lblMinutos.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinutos.ForeColor = System.Drawing.Color.Black;
            this.lblMinutos.Location = new System.Drawing.Point(363, 55);
            this.lblMinutos.Name = "lblMinutos";
            this.lblMinutos.Size = new System.Drawing.Size(84, 23);
            this.lblMinutos.TabIndex = 94;
            this.lblMinutos.Text = "Minutos:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoras.ForeColor = System.Drawing.Color.Black;
            this.lblHoras.Location = new System.Drawing.Point(378, 19);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(74, 23);
            this.lblHoras.TabIndex = 93;
            this.lblHoras.Text = "Horas: ";
            // 
            // txtEntrada
            // 
            this.txtEntrada.Enabled = false;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(86, 193);
            this.txtEntrada.MaxLength = 10;
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(277, 30);
            this.txtEntrada.TabIndex = 92;
            this.txtEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(3, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 23);
            this.label13.TabIndex = 91;
            this.label13.Text = "Entrada:";
            // 
            // txtModelo
            // 
            this.txtModelo.Enabled = false;
            this.txtModelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelo.Location = new System.Drawing.Point(86, 84);
            this.txtModelo.MaxLength = 10;
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(277, 30);
            this.txtModelo.TabIndex = 90;
            this.txtModelo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(86, 48);
            this.txtMarca.MaxLength = 10;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(277, 30);
            this.txtMarca.TabIndex = 89;
            this.txtMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtPlacas2
            // 
            this.txtPlacas2.Enabled = false;
            this.txtPlacas2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlacas2.Location = new System.Drawing.Point(86, 121);
            this.txtPlacas2.MaxLength = 10;
            this.txtPlacas2.Name = "txtPlacas2";
            this.txtPlacas2.Size = new System.Drawing.Size(277, 30);
            this.txtPlacas2.TabIndex = 88;
            this.txtPlacas2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(13, 128);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 23);
            this.label10.TabIndex = 87;
            this.label10.Text = "Placas:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(7, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 23);
            this.label11.TabIndex = 86;
            this.label11.Text = "Modelo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(16, 55);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 23);
            this.label12.TabIndex = 85;
            this.label12.Text = "Marca:";
            // 
            // txtTicket
            // 
            this.txtTicket.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTicket.Location = new System.Drawing.Point(86, 12);
            this.txtTicket.MaxLength = 10;
            this.txtTicket.Name = "txtTicket";
            this.txtTicket.Size = new System.Drawing.Size(277, 30);
            this.txtTicket.TabIndex = 84;
            this.txtTicket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTicket.TextChanged += new System.EventHandler(this.txtTicket_TextChanged_1);
            this.txtTicket.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTicket_KeyPress_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(14, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 23);
            this.label9.TabIndex = 83;
            this.label9.Text = "Ticket :";
            // 
            // Estacionar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Blue;
            this.ClientSize = new System.Drawing.Size(1221, 483);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHora);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Estacionar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estacionamiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Estacionar_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridHistorial)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.ComboBox ComboModelo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ComboMarca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCupo;
        private System.Windows.Forms.TextBox txtVehiculos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDisponibles;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView GridHistorial;
        private System.Windows.Forms.TextBox txtCostoHora;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox CheckRegistro;
        private System.Windows.Forms.Panel panelResultado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.CheckBox CheckImprimir;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox ComboTicket;
        private System.Windows.Forms.Label lblMinutos;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtPlacas2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTicket;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox ComboColor;
        private System.Windows.Forms.TextBox txtColorSalida;
        private System.Windows.Forms.Label label22;

    }
}