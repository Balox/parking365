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
using parkingDemo.domain;

namespace parkingDemo {
  public partial class registrarSalida : Form {

    private static volatile registrarSalida instance;
    private static object syncRoot = new Object();

    private Size sInicio = new Size(300,220);
    private DateTime FeSalida;
    private bool hayIngreso = false;
    private Double minutos = 0;
    private Double costo = 0;
    private Ingreso icurrent = null;
    private bool stop = false;

    public registrarSalida() {
      InitializeComponent();
    }

    public static registrarSalida Instance {
      get {
        if(instance == null) {
          lock(syncRoot) {
            if(instance == null) {
              instance = new registrarSalida();
            }
          }
        }
        return instance;
      }
    }
    
    private void button1_Click(object sender,EventArgs e) {
      // buscar
      //Ingreso i = Global.data.Ingresos.SingleOrDefault(x => x.Placa == textBox1.Text.Trim());
      stop = false;
      icurrent = Global.data.Ingresos.SingleOrDefault(x => x.Placa == textBox1.Text.Trim());
      
      if (icurrent == null) {
        MessageBox.Show(".:Mensaje Información:.","No se encontro la PLACA ingresada.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        textBox1.Text = String.Empty;
        textBox1.Enabled = true;
        textBox1.Focus();
      } else {
        textBox1.Enabled = false;

        //FeIngreso = i.FeIngreso;
        hayIngreso = true;
        //tarifa = i.Tarifa;
        label6.Text = icurrent.Placa; // PLACA
        label7.Text = icurrent.Fecha; // FECHA INGRESO
        label1.Text = icurrent.Hora; // HORA INGRESO
        label11.Text = icurrent.Tiempo.ToString(); // TIEMPO
        label12.Text = icurrent.Tarifa.ToString(); // TARIFA
        label14.Text = icurrent.Costo.ToString(); // COSTO

        button3.Focus();
        this.Size = new Size(300, 540);
      }

      //Console.WriteLine(i);
    }

    private void button2_Click(object sender,EventArgs e) {
      // cancelar
      label6.Text = String.Empty; // PLACA
      label7.Text = String.Empty; // FECHA INGRESO
      label1.Text = String.Empty; // HORA INGRESO
      label11.Text = String.Empty; // TIEMPO
      label12.Text = String.Empty; // TARIFA
      label14.Text = String.Empty; // COSTO
      textBox1.Text = string.Empty;
      textBox1.Enabled = true;
      textBox1.Focus();

      this.Size = new Size(300,220);
      hayIngreso = false;
      icurrent.Tarifa = 0;
      //tarifa = 0;
      stop = false;
    }

    private void button3_Click(object sender,EventArgs e) {
      // registrar salida

      if (icurrent != null) {
        stop = true;
        var index = Global.data.Ingresos.IndexOf(icurrent);

        icurrent.FeSalida = FeSalida;
        icurrent.HoraSalida = String.Format("{0:HH:mm:ss}",FeSalida);
        icurrent.Tiempo = Convert.ToInt32(minutos);
        icurrent.Costo = Convert.ToDecimal(costo);

        Global.data.Ingresos[index] = icurrent;

        MessageBox.Show(".:Mensaje Información:.","No se encontro la PLACA ingresada.",MessageBoxButtons.OK,MessageBoxIcon.Information);
        textBox1.Text = String.Empty;
        textBox1.Enabled = true;
        textBox1.Focus();

        this.Size = new Size(300,220);

      }
    }

    private void registrarSalida_Load(object sender,EventArgs e) {
      label6.Text = String.Empty; // PLACA
      label7.Text = String.Empty; // FECHA INGRESO
      label1.Text = String.Empty; // HORA INGRESO
      label11.Text = String.Empty; // TIEMPO
      label12.Text = String.Empty; // TARIFA
      label14.Text = String.Empty; // COSTO
      textBox1.Text = string.Empty;
      textBox1.Enabled = true;
      textBox1.Focus();

      this.Size = sInicio;
      hayIngreso = false;
      stop = false;

      //icurrent.Tarifa = 0;
      

      this.label4.Text = String.Format("{0:HH:mm:ss}",DateTime.Now);
      timer1.Interval = 1000; //  ' Un segundo
      timer1.Start();
    }

    private void timer1_Tick(object sender,EventArgs e) {
      var current = DateTime.Now;
      this.label4.Text = String.Format("{0:HH:mm:ss}",current);

      if (!stop) {
        if(hayIngreso) {
          FeSalida = current;
          TimeSpan result = current.Subtract(icurrent.FeIngreso);
          minutos = result.TotalMinutes;
          costo = Math.Round(minutos * icurrent.Tarifa);

          //label11.Text = result.ToString(@"dd\.hh\:mm\:ss");
          label11.Text = result.ToString(@"hh\:mm\:ss");
          label14.Text = Convert.ToString(costo);
        }
      }
    }
  }
}
