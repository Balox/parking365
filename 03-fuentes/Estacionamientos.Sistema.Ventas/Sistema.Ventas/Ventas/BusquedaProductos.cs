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

namespace Sistema.Ventas
{
    public partial class BusquedaProductos : Form
    {
        public BusquedaProductos()
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
            this.GridDatosBusqueda.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            GridDatosBusqueda.Columns[0].Width = 170;
            GridDatosBusqueda.Columns[1].Width = 170;
            GridDatosBusqueda.Columns[2].Width = 170;
            GridDatosBusqueda.Columns[3].Visible = false;
        }





        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            BuscarProductos();
            txtProductoBusqueda.Focus();
            txtProductoBusqueda.Select();
        }

        private void BuscarProductos()
        {
            const string quote = "\"";
            string Query = "SELECT top 30 productos.cUPC as Codigo,productos.cDesc as Producto, Categoria.cDesc as Categoria,  productos.cUPC,productos.iCveProductos " +
" FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";



            if (ComboBusqueda.SelectedIndex == 1)
            {
                //Query += " Like " + quote + "%" + txtProductoBuscar.Text.Trim() + "%" + quote + " and productos.cUPC  Like " + quote + "%" + txtCodigoBusqueda.Text.Trim() + "%" + quote + " order by productos.cDesc asc;";

                Query += " WHERE (((productos.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote
+ ") or ((Categoria.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote + "))  and productos.cUPC  Like " + quote + "%" + txtCodigoBusqueda.Text.Trim() + "%" + quote;

            }
            else
            {
                Query += " WHERE (((productos.cDesc) Like " + quote + "" + txtProductoBusqueda.Text.Trim() + "%" + quote
+ ") or ((Categoria.cDesc) Like " + quote + "" + txtProductoBusqueda.Text.Trim() + "%" + quote + "))  and productos.cUPC  Like " + quote + "%" + txtCodigoBusqueda.Text.Trim() + "%" + quote;
                //Query += " Like " + quote + "" + txtProductoBuscar.Text.Trim() + "%" + quote + " order by productos.cDesc asc;";
            }


            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery(Query);
            GridDatosBusqueda.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.GridDatosBusqueda.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                GridDatosBusqueda.Columns[0].Width = 50;
                GridDatosBusqueda.Columns[1].Width = 230;
                GridDatosBusqueda.Columns[2].Width = 200;
                GridDatosBusqueda.Columns[3].Visible = false;
                GridDatosBusqueda.Columns[4].Visible = false;
            }
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosBusqueda.SelectedCells.Count > 0)
            {
                var index = GridDatosBusqueda.CurrentCell.RowIndex;
                string iCve = GridDatosBusqueda.Rows[index].Cells[3].Value.ToString().Trim();

                iFormAsignaProducto formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "CatProductosInventario").SingleOrDefault() as iFormAsignaProducto;
                if (formInterface != null)
                    formInterface.AsingaProducto(iCve);
                iFormAsignaProducto formInterface2 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Ventas").SingleOrDefault() as iFormAsignaProducto;
                if (formInterface2 != null)
                    formInterface2.AsingaProducto(GridDatosBusqueda.Rows[index].Cells["Codigo"].Value.ToString().Trim());
                this.Close();
            }
        }

        private void ComboBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtCodigoBusqueda.Text = "";
            BuscarProductos();
        }

        private void txtProductoBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtCodigoBusqueda.Text = "";
            //ComboBusqueda.SelectedIndex = 1;
            BuscarProductos();
        }

        private void txtCodigoBusqueda_TextChanged(object sender, EventArgs e)
        {
            txtProductoBusqueda.Text = "";
            BuscarProductos();
        }

        private void GridDatosBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridDatosBusqueda.SelectedCells.Count > 0)
            {
                var index = GridDatosBusqueda.CurrentCell.RowIndex;
                string iCve = GridDatosBusqueda.Rows[index].Cells["iCveProductos"].Value.ToString().Trim();

                iFormAsignaProducto formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "CatProductosInventario").SingleOrDefault() as iFormAsignaProducto;
                if (formInterface != null)
                    formInterface.AsingaProducto(iCve);

                iFormAsignaProducto formInterface2 = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Ventas").SingleOrDefault() as iFormAsignaProducto;
                if (formInterface2 != null)
                    formInterface2.AsingaProducto(GridDatosBusqueda.Rows[index].Cells["Codigo"].Value.ToString().Trim());

                this.Close();
            }
        }

        private void GridDatosBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




    }
}
