using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using parking365.common;
using System.Threading;

namespace parking_365_app.forms.main {
  public partial class welcome : Form {

    private Thread thread;
    private delegate void myDelegateForm();

    public welcome() {
      InitializeComponent();
    }

    private void welcome_Load(object sender,EventArgs e) {
      try {
        // cargar accesos del usuario logeado
        thread = new Thread(formThread);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();

      } catch (Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      }
    }

    private void formThread() {
      Thread.Sleep(3000);
      this.Invoke(new myDelegateForm(formClose));
      Application.Run(new main());
    }

    private void formClose() {
      this.Close();
    }
  }
}
