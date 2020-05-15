namespace parking_365_app.forms.administracion {
  partial class mttocliente {
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
      this.Label38 = new System.Windows.Forms.Label();
      this.txtobservacion = new System.Windows.Forms.TextBox();
      this.label6 = new System.Windows.Forms.Label();
      this.txtemail = new System.Windows.Forms.TextBox();
      this.label5 = new System.Windows.Forms.Label();
      this.txttelefono = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.txtrepresentante = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtnombre = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtdocumento = new System.Windows.Forms.TextBox();
      this.rbjuridica = new System.Windows.Forms.RadioButton();
      this.rbNatural = new System.Windows.Forms.RadioButton();
      this.pbotones = new System.Windows.Forms.Panel();
      this.label7 = new System.Windows.Forms.Label();
      this.btncancel = new System.Windows.Forms.Button();
      this.btnsave = new System.Windows.Forms.Button();
      this.pbotones.SuspendLayout();
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
      this.lblTitulo.Size = new System.Drawing.Size(400, 28);
      this.lblTitulo.TabIndex = 4;
      this.lblTitulo.Text = "Nuevo Cliente     ";
      this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label18
      // 
      this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label18.Dock = System.Windows.Forms.DockStyle.Top;
      this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label18.Location = new System.Drawing.Point(0, 28);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(400, 2);
      this.label18.TabIndex = 16;
      // 
      // Label38
      // 
      this.Label38.AutoSize = true;
      this.Label38.BackColor = System.Drawing.Color.Transparent;
      this.Label38.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
      this.Label38.ForeColor = System.Drawing.Color.DarkRed;
      this.Label38.Location = new System.Drawing.Point(8, 8);
      this.Label38.Name = "Label38";
      this.Label38.Size = new System.Drawing.Size(51, 12);
      this.Label38.TabIndex = 17;
      this.Label38.Text = "Salir (Esc)";
      // 
      // txtobservacion
      // 
      this.txtobservacion.Location = new System.Drawing.Point(154, 233);
      this.txtobservacion.Multiline = true;
      this.txtobservacion.Name = "txtobservacion";
      this.txtobservacion.Size = new System.Drawing.Size(230, 66);
      this.txtobservacion.TabIndex = 7;
      this.txtobservacion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(16, 236);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(71, 13);
      this.label6.TabIndex = 30;
      this.label6.Text = "Observación";
      // 
      // txtemail
      // 
      this.txtemail.Location = new System.Drawing.Point(154, 203);
      this.txtemail.Name = "txtemail";
      this.txtemail.Size = new System.Drawing.Size(230, 22);
      this.txtemail.TabIndex = 6;
      this.txtemail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(16, 206);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(102, 13);
      this.label5.TabIndex = 28;
      this.label5.Text = "Correo electrónico";
      // 
      // txttelefono
      // 
      this.txttelefono.Location = new System.Drawing.Point(154, 173);
      this.txttelefono.Name = "txttelefono";
      this.txttelefono.Size = new System.Drawing.Size(230, 22);
      this.txttelefono.TabIndex = 5;
      this.txttelefono.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(16, 176);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(51, 13);
      this.label4.TabIndex = 26;
      this.label4.Text = "Teléfono";
      // 
      // txtrepresentante
      // 
      this.txtrepresentante.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtrepresentante.Location = new System.Drawing.Point(154, 143);
      this.txtrepresentante.Name = "txtrepresentante";
      this.txtrepresentante.Size = new System.Drawing.Size(230, 22);
      this.txtrepresentante.TabIndex = 4;
      this.txtrepresentante.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(16, 146);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(82, 13);
      this.label3.TabIndex = 24;
      this.label3.Text = "Representante";
      // 
      // txtnombre
      // 
      this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtnombre.Location = new System.Drawing.Point(154, 113);
      this.txtnombre.Name = "txtnombre";
      this.txtnombre.Size = new System.Drawing.Size(230, 22);
      this.txtnombre.TabIndex = 3;
      this.txtnombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(16, 116);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(48, 13);
      this.label2.TabIndex = 22;
      this.label2.Text = "Nombre";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(16, 86);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(126, 13);
      this.label1.TabIndex = 21;
      this.label1.Text = "Número de documento";
      // 
      // txtdocumento
      // 
      this.txtdocumento.Location = new System.Drawing.Point(154, 83);
      this.txtdocumento.Name = "txtdocumento";
      this.txtdocumento.Size = new System.Drawing.Size(230, 22);
      this.txtdocumento.TabIndex = 2;
      this.txtdocumento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // rbjuridica
      // 
      this.rbjuridica.AutoSize = true;
      this.rbjuridica.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbjuridica.Location = new System.Drawing.Point(223, 45);
      this.rbjuridica.Name = "rbjuridica";
      this.rbjuridica.Size = new System.Drawing.Size(110, 17);
      this.rbjuridica.TabIndex = 1;
      this.rbjuridica.Text = "Persona Jurídica";
      this.rbjuridica.UseVisualStyleBackColor = true;
      this.rbjuridica.CheckedChanged += new System.EventHandler(this.rbNatural_CheckedChanged);
      this.rbjuridica.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // rbNatural
      // 
      this.rbNatural.AutoSize = true;
      this.rbNatural.Checked = true;
      this.rbNatural.FlatAppearance.BorderColor = System.Drawing.Color.Red;
      this.rbNatural.FlatAppearance.BorderSize = 2;
      this.rbNatural.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rbNatural.Location = new System.Drawing.Point(67, 45);
      this.rbNatural.Name = "rbNatural";
      this.rbNatural.Size = new System.Drawing.Size(109, 17);
      this.rbNatural.TabIndex = 0;
      this.rbNatural.TabStop = true;
      this.rbNatural.Text = "Persona Natural";
      this.rbNatural.UseVisualStyleBackColor = true;
      this.rbNatural.CheckedChanged += new System.EventHandler(this.rbNatural_CheckedChanged);
      this.rbNatural.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // pbotones
      // 
      this.pbotones.Controls.Add(this.label7);
      this.pbotones.Controls.Add(this.btncancel);
      this.pbotones.Controls.Add(this.btnsave);
      this.pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pbotones.Location = new System.Drawing.Point(0, 321);
      this.pbotones.Name = "pbotones";
      this.pbotones.Size = new System.Drawing.Size(400, 40);
      this.pbotones.TabIndex = 8;
      // 
      // label7
      // 
      this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label7.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label7.Dock = System.Windows.Forms.DockStyle.Top;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label7.Location = new System.Drawing.Point(0, 0);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(400, 2);
      this.label7.TabIndex = 15;
      // 
      // btncancel
      // 
      this.btncancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btncancel.Image = global::parking_365_app.Properties.Resources.icons8_Unavailable_20px;
      this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btncancel.Location = new System.Drawing.Point(296, 7);
      this.btncancel.Name = "btncancel";
      this.btncancel.Size = new System.Drawing.Size(92, 28);
      this.btncancel.TabIndex = 1;
      this.btncancel.Text = "     &Cancelar";
      this.btncancel.UseVisualStyleBackColor = true;
      this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
      this.btncancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // btnsave
      // 
      this.btnsave.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnsave.Image = global::parking_365_app.Properties.Resources.icons8_Save_20px;
      this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnsave.Location = new System.Drawing.Point(198, 7);
      this.btnsave.Name = "btnsave";
      this.btnsave.Size = new System.Drawing.Size(92, 28);
      this.btnsave.TabIndex = 0;
      this.btnsave.Text = "     &Guardar";
      this.btnsave.UseVisualStyleBackColor = true;
      this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
      this.btnsave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      // 
      // mttocliente
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(400, 361);
      this.Controls.Add(this.pbotones);
      this.Controls.Add(this.txtobservacion);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.txtemail);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.txttelefono);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.txtrepresentante);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtnombre);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtdocumento);
      this.Controls.Add(this.rbjuridica);
      this.Controls.Add(this.rbNatural);
      this.Controls.Add(this.Label38);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.lblTitulo);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "mttocliente";
      this.ShowIcon = false;
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "mttocliente";
      this.Load += new System.EventHandler(this.mttocliente_Load);
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.mttocliente_KeyDown);
      this.pbotones.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    internal System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label label18;
    internal System.Windows.Forms.Label Label38;
    private System.Windows.Forms.TextBox txtobservacion;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.TextBox txtemail;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.TextBox txttelefono;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.TextBox txtrepresentante;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtnombre;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtdocumento;
    private System.Windows.Forms.RadioButton rbjuridica;
    private System.Windows.Forms.RadioButton rbNatural;
    private System.Windows.Forms.Panel pbotones;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Button btncancel;
    private System.Windows.Forms.Button btnsave;
  }
}