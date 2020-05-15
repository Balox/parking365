namespace Sistema.Ventas.Catalogos
{
    partial class PorPagar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PorPagar));
            this.GridDatos = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAbonos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboProveedores = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPiezasRestantes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPiezasVendidas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPiezasActuales = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ComboProductos = new System.Windows.Forms.ComboBox();
            this.GridAbonos = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAbono = new System.Windows.Forms.TextBox();
            this.btnAbonar = new System.Windows.Forms.Button();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txticve = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtProveedor = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbonos)).BeginInit();
            this.SuspendLayout();
            // 
            // GridDatos
            // 
            this.GridDatos.AllowUserToAddRows = false;
            this.GridDatos.AllowUserToDeleteRows = false;
            this.GridDatos.BackgroundColor = System.Drawing.Color.White;
            this.GridDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatos.Location = new System.Drawing.Point(0, 91);
            this.GridDatos.Name = "GridDatos";
            this.GridDatos.ReadOnly = true;
            this.GridDatos.Size = new System.Drawing.Size(535, 407);
            this.GridDatos.TabIndex = 10;
            this.GridDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatos_CellDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtAbonos);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ComboProveedores);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtPiezasRestantes);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPiezasVendidas);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtPiezasActuales);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.ComboProductos);
            this.groupBox2.Location = new System.Drawing.Point(0, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1222, 83);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtrar";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(890, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 14);
            this.label7.TabIndex = 67;
            this.label7.Text = "TOTAL";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(866, 41);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(95, 27);
            this.txtTotal.TabIndex = 66;
            this.txtTotal.Text = "0";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(789, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 14);
            this.label6.TabIndex = 65;
            this.label6.Text = "$ Abonos";
            // 
            // txtAbonos
            // 
            this.txtAbonos.Enabled = false;
            this.txtAbonos.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbonos.Location = new System.Drawing.Point(765, 41);
            this.txtAbonos.MaxLength = 10;
            this.txtAbonos.Name = "txtAbonos";
            this.txtAbonos.Size = new System.Drawing.Size(95, 27);
            this.txtAbonos.TabIndex = 64;
            this.txtAbonos.Text = "0";
            this.txtAbonos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(688, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 63;
            this.label4.Text = "$ Compra";
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Enabled = false;
            this.txtPrecioCompra.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioCompra.Location = new System.Drawing.Point(664, 41);
            this.txtPrecioCompra.MaxLength = 10;
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(95, 27);
            this.txtPrecioCompra.TabIndex = 62;
            this.txtPrecioCompra.Text = "0";
            this.txtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.ComboProveedores.SelectedIndexChanged += new System.EventHandler(this.ComboProveedores_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1125, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 14);
            this.label3.TabIndex = 57;
            this.label3.Text = "Piezas Restantes";
            // 
            // txtPiezasRestantes
            // 
            this.txtPiezasRestantes.Enabled = false;
            this.txtPiezasRestantes.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasRestantes.Location = new System.Drawing.Point(1122, 41);
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
            this.label2.Location = new System.Drawing.Point(1024, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 14);
            this.label2.TabIndex = 55;
            this.label2.Text = "Piezas Vendidas";
            // 
            // txtPiezasVendidas
            // 
            this.txtPiezasVendidas.Enabled = false;
            this.txtPiezasVendidas.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasVendidas.Location = new System.Drawing.Point(1021, 41);
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
            this.label1.Location = new System.Drawing.Point(559, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 14);
            this.label1.TabIndex = 53;
            this.label1.Text = "Piezas Compradas";
            // 
            // txtPiezasActuales
            // 
            this.txtPiezasActuales.Enabled = false;
            this.txtPiezasActuales.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPiezasActuales.Location = new System.Drawing.Point(561, 41);
            this.txtPiezasActuales.MaxLength = 10;
            this.txtPiezasActuales.Name = "txtPiezasActuales";
            this.txtPiezasActuales.Size = new System.Drawing.Size(95, 27);
            this.txtPiezasActuales.TabIndex = 52;
            this.txtPiezasActuales.Text = "0";
            this.txtPiezasActuales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            // GridAbonos
            // 
            this.GridAbonos.AllowUserToAddRows = false;
            this.GridAbonos.AllowUserToDeleteRows = false;
            this.GridAbonos.BackgroundColor = System.Drawing.Color.White;
            this.GridAbonos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridAbonos.Location = new System.Drawing.Point(561, 91);
            this.GridAbonos.Name = "GridAbonos";
            this.GridAbonos.ReadOnly = true;
            this.GridAbonos.Size = new System.Drawing.Size(661, 321);
            this.GridAbonos.TabIndex = 56;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(586, 450);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 14);
            this.label8.TabIndex = 67;
            this.label8.Text = "Abonar";
            // 
            // txtAbono
            // 
            this.txtAbono.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbono.Location = new System.Drawing.Point(562, 467);
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
            this.btnAbonar.Location = new System.Drawing.Point(1144, 459);
            this.btnAbonar.Name = "btnAbonar";
            this.btnAbonar.Size = new System.Drawing.Size(78, 35);
            this.btnAbonar.TabIndex = 68;
            this.btnAbonar.Text = "Abonar";
            this.btnAbonar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbonar.UseVisualStyleBackColor = true;
            this.btnAbonar.Click += new System.EventHandler(this.btnAbonar_Click);
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(680, 474);
            this.txtComentario.MaxLength = 240;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(458, 20);
            this.txtComentario.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(677, 450);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 14);
            this.label9.TabIndex = 70;
            this.label9.Text = "Comentario del abono";
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(750, 415);
            this.txtProducto.MaxLength = 240;
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(472, 20);
            this.txtProducto.TabIndex = 71;
            this.txtProducto.TextChanged += new System.EventHandler(this.txtProducto_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(688, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 72;
            this.label10.Text = "Producto :";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // txticve
            // 
            this.txticve.Enabled = false;
            this.txticve.Location = new System.Drawing.Point(631, 415);
            this.txticve.MaxLength = 240;
            this.txticve.Name = "txticve";
            this.txticve.Size = new System.Drawing.Size(50, 20);
            this.txticve.TabIndex = 73;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(559, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 14);
            this.label11.TabIndex = 74;
            this.label11.Text = "No Compra :";
            // 
            // txtProveedor
            // 
            this.txtProveedor.Location = new System.Drawing.Point(816, 447);
            this.txtProveedor.Name = "txtProveedor";
            this.txtProveedor.Size = new System.Drawing.Size(69, 20);
            this.txtProveedor.TabIndex = 78;
            this.txtProveedor.Visible = false;
            // 
            // PorPagar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 510);
            this.Controls.Add(this.txtProveedor);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txticve);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.btnAbonar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAbono);
            this.Controls.Add(this.GridAbonos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GridDatos);
            this.MaximizeBox = false;
            this.Name = "PorPagar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cuentas por pagar";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridDatos)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridAbonos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridDatos;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ComboProductos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPiezasActuales;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPiezasRestantes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPiezasVendidas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboProveedores;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.DataGridView GridAbonos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAbonos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtAbono;
        private System.Windows.Forms.Button btnAbonar;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txticve;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtProveedor;
    }
}