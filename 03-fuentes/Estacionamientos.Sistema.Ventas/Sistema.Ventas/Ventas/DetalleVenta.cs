using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Facturacion.Electronica;

namespace Sistema.Ventas
{
    public partial class DetalleVenta : Form
    {
        public DetalleVenta()
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
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", 10);
            GridDatos.Columns[0].Visible = false;
            //GridDatos.Columns[1].Visible = false;
            //GridDatos.Columns[2].Width = 120;
            //GridDatos.Columns[3].Width = 160;

        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            ComboCliente.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' as NOMBRE,-1 as NUMEROCLIENTE from cliente union select NOMBRE,NUMEROCLIENTE from cliente order by 2");
            ComboCliente.DisplayMember = "NOMBRE";
            ComboCliente.ValueMember = "NUMEROCLIENTE";
            ComboCliente.SelectedIndex = 0;

            CargaCierre();

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
            string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.fFecha AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo " +
                " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
                " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
               " where venta.fFecha between #" + sInicial + "# and #" + sFinal + "# ";
            if (ComboCliente.SelectedValue.ToString()!="-1")
            {
                Query += " and venta.NUMEROCLIENTE=" + ComboCliente.SelectedValue.ToString();    
            }
            
            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            GridDatos.DataSource = dtDatos;
            EstilosGrid();
        }

        private void ComboCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargaCierre();
        }

    }
}
