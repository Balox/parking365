using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using parking_365_app.forms.security;
using parking365.common;
using System.Configuration;
using parking_365_app.forms.main;

namespace parking_365_app {
  static class Program {
    /// <summary>
    /// Punto de entrada principal para la aplicación.
    /// </summary>
    [STAThread]
    static void Main() {
      if(!loadValuesAppConfig()) {
        return;
      }

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new main());
    }

    static bool loadValuesAppConfig() {
      DataBase.SERVER = ConfigurationManager.AppSettings["server"];
      DataBase.PORT = ConfigurationManager.AppSettings["port"];
      DataBase.DATABASE = ConfigurationManager.AppSettings["database"];

      DataBase.ConnectionString = String.Format(
          ConfigurationManager.ConnectionStrings["PARKING365"].ConnectionString,
          DataBase.SERVER,
          DataBase.PORT,
          DataBase.USER,
          DataBase.PASSWORD,
          DataBase.DATABASE
        );
      
      Console.WriteLine(DataBase.ConnectionString);

        if(DataBase.ConnectionString.Length == 0) {
          MessageBox.Show("No se ha cargado correctamente los parametros de conexion a base de datos.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          return false;
        }

        return true;
    }

  }
}
