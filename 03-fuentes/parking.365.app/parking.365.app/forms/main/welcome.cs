using System;
using System.Windows.Forms;
using System.Threading;
using parking._365.app.common;

namespace parking._365.app.forms.main {
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
      Application.Run(new mdiMain());
    }

    private void formClose() {
      this.Close();
    }
  }
}
