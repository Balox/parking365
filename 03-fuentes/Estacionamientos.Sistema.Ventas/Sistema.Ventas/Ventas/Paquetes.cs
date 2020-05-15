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
using System.Configuration;
using System.Data.OleDb;

namespace Sistema.Ventas
{
    public partial class Paquetes : Form
    {
        public Paquetes()
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
            //this.GridServicios.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            //GridServicios.Columns[0].Width = 170;
            //GridServicios.Columns[1].Width = 170;
            //GridServicios.Columns[2].Width = 170;
            //GridServicios.Columns[3].Visible = false;
        }

        private void Membresias_Load(object sender, EventArgs e)
        {
            //ComboCliente.DataSource = new ClassGenerales().EjecutaQuery(" select NOMBRE,NUMEROCLIENTE from cliente order by 1");
            //ComboCliente.DisplayMember = "NOMBRE";
            //ComboCliente.ValueMember = "NUMEROCLIENTE";
            //ComboCliente.SelectedIndex = 0;

            ComboClientesBusqueda.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' as NOMBRE,-1 as NUMEROCLIENTE from cliente union select NOMBRE,NUMEROCLIENTE from cliente order by 1");
            ComboClientesBusqueda.DisplayMember = "NOMBRE";
            ComboClientesBusqueda.ValueMember = "NUMEROCLIENTE";
            ComboClientesBusqueda.SelectedIndex = 0;

            BuscarProductos();

            ObtieneCodigo();


        }

        private void ObtieneCodigo()
        {
            DataTable dtFolio = new ClassGenerales().EjecutaQuery("SELECT  Max(IdPaquetes)+1 As iFolio  FROM Paquetes;");
            string iFolio = dtFolio.Rows[0]["iFolio"].ToString() == "" ? "1" : dtFolio.Rows[0]["iFolio"].ToString();
            txtCodigo.Text = "P" + iFolio;
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtProductoBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            const string quote = "\"";
            string Query = "SELECT productos.cDesc as Producto, Categoria.cDesc as Categoria,  productos.cUPC,productos.iCveProductos,mPrecioVenta,cUtilidad,mPrecioCompra " +
" FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
" WHERE (((productos.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote
+ ") or ((Categoria.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote + "));";
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery(Query);
            GridDatosBusqueda.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.GridDatosBusqueda.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                GridDatosBusqueda.Columns[0].Width = 130;
                GridDatosBusqueda.Columns[1].Width = 130;
                GridDatosBusqueda.Columns[2].Visible = false;
                GridDatosBusqueda.Columns[3].Visible = false;
                GridDatosBusqueda.Columns[4].Visible = false;
                GridDatosBusqueda.Columns[5].Visible = false;
                GridDatosBusqueda.Columns[6].Visible = false;
            }
        }

        private void txtProductoBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            BuscarProductos();
        }





        private void txtFolioPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {

                }
            }
            catch (Exception)
            {


            }

        }





        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                //Double Total = txtTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTotal.Text) == true ? Convert.ToDouble(txtTotal.Text) : 0;
                if (txtPaquete.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un nombre para el paquete.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPaquete.Focus();
                    return;
                }

                if (txtCodigo.Text == string.Empty)
                {
                    MessageBox.Show("Ingrese un codigo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Focus();
                    return;
                }

                if (GridProductosPaquete.Rows.Count == 0)
                {
                    MessageBox.Show("Ingrese al menos 1 producto al paquete.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Boolean Inserto = false;

                string Inicial = fInicial.Value.ToString("dd/MM/yyyy") + " 01:00:00 ";
                string Final = fFinal.Value.ToString("dd/MM/yyyy") + " 23:59:00 ";

                Inserto = new ClassGenerales().EjecutaQuery2("insert into Paquetes (Inicio,Fin,Nombre,Codigo) values ('" +
                    Inicial + "','" + Final + "','" + txtPaquete.Text + "','" + txtCodigo.Text + "')");

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("select max(IdPaquetes) as IdPaquetes from Paquetes");

                for (int i = 0; i < GridProductosPaquete.Rows.Count; i++)
                {
                    Inserto = new ClassGenerales().EjecutaQuery2("insert into PaquetesDetalle " +
                        " (IdPaquetes,iCveProductos,mPrecioVenta,mDescuento,mPrecioVentaPaquete,mUtilidad) values (" +
                        " " + dtDatos.Rows[0][0] + "," +
                        GridProductosPaquete.Rows[i].Cells[0].Value.ToString().Trim() + "," +
                        GridProductosPaquete.Rows[i].Cells[2].Value.ToString().Trim() + "," +
                        GridProductosPaquete.Rows[i].Cells[3].Value.ToString().Trim() + "," +
                        GridProductosPaquete.Rows[i].Cells[4].Value.ToString().Trim() + "," +
                        GridProductosPaquete.Rows[i].Cells[5].Value.ToString().Trim() + ")");
                }


                if (Inserto == true)
                {
                    MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
                    GridProductosPaquete.Rows.Clear();
                    txtSubTotal.Text = "";
                    txtDesc.Text = "";
                    txtTotalPaquete.Text = "";

                    txtPaquete.Text = "";
                    ObtieneCodigo();
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridDatosBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            AgregarProducto();

        }

        private void AgregarProducto()
        {
            if (GridDatosBusqueda.SelectedCells.Count > 0)
            {
                var index = GridDatosBusqueda.CurrentCell.RowIndex;
                txtiCveProducto.Text = GridDatosBusqueda.Rows[index].Cells[3].Value.ToString().Trim();

                txtProducto.Text = GridDatosBusqueda.Rows[index].Cells[0].Value.ToString().Trim() + " " +
                    GridDatosBusqueda.Rows[index].Cells[1].Value.ToString().Trim();

                txtPrecioVenta.Text = GridDatosBusqueda.Rows[index].Cells[4].Value.ToString().Trim();
                txtUtilidad.Text = GridDatosBusqueda.Rows[index].Cells[5].Value.ToString().Trim();
                txtPrecioCompra.Text = GridDatosBusqueda.Rows[index].Cells[6].Value.ToString().Trim();
                txtPrecioVentaPaquete.Text = txtPrecioVenta.Text;

                txtDescuentoPorcentaje.Focus();
                txtDescuentoPorcentaje.Select();
            }
        }

        private void txtDescuento_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescuentoPorcentaje_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtPrecioVenta.Text = string.Empty;
            txtdescuento.Text = string.Empty;
            txtPrecioVentaPaquete.Text = string.Empty;
            txtiCveProducto.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtDescuentoPorcentaje.Text = string.Empty;

            txtPrecioCompra.Text = "";
            txtUtilidad.Text = "";


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (GridPaquetesHistorial.Rows.Count > 0)
            {

                if (GridPaquetesHistorial.SelectedCells.Count > 0)
                {
                    var index = GridPaquetesHistorial.CurrentCell.RowIndex;
                    string iCve = GridPaquetesHistorial.Rows[index].Cells[0].Value.ToString().Trim();

                    DatosReportes datos = GetTicket(iCve);
                    DatosReportes.dtTicketRow row = datos.dtTicket.NewdtTicketRow();

                    rptMembresias report = new rptMembresias();
                    report.SetDataSource(datos);

                    report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                    report.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
                MessageBox.Show("Seleccione un paquete para imprimir.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }




        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();

   
        }




        private void Buscar()
        {
            string sInicial = fInicial2.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal2.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT IdPaquetes,Codigo,Nombre, Paquetes.Inicio, Paquetes.Fin " +
" FROM Paquetes ";

            Query += " where Inicio between #" + sInicial + "# and #" + sFinal + "# ";


            //if (ComboClientesBusqueda.SelectedValue.ToString() != "-1")
            //{
            //    Query += " and cliente.NUMEROCLIENTE=" + ComboCliente.SelectedValue.ToString();
            //}

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            GridPaquetesHistorial.DataSource = dtDatos;
            GridPaquetesHistorial.Columns[0].Visible = false;
            GridPaquetesHistorial.Columns[1].Width = 50;
            GridPaquetesHistorial.Columns[2].Width = 100;
            GridPaquetesHistorial.Columns[3].Width = 100;
            GridPaquetesHistorial.Columns[3].Width = 100;


            txtiCveDetalle.Text = "";
            txtPrecioCompra2.Text = "";
            txtPrecioVenta2.Text = "";
            txtDescuentoPorcentaje2.Text = "0.00";
            txtdescuento2.Text = "0.00";
            txtPrecioVentaPaquete2.Text = "";

            txtSubtotal2.Text = "";
            txtDesc2.Text = "";
            txtTotal2.Text = "";
            GridPaquetesHistorialDetalle.DataSource = null;

        }

        private void GridPaquetesHistorial_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaHistorialDetalle();
        }

        private void CargaHistorialDetalle()
        {
            try
            {

                if (GridPaquetesHistorial.SelectedCells.Count > 0)
                {
                    var index = GridPaquetesHistorial.CurrentCell.RowIndex;
                    string iCve = GridPaquetesHistorial.Rows[index].Cells[0].Value.ToString().Trim();

                    DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT productos.cDesc as Producto, Categoria.cDesc as Categoria," +
                        " PaquetesDetalle.IdPaqueteDetalle,PaquetesDetalle.mPrecioVenta as PrecioVenta," +
                        " PaquetesDetalle.mDescuento as Descu,mPrecioVentaPaquete as PrecioPaquete,PaquetesDetalle.iCveProductos " +
    "FROM (productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria) " +
    " INNER JOIN PaquetesDetalle ON productos.iCveProductos = PaquetesDetalle.iCveProductos where IdPaquetes=" + iCve);

                    GridPaquetesHistorialDetalle.DataSource = dtDatos;
                    GridPaquetesHistorialDetalle.Columns[0].Width = 130;
                    GridPaquetesHistorialDetalle.Columns[1].Width = 130;
                    GridPaquetesHistorialDetalle.Columns[2].Visible = false;
                    GridPaquetesHistorialDetalle.Columns[3].Width = 100;
                    GridPaquetesHistorialDetalle.Columns[4].Width = 100;
                    GridPaquetesHistorialDetalle.Columns[5].Width = 100;
                    GridPaquetesHistorialDetalle.Columns[6].Visible = false;
                    SumaTotalPaquete2();
                }
            }
            catch (Exception)
            {

            }
        }


        private void SumaTotalPaquete2()
        {
            Double SubTotal = 0;
            Double Total = 0;
            Double Desc = 0;
            for (int i = 0; i < GridPaquetesHistorialDetalle.Rows.Count; i++)
            {
                SubTotal = SubTotal + Convert.ToDouble(GridPaquetesHistorialDetalle.Rows[i].Cells[3].Value);
                Desc = Desc + Convert.ToDouble(GridPaquetesHistorialDetalle.Rows[i].Cells[4].Value);
                Total = Total + Convert.ToDouble(GridPaquetesHistorialDetalle.Rows[i].Cells[5].Value);
            }
            txtSubtotal2.Text = String.Format("{0:0,0.00}", SubTotal);
            txtDesc2.Text = String.Format("{0:0,0.00}", Desc);
            txtTotal2.Text = String.Format("{0:0,0.00}", Total);
        }


        private void btnAnexar_Click(object sender, EventArgs e)
        {
            AgregarProducto();

        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (GridProductosPaquete.SelectedCells.Count > 0)
            {
                var index = GridProductosPaquete.CurrentCell.RowIndex;
                GridProductosPaquete.Rows.RemoveAt(index);
                SumaTotalPaquete();
            }
        }

        private void GridPaquetesHistorialDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    if (GridPaquetesHistorialDetalle.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
            //    {
            //        GridPaquetesHistorialDetalle.Rows[e.RowIndex].Cells[0].Value = "False";
            //    }
            //    else
            //    {
            //        GridPaquetesHistorialDetalle.Rows[e.RowIndex].Cells[0].Value = "True";
            //    }
            //}
        }

        private void btnGuardaServicios_Click(object sender, EventArgs e)
        {
            try
            {


                bool Inserto = false;
                for (int i = 0; i < GridPaquetesHistorialDetalle.Rows.Count; i++)
                {
                    int Utilizado = GridPaquetesHistorialDetalle.Rows[i].Cells[0].Value.ToString() == "True" || GridPaquetesHistorialDetalle.Rows[i].Cells[0].Value.ToString() == "1" ? 1 : 0;
                    Inserto = new ClassGenerales().EjecutaQuery2("update PaquetesDetalle set Utilizado=" + Utilizado
                        + ", FechaUtilizado='" + fMovimiento.Value + "' where IdPaqueteDetalle=" + GridPaquetesHistorialDetalle.Rows[i].Cells[3].Value);
                }


                if (Inserto == true)
                {
                    MessageBox.Show("Se Registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPaquetesHistorialDetalle.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtdescuento_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtDescuentoPorcentaje_TextChanged_1(object sender, EventArgs e)
        {
            Double Porcentaje = txtDescuentoPorcentaje.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDescuentoPorcentaje.Text) == true ? Convert.ToDouble(txtDescuentoPorcentaje.Text) : 0;
            txtdescuento.Text = "0.00";

            if (Porcentaje <= 100)
            {
                Double Precio = txtPrecioVenta.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta.Text) == true ? Convert.ToDouble(txtPrecioVenta.Text) : 0;
                txtdescuento.Text = ((Precio) * (Porcentaje / 100)).ToString();

                txtPrecioVentaPaquete.Text = String.Format("{0:0,0.00}", Precio - Convert.ToDouble(txtdescuento.Text));
                CalculaUtilidad();
            }
            else
            {
                MessageBox.Show("No se permiten porcentajes mayores a 100%", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescuentoPorcentaje.Text = "0.00";
                txtdescuento.Text = "0.00";
                txtPrecioVentaPaquete.Text = txtPrecioVenta.Text;
                CalculaUtilidad();
            }
        }


        private void CalculaUtilidad()
        {
            try
            {
                Double PrecioCompra = txtPrecioCompra.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra.Text) == true ? Convert.ToDouble(txtPrecioCompra.Text) : 0;
                Double PrecioVenta = txtPrecioVentaPaquete.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVentaPaquete.Text) == true ? Convert.ToDouble(txtPrecioVentaPaquete.Text) : 0;
                txtUtilidad.Text = String.Format("{0:0.00}", PrecioVenta - PrecioCompra);
            }
            catch (Exception)
            {
                txtUtilidad.Text = "0";
            }
        }


        private void CalculaUtilidad2()
        {
            try
            {
                Double PrecioCompra = txtPrecioCompra2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra2.Text) == true ? Convert.ToDouble(txtPrecioCompra2.Text) : 0;
                Double PrecioVenta = txtPrecioVentaPaquete2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVentaPaquete2.Text) == true ? Convert.ToDouble(txtPrecioVentaPaquete2.Text) : 0;
                txtUtilidad2.Text = String.Format("{0:0.00}", PrecioVenta - PrecioCompra);
            }
            catch (Exception)
            {
                txtUtilidad2.Text = "0";
            }
        }


        private void btnAgregarProducto_Click_1(object sender, EventArgs e)
        {
            Double PrecioVenta = txtPrecioVenta.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta.Text) == true ? Convert.ToDouble(txtPrecioVenta.Text) : 0;
            Double Descuento = txtdescuento.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtdescuento.Text) == true ? Convert.ToDouble(txtdescuento.Text) : 0;
            Double PrecioVentaPaquete = txtPrecioVentaPaquete.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVentaPaquete.Text) == true ? Convert.ToDouble(txtPrecioVentaPaquete.Text) : 0;
            Double iCveProducto = txtiCveProducto.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtiCveProducto.Text) == true ? Convert.ToDouble(txtiCveProducto.Text) : 0;
            Double Utilidad = txtUtilidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtUtilidad.Text) == true ? Convert.ToDouble(txtUtilidad.Text) : 0;

            //if (PrecioVentaPaquete == 0)
            //{
            //    MessageBox.Show("Ingrese un precio venta paquete.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    txtPrecioVentaPaquete.Focus();
            //    return;
            //}

            if (iCveProducto == 0)
            {
                MessageBox.Show("Cargue un producto.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (txtProducto.Text == string.Empty)
            {
                MessageBox.Show("Cargue un producto.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            GridProductosPaquete.Rows.Add(txtiCveProducto.Text, txtProducto.Text, PrecioVenta, Descuento, PrecioVentaPaquete, Utilidad);
            Limpiar();
            SumaTotalPaquete();
        }

        private void SumaTotalPaquete()
        {
            Double SubTotal = 0;
            Double Total = 0;
            Double Desc = 0;
            for (int i = 0; i < GridProductosPaquete.Rows.Count; i++)
            {
                Total = Total + Convert.ToDouble(GridProductosPaquete.Rows[i].Cells[4].Value);
                Desc = Desc + Convert.ToDouble(GridProductosPaquete.Rows[i].Cells[3].Value);
                SubTotal = SubTotal + Convert.ToDouble(GridProductosPaquete.Rows[i].Cells[2].Value);
            }
            txtSubTotal.Text = String.Format("{0:0,0.00}", SubTotal);
            txtDesc.Text = String.Format("{0:0,0.00}", Desc);
            txtTotalPaquete.Text = String.Format("{0:0,0.00}", Total);
        }


        private void btnBuscarVendidos_Click(object sender, EventArgs e)
        {
            string sInicial = fInicial3.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal3.Value.AddDays(1).ToString("MM/dd/yyyy");

            //string Query = "SELECT  venta.Utilizado, venta.FechaUtilizado,Categoria.cDesc AS Categoria, "+
            //    " productos.cDesc AS Producto,venta.IdPaquetes, venta.iCveVenta AS NoVenta,fFecha " +
            //       " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
            //       " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";

            string Query = "SELECT venta.iFolio AS Folio, cliente.NOMBRE AS Cliente, venta.fFecha AS FechaVenta, " +
            " venta.IdPaquetes, Paquetes.Nombre as Paquete, Paquetes.Codigo " +
" FROM ((((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos)  " +
            " INNER JOIN cliente ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE)  " +
            " INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios)  " +
            " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria)  " +
            " INNER JOIN Paquetes ON venta.IdPaquetes = Paquetes.IdPaquetes ";


            Query += " where fFecha between #" + sInicial + "# and #" + sFinal + "# and  venta.IdPaquetes<>0 ";


            if (ComboClientesBusqueda.SelectedValue.ToString() != "-1")
            {
                Query += " and cliente.NUMEROCLIENTE=" + ComboClientesBusqueda.SelectedValue.ToString();
            }

            Query += " GROUP BY venta.iFolio, cliente.NOMBRE, venta.fFecha, venta.IdPaquetes, Paquetes.Nombre , Paquetes.Codigo  ";
            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            gridComprasPaquete.DataSource = dtDatos;
            gridComprasPaquete.Columns[0].Width = 40;
            gridComprasPaquete.Columns[1].Width = 120;
            gridComprasPaquete.Columns[2].Width = 140;
            gridComprasPaquete.Columns[3].Visible = false;
            //gridComprasPaquete.Columns[4].Width = 120;
            gridComprasPaquete.Columns[5].Width = 70;
            //gridComprasPaquete.Columns[5].Width = 50;
        }

        private void gridComprasPaquete_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridPaqueteVendidosDetalle.Rows.Clear();
            if (gridComprasPaquete.SelectedCells.Count > 0)
            {
                var index = gridComprasPaquete.CurrentCell.RowIndex;
                string iCve = gridComprasPaquete.Rows[index].Cells[0].Value.ToString().Trim();

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT venta.Utilizado, productos.cDesc AS Producto, Categoria.cDesc AS Categoria, venta.FechaUtilizado, venta.iCveVenta " +
"FROM (venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
"WHERE (((venta.iFolio)=" + iCve + "))");

                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    GridPaqueteVendidosDetalle.Rows.Add(dtDatos.Rows[i]["Utilizado"],
                         dtDatos.Rows[i]["Producto"] + "-" + dtDatos.Rows[i]["Categoria"],
                        dtDatos.Rows[i]["FechaUtilizado"],
                        dtDatos.Rows[i]["iCveVenta"]);
                }

            }
        }

        private void btnGuardaDetallePaquete_Click(object sender, EventArgs e)
        {
            try
            {


                bool Inserto = false;
                for (int i = 0; i < GridPaqueteVendidosDetalle.Rows.Count; i++)
                {
                    int Utilizado = GridPaqueteVendidosDetalle.Rows[i].Cells[0].Value.ToString() == "True" || GridPaqueteVendidosDetalle.Rows[i].Cells[0].Value.ToString() == "1" ? 1 : 0;
                    if (Utilizado == 1)
                    {
                        Inserto = new ClassGenerales().EjecutaQuery2("update venta set Utilizado=" + Utilizado
                            + ", FechaUtilizado='" + fMovimiento.Value + "' where iCveVenta=" + GridPaqueteVendidosDetalle.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        Inserto = new ClassGenerales().EjecutaQuery2("update venta set Utilizado=" + Utilizado
                         + ", FechaUtilizado=null where iCveVenta=" + GridPaqueteVendidosDetalle.Rows[i].Cells[3].Value);
                    }

                }


                if (Inserto == true)
                {
                    MessageBox.Show("Se Registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridPaqueteVendidosDetalle.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GridPaqueteVendidosDetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (GridPaqueteVendidosDetalle.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    DialogResult Resultado = MessageBox.Show("¿Desea desmarcar el servicio? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        GridPaqueteVendidosDetalle.Rows[e.RowIndex].Cells[0].Value = "False";
                    }
                }
                else
                {
                    GridPaqueteVendidosDetalle.Rows[e.RowIndex].Cells[0].Value = "True";
                }
            }
        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            if (gridComprasPaquete.Rows.Count > 0)
            {

                if (gridComprasPaquete.SelectedCells.Count > 0)
                {
                    var index = gridComprasPaquete.CurrentCell.RowIndex;
                    string iCve = gridComprasPaquete.Rows[index].Cells[0].Value.ToString().Trim();

                    DatosReportes datos = GetTicket(iCve);
                    DatosReportes.dtTicketRow row = datos.dtTicket.NewdtTicketRow();

                    rptPaquetes report = new rptPaquetes();
                    report.SetDataSource(datos);

                    report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                    report.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
                MessageBox.Show("Seleccione un paquete para imprimir.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static DatosReportes GetTicket(string iCve)
        {
            DatosReportes DatosTickets = new DatosReportes();
            string Query = "SELECT cliente.NOMBRE as Cliente, productos.cDesc as Producto," +
                "  Categoria.cDesc as Categoria, Switch(Utilizado=1,'No',Utilizado=0,'Si') AS Disponible , " +
                " venta.FechaUtilizado, Paquetes.Nombre as Paquete " +
" FROM (((venta INNER JOIN cliente ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) " +
" INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) " +
" INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria) " +
 " INNER JOIN Paquetes ON venta.IdPaquetes = Paquetes.IdPaquetes where venta.iFolio=" + iCve;

            OleDbConnection cone = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(Query, cone);
            cmd.CommandType = CommandType.Text;
            cone.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(DatosTickets, "dtPaquetes");

            cone.Close();
            return DatosTickets;
        }

        private void txtDescuentoPorcentaje2_TextChanged(object sender, EventArgs e)
        {
            CalculaDEscuentoDetalles();
        }

        private void CalculaDEscuentoDetalles()
        {
            Double Porcentaje = txtDescuentoPorcentaje2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDescuentoPorcentaje2.Text) == true ? Convert.ToDouble(txtDescuentoPorcentaje2.Text) : 0;
            txtdescuento2.Text = "0.00";
            if (Porcentaje <= 100)
            {
                Double Precio = txtPrecioVenta2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta2.Text) == true ? Convert.ToDouble(txtPrecioVenta2.Text) : 0;
                txtdescuento2.Text = ((Precio) * (Porcentaje / 100)).ToString();

                txtPrecioVentaPaquete2.Text = String.Format("{0:0,0.00}", Precio - Convert.ToDouble(txtdescuento2.Text));
                CalculaUtilidad2();
            }
            else
            {
                MessageBox.Show("No se permiten porcentajes mayores a 100%", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtDescuentoPorcentaje2.Text = "0.00";
                txtdescuento2.Text = "0.00";
                txtPrecioVentaPaquete2.Text = txtPrecioVenta2.Text;
                CalculaUtilidad2();
            }
        }

        private void GridPaquetesHistorialDetalle_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (GridPaquetesHistorialDetalle.SelectedCells.Count > 0)
                {
                    var index = GridPaquetesHistorialDetalle.CurrentCell.RowIndex;
                    string iCve = GridPaquetesHistorialDetalle.Rows[index].Cells[2].Value.ToString().Trim();
                    string iCveProducto = GridPaquetesHistorialDetalle.Rows[index].Cells[6].Value.ToString().Trim();

                    txtiCveDetalle.Text = iCve;

                    DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT mPrecioCompra "
+ " FROM productos where iCveProductos=" + iCveProducto);

                    txtPrecioCompra2.Text = dtDatos.Rows[0]["mPrecioCompra"].ToString();
                    txtPrecioVenta2.Text = GridPaquetesHistorialDetalle.Rows[index].Cells[3].Value.ToString();
                    txtPrecioVentaPaquete2.Text = GridPaquetesHistorialDetalle.Rows[index].Cells[5].Value.ToString();
                    txtdescuento2.Text = GridPaquetesHistorialDetalle.Rows[index].Cells[4].Value.ToString();

                    Double Descuento = txtdescuento2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtdescuento2.Text) == true ? Convert.ToDouble(txtdescuento2.Text) : 0;
                    Double PrecioVenta = txtPrecioVenta2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta2.Text) == true ? Convert.ToDouble(txtPrecioVenta2.Text) : 0;

                    Double Porcentaje = ((Descuento * 100) / PrecioVenta);

                    txtDescuentoPorcentaje2.Text = Porcentaje.ToString();


                    CalculaDEscuentoDetalles();

                }
            }
            catch (Exception)
            {

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            bool Inserto = false;
            try
            {

                if (txtiCveDetalle.Text == "")
                {
                    MessageBox.Show("Seleccione un producto para modificar", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Double PrecioVenta = txtPrecioVenta2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta2.Text) == true ? Convert.ToDouble(txtPrecioVenta2.Text) : 0;
                Double Descuento = txtdescuento2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtdescuento2.Text) == true ? Convert.ToDouble(txtdescuento2.Text) : 0;
                Double PrecioVentaPaquete = txtPrecioVentaPaquete2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVentaPaquete2.Text) == true ? Convert.ToDouble(txtPrecioVentaPaquete2.Text) : 0;
                Double Utilidad = txtUtilidad2.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtUtilidad2.Text) == true ? Convert.ToDouble(txtUtilidad2.Text) : 0;


                Inserto = new ClassGenerales().EjecutaQuery2("update PaquetesDetalle set "
                    + " mPrecioVenta=" + PrecioVenta + ",mDescuento=" + Descuento + ",mPrecioVentaPaquete=" + PrecioVentaPaquete + ",mUtilidad=" + Utilidad
                    + " where IdPaqueteDetalle=" + txtiCveDetalle.Text);


                if (Inserto == true)
                {
                    MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargaHistorialDetalle();
                    txtiCveDetalle.Text = "";
                    txtPrecioCompra2.Text = "";
                    txtPrecioVenta2.Text = "";
                    txtDescuentoPorcentaje2.Text = "0.00";
                    txtdescuento2.Text = "0.00";
                    txtPrecioVentaPaquete2.Text = "";

                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }



            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (GridPaquetesHistorial.SelectedCells.Count > 0)
            {
                var index = GridPaquetesHistorial.CurrentCell.RowIndex;
                string iCve = GridPaquetesHistorial.Rows[index].Cells[0].Value.ToString().Trim();

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT iFolio FROM venta where IdPaquetes=" + iCve);

                if (dtDatos.Rows.Count > 0)
                {
                    MessageBox.Show("El paquete ya fue vendido, no se puede eliminar.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    DialogResult Resultado = MessageBox.Show("¿Desea eliminar el paquete " + GridPaquetesHistorial.Rows[index].Cells[2].Value.ToString().Trim() + "? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Resultado == System.Windows.Forms.DialogResult.Yes)
                    {

                        bool Inserto = false;

                        Inserto = new ClassGenerales().EjecutaQuery2("delete from PaquetesDetalle where IdPaquetes=" + iCve);
                        Inserto = new ClassGenerales().EjecutaQuery2("delete from Paquetes where IdPaquetes=" + iCve);

                        if (Inserto == true)
                        {
                            MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Buscar();

                        }
                        else
                        {
                            MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }



    }
}
