using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;
using System.IO;
using System.Security.Cryptography;

namespace Sistema.Ventas.Catalogos
{
    public partial class CatConfiguracion : Form
    {
        public CatConfiguracion()
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


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Double Dias = txtDias.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDias.Text) == true ? Convert.ToDouble(txtDias.Text) : 0;
            Double DiasAviso = txtAviso.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtAviso.Text) == true ? Convert.ToDouble(txtAviso.Text) : 0;
            Double Capacidad = txtCapacidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCapacidad.Text) == true ? Convert.ToDouble(txtCapacidad.Text) : 0;
            Double Hora = txtHora.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtHora.Text) == true ? Convert.ToDouble(txtHora.Text) : 0;

            Double CelAlertas = txtCelAlertas.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCelAlertas.Text) == true ? Convert.ToDouble(txtCelAlertas.Text) : 0;

            if (txtCarpetaTickets.Text == "")
            {
                MessageBox.Show("La ruta para almacenar los tickets no puede quedarse vacia.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }



            try
            {
                bool Inserto = new ClassGenerales().EjecutaQuery2("update Configuracion set Impresora='" + txtImpresora.Text + "', RazonSocial='" + txtRazonSocial.Text +
                       "', RFC='" + txtRFC.Text + "', " +
                       "Domicilio='" + txtDomicilio.Text + "', Ciudad='" + txtCiudad.Text + "', Estado='" + txtEstado.Text +
                       "', Telefono='" + txtTelefono.Text + "', Email='" + txtEmail.Text + "', Saludo='" + txtSaludo.Text +
                       "', Logo='" + txtLogo.Text + "',DiasCitas=" + Dias + ",CarpetaTicket='" + txtCarpetaTickets.Text +
                       "',Aviso='" + DiasAviso + "',UsuarioTAE='" + Encriptar(txtUsuarioTAE.Text.Trim(), Variables.PassEncriptacion) +
                       "',ContrasenaTAE='" + Encriptar(txtContraseñaTAE.Text.Trim(), Variables.PassEncriptacion) +
                       "',UserRed='" + Encriptar(txtUsuarioRed.Text.Trim(), Variables.PassEncriptacion) +
                       "',PassRed='" + Encriptar(txtPasswordRed.Text.Trim(), Variables.PassEncriptacion) + "',Capacidad=" + Capacidad + ",Hora=" + Hora +
                       ",Direccion2='" + txtDireccion2.Text + "',RFC2='" + txtRFC2.Text + "',Telefono2='" + txtTelefono2.Text + "',Horarios='" + txtHorarios.Text +
                       "',CelAlertas='" + CelAlertas + "',EmailAlertas='" + txtEmailAlertas.Text.Trim() + "';");

                if (Inserto == true)
                {
                    MessageBox.Show("Se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                Variables.dtConfiguracion = new ClassGenerales().ObtieneConfiguracion();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CatConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dtDatos = new ClassGenerales().ObtieneConfiguracion();

                if (dtDatos.Rows.Count > 0)
                {
                    Variables.dtConfiguracion = dtDatos;
                    txtImpresora.Text = dtDatos.Rows[0]["Impresora"].ToString().Trim();
                    txtRazonSocial.Text = dtDatos.Rows[0]["RazonSocial"].ToString();
                    txtRFC.Text = dtDatos.Rows[0]["RFC"].ToString();
                    txtDomicilio.Text = dtDatos.Rows[0]["Domicilio"].ToString();
                    txtCiudad.Text = dtDatos.Rows[0]["Ciudad"].ToString();
                    txtEstado.Text = dtDatos.Rows[0]["Estado"].ToString();
                    txtTelefono.Text = dtDatos.Rows[0]["Telefono"].ToString();
                    txtEmail.Text = dtDatos.Rows[0]["Email"].ToString();
                    txtSaludo.Text = dtDatos.Rows[0]["Saludo"].ToString();
                    txtLogo.Text = dtDatos.Rows[0]["Logo"].ToString();
                    txtDias.Text = dtDatos.Rows[0]["DiasCitas"].ToString();
                    txtCarpetaTickets.Text = dtDatos.Rows[0]["CarpetaTicket"].ToString();
                    txtAviso.Text = dtDatos.Rows[0]["Aviso"].ToString();

                    txtUsuarioTAE.Text = Desencriptar(dtDatos.Rows[0]["UsuarioTAE"].ToString(), Variables.PassEncriptacion);
                    txtContraseñaTAE.Text = Desencriptar(dtDatos.Rows[0]["ContrasenaTAE"].ToString(), Variables.PassEncriptacion);

                    txtUsuarioRed.Text = Desencriptar(dtDatos.Rows[0]["UserRed"].ToString(), Variables.PassEncriptacion);
                    txtPasswordRed.Text = Desencriptar(dtDatos.Rows[0]["PassRed"].ToString(), Variables.PassEncriptacion);

                    txtCapacidad.Text = dtDatos.Rows[0]["Capacidad"].ToString();
                    txtHora.Text = dtDatos.Rows[0]["Hora"].ToString();

                    txtDireccion2.Text = dtDatos.Rows[0]["Direccion2"].ToString();
                    txtRFC2.Text = dtDatos.Rows[0]["RFC2"].ToString();
                    txtTelefono2.Text = dtDatos.Rows[0]["Telefono2"].ToString();

                    txtHorarios.Text = dtDatos.Rows[0]["Horarios"].ToString();

                    txtCelAlertas.Text = dtDatos.Rows[0]["CelAlertas"].ToString().Trim();
                    txtEmailAlertas.Text = dtDatos.Rows[0]["EmailAlertas"].ToString().Trim();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnImpresora_Click(object sender, EventArgs e)
        {
            PrintDialog pDialog = new PrintDialog();



            var print = pDialog.ShowDialog();

            if (print.ToString() == "OK")
            {
                txtImpresora.Text = pDialog.PrinterSettings.PrinterName;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtLogo.Text = ((System.Windows.Forms.FileDialog)(openFileDialog1)).FileName;
            }
        }

        private void btnCarpeta_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtCarpetaTickets.Text = folderBrowserDialog1.SelectedPath;
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

        private void btnRespaldo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se realizara el respaldo de la base de datos \nPor favor de click en OK y despues seleccione la carpeta donde se almacenara el respaldo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Question);
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(folderBrowserDialog1.SelectedPath + "\\" + DateTime.Now.ToString("dd_MM_yy HH_MM") + "PuntoVenta.mdb"))
                {
                    File.Copy(Application.StartupPath + "\\PuntoVenta.mdb", folderBrowserDialog1.SelectedPath + "\\" + DateTime.Now.ToString("dd_MM_yy HH_MM") + "PuntoVenta.mdb");
                    MessageBox.Show("El respaldo se realizo correctamente en la siguiente ruta: " + folderBrowserDialog1.SelectedPath + "\\" + DateTime.Now.ToString("dd_MM_yy HH_MM") + "PuntoVenta.mdb", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Desea realizar la limpieza del catalogo de marcas y modelos? ", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == System.Windows.Forms.DialogResult.Yes)
            {
                new ClassGenerales().EjecutaQuery2("delete from CatMarcas;");
                new ClassGenerales().EjecutaQuery2("delete from CatModelo;");
                MessageBox.Show("Eliminación correcta!", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                return;
            }
        }




    }
}
