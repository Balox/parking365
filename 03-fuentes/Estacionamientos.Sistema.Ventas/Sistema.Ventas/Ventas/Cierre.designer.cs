namespace Sistema.Ventas
{
    partial class Cierre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cierre));
            this.Datos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.ComboVendido = new System.Windows.Forms.ComboBox();
            this.btnCancelarProducto = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ComboStatus = new System.Windows.Forms.ComboBox();
            this.txtFolio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ComboCliente = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.fFinal = new System.Windows.Forms.DateTimePicker();
            this.fInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArticulosVendidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUtilidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGastos = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.BackgroundColor = System.Drawing.Color.White;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(2, 77);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(1236, 357);
            this.Datos.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.ComboVendido);
            this.groupBox1.Controls.Add(this.btnCancelarProducto);
            this.groupBox1.Controls.Add(this.btnExportar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ComboStatus);
            this.groupBox1.Controls.Add(this.txtFolio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ComboCliente);
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.fFinal);
            this.groupBox1.Controls.Add(this.fInicial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1236, 73);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Busqueda";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(340, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 14);
            this.label12.TabIndex = 21;
            this.label12.Text = "Usuario:";
            // 
            // ComboVendido
            // 
            this.ComboVendido.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboVendido.FormattingEnabled = true;
            this.ComboVendido.Location = new System.Drawing.Point(387, 39);
            this.ComboVendido.Name = "ComboVendido";
            this.ComboVendido.Size = new System.Drawing.Size(133, 21);
            this.ComboVendido.TabIndex = 20;
            // 
            // btnCancelarProducto
            // 
            this.btnCancelarProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarProducto.Image")));
            this.btnCancelarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarProducto.Location = new System.Drawing.Point(848, 16);
            this.btnCancelarProducto.Name = "btnCancelarProducto";
            this.btnCancelarProducto.Size = new System.Drawing.Size(119, 45);
            this.btnCancelarProducto.TabIndex = 19;
            this.btnCancelarProducto.Text = "Cancelar Producto";
            this.btnCancelarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarProducto.UseVisualStyleBackColor = true;
            this.btnCancelarProducto.Click += new System.EventHandler(this.btnCancelarProducto_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Image = ((System.Drawing.Image)(resources.GetObject("btnExportar.Image")));
            this.btnExportar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportar.Location = new System.Drawing.Point(1134, 16);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(99, 45);
            this.btnExportar.TabIndex = 18;
            this.btnExportar.Text = "Exportar Excel";
            this.btnExportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(743, 16);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 45);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar Folio";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "Status:";
            // 
            // ComboStatus
            // 
            this.ComboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboStatus.FormattingEnabled = true;
            this.ComboStatus.Location = new System.Drawing.Point(243, 39);
            this.ComboStatus.Name = "ComboStatus";
            this.ComboStatus.Size = new System.Drawing.Size(94, 21);
            this.ComboStatus.TabIndex = 15;
            // 
            // txtFolio
            // 
            this.txtFolio.Location = new System.Drawing.Point(582, 13);
            this.txtFolio.MaxLength = 10;
            this.txtFolio.Name = "txtFolio";
            this.txtFolio.Size = new System.Drawing.Size(64, 20);
            this.txtFolio.TabIndex = 14;
            this.txtFolio.TextChanged += new System.EventHandler(this.txtFolio_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(545, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 14);
            this.label4.TabIndex = 13;
            this.label4.Text = "Folio:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(196, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 14);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cliente:";
            // 
            // ComboCliente
            // 
            this.ComboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCliente.FormattingEnabled = true;
            this.ComboCliente.Location = new System.Drawing.Point(243, 13);
            this.ComboCliente.Name = "ComboCliente";
            this.ComboCliente.Size = new System.Drawing.Size(277, 21);
            this.ComboCliente.TabIndex = 11;
            this.ComboCliente.SelectedIndexChanged += new System.EventHandler(this.ComboCliente_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(652, 16);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(85, 45);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // fFinal
            // 
            this.fFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fFinal.Location = new System.Drawing.Point(85, 40);
            this.fFinal.Name = "fFinal";
            this.fFinal.Size = new System.Drawing.Size(103, 20);
            this.fFinal.TabIndex = 3;
            // 
            // fInicial
            // 
            this.fInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fInicial.Location = new System.Drawing.Point(85, 10);
            this.fInicial.Name = "fInicial";
            this.fInicial.Size = new System.Drawing.Size(103, 20);
            this.fInicial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Final :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha Inicial :";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(471, 468);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(127, 30);
            this.txtTotal.TabIndex = 46;
            this.txtTotal.Text = "0.00";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDescuentoTotal
            // 
            this.txtDescuentoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescuentoTotal.Location = new System.Drawing.Point(318, 471);
            this.txtDescuentoTotal.Name = "txtDescuentoTotal";
            this.txtDescuentoTotal.ReadOnly = true;
            this.txtDescuentoTotal.Size = new System.Drawing.Size(127, 27);
            this.txtDescuentoTotal.TabIndex = 45;
            this.txtDescuentoTotal.Text = "0.00";
            this.txtDescuentoTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSubtotal.Location = new System.Drawing.Point(175, 471);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(127, 27);
            this.txtSubtotal.TabIndex = 44;
            this.txtSubtotal.Text = "0.00";
            this.txtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(472, 440);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 21);
            this.label6.TabIndex = 43;
            this.label6.Text = "Total $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(314, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 21);
            this.label7.TabIndex = 42;
            this.label7.Text = "Descuento $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(171, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "SubTotal $";
            // 
            // txtArticulosVendidos
            // 
            this.txtArticulosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulosVendidos.Location = new System.Drawing.Point(12, 471);
            this.txtArticulosVendidos.Name = "txtArticulosVendidos";
            this.txtArticulosVendidos.ReadOnly = true;
            this.txtArticulosVendidos.Size = new System.Drawing.Size(127, 27);
            this.txtArticulosVendidos.TabIndex = 48;
            this.txtArticulosVendidos.Text = "0";
            this.txtArticulosVendidos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(8, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Art. Vendidos";
            // 
            // txtUtilidad
            // 
            this.txtUtilidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUtilidad.ForeColor = System.Drawing.Color.Maroon;
            this.txtUtilidad.Location = new System.Drawing.Point(1111, 471);
            this.txtUtilidad.Name = "txtUtilidad";
            this.txtUtilidad.ReadOnly = true;
            this.txtUtilidad.Size = new System.Drawing.Size(127, 30);
            this.txtUtilidad.TabIndex = 50;
            this.txtUtilidad.Text = "0.00";
            this.txtUtilidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1112, 443);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 49;
            this.label10.Text = "Utilidad $";
            // 
            // txtGastos
            // 
            this.txtGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGastos.Location = new System.Drawing.Point(967, 475);
            this.txtGastos.Name = "txtGastos";
            this.txtGastos.ReadOnly = true;
            this.txtGastos.Size = new System.Drawing.Size(127, 27);
            this.txtGastos.TabIndex = 52;
            this.txtGastos.Text = "0.00";
            this.txtGastos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(963, 444);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 21);
            this.label11.TabIndex = 51;
            this.label11.Text = "Gastos $";
            // 
            // btnImprimir
            // 
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.Image")));
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(973, 16);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(85, 44);
            this.btnImprimir.TabIndex = 57;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // Cierre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 509);
            this.Controls.Add(this.txtGastos);
            this.Controls.Add(this.label11);
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
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Datos);
            this.MaximizeBox = false;
            this.Name = "Cierre";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cierre de Caja";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fFinal;
        private System.Windows.Forms.DateTimePicker fInicial;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox ComboCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtFolio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ComboStatus;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArticulosVendidos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnCancelarProducto;
        private System.Windows.Forms.TextBox txtUtilidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtGastos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox ComboVendido;
        private System.Windows.Forms.Button btnImprimir;
    }
}