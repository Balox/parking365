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
    public partial class Detalles : Form
    {
        public Detalles()
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
                CargaCierre(Variables.FolioDetalles);
            }
            catch (Exception)
            {

                throw;
            }
        }




        public void CargaCierre(int Folio)
        {

            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.fFecha AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo " +
                " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
                " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";
            Query += " where venta.iFolio=" + Folio;
            Query += " and venta.iStatus=1";


            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            Datos.DataSource = dtDatos;
            EstilosGrid();


            Double Subtotal = 0;
            Double Descuento = 0;
            for (int i = 0; i < dtDatos.Rows.Count; i++)
            {
                Subtotal += Convert.ToDouble(dtDatos.Rows[i]["Cantidad"]) *
                    Convert.ToDouble(dtDatos.Rows[i]["PrecioVenta"]);
                Descuento += Convert.ToDouble(dtDatos.Rows[i]["Descuento"]);
            }

            txtArticulosVendidos.Text = dtDatos.Rows.Count.ToString();
            txtSubtotal.Text = String.Format("{0:0,0.00}", Subtotal);
            txtDescuentoTotal.Text = String.Format("{0:0,0.00}", Descuento);
            txtTotal.Text = String.Format("{0:0,0.00}", Subtotal - Descuento);




        }




    }
}
