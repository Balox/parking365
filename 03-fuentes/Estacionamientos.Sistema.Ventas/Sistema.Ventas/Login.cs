using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;
using System.Net;
using System.Security.Cryptography;
using System.Data.OleDb;
//using iTextSharp.text;
using System.IO;
//using iTextSharp.text.pdf;

namespace Sistema.Ventas
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(cerrar_form);
        }

        private void btnEntrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Entrar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        void cerrar_form(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 112)
            {
                Recargas form = new Recargas();
                form.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void CreaPDF()
        {
           /*
            * COMENTADO 
            string Ticket = " <table style='width: 20px;' border='1'> " +
           " <tr><td align='center'>@Empresa</td></tr> " +
           " <tr><td align='center'>@Direccion</td></tr> " +
           " <tr><td align='center'>@Rfc</td></tr> " +
           " <tr><td align='center'>@Telefono</td></tr> " +
           " <tr><td align='center'>Marca: @Marca</td></tr> " +
           " <tr><td align='center'>Modelo: @Modelo</td></tr> " +
           " <tr><td align='center'>Placas: @Placas</td></tr> " +
           " <tr><td align='center'>Color: @Color</td></tr> " +
           " <tr><td align='center'>Horarios<br />Lun-Sab de 9:00 am a 9:00 pm<br />Domingo de 9:00 am a 7:00 pm<br />" + //</td></tr> " +
          // " <tr><td align='justify'> " +
                   " CONTRATO DE PRESTACION DE SERVICIO DE ESTACIONAMIENTO La entrega y recibo del  " +
                   " presente contrato, implica que el usuario del servicio conoce y acepta el  " +
                   " contenido de las siguientes: CLAUSULAS: PRIMERA: El usuario del servicio acepta  " +
                   " que los daños ocasionados al vehículo por el personal del prestador del servicio  " +
                   " serán reparados en los talleres del prestador y a entera satisfacción del  " +
                   " usuario. SEGUNDA: El usuario del servicio asume la responsabilidad de todos los  " +
                   " gastos que se generen con motivo de sus traslados y demás accesorios durante el  " +
                   " tiempo que permanezca el vehículo en reparación. TERCERA: El prestador del  " +
                   " servicio responderá por los objetos dejados en el interior del vehículo como son  " +
                   " carátulas de stereos, teléfonos, lentes, siempre y cuando exista constancia por  " +
                   " escrito de haberlos reportado al personal del estacionamiento. CUARTA: El  " +
                   " prestador de servicio cuenta con una póliza de seguro de responsabilidad civil  " +
                   " por robo total, hasta por la cantidad de $200,000.00 (Doscientos mil pesos  " +
                   " 00/100 m.n.) aceptando el usuario del servicio que, si el vehículo descrito en  " +
                   " el presente contrato vale más de dicha cantidad, su demasía, así como el  " +
                   " deducible correrá por su cuenta. QUINTA: El prestador del servicio no se hace  " +
                   " responsable por: 1. Incendio motivado por deficiencia de la instalación  " +
                   " eléctrica o falla del carburador. 2. Desperfectos mecánicos no imputables al  " +
                   " personal del prestador del servicio de estacionamiento 3. Siniestros a causa de  " +
                   " inundaciones, incendios, temblores, terremotos, alborotos populares o  " +
                   " estudiantiles o cualquier otro que no se le sea imputable al personal del  " +
                   " prestador del servicio de estacionamiento. SEXTA: El prestador del servicio se  " +
                   " deslinda de cualquier responsabilidad civil, penal o de cualquier índole cuando  " +
                   " el vehículo sea irregular o sea reportado como robado. SEPTIMA: Si el usuario  " +
                   " pierde este contrato deberá reportarlo inmediatamente y acreditar la propiedad,  " +
                   " de lo contrario se entregará al portador de dicho contrato sin responsabilidad  " +
                   " alguna al prestador del servicio, el costo por contrato perdido es de $100 (Cien  " +
                   " pesos 00/100 m.n.) más el tiempo de estancia. OCTAVA: El prestador del servicio  " +
                   " no se hace responsable por vehículos dejados después del horario establecido y  " +
                   " exhibido en el establecimiento y dicho contrato. NOTA IMPORTANTE EN DICHO  " +
                   " ESTABLECIMIENTO “NO HAY TOLERANCIA, SOLO HORAS COMPLETAS SE COBRAN”</td> " +
           " </tr> " +
       " </table>";
      */
            //Document document = new Document(PageSize.LETTER,1,400,1,1);
            //PdfWriter.GetInstance(document, new FileStream("C:\\CFDI\\MySamplePDF.pdf", FileMode.Create));
            //document.Open();
            //iTextSharp.text.html.simpleparser.HTMLWorker hw =
            //             new iTextSharp.text.html.simpleparser.HTMLWorker(document);
            //hw.Parse(new StringReader(Ticket));
            //document.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CreaPDF();
            this.Height = 215;
            Variables.PassEncriptacion = "o5o2o8o5o2o8";

            txtusuario.Focus();

            Variables.TamañoGrid = 11;

            try
            {
                new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN Direccion2 Char");
                new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN RFC2 Char");
                new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN Telefono2 Char");

            }
            catch (Exception ex)
            {
        Console.WriteLine(ex.Message);
            }

             try
            {
                new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN Horarios Char");
                new ClassGenerales().EjecutaQuery2("update Configuracion set Horarios='Horarios Lun-Sab de 9:00 am a 9:00 pm Domingo de 9:00 am a 7:00 pm'");

            }
            catch (Exception ex)
            {
        Console.WriteLine(ex.Message);
      }

             try
             {
                 new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN CelAlertas Char(10)");
                 new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN EmailAlertas Char(100)");
                 new ClassGenerales().EjecutaQuery2("update Configuracion set EmailAlertas='guerrero140773@yahoo.com.mx'");
             }
             catch (Exception ex)
             {
        Console.WriteLine(ex.Message);
      }

            
            

            // try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Citas drop column NUMEROCLIENTE");
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Citas ADD COLUMN iCveProveedor integer ");
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("create table AbonosClientes (IdAbonosClientes AUTOINCREMENT " +
            //                   " CONSTRAINT IdAbonosProveedoresConstraint PRIMARY KEY, " +
            //   " iCveVenta integer,Abono Double,FechaAbono Datetime,Comentario Char)");

            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("create table Estacionamiento (Id AUTOINCREMENT " +
            //                   " CONSTRAINT IdConstraint PRIMARY KEY, " +
            //   " Marca Char,Modelo Char,Placas Char,Entrada Datetime,Salida Datetime,Total Double,Estatus integer)");

            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE venta ADD COLUMN Pagado Byte");
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE venta ADD COLUMN Entregado integer default 1");
            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN UserRed Char");
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN PassRed Char");
            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("create table Gastos (IdGasto AUTOINCREMENT " +
            //                   " CONSTRAINT IdGastoConstraint PRIMARY KEY, " +
            //   " iCveGasto integer,Gasto Double,FechaGasto Datetime,Comentario Char)");

            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("create table CatGastos (iCveGasto AUTOINCREMENT " +
            //                   " CONSTRAINT iCveGastoConstraint PRIMARY KEY, " +
            //   " cDesc Char,bActivo Byte)");

            //}
            //catch (Exception)
            //{

            //}

            //  try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN Capacidad integer");
            //}
            //catch (Exception)
            //{

            //}

            //  try
            //  {
            //      new ClassGenerales().EjecutaQuery2("ALTER TABLE Configuracion ADD COLUMN Hora Double");
            //  }
            //  catch (Exception)
            //  {

            //  }


            //  try
            //  {
            //      new ClassGenerales().EjecutaQuery2("create table CatMarcas (iCveMarca AUTOINCREMENT " +
            //                     " CONSTRAINT iCveMarcaConstraint PRIMARY KEY, " +
            //     " cDesc Char,bActivo Byte)");

            //  }
            //  catch (Exception)
            //  {

            //  }


            //try
            //  {
            //      new ClassGenerales().EjecutaQuery2("create table CatModelo (iCveModelos AUTOINCREMENT " +
            //                     " CONSTRAINT iCveModelosConstraint PRIMARY KEY,iCveMarca integer, " +
            //     " cDesc Char,bActivo Byte)");

            //  }
            //  catch (Exception)
            //  {

            //  }


            

            //     try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Estacionamiento ADD COLUMN Tarifa Double");
            //}
            //catch (Exception)
            //{

            //}

            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE CatModelo ADD COLUMN Tarifa Double");
            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("ALTER TABLE Estacionamiento ADD COLUMN Color Char(50)");
            //}
            //catch (Exception)
            //{

            //}


            //try
            //{
            //    new ClassGenerales().EjecutaQuery2("create table Colores (iCveColor AUTOINCREMENT " +
            //                   " CONSTRAINT iCveColorConstraint PRIMARY KEY, " +
            //   " cDesc Char,bActivo Byte)");

            //}
            //catch (Exception)
            //{

            //}


//Ventas
//CierreCaja
//CitasProveedores
//Membresias
//Paquetes
//Inventario
//CuentasPagar
//CuentasCobrar
//Gastos
//CatClientes
//CatProductos
//CatPersonal
//CatUnidades
//CatCategorias
//CatProveedores
//CatNiveles
//Configuracion
//TiempoAire

        //    try
        //    {
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Ventas Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CierreCaja Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CitasProveedores Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Membresias Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Paquetes Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Inventario Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CuentasPagar Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CuentasCobrar Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Gastos Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatClientes Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatProductos Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatPersonal Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatUnidades Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatCategorias Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatProveedores Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN CatNiveles Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN Configuracion Byte  default 1");
        //        new ClassGenerales().EjecutaQuery2("ALTER TABLE USUARIOS ADD COLUMN TiempoAire Byte  default 1");

        //        new ClassGenerales().EjecutaQuery2("update USUARIOS set Ventas=1,        CierreCaja=1,        CitasProveedores=1, " +
        //" Membresias=1,        Paquetes=1,        Inventario=1,        CuentasPagar=1,        CuentasCobrar=1, " +
        //" Gastos=1,        CatClientes=1,        CatProductos=1,        CatPersonal=1,        CatUnidades=1, " +
        //" CatCategorias=1,        CatProveedores=1,        CatNiveles=1,        Configuracion=1,        TiempoAire=1");
        //    }
        //    catch (Exception)
        //    {

        //    }




            Variables.dtConfiguracion = new ClassGenerales().ObtieneConfiguracion();
            txtUsuarioRed.Text = Desencriptar(Variables.dtConfiguracion.Rows[0]["UserRed"].ToString(), Variables.PassEncriptacion);
            txtPasswordRed.Text = Desencriptar(Variables.dtConfiguracion.Rows[0]["PassRed"].ToString(), Variables.PassEncriptacion);

            if (txtUsuarioRed.Text == "")
            {
                this.Height = 325;
            }
            //new ClassGenerales().EjecutaQuery2("delete from productos");


            ////creamos un objeto OpenDialog que es un cuadro de dialogo para buscar archivos
            //OpenFileDialog dialog = new OpenFileDialog();
            //dialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx"; //le indicamos el tipo de filtro en este caso que busque
            ////solo los archivos excel

            //dialog.Title = "Seleccione el archivo de Excel";//le damos un titulo a la ventana

            //dialog.FileName = string.Empty;//inicializamos con vacio el nombre del archivo

            ////si al seleccionar el archivo damos Ok
            //if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    LLenarGrid(dialog.FileName, "Hoja3"); //se manda a llamar al metodo

            //}    


        }


        private void LLenarGrid(string archivo, string hoja)
        {
            //declaramos las variables         
            OleDbConnection conexion = null;
            DataSet dataSet = null;
            OleDbDataAdapter dataAdapter = null;
            string consultaHojaExcel = "Select * from [" + hoja + "$]";

            //esta cadena es para archivos excel 2007 y 2010
            string cadenaConexionArchivoExcel = "provider=Microsoft.ACE.OLEDB.12.0;Data Source='" + archivo + "';Extended Properties=Excel 12.0;";

            //para archivos de 97-2003 usar la siguiente cadena
            //string cadenaConexionArchivoExcel = "provider=Microsoft.Jet.OLEDB.4.0;Data Source='" + archivo + "';Extended Properties=Excel 8.0;";

            //Validamos que el usuario ingrese el nombre de la hoja del archivo de excel a leer
            if (string.IsNullOrEmpty(hoja))
            {
                MessageBox.Show("No hay una hoja para leer");
            }
            else
            {
                try
                {
                    //Si el usuario escribio el nombre de la hoja se procedera con la busqueda
                    conexion = new OleDbConnection(cadenaConexionArchivoExcel);//creamos la conexion con la hoja de excel
                    conexion.Open(); //abrimos la conexion
                    dataAdapter = new OleDbDataAdapter(consultaHojaExcel, conexion); //traemos los datos de la hoja y las guardamos en un dataSdapter
                    dataSet = new DataSet(); // creamos la instancia del objeto DataSet
                    dataAdapter.Fill(dataSet, hoja);//llenamos el dataset

                    DataTable dtDatos = new DataTable();
                    dtDatos = dataSet.Tables[0];
                    //dataGridView1.DataSource = dataSet.Tables[0]; //le asignamos al DataGridView el contenido del dataSet
                    conexion.Close();//cerramos la conexion
                    //dataGridView1.AllowUserToAddRows = false;       //eliminamos la ultima fila del datagridview que se autoagrega

                    try
                    {
                        for (int i = 1; i < dtDatos.Rows.Count; i++)
                        {
                            new ClassGenerales().EjecutaQuery2(dtDatos.Rows[i]["F8"].ToString().ToUpper());
                        }
                    }
                    catch (Exception)
                    {

                    }

                }
                catch (Exception ex)
                {
                    //en caso de haber una excepcion que nos mande un mensaje de error
                    MessageBox.Show("Error, Verificar el archivo o el nombre de la hoja", ex.Message);
                }
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Entrar();
            }
        }


        private void Entrar()
        {
            
            string Valor = Desencriptar(Variables.dtConfiguracion.Rows[0]["Licencia"].ToString(), Variables.PassEncriptacion);
            string[] Valor2 = Valor.Split(':');

            if (Valor2.Length == 1)
            {
                //if (Dns.GetHostName() != Valor)
                //{
                //    MessageBox.Show("La licencia no es valida, favor de contactar al administrador.", "Licencia no valida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtusuario.Focus();
                //    return;
                //}
            }
            else
            {
                //DateTime FechaLicenciaVence = Convert.ToDateTime(Valor2[1]).AddDays(15);

                //if (FechaLicenciaVence < DateTime.Now)
                //{
                //    MessageBox.Show("La version demo finalizo, pongase en contacto con el administrador.", "Licencia no valida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtusuario.Focus();
                //    return;
                //}
            }





            if (txtusuario.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un usuario.", "Usuario no Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtusuario.Focus();
                return;
            }


            if (txtpassword.Text == string.Empty)
            {
                MessageBox.Show("Ingrese una contraseña.", "Usuario no Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Focus();
                return;
            }

            string msg = new ClassGenerales().ValidaUsuario(txtusuario.Text, txtpassword.Text);
            if (msg == "El usuario no existe")
            {
                MessageBox.Show("Verique el Nombre de Usuario y Contraseña", "Usuario no Valido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtpassword.Text = "";
                txtpassword.Focus();
            }
            else
            {

                if (new ClassGenerales().AccesoInternet())
                {


                    if (Variables.dtConfiguracion.Rows[0]["UserRed"].ToString() == string.Empty)
                    {
                        MessageBox.Show("Registre el Usuario RedMandados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuarioRed.Text = "";
                        txtUsuarioRed.Focus();
                        this.Height = 325;
                        return;
                    }

                    if (Variables.dtConfiguracion.Rows[0]["PassRed"].ToString() == string.Empty)
                    {
                        MessageBox.Show("Registre el Password RedMandados.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPasswordRed.Text = "";
                        txtPasswordRed.Focus();
                        this.Height = 325;
                        return;
                    }
                    /*
                    DataTable dtDatos = new ClassGenerales().EjecutaQueryMysql("SELECT cEmail,cPassword,bActivo FROM 
                    " +
                        " WHERE cEmail='" +Desencriptar( Variables.dtConfiguracion.Rows[0]["UserRed"].ToString(),Variables.PassEncriptacion) +
                        "' AND cPassword='" + Desencriptar(Variables.dtConfiguracion.Rows[0]["PassRed"].ToString(), Variables.PassEncriptacion)+"'");

                    if (dtDatos.Rows.Count == 0)
                    {
                        MessageBox.Show("La licencia no esta registrada en la base de datos.", "Licencia no valida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (dtDatos.Rows.Count > 0)
                    {
                        if (dtDatos.Rows[0]["bActivo"].ToString() == "0")
                        {
                            MessageBox.Show("Contacte al administrador para renovar su licencia.", "Licencia no valida.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    */

                }




                Variables.Usuario = msg;
                Variables.NombreEmpresa = Variables.dtConfiguracion.Rows[0]["RazonSocial"].ToString();
                //new ClassGenerales().Correo();
                MDIMenu principal = new MDIMenu();
                principal.Show();
                this.Hide();
            }
        }

        private void txtusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtpassword.Focus();
            }
        }

        private void btnLicencia_Click(object sender, EventArgs e)
        {
            if (txtPassLicencia.Text == string.Empty)
            {
                MessageBox.Show("Verique la Contraseña.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassLicencia.Text = "";
                txtPassLicencia.Focus();
                return;
            }

            if (txtUsuarioRed.Text == string.Empty)
            {
                MessageBox.Show("Verique el Usuario RedMandados", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioRed.Text = "";
                txtUsuarioRed.Focus();
                return;
            }


            if (txtPasswordRed.Text == string.Empty)
            {
                MessageBox.Show("Verique el Password RedMandados", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPasswordRed.Text = "";
                txtPasswordRed.Focus();
                return;
            }

            
            if (Variables.PassEncriptacion == txtPassLicencia.Text || txtPassLicencia.Text == "demo")
            {
                bool Inserto = false;

                if (txtPassLicencia.Text == "demo")
                {
                    Inserto = new ClassGenerales().EjecutaQuery2("update Configuracion set Licencia='" + 
                        Encriptar("demo:" + DateTime.Now.ToString("dd-MM-yyyy"), Variables.PassEncriptacion) + "'");
                }
                else
                {
                    Inserto = new ClassGenerales().EjecutaQuery2("update Configuracion set Licencia='" + 
                        Encriptar(Dns.GetHostName(), Variables.PassEncriptacion) + "'");
                }

                if (Inserto)
                {
                    MessageBox.Show("Se registro correctamente la licencia a nombre del equipo: " + Dns.GetHostName(), "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Clipboard.SetText(Dns.GetHostName());
                    Inserto = new ClassGenerales().EjecutaQuery2("delete from venta");
                   
                    Inserto = new ClassGenerales().EjecutaQuery2("update Configuracion set UserRed='" + 
                        Encriptar(txtUsuarioRed.Text.Trim(), Variables.PassEncriptacion) + 
                       "',PassRed='" + Encriptar(txtPasswordRed.Text.Trim(), Variables.PassEncriptacion) + "';");

                    Variables.dtConfiguracion = new ClassGenerales().ObtieneConfiguracion();

                    txtUsuarioRed.Text = Desencriptar(Variables.dtConfiguracion.Rows[0]["UserRed"].ToString(), Variables.PassEncriptacion);
                    txtPasswordRed.Text = Desencriptar(Variables.dtConfiguracion.Rows[0]["PassRed"].ToString(), Variables.PassEncriptacion);
                }
                else
                {
                    MessageBox.Show("Fallo el registro de licencia.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La contraseña del registro es incorrecta.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassLicencia.Text = "";
                txtPassLicencia.Focus();
                return;
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



        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (this.Height == 215)
            {
                this.Height = 325;
            }
            else if (this.Height == 325)
            {
                this.Height = 215;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    }
}
