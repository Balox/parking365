using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;

namespace Sistema.Ventas.Catalogos
{
    public partial class PorPagar : Form
    {
        public PorPagar()
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
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            this.GridDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            //GridDatos.Columns[0].Visible = false;
            //GridDatos.Columns[1].Visible = false;
            //GridDatos.Columns[2].Visible = false;
            //GridDatos.Columns[3].Visible = false;
            GridDatos.Columns[0].Width = 70;
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

            ComboProductos.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' AS Producto, '-1' as iCveProductos from configuracion union SELECT cDesc AS Producto, iCveProductos FROM productos order by 1");
            ComboProductos.DisplayMember = "Producto";
            ComboProductos.ValueMember = "iCveProductos";
            ComboProductos.SelectedValue = "-1";

            ComboProveedores.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' AS cDesc, '-1' as iCveProveedor from configuracion union SELECT cDesc,iCveProveedor  FROM proveedor order by 1");
            ComboProveedores.DisplayMember = "cDesc";
            ComboProveedores.ValueMember = "iCveProveedor";
            ComboProveedores.SelectedValue = "-1";
        }


        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            DataTable dtVendidas = new DataTable();
            Double PiezasActuales = 0;
            Double Vendidas = 0;
            Double PrecioCompra = 0;
            Double Abonos = 0;
            try
            {
                string Query = "SELECT IdProductosInventario as NoCompra, productos.cDesc AS Producto, " +
                " Categoria.cDesc AS Categoria, productos_inventario.iPiezas AS Piezas, productos_inventario.mPrecioCompra AS PrecioCompra,  " +
"                 productos_inventario.mPrecioVenta AS PrecioVenta, productos_inventario.cUtilidad AS Utilidad, productos_inventario.FechaCompra,  " +
                " proveedor.cDesc as Proveedor " +
" FROM ((productos_inventario  " +
                " INNER JOIN productos ON productos_inventario.iCveProductos = productos.iCveProductos)  " +
                " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria)  " +
                " INNER JOIN proveedor ON productos_inventario.iCveProveedor = proveedor.iCveProveedor ";


                if (ComboProductos.SelectedValue.ToString() != "-1")
                {
                    Query = Query + " WHERE productos.iCveProductos=" + ComboProductos.SelectedValue;
                }

                if (ComboProveedores.SelectedValue.ToString() != "-1" && ComboProductos.SelectedValue.ToString() != "-1")
                {
                    Query = Query + " and  proveedor.iCveProveedor=" + ComboProveedores.SelectedValue;
                }
                else if (ComboProveedores.SelectedValue.ToString() != "-1" && ComboProductos.SelectedValue.ToString() == "-1")
                {
                    Query = Query + " WHERE  proveedor.iCveProveedor=" + ComboProveedores.SelectedValue;
                }

                dt = new ClassGenerales().EjecutaQuery(Query);


                GridDatos.DataSource = dt;

                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    PiezasActuales = PiezasActuales + Convert.ToDouble(dt.Rows[i]["Piezas"]);
                    PrecioCompra = PrecioCompra + (Convert.ToDouble(dt.Rows[i]["Piezas"]) * Convert.ToDouble(dt.Rows[i]["PrecioCompra"]));
                }

                dtVendidas = new ClassGenerales().EjecutaQuery("SELECT Sum(iCantidad) AS Vendidas FROM venta WHERE iStatus=1 and iCveProductos=" + ComboProductos.SelectedValue);

                Vendidas = dtVendidas.Rows[0]["Vendidas"].ToString() == "" ? 0 : Convert.ToDouble(dtVendidas.Rows[0]["Vendidas"]);

                txtPiezasActuales.Text = String.Format("{0:0,0.00}", PiezasActuales);
                txtPiezasVendidas.Text = String.Format("{0:0,0.00}", Vendidas);
                txtPiezasRestantes.Text = String.Format("{0:0,0.00}", PiezasActuales - Vendidas);



                string QueryAbonos = "SELECT productos_inventario.IdProductosInventario AS NoCompra, proveedor.cDesc AS Proveedor, " +
                " AbonosProveedores.Abono, AbonosProveedores.FechaAbono, AbonosProveedores.Comentario " +
" FROM (AbonosProveedores  " +
                " INNER JOIN productos_inventario ON AbonosProveedores.IdProductosInventario = productos_inventario.IdProductosInventario)  " +
                " INNER JOIN proveedor ON productos_inventario.iCveProveedor = proveedor.iCveProveedor ";

                if (ComboProductos.SelectedValue.ToString() != "-1")
                {
                    QueryAbonos = QueryAbonos + " WHERE productos_inventario.iCveProductos=" + ComboProductos.SelectedValue;
                }

                if (ComboProveedores.SelectedValue.ToString() != "-1" && ComboProductos.SelectedValue.ToString() != "-1")
                {
                    QueryAbonos = QueryAbonos + " and  proveedor.iCveProveedor=" + ComboProveedores.SelectedValue;
                }
                else if (ComboProveedores.SelectedValue.ToString() != "-1" && ComboProductos.SelectedValue.ToString() == "-1")
                {
                    QueryAbonos = QueryAbonos + " WHERE  proveedor.iCveProveedor=" + ComboProveedores.SelectedValue;
                }



                DataTable dtAbonos = new ClassGenerales().EjecutaQuery(QueryAbonos);

                GridAbonos.DataSource = dtAbonos;

              
                for (int i = 0; i < dtAbonos.Rows.Count; i++)
                {
                    Abonos = Abonos + Convert.ToDouble(dtAbonos.Rows[i]["Abono"]);
 
                }

                txtAbonos.Text = String.Format("{0:0,0.00}", Abonos);

                txtPrecioCompra.Text = String.Format("{0:0,0.00}", PrecioCompra);

                txtTotal.Text = String.Format("{0:0,0.00}", PrecioCompra-Abonos);

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


        private void CargaAbonosProveedores()
        {
            //AbonosProveedores
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

                //Double PrecioCompra = txtPrecioCompra.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra.Text) == true ? Convert.ToDouble(txtPrecioCompra.Text) : 0;

                //if (Piezas <= 0)
                //{
                //    MessageBox.Show("Ingrese las piezas.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    txtPiezas.Focus();
                //    return;
                //}



                Boolean Inserto = false;

                //Inserto = new ClassGenerales().EjecutaQuery2("insert into productos_inventario "+
                //    " (iCveProductos,iPiezas,mPrecioCompra,mPrecioVenta,cUtilidad,FechaCompra,iCveProveedor) values " +
                //    " (" + ComboProductos.SelectedValue + "," + Piezas + "," + PrecioCompra + "," + PrecioVenta + 
                //    "," + Utilidad + ",'" + fInicial .Value+ "',"+ComboProveedores.SelectedValue+") ");


                if (Inserto == true)
                {
                    MessageBox.Show("Se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro verifique todos los datos.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        private void ComboProveedores_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {

            try
            {
                Boolean Inserto = false;


                if (txticve.Text == "")
                {
                    MessageBox.Show("Seleccione un número de compra.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txticve.Focus();
                    return;
                }

                Double Abono = txtAbono.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtAbono.Text) == true ? Convert.ToDouble(txtAbono.Text) : 0;

                if (Abono == 0)
                {
                    MessageBox.Show("El abono debe ser distinto de 0 (cero).", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAbono.Focus();
                    return;
                }


                Inserto = new ClassGenerales().EjecutaQuery2("insert into AbonosProveedores " +
                    " ( IdProductosInventario, Abono, Comentario)   values "+
                    " ( " + txticve.Text + ", " + Abono + ", '" + txtComentario.Text.Trim() + "')");

                if (Inserto == true)
                {
                    DialogResult Resultado = MessageBox.Show("¡Se registro correctamente el abono.! \n¿Desea Insertar este abono como gasto.? ", "Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Resultado == System.Windows.Forms.DialogResult.Yes)
                    {

                        Variables.GastoComentario = "NoCompra: " + txticve.Text + " Proveedor: " + txtProveedor.Text + ", " + txtComentario.Text.Trim();
                        Variables.GastoImporte = Abono.ToString();
                        GastosAuxiliar form = new GastosAuxiliar();
                        form.ShowDialog();
                    }
                    else
                    {

                    }

                    //MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txticve.Text = "";
                    txtAbono.Text = "";
                    txtComentario.Text = "";
                    txtProducto.Text = "";
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void GridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatos.SelectedCells.Count > 0)
            {
                var index = GridDatos.CurrentCell.RowIndex;
                string iCve = GridDatos.Rows[index].Cells[0].Value.ToString().Trim();
                txtProducto.Text = GridDatos.Rows[index].Cells[1].Value.ToString().Trim() + " " + GridDatos.Rows[index].Cells[2].Value.ToString().Trim();
                txticve.Text = iCve;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
