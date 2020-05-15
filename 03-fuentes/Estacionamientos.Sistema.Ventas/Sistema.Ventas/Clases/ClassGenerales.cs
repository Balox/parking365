using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Configuration;
using Facturacion.Electronica;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;

namespace Sistema.Ventas
{
    public class ClassGenerales
    {


        public DataTable EjecutaQuery(string Query)
        {
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader Reader = cmd.ExecuteReader();
                dt.Load(Reader);

                con.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public DataTable ObtieneConfiguracion()
        {// SELECT Impresora, RazonSocial, RFC, Domicilio, Ciudad, Estado, Telefono, Email, Saludo, Logo,DiasCitas FROM Configuracion;
            DataTable dt = new DataTable();
            try
            {
                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(" SELECT * FROM Configuracion;", con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                OleDbDataReader Reader = cmd.ExecuteReader();
                dt.Load(Reader);

                con.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }




        public Boolean EjecutaQuery2(string Query)
        {
            try
            {

                OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
                OleDbCommand cmd = new OleDbCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int Inserto = 0;
                Inserto = cmd.ExecuteNonQuery();
                con.Close();
                if (Inserto > 0 || Inserto == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public string ValidaUsuario(string cUsuario, string cPassword)
        {
            OleDbConnection Cnx = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            string Resultado;

            OleDbCommand cmd = new OleDbCommand("select cNombre,iCveUsuarios,bAdmon from usuarios where cUsuario='" + cUsuario + "' AND cPassword='" + cPassword + "'", Cnx);
            cmd.CommandType = CommandType.Text;
            Cnx.Open();

            OleDbDataReader Reader = cmd.ExecuteReader();


            if (Reader.Read())
            {
                Resultado = Reader.GetString(0);
                Variables.Usuario = Reader.GetString(0);
                Variables.iCveUsuario = Reader.GetInt32(1);
                Variables.iCveUsuarioAdministrador = Reader.GetByte(2);

                if (Variables.iCveUsuarioAdministrador == 1)
                {
                    EjecutaQuery2("update usuarios set CatPersonal = 1 where iCveUsuarios=" + Variables.iCveUsuario);
                }
            }
            else
            {
                Resultado = "El usuario no existe";
            }

            Cnx.Close();
            return Resultado;
        }

        public string ObtieneCadenaConexion()
        {
            string Cadena = string.Empty;
            Cadena = Desencriptar("27bRgE1J2wImggRodlHvvflWJf8G9nObDKF6plS7r99zkvYhew6gr+6AoyaJrW9ZuQCJ74HWWMYceLEZKSyHdY1/W/dDydNAtz7oahg16FyknQoH00+U/dCCKgvIRJvv", Variables.PassEncriptacion);
            return Cadena;
        }


        public DataTable EjecutaQueryMysql(string Query)
        {
            DataTable dt = new DataTable();
            try
            {

                MySqlConnection con = new MySqlConnection(ObtieneCadenaConexion());
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                MySqlDataReader Reader = cmd.ExecuteReader();
                dt.Load(Reader);

                con.Close();
                return dt;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public Boolean EjecutaQueryMysql2(string Query)
        {
            try
            {

                MySqlConnection con = new MySqlConnection(ObtieneCadenaConexion());
                MySqlCommand cmd = new MySqlCommand(Query, con);
                cmd.CommandType = CommandType.Text;
                con.Open();
                int Inserto = 0;
                Inserto = cmd.ExecuteNonQuery();
                con.Close();
                if (Inserto > 0 || Inserto == -1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }




        public static Boolean IsNumericInt(string valor)
        {
            int result;
            return int.TryParse(valor, out result);
        }

        public static Boolean IsNumericDouble(string valor)
        {
            Double result;
            return Double.TryParse(valor, out result);
        }

        public static Boolean IsNumericDecimal(string valor)
        {
            Decimal result;
            return Decimal.TryParse(valor, out result);
        }

        public static Boolean IsNumericFloat(string valor)
        {
            float result;
            return float.TryParse(valor, out result);
        }



        public void ExportarExcel(DataGridView dataGridView1)
        {

            try
            {
                // creating Excel Application
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();


                // creating new WorkBook within Excel application
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);


                // creating new Excelsheet in workbook
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

                // see the excel sheet behind the program
                app.Visible = true;

                // get the reference of first sheet. By default its name is Sheet1.
                // store its reference to worksheet
                worksheet = workbook.Sheets["Hoja1"];

                worksheet = workbook.ActiveSheet;

                // changing the name of active sheet
                worksheet.Name = "Datos";


                // storing header part in Excel
                for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
                {
                    worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
                }



                // storing Each row and column value to excel sheet
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    }
                }


                // save the application
                //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);

                // Exit from the application
                app.Quit();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {

            }

        }



        public static string Encriptar(string texto, string key)
        {
            try
            {
                byte[] keyArray;
                byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
                //Se utilizan las clases de encriptación MD5

                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                //Algoritmo TripleDES
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateEncryptor();

                byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0, Arreglo_a_Cifrar.Length);
                tdes.Clear();
                //se regresa el resultado en forma de una cadena
                texto = Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
            }

            catch (Exception)
            {
            }
            return texto;
        }

        public static string Desencriptar(string textoEncriptado, string key)
        {
            try
            {
                byte[] keyArray;
                byte[] Array_a_Descifrar = Convert.FromBase64String(textoEncriptado);
                //algoritmo MD5
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                hashmd5.Clear();
                TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
                tdes.Key = keyArray;
                tdes.Mode = CipherMode.ECB;
                tdes.Padding = PaddingMode.PKCS7;
                ICryptoTransform cTransform = tdes.CreateDecryptor();
                byte[] resultArray = cTransform.TransformFinalBlock(Array_a_Descifrar, 0, Array_a_Descifrar.Length);
                tdes.Clear();
                textoEncriptado = UTF8Encoding.UTF8.GetString(resultArray);
            }

            catch (Exception)
            {
            }
            return textoEncriptado;
        }


        public bool AccesoInternet()
        {

            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;

            }
            catch (Exception)
            {
                return false;
            }

        }




        private Double CargaCierre()
        {
            Double Total = 0;

            string sInicial = DateTime.Now.ToString("MM/dd/yyyy");
            string sFinal = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT  sum( venta.Total) as Total FROM venta ";

            Query += " where venta.fFecha between #" + sInicial + "# and #" + sFinal + "# ";

            Query += " and venta.iStatus=1";

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            if (dtDatos.Rows.Count>0)
            {
                Total = Convert.ToDouble(dtDatos.Rows[0]["Total"]);
            }
            return Total;
        }


        public void Correo()
        {

            try
            {
                string EmailAlertas = Variables.dtConfiguracion.Rows[0]["EmailAlertas"].ToString().Trim();

                if (EmailAlertas == "")
                {
                    return;
                }


                MailMessage email = new MailMessage();
                email.To.Add(EmailAlertas);
                email.Bcc.Add("sistemas.cam@hotmail.com");
                email.From = new MailAddress("sistemas@servidor.com");
                email.Subject = "Alertas " + Variables.NombreEmpresa;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;
                string html = "  <h4>Fecha : " + DateTime.Now.ToString("yyyy/MM/dd HH:mm") + "</h4> " +
                               " <h4>TOTAL ACTUAL DE LA CAJA : $" + String.Format("{0:0,0.00}", CargaCierre()) + "</h4> ";

                AlternateView htmlView = AlternateView.CreateAlternateViewFromString(html, Encoding.UTF8,
                                            MediaTypeNames.Text.Html);

                email.AlternateViews.Add(htmlView);

                SmtpClient smtp = new SmtpClient();
                smtp.Host = " mail.servidor.com";
                smtp.Port = 587;
                smtp.EnableSsl = false;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("sistemas@servidor.com", "#");
                smtp.Send(email);
                email.Dispose();
            }
            catch (Exception ex)
            {
              Console.WriteLine(ex.Message);
            }
            //try
            //{

            //}
            //catch (Exception)
            //{

            //}
        }


    }
}
