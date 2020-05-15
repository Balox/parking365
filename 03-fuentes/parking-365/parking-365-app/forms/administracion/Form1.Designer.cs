namespace parking_365_app.forms.administracion {
  partial class Form1 {
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
      this.plistado = new System.Windows.Forms.Panel();
      this.btnsearch = new System.Windows.Forms.Button();
      this.txtbuscar = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.lblresultado = new System.Windows.Forms.Label();
      this.dgvusuarios = new System.Windows.Forms.DataGridView();
      this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idperfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idzonahoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.zonahoraria = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.utc_offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.diascaducidadclave = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fechaexpiracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.fechacambioclave = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estadoregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dgclientes = new System.Windows.Forms.DataGridView();
      this.plistado.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
      this.SuspendLayout();
      // 
      // plistado
      // 
      this.plistado.Controls.Add(this.btnsearch);
      this.plistado.Controls.Add(this.txtbuscar);
      this.plistado.Controls.Add(this.label3);
      this.plistado.Controls.Add(this.lblresultado);
      this.plistado.Controls.Add(this.dgvusuarios);
      this.plistado.Location = new System.Drawing.Point(404, 29);
      this.plistado.Name = "plistado";
      this.plistado.Size = new System.Drawing.Size(824, 475);
      this.plistado.TabIndex = 37;
      // 
      // btnsearch
      // 
      this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnsearch.Image = global::parking_365_app.Properties.Resources.icons8_Search_24px;
      this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnsearch.Location = new System.Drawing.Point(271, 7);
      this.btnsearch.Name = "btnsearch";
      this.btnsearch.Size = new System.Drawing.Size(100, 35);
      this.btnsearch.TabIndex = 28;
      this.btnsearch.Text = "     &Buscar";
      this.btnsearch.UseVisualStyleBackColor = true;
      // 
      // txtbuscar
      // 
      this.txtbuscar.Location = new System.Drawing.Point(65, 15);
      this.txtbuscar.Name = "txtbuscar";
      this.txtbuscar.Size = new System.Drawing.Size(200, 20);
      this.txtbuscar.TabIndex = 27;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(12, 18);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(43, 13);
      this.label3.TabIndex = 26;
      this.label3.Text = "Usuario";
      // 
      // lblresultado
      // 
      this.lblresultado.AutoSize = true;
      this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblresultado.ForeColor = System.Drawing.Color.Black;
      this.lblresultado.Location = new System.Drawing.Point(12, 450);
      this.lblresultado.Name = "lblresultado";
      this.lblresultado.Size = new System.Drawing.Size(72, 13);
      this.lblresultado.TabIndex = 25;
      this.lblresultado.Text = "lblResultado";
      // 
      // dgvusuarios
      // 
      this.dgvusuarios.AllowUserToDeleteRows = false;
      this.dgvusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idusuario,
            this.idperfil,
            this.perfil,
            this.idzonahoraria,
            this.zonahoraria,
            this.utc_offset,
            this.nombrecompleto,
            this.usuario,
            this.email,
            this.telefono,
            this.sexo,
            this.diascaducidadclave,
            this.fechaexpiracion,
            this.fechacambioclave,
            this.estadoregistro});
      this.dgvusuarios.Location = new System.Drawing.Point(12, 50);
      this.dgvusuarios.Name = "dgvusuarios";
      this.dgvusuarios.ReadOnly = true;
      this.dgvusuarios.RowHeadersVisible = false;
      this.dgvusuarios.Size = new System.Drawing.Size(800, 390);
      this.dgvusuarios.TabIndex = 22;
      // 
      // item
      // 
      this.item.DataPropertyName = "item";
      this.item.HeaderText = "N°";
      this.item.Name = "item";
      this.item.ReadOnly = true;
      this.item.Width = 50;
      // 
      // idusuario
      // 
      this.idusuario.DataPropertyName = "idusuario";
      this.idusuario.HeaderText = "idusuario";
      this.idusuario.Name = "idusuario";
      this.idusuario.ReadOnly = true;
      this.idusuario.Visible = false;
      // 
      // idperfil
      // 
      this.idperfil.DataPropertyName = "idperfil";
      this.idperfil.HeaderText = "idperfil";
      this.idperfil.Name = "idperfil";
      this.idperfil.ReadOnly = true;
      this.idperfil.Visible = false;
      // 
      // perfil
      // 
      this.perfil.DataPropertyName = "perfil";
      this.perfil.HeaderText = "Perfil";
      this.perfil.Name = "perfil";
      this.perfil.ReadOnly = true;
      this.perfil.Width = 120;
      // 
      // idzonahoraria
      // 
      this.idzonahoraria.DataPropertyName = "idzonahoraria";
      this.idzonahoraria.HeaderText = "idzonahoraria";
      this.idzonahoraria.Name = "idzonahoraria";
      this.idzonahoraria.ReadOnly = true;
      this.idzonahoraria.Visible = false;
      // 
      // zonahoraria
      // 
      this.zonahoraria.DataPropertyName = "zonahoraria";
      this.zonahoraria.HeaderText = "zonahoraria";
      this.zonahoraria.Name = "zonahoraria";
      this.zonahoraria.ReadOnly = true;
      this.zonahoraria.Visible = false;
      // 
      // utc_offset
      // 
      this.utc_offset.DataPropertyName = "utc_offset";
      this.utc_offset.HeaderText = "utc_offset";
      this.utc_offset.Name = "utc_offset";
      this.utc_offset.ReadOnly = true;
      this.utc_offset.Visible = false;
      // 
      // nombrecompleto
      // 
      this.nombrecompleto.DataPropertyName = "nombrecompleto";
      this.nombrecompleto.HeaderText = "Nombre";
      this.nombrecompleto.Name = "nombrecompleto";
      this.nombrecompleto.ReadOnly = true;
      this.nombrecompleto.Width = 200;
      // 
      // usuario
      // 
      this.usuario.DataPropertyName = "usuario";
      this.usuario.HeaderText = "Usuario";
      this.usuario.Name = "usuario";
      this.usuario.ReadOnly = true;
      this.usuario.Width = 150;
      // 
      // email
      // 
      this.email.DataPropertyName = "email";
      this.email.HeaderText = "Email";
      this.email.Name = "email";
      this.email.ReadOnly = true;
      this.email.Width = 157;
      // 
      // telefono
      // 
      this.telefono.DataPropertyName = "telefono";
      this.telefono.HeaderText = "Teléfono";
      this.telefono.Name = "telefono";
      this.telefono.ReadOnly = true;
      this.telefono.Width = 120;
      // 
      // sexo
      // 
      this.sexo.DataPropertyName = "sexo";
      this.sexo.HeaderText = "Sexo";
      this.sexo.Name = "sexo";
      this.sexo.ReadOnly = true;
      this.sexo.Visible = false;
      // 
      // diascaducidadclave
      // 
      this.diascaducidadclave.DataPropertyName = "diascaducidadclave";
      this.diascaducidadclave.HeaderText = "diascaducidadclave";
      this.diascaducidadclave.Name = "diascaducidadclave";
      this.diascaducidadclave.ReadOnly = true;
      this.diascaducidadclave.Visible = false;
      // 
      // fechaexpiracion
      // 
      this.fechaexpiracion.DataPropertyName = "fechaexpiracion";
      this.fechaexpiracion.HeaderText = "fechaexpiracion";
      this.fechaexpiracion.Name = "fechaexpiracion";
      this.fechaexpiracion.ReadOnly = true;
      this.fechaexpiracion.Visible = false;
      // 
      // fechacambioclave
      // 
      this.fechacambioclave.DataPropertyName = "fechacambioclave";
      this.fechacambioclave.HeaderText = "fechacambioclave";
      this.fechacambioclave.Name = "fechacambioclave";
      this.fechacambioclave.ReadOnly = true;
      this.fechacambioclave.Visible = false;
      // 
      // estadoregistro
      // 
      this.estadoregistro.DataPropertyName = "estadoregistro";
      this.estadoregistro.HeaderText = "estadoregistro";
      this.estadoregistro.Name = "estadoregistro";
      this.estadoregistro.ReadOnly = true;
      this.estadoregistro.Visible = false;
      // 
      // dgclientes
      // 
      this.dgclientes.AllowUserToAddRows = false;
      this.dgclientes.AllowUserToDeleteRows = false;
      this.dgclientes.AllowUserToResizeColumns = false;
      this.dgclientes.AllowUserToResizeRows = false;
      this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgclientes.Location = new System.Drawing.Point(33, 58);
      this.dgclientes.MultiSelect = false;
      this.dgclientes.Name = "dgclientes";
      this.dgclientes.ReadOnly = true;
      this.dgclientes.RowHeadersVisible = false;
      this.dgclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgclientes.Size = new System.Drawing.Size(341, 262);
      this.dgclientes.TabIndex = 29;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1370, 505);
      this.Controls.Add(this.dgclientes);
      this.Controls.Add(this.plistado);
      this.Name = "Form1";
      this.Text = "Form1";
      this.plistado.ResumeLayout(false);
      this.plistado.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvusuarios)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Panel plistado;
    private System.Windows.Forms.Button btnsearch;
    private System.Windows.Forms.TextBox txtbuscar;
    private System.Windows.Forms.Label label3;
    internal System.Windows.Forms.Label lblresultado;
    private System.Windows.Forms.DataGridView dgvusuarios;
    private System.Windows.Forms.DataGridViewTextBoxColumn item;
    private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn idperfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn idzonahoraria;
    private System.Windows.Forms.DataGridViewTextBoxColumn zonahoraria;
    private System.Windows.Forms.DataGridViewTextBoxColumn utc_offset;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
    private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    private System.Windows.Forms.DataGridViewTextBoxColumn diascaducidadclave;
    private System.Windows.Forms.DataGridViewTextBoxColumn fechaexpiracion;
    private System.Windows.Forms.DataGridViewTextBoxColumn fechacambioclave;
    private System.Windows.Forms.DataGridViewTextBoxColumn estadoregistro;
    private System.Windows.Forms.DataGridView dgclientes;
  }
}