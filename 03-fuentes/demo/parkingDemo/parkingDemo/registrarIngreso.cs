using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parkingDemo {
  public partial class registrarIngreso : Form {

    private static volatile registrarIngreso instance;
    private static object syncRoot = new Object();
    
    public registrarIngreso() {
      InitializeComponent();
    }

    public static registrarIngreso Instance {
      get {
        if (instance == null) {
          lock (syncRoot) {
            if (instance == null) {
              instance = new registrarIngreso();
            }
          }
        }
        return instance;
      }
    }

    private void button2_Click(object sender,EventArgs e) {
      //boton registrar ingreso
      // mostrar ticket
      mostrarTicket mt = new mostrarTicket();
      var feIngreso = DateTime.Now;

      mt.setFeIngreso(feIngreso);
      mt.setFecha(String.Format("{0:dd:MM:yyyy}",feIngreso));
      mt.setHora(String.Format("{0:HH:mm:ss}",feIngreso));
      mt.setPlaca(textBox1.Text.Trim());
      mt.generarCodigoBarra();      
      mt.Show();
    }

    private void button1_Click(object sender,EventArgs e) {
      instance = null;
      this.Close();
    }

    private void registrarIngreso_Load(object sender,EventArgs e) {
      this.label2.Text = String.Format("{0:HH:mm:ss}",DateTime.Now);
      timer1.Interval = 1000; //  ' Un segundo
      timer1.Start();
    }

    private void timer1_Tick(object sender,EventArgs e) {
      this.label2.Text = String.Format("{0:HH:mm:ss}",DateTime.Now);
    }

    private void registrarIngreso_FormClosed(object sender,FormClosedEventArgs e) {
      instance = null;
    }
  }
}
