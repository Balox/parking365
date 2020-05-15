using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parking._365.app.dao {
  public class DataBase {
    private const string Server = ".";
    private const string Database = "parking_prod";
    private const string User = "sa";
    private const string Password = "Admin@2019";

    // Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
    public static string ConnectionString = string.Format("Server={0};Database={1};User Id={2};Password={3};",Server,Database,User,Password);
    public static string MssqlVersion = string.Empty;


    public static bool PruebaConexion() {
      using (System.Data.SqlClient.SqlConnection cn = new System.Data.SqlClient.SqlConnection(ConnectionString)) {
        cn.Open();

        try {
          System.Data.SqlClient.SqlCommand cmd = new System.Data.SqlClient.SqlCommand();
          cmd.Connection = cn;
          cmd.CommandType = System.Data.CommandType.Text;
          cmd.CommandText = "select @@VERSION;";

          MssqlVersion = Convert.ToString(cmd.ExecuteScalar());

          return !MssqlVersion.Equals(string.Empty);

        } catch (Exception ex) {
          throw ex;
        }
      }
    }

  }
}
