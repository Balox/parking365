namespace Sistema.Ventas
{
    partial class Detalles
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
            this.Datos = new System.Windows.Forms.DataGridView();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtDescuentoTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArticulosVendidos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).BeginInit();
            this.SuspendLayout();
            // 
            // Datos
            // 
            this.Datos.AllowUserToAddRows = false;
            this.Datos.AllowUserToDeleteRows = false;
            this.Datos.BackgroundColor = System.Drawing.Color.White;
            this.Datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Datos.Location = new System.Drawing.Point(2, 12);
            this.Datos.Name = "Datos";
            this.Datos.ReadOnly = true;
            this.Datos.Size = new System.Drawing.Size(1236, 251);
            this.Datos.TabIndex = 10;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotal.Location = new System.Drawing.Point(456, 309);
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
            this.txtDescuentoTotal.Location = new System.Drawing.Point(318, 312);
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
            this.txtSubtotal.Location = new System.Drawing.Point(175, 312);
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
            this.label6.Location = new System.Drawing.Point(457, 281);
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
            this.label7.Location = new System.Drawing.Point(314, 281);
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
            this.label8.Location = new System.Drawing.Point(171, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 21);
            this.label8.TabIndex = 41;
            this.label8.Text = "SubTotal $";
            // 
            // txtArticulosVendidos
            // 
            this.txtArticulosVendidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtArticulosVendidos.Location = new System.Drawing.Point(12, 312);
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
            this.label9.Location = new System.Drawing.Point(8, 281);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 21);
            this.label9.TabIndex = 47;
            this.label9.Text = "Art. Vendidos";
            // 
            // Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1243, 348);
            this.Controls.Add(this.txtArticulosVendidos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDescuentoTotal);
            this.Controls.Add(this.txtSubtotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Datos);
            this.MaximizeBox = false;
            this.Name = "Detalles";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles...";
            this.Load += new System.EventHandler(this.CatPersonal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Datos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Datos;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtDescuentoTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArticulosVendidos;
        private System.Windows.Forms.Label label9;
    }
}