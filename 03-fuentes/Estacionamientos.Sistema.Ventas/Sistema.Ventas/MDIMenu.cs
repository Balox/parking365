using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using Sistema.Ventas.Catalogos;
using Facturacion.Electronica;
using System.Threading;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;


namespace Sistema.Ventas
{
    public partial class MDIMenu : Form
    {

        public MDIMenu()
        {
            InitializeComponent();
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient)
                {
                    control.BackgroundImage = System.Drawing.Image.FromFile(Application.StartupPath + "/Logo.png");
                    control.BackgroundImageLayout = ImageLayout.Center;
                    control.BackColor = Color.Tomato;
                    //Properties.Resources.duk;

                    break;
                }
            }
        }

        Panel panal = new Panel();
        private void MDIMenu_Load(object sender, EventArgs e)
        {


            ElementHost host = new ElementHost();
            RibbonMenu uc = new RibbonMenu();


            host.Dock = DockStyle.Fill;
            host.Child = uc;

            panal.Controls.Add(host);
            panal.Anchor = AnchorStyles.Top;
            panal.Height = 135;
            panal.Width = 2000;
            panal.Dock = DockStyle.Left;
            panal.Dock = DockStyle.Top;
            this.Controls.Add(panal);

            uc.AsignaSesion("Cerrar sesión [" + Variables.Usuario + "]");
            //Me.Text = Me.Text + " " + gsBaseDatos
            //ToolStripStatusLabel.Text = gsNombreUsuario + " " + gsServidor + " BASE DE DATOS [" + User.sii_BaseDatos + "]"

        }



        public void AbrirCatalogoPersonal()
        {
            //    CatPersonal form3 = new CatPersonal();
            //    form3.MdiParent = MDIMenu.ActiveForm;
            //    form3.Show();

            if (ValidaPermisos("CatPersonal") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ValidaFormularioAbierto("CatPersonal") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatPersonal");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatPersonal form3 = new CatPersonal();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void Cerrar()
        {
            Application.Exit();
        }


        private Form ValidaFormularioAbiertoForm(string Form)
        {
            Form instForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == Form).SingleOrDefault();
            return instForm;
        }


        private bool ValidaPermisos(string Form)
        {
            string Query = "SELECT * FROM USUARIOS where iCveUsuarios=" + Variables.iCveUsuario;
            switch (Form)
            {
                case "Ventas": Query += " and Ventas=1"; break;
                case "Cierre": Query += " and CierreCaja=1"; break;
                case "CatCitas": Query += " and CitasProveedores=1"; break;
                case "Membresias": Query += " and Membresias=1"; break;
                case "Paquetes": Query += " and Paquetes=1"; break;
                case "CatProductosInventario": Query += " and Inventario=1"; break;
                case "PorPagar": Query += " and CuentasPagar=1"; break;
                case "PorCobrar": Query += " and CuentasCobrar=1"; break;
                case "Gastos": Query += " and Gastos=1"; break;
                case "CatClientes": Query += " and CatClientes=1"; break;
                case "CatProductos": Query += " and CatProductos=1"; break;
                case "CatPersonal": Query += " and CatPersonal=1"; break;
                case "CatUnidad": Query += " and CatUnidades=1"; break;
                case "CatCategorias": Query += " and CatCategorias=1"; break;
                case "CatProveedores": Query += " and CatProveedores=1"; break;
                case "CatNiveles": Query += " and CatNiveles=1"; break;
                case "CatConfiguracion": Query += " and Configuracion=1"; break;
            }

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);
            if (dtDatos.Rows.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        private Boolean ValidaFormularioAbierto(string Form)
        {

            Form instForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == Form).SingleOrDefault();

            if (instForm != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



        public void AbrirCatalogoClientes()
        {
            if (ValidaPermisos("CatClientes") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatClientes") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("CatClientes");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatClientes form3 = new CatClientes();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirCatalogoCitas()
        {
            if (ValidaPermisos("CatCitas") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatCitas") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatCitas");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatCitas form3 = new CatCitas();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirCatalogoProductos()
        {
            if (ValidaPermisos("CatProductos") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatProductos") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatProductos");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatProductos form3 = new CatProductos();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void AbrirVentas()
        {
            if (ValidaPermisos("Ventas") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Ventas") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("Ventas");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Ventas form3 = new Ventas();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }





        public void AbrirCatalogoUnidades()
        {
            if (ValidaPermisos("CatUnidad") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatUnidad") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatUnidad");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatUnidad form3 = new CatUnidad();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirCatalogoCategorias()
        {
            if (ValidaPermisos("CatCategorias") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatCategorias") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatCategorias");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatCategorias form3 = new CatCategorias();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void AbrirCatalogoProveedores()
        {
            if (ValidaPermisos("CatProveedores") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatProveedores") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatProveedores");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatProveedores form3 = new CatProveedores();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void AbrirCatalogoConfiguracion()
        {
            if (ValidaPermisos("CatConfiguracion") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatConfiguracion") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatConfiguracion");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatConfiguracion form3 = new CatConfiguracion();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirCierre()
        {
            if (ValidaPermisos("Cierre") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Cierre") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("Cierre");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Cierre form3 = new Cierre();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AjustarRibbonAbrir()
        {
            //MDIMenu.ActiveForm;
            panal.Height = 45;
        }

        public void AjustarRibbonCerrar()
        {
            panal.Height = 135;
        }


        public void AbrirCatalogoNiveles()
        {
            if (ValidaPermisos("CatNiveles") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatNiveles") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatNiveles");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatNiveles form3 = new CatNiveles();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirMembresias()
        {
            if (ValidaPermisos("Membresias") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Membresias") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("Membresias");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Membresias form3 = new Membresias();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirPaquetes()
        {
            if (ValidaPermisos("Paquetes") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Paquetes") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("Paquetes");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Paquetes form3 = new Paquetes();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirInventario()
        {
            if (ValidaPermisos("CatProductosInventario") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatProductosInventario") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("CatProductosInventario");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatProductosInventario form3 = new CatProductosInventario();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void AbrirCuentasPorPagar()
        {
            if (ValidaPermisos("PorPagar") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("PorPagar") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("PorPagar");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                PorPagar form3 = new PorPagar();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirCuentasPorCobrar()
        {
            if (ValidaPermisos("PorCobrar") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("PorCobrar") == true)
            {
                //MessageBox.Show("No es posible abrir el modulo 2 veces..", "J&R", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Form abierto = ValidaFormularioAbiertoForm("PorCobrar");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                PorCobrar form3 = new PorCobrar();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirGastos()
        {
            if (ValidaPermisos("Gastos") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Gastos") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("Gastos");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Gastos form3 = new Gastos();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        public void AbrirEstacionamiento()
        {
            if (ValidaPermisos("Estacionar") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("Estacionar") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("Estacionar");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                Estacionar form3 = new Estacionar();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }



        public void AbrirMarcas()
        {
            if (ValidaPermisos("CatMarcas") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatMarcas") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("CatMarcas");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatMarcas form3 = new CatMarcas();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirModelo()
        {
            if (ValidaPermisos("CatModelos") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatModelos") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("CatModelos");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatModelos form3 = new CatModelos();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }


        public void AbrirColores()
        {
            if (ValidaPermisos("CatColores") == false)
            {
                MessageBox.Show("No tiene permisos para abrir esta pantalla.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (ValidaFormularioAbierto("CatColores") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("CatColores");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatColores form3 = new CatColores();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }

        }

        private void Alertas_Tick(object sender, EventArgs e)
        {
            ThreadStart delegado = new ThreadStart(Correo);
            Thread hilo = new Thread(delegado);
            hilo.Start();
            //new ClassGenerales().Correo();
            hilo.Join();
        }


        private void Correo()
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
            try
            {
                //new ClassGenerales().EnviaSMS("2225269012", "Pago nuevo, estacion " + cbMotivo.Text + " Monto: " + txtCantidad.Text);
                // new ClassGenerales().EnviaSMS("2227109722", "Pago nuevo, estacion " + cbEstaciones.Text + " Monto: " + txtCantidad.Text);
            }
            catch (Exception)
            {

            }
        }



        private Double CargaCierre()
        {
            try
            {
                Double Total = 0;

                string sInicial = DateTime.Now.ToString("MM/dd/yyyy");
                string sFinal = DateTime.Now.AddDays(1).ToString("MM/dd/yyyy");

                string Query = "SELECT  sum( venta.Total) as Total FROM venta ";

                Query += " where venta.fFecha between #" + sInicial + "# and #" + sFinal + "# ";

                Query += " and venta.iStatus=1";

                DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

                if (dtDatos.Rows.Count > 0)
                {
                    Total = Convert.ToDouble(dtDatos.Rows[0]["Total"]);
                }
                return Total;
            }
            catch (Exception)
            {

                return 0;
            }

        }


    }
}
