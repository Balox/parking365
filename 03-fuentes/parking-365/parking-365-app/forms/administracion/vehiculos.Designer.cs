namespace parking_365_app.forms.administracion {
  partial class vehiculos {
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
      this.lblTitulo.Size = new System.Drawing.Size(824, 33);
      this.lblTitulo.TabIndex = 4;
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
      this.label18.TabIndex = 16;
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
      this.pbotones.TabIndex = 30;
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
      // 
      // vehiculos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(824, 560);
      this.Controls.Add(this.pbotones);
      this.Controls.Add(this.label18);
      this.Controls.Add(this.lblTitulo);
      this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "vehiculos";
      this.Text = "vehiculos";
      this.Load += new System.EventHandler(this.vehiculos_Load);
      this.pbotones.ResumeLayout(false);
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
  }
}