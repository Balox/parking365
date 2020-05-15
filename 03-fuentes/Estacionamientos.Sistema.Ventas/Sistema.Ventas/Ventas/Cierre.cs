using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;
using Sistema.Ventas.Reportes;

namespace Sistema.Ventas
{
    public partial class Cierre : Form
    {
        public Cierre()
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



        public void EstilosGrid()
        {
            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            Datos.Columns[0].Visible = false;
            //GridDatos.Columns[1].Visible = false;
            Datos.Columns[1].Width = 60;
            Datos.Columns[2].Width = 160;
            Datos.Columns[3].Width = 160;
            Datos.Columns[4].Width = 70;
            Datos.Columns[5].Width = 70;
            Datos.Columns[6].Width = 70;
            Datos.Columns[7].Width = 70;
            Datos.Columns[8].Width = 70;
            Datos.Columns[9].Width = 160;
            Datos.Columns[12].Width = 70;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            try
            {


                ComboCliente.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' as NOMBRE,-1 as NUMEROCLIENTE from cliente union select NOMBRE,NUMEROCLIENTE from cliente order by 2");
                ComboCliente.DisplayMember = "NOMBRE";
                ComboCliente.ValueMember = "NUMEROCLIENTE";
                ComboCliente.SelectedIndex = 0;

                //1 Activo 2 Cancelados
                ComboStatus.DataSource = new ClassGenerales().EjecutaQuery("select 'Activos' as Texto,1 as Valor from configuracion union select 'Cancelados' as Texto,2 as Valor from configuracion");
                ComboStatus.DisplayMember = "Texto";
                ComboStatus.ValueMember = "Valor";
                ComboStatus.SelectedIndex = 0;

                ComboVendido.DataSource = new ClassGenerales().EjecutaQuery("select -1 as iCveUsuarios,'TODOS' as cNombre from configuracion union select iCveUsuarios,cNombre from USUARIOS order by 2");
                ComboVendido.DisplayMember = "cNombre";
                ComboVendido.ValueMember = "iCveUsuarios";
                ComboVendido.SelectedValue = "-1";

                CargaCierre();
            }
            catch (Exception)
            {

                throw;
            }
        }




        private void LimpiaControles(string Valor)
        {

            //txtObservaciones.Text = string.Empty;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LimpiaControles("Nuevo");
        }






        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaCierre();
        }


        private void CargaCierre()
        {

        //    if (Variables.iCveUsuarioAdministrador == 1)
        //    {
        //}

            string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.fFecha AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo,Venta.cUtilidad as Utilidad " +
                " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
                " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";

            if (ClassGenerales.IsNumericDouble(txtFolio.Text))
            {
                Query += " where venta.iFolio=" + txtFolio.Text.Trim();
            }
            else
            {
                Query += " where venta.fFecha between #" + sInicial + "# and #" + sFinal + "# ";
                if (ComboCliente.SelectedValue.ToString() != "-1")
                {
                    Query += " and venta.NUMEROCLIENTE=" + ComboCliente.SelectedValue.ToString();
                }
                if (Variables.iCveUsuarioAdministrador == 1)
                {
                    if (ComboVendido.SelectedValue.ToString() != "-1")
                    {
                        Query += " and venta.iCveUsuarios=" + ComboVendido.SelectedValue.ToString();
                    }
                }
                else
                {
                    Query += " and venta.iCveUsuarios=" + Variables.iCveUsuario;
                }
                
               
            }
            Query += " and venta.iStatus=" + ComboStatus.SelectedValue.ToString();

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            Datos.DataSource = dtDatos;
            EstilosGrid();


            Double Subtotal = 0;
            Double Descuento = 0;
             Double Utilidad = 0;
            for (int i = 0; i < dtDatos.Rows.Count; i++)
            {
                Subtotal += Convert.ToDouble(dtDatos.Rows[i]["Cantidad"]) *
                    Convert.ToDouble(dtDatos.Rows[i]["PrecioVenta"]);
                Descuento += Convert.ToDouble(dtDatos.Rows[i]["Descuento"]);
                Utilidad += Convert.ToDouble(dtDatos.Rows[i]["Utilidad"]);
            }


            txtUtilidad.Text = String.Format("{0:0,0.00}", Utilidad);
            txtArticulosVendidos.Text = dtDatos.Rows.Count.ToString();
            txtSubtotal.Text = String.Format("{0:0,0.00}", Subtotal);
            txtDescuentoTotal.Text = String.Format("{0:0,0.00}", Descuento);
            txtTotal.Text = String.Format("{0:0,0.00}", Subtotal - Descuento);



            string Query2 = "SELECT sum(Gasto) FROM Gastos ";

            Query2 += " where FechaGasto between #" + sInicial + "# and #" + sFinal + "# ";


            DataTable dtGastos = new ClassGenerales().EjecutaQuery(Query2);

            txtGastos.Text = String.Format("{0:0,0.00}", dtGastos.Rows[0][0]);

        }

        private void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtFolio_TextChanged(object sender, EventArgs e)
        {
            try
            {
                CargaCierre();
            }
            catch (Exception)
            {
                txtFolio.Text = "";
                txtFolio.Focus();
            }
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (ClassGenerales.IsNumericDouble(txtFolio.Text)==false)
            {
                MessageBox.Show("Cargue un Folio valido", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFolio.Focus();
                return;
            }

            if (Datos.Rows.Count==0)
            {
                MessageBox.Show("No existen datos para cancelar", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFolio.Focus();
                return;
            }

            DialogResult Resultado = MessageBox.Show("¿Desea realizar la cancelación del folio " + txtFolio.Text+ " ?", "Cancelacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == System.Windows.Forms.DialogResult.Yes)
            {
                    bool Inserto = new ClassGenerales().EjecutaQuery2("update venta set iStatus=2 where iFolio=" + txtFolio.Text.Trim());
                    MessageBox.Show("Se cancelo exitosamente el folio: " + txtFolio.Text, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFolio.Text = "";
                    CargaCierre();
                    
            }

          
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            new ClassGenerales().ExportarExcel(Datos);
        }

        private void btnCancelarProducto_Click(object sender, EventArgs e)
        {
            if (Datos.SelectedCells.Count > 0)
            {
                var index = Datos.CurrentCell.RowIndex;
                string iCve = Datos.Rows[index].Cells[0].Value.ToString().Trim();
                string Producto = Datos.Rows[index].Cells[3].Value.ToString().Trim();

                DialogResult Resultado = MessageBox.Show("¿Desea realizar la cancelación del producto " + Producto + " ? " , "Cancelacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                    bool Inserto = new ClassGenerales().EjecutaQuery2("update venta set iStatus=2 where iCveVenta=" + iCve);
                    MessageBox.Show("Se cancelo exitosamente el producto: " + Producto, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtFolio.Text = "";
                    CargaCierre();

                }
              
            }
            else
            {
                MessageBox.Show("No selecciono ningun registro.: " + txtFolio.Text, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            DatosReportes datos = new DatosReportes();
            DatosReportes.dtCierreRow row = datos.dtCierre.NewdtCierreRow();
            row.Descuento = Convert.ToDouble(txtDescuentoTotal.Text);
            row.FechaFinal = fInicial.Value;
            row.FechaInicial = fFinal.Value;
            row.NoFolios = Convert.ToInt32(txtArticulosVendidos.Text);
            row.SubTotal = Convert.ToDouble(txtSubtotal.Text);
            row.Total = Convert.ToDouble(txtTotal.Text);
            datos.dtCierre.Rows.Add(row);

            CierreCaja report = new CierreCaja();
            report.SetDataSource(datos);
            report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
            report.PrintToPrinter(1, false, 0, 0);
            report.Close();
            report.Dispose();
        }

    }
}
