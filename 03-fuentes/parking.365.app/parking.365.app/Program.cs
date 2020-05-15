using System;
using System.Windows.Forms;
using parking._365.app.forms.main;
using parking._365.app.controllers;

namespace parking._365.app {
  static class Program {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main() {
      if (!MainController.init()) {
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new welcome());
    }
    
  }
}
