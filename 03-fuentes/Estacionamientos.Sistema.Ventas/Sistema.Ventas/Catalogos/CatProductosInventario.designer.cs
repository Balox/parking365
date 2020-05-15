namespace Sistema.Ventas.Catalogos
{
    partial class CatProductosInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CatProductosInventario));
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboProveedores = new System.Windows.Forms.ComboBox();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiezasRestantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPiezasVendidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPiezasActuales = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboProductos = new System.Windows.Forms.ComboBox();
            this.txtPiezas = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridDatos
            // 
            this.GridDatos.AllowUserToAddRows = false;
            this.GridDatos.AllowUserToDeleteRows = false;
            this.GridDatos.BackgroundColor = System.Drawing.Color.White;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(0, 166);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.ReadOnly = true;
            this.GridDatos.Size = new System.Drawing.Size(1149, 332);
            this.GridDatos.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscar);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboProveedores);
            this.groupBox2.Controls.Add(this.fInicial);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPiezasRestantes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPiezasVendidas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPiezasActuales);
            this.groupBox2.Controls.Add(this.btnAgregar);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ComboProductos);
            this.groupBox2.Controls.Add(this.txtPiezas);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.txtPrecioVenta);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.txtUtilidad);
            this.groupBox2.Location = new System.Drawing.Point(0, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1137, 158);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar al inventario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 14);
            this.label5.TabIndex = 61;
            this.label5.Text = "Proveedor:";
            // 
            // ComboProveedores
            // 
            this.ComboProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboProveedores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboProveedores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProveedores.FormattingEnabled = true;
            this.ComboProveedores.Location = new System.Drawing.Point(93, 47);
            this.ComboProveedores.Name = "ComboProveedores";
            this.ComboProveedores.Size = new System.Drawing.Size(442, 23);
            this.ComboProveedores.TabIndex = 60;
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(93, 133);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Fecha Compra :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1030, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 57;
            this.label3.Text = "Piezas Restantes";
            // 
            // txtPiezasRestantes
            // 
            this.txtPiezasRestantes.Enabled = false;
            this.txtPiezasRestantes.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasRestantes.Location = new System.Drawing.Point(1027, 63);
            this.txtPiezasRestantes.MaxLength = 10;
            this.txtPiezasRestantes.Name = "txtPiezasRestantes";
            this.txtPiezasRestantes.Size = new System.Drawing.Size(95, 27);
            this.txtPiezasRestantes.TabIndex = 56;
            this.txtPiezasRestantes.Text = "0";
            this.txtPiezasRestantes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(919, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 55;
            this.label2.Text = "Piezas Vendidas";
            // 
            // txtPiezasVendidas
            // 
            this.txtPiezasVendidas.Enabled = false;
            this.txtPiezasVendidas.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasVendidas.Location = new System.Drawing.Point(916, 63);
            this.txtPiezasVendidas.MaxLength = 10;
            this.txtPiezasVendidas.Name = "txtPiezasVendidas";
            this.txtPiezasVendidas.Size = new System.Drawing.Size(95, 27);
            this.txtPiezasVendidas.TabIndex = 54;
            this.txtPiezasVendidas.Text = "0";
            this.txtPiezasVendidas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(790, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Piezas Compradas";
            // 
            // txtPiezasActuales
            // 
            this.txtPiezasActuales.Enabled = false;
            this.txtPiezasActuales.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasActuales.Location = new System.Drawing.Point(792, 63);
            this.txtPiezasActuales.MaxLength = 10;
            this.txtPiezasActuales.Name = "txtPiezasActuales";
            this.txtPiezasActuales.Size = new System.Drawing.Size(95, 27);
            this.txtPiezasActuales.TabIndex = 52;
            this.txtPiezasActuales.Text = "0";
            this.txtPiezasActuales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.White;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.Location = new System.Drawing.Point(422, 83);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(113, 44);
            this.btnAgregar.TabIndex = 51;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(37, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 14);
            this.label14.TabIndex = 50;
            this.label14.Text = "Producto:";
            // 
            // ComboProductos
            // 
            this.ComboProductos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ComboProductos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProductos.FormattingEnabled = true;
            this.ComboProductos.Location = new System.Drawing.Point(93, 19);
            this.ComboProductos.Name = "ComboProductos";
            this.ComboProductos.Size = new System.Drawing.Size(442, 24);
            this.ComboProductos.TabIndex = 49;
            this.ComboProductos.SelectedIndexChanged += new System.EventHandler(this.ComboProductos_SelectedIndexChanged);
            // 
            // txtPiezas
            // 
            this.txtPiezas.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezas.Location = new System.Drawing.Point(261, 77);
            this.txtPiezas.MaxLength = 50;
            this.txtPiezas.Name = "txtPiezas";
            this.txtPiezas.Size = new System.Drawing.Size(95, 20);
            this.txtPiezas.TabIndex = 47;
            this.txtPiezas.Text = "1";
            this.txtPiezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(196, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 14);
            this.label13.TabIndex = 48;
            this.label13.Text = "Piezas:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(21, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 14);
            this.label15.TabIndex = 9;
            this.label15.Text = "Precio Venta:";
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVenta.Location = new System.Drawing.Point(93, 107);
            this.txtPrecioVenta.MaxLength = 10;
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(95, 20);
            this.txtPrecioVenta.TabIndex = 7;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(10, 83);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 14);
            this.label16.TabIndex = 40;
            this.label16.Text = "Precio Compra:";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(93, 77);
            this.txtPrecioCompra.MaxLength = 50;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(95, 20);
            this.txtPrecioCompra.TabIndex = 6;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(200, 113);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(44, 14);
            this.label17.TabIndex = 46;
            this.label17.Text = "Utilidad:";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Enabled = false;
            this.txtUtilidad.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.Location = new System.Drawing.Point(261, 107);
            this.txtUtilidad.MaxLength = 100;
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.Size = new System.Drawing.Size(95, 20);
            this.txtUtilidad.TabIndex = 8;
            this.txtUtilidad.Text = "0";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(541, 20);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(71, 23);
            this.btnBuscar.TabIndex = 63;
            this.btnBuscar.Text = "Buscar (F1)";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CatProductosInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1149, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridDatos);
            this.MaximizeBox = false;
            this.Name = "CatProductosInventario";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboProductos;
        private System.Windows.Forms.TextBox txtPiezas;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPiezasActuales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiezasRestantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPiezasVendidas;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboProveedores;
        private System.Windows.Forms.Button btnBuscar;
    }
}