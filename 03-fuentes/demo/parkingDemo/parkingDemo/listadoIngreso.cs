using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parkingDemo.common;

namespace parkingDemo {
  public partial class listadoIngreso : Form {

    private static volatile listadoIngreso instance;
    private static object syncRoot = new Object();

    public listadoIngreso() {
      InitializeComponent();
    }
    public static listadoIngreso Instance {
      get {
        if(instance == null) {
          lock(syncRoot) {
            if(instance == null) {
              instance = new listadoIngreso();
            }
          }
        }
        return instance;
      }
    }
    private void listadoIngreso_Load(object sender,EventArgs e) {
      this.label2.Text = String.Format("{0:HH:mm:ss}",DateTime.Now);
      timer1.Interval = 1000; //  ' Un segundo
      timer1.Start();
      
      dataGridView1.DataBindings.Add("Datasource", Global.data ,"Ingresos");
    }

    private void button1_Click(object sender,EventArgs e) {

    }

    private void timer1_Tick(object sender,EventArgs e) {
      this.label2.Text = String.Format("{0:HH:mm:ss}",DateTime.Now);
    }
  }
}
