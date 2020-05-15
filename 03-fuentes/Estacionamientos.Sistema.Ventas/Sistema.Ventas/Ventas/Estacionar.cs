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
using Sistema.Ventas.Reportes;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Drawing.Imaging;


namespace Sistema.Ventas
{
    public partial class Estacionar : Form
    {
        int Horas = 0;
        public Estacionar()
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblHora.Refresh();

            lblFecha.Text = DateTime.Now.ToShortDateString();
            lblFecha.Refresh();
        }

        private void Estacionar_Load(object sender, EventArgs e)
        {
            ComboMarca.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveMarca from CatMarcas order by cDesc");
            ComboMarca.DisplayMember = "cDesc";
            ComboMarca.ValueMember = "iCveMarca";
            ComboMarca.SelectedIndex = -1;
            CargaGrid();
            ComboTicket.DataSource = new ClassGenerales().EjecutaQuery("select '1' as Texto,1 as Valor from configuracion union select '2' as Texto,2 as Valor from configuracion");
            ComboTicket.DisplayMember = "Texto";
            ComboTicket.ValueMember = "Valor";
            //ComboTicket.SelectedIndex = -1;

            ComboColor.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveColor from Colores order by cDesc");
            ComboColor.DisplayMember = "cDesc";
            ComboColor.ValueMember = "iCveColor";
            ComboColor.SelectedIndex = -1;
        }

        private void CargaGrid()
        {

           // if (Variables.iCveUsuarioAdministrador == 1)
           // {


                string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
                string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("select Id,Marca ,Modelo ,Placas,Entrada ,Salida ,Total ,Switch(Estatus=0,'No Pagado',Estatus=1,'Pagado') AS Estatus,Tarifa,Color from Estacionamiento  where Entrada between #" + sInicial + "# and #" + sFinal + "#  order by Id desc ");
                GridHistorial.DataSource = null;
                if (dtDatos.Rows.Count > 0)
                {
                    GridHistorial.DataSource = dtDatos;
                    this.GridHistorial.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                    this.GridHistorial.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                    GridHistorial.Columns[0].Width = 50;
                    GridHistorial.Columns[4].Width = 160;
                    GridHistorial.Columns[5].Width = 160;
                    int count = 0;
                    for (int i = 0; i < dtDatos.Rows.Count; i++)
                    {
                        if (dtDatos.Rows[i]["Estatus"].ToString() == "No Pagado")
                        {
                            count++;
                        }
                    }

                    txtVehiculos.Text = count.ToString();

                }
            //}
                CalculaCupo();
            
        }

        private void CalculaCupo()
        {
            DataTable dtDatos = new ClassGenerales().ObtieneConfiguracion();
            if (dtDatos.Rows.Count > 0)
            {
                txtCupo.Text = dtDatos.Rows[0]["Capacidad"].ToString();
                //txtCostoHora.Text = dtDatos.Rows[0]["Hora"].ToString();
            }

            Double Cupo = txtCupo.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCupo.Text) == true ? Convert.ToDouble(txtCupo.Text) : 0;
            Double Vehiculos = txtVehiculos.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtVehiculos.Text) == true ? Convert.ToDouble(txtVehiculos.Text) : 0;
            txtDisponibles.Text = String.Format("{0:0,0}", Cupo - Vehiculos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Registra();
        }


        private void CreaPDF()
        {
            //string htmlText = "  <table style='width: 100%;'><tr><td>jesus</td><td>cruz</td><td>alvarez</td></tr></table>";
            //Document document = new Document();
            //PdfWriter.GetInstance(document, new FileStream("C:\\CFDI\\MySamplePDF.pdf", FileMode.Create));
            //document.Open();
            //iTextSharp.text.html.simpleparser.HTMLWorker hw =
            //             new iTextSharp.text.html.simpleparser.HTMLWorker(document);
            //hw.Parse(new StringReader(htmlText));
            //document.Close();
        }


        private void Registra()
        {
            if (ComboMarca.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione la marca del vehiculo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboMarca.Focus();
                return;
            }
            if (ComboModelo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione el Modelo del vehiculo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboModelo.Focus();
                return;
            }
            if (txtPlacas.Text == "")
            {
                MessageBox.Show("Ingrese las placas del vehiculo", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlacas.Focus();
                return;
            }

            if (txtColor.Text == "")
            {
                MessageBox.Show("Ingrese el color del vehiculo", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtColor.Focus();
                return;
            }

            Double Hora = txtCostoHora.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCostoHora.Text) == true ? Convert.ToDouble(txtCostoHora.Text) : 0;

            if (Hora == 0)
            {
                MessageBox.Show("El modelo no tiene tarifa capturada.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPlacas.Focus();
                return;
            }

            Boolean Inserto = false;
            Inserto = new ClassGenerales().EjecutaQuery2("insert into Estacionamiento " +
                " (Marca ,Modelo ,Placas,Entrada ,Total ,Estatus,Tarifa,Color) values (" +
                "'" + ComboMarca.Text.Trim() + "' ,'" + ComboModelo.Text.Trim() + "' ,'" +
                txtPlacas.Text.Trim().ToUpper() + "','" + DateTime.Now + "'  ,0 ,0," + Hora + ",'" + txtColor.Text.Trim().ToUpper() + "' ) ");

            DataTable dtFolio = new ClassGenerales().EjecutaQuery("SELECT  Max(Id) As iFolio  FROM Estacionamiento;");
            string iFolio = dtFolio.Rows[0]["iFolio"].ToString() == "" ? "1" : dtFolio.Rows[0]["iFolio"].ToString();

            if (CheckRegistro.Checked)
            {
                string Ticket = " <table style='width: 100px;'  border='1'> "+
            " <tr><td align='center'>@Empresa</td></tr> "+
            " <tr><td align='center'>@Direccion</td></tr> "+
            " <tr><td align='center'>@Rfc</td></tr> "+
            " <tr><td align='center'>@Telefono</td></tr> "+
            " <tr><td align='center'>Marca: @Marca</td></tr> "+
            " <tr><td align='center'>Modelo: @Modelo</td></tr> "+
            " <tr><td align='center'>Placas: @Placas</td></tr> "+
            " <tr><td align='center'>Color: @Color</td></tr> "+
            " <tr><td align='center'>Horarios<br />Lun-Sab de 9:00 am a 9:00 pm<br />Domingo de 9:00 am a 7:00 pm </td></tr> "+
            " <tr><td align='justify'  valign='top'> "+
                    " CONTRATO DE PRESTACION DE SERVICIO DE ESTACIONAMIENTO La entrega y recibo del  "+
                    " presente contrato, implica que el usuario del servicio conoce y acepta el  "+
                    " contenido de las siguientes: CLAUSULAS: PRIMERA: El usuario del servicio acepta  "+
                    " que los daños ocasionados al vehículo por el personal del prestador del servicio  "+
                    " serán reparados en los talleres del prestador y a entera satisfacción del  "+
                    " usuario. SEGUNDA: El usuario del servicio asume la responsabilidad de todos los  "+
                    " gastos que se generen con motivo de sus traslados y demás accesorios durante el  "+
                    " tiempo que permanezca el vehículo en reparación. TERCERA: El prestador del  "+
                    " servicio responderá por los objetos dejados en el interior del vehículo como son  "+
                    " carátulas de stereos, teléfonos, lentes, siempre y cuando exista constancia por  "+
                    " escrito de haberlos reportado al personal del estacionamiento. CUARTA: El  "+
                    " prestador de servicio cuenta con una póliza de seguro de responsabilidad civil  "+
                    " por robo total, hasta por la cantidad de $200,000.00 (Doscientos mil pesos  "+
                    " 00/100 m.n.) aceptando el usuario del servicio que, si el vehículo descrito en  "+
                    " el presente contrato vale más de dicha cantidad, su demasía, así como el  "+
                    " deducible correrá por su cuenta. QUINTA: El prestador del servicio no se hace  "+
                    " responsable por: 1. Incendio motivado por deficiencia de la instalación  "+
                    " eléctrica o falla del carburador. 2. Desperfectos mecánicos no imputables al  "+
                    " personal del prestador del servicio de estacionamiento 3. Siniestros a causa de  "+
                    " inundaciones, incendios, temblores, terremotos, alborotos populares o  "+
                    " estudiantiles o cualquier otro que no se le sea imputable al personal del  "+
                    " prestador del servicio de estacionamiento. SEXTA: El prestador del servicio se  "+ 
                    " deslinda de cualquier responsabilidad civil, penal o de cualquier índole cuando  "+
                    " el vehículo sea irregular o sea reportado como robado. SEPTIMA: Si el usuario  "+
                    " pierde este contrato deberá reportarlo inmediatamente y acreditar la propiedad,  "+
                    " de lo contrario se entregará al portador de dicho contrato sin responsabilidad  "+
                    " alguna al prestador del servicio, el costo por contrato perdido es de $100 (Cien  "+
                    " pesos 00/100 m.n.) más el tiempo de estancia. OCTAVA: El prestador del servicio  "+
                    " no se hace responsable por vehículos dejados después del horario establecido y  "+
                    " exhibido en el establecimiento y dicho contrato. NOTA IMPORTANTE EN DICHO  "+
                    " ESTABLECIMIENTO “NO HAY TOLERANCIA, SOLO HORAS COMPLETAS SE COBRAN”</td> "+
            " </tr> "+
        " </table>";

                DatosReportes datos = new DatosReportes();
                DatosReportes.dtEstacionamientoRow row = datos.dtEstacionamiento.NewdtEstacionamientoRow();
                row.Entrada = DateTime.Now;
                row.Marca = ComboMarca.Text.Trim();
                row.Modelo = ComboModelo.Text.Trim();
                row.Placas = txtPlacas.Text.Trim().ToUpper();
                row.Empresa = Variables.NombreEmpresa;
                row.Color = txtColor.Text.Trim().ToUpper();

                row.Direccion = Variables.dtConfiguracion.Rows[0]["Direccion2"].ToString();//"8 Poniente 104 Col. Centro Pue.";
                row.RFC = Variables.dtConfiguracion.Rows[0]["RFC2"].ToString();//"RFC PAMA8609QI6";
                row.Telefono = Variables.dtConfiguracion.Rows[0]["Telefono2"].ToString();//"Teléfono (222) 2469259";
                row.Horarios = Variables.dtConfiguracion.Rows[0]["Horarios"].ToString();//"Teléfono (222) 2469259";
                BarcodeLib.Barcode Codigo = new BarcodeLib.Barcode();
                Codigo.IncludeLabel = true;
                panelResultado.BackgroundImage = Codigo.Encode(BarcodeLib.TYPE.CODE128, iFolio, Color.Black, Color.White, 400, 100);

                Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();

                if (!Directory.Exists(Application.StartupPath + @"\Cod"))
                {
                    Directory.CreateDirectory(Application.StartupPath + @"\Cod");
                }

                imgFinal.Save(Application.StartupPath + @"\Cod\" + iFolio + ".png");
                byte[] imgData2 = System.IO.File.ReadAllBytes(Application.StartupPath + @"\Cod\" + iFolio + ".png");
                row.Imagen = imgData2.ToArray();

                datos.dtEstacionamiento.Rows.Add(row);

                EntradaEstacionamiento report = new EntradaEstacionamiento();
                report.SetDataSource(datos);
                report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                report.PrintToPrinter(1, false, 0, 0);

                if (File.Exists(Application.StartupPath + @"\Cod\" + iFolio + ".png"))
                {
                    File.Delete(Application.StartupPath + @"\Cod\" + iFolio + ".png");
                }

                report.Close();
                report.Dispose();
                //img.Save(Application.StartupPath + @"\Qr\" + dt.Rows[0]["iCveClientes"].ToString() + ".jpg");
                //byte[] imgData2 = System.IO.File.ReadAllBytes(Application.StartupPath + @"\Qr\" + dt.Rows[0]["iCveClientes"].ToString() + ".jpg");
                //row2.ImagenQr = imgData2.ToArray();
                //            row.Imagen = "";
                //datos.dtEstacionamiento.Rows.Add(row);
            }




            if (Inserto == true)
            {
                MessageBox.Show("Se Registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPlacas.Text = "";
                ComboMarca.SelectedIndex = 0;
            }
            else
            {
                MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            //Id,Marca ,Modelo ,Placas,Entrada ,Salida ,Total ,Estatus from Estacionamiento

            CargaGrid();
        }

        private void GuardarCodigo()
        {
            Image imgFinal = (Image)panelResultado.BackgroundImage.Clone();

            SaveFileDialog CajaDeDiaologoGuardar = new SaveFileDialog();
            CajaDeDiaologoGuardar.AddExtension = true;
            CajaDeDiaologoGuardar.Filter = "Image PNG (*.png)|*.png";
            CajaDeDiaologoGuardar.ShowDialog();
            if (!string.IsNullOrEmpty(CajaDeDiaologoGuardar.FileName))
            {
                imgFinal.Save(CajaDeDiaologoGuardar.FileName, ImageFormat.Png);
            }
            imgFinal.Dispose();
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }

        private void ComboModelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtCostoHora.Text = "";
                DataTable dtDatos = new ClassGenerales().EjecutaQuery("select Tarifa from CatModelo where iCveModelos=" + ComboModelo.SelectedValue);
                if (dtDatos.Rows.Count>0)
                {
                    txtCostoHora.Text = dtDatos.Rows[0][0].ToString();
                }
            }
            catch (Exception)
            {
                ComboModelo.SelectedIndex = -1;
            }
        }

        private void ComboMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ComboModelo.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveModelos from CatModelo where iCveMarca=" + ComboMarca.SelectedValue + " order by cDesc");
                ComboModelo.DisplayMember = "cDesc";
                ComboModelo.ValueMember = "iCveModelos";
                ComboModelo.SelectedIndex = 0;
            }
            catch (Exception)
            {
                ComboModelo.SelectedIndex = -1;
            }

        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {


           
        }



        private void Cobrar()
        {
            try
            {

                Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
                Double Total = lblTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(lblTotal.Text) == true ? Convert.ToDouble(lblTotal.Text) : 0;


                if (Pago < Total)
                {
                    MessageBox.Show("Ingrese el monto de pago.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPago.Focus();
                    return;
                }



                DialogResult Resultado = MessageBox.Show("¿Desea realizar el cobro? ", "Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }


                if (Total <= 0)
                {
                    MessageBox.Show("Cargue un ticket para poder cobrar", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTicket.Focus();
                    return;
                }

                Double CostoHora = txtCostoHora.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCostoHora.Text) == true ? Convert.ToDouble(txtCostoHora.Text) : 0;

                DataTable dtFolio = new ClassGenerales().EjecutaQuery("SELECT  Max(venta.iFolio)+1 As iFolio  FROM venta;");
                bool Inserta = false;
                string iFolio = dtFolio.Rows[0]["iFolio"].ToString() == "" ? "1" : dtFolio.Rows[0]["iFolio"].ToString();
                string Pagado = "1";

                    string IdPaquetes = "0";
                    Inserta = new ClassGenerales().EjecutaQuery2("insert into venta (iFolio, iCveProductos, iCantidad, " +
                        " mPrecioVenta, mDescuento,iCveUsuarios, NUMEROCLIENTE,Total,FechaMaquina,cUtilidad,IdPaquetes,Pagado) values (" + iFolio +
                        ", " + 23731 + ", " + Horas + ", " +
                        " " + CostoHora + ", " + 0 +
                        "," + Variables.iCveUsuario + ", 2,"
                        + Total + ",'" + DateTime.Now + "'," + Total + "," +
                        IdPaquetes + "," + Pagado + ")");
                if (Inserta == true)
                {
                    Double Ticket = txtTicket.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTicket.Text) == true ? Convert.ToDouble(txtTicket.Text) : 0;
                    Inserta = new ClassGenerales().EjecutaQuery2("update Estacionamiento set Total="+Total+",Estatus=1,Salida=Now() where Id=" + Ticket);

                    if (CheckImprimir.Checked == true)
                    {
                        for (int i = 0; i < Convert.ToInt32(ComboTicket.SelectedValue); i++)
                        {
                            Imprimir(iFolio);
                        }

                    }
                    CargaGrid();
                    NuevaVenta();
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el pago.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void Imprimir(string Folio)
        {
            try
            {
                Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
                Double Cambio = txtCambio.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCambio.Text) == true ? Convert.ToDouble(txtCambio.Text) : 0;

                DatosReportes datos = GetTicket(Folio, Pago, Cambio, ".", txtColorSalida.Text.Trim());
                DatosReportes.dtLogosRow row = datos.dtLogos.NewdtLogosRow();


                if (Variables.dtConfiguracion.Rows[0]["Logo"].ToString() != "")
                {
                    if (System.IO.File.Exists(Variables.dtConfiguracion.Rows[0]["Logo"].ToString()))
                    {
                        byte[] imgData = System.IO.File.ReadAllBytes(Variables.dtConfiguracion.Rows[0]["Logo"].ToString());
                        row.ImagenLogo = imgData.ToArray();
                        datos.dtLogos.Rows.Add(row);
                    }
                }

                rptTicketGrande report = new rptTicketGrande();
                report.SetDataSource(datos);
                report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                report.PrintToPrinter(1, false, 0, 0);
                report.Close();
                report.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static DatosReportes GetTicket(string Folio, Double Efectivo, Double Cambio, string Observaciones,string Color)
        {
            DatosReportes DatosTickets = new DatosReportes();
            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.FechaMaquina AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo " +
                " , '" + Variables.dtConfiguracion.Rows[0]["RazonSocial"] + "' as Empresa,'"
                + Variables.dtConfiguracion.Rows[0]["Domicilio"] + "' as Direccion,'"
                + Variables.dtConfiguracion.Rows[0]["Telefono"] + "' as Telefono ,'"
                + Variables.dtConfiguracion.Rows[0]["RFC"] + "' as RFC,'"
                + Variables.dtConfiguracion.Rows[0]["Email"] + "' as Email,'"
                + Variables.dtConfiguracion.Rows[0]["Saludo"] + "'  as Leyenda," + Efectivo + " as Efectivo," + Cambio + " as Cambio, '" +
                Observaciones + "' as Observaciones , unidad.cDesc AS Unidad, '" + Color + "' as Color" +
               " FROM ((((venta " +
            " INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) " +
            " INNER JOIN cliente ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) " +
            " INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) " +
            " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria) " +
            " INNER JOIN unidad ON productos.iCveUnidad = unidad.iCveUnidad" +
            " where  venta.iFolio=" + Folio + " ;";
            OleDbConnection cone = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(Query, cone);
            cmd.CommandType = CommandType.Text;
            cone.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(DatosTickets, "dtTicket");

            cone.Close();
            return DatosTickets;
        }



        private void NuevaVenta()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtPlacas2.Text = "";
            txtEntrada.Text = "";
            lblHora.Text = "Horas";
            lblMinutos.Text = "Minutos";
            lblTotal.Text = "000,000.00";
            txtPago.Text = "0.00";
            txtCambio.Text = "0.00";
            txtColorSalida.Text = "";
            txtTicket.Text = "";
        }



        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
           




        }

        private void txtTicket_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (((System.Windows.Forms.TabControl)(sender)).SelectedIndex==1)
            {
                txtTicket.Focus();
            }
        }

        private void txtTicket_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtTicket_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar == 13)
                {
                    Double Ticket = txtTicket.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTicket.Text) == true ? Convert.ToDouble(txtTicket.Text) : 0;
                    DataTable dtDatos = new ClassGenerales().EjecutaQuery("select Id,Marca ,Modelo ,Placas,Entrada ," +
                        " Salida ,Total ,Estatus,Tarifa,Color from Estacionamiento  where Id=" + Ticket);

                    txtMarca.Text = "";
                    txtModelo.Text = "";
                    txtPlacas2.Text = "";
                    txtEntrada.Text = "";
                    txtColorSalida.Text = "";
                    lblHora.Text = "Horas";
                    lblMinutos.Text = "Minutos";
                    txtCostoHora.Text = "";
                    DateTime Entrada;
                    btnCobrar.Enabled = true;
                    if (dtDatos.Rows.Count > 0)
                    {
                        if (dtDatos.Rows[0]["Estatus"].ToString() == "1")
                        {
                            MessageBox.Show("El ticket ya se encuentra pagado", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnCobrar.Enabled = false;
                            //return;
                        }
                        txtMarca.Text = dtDatos.Rows[0]["Marca"].ToString();
                        txtModelo.Text = dtDatos.Rows[0]["Modelo"].ToString();
                        txtPlacas2.Text = dtDatos.Rows[0]["Placas"].ToString();
                        txtEntrada.Text = dtDatos.Rows[0]["Entrada"].ToString();
                        Entrada = Convert.ToDateTime(dtDatos.Rows[0]["Entrada"]);
                        txtCostoHora.Text = dtDatos.Rows[0]["Tarifa"].ToString();
                        txtColorSalida.Text = dtDatos.Rows[0]["Color"].ToString();
                        TimeSpan ts = DateTime.Now - Entrada;
                        int Minutos = ts.Minutes;
                        int Horas2 = ts.Hours;
                        int Dias = ts.Days;


                        if (Dias > 0)
                        {
                            Horas2 = Horas2 + (Dias * 24);
                        }
                        lblHoras.Text = "Horas: " + Horas2.ToString();
                        if (Minutos >= 1)
                        {
                            Horas2 = Horas2 + 1;
                        }

                        Horas = Horas2;
                        lblMinutos.Text = "Minutos: " + Minutos.ToString();
                        lblTotal.Text = String.Format("{0:0,0.00}", Horas2 * Convert.ToDouble(txtCostoHora.Text));
                        txtPago.Focus();
                    }
                    else
                    {
                        MessageBox.Show("Ticket no encontrado", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al cargar el ticket.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCobrar_Click_1(object sender, EventArgs e)
        {
            Cobra();
        }

        private void Cobra()
        {
            DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT max(fFecha) as Fecha FROM venta");
            DateTime UltimaFecha = DateTime.Now;
            try
            {
                UltimaFecha = Convert.ToDateTime(dtDatos.Rows[0]["Fecha"]);
            }
            catch (Exception)
            {

            }


            if (UltimaFecha > DateTime.Now)
            {
                MessageBox.Show("No se puede realizar la compra, ya que la fecha del sistema no esta actualizada.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                Cobrar();
            }


            CargaGrid();
        }

        private void txtPago_TextChanged_1(object sender, EventArgs e)
        {
            Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
            Double Total = lblTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(lblTotal.Text) == true ? Convert.ToDouble(lblTotal.Text) : 0;


            if (Math.Abs(Pago - Total) < 10)
            {
                txtCambio.Text = (Pago - Total).ToString();
            }
            else
            {
                txtCambio.Text = String.Format("{0:0,0.00}", Pago - Total);
            }
        }

        private void ComboTicket_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Cobra();
            }
        }

        private void txtColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
            {
                Registra();
            }
        }

        private void ComboColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtColor.Text = ComboColor.Text;
            }
            catch (Exception)
            {
                
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

    }
}
