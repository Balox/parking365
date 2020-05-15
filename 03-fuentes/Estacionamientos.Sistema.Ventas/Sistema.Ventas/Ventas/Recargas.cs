using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;
using Sistema.Ventas.Clases;
using System.Xml;
using System.Security.Cryptography;

namespace Sistema.Ventas
{
    public partial class Recargas : Form
    {
        public Recargas()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(cerrar_form);
        }

        void cerrar_form(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 27)
            {
                this.Close();
            }
        }


        public string Usuario = Desencriptar(Variables.dtConfiguracion.Rows[0]["UsuarioTAE"].ToString(), Variables.PassEncriptacion);//"demo123456";
        public string Contraseña = Desencriptar(Variables.dtConfiguracion.Rows[0]["ContrasenaTAE"].ToString(), Variables.PassEncriptacion);//"Demo123456";

        private void Recargas_Load(object sender, EventArgs e)
        {
            Compañias();
        }

        private void Compañias()
        {
            DataTable table = new DataTable();
            table.Columns.Add("Clave", typeof(string));
            table.Columns.Add("Concepto", typeof(string));

            table.Rows.Add("1", "Telcel");
            table.Rows.Add("2", "Movistar");
            table.Rows.Add("3", "Unefon");
            table.Rows.Add("4", "Iusacell");
            table.Rows.Add("5", "Nextel");
            table.Rows.Add("6", "Virgin");
            table.Rows.Add("7", "Cierto");
            table.Rows.Add("8", "Maztiempo");
            table.Rows.Add("9", "Alo");

            ComboCompañia.DataSource = table;
            ComboCompañia.ValueMember = "Clave";
            ComboCompañia.DisplayMember = "Concepto";
            ComboCompañia.SelectedIndex = 0;
        }

        private void btnConsultarSaldo_Click(object sender, EventArgs e)
        {
            wsRecargas.ApplicationServicesPortTypeClient Cliente = new wsRecargas.ApplicationServicesPortTypeClient();
            string Cadena = "<Recarga><Usuario>" + Usuario + "</Usuario><Passwd>" + Contraseña + "</Passwd></Recarga>";
            string Resultado = Cliente.ObtenSaldo(Cadena);
            XmlDocument xm = new XmlDocument();
            xm.LoadXml(Resultado);
            XmlNodeList Exito = xm.GetElementsByTagName("Saldo");
            XmlNodeList Error = xm.GetElementsByTagName("Error");

            if (Exito.Count > 0)
            {
                txtSaldo.Text = Exito[0].InnerXml;
            }

            if (Error.Count > 0)
            {
                MessageBox.Show(Error[0].InnerXml, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {

            if (txtTelefono.Text.Length != 10)
            {
                MessageBox.Show("El Teléfono debe ser de 10 digitos", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            if (txtConfirmaTelefono.Text.Length != 10)
            {
                MessageBox.Show("El Teléfono confirmación debe ser de 10 digitos", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmaTelefono.Focus();
                return;
            }

            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese el Teléfono", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefono.Focus();
                return;
            }

            if (txtConfirmaTelefono.Text.Trim() == "")
            {
                MessageBox.Show("Ingrese la confirmación del telefono", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtConfirmaTelefono.Focus();
                return;
            }

            if (txtTelefono.Text.Trim() != txtConfirmaTelefono.Text.Trim())
            {
                MessageBox.Show("El teléfono no es igual a la confirmación", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DialogResult Resultadoss = MessageBox.Show("Se realizara una recarga de $" + ComboMonto.Text + " al número " + txtTelefono.Text.Trim() + ", ¿Es correcto? ", "Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultadoss == System.Windows.Forms.DialogResult.Yes)
            {

            }
            else
            {
                return;
            }


            string Cadena = "<Recarga>";
            Cadena = Cadena + "<Usuario>" + Usuario + "</Usuario>";
            Cadena = Cadena + "<Passwd>" + Contraseña + "</Passwd>";
            Cadena = Cadena + "<Telefono>" + txtTelefono.Text.Trim() + "</Telefono>";
            Cadena = Cadena + "<Carrier>" + ComboCompañia.Text + "</Carrier>";
            Cadena = Cadena + "<Monto>" + ComboMonto.SelectedValue + "</Monto>";
            Cadena = Cadena + "</Recarga>";

            wsRecargas.ApplicationServicesPortTypeClient Cliente = new wsRecargas.ApplicationServicesPortTypeClient();
            //string Resultado = Cliente.RecargaEWS(Cadena);
            string Resultado = "";
            if (ComboMonto.SelectedValue.ToString() == "20006" ||
   ComboMonto.SelectedValue.ToString() == "30006" ||
   ComboMonto.SelectedValue.ToString() == "50006" ||
   ComboMonto.SelectedValue.ToString() == "100006" ||
   ComboMonto.SelectedValue.ToString() == "150006" ||
   ComboMonto.SelectedValue.ToString() == "200006" ||
   ComboMonto.SelectedValue.ToString() == "300006" ||
   ComboMonto.SelectedValue.ToString() == "500006" ||
   ComboMonto.SelectedValue.ToString() == "10007" ||
   ComboMonto.SelectedValue.ToString() == "20007" ||
   ComboMonto.SelectedValue.ToString() == "29007" ||
   ComboMonto.SelectedValue.ToString() == "49007" ||
   ComboMonto.SelectedValue.ToString() == "99007" ||
   ComboMonto.SelectedValue.ToString() == "149007" ||
   ComboMonto.SelectedValue.ToString() == "249007")
            {
                Resultado = Cliente.Paquetes(Cadena);
            }
            else
            {
                Resultado = Cliente.RecargaEWS(Cadena);
            }


            XmlDocument xm = new XmlDocument();
            xm.LoadXml(Resultado);

            XmlNodeList Exito = xm.GetElementsByTagName("Folio");
            XmlNodeList Error = xm.GetElementsByTagName("Error");

            if (Exito.Count > 0)
            {
                XmlNodeList Cantidad = xm.GetElementsByTagName("Cantidad");
                XmlNodeList Telefono = xm.GetElementsByTagName("Telefono");
                XmlNodeList Carrier = xm.GetElementsByTagName("Carrier");
                MessageBox.Show("Recarga Exitosa... " +
                    "\nFolio: " + Exito[0].InnerXml +
                    "\nCantidad: " + ComboMonto.Text +//Cantidad[0].InnerXml +
                    "\nTelefono; " + Telefono[0].InnerXml +
                    "\nCompañia :" + Carrier[0].InnerXml, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtConfirmaTelefono.Text = "";
                txtTelefono.Text = "";
                Compañias();
                ChecarSaldo();

            }

            if (Error.Count > 0)
            {
                MessageBox.Show("NO se realizo la recarga (" + Error[0].InnerXml + ") ", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //<Recarga><Resultado><Error>Producto no disponible</Error></Resultado></Recarga>
            //<Recarga><Resultado><Folio>198503</Folio><Cantidad>10</Cantidad>
            //    <Telefono>2221711391</Telefono><Carrier>Movistar</Carrier></Resultado></Recarga>
        }

        private void ChecarSaldo()
        {
            try
            {
                wsRecargas.ApplicationServicesPortTypeClient Cliente = new wsRecargas.ApplicationServicesPortTypeClient();
                string Cadena = "<Recarga><Usuario>" + Usuario + "</Usuario><Passwd>" + Contraseña + "</Passwd></Recarga>";
                string Resultado = Cliente.ObtenSaldo(Cadena);
                XmlDocument xm = new XmlDocument();
                xm.LoadXml(Resultado);
                XmlNodeList Exito = xm.GetElementsByTagName("Saldo");
                XmlNodeList Error = xm.GetElementsByTagName("Error");

                if (Exito.Count > 0)
                {
                    txtSaldo.Text = Exito[0].InnerXml;
                }

                if (Error.Count > 0)
                {
                    MessageBox.Show(Error[0].InnerXml, "Recarga de tiempo aire", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recarga de tiempo aire", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ComboCompañia_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (ComboCompañia.Text)
            {
                case "Telcel": Telcel(); break;
                case "Movistar": Movistar(); break;
                case "Unefon": Unefon(); break;
                case "Iusacell": Iusacell(); break;
                case "Nextel": Nextel(); break;
                case "Virgin": Virgin(); break;
                case "Cierto": Cierto(); break;
                case "Maztiempo": Maztiempo(); break;
                case "Alo": Alo(); break;
            }

        }

        private void Iusacell()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");

            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }

        private void Alo()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }

        private void Maztiempo()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("60", "$60");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("120", "$120");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }


        private void Cierto()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));

            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }


        private void Virgin()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));

            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("40", "$40");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }


        private void Unefon()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            table2.Rows.Add("750", "$750");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }

        private void Nextel()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("500", "$500");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }



        private void Movistar()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("40", "$40");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("60", "$60");
            table2.Rows.Add("70", "$70");
            table2.Rows.Add("80", "$80");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("120", "$120");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("250", "$250");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("400", "$400");
            table2.Rows.Add("500", "$500");
            //Paquetes
            table2.Rows.Add("10007", "Internet 1 día | 30 Megas + 1GB para WhatsApp x $10.00");
            table2.Rows.Add("20007", "Internet 2 días | 60 Megas + 1GB para WhatsApp x $20.00");
            table2.Rows.Add("29007", "Internet 3 días | 100 Megas + 1GB para WhatsApp x $29.00");
            table2.Rows.Add("49007", "Internet 7 días | 200 Megas + 1GB para WhatsApp y Twitter x $49.00");
            table2.Rows.Add("99007", "Internet 15 días | 600 Megas + 1GB para WhatsApp, Facebook y Twitter x $99.00");
            table2.Rows.Add("149007", "Internet 30 | 1 GB + 1GB para WhatsApp, Facebook y Twitter x $149.00");
            table2.Rows.Add("249007", "Internet 30 PLUS | 2 GB + 1GB para WhatsApp, Facebook y Twitter x $249.00");
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
        }





        private void Telcel()
        {
            DataTable table2 = new DataTable();
            table2.Columns.Add("Clave", typeof(string));
            table2.Columns.Add("Concepto", typeof(string));
            table2.Rows.Add("10", "$10");
            table2.Rows.Add("20", "$20");
            table2.Rows.Add("30", "$30");
            table2.Rows.Add("50", "$50");
            table2.Rows.Add("100", "$100");
            table2.Rows.Add("150", "$150");
            table2.Rows.Add("200", "$200");
            table2.Rows.Add("300", "$300");
            table2.Rows.Add("500", "$500");
            //Paquetes
            table2.Rows.Add("20006", "Sin límite 20 | 30 MB | WhatsApp 200 MB | Vigencia 1 día");
            table2.Rows.Add("30006", "Sin límite 30 | 40 MB | WhatsApp 300 MB | Vigencia 3 días");
            table2.Rows.Add("50006", "Sin límite 50 | 100 Megas | SMS, Llamadas ilimitado, Redes Sociales 500 MB | Vigencia 7 días");
            table2.Rows.Add("100006", "Sin límite 100 | 300 Megas | SMS, Llamadas ilimitado, Redes Sociales 1000 MB | Vigencia 21 días");
            table2.Rows.Add("150006", "Sin límite 150 | 600 Megas | SMS, Llamadas ilimitado, Redes Sociales 1500 MB | Vigencia 28 días");
            table2.Rows.Add("200006", "Sin límite 200 | 1000 Megas | SMS, Llamadas ilimitado, Redes Sociales 1500 MB | Vigencia 33 días");
            table2.Rows.Add("300006", "Sin límite 300 | 1500 Megas | SMS, Llamadas ilimitado, Redes Sociales 1500 MB | Vigencia 40 días");
            table2.Rows.Add("500006", "Sin límite 500 | 2500 Megas | SMS, Llamadas ilimitado, Redes Sociales 1500 MB | Vigencia 45 días");
            //Fin Paquetes
            ComboMonto.DataSource = table2;
            ComboMonto.ValueMember = "Clave";
            ComboMonto.DisplayMember = "Concepto";
            ComboMonto.SelectedIndex = 0;
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



    }
}
