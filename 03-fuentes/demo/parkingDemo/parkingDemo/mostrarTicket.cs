using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using parkingDemo.domain;
using parkingDemo.common;

namespace parkingDemo {
  public partial class mostrarTicket : Form {

    private string barcode;
    private DateTime dateTime;
    public mostrarTicket() {
      InitializeComponent();
    }
    public void setFeIngreso(DateTime dt) {
      this.dateTime = dt;
    }
    public void setFecha(string f) {
      label4.Text = f;
    }
    public void setHora(string h) {
      label5.Text = h;
    }
    public void setPlaca(string p) {
      label6.Text = p.ToUpper();
    }
    
    public void generarCodigoBarra() {
      BarcodeLib.Barcode bc = new Barcode();
      bc.IncludeLabel = true;
      barcode = (label6.Text + label5.Text);

      panel1.BackgroundImage = bc.Encode(TYPE.CODE128,barcode,Color.Blue,Color.White,400,100);
      //reposition the barcode image to the middle
      panel1.Location = new Point((this.panel1.Location.X + this.panel1.Width / 2) - panel1.Width / 2,(this.panel1.Location.Y + this.panel1.Height / 2) - panel1.Height / 2);

      Global.contadorI++;
      Ingreso i = new Ingreso(
        Global.contadorI, // Id
        barcode, // Ticket
        label4.Text, // Fecha
        label5.Text, // Hora
        label6.Text, // Placa
        this.dateTime); // Fecha Ingreso

      Global.data.Ingresos.Add(i);
    }
    private void mostrarTicket_Load(object sender,EventArgs e) {

    }

    private void button1_Click(object sender,EventArgs e) {
      this.Close();
    }

    private void button2_Click(object sender,EventArgs e) {
      Clipboard.SetText(barcode);
    }
  }
}
