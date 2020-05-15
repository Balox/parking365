using parking._365.app.dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking._365.app.controllers {
  public class MainController {

    private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

    public static bool init() {
      try {
        log.Info("Parking365 iniciado...");

        if(!DataBase.PruebaConexion()) {
          log.Warn("No se ha realizado la prueba de conexion a base de datos.");
          return false;
        }

        // se puede agregar otra validacion o cargar valores y parametros de sistema...


        return true;

      } catch(Exception ex) {
        log.Error(ex.Message);
        return false;
      }
    }
  }
}
