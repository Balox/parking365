using System.Text;
using System.Security.Cryptography;

namespace parking._365.app.common {
  public class Global {
    public const string NAME_MODULE = ".:PARKING365:.";
    public const int IdAdmin = 1;
    

    public static string GetMd5Hash(MD5 md5Hash,string input) {

      // Convert the input string to a byte array and compute the hash.
      byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

      // Create a new Stringbuilder to collect the bytes
      // and create a string.
      StringBuilder sBuilder = new StringBuilder();

      // Loop through each byte of the hashed data 
      // and format each one as a hexadecimal string.
      for(int i = 0; i < data.Length; i++) {
        sBuilder.Append(data[i].ToString("x2"));
      }

      // Return the hexadecimal string.
      return sBuilder.ToString();
    }

    public enum TIPO_CLIENTE {
      NONE,
      NATURAL,
      JURIDICA
    };

    public enum TIPO_DOCUMENTO {
      NONE,
      DNI,
      RUC
    };
  }

}
