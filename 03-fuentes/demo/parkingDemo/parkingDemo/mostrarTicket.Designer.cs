namespace parkingDemo {
  partial class mostrarTicket {
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.button1 = new System.Windows.Forms.Button();
      this.panel1 = new System.Windows.Forms.Panel();
      this.button2 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(59, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(167, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = ".:BIENVENIDO A PARKING 365:.";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(30, 90);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(45, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "FECHA:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(30, 120);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(41, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "HORA:";
      // 
      // label4
      // 
      this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label4.Location = new System.Drawing.Point(100, 85);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(90, 20);
      this.label4.TabIndex = 3;
      this.label4.Text = "06/08/2018";
      this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label5
      // 
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.Location = new System.Drawing.Point(100, 115);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(90, 20);
      this.label5.TabIndex = 4;
      this.label5.Text = "18:35:54";
      this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // label6
      // 
      this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label6.Location = new System.Drawing.Point(52, 155);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(180, 40);
      this.label6.TabIndex = 5;
      this.label6.Text = "ABC-123";
      this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(105, 326);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(75, 23);
      this.button1.TabIndex = 7;
      this.button1.Text = "SALIR";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // panel1
      // 
      this.panel1.Location = new System.Drawing.Point(-58, 215);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(400, 100);
      this.panel1.TabIndex = 0;
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button2.Location = new System.Drawing.Point(231, 188);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(48, 23);
      this.button2.TabIndex = 0;
      this.button2.Text = "COPIAR";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // mostrarTicket
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(284, 361);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "mostrarTicket";
      this.Text = ".:Mostrar Ticket:.";
      this.Load += new System.EventHandler(this.mostrarTicket_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button button2;
  }
}