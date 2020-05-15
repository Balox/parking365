namespace Sistema.Ventas
{
    partial class Recargas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Recargas));
            this.ComboCompañia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtConfirmaTelefono = new System.Windows.Forms.TextBox();
            this.ComboMonto = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRecargar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.btnConsultarSaldo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ComboCompañia
            // 
            this.ComboCompañia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboCompañia.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboCompañia.FormattingEnabled = true;
            this.ComboCompañia.Location = new System.Drawing.Point(200, 16);
            this.ComboCompañia.Name = "ComboCompañia";
            this.ComboCompañia.Size = new System.Drawing.Size(190, 39);
            this.ComboCompañia.TabIndex = 0;
            this.ComboCompañia.SelectedIndexChanged += new System.EventHandler(this.ComboCompañia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(81, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Compañia :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Teléfono :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Confirmar Teléfono :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(116, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Monto :";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(200, 75);
            this.txtTelefono.MaxLength = 10;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(190, 38);
            this.txtTelefono.TabIndex = 5;
            // 
            // txtConfirmaTelefono
            // 
            this.txtConfirmaTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmaTelefono.Location = new System.Drawing.Point(200, 130);
            this.txtConfirmaTelefono.MaxLength = 10;
            this.txtConfirmaTelefono.Name = "txtConfirmaTelefono";
            this.txtConfirmaTelefono.PasswordChar = '*';
            this.txtConfirmaTelefono.ShortcutsEnabled = false;
            this.txtConfirmaTelefono.Size = new System.Drawing.Size(190, 38);
            this.txtConfirmaTelefono.TabIndex = 6;
            // 
            // ComboMonto
            // 
            this.ComboMonto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboMonto.DropDownWidth = 600;
            this.ComboMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboMonto.FormattingEnabled = true;
            this.ComboMonto.Location = new System.Drawing.Point(200, 197);
            this.ComboMonto.Name = "ComboMonto";
            this.ComboMonto.Size = new System.Drawing.Size(190, 24);
            this.ComboMonto.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRecargar);
            this.groupBox1.Controls.Add(this.ComboCompañia);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ComboMonto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtConfirmaTelefono);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(1, 124);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(398, 277);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recarga";
            // 
            // btnRecargar
            // 
            this.btnRecargar.Image = ((System.Drawing.Image)(resources.GetObject("btnRecargar.Image")));
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecargar.Location = new System.Drawing.Point(200, 228);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(86, 37);
            this.btnRecargar.TabIndex = 60;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.UseVisualStyleBackColor = true;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSaldo);
            this.groupBox2.Controls.Add(this.btnConsultarSaldo);
            this.groupBox2.Location = new System.Drawing.Point(405, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(167, 114);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Saldo disponible";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(6, 21);
            this.txtSaldo.MaxLength = 10;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(152, 38);
            this.txtSaldo.TabIndex = 62;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConsultarSaldo
            // 
            this.btnConsultarSaldo.Image = ((System.Drawing.Image)(resources.GetObject("btnConsultarSaldo.Image")));
            this.btnConsultarSaldo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultarSaldo.Location = new System.Drawing.Point(22, 65);
            this.btnConsultarSaldo.Name = "btnConsultarSaldo";
            this.btnConsultarSaldo.Size = new System.Drawing.Size(117, 37);
            this.btnConsultarSaldo.TabIndex = 61;
            this.btnConsultarSaldo.Text = "$ Consultar Saldo";
            this.btnConsultarSaldo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsultarSaldo.UseVisualStyleBackColor = true;
            this.btnConsultarSaldo.Click += new System.EventHandler(this.btnConsultarSaldo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(571, 120);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // Recargas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(574, 403);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Recargas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Recarga de tiempo aire";
            this.Load += new System.EventHandler(this.Recargas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboCompañia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtConfirmaTelefono;
        private System.Windows.Forms.ComboBox ComboMonto;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRecargar;
        private System.Windows.Forms.Button btnConsultarSaldo;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.PictureBox pictureBox1;

    }
}