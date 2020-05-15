namespace parkingDemo {
  partial class listadoIngreso {
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
      this.components = new System.ComponentModel.Container();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.label2 = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.button1 = new System.Windows.Forms.Button();
      this.Item = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ticket = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FechaIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoraIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.FeSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.HoraSalida = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Tarifa = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // timer1
      // 
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.label2.Location = new System.Drawing.Point(612, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(120, 31);
      this.label2.TabIndex = 4;
      this.label2.Text = "18:35:56";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Item,
            this.ticket,
            this.Placa,
            this.FeIngreso,
            this.FechaIngreso,
            this.HoraIngreso,
            this.ingreso,
            this.FeSalida,
            this.HoraSalida,
            this.Tiempo,
            this.Tarifa,
            this.Costo});
      this.dataGridView1.Location = new System.Drawing.Point(12, 58);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.RowHeadersWidth = 25;
      this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.dataGridView1.Size = new System.Drawing.Size(720, 250);
      this.dataGridView1.TabIndex = 5;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(657, 326);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 6;
      this.button1.Text = "SALIR";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Item
      // 
      this.Item.DataPropertyName = "Id";
      this.Item.HeaderText = "N°";
      this.Item.Name = "Item";
      this.Item.Width = 30;
      // 
      // ticket
      // 
      this.ticket.DataPropertyName = "Ticket";
      this.ticket.HeaderText = "TICKET";
      this.ticket.Name = "ticket";
      // 
      // Placa
      // 
      this.Placa.DataPropertyName = "Placa";
      this.Placa.HeaderText = "PLACA";
      this.Placa.Name = "Placa";
      this.Placa.Width = 80;
      // 
      // FeIngreso
      // 
      this.FeIngreso.DataPropertyName = "FeIngreso";
      this.FeIngreso.HeaderText = "FeIngreso";
      this.FeIngreso.Name = "FeIngreso";
      this.FeIngreso.Visible = false;
      // 
      // FechaIngreso
      // 
      this.FechaIngreso.DataPropertyName = "Fecha";
      this.FechaIngreso.HeaderText = "FECHA INGRESO";
      this.FechaIngreso.Name = "FechaIngreso";
      this.FechaIngreso.Visible = false;
      // 
      // HoraIngreso
      // 
      this.HoraIngreso.DataPropertyName = "Hora";
      this.HoraIngreso.HeaderText = "HORA INGRESO";
      this.HoraIngreso.Name = "HoraIngreso";
      this.HoraIngreso.Width = 120;
      // 
      // ingreso
      // 
      this.ingreso.DataPropertyName = "Puerta";
      this.ingreso.HeaderText = "INGRESO";
      this.ingreso.Name = "ingreso";
      this.ingreso.Width = 80;
      // 
      // FeSalida
      // 
      this.FeSalida.HeaderText = "FeSalida";
      this.FeSalida.Name = "FeSalida";
      this.FeSalida.Visible = false;
      // 
      // HoraSalida
      // 
      this.HoraSalida.DataPropertyName = "HoraSalida";
      this.HoraSalida.HeaderText = "HORA SALIDA";
      this.HoraSalida.Name = "HoraSalida";
      // 
      // Tiempo
      // 
      this.Tiempo.DataPropertyName = "Tiempo";
      this.Tiempo.HeaderText = "TIEMPO";
      this.Tiempo.Name = "Tiempo";
      this.Tiempo.Width = 60;
      // 
      // Tarifa
      // 
      this.Tarifa.DataPropertyName = "Tarifa";
      this.Tarifa.HeaderText = "TARIFA";
      this.Tarifa.Name = "Tarifa";
      this.Tarifa.Width = 60;
      // 
      // Costo
      // 
      this.Costo.DataPropertyName = "Costo";
      this.Costo.HeaderText = "COSTO";
      this.Costo.Name = "Costo";
      this.Costo.Width = 60;
      // 
      // listadoIngreso
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(744, 361);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.label2);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "listadoIngreso";
      this.Text = ".:Listado de Ingresos:.";
      this.Load += new System.EventHandler(this.listadoIngreso_Load);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Timer timer1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataGridView dataGridView1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.DataGridViewTextBoxColumn Item;
    private System.Windows.Forms.DataGridViewTextBoxColumn ticket;
    private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
    private System.Windows.Forms.DataGridViewTextBoxColumn FeIngreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn FechaIngreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoraIngreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn ingreso;
    private System.Windows.Forms.DataGridViewTextBoxColumn FeSalida;
    private System.Windows.Forms.DataGridViewTextBoxColumn HoraSalida;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
    private System.Windows.Forms.DataGridViewTextBoxColumn Tarifa;
    private System.Windows.Forms.DataGridViewTextBoxColumn Costo;
  }
}