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
    public partial class CatProductos : Form
    {
        public CatProductos()
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
            GridDatos.Columns[0].Visible = false;
            GridDatos.Columns[1].Visible = false;
            GridDatos.Columns[2].Visible = false;
            GridDatos.Columns[3].Visible = false;
            GridDatos.Columns[5].Width = 200;
            GridDatos.Columns[6].Width = 200;
            GridDatos.Columns[4].Width = 60;
            GridDatos.Columns[7].Visible = false;
            GridDatos.Columns[8].Width = 60;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }






        private void CatPersonal_Load(object sender, EventArgs e)
        {
            ComboBusqueda.SelectedIndex = 1;
            CargaGrid();

            ComboUnidad.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveUnidad from unidad");
            ComboUnidad.DisplayMember = "cDesc";
            ComboUnidad.ValueMember = "iCveUnidad";
            ComboUnidad.SelectedIndex = 0;


            ComboCategoria.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveCategoria from categoria ");
            ComboCategoria.DisplayMember = "cDesc";
            ComboCategoria.ValueMember = "iCveCategoria";
            ComboCategoria.SelectedIndex = 0;


            ComboProveedor.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveProveedor from proveedor");
            ComboProveedor.DisplayMember = "cDesc";
            ComboProveedor.ValueMember = "iCveProveedor";
            ComboProveedor.SelectedIndex = 0;

        }


        private void CargaGrid()
        {
            const string quote = "\"";
            DataTable dt = new DataTable();
            string Query = "SELECT top 1000 productos.iCveProductos, productos.iCveUnidad, productos.iCveProveedor, " +
                 " productos.iCveCategoria, productos.cUPC as Codigo, productos.cDesc as Producto, Categoria.cDesc  as Categoria, productos.iPiezas as Piezas, productos.iMinPiezas as MinPiezas, productos.mPrecioCompra as PrecioCompra " +
                 ", productos.mPrecioVenta as PrecioVenta, productos.cUtilidad as Utilidad, proveedor.cDesc as Proveedor, unidad.cDesc as Unidad" +
 " FROM ((productos INNER JOIN unidad ON productos.iCveUnidad = unidad.iCveUnidad) " +
 " INNER JOIN proveedor ON productos.iCveProveedor = proveedor.iCveProveedor)" +
 " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where productos.cDesc ";

            if (ComboBusqueda.SelectedIndex == 1)
            {
                Query += " Like " + quote + "%" + txtProductoBuscar.Text.Trim() + "%" + quote + " and productos.cUPC  Like " + quote + "%" + txtCodigoBusqueda.Text.Trim() + "%" + quote + " order by productos.cDesc asc;";
            }
            else
            {
                Query += " Like " + quote + "" + txtProductoBuscar.Text.Trim() + "%" + quote + " and productos.cUPC  Like " + quote + "%" + txtCodigoBusqueda.Text.Trim() + "%" + quote + " order by productos.cDesc asc;";
            }


            dt = new ClassGenerales().EjecutaQuery(Query);
            GridDatos.DataSource = dt;
            EstilosGrid();

            dt = new ClassGenerales().EjecutaQuery("SELECT top 100 productos.cUPC,productos.cDesc AS Producto, Categoria.cDesc AS Categoria,Sum(p.iPiezas) AS Compradas, v.Vendidos, (Sum(p.iPiezas)-v.Vendidos) AS Actuales, productos.iMinPiezas as MinPiezas " +
" FROM ((productos_inventario AS p INNER JOIN (SELECT sum(iCantidad) as Vendidos,iCveProductos FROM venta group by iCveProductos)  AS v ON p.iCveProductos = v.iCveProductos) INNER JOIN productos ON p.iCveProductos = productos.iCveProductos) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
" GROUP BY v.Vendidos, productos.cUPC, Categoria.cDesc, productos.cDesc, productos.iMinPiezas order by 4 asc ");
            DataTable dtAuxiliar = dt.Clone();


            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToDouble(dr.ItemArray[5]) <= Convert.ToDouble(dr.ItemArray[6]))
                {
                    dtAuxiliar.Rows.Add(dr.ItemArray);
                }
            }


            DatosMinimos.DataSource = dtAuxiliar;

            if (dtAuxiliar.Rows.Count > 0)
            {
                this.DatosMinimos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                DatosMinimos.Columns[0].Width = 120;
                DatosMinimos.Columns[1].Width = 120;
                DatosMinimos.Columns[2].Width = 120;
                DatosMinimos.Columns[3].Width = 90;
                DatosMinimos.Columns[4].Width = 90;
                DatosMinimos.Columns[5].Width = 90;
                DatosMinimos.Columns[6].Width = 90;
            }
        }



        private void LimpiaControles(string Valor)
        {
            txtNo.Text = Valor;
            txtCodigoBarras.Text = string.Empty;
            txtProducto.Text = string.Empty;
            txtPiezas.Text = string.Empty;
            txtMinPiezas.Text = string.Empty;
            txtMinPiezas.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtUtilidad.Text = "0";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LimpiaControles("Nuevo");
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
                int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);
                DataTable dt = new DataTable();
                dt = new ClassGenerales().EjecutaQuery("SELECT productos.iCveProductos, productos.iCveUnidad, productos.iCveProveedor, " +
                " productos.iCveCategoria, productos.cUPC as Codigo, productos.cDesc as Producto, productos.iPiezas as Piezas, productos.iMinPiezas as MinPiezas, productos.mPrecioCompra as PrecioCompra " +
                ", productos.mPrecioVenta as PrecioVenta, productos.cUtilidad as Utilidad, proveedor.cDesc as Proveedor, Categoria.cDesc  as Categoria, unidad.cDesc as Unidad,productos.bActivo as Activo " +
" FROM ((productos INNER JOIN unidad ON productos.iCveUnidad = unidad.iCveUnidad) " +
" INNER JOIN proveedor ON productos.iCveProveedor = proveedor.iCveProveedor)" +
" INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where iCveProductos=" + iCve);

                txtNo.Text = dt.Rows[0]["iCveProductos"].ToString();
                txtCodigoBarras.Text = dt.Rows[0]["Codigo"].ToString();
                txtProducto.Text = dt.Rows[0]["Producto"].ToString();
                txtPiezas.Text = dt.Rows[0]["Piezas"].ToString();
                txtMinPiezas.Text = dt.Rows[0]["MinPiezas"].ToString();
                txtPrecioCompra.Text = dt.Rows[0]["PrecioCompra"].ToString();
                txtPrecioVenta.Text = dt.Rows[0]["PrecioVenta"].ToString();
                txtUtilidad.Text = dt.Rows[0]["Utilidad"].ToString();
                CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);

                ComboCategoria.SelectedValue = dt.Rows[0]["iCveCategoria"].ToString();
                ComboProveedor.SelectedValue = dt.Rows[0]["iCveProveedor"].ToString();
                ComboUnidad.SelectedValue = dt.Rows[0]["iCveUnidad"].ToString();


            }
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNo.Text == "")
                {
                    MessageBox.Show("Seleccione el boton de agregar o editar.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (txtCodigoBarras.Text == "")
                {
                    MessageBox.Show("Inserte un Codigo de barras.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoBarras.Focus();
                    return;
                }

                if (txtProducto.Text == "")
                {
                    MessageBox.Show("Inserte un nombre de producto.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtProducto.Focus();
                    return;
                }

                if (ClassGenerales.IsNumericDouble(txtCodigoBarras.Text) == false)
                {
                    MessageBox.Show("El codigo de barras debe ser númerico", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigoBarras.Focus();
                    return;
                }

                //if (txtDireccion.Text == "")
                //{
                //    MessageBox.Show("Inserte un Usuario.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtDireccion.Focus();
                //    return;
                //}


                Double PrecioCompra = txtPrecioCompra.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioCompra.Text) == true ? Convert.ToDouble(txtPrecioCompra.Text) : 0;
                Double PrecioVenta = txtPrecioVenta.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPrecioVenta.Text) == true ? Convert.ToDouble(txtPrecioVenta.Text) : 0;
                Double Utilidad = txtUtilidad.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtUtilidad.Text) == true ? Convert.ToDouble(txtUtilidad.Text) : 0;
                Double MinPiezas = txtMinPiezas.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtMinPiezas.Text) == true ? Convert.ToDouble(txtMinPiezas.Text) : 0;
                Double Piezas = txtPiezas.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtPiezas.Text) == true ? Convert.ToDouble(txtPiezas.Text) : 0;



                Boolean Inserto = false;
                string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {
                    DataTable dtExiste = new ClassGenerales().EjecutaQuery("SELECT count(iCveProductos) as Existe FROM productos where cUPC='" + txtCodigoBarras.Text + "' ;");
                    if (Convert.ToInt32(dtExiste.Rows[0]["Existe"]) > 0)
                    {
                        MessageBox.Show("El codigo de barras ya existe.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigoBarras.Focus();
                        return;
                    }



                    Inserto = new ClassGenerales().EjecutaQuery2("insert into productos (iCveUnidad, iCveProveedor, iCveCategoria, " +
                        " cUPC, cDesc, iPiezas, iMinPiezas, mPrecioCompra, " +
                        " mPrecioVenta, bActivo, cUtilidad)  values (" + ComboUnidad.SelectedValue.ToString() + ", "
                        + ComboProveedor.SelectedValue.ToString() + ", " + ComboCategoria.SelectedValue.ToString() + ", " +
                        " '" + txtCodigoBarras.Text + "', '" + txtProducto.Text.Trim() + "', " + Piezas + ", " + MinPiezas +
                        ", " + PrecioCompra + ", " +
                        " " + PrecioVenta + ", " + Status + ", '" + Utilidad + "') ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update productos set iCveUnidad=" + ComboUnidad.SelectedValue.ToString() +
                        ", iCveProveedor=" + ComboProveedor.SelectedValue.ToString() + ", iCveCategoria=" + ComboCategoria.SelectedValue.ToString() +
                        ", cUPC='" + txtCodigoBarras.Text + "', cDesc='" + txtProducto.Text.Trim() + "', " +
                        " iPiezas=" + Piezas + ", iMinPiezas=" + MinPiezas + ", mPrecioCompra=" + PrecioCompra +
                        ", mPrecioVenta=" + PrecioVenta + ", bActivo=" + Status + ", cUtilidad='" + Utilidad + "' where iCveProductos= " + iCve);
                }

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

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            CargaEdicion();
        }

        private void GridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargaEdicion();
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

                txtUtilidad.Text = String.Format("{0:0.00}", PrecioVenta - PrecioCompra);

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CheckStatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnInventario_Click(object sender, EventArgs e)
        {
            CatProductosInventario form = new CatProductosInventario();
            form.ShowDialog();
        }

        private void txtProductoBuscar_TextChanged(object sender, EventArgs e)
        {
            CargaGrid();
        }

        private void ComboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoBusqueda.Text = "";
            CargaGrid();
        }

        private void txtProductoBuscar_TextChanged_1(object sender, EventArgs e)
        {
            txtCodigoBusqueda.Text = "";
            //ComboBusqueda.SelectedIndex = 1;

            CargaGrid();
        }

        private void txtCodigoBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtProductoBuscar.Text = "";
            CargaGrid();
        }

        private void btnRepetidos_Click(object sender, EventArgs e)
        {
            try
            {
                lblEliminados.Text = "0 de 0";
                DataTable dtRepetidos = new ClassGenerales().EjecutaQuery("SELECT cUPC,count(cUPC) as Total FROM productos group by cUPC   HAVING COUNT(cUPC) > 1   order by 2 desc");
                DialogResult Resultado = MessageBox.Show("Se encontraton " + dtRepetidos.Rows.Count + " productos repetidos ¿Desea eliminarlos? ", "Cobro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }


                progressBar1.Minimum = 0;
                progressBar1.Maximum = dtRepetidos.Rows.Count - 1;
                if (dtRepetidos.Rows.Count > 0)
                {
                    for (int i = 0; i < dtRepetidos.Rows.Count; i++)
                    {
                        DataTable dtEliminar = new ClassGenerales().EjecutaQuery("select iCveProductos from productos where cUPC='" + dtRepetidos.Rows[i]["cUPC"] + "'");
                        new ClassGenerales().EjecutaQuery2("update venta set iCveProductos=" + dtEliminar.Rows[1][0] + " where iCveProductos=" + dtEliminar.Rows[0][0]);
                        new ClassGenerales().EjecutaQuery2("update productos_inventario set iCveProductos=" + dtEliminar.Rows[1][0] + " where iCveProductos=" + dtEliminar.Rows[0][0]);
                        new ClassGenerales().EjecutaQuery2("delete from productos where iCveProductos=" + dtEliminar.Rows[0][0]);
                        lblEliminados.Text = i + " de " + progressBar1.Maximum;
                        lblEliminados.Refresh();
                        progressBar1.Value = i;
                        progressBar1.PerformStep();
                    }

                }
            }
            catch (Exception)
            {
            }
        }




    }
}
