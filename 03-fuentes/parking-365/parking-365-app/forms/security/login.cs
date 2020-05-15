using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using parking365.common;
using parking365.service;
using parking_365_app.util;
using parking_365_app.forms.main;

namespace parking_365_app.forms.security {
  public partial class login : Form {

    private ConfigurationService service = new ConfigurationService();
    private Thread thread;

    public login() {
      InitializeComponent();
      // comentar luego
      txtusername.Text = "AdminParking";
      txtpassword.Text = "4dm1n@Park1ng365";
    }

    private void pbsalir_Click(object sender,EventArgs e) {
      System.Windows.Forms.Application.Exit();
    }

    private void btnIngresar_Click(object sender,EventArgs e) {
      txtusername.Enabled = false;
      txtpassword.Enabled = false;
      try { 
        string username = txtusername.Text.Trim();
        string password = txtpassword.Text.Trim();

        if (username.Length == 0 || password.Length == 0) {
          MessageBox.Show("Credenciales incorrectas.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          return;
        }

        Constanst.USER_CURRENT = service.usuarioService().Login(username,password);

        this.Close();
        thread = new Thread(formThread);
        thread.SetApartmentState(ApartmentState.STA);
        thread.Start();

      } catch (Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        txtusername.Enabled = true;
        txtpassword.Enabled = true;
        GC.Collect();
      }
    }

    private void formThread() {
      Application.Run(new welcome());
    }
  }
}
