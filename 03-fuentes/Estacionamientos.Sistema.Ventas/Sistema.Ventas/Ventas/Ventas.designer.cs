namespace Sistema.Ventas
{
    partial class Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ventas));
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnEliminaRenglon = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.lblFolioActivo = new System.Windows.Forms.Label();
            this.lblStatusFolio = new System.Windows.Forms.Label();
            this.txtFolioHistorico = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCobrar = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.DescPesos = new System.Windows.Forms.RadioButton();
            this.DescPorce = new System.Windows.Forms.RadioButton();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.txtDescuentoPorcentaje = new System.Windows.Forms.TextBox();
            this.txtiCveProducto = new System.Windows.Forms.TextBox();
            this.txtdescuento = new System.Windows.Forms.TextBox();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.GridDatosBusqueda = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CheckPagado = new System.Windows.Forms.CheckBox();
            this.btnPorCobrar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.ComboTicket = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.btnTiempoAire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtProductoBusqueda = new System.Windows.Forms.TextBox();
            this.btnUltimasVisitas = new System.Windows.Forms.Button();
            this.btnCitasPendientes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPago = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCambio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CheckImprimir = new System.Windows.Forms.CheckBox();
            this.CheckPrecio = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridDatos
            // 
            this.GridDatos.AllowUserToAddRows = false;
            this.GridDatos.AllowUserToDeleteRows = false;
            this.GridDatos.BackgroundColor = System.Drawing.Color.White;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(4, 116);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.ReadOnly = true;
            this.GridDatos.Size = new System.Drawing.Size(766, 295);
            this.GridDatos.TabIndex = 10;
            this.GridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatos_CellDoubleClick);
            this.GridDatos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GridDatos_KeyUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(90)))), ((int)(((byte)(141)))));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnBuscarCliente);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.ComboCliente);
            this.panel2.Controls.Add(this.btnNueva);
            this.panel2.Controls.Add(this.btnEliminaRenglon);
            this.panel2.Controls.Add(this.label18);
            this.panel2.Controls.Add(this.lblFolioActivo);
            this.panel2.Controls.Add(this.lblStatusFolio);
            this.panel2.Controls.Add(this.txtFolioHistorico);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 55);
            this.panel2.TabIndex = 29;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(542, 15);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(71, 23);
            this.btnBuscarCliente.TabIndex = 39;
            this.btnBuscarCliente.Text = "Buscar (F1)";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(191, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 44);
            this.label9.TabIndex = 38;
            this.label9.Text = "Cliente:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ComboCliente
            // 
            this.ComboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(287, 8);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(254, 28);
            this.ComboCliente.TabIndex = 36;
            // 
            // btnNueva
            // 
            this.btnNueva.BackColor = System.Drawing.Color.White;
            this.btnNueva.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.ForeColor = System.Drawing.Color.Black;
            this.btnNueva.Image = ((System.Drawing.Image)(resources.GetObject("btnNueva.Image")));
            this.btnNueva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNueva.Location = new System.Drawing.Point(97, 3);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(100, 45);
            this.btnNueva.TabIndex = 35;
            this.btnNueva.Text = "Nueva";
            this.btnNueva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNueva.UseVisualStyleBackColor = false;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnEliminaRenglon
            // 
            this.btnEliminaRenglon.BackColor = System.Drawing.Color.White;
            this.btnEliminaRenglon.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminaRenglon.ForeColor = System.Drawing.Color.Black;
            this.btnEliminaRenglon.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminaRenglon.Image")));
            this.btnEliminaRenglon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminaRenglon.Location = new System.Drawing.Point(3, 3);
            this.btnEliminaRenglon.Name = "btnEliminaRenglon";
            this.btnEliminaRenglon.Size = new System.Drawing.Size(93, 45);
            this.btnEliminaRenglon.TabIndex = 34;
            this.btnEliminaRenglon.Text = "&Eliminar";
            this.btnEliminaRenglon.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminaRenglon.UseVisualStyleBackColor = false;
            this.btnEliminaRenglon.Click += new System.EventHandler(this.btnEliminaRenglon_Click);
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(608, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(72, 44);
            this.label18.TabIndex = 22;
            this.label18.Text = "Caja 1";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFolioActivo
            // 
            this.lblFolioActivo.AutoSize = true;
            this.lblFolioActivo.BackColor = System.Drawing.Color.Transparent;
            this.lblFolioActivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFolioActivo.ForeColor = System.Drawing.Color.Black;
            this.lblFolioActivo.Location = new System.Drawing.Point(749, 8);
            this.lblFolioActivo.Name = "lblFolioActivo";
            this.lblFolioActivo.Size = new System.Drawing.Size(15, 16);
            this.lblFolioActivo.TabIndex = 2;
            this.lblFolioActivo.Text = "0";
            this.lblFolioActivo.Visible = false;
            // 
            // lblStatusFolio
            // 
            this.lblStatusFolio.BackColor = System.Drawing.Color.Red;
            this.lblStatusFolio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStatusFolio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatusFolio.ForeColor = System.Drawing.Color.White;
            this.lblStatusFolio.Location = new System.Drawing.Point(719, 28);
            this.lblStatusFolio.Name = "lblStatusFolio";
            this.lblStatusFolio.Size = new System.Drawing.Size(31, 20);
            this.lblStatusFolio.TabIndex = 32;
            this.lblStatusFolio.Text = "Cancelado";
            this.lblStatusFolio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblStatusFolio.Visible = false;
            // 
            // txtFolioHistorico
            // 
            this.txtFolioHistorico.Location = new System.Drawing.Point(686, 27);
            this.txtFolioHistorico.Name = "txtFolioHistorico";
            this.txtFolioHistorico.Size = new System.Drawing.Size(71, 20);
            this.txtFolioHistorico.TabIndex = 30;
            this.txtFolioHistorico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFolioHistorico.TextChanged += new System.EventHandler(this.txtFolioHistorico_TextChanged);
            this.txtFolioHistorico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFolioHistorico_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(676, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "ReImpresion:";
            // 
            // btnCobrar
            // 
            this.btnCobrar.BackColor = System.Drawing.Color.White;
            this.btnCobrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCobrar.ForeColor = System.Drawing.Color.Black;
            this.btnCobrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCobrar.Image")));
            this.btnCobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCobrar.Location = new System.Drawing.Point(657, 430);
            this.btnCobrar.Name = "btnCobrar";
            this.btnCobrar.Size = new System.Drawing.Size(113, 44);
            this.btnCobrar.TabIndex = 33;
            this.btnCobrar.Text = "&Cobrar(F10)";
            this.btnCobrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCobrar.UseVisualStyleBackColor = false;
            this.btnCobrar.Click += new System.EventHandler(this.btnCobrar_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.CheckPrecio);
            this.panel6.Controls.Add(this.btnBusquedaAvanzada);
            this.panel6.Controls.Add(this.DescPesos);
            this.panel6.Controls.Add(this.DescPorce);
            this.panel6.Controls.Add(this.txtUtilidad);
            this.panel6.Controls.Add(this.txtDescuentoPorcentaje);
            this.panel6.Controls.Add(this.txtiCveProducto);
            this.panel6.Controls.Add(this.txtdescuento);
            this.panel6.Controls.Add(this.txtprecio);
            this.panel6.Controls.Add(this.label24);
            this.panel6.Controls.Add(this.btnAgregar);
            this.panel6.Controls.Add(this.txtdescripcion);
            this.panel6.Controls.Add(this.label23);
            this.panel6.Controls.Add(this.txtcantidad);
            this.panel6.Controls.Add(this.label22);
            this.panel6.Controls.Add(this.txtcodigo);
            this.panel6.Controls.Add(this.label15);
            this.panel6.Location = new System.Drawing.Point(4, 57);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(766, 56);
            this.panel6.TabIndex = 30;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(272, 4);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(134, 21);
            this.btnBusquedaAvanzada.TabIndex = 59;
            this.btnBusquedaAvanzada.Text = "Busqueda avanzada (F2)";
            this.btnBusquedaAvanzada.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // DescPesos
            // 
            this.DescPesos.AutoSize = true;
            this.DescPesos.Location = new System.Drawing.Point(614, 6);
            this.DescPesos.Name = "DescPesos";
            this.DescPesos.Size = new System.Drawing.Size(31, 17);
            this.DescPesos.TabIndex = 42;
            this.DescPesos.Text = "$";
            this.DescPesos.UseVisualStyleBackColor = true;
            this.DescPesos.CheckedChanged += new System.EventHandler(this.DescPesos_CheckedChanged);
            // 
            // DescPorce
            // 
            this.DescPorce.AutoSize = true;
            this.DescPorce.Checked = true;
            this.DescPorce.Location = new System.Drawing.Point(645, 6);
            this.DescPorce.Name = "DescPorce";
            this.DescPorce.Size = new System.Drawing.Size(33, 17);
            this.DescPorce.TabIndex = 40;
            this.DescPorce.TabStop = true;
            this.DescPorce.Text = "%";
            this.DescPorce.UseVisualStyleBackColor = true;
            this.DescPorce.CheckedChanged += new System.EventHandler(this.DescPorce_CheckedChanged);
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.Location = new System.Drawing.Point(167, -3);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(33, 23);
            this.txtUtilidad.TabIndex = 41;
            this.txtUtilidad.Text = "0.00";
            this.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtUtilidad.Visible = false;
            // 
            // txtDescuentoPorcentaje
            // 
            this.txtDescuentoPorcentaje.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtDescuentoPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoPorcentaje.Location = new System.Drawing.Point(623, 27);
            this.txtDescuentoPorcentaje.Name = "txtDescuentoPorcentaje";
            this.txtDescuentoPorcentaje.Size = new System.Drawing.Size(44, 23);
            this.txtDescuentoPorcentaje.TabIndex = 40;
            this.txtDescuentoPorcentaje.Text = "0.00";
            this.txtDescuentoPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDescuentoPorcentaje.TextChanged += new System.EventHandler(this.txtDescuentoPorcentaje_TextChanged);
            this.txtDescuentoPorcentaje.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescuentoPorcentaje_KeyPress);
            // 
            // txtiCveProducto
            // 
            this.txtiCveProducto.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtiCveProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtiCveProducto.Location = new System.Drawing.Point(-21, -7);
            this.txtiCveProducto.Name = "txtiCveProducto";
            this.txtiCveProducto.Size = new System.Drawing.Size(20, 26);
            this.txtiCveProducto.TabIndex = 39;
            this.txtiCveProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtdescuento
            // 
            this.txtdescuento.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescuento.Location = new System.Drawing.Point(623, 27);
            this.txtdescuento.Name = "txtdescuento";
            this.txtdescuento.Size = new System.Drawing.Size(44, 23);
            this.txtdescuento.TabIndex = 3;
            this.txtdescuento.Text = "0.00";
            this.txtdescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtdescuento.Visible = false;
            this.txtdescuento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdescuento_KeyPress);
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtprecio.Enabled = false;
            this.txtprecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(555, 27);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(59, 23);
            this.txtprecio.TabIndex = 34;
            this.txtprecio.Text = "0.00";
            this.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Black;
            this.label24.Location = new System.Drawing.Point(557, 7);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 18);
            this.label24.TabIndex = 33;
            this.label24.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(679, 7);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(85, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Car&gar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtdescripcion.Enabled = false;
            this.txtdescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescripcion.Location = new System.Drawing.Point(167, 26);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(305, 24);
            this.txtdescripcion.TabIndex = 32;
            // 
            // label23
            // 
            this.label23.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.Black;
            this.label23.Location = new System.Drawing.Point(173, 5);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(93, 18);
            this.label23.TabIndex = 31;
            this.label23.Text = "Descripción";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.Location = new System.Drawing.Point(507, 27);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(43, 23);
            this.txtcantidad.TabIndex = 2;
            this.txtcantidad.Text = "1";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            // 
            // label22
            // 
            this.label22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Black;
            this.label22.Location = new System.Drawing.Point(506, 7);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 18);
            this.label22.TabIndex = 29;
            this.label22.Text = "Cant.";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodigo.Location = new System.Drawing.Point(3, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(163, 23);
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(71, 6);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 18);
            this.label15.TabIndex = 27;
            this.label15.Text = "Código";
            // 
            // GridDatosBusqueda
            // 
            this.GridDatosBusqueda.AllowUserToAddRows = false;
            this.GridDatosBusqueda.AllowUserToDeleteRows = false;
            this.GridDatosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.GridDatosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosBusqueda.Location = new System.Drawing.Point(3, 45);
            this.GridDatosBusqueda.Name = "GridDatosBusqueda";
            this.GridDatosBusqueda.ReadOnly = true;
            this.GridDatosBusqueda.Size = new System.Drawing.Size(557, 339);
            this.GridDatosBusqueda.TabIndex = 31;
            this.GridDatosBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosBusqueda_CellContentClick);
            this.GridDatosBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosBusqueda_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CheckPagado);
            this.groupBox1.Controls.Add(this.btnPorCobrar);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.ComboTicket);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtObservaciones);
            this.groupBox1.Controls.Add(this.btnTiempoAire);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.txtProductoBusqueda);
            this.groupBox1.Controls.Add(this.btnUltimasVisitas);
            this.groupBox1.Controls.Add(this.GridDatosBusqueda);
            this.groupBox1.Controls.Add(this.btnCitasPendientes);
            this.groupBox1.Location = new System.Drawing.Point(773, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 473);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda de productos";
            // 
            // CheckPagado
            // 
            this.CheckPagado.AutoSize = true;
            this.CheckPagado.Checked = true;
            this.CheckPagado.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckPagado.Location = new System.Drawing.Point(108, 393);
            this.CheckPagado.Name = "CheckPagado";
            this.CheckPagado.Size = new System.Drawing.Size(63, 17);
            this.CheckPagado.TabIndex = 57;
            this.CheckPagado.Text = "Pagado";
            this.CheckPagado.UseVisualStyleBackColor = true;
            // 
            // btnPorCobrar
            // 
            this.btnPorCobrar.Location = new System.Drawing.Point(177, 419);
            this.btnPorCobrar.Name = "btnPorCobrar";
            this.btnPorCobrar.Size = new System.Drawing.Size(155, 21);
            this.btnPorCobrar.TabIndex = 56;
            this.btnPorCobrar.Text = "Ctas por Cobrar";
            this.btnPorCobrar.UseVisualStyleBackColor = true;
            this.btnPorCobrar.Click += new System.EventHandler(this.btnPorCobrar_Click);
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 394);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 15);
            this.label8.TabIndex = 55;
            this.label8.Text = "Impre.";
            // 
            // ComboTicket
            // 
            this.ComboTicket.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboTicket.FormattingEnabled = true;
            this.ComboTicket.Location = new System.Drawing.Point(55, 388);
            this.ComboTicket.Name = "ComboTicket";
            this.ComboTicket.Size = new System.Drawing.Size(47, 21);
            this.ComboTicket.TabIndex = 54;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 424);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 15);
            this.label7.TabIndex = 53;
            this.label7.Text = "Observaciones:";
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.Location = new System.Drawing.Point(9, 443);
            this.txtObservaciones.MaxLength = 120;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(548, 20);
            this.txtObservaciones.TabIndex = 52;
            // 
            // btnTiempoAire
            // 
            this.btnTiempoAire.Location = new System.Drawing.Point(177, 391);
            this.btnTiempoAire.Name = "btnTiempoAire";
            this.btnTiempoAire.Size = new System.Drawing.Size(155, 21);
            this.btnTiempoAire.TabIndex = 51;
            this.btnTiempoAire.Text = "Tiempo Aire";
            this.btnTiempoAire.UseVisualStyleBackColor = true;
            this.btnTiempoAire.Click += new System.EventHandler(this.btnTiempoAire_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(407, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 21);
            this.button1.TabIndex = 50;
            this.button1.Text = "Vencimiento Membresias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtProductoBusqueda
            // 
            this.txtProductoBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductoBusqueda.Location = new System.Drawing.Point(3, 15);
            this.txtProductoBusqueda.Name = "txtProductoBusqueda";
            this.txtProductoBusqueda.Size = new System.Drawing.Size(557, 23);
            this.txtProductoBusqueda.TabIndex = 32;
            this.txtProductoBusqueda.TextChanged += new System.EventHandler(this.txtProductoBusqueda_TextChanged);
            // 
            // btnUltimasVisitas
            // 
            this.btnUltimasVisitas.Location = new System.Drawing.Point(208, 363);
            this.btnUltimasVisitas.Name = "btnUltimasVisitas";
            this.btnUltimasVisitas.Size = new System.Drawing.Size(155, 21);
            this.btnUltimasVisitas.TabIndex = 49;
            this.btnUltimasVisitas.Text = "Ultimas Visitas";
            this.btnUltimasVisitas.UseVisualStyleBackColor = true;
            this.btnUltimasVisitas.Visible = false;
            this.btnUltimasVisitas.Click += new System.EventHandler(this.btnUltimasVisitas_Click);
            // 
            // btnCitasPendientes
            // 
            this.btnCitasPendientes.Location = new System.Drawing.Point(3, 363);
            this.btnCitasPendientes.Name = "btnCitasPendientes";
            this.btnCitasPendientes.Size = new System.Drawing.Size(155, 21);
            this.btnCitasPendientes.TabIndex = 48;
            this.btnCitasPendientes.Text = "Citas Pendientes";
            this.btnCitasPendientes.UseVisualStyleBackColor = true;
            this.btnCitasPendientes.Visible = false;
            this.btnCitasPendientes.Click += new System.EventHandler(this.btnCitasPendientes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 35;
            this.label1.Text = "SubTotal $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(130, 416);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 21);
            this.label3.TabIndex = 36;
            this.label3.Text = "Descuento $";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(261, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 37;
            this.label4.Text = "Total $";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(4, 447);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(127, 27);
            this.txtSubtotal.TabIndex = 38;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Enabled = false;
            this.txtDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoTotal.Location = new System.Drawing.Point(134, 447);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.Size = new System.Drawing.Size(127, 27);
            this.txtDescuentoTotal.TabIndex = 39;
            this.txtDescuentoTotal.Text = "0.00";
            this.txtDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(265, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 30);
            this.txtTotal.TabIndex = 40;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPago
            // 
            this.txtPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPago.ForeColor = System.Drawing.Color.Black;
            this.txtPago.Location = new System.Drawing.Point(396, 447);
            this.txtPago.Name = "txtPago";
            this.txtPago.Size = new System.Drawing.Size(127, 27);
            this.txtPago.TabIndex = 42;
            this.txtPago.Text = "0.00";
            this.txtPago.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtPago.TextChanged += new System.EventHandler(this.txtPago_TextChanged);
            this.txtPago.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPago_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(392, 416);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 21);
            this.label5.TabIndex = 41;
            this.label5.Text = "Pago (F9) $";
            // 
            // txtCambio
            // 
            this.txtCambio.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCambio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtCambio.Location = new System.Drawing.Point(528, 447);
            this.txtCambio.Name = "txtCambio";
            this.txtCambio.ReadOnly = true;
            this.txtCambio.Size = new System.Drawing.Size(127, 27);
            this.txtCambio.TabIndex = 44;
            this.txtCambio.Text = "0.00";
            this.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(524, 416);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Cambio $";
            // 
            // CheckImprimir
            // 
            this.CheckImprimir.AutoSize = true;
            this.CheckImprimir.Checked = true;
            this.CheckImprimir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckImprimir.Location = new System.Drawing.Point(657, 414);
            this.CheckImprimir.Name = "CheckImprimir";
            this.CheckImprimir.Size = new System.Drawing.Size(94, 17);
            this.CheckImprimir.TabIndex = 45;
            this.CheckImprimir.Text = "Imprimir Ticket";
            this.CheckImprimir.UseVisualStyleBackColor = true;
            // 
            // CheckPrecio
            // 
            this.CheckPrecio.AutoSize = true;
            this.CheckPrecio.Location = new System.Drawing.Point(474, 36);
            this.CheckPrecio.Name = "CheckPrecio";
            this.CheckPrecio.Size = new System.Drawing.Size(32, 17);
            this.CheckPrecio.TabIndex = 60;
            this.CheckPrecio.Text = "$";
            this.CheckPrecio.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1342, 475);
            this.Controls.Add(this.CheckImprimir);
            this.Controls.Add(this.txtCambio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCobrar);
            this.Controls.Add(this.txtPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuentoTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.GridDatos);
            this.MaximizeBox = false;
            this.Name = "Ventas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label lblFolioActivo;
        private System.Windows.Forms.Label lblStatusFolio;
        private System.Windows.Forms.TextBox txtFolioHistorico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnEliminaRenglon;
        private System.Windows.Forms.Button btnCobrar;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtdescuento;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView GridDatosBusqueda;
        private System.Windows.Forms.TextBox txtiCveProducto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtProductoBusqueda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtPago;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCambio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescuentoPorcentaje;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.RadioButton DescPorce;
        private System.Windows.Forms.RadioButton DescPesos;
        private System.Windows.Forms.Button btnCitasPendientes;
        private System.Windows.Forms.Button btnUltimasVisitas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox CheckImprimir;
        private System.Windows.Forms.Button btnTiempoAire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.ComboBox ComboTicket;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPorCobrar;
        private System.Windows.Forms.CheckBox CheckPagado;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.CheckBox CheckPrecio;
    }
}