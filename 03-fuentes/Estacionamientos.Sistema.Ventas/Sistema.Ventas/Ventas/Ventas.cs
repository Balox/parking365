using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;
using System.Data.OleDb;
using System.Configuration;
using Sistema.Ventas.Reportes;
using System.IO;
using Sistema.Ventas.Clases;
using Sistema.Ventas.Catalogos;

namespace Sistema.Ventas
{
    public partial class Ventas : Form, iFormClientes, iFormClientesLoad, iFormAsignaProducto
    {
        public Ventas()
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
            if (e.KeyValue == 121)
            {
                Cobrar();
            }

            if (e.KeyValue == 120)
            {
                txtPago.Focus();
                txtPago.Select();
            }

            if (e.KeyValue == 119)
            {
                txtProductoBusqueda.Focus();
                txtProductoBusqueda.Select();
            }

            if (e.KeyValue == 112)
            {
                BusquedaClientes form = new BusquedaClientes();
                form.ShowDialog();
            }
            if (e.KeyValue == 113)
            {
                BusquedaProductos form = new BusquedaProductos();
                form.ShowDialog();
            }
        }



        public void EstilosGrid()
        {
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);

            //this.GridDatos.RowsDefaultCellStyle.BackColor = Color.Bisque;
            this.GridDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            //GridDatos.Columns[1].Visible = false;
            //GridDatos.Columns[2].Visible = false;
            //GridDatos.Columns[3].Visible = false;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            //Imprimir("3");
            EstilosGrid();
            NuevaVenta();
            //CargaMembresias();


            ComboTicket.DataSource = new ClassGenerales().EjecutaQuery("select '1' as Texto,1 as Valor from configuracion union select '2' as Texto,2 as Valor from configuracion");
            ComboTicket.DisplayMember = "Texto";
            ComboTicket.ValueMember = "Valor";
            ComboTicket.SelectedIndex = 0;
        }



        public void CargaClientes()
        {
            ComboCliente.DataSource = new ClassGenerales().EjecutaQuery("select NOMBRE,NUMEROCLIENTE from cliente order by NOMBRE");
            ComboCliente.DisplayMember = "NOMBRE";
            ComboCliente.ValueMember = "NUMEROCLIENTE";
            ComboCliente.SelectedValue = "2";
        }

 




        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT productos.iCveProductos, productos.iCveUnidad, productos.iCveProveedor, " +
                " productos.iCveCategoria, productos.cUPC as Codigo, productos.cDesc as Producto, productos.iPiezas as Piezas, productos.iMinPiezas as MinPiezas, productos.mPrecioCompra as PrecioCompra " +
                ", productos.mPrecioVenta as PrecioVenta, productos.cUtilidad as Utilidad, proveedor.cDesc as Proveedor, Categoria.cDesc  as Categoria, unidad.cDesc as Unidad" +
" FROM ((productos INNER JOIN unidad ON productos.iCveUnidad = unidad.iCveUnidad) " +
" INNER JOIN proveedor ON productos.iCveProveedor = proveedor.iCveProveedor)" +
" INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria;");
            GridDatos.DataSource = dt;
        }



        private void NuevaVenta()
        {
            try
            {


                DataTable dtVenta = new DataTable();
                dtVenta.Columns.Add("iCveProductos");
                dtVenta.Columns.Add("Cantidad");
                dtVenta.Columns.Add("Producto");
                dtVenta.Columns.Add("PrecioVenta");
                dtVenta.Columns.Add("Descuento");
                dtVenta.Columns.Add("Total");
                dtVenta.Columns.Add("Utilidad");
                dtVenta.Columns.Add("IdPaquetes");
                Variables.dtVenta = dtVenta;
                GridDatos.DataSource = dtVenta;
                GridDatos.Columns[6].Visible = false;
                txtdescripcion.Text = "";
                txtcantidad.Text = "1";
                txtdescuento.Text = "";
                txtSubtotal.Text = "0.00";
                txtDescuentoTotal.Text = "0.00";
                txtTotal.Text = "0.00";
                txtPago.Text = "0.00";
                txtCambio.Text = "0.00";
                txtDescuentoPorcentaje.Text = "0";
                txtUtilidad.Text = "0.00";
                txtObservaciones.Text = "";

                BuscarProductos();
                //CargarCitas();
                CargaClientes();
                //UltimasVisitas();

                txtcodigo.Focus();
                txtcodigo.Select();

                iFormActualizaInventario formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "CatProductosInventario").SingleOrDefault() as iFormActualizaInventario;
                if (formInterface != null)
                    formInterface.CargaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            CargaEdicion();
        }


        private void CargaEdicion()
        {
            if (GridDatos.SelectedCells.Count > 0)
            {
                var index = GridDatos.CurrentCell.RowIndex;
                int iCveUsuarios = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);
                DataTable dt = new DataTable();
                dt = new ClassGenerales().EjecutaQuery("SELECT NUMEROCLIENTE as Codigo,NOMBRE, DIRECCION, CIUDAD,  " +
                    "  TELEFONO, EMAIL, RFC, REFERENCIA FROM cliente where NUMEROCLIENTE= " + iCveUsuarios);



            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CargaEdicion();
        }

        private void GridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaEdicion();
        }

        private void txtcodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                CargaProducto();
            }
        }


        private void CargaProducto()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = new ClassGenerales().EjecutaQuery(" SELECT productos.cDesc as Producto, Categoria.cDesc as Categoria, productos.mPrecioVenta, productos.iCveProductos,productos.cUtilidad "
+ " FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where  productos.cUPC='" + txtcodigo.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    txtdescripcion.Text = dt.Rows[0]["Producto"].ToString() + "- " + dt.Rows[0]["Categoria"].ToString();
                    txtprecio.Text = Math.Round(Convert.ToDecimal(dt.Rows[0]["mPrecioVenta"]), 2).ToString();
                    txtiCveProducto.Text = dt.Rows[0]["iCveProductos"].ToString();
                    txtUtilidad.Text = dt.Rows[0]["cUtilidad"].ToString();


                    //GridDatos.CurrentCell = GridDatos.Rows[GridDatos.Rows.Count - 1].Cells[0];

                    txtcantidad.Focus();
                    txtcantidad.Select();
                }
                else
                {
                    DataTable dtPaquetes = new ClassGenerales().EjecutaQuery(" select IdPaquetes,Nombre,Inicio,Fin from paquetes where Codigo='" + txtcodigo.Text + "'");
                    if (dtPaquetes.Rows.Count > 0)
                    {
                        DateTime fInicial = Convert.ToDateTime(dtPaquetes.Rows[0]["Inicio"]);
                        DateTime fFinal = Convert.ToDateTime(dtPaquetes.Rows[0]["Fin"]);//.AddDays(1);


                        if (fInicial < DateTime.Now && DateTime.Now > fFinal)
                        {
                            MessageBox.Show("El paquete esta activo en el periodo : de " + fInicial.ToString("dd/MMM/yyyy") + " a " + fFinal.ToString("dd/MMM/yyyy"), Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            AgregaProductoPaquete(dtPaquetes.Rows[0]["IdPaquetes"].ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("El código de articulo no existe", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se cargo el producto " + ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargaProductoPaquete()
        {
            try
            {
                DataTable dt = new DataTable();
                dt = new ClassGenerales().EjecutaQuery(" SELECT productos.cDesc as Producto, Categoria.cDesc as Categoria, productos.mPrecioVenta, productos.iCveProductos,productos.cUtilidad "
+ " FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where  productos.cUPC='" + txtcodigo.Text + "'");
                if (dt.Rows.Count > 0)
                {
                    txtdescripcion.Text = dt.Rows[0]["Categoria"].ToString() + "- " + dt.Rows[0]["Producto"].ToString();
                    txtprecio.Text = Math.Round(Convert.ToDecimal(dt.Rows[0]["mPrecioVenta"]), 2).ToString();
                    txtiCveProducto.Text = dt.Rows[0]["iCveProductos"].ToString();
                    txtUtilidad.Text = dt.Rows[0]["cUtilidad"].ToString();


                    //GridDatos.CurrentCell = GridDatos.Rows[GridDatos.Rows.Count - 1].Cells[0];

                    txtcantidad.Focus();
                    txtcantidad.Select();
                }
                else
                {
                    MessageBox.Show("El código de articulo no existe", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
            }
        }

        private void txtProductoBusqueda_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BuscarProductos()
        {
            const string quote = "\"";
            string Query = "SELECT top 30 productos.cDesc as Producto, Categoria.cDesc as Categoria,  productos.cUPC " +
" FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
" WHERE (((productos.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote
+ ") or ((Categoria.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote + "));";
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery(Query);
            GridDatosBusqueda.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.GridDatosBusqueda.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                this.GridDatosBusqueda.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
                GridDatosBusqueda.Columns[0].Width = 230;
                GridDatosBusqueda.Columns[1].Width = 200;
                GridDatosBusqueda.Columns[2].Visible = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregaProducto();
        }

        private void AgregaProducto()
        {

            if (txtcodigo.Text == string.Empty)
            {
                MessageBox.Show("Ingrese un codigo de producto.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodigo.Focus();
                return;
            }

            if (txtcantidad.Text == string.Empty)
                txtcantidad.Text = "1";

            if (txtprecio.Text == string.Empty)
                txtprecio.Text = "0";

            if (txtdescuento.Text == string.Empty)
                txtdescuento.Text = "0";

            Double Cantidad = txtcantidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtcantidad.Text) == true ? Convert.ToDouble(txtcantidad.Text) : 0;
            Double Precio = txtprecio.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtprecio.Text) == true ? Convert.ToDouble(txtprecio.Text) : 0;
            Double Descuento = txtdescuento.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtdescuento.Text) == true ? Convert.ToDouble(txtdescuento.Text) : 0;
            Double Utilidad = txtUtilidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtUtilidad.Text) == true ? Convert.ToDouble(txtUtilidad.Text) : 0;

            if (ClassGenerales.IsNumericDouble(txtprecio.Text) == false ||
                ClassGenerales.IsNumericDouble(txtcantidad.Text) == false || Cantidad == 0 || Precio == 0)
            {
                MessageBox.Show("No cargo ningun articulo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Double Total = 0;
            if (CheckPrecio.Checked)
            {
                Cantidad = (Cantidad * 1) / Precio;
            }


            DataRow lastRow = Variables.dtVenta.NewRow();
            lastRow["iCveProductos"] = txtiCveProducto.Text.Trim();
            lastRow["Cantidad"] = Math.Round(Cantidad, 2).ToString();
            lastRow["Producto"] = txtdescripcion.Text;
            lastRow["PrecioVenta"] = txtprecio.Text;
            lastRow["Descuento"] = txtdescuento.Text;
            lastRow["Total"] = Math.Round((Cantidad * Precio) - Descuento, 2);
            lastRow["Utilidad"] = Math.Round((Cantidad * Utilidad), 2);
            Variables.dtVenta.Rows.Add(lastRow);

            CargaDatosGrid();
            CargaTotales();
            txtcodigo.Text = string.Empty;
            txtcodigo.Focus();
            txtdescuento.Text = "0";
            txtDescuentoPorcentaje.Text = "0";
            txtcantidad.Text = "1";
            CheckPrecio.Checked = false;

            txtUtilidad.Text = "";
            txtdescripcion.Text = "";
            txtiCveProducto.Text = "";

            txtprecio.Text = "0.00";
        }


        private void AgregaProductoPaquete(string IdPaquetes)
        {
            DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT PaquetesDetalle.iCveProductos, " +
                " productos.cDesc as Producto, Categoria.cDesc as Categoria, PaquetesDetalle.mPrecioVentaPaquete, " +
                " PaquetesDetalle.mDescuento, PaquetesDetalle.mUtilidad,PaquetesDetalle.mPrecioVenta " +
" FROM (PaquetesDetalle " +
"INNER JOIN productos ON PaquetesDetalle.iCveProductos = productos.iCveProductos) " +
" INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where IdPaquetes=" + IdPaquetes);



            Double Cantidad = 1;
            for (int i = 0; i < dtDatos.Rows.Count; i++)
            {
                Double PrecioVentaPaquete = dtDatos.Rows[i]["mPrecioVentaPaquete"].ToString() == string.Empty ? 0 : ClassGenerales.IsNumericDouble(dtDatos.Rows[i]["mPrecioVentaPaquete"].ToString()) == true ? Convert.ToDouble(dtDatos.Rows[i]["mPrecioVentaPaquete"].ToString()) : 0;
                Double Descuento = dtDatos.Rows[i]["mDescuento"].ToString() == string.Empty ? 0 : ClassGenerales.IsNumericDouble(dtDatos.Rows[i]["mDescuento"].ToString()) == true ? Convert.ToDouble(dtDatos.Rows[i]["mDescuento"].ToString()) : 0;
                Double PrecioVenta = dtDatos.Rows[i]["mPrecioVenta"].ToString() == string.Empty ? 0 : ClassGenerales.IsNumericDouble(dtDatos.Rows[i]["mPrecioVenta"].ToString()) == true ? Convert.ToDouble(dtDatos.Rows[i]["mPrecioVenta"].ToString()) : 0;
                Double Utilidad = dtDatos.Rows[i]["mUtilidad"].ToString() == string.Empty ? 0 : ClassGenerales.IsNumericDouble(dtDatos.Rows[i]["mUtilidad"].ToString()) == true ? Convert.ToDouble(dtDatos.Rows[i]["mUtilidad"].ToString()) : 0;

                DataRow lastRow = Variables.dtVenta.NewRow();
                lastRow["iCveProductos"] = dtDatos.Rows[i]["iCveProductos"].ToString().Trim();
                lastRow["Cantidad"] = Cantidad;
                lastRow["Producto"] = dtDatos.Rows[i]["Producto"].ToString() + " - " + dtDatos.Rows[i]["Categoria"].ToString();
                lastRow["PrecioVenta"] = PrecioVenta;
                lastRow["Descuento"] = Descuento;
                lastRow["Total"] = (Cantidad * PrecioVenta) - Descuento;
                lastRow["Utilidad"] = (Cantidad * Utilidad);
                lastRow["IdPaquetes"] = IdPaquetes;
                Variables.dtVenta.Rows.Add(lastRow);
            }


            CargaDatosGrid();
            CargaTotales();
            txtcodigo.Text = string.Empty;
            txtcodigo.Focus();
            txtdescuento.Text = "0";
            txtcantidad.Text = "1";
        }

        private void CargaTotales()
        {
            Double Subtotal = 0;
            Double Descuento = 0;
            for (int i = 0; i < Variables.dtVenta.Rows.Count; i++)
            {
                Subtotal += Convert.ToDouble(Variables.dtVenta.Rows[i]["Cantidad"]) *
                    Convert.ToDouble(Variables.dtVenta.Rows[i]["PrecioVenta"]);
                Descuento += Convert.ToDouble(Variables.dtVenta.Rows[i]["Descuento"]);
            }
            txtSubtotal.Text = String.Format("{0:0,0.00}", Subtotal);
            txtDescuentoTotal.Text = String.Format("{0:0,0.00}", Descuento);
            txtTotal.Text = String.Format("{0:0,0.00}", Subtotal - Descuento);
            txtPago.Text = "0.00";// txtTotal.Text;
        }

        private void CargaDatosGrid()
        {
            GridDatos.DataSource = Variables.dtVenta;
            if (Variables.dtVenta.Rows.Count > 0)
            {
                GridDatos.Columns[0].Visible = false;
                GridDatos.Columns[1].Width = 60;
                GridDatos.Columns[2].Width = 280;
                GridDatos.Columns[6].Visible = false;
                GridDatos.Columns[7].Visible = false;
            }

            EstilosGrid();
        }

        private void btnEliminaRenglon_Click(object sender, EventArgs e)
        {
            EliminaRegistro();
        }

        private void EliminaRegistro()
        {
            if (GridDatos.SelectedCells.Count > 0)
            {
                var index = GridDatos.CurrentCell.RowIndex;
                Variables.dtVenta.Rows.RemoveAt(index);
            }
            CargaDatosGrid();
            CargaTotales();
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {

            Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
            Double Total = txtTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTotal.Text) == true ? Convert.ToDouble(txtTotal.Text) : 0;

            
            if (Math.Abs(Pago - Total) < 10)
            {
                txtCambio.Text = (Pago - Total).ToString();
            }
            else
            {
                txtCambio.Text = String.Format("{0:0,0.00}", Pago - Total);
            }

        }

        private void GridDatos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 8)
            {
                EliminaRegistro();
            }
        }

        private void GridDatosBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            if (GridDatosBusqueda.SelectedCells.Count > 0)
            {
                var index = GridDatosBusqueda.CurrentCell.RowIndex;
                string iCve = GridDatosBusqueda.Rows[index].Cells[2].Value.ToString().Trim();
                txtcodigo.Text = iCve;
                CargaProducto();
            }
        }

        private void btnCitas_Click(object sender, EventArgs e)
        {
            new MDIMenu().AbrirCatalogoCitas();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
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
        }

        private void Cobrar()
        {
            try
            {

                Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
                Double Total = txtTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTotal.Text) == true ? Convert.ToDouble(txtTotal.Text) : 0;

                if (CheckPagado.Checked==true)
                {
                    if (Pago < Total)
                    {
                        MessageBox.Show("Ingrese el monto de pago.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtPago.Focus();
                        return;
                    }
                }
                

                DialogResult Resultado = MessageBox.Show("¿Desea realizar el cobro? ", "Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }



                if (GridDatos.Rows.Count == 0)
                {
                    MessageBox.Show("No hay ningun articulo en la lista de venta.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtcodigo.Focus();
                    return;
                }

                try
                {
                    if (ComboCliente.SelectedValue.ToString() == "null")
                    {
                        MessageBox.Show("Seleccione un cliente valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ComboCliente.Focus();
                        return;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Seleccione un cliente valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ComboCliente.Focus();
                    return;
                }


                DataTable dtFolio = new ClassGenerales().EjecutaQuery("SELECT  Max(venta.iFolio)+1 As iFolio  FROM venta;");
                bool Inserta = false;
                string iFolio = dtFolio.Rows[0]["iFolio"].ToString() == "" ? "1" : dtFolio.Rows[0]["iFolio"].ToString();
                string Pagado = CheckPagado.Checked == true ? "1" : "0";
                for (int i = 0; i < Variables.dtVenta.Rows.Count; i++)
                {
                    string IdPaquetes = Variables.dtVenta.Rows[i]["IdPaquetes"].ToString() == "" ? "0" : Variables.dtVenta.Rows[i]["IdPaquetes"].ToString();
                    Inserta = new ClassGenerales().EjecutaQuery2("insert into venta (iFolio, iCveProductos, iCantidad, " +
                        " mPrecioVenta, mDescuento,iCveUsuarios, NUMEROCLIENTE,Total,FechaMaquina,cUtilidad,IdPaquetes,Pagado) values (" + iFolio +
                        ", " + Variables.dtVenta.Rows[i]["iCveProductos"] + ", " + Variables.dtVenta.Rows[i]["Cantidad"] + ", " +
                        " " + Variables.dtVenta.Rows[i]["PrecioVenta"] + ", " + Variables.dtVenta.Rows[i]["Descuento"] +
                        "," + Variables.iCveUsuario + ", " + ComboCliente.SelectedValue.ToString() + ","
                        + Variables.dtVenta.Rows[i]["Total"] + ",'" + DateTime.Now + "'," + Variables.dtVenta.Rows[i]["Utilidad"] + "," +
                        IdPaquetes + "," + Pagado + ")");
                }
                if (Inserta == true)
                {
                    if (CheckImprimir.Checked == true)
                    {
                        for (int i = 0; i < Convert.ToInt32( ComboTicket.SelectedValue); i++)
                        {
                            Imprimir(iFolio);    
                        }
                        
                    }

                    NuevaVenta();
                    //MessageBox.Show("La Cita se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void txtcantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AgregaProducto();
            }
        }



        private void Imprimir(string Folio)
        {
            try
            {
                Double Pago = txtPago.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPago.Text) == true ? Convert.ToDouble(txtPago.Text) : 0;
                Double Cambio = txtCambio.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtCambio.Text) == true ? Convert.ToDouble(txtCambio.Text) : 0;
                if (txtObservaciones.Text=="")
                {
                    txtObservaciones.Text = ".";
                }


                DatosReportes datos = GetTicket(Folio, Pago, Cambio,txtObservaciones.Text.Trim());
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

                //try
                //{
                //    string Ruta = Variables.dtConfiguracion.Rows[0]["CarpetaTicket"].ToString() + @"\" + Folio + ".pdf";
                //    report.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, Ruta);
                //}
                //catch (Exception)
                //{

                //}
                

                report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                report.PrintToPrinter(1, false, 0, 0);

                //if (Variables.dtConfiguracion.Rows[0]["Impresora2"].ToString() != "")
                //{
                //    report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora2"].ToString();
                //    report.PrintToPrinter(1, false, 0, 0);
                //}


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static DatosReportes GetTicket(string Folio, Double Efectivo, Double Cambio,string Observaciones)
        {
            DatosReportes DatosTickets = new DatosReportes();
            // Impresora, RazonSocial, RFC, Domicilio, Ciudad, Estado, Telefono, Email, Saludo, Logo ;
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
                Observaciones + "' as Observaciones , unidad.cDesc AS Unidad" +
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

        private void txtPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                Cobrar();
            }
        }

        private void txtdescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AgregaProducto();
            }
        }

        private void txtDescuentoPorcentaje_TextChanged(object sender, EventArgs e)
        {
            Double Porcentaje = txtDescuentoPorcentaje.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDescuentoPorcentaje.Text) == true ? Convert.ToDouble(txtDescuentoPorcentaje.Text) : 0;
            txtdescuento.Text = "0.00";
            if (Porcentaje <= 100)
            {
                Double Cantidad = txtcantidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtcantidad.Text) == true ? Convert.ToDouble(txtcantidad.Text) : 0;
                Double Precio = txtprecio.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtprecio.Text) == true ? Convert.ToDouble(txtprecio.Text) : 0;
                txtdescuento.Text = ((Cantidad * Precio) * (Porcentaje / 100)).ToString();
            }


        }

        private void txtDescuentoPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                AgregaProducto();
            }
        }

        private void txtFolioHistorico_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {


                if (e.KeyChar == 13)
                {
                    //1 Activo 2 Cancelados

                    DataTable dtFolio = new ClassGenerales().EjecutaQuery("SELECT venta.iFolio FROM venta where iStatus=1 and iFolio=" + txtFolioHistorico.Text);
                    if (dtFolio.Rows.Count > 0)
                    {
                        DialogResult Resultado = MessageBox.Show("¿Desea ReImprimir el ticket? " + txtFolioHistorico.Text, "Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Resultado == System.Windows.Forms.DialogResult.Yes)
                        {

                            for (int i = 0; i < Convert.ToInt32(ComboTicket.SelectedValue); i++)
                            {
                                Imprimir(txtFolioHistorico.Text);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El Folio no existe o esta cancelado", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtFolioHistorico.Text = "";
                        txtFolioHistorico.Focus();
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Cargue un folio valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFolioHistorico.Text = "";
                txtFolioHistorico.Focus();
            }
        }

        private void txtFolioHistorico_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            NuevaVenta();
        }

        //private void DatosVisitas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (DatosVisitas.SelectedCells.Count > 0)
        //    {
        //        var index = DatosVisitas.CurrentCell.RowIndex;
        //        string iCve = DatosVisitas.Rows[index].Cells[2].Value.ToString().Trim();

        //        Detalles form = new Detalles();
        //        Variables.FolioDetalles = Convert.ToInt32(iCve);
        //        //iFormDetalles formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Detalles").SingleOrDefault() as iFormDetalles;
        //        //if (formInterface != null)
        //        //    formInterface.CargaCierre(Convert.ToInt32(iCve));
        //        form.ShowDialog();


        //    }
        //}


        public void SeleccionaCliente(int iCve)
        {
            ComboCliente.SelectedValue = iCve.ToString();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BusquedaClientes form = new BusquedaClientes();
            form.ShowDialog();
        }

        private void GridDatosBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private void txtDiasVencer_TextChanged(object sender, EventArgs e)
        //{
        //    CargaMembresias();
        //}

        //    private void CargaMembresias()
        //    {

        //        try
        //        {
        //            Double Cantidad = txtDiasVencer.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDiasVencer.Text) == true ? Convert.ToDouble(txtDiasVencer.Text) : 0;
        //            DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT cliente.NOMBRE, Membresias.FechaInicial,DateDiff('d', FechaInicial, now()) as DiasTranscurridos " +
        //" FROM Membresias INNER JOIN cliente ON Membresias.NUMEROCLIENTE = cliente.NUMEROCLIENTE" +
        //" where DateDiff('d', FechaInicial, now())>=" + Cantidad);

        //            GridMembresias.DataSource = dtDatos;
        //            GridMembresias.Columns[0].Width = 100;
        //            GridMembresias.Columns[1].Width = 100;
        //            GridMembresias.Columns[2].Width = 100;

        //            this.GridMembresias.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
        //        }
        //        catch (Exception)
        //        {
        //            txtDiasVencer.Text = string.Empty;
        //        }


        //    }

        private void DescPorce_CheckedChanged(object sender, EventArgs e)
        {
            ActivaDesc();
        }

        private void ActivaDesc()
        {
            if (DescPorce.Checked)
            {
                txtDescuentoPorcentaje.Visible = true;
                txtDescuentoPorcentaje.Text = "0";
                txtDescuentoPorcentaje.Focus();

                txtdescuento.Visible = false;
            }

            if (DescPesos.Checked)
            {
                txtDescuentoPorcentaje.Visible = false;

                txtdescuento.Visible = true;
                txtdescuento.Text = "0";
                txtdescuento.Focus();
            }

        }

        private void DescPesos_CheckedChanged(object sender, EventArgs e)
        {
            ActivaDesc();
        }

        private void btnCitasPendientes_Click(object sender, EventArgs e)
        {
            Variables.Auxiliar = "Citas Pendientes";
            Auxiliar form = new Auxiliar();
            form.ShowDialog();
        }

        private void btnUltimasVisitas_Click(object sender, EventArgs e)
        {
            Variables.Auxiliar = "Ultimas Visitas";
            Auxiliar form = new Auxiliar();
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Variables.Auxiliar = "Vencimiento Membresias";
            Auxiliar form = new Auxiliar();
            form.ShowDialog();

        }

        private void btnTiempoAire_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¡No olvide realizar el cobro de tiempo aire, antes de realizar la recarga! ", "Tiempo Aire", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Resultado == System.Windows.Forms.DialogResult.Yes)
            {
                Recargas form = new Recargas();
                form.ShowDialog();
            }
            else
            {
                return;
            }
             

        }

        private void btnPorCobrar_Click(object sender, EventArgs e)
        {
            if (ValidaFormularioAbierto("PorCobrar") == true)
            {
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


        private Form ValidaFormularioAbiertoForm(string Form)
        {
            Form instForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == Form).SingleOrDefault();
            return instForm;
        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            BusquedaProductos form = new BusquedaProductos();
            form.ShowDialog();
        }


        public void AsingaProducto(string iCve)
        {
            txtcodigo.Text = iCve;
            CargaProducto();
        }

    }
}
