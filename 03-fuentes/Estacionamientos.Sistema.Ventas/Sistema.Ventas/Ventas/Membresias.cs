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

namespace Sistema.Ventas
{
    public partial class Membresias : Form
    {
        public Membresias()
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
            ComboCliente.DataSource = new ClassGenerales().EjecutaQuery(" select NOMBRE,NUMEROCLIENTE from cliente order by 1");
            ComboCliente.DisplayMember = "NOMBRE";
            ComboCliente.ValueMember = "NUMEROCLIENTE";
            ComboCliente.SelectedIndex = 0;

            ComboClientesBusqueda.DataSource = new ClassGenerales().EjecutaQuery("select 'TODOS' as NOMBRE,-1 as NUMEROCLIENTE from cliente union select NOMBRE,NUMEROCLIENTE from cliente order by 1");
            ComboClientesBusqueda.DisplayMember = "NOMBRE";
            ComboClientesBusqueda.ValueMember = "NUMEROCLIENTE";
            ComboClientesBusqueda.SelectedIndex = 0;




            ComboNiveles.DataSource = new ClassGenerales().EjecutaQuery(" select Nivel from Niveles order by 1");
            ComboNiveles.DisplayMember = "Nivel";
            ComboNiveles.ValueMember = "Nivel";
            ComboNiveles.SelectedIndex = 0;

            BuscarProductos();
            BuscaServicios();


            DataTable dtMembresiaDetalle = new DataTable();
            dtMembresiaDetalle.Columns.Add("iCveProductos");
            Variables.dtMembresiaDetalle = dtMembresiaDetalle;

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
            string Query = "SELECT productos.cDesc as Producto, Categoria.cDesc as Categoria,  productos.cUPC,productos.iCveProductos " +
" FROM productos INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria " +
" WHERE (((productos.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote
+ ") or ((Categoria.cDesc) Like " + quote + "%" + txtProductoBusqueda.Text.Trim() + "%" + quote + "));";
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery(Query);
            GridDatosBusqueda.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                this.GridDatosBusqueda.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
                GridDatosBusqueda.Columns[0].Width = 130;
                GridDatosBusqueda.Columns[1].Width = 130;
                GridDatosBusqueda.Columns[2].Visible = false;
                GridDatosBusqueda.Columns[3].Visible = false;
            }
        }

        private void txtProductoBusqueda_TextChanged_1(object sender, EventArgs e)
        {
            BuscarProductos();
        }

        private void ComboNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscaServicios();
            GridServicios.Rows.Clear();
        }

        private void BuscaServicios()
        {
            try
            {
                DataTable dtDatos = new ClassGenerales().EjecutaQuery(" select NoServicios from Niveles where Nivel=" + ComboNiveles.SelectedValue);
                txtServicios.Text = dtDatos.Rows[0]["NoServicios"].ToString();
            }
            catch (Exception)
            {
                txtServicios.Text = "0";
            }
        }

        private void txtFolioPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (e.KeyChar == 13)
                {
                    CargaCierre();
                }
            }
            catch (Exception)
            {


            }

        }



        private void CargaCierre()
        {

            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.fFecha AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo,Venta.cUtilidad as Utilidad " +
                " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
                " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";

            if (ClassGenerales.IsNumericDouble(txtFolioPago.Text))
            {
                Query += " where venta.iFolio=" + txtFolioPago.Text.Trim();
            }

            Query += " and venta.iStatus=1";

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

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


            //txtUtilidad.Text = String.Format("{0:0,0.00}", Utilidad);
            //txtArticulosVendidos.Text = dtDatos.Rows.Count.ToString();
            //txtSubtotal.Text = String.Format("{0:0,0.00}", Subtotal);
            //txtDescuentoTotal.Text = String.Format("{0:0,0.00}", Descuento);
            txtTotal.Text = String.Format("{0:0,0.00}", Subtotal - Descuento);

        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(txtServicios.Text) > GridServicios.Rows.Count)
            {
                if (GridDatosBusqueda.SelectedCells.Count > 0)
                {
                    var index = GridDatosBusqueda.CurrentCell.RowIndex;
                    string iCve = GridDatosBusqueda.Rows[index].Cells[3].Value.ToString().Trim();
                    string Producto = GridDatosBusqueda.Rows[index].Cells[0].Value.ToString().Trim() + " " +
                        GridDatosBusqueda.Rows[index].Cells[1].Value.ToString().Trim();
                    GridServicios.Rows.Add(iCve, Producto);
                }
            }
            else
            {
                MessageBox.Show("No se permite agregar más servicios.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {

                Double Total = txtTotal.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTotal.Text) == true ? Convert.ToDouble(txtTotal.Text) : 0;
                if (Total <= 0)
                {
                    MessageBox.Show("Valide el monto del folio pagado.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (GridServicios.Rows.Count == 0)
                {
                    MessageBox.Show("Ingrese los servicios.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }


                Boolean Inserto = false;

                Inserto = new ClassGenerales().EjecutaQuery2("insert into Membresias (NUMEROCLIENTE,IdNivel,FechaInicial,Folio) values (" + ComboCliente.SelectedValue + "," +
                    ComboNiveles.SelectedValue + ",'" + fInicial.Value + "'," + txtFolioPago.Text + ")");

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("select max(IdMembresia) as IdMembreria from Membresias");

                for (int i = 0; i < GridServicios.Rows.Count; i++)
                {
                    Inserto = new ClassGenerales().EjecutaQuery2("insert into MembresiasDetalle (IdMembresia,iCveProductos) values " +
                        "(" + dtDatos.Rows[0][0] + "," + GridServicios.Rows[i].Cells[0].Value.ToString().Trim() + ")");
                }


                if (Inserto == true)
                {
                    MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Limpiar();
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

        private void Limpiar()
        {
            txtFolioPago.Text = "";
            txtTotal.Text = "";
            ComboNiveles.SelectedIndex = 0;
            GridServicios.Rows.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT Membresias.IdMembresia, cliente.NOMBRE as Nombre, Niveles.Nivel, Niveles.NoServicios, Membresias.FechaInicial, Membresias.Folio " +
" FROM (Membresias INNER JOIN cliente ON Membresias.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN Niveles ON Membresias.IdNivel = Niveles.IdNivel";

            Query += " where FechaInicial between #" + sInicial + "# and #" + sFinal + "# ";


            if (ComboClientesBusqueda.SelectedValue.ToString() != "-1")
            {
                Query += " and cliente.NUMEROCLIENTE=" + ComboClientesBusqueda.SelectedValue.ToString();
            }

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            GridMembresiasBusqueda.DataSource = dtDatos;
            GridMembresiasBusqueda.Columns[0].Visible = false;
            GridMembresiasBusqueda.Columns[2].Width = 50;
            GridMembresiasBusqueda.Columns[3].Visible = false;
            GridMembresiasBusqueda.Columns[5].Width = 50;
        }


        private void GridMembresiasBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            GridServiciosBusqueda.Rows.Clear();
            if (GridMembresiasBusqueda.SelectedCells.Count > 0)
            {
                var index = GridMembresiasBusqueda.CurrentCell.RowIndex;
                string iCve = GridMembresiasBusqueda.Rows[index].Cells[0].Value.ToString().Trim();

                DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT MembresiasDetalle.Utilizado, productos.cDesc as Producto, Categoria.cDesc as Categoria "
                    + " , MembresiasDetalle.FechaUtilizado " +
",MembresiasDetalle.IdMembresiaDetalle FROM (MembresiasDetalle " +
" INNER JOIN productos ON MembresiasDetalle.iCveProductos = productos.iCveProductos) " +
" INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where IdMembresia=" + iCve);

                for (int i = 0; i < dtDatos.Rows.Count; i++)
                {
                    GridServiciosBusqueda.Rows.Add(dtDatos.Rows[i]["Utilizado"],
                         dtDatos.Rows[i]["Producto"] + "-" + dtDatos.Rows[i]["Categoria"],
                        dtDatos.Rows[i]["FechaUtilizado"],
                        dtDatos.Rows[i]["IdMembresiaDetalle"]);
                }

            }
        }

        private void GridServiciosBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (GridServiciosBusqueda.Rows[e.RowIndex].Cells[0].Value.ToString() == "True")
                {
                    DialogResult Resultado = MessageBox.Show("¿Desea desmarcar el servicio? ", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Resultado == System.Windows.Forms.DialogResult.Yes)
                    {
                        GridServiciosBusqueda.Rows[e.RowIndex].Cells[0].Value = "False";
                    }
                }
                else
                {
                    GridServiciosBusqueda.Rows[e.RowIndex].Cells[0].Value = "True";
                }
            }
        }

        private void btnGuardaServicios_Click(object sender, EventArgs e)
        {
            try
            {


                bool Inserto = false;
                for (int i = 0; i < GridServiciosBusqueda.Rows.Count; i++)
                {
                    int Utilizado = GridServiciosBusqueda.Rows[i].Cells[0].Value.ToString() == "True" || GridServiciosBusqueda.Rows[i].Cells[0].Value.ToString() == "1" ? 1 : 0;
                    if (Utilizado == 1)
                    {
                        Inserto = new ClassGenerales().EjecutaQuery2("update MembresiasDetalle set Utilizado=" + Utilizado
                            + ", FechaUtilizado='" + fMovimiento.Value + "' where IdMembresiaDetalle=" + GridServiciosBusqueda.Rows[i].Cells[3].Value);
                    }
                    else
                    {
                        Inserto = new ClassGenerales().EjecutaQuery2("update MembresiasDetalle set Utilizado=" + Utilizado
                           + ", FechaUtilizado=null where IdMembresiaDetalle=" + GridServiciosBusqueda.Rows[i].Cells[3].Value);    
                    }
                    
                }


                if (Inserto == true)
                {
                    MessageBox.Show("Se Registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridServiciosBusqueda.Rows.Clear();
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

        private void btnQuitar_Click(object sender, EventArgs e)
        {


            if (GridServicios.SelectedCells.Count > 0)
            {
                var index = GridServicios.CurrentCell.RowIndex;
                GridServicios.Rows.RemoveAt(index);
            }

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (GridServiciosBusqueda.Rows.Count > 0)
            {

                if (GridMembresiasBusqueda.SelectedCells.Count > 0)
                {
                    var index = GridMembresiasBusqueda.CurrentCell.RowIndex;
                    string iCve = GridMembresiasBusqueda.Rows[index].Cells[0].Value.ToString().Trim();

                    DatosReportes datos = GetTicket(iCve);
                    DatosReportes.dtTicketRow row = datos.dtTicket.NewdtTicketRow();

                    rptMembresias report = new rptMembresias();
                    report.SetDataSource(datos);

                    report.PrintOptions.PrinterName = Variables.dtConfiguracion.Rows[0]["Impresora"].ToString();
                    report.PrintToPrinter(1, false, 0, 0);
                }
            }
            else
                MessageBox.Show("Seleccione una membresia para imprimir.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }



        public static DatosReportes GetTicket(string iCve)
        {
            DatosReportes DatosTickets = new DatosReportes();
            string Query =     "SELECT cliente.NOMBRE as Cliente, productos.cDesc as Producto, " +
                        " Categoria.cDesc as Categoria,Switch(Utilizado=1,'No',Utilizado=0,'Si') AS Disponible, " +
                        " MembresiasDetalle.FechaUtilizado, Membresias.FechaInicial, Membresias.Folio " +
        "FROM (((Membresias INNER JOIN MembresiasDetalle ON Membresias.IdMembresia = MembresiasDetalle.IdMembresia) " +
        " INNER JOIN cliente ON Membresias.NUMEROCLIENTE = cliente.NUMEROCLIENTE) " +
        " INNER JOIN productos ON MembresiasDetalle.iCveProductos = productos.iCveProductos) " +
        " INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria where Membresias.IdMembresia=" + iCve;

            OleDbConnection cone = new OleDbConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
            OleDbCommand cmd = new OleDbCommand(Query, cone);
            cmd.CommandType = CommandType.Text;
            cone.Open();

            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(DatosTickets, "dtMembresias");

            cone.Close();
            return DatosTickets;
        }





    }
}
