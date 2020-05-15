namespace parking_365_app.forms.administracion {
  partial class usuarios {
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
      this.btncancel = new System.Windows.Forms.Button();
      this.btndelete = new System.Windows.Forms.Button();
      this.btnsave = new System.Windows.Forms.Button();
      this.btnedit = new System.Windows.Forms.Button();
      this.btnnew = new System.Windows.Forms.Button();
      this.dgusuarios = new System.Windows.Forms.DataGridView();
      this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idusuariocrea = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idusuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.idperfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.nombrecompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saltsecret = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.estadoregistro = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.label2 = new System.Windows.Forms.Label();
      this.pcontenido = new System.Windows.Forms.Panel();
      this.label3 = new System.Windows.Forms.Label();
      this.pdatos = new System.Windows.Forms.Panel();
      this.txtconfirmacion = new System.Windows.Forms.TextBox();
      this.txtclave = new System.Windows.Forms.TextBox();
      this.txttelefono = new System.Windows.Forms.TextBox();
      this.txtusuario = new System.Windows.Forms.TextBox();
      this.txtemail = new System.Windows.Forms.TextBox();
      this.cboperfil = new System.Windows.Forms.ComboBox();
      this.label8 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label10 = new System.Windows.Forms.Label();
      this.txtnombre = new System.Windows.Forms.TextBox();
      this.label11 = new System.Windows.Forms.Label();
      this.pbotones.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).BeginInit();
      this.pcontenido.SuspendLayout();
      this.pdatos.SuspendLayout();
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
      this.lblTitulo.TabIndex = 2;
      this.lblTitulo.Text = "Administrar Usuarios     ";
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
      this.label18.TabIndex = 14;
      // 
      // pbotones
      // 
      this.pbotones.Controls.Add(this.label1);
      this.pbotones.Controls.Add(this.btncancel);
      this.pbotones.Controls.Add(this.btndelete);
      this.pbotones.Controls.Add(this.btnsave);
      this.pbotones.Controls.Add(this.btnedit);
      this.pbotones.Controls.Add(this.btnnew);
      this.pbotones.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.pbotones.Location = new System.Drawing.Point(0, 510);
      this.pbotones.Name = "pbotones";
      this.pbotones.Size = new System.Drawing.Size(824, 50);
      this.pbotones.TabIndex = 28;
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
      // btncancel
      // 
      this.btncancel.Enabled = false;
      this.btncancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btncancel.Image = global::parking_365_app.Properties.Resources.icons8_Unavailable_24px;
      this.btncancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btncancel.Location = new System.Drawing.Point(712, 8);
      this.btncancel.Name = "btncancel";
      this.btncancel.Size = new System.Drawing.Size(100, 35);
      this.btncancel.TabIndex = 4;
      this.btncancel.Text = "     &Cancelar";
      this.btncancel.UseVisualStyleBackColor = true;
      this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
      // 
      // btndelete
      // 
      this.btndelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btndelete.Image = global::parking_365_app.Properties.Resources.icons8_Trash_Can_24px;
      this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btndelete.Location = new System.Drawing.Point(606, 8);
      this.btndelete.Name = "btndelete";
      this.btndelete.Size = new System.Drawing.Size(100, 35);
      this.btndelete.TabIndex = 3;
      this.btndelete.Text = "     E&liminar";
      this.btndelete.UseVisualStyleBackColor = true;
      this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
      // 
      // btnsave
      // 
      this.btnsave.Enabled = false;
      this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnsave.Image = global::parking_365_app.Properties.Resources.icons8_Save_24px;
      this.btnsave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnsave.Location = new System.Drawing.Point(500, 8);
      this.btnsave.Name = "btnsave";
      this.btnsave.Size = new System.Drawing.Size(100, 35);
      this.btnsave.TabIndex = 2;
      this.btnsave.Text = "     &Guardar";
      this.btnsave.UseVisualStyleBackColor = true;
      this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
      // 
      // btnedit
      // 
      this.btnedit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnedit.Image = global::parking_365_app.Properties.Resources.icons8_Edit_File_24px;
      this.btnedit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnedit.Location = new System.Drawing.Point(394, 8);
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
      this.btnnew.Location = new System.Drawing.Point(288, 8);
      this.btnnew.Name = "btnnew";
      this.btnnew.Size = new System.Drawing.Size(100, 35);
      this.btnnew.TabIndex = 0;
      this.btnnew.Text = "     &Nuevo";
      this.btnnew.UseVisualStyleBackColor = true;
      this.btnnew.Click += new System.EventHandler(this.btnnew_Click);
      // 
      // dgusuarios
      // 
      this.dgusuarios.AllowUserToAddRows = false;
      this.dgusuarios.AllowUserToDeleteRows = false;
      this.dgusuarios.AllowUserToResizeColumns = false;
      this.dgusuarios.AllowUserToResizeRows = false;
      this.dgusuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgusuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.item,
            this.idusuariocrea,
            this.idusuario,
            this.idperfil,
            this.perfil,
            this.nombrecompleto,
            this.email,
            this.telefono,
            this.sexo,
            this.usuario,
            this.clave,
            this.saltsecret,
            this.estadoregistro});
      this.dgusuarios.Location = new System.Drawing.Point(12, 40);
      this.dgusuarios.MultiSelect = false;
      this.dgusuarios.Name = "dgusuarios";
      this.dgusuarios.ReadOnly = true;
      this.dgusuarios.RowHeadersVisible = false;
      this.dgusuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dgusuarios.Size = new System.Drawing.Size(420, 420);
      this.dgusuarios.TabIndex = 0;
      this.dgusuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgusuarios_CellClick);
      // 
      // item
      // 
      this.item.DataPropertyName = "item";
      this.item.HeaderText = "N°";
      this.item.Name = "item";
      this.item.ReadOnly = true;
      this.item.Width = 40;
      // 
      // idusuariocrea
      // 
      this.idusuariocrea.DataPropertyName = "idusuariocrea";
      this.idusuariocrea.HeaderText = "idusuariocrea";
      this.idusuariocrea.Name = "idusuariocrea";
      this.idusuariocrea.ReadOnly = true;
      this.idusuariocrea.Visible = false;
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
      // 
      // nombrecompleto
      // 
      this.nombrecompleto.DataPropertyName = "nombrecompleto";
      this.nombrecompleto.HeaderText = "Nombre";
      this.nombrecompleto.Name = "nombrecompleto";
      this.nombrecompleto.ReadOnly = true;
      this.nombrecompleto.Width = 150;
      // 
      // email
      // 
      this.email.DataPropertyName = "email";
      this.email.HeaderText = "email";
      this.email.Name = "email";
      this.email.ReadOnly = true;
      this.email.Visible = false;
      // 
      // telefono
      // 
      this.telefono.DataPropertyName = "telefono";
      this.telefono.HeaderText = "telefono";
      this.telefono.Name = "telefono";
      this.telefono.ReadOnly = true;
      this.telefono.Visible = false;
      // 
      // sexo
      // 
      this.sexo.DataPropertyName = "sexo";
      this.sexo.HeaderText = "sexo";
      this.sexo.Name = "sexo";
      this.sexo.ReadOnly = true;
      this.sexo.Visible = false;
      // 
      // usuario
      // 
      this.usuario.DataPropertyName = "usuario";
      this.usuario.HeaderText = "Usuario";
      this.usuario.Name = "usuario";
      this.usuario.ReadOnly = true;
      this.usuario.Width = 127;
      // 
      // clave
      // 
      this.clave.DataPropertyName = "clave";
      this.clave.HeaderText = "clave";
      this.clave.Name = "clave";
      this.clave.ReadOnly = true;
      this.clave.Visible = false;
      // 
      // saltsecret
      // 
      this.saltsecret.DataPropertyName = "saltsecret";
      this.saltsecret.HeaderText = "saltsecret";
      this.saltsecret.Name = "saltsecret";
      this.saltsecret.ReadOnly = true;
      this.saltsecret.Visible = false;
      // 
      // estadoregistro
      // 
      this.estadoregistro.DataPropertyName = "estadoregistro";
      this.estadoregistro.HeaderText = "Estado";
      this.estadoregistro.Name = "estadoregistro";
      this.estadoregistro.ReadOnly = true;
      this.estadoregistro.Visible = false;
      this.estadoregistro.Width = 50;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(15, 15);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(97, 15);
      this.label2.TabIndex = 1;
      this.label2.Text = "Lista de usuarios";
      // 
      // pcontenido
      // 
      this.pcontenido.BackColor = System.Drawing.Color.Silver;
      this.pcontenido.Controls.Add(this.label3);
      this.pcontenido.Controls.Add(this.pdatos);
      this.pcontenido.Controls.Add(this.label2);
      this.pcontenido.Controls.Add(this.dgusuarios);
      this.pcontenido.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pcontenido.Location = new System.Drawing.Point(0, 35);
      this.pcontenido.Name = "pcontenido";
      this.pcontenido.Size = new System.Drawing.Size(824, 475);
      this.pcontenido.TabIndex = 29;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label3.Location = new System.Drawing.Point(445, 15);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(104, 15);
      this.label3.TabIndex = 2;
      this.label3.Text = "Datos del Usuario";
      // 
      // pdatos
      // 
      this.pdatos.BackColor = System.Drawing.Color.WhiteSmoke;
      this.pdatos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.pdatos.Controls.Add(this.txtconfirmacion);
      this.pdatos.Controls.Add(this.txtclave);
      this.pdatos.Controls.Add(this.txttelefono);
      this.pdatos.Controls.Add(this.txtusuario);
      this.pdatos.Controls.Add(this.txtemail);
      this.pdatos.Controls.Add(this.cboperfil);
      this.pdatos.Controls.Add(this.label8);
      this.pdatos.Controls.Add(this.label7);
      this.pdatos.Controls.Add(this.label6);
      this.pdatos.Controls.Add(this.label5);
      this.pdatos.Controls.Add(this.label4);
      this.pdatos.Controls.Add(this.label10);
      this.pdatos.Controls.Add(this.txtnombre);
      this.pdatos.Controls.Add(this.label11);
      this.pdatos.Enabled = false;
      this.pdatos.Location = new System.Drawing.Point(438, 40);
      this.pdatos.Name = "pdatos";
      this.pdatos.Size = new System.Drawing.Size(374, 420);
      this.pdatos.TabIndex = 0;
      // 
      // txtconfirmacion
      // 
      this.txtconfirmacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtconfirmacion.Location = new System.Drawing.Point(16, 368);
      this.txtconfirmacion.Name = "txtconfirmacion";
      this.txtconfirmacion.PasswordChar = '*';
      this.txtconfirmacion.Size = new System.Drawing.Size(340, 23);
      this.txtconfirmacion.TabIndex = 25;
      // 
      // txtclave
      // 
      this.txtclave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtclave.Location = new System.Drawing.Point(16, 313);
      this.txtclave.Name = "txtclave";
      this.txtclave.PasswordChar = '*';
      this.txtclave.Size = new System.Drawing.Size(340, 23);
      this.txtclave.TabIndex = 24;
      // 
      // txttelefono
      // 
      this.txttelefono.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txttelefono.Location = new System.Drawing.Point(16, 203);
      this.txttelefono.Name = "txttelefono";
      this.txttelefono.Size = new System.Drawing.Size(340, 23);
      this.txttelefono.TabIndex = 23;
      // 
      // txtusuario
      // 
      this.txtusuario.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtusuario.Location = new System.Drawing.Point(16, 258);
      this.txtusuario.Name = "txtusuario";
      this.txtusuario.Size = new System.Drawing.Size(340, 23);
      this.txtusuario.TabIndex = 22;
      // 
      // txtemail
      // 
      this.txtemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtemail.Location = new System.Drawing.Point(16, 148);
      this.txtemail.Name = "txtemail";
      this.txtemail.Size = new System.Drawing.Size(340, 23);
      this.txtemail.TabIndex = 21;
      // 
      // cboperfil
      // 
      this.cboperfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboperfil.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cboperfil.FormattingEnabled = true;
      this.cboperfil.Location = new System.Drawing.Point(16, 33);
      this.cboperfil.Name = "cboperfil";
      this.cboperfil.Size = new System.Drawing.Size(340, 23);
      this.cboperfil.TabIndex = 20;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label8.Location = new System.Drawing.Point(15, 15);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(34, 15);
      this.label8.TabIndex = 19;
      this.label8.Text = "Perfil";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label7.Location = new System.Drawing.Point(15, 350);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(112, 15);
      this.label7.TabIndex = 18;
      this.label7.Text = "Confirmación Clave";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(15, 295);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(36, 15);
      this.label6.TabIndex = 17;
      this.label6.Text = "Clave";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(15, 185);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(53, 15);
      this.label5.TabIndex = 16;
      this.label5.Text = "Teléfono";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(15, 130);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(36, 15);
      this.label4.TabIndex = 15;
      this.label4.Text = "Email";
      // 
      // label10
      // 
      this.label10.AutoSize = true;
      this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label10.Location = new System.Drawing.Point(15, 240);
      this.label10.Name = "label10";
      this.label10.Size = new System.Drawing.Size(47, 15);
      this.label10.TabIndex = 14;
      this.label10.Text = "Usuario";
      // 
      // txtnombre
      // 
      this.txtnombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
      this.txtnombre.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtnombre.Location = new System.Drawing.Point(16, 93);
      this.txtnombre.Name = "txtnombre";
      this.txtnombre.Size = new System.Drawing.Size(340, 23);
      this.txtnombre.TabIndex = 3;
      // 
      // label11
      // 
      this.label11.AutoSize = true;
      this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label11.Location = new System.Drawing.Point(15, 75);
      this.label11.Name = "label11";
      this.label11.Size = new System.Drawing.Size(107, 15);
      this.label11.TabIndex = 2;
      this.label11.Text = "Nombre Completo";
      // 
      // usuarios
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
      this.Name = "usuarios";
      this.Text = "usuarios";
      this.Load += new System.EventHandler(this.usuarios_Load);
      this.pbotones.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgusuarios)).EndInit();
      this.pcontenido.ResumeLayout(false);
      this.pcontenido.PerformLayout();
      this.pdatos.ResumeLayout(false);
      this.pdatos.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion
    internal System.Windows.Forms.Label lblTitulo;
    private System.Windows.Forms.Label label18;
    private System.Windows.Forms.Panel pbotones;
    private System.Windows.Forms.Button btnnew;
    private System.Windows.Forms.Button btncancel;
    private System.Windows.Forms.Button btndelete;
    private System.Windows.Forms.Button btnsave;
    private System.Windows.Forms.Button btnedit;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataGridView dgusuarios;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Panel pcontenido;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Panel pdatos;
    private System.Windows.Forms.Label label11;
    private System.Windows.Forms.TextBox txtnombre;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label10;
    private System.Windows.Forms.ComboBox cboperfil;
    private System.Windows.Forms.TextBox txtemail;
    private System.Windows.Forms.TextBox txttelefono;
    private System.Windows.Forms.TextBox txtusuario;
    private System.Windows.Forms.TextBox txtclave;
    private System.Windows.Forms.TextBox txtconfirmacion;
    private System.Windows.Forms.DataGridViewTextBoxColumn item;
    private System.Windows.Forms.DataGridViewTextBoxColumn idusuariocrea;
    private System.Windows.Forms.DataGridViewTextBoxColumn idusuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn idperfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn perfil;
    private System.Windows.Forms.DataGridViewTextBoxColumn nombrecompleto;
    private System.Windows.Forms.DataGridViewTextBoxColumn email;
    private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
    private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
    private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
    private System.Windows.Forms.DataGridViewTextBoxColumn clave;
    private System.Windows.Forms.DataGridViewTextBoxColumn saltsecret;
    private System.Windows.Forms.DataGridViewTextBoxColumn estadoregistro;
  }
}