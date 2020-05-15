namespace parking_365_app.forms.security {
  partial class eliminar {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if(disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.lblTitulo = new System.Windows.Forms.Label();
      this.label18 = new System.Windows.Forms.Label();
      this.lbltexto1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.lbltextoeliminar = new System.Windows.Forms.Label();
      this.txteliminar = new System.Windows.Forms.TextBox();
      this.btnCancelar = new System.Windows.Forms.Button();
      this.btnConfirmar = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // lblTitulo
      // 
      this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
      this.lblTitulo.Dock = System.Windows.Forms.DockStyle.Top;
      this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitulo.ForeColor = System.Drawing.Color.Black;
      this.lblTitulo.Location = new System.Drawing.Point(0, 0);
      this.lblTitulo.Name = "lblTitulo";
      this.lblTitulo.Size = new System.Drawing.Size(500, 33);
      this.lblTitulo.TabIndex = 3;
      this.lblTitulo.Text = "Confirmación requerida     ";
      this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label18
      // 
      this.label18.BackColor = System.Drawing.Color.DarkRed;
      this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label18.Dock = System.Windows.Forms.DockStyle.Top;
      this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label18.Location = new System.Drawing.Point(0, 33);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(500, 2);
      this.label18.TabIndex = 15;
      // 
      // lbltexto1
      // 
      this.lbltexto1.AutoSize = true;
      this.lbltexto1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbltexto1.ForeColor = System.Drawing.Color.DarkRed;
      this.lbltexto1.Location = new System.Drawing.Point(19, 50);
      this.lbltexto1.Name = "lbltexto1";
      this.lbltexto1.Size = new System.Drawing.Size(462, 30);
      this.lbltexto1.TabIndex = 16;
      this.lbltexto1.Text = "Vas a eliminar MENU_ADMINISTRACION. \r\n¡El registro eliminado NO PUEDE ser restaur" +
    "ado! ¿Está usted ABSOLUTAMENTE seguro?";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
      this.label2.Location = new System.Drawing.Point(19, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(388, 30);
      this.label2.TabIndex = 17;
      this.label2.Text = "Esta acción puede conducir a la pérdida de datos. \r\nPara evitar acciones accident" +
    "ales, le pedimos que confirme su intención.";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.ForeColor = System.Drawing.SystemColors.WindowText;
      this.label3.Location = new System.Drawing.Point(19, 130);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(120, 15);
      this.label3.TabIndex = 18;
      this.label3.Text = "Para proceder escriba";
      // 
      // lbltextoeliminar
      // 
      this.lbltextoeliminar.AutoSize = true;
      this.lbltextoeliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lbltextoeliminar.ForeColor = System.Drawing.Color.DarkRed;
      this.lbltextoeliminar.Location = new System.Drawing.Point(140, 130);
      this.lbltextoeliminar.Name = "lbltextoeliminar";
      this.lbltextoeliminar.Size = new System.Drawing.Size(151, 15);
      this.lbltextoeliminar.TabIndex = 19;
      this.lbltextoeliminar.Text = "MENU_ADMINISTRACION";
      // 
      // txteliminar
      // 
      this.txteliminar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txteliminar.Location = new System.Drawing.Point(19, 160);
      this.txteliminar.Name = "txteliminar";
      this.txteliminar.Size = new System.Drawing.Size(462, 23);
      this.txteliminar.TabIndex = 20;
      this.txteliminar.TextChanged += new System.EventHandler(this.txteliminar_TextChanged);
      this.txteliminar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eliminar_KeyDown);
      // 
      // btnCancelar
      // 
      this.btnCancelar.BackColor = System.Drawing.Color.Blue;
      this.btnCancelar.FlatAppearance.BorderSize = 0;
      this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCancelar.ForeColor = System.Drawing.Color.White;
      this.btnCancelar.Location = new System.Drawing.Point(381, 195);
      this.btnCancelar.Name = "btnCancelar";
      this.btnCancelar.Size = new System.Drawing.Size(100, 26);
      this.btnCancelar.TabIndex = 21;
      this.btnCancelar.Text = "Cancelar";
      this.btnCancelar.UseVisualStyleBackColor = false;
      this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
      // 
      // btnConfirmar
      // 
      this.btnConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(48)))), ((int)(((byte)(44)))));
      this.btnConfirmar.Enabled = false;
      this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
      this.btnConfirmar.FlatAppearance.BorderSize = 0;
      this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.btnConfirmar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnConfirmar.ForeColor = System.Drawing.Color.White;
      this.btnConfirmar.Location = new System.Drawing.Point(275, 195);
      this.btnConfirmar.Name = "btnConfirmar";
      this.btnConfirmar.Size = new System.Drawing.Size(100, 26);
      this.btnConfirmar.TabIndex = 22;
      this.btnConfirmar.Text = "Confirmar";
      this.btnConfirmar.UseVisualStyleBackColor = false;
      this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.DarkRed;
      this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(500, 2);
      this.label1.TabIndex = 23;
      // 
      // label4
      // 
      this.label4.BackColor = System.Drawing.Color.DarkRed;
      this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label4.Location = new System.Drawing.Point(0, 228);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(500, 2);
      this.label4.TabIndex = 24;
      // 
      // label5
      // 
      this.label5.BackColor = System.Drawing.Color.DarkRed;
      this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label5.Location = new System.Drawing.Point(0, 0);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(2, 230);
      this.label5.TabIndex = 25;
      // 
      // label6
      // 
      this.label6.BackColor = System.Drawing.Color.DarkRed;
      this.label6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label6.Location = new System.Drawing.Point(498, 0);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(2, 230);
      this.label6.TabIndex = 26;
      // 
      // eliminar
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(500, 230);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnConfirmar);
      this.Controls.Add(this.btnCancelar);
      this.Controls.Add(this.txteliminar);
      this.Controls.Add(this.lbltextoeliminar);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.lbltexto1);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.lblTitulo);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "eliminar";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "eliminar";
      this.Load += new System.EventHandler(this.eliminar_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eliminar_KeyDown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Label lbltexto1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label lbltextoeliminar;
    private System.Windows.Forms.TextBox txteliminar;
    private System.Windows.Forms.Button btnCancelar;
    private System.Windows.Forms.Button btnConfirmar;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
  }
}