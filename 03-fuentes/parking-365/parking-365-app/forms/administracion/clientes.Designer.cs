namespace parking_365_app.forms.administracion {
  partial class clientes {
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
      this.pbotones = new System.Windows.Forms.Panel();
      this.label1 = new System.Windows.Forms.Label();
      this.btndelete = new System.Windows.Forms.Button();
      this.btnedit = new System.Windows.Forms.Button();
      this.btnnew = new System.Windows.Forms.Button();
      this.pcontenido = new System.Windows.Forms.Panel();
      this.dgclientes = new System.Windows.Forms.DataGridView();
      this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idcliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idtipocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tipocliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idtipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.tipodocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.documento = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.representante = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.observacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.vehiculos = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estadoregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idusuariocrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.btnClean = new System.Windows.Forms.Button();
      this.lblresultado = new System.Windows.Forms.Label();
      this.btnsearch = new System.Windows.Forms.Button();
      this.txtdocumento = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.pbotones.SuspendLayout();
      this.pcontenido.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).BeginInit();
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
      this.lblTitulo.Size = new System.Drawing.Size(824, 33);
      this.lblTitulo.TabIndex = 3;
      this.lblTitulo.Text = "Administrar Clientes     ";
      this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label18
      // 
      this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label18.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label18.Dock = System.Windows.Forms.DockStyle.Top;
      this.label18.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label18.Location = new System.Drawing.Point(0, 33);
      this.label18.Name = "label18";
      this.label18.Size = new System.Drawing.Size(824, 2);
      this.label18.TabIndex = 15;
      // 
      // pbotones
      // 
      this.pbotones.Controls.Add(this.label1);
      this.pbotones.Controls.Add(this.btndelete);
      this.pbotones.Controls.Add(this.btnedit);
      this.pbotones.Controls.Add(this.btnnew);
      this.pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pbotones.Location = new System.Drawing.Point(0, 510);
      this.pbotones.Name = "pbotones";
      this.pbotones.Size = new System.Drawing.Size(824, 50);
      this.pbotones.TabIndex = 29;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.label1.Dock = System.Windows.Forms.DockStyle.Top;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(204)))), ((int)(((byte)(115)))));
      this.label1.Location = new System.Drawing.Point(0, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(824, 2);
      this.label1.TabIndex = 15;
      // 
      // btndelete
      // 
      this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btndelete.Image = global::parking_365_app.Properties.Resources.icons8_Trash_Can_24px;
      this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btndelete.Location = new System.Drawing.Point(712, 8);
      this.btndelete.Name = "btndelete";
      this.btndelete.Size = new System.Drawing.Size(100, 35);
      this.btndelete.TabIndex = 3;
      this.btndelete.Text = "     E&liminar";
      this.btndelete.UseVisualStyleBackColor = true;
      this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
      // 
      // btnedit
      // 
      this.btnedit.Enabled = false;
      this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnedit.Image = global::parking_365_app.Properties.Resources.icons8_Edit_File_24px;
      this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnedit.Location = new System.Drawing.Point(606, 8);
      this.btnedit.Name = "btnedit";
      this.btnedit.Size = new System.Drawing.Size(100, 35);
      this.btnedit.TabIndex = 1;
      this.btnedit.Text = "     &Editar";
      this.btnedit.UseVisualStyleBackColor = true;
      this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
      // 
      // btnnew
      // 
      this.btnnew.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnnew.Image = global::parking_365_app.Properties.Resources.icons8_Add_File_24px;
      this.btnnew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnnew.Location = new System.Drawing.Point(500, 8);
      this.btnnew.Name = "btnnew";
      this.btnnew.Size = new System.Drawing.Size(100, 35);
      this.btnnew.TabIndex = 0;
      this.btnnew.Text = "     &Nuevo";
      this.btnnew.UseVisualStyleBackColor = true;
      this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
      // 
      // pcontenido
      // 
      this.pcontenido.BackColor = System.Drawing.Color.Silver;
      this.pcontenido.Controls.Add(this.dgclientes);
      this.pcontenido.Controls.Add(this.btnClean);
      this.pcontenido.Controls.Add(this.lblresultado);
      this.pcontenido.Controls.Add(this.btnsearch);
      this.pcontenido.Controls.Add(this.txtdocumento);
      this.pcontenido.Controls.Add(this.label2);
      this.pcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pcontenido.Location = new System.Drawing.Point(0, 35);
      this.pcontenido.Name = "pcontenido";
      this.pcontenido.Size = new System.Drawing.Size(824, 475);
      this.pcontenido.TabIndex = 30;
      // 
      // dgclientes
      // 
      this.dgclientes.AllowUserToAddRows = false;
      this.dgclientes.AllowUserToDeleteRows = false;
      this.dgclientes.AllowUserToResizeColumns = false;
      this.dgclientes.AllowUserToResizeRows = false;
      this.dgclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idcliente,
            this.idtipocliente,
            this.tipocliente,
            this.idtipodocumento,
            this.tipodocumento,
            this.documento,
            this.nombre,
            this.representante,
            this.telefono,
            this.email,
            this.observacion,
            this.vehiculos,
            this.estadoregistro,
            this.idusuariocrea});
      this.dgclientes.Location = new System.Drawing.Point(22, 59);
      this.dgclientes.MultiSelect = false;
      this.dgclientes.Name = "dgclientes";
      this.dgclientes.ReadOnly = true;
      this.dgclientes.RowHeadersVisible = false;
      this.dgclientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgclientes.Size = new System.Drawing.Size(780, 380);
      this.dgclientes.TabIndex = 3;
      // 
      // item
      // 
      this.item.DataPropertyName = "item";
      this.item.HeaderText = "N°";
      this.item.Name = "item";
      this.item.ReadOnly = true;
      this.item.Width = 30;
      // 
      // idcliente
      // 
      this.idcliente.DataPropertyName = "idcliente";
      this.idcliente.HeaderText = "idcliente";
      this.idcliente.Name = "idcliente";
      this.idcliente.ReadOnly = true;
      this.idcliente.Visible = false;
      // 
      // idtipocliente
      // 
      this.idtipocliente.DataPropertyName = "idtipocliente";
      this.idtipocliente.HeaderText = "idtipocliente";
      this.idtipocliente.Name = "idtipocliente";
      this.idtipocliente.ReadOnly = true;
      this.idtipocliente.Visible = false;
      // 
      // tipocliente
      // 
      this.tipocliente.DataPropertyName = "tipocliente";
      this.tipocliente.HeaderText = "Tipo Cliente";
      this.tipocliente.Name = "tipocliente";
      this.tipocliente.ReadOnly = true;
      this.tipocliente.Width = 117;
      // 
      // idtipodocumento
      // 
      this.idtipodocumento.DataPropertyName = "idtipodocumento";
      this.idtipodocumento.HeaderText = "idtipodocumento";
      this.idtipodocumento.Name = "idtipodocumento";
      this.idtipodocumento.ReadOnly = true;
      this.idtipodocumento.Visible = false;
      // 
      // tipodocumento
      // 
      this.tipodocumento.DataPropertyName = "tipodocumento";
      this.tipodocumento.HeaderText = "tipodocumento";
      this.tipodocumento.Name = "tipodocumento";
      this.tipodocumento.ReadOnly = true;
      this.tipodocumento.Visible = false;
      // 
      // documento
      // 
      this.documento.DataPropertyName = "documento";
      this.documento.HeaderText = "Documento";
      this.documento.Name = "documento";
      this.documento.ReadOnly = true;
      // 
      // nombre
      // 
      this.nombre.DataPropertyName = "nombre";
      this.nombre.HeaderText = "Cliente";
      this.nombre.Name = "nombre";
      this.nombre.ReadOnly = true;
      this.nombre.Width = 210;
      // 
      // representante
      // 
      this.representante.DataPropertyName = "representante";
      this.representante.HeaderText = "representante";
      this.representante.Name = "representante";
      this.representante.ReadOnly = true;
      this.representante.Visible = false;
      // 
      // telefono
      // 
      this.telefono.DataPropertyName = "telefono";
      this.telefono.HeaderText = "Teléfono";
      this.telefono.Name = "telefono";
      this.telefono.ReadOnly = true;
      this.telefono.Width = 80;
      // 
      // email
      // 
      this.email.DataPropertyName = "email";
      this.email.HeaderText = "Email";
      this.email.Name = "email";
      this.email.ReadOnly = true;
      this.email.Width = 120;
      // 
      // observacion
      // 
      this.observacion.DataPropertyName = "observacion";
      this.observacion.HeaderText = "observacion";
      this.observacion.Name = "observacion";
      this.observacion.ReadOnly = true;
      this.observacion.Visible = false;
      // 
      // vehiculos
      // 
      this.vehiculos.DataPropertyName = "vehiculos";
      this.vehiculos.HeaderText = "Vehículos";
      this.vehiculos.Name = "vehiculos";
      this.vehiculos.ReadOnly = true;
      this.vehiculos.Width = 60;
      // 
      // estadoregistro
      // 
      this.estadoregistro.DataPropertyName = "estadoregistro";
      this.estadoregistro.HeaderText = "Estado";
      this.estadoregistro.Name = "estadoregistro";
      this.estadoregistro.ReadOnly = true;
      this.estadoregistro.Width = 60;
      // 
      // idusuariocrea
      // 
      this.idusuariocrea.DataPropertyName = "idusuariocrea";
      this.idusuariocrea.HeaderText = "idusuariocrea";
      this.idusuariocrea.Name = "idusuariocrea";
      this.idusuariocrea.ReadOnly = true;
      this.idusuariocrea.Visible = false;
      // 
      // btnClean
      // 
      this.btnClean.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnClean.Image = global::parking_365_app.Properties.Resources.icons8_Broom_24px_1;
      this.btnClean.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnClean.Location = new System.Drawing.Point(456, 12);
      this.btnClean.Name = "btnClean";
      this.btnClean.Size = new System.Drawing.Size(100, 35);
      this.btnClean.TabIndex = 5;
      this.btnClean.Text = "     &Limpiar";
      this.btnClean.UseVisualStyleBackColor = true;
      this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
      // 
      // lblresultado
      // 
      this.lblresultado.AutoSize = true;
      this.lblresultado.Font = new System.Drawing.Font("Segoe UI", 7.25F, System.Drawing.FontStyle.Bold);
      this.lblresultado.ForeColor = System.Drawing.Color.Navy;
      this.lblresultado.Location = new System.Drawing.Point(12, 450);
      this.lblresultado.Name = "lblresultado";
      this.lblresultado.Size = new System.Drawing.Size(175, 12);
      this.lblresultado.TabIndex = 4;
      this.lblresultado.Text = "Número de registros encontrados: 0.";
      // 
      // btnsearch
      // 
      this.btnsearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnsearch.Image = global::parking_365_app.Properties.Resources.icons8_Search_24px;
      this.btnsearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnsearch.Location = new System.Drawing.Point(350, 12);
      this.btnsearch.Name = "btnsearch";
      this.btnsearch.Size = new System.Drawing.Size(100, 35);
      this.btnsearch.TabIndex = 2;
      this.btnsearch.Text = "     &Buscar";
      this.btnsearch.UseVisualStyleBackColor = true;
      this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
      // 
      // txtdocumento
      // 
      this.txtdocumento.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtdocumento.Location = new System.Drawing.Point(144, 19);
      this.txtdocumento.MaxLength = 30;
      this.txtdocumento.Name = "txtdocumento";
      this.txtdocumento.Size = new System.Drawing.Size(200, 23);
      this.txtdocumento.TabIndex = 1;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(24, 22);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(114, 15);
      this.label2.TabIndex = 0;
      this.label2.Text = "Ingresar documento";
      // 
      // clientes
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(824, 560);
      this.Controls.Add(this.pcontenido);
      this.Controls.Add(this.pbotones);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.lblTitulo);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "clientes";
      this.Text = "clientes";
      this.Load += new System.EventHandler(this.clientes_Load);
      this.pbotones.ResumeLayout(false);
      this.pcontenido.ResumeLayout(false);
      this.pcontenido.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgclientes)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    internal System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Panel pbotones;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btndelete;
    private System.Windows.Forms.Button btnedit;
    private System.Windows.Forms.Button btnnew;
    private System.Windows.Forms.Panel pcontenido;
    private System.Windows.Forms.Button btnsearch;
    private System.Windows.Forms.TextBox txtdocumento;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label lblresultado;
    private System.Windows.Forms.DataGridView dgclientes;
    private System.Windows.Forms.Button btnClean;
    private System.Windows.Forms.DataGridViewTextBoxColumn item;
    private System.Windows.Forms.DataGridViewTextBoxColumn idcliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn idtipocliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn tipocliente;
    private System.Windows.Forms.DataGridViewTextBoxColumn idtipodocumento;
    private System.Windows.Forms.DataGridViewTextBoxColumn tipodocumento;
    private System.Windows.Forms.DataGridViewTextBoxColumn documento;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
    private System.Windows.Forms.DataGridViewTextBoxColumn representante;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn observacion;
    private System.Windows.Forms.DataGridViewTextBoxColumn vehiculos;
    private System.Windows.Forms.DataGridViewTextBoxColumn estadoregistro;
    private System.Windows.Forms.DataGridViewTextBoxColumn idusuariocrea;
  }
}