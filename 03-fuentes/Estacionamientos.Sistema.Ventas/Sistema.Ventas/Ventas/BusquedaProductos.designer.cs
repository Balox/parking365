namespace Sistema.Ventas
{
    partial class BusquedaProductos
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ComboBusqueda = new System.Windows.Forms.ComboBox();
            this.txtCodigoBusqueda = new System.Windows.Forms.TextBox();
            this.txtProductoBusqueda = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.GridDatosBusqueda = new System.Windows.Forms.DataGridView();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ComboBusqueda);
            this.groupBox3.Controls.Add(this.txtCodigoBusqueda);
            this.groupBox3.Controls.Add(this.txtProductoBusqueda);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Location = new System.Drawing.Point(4, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(623, 48);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Busqueda de Productos";
            // 
            // ComboBusqueda
            // 
            this.ComboBusqueda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBusqueda.FormattingEnabled = true;
            this.ComboBusqueda.Items.AddRange(new object[] {
            "Inicia con",
            "Contiene"});
            this.ComboBusqueda.Location = new System.Drawing.Point(100, 15);
            this.ComboBusqueda.Name = "ComboBusqueda";
            this.ComboBusqueda.Size = new System.Drawing.Size(72, 21);
            this.ComboBusqueda.TabIndex = 13;
            this.ComboBusqueda.SelectedIndexChanged += new System.EventHandler(this.ComboBusqueda_SelectedIndexChanged);
            // 
            // txtCodigoBusqueda
            // 
            this.txtCodigoBusqueda.Location = new System.Drawing.Point(481, 16);
            this.txtCodigoBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigoBusqueda.Name = "txtCodigoBusqueda";
            this.txtCodigoBusqueda.Size = new System.Drawing.Size(108, 20);
            this.txtCodigoBusqueda.TabIndex = 15;
            this.txtCodigoBusqueda.TextChanged += new System.EventHandler(this.txtCodigoBusqueda_TextChanged);
            // 
            // txtProductoBusqueda
            // 
            this.txtProductoBusqueda.Location = new System.Drawing.Point(175, 16);
            this.txtProductoBusqueda.Margin = new System.Windows.Forms.Padding(2);
            this.txtProductoBusqueda.Name = "txtProductoBusqueda";
            this.txtProductoBusqueda.Size = new System.Drawing.Size(200, 20);
            this.txtProductoBusqueda.TabIndex = 11;
            this.txtProductoBusqueda.TextChanged += new System.EventHandler(this.txtProductoBusqueda_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(398, 19);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Codigo Barras :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 23);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Nombre Producto: ";
            // 
            // GridDatosBusqueda
            // 
            this.GridDatosBusqueda.AllowUserToAddRows = false;
            this.GridDatosBusqueda.AllowUserToDeleteRows = false;
            this.GridDatosBusqueda.BackgroundColor = System.Drawing.Color.White;
            this.GridDatosBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridDatosBusqueda.Location = new System.Drawing.Point(1, 60);
            this.GridDatosBusqueda.Name = "GridDatosBusqueda";
            this.GridDatosBusqueda.ReadOnly = true;
            this.GridDatosBusqueda.Size = new System.Drawing.Size(626, 323);
            this.GridDatosBusqueda.TabIndex = 18;
            this.GridDatosBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosBusqueda_CellContentClick);
            this.GridDatosBusqueda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridDatosBusqueda_CellDoubleClick);
            // 
            // BusquedaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(628, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GridDatosBusqueda);
            this.MaximizeBox = false;
            this.Name = "BusquedaProductos";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Productos...";
            this.Load += new System.EventHandler(this.BusquedaClientes_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDatosBusqueda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox ComboBusqueda;
        private System.Windows.Forms.TextBox txtCodigoBusqueda;
        private System.Windows.Forms.TextBox txtProductoBusqueda;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView GridDatosBusqueda;

    }
}