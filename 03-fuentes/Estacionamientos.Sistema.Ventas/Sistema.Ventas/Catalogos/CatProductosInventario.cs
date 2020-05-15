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

namespace Sistema.Ventas.Catalogos
{
    public partial class CatProductosInventario : Form, iFormActualizaInventario, iFormAsignaProducto
    {
        public CatProductosInventario()
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

            if (e.KeyValue == 112)
            {
                BusquedaProductos form = new BusquedaProductos();
                form.ShowDialog();
            }
        }



        public void EstilosGrid()
        {
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            //GridDatos.Columns[0].Visible = false;
            //GridDatos.Columns[1].Visible = false;
            //GridDatos.Columns[2].Visible = false;
            //GridDatos.Columns[3].Visible = false;
            GridDatos.Columns[0].Width = 50;
            GridDatos.Columns[1].Width = 250;
            GridDatos.Columns[2].Width = 250;
            GridDatos.Columns[3].Width = 100;
            GridDatos.Columns[4].Width = 100;
            GridDatos.Columns[5].Width = 100;
            GridDatos.Columns[6].Width = 100;
            GridDatos.Columns[7].Width = 150;
            GridDatos.Columns[8].Width = 150;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            
            ComboProductos.DataSource = new ClassGenerales().EjecutaQuery("SELECT cDesc AS Producto, iCveProductos FROM productos order by cDesc");
            ComboProductos.DisplayMember = "Producto";
            ComboProductos.ValueMember = "iCveProductos";

            ComboProveedores.DataSource = new ClassGenerales().EjecutaQuery("SELECT iCveProveedor, cDesc FROM proveedor order by cDesc");
            ComboProveedores.DisplayMember = "cDesc";
            ComboProveedores.ValueMember = "iCveProveedor";

        }


        public void CargaGrid()
        {
            DataTable dt = new DataTable();
            DataTable dtVendidas = new DataTable();
            Double PiezasActuales = 0;
            Double Vendidas = 0;
            try
            {

                dt = new ClassGenerales().EjecutaQuery("SELECT productos.cUPC AS Codigo, productos.cDesc AS Producto, " +
                " Categoria.cDesc AS Categoria, productos_inventario.iPiezas AS Piezas, productos_inventario.mPrecioCompra AS PrecioCompra,  " +
"                 productos_inventario.mPrecioVenta AS PrecioVenta, productos_inventario.cUtilidad AS Utilidad, productos_inventario.FechaCompra,  " +
                " proveedor.cDesc as Proveedor " +
" FROM ((productos_inventario  " +
                " INNER JOIN productos ON productos_inventario.iCveProductos = productos.iCveProductos)  " +
                " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria)  " +
                " INNER JOIN proveedor ON productos_inventario.iCveProveedor = proveedor.iCveProveedor " +
" WHERE (((productos.iCveProductos)=" + ComboProductos.SelectedValue + "))");

                GridDatos.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PiezasActuales = PiezasActuales + Convert.ToDouble(dt.Rows[i]["Piezas"]);
                }

                dtVendidas = new ClassGenerales().EjecutaQuery("SELECT Sum(iCantidad) AS Vendidas FROM venta WHERE iStatus=1 and iCveProductos=" + ComboProductos.SelectedValue);

                Vendidas = dtVendidas.Rows[0]["Vendidas"].ToString() == "" ? 0 : Convert.ToDouble(dtVendidas.Rows[0]["Vendidas"]);

                txtPiezasActuales.Text = String.Format("{0:0,0.00}", PiezasActuales);
                txtPiezasVendidas.Text = String.Format("{0:0,0.00}", Vendidas);
                txtPiezasRestantes.Text = String.Format("{0:0,0.00}", PiezasActuales - Vendidas);


                DataTable dtProveedor = new ClassGenerales().EjecutaQuery("select iCveProveedor from productos where iCveProductos=" +
                    ComboProductos.SelectedValue);

                ComboProveedores.SelectedValue = dtProveedor.Rows[0]["iCveProveedor"];

                EstilosGrid();
            }
            catch (Exception)
            {
                GridDatos.DataSource = dt;
                txtPiezasActuales.Text = String.Format("{0:0,0.00}", PiezasActuales);
                txtPiezasVendidas.Text = String.Format("{0:0,0.00}", Vendidas);
                txtPiezasRestantes.Text = String.Format("{0:0,0.00}", PiezasActuales - Vendidas);
            }

        }



        private void LimpiaControles(string Valor)
        {

            txtPiezas.Text = string.Empty;

            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtUtilidad.Text = "0";
        }


        private void toolStripButton6_Click(object sender, EventArgs e)
        {
   
        }


        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            CalculaUtilidad();
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            CalculaUtilidad();
        }


        private void CalculaUtilidad()
        {
            try
            {

            Double PrecioCompra = txtPrecioCompra.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra.Text) == true ? Convert.ToDouble(txtPrecioCompra.Text) : 0;
            Double PrecioVenta = txtPrecioVenta.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta.Text) == true ? Convert.ToDouble(txtPrecioVenta.Text) : 0;

            txtUtilidad.Text = String.Format("{0:0.00}", PrecioVenta-PrecioCompra);

            }
            catch (Exception)
            {
                txtUtilidad.Text = "0";
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            new ClassGenerales().ExportarExcel(GridDatos);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                if (ComboProductos.SelectedValue.ToString() == "null")
                {
                    MessageBox.Show("Seleccione un producto valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ComboProductos.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un producto valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboProductos.Focus();
                return;
            }


            try
            {

                if (ComboProveedores.SelectedValue.ToString() == "null")
                {
                    MessageBox.Show("Seleccione un proveedor valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ComboProveedores.Focus();
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un proveedor valido.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                ComboProveedores.Focus();
                return;
            }



            try
            {

                Double PrecioCompra = txtPrecioCompra.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra.Text) == true ? Convert.ToDouble(txtPrecioCompra.Text) : 0;
                Double PrecioVenta = txtPrecioVenta.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta.Text) == true ? Convert.ToDouble(txtPrecioVenta.Text) : 0;
                Double Utilidad = txtUtilidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtUtilidad.Text) == true ? Convert.ToDouble(txtUtilidad.Text) : 0;
                Double Piezas = txtPiezas.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPiezas.Text) == true ? Convert.ToDouble(txtPiezas.Text) : 0;

                if (Piezas == 0)
                {
                    MessageBox.Show("Ingrese las piezas.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPiezas.Focus();
                    return;
                }

                if (PrecioCompra <= 0)
                {
                    MessageBox.Show("Ingrese Precio Compra.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPiezas.Focus();
                    return;
                }

                if (PrecioVenta <= 0)
                {
                    MessageBox.Show("Ingrese Precio Venta.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPiezas.Focus();
                    return;
                }


                Boolean Inserto = false;

                Inserto = new ClassGenerales().EjecutaQuery2("insert into productos_inventario "+
                    " (iCveProductos,iPiezas,mPrecioCompra,mPrecioVenta,cUtilidad,FechaCompra,iCveProveedor) values " +
                    " (" + ComboProductos.SelectedValue + "," + Piezas + "," + PrecioCompra + "," + PrecioVenta + 
                    "," + Utilidad + ",'" + fInicial .Value+ "',"+ComboProveedores.SelectedValue+") ");

                Inserto = new ClassGenerales().EjecutaQuery2("update productos set mPrecioCompra=" + PrecioCompra +
                    ",mPrecioVenta=" + PrecioVenta + ", " +
                " cUtilidad=" + Utilidad + " where iCveProductos=" + ComboProductos.SelectedValue);


                if (Inserto == true)
                {
                    MessageBox.Show("Se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro verifique todos los datos.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiaControles(string.Empty);
                CargaGrid();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void ComboProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGrid();
        }

        public void AsingaProducto(string iCve)
        {
            ComboProductos.SelectedValue = iCve;
            CargaGrid();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BusquedaProductos form = new BusquedaProductos();
            form.ShowDialog();
        }

    }
}
