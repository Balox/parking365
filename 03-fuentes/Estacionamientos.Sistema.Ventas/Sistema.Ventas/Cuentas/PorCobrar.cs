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
    public partial class PorCobrar : Form
    {
        public PorCobrar()
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



  


        private void CatPersonal_Load(object sender, EventArgs e)
        {

            ComboCliente.DataSource = new ClassGenerales().EjecutaQuery("select NUMEROCLIENTE,NOMBRE FROM cliente order by 2");
            ComboCliente.DisplayMember = "NOMBRE";
            ComboCliente.ValueMember = "NUMEROCLIENTE";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaCierre();
        }


        private void CargaCierre()
        {

            Double Abonos = 0;
            string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");
            string Pagado = CheckPagado.Checked == true ? "1" : "0";


            string Query = "SELECT venta.iCveVenta AS NoVenta, venta.iFolio AS Folio, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, " +
                " venta.fFecha AS Fecha, cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo,Venta.cUtilidad as Utilidad,Switch(Entregado=1,'Entregado',Entregado=0,'Pendiente') as Entregado " +
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

            }
            Query += " and venta.iStatus=1 and Pagado=" + Pagado;

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





            string QueryAbonos = "SELECT venta.iCveVenta AS NoVenta, cliente.NOMBRE AS Cliente, " +
           " AbonosClientes.Abono, AbonosClientes.FechaAbono, AbonosClientes.Comentario " +
" FROM (AbonosClientes  " +
           " INNER JOIN venta ON AbonosClientes.iCveVenta = venta.iCveVenta)  " +
           " INNER JOIN cliente ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE ";




            QueryAbonos = QueryAbonos + " WHERE  cliente.NUMEROCLIENTE=" + ComboCliente.SelectedValue;




            DataTable dtAbonos = new ClassGenerales().EjecutaQuery(QueryAbonos);

            GridAbonos.DataSource = dtAbonos;

            GridAbonos.Columns[0].Width = 55;
            GridAbonos.Columns[1].Visible = false;
            GridAbonos.Columns[2].Width = 70;
            GridAbonos.Columns[3].Width = 150;
            GridAbonos.Columns[4].Width = 150;


            for (int i = 0; i < dtAbonos.Rows.Count; i++)
            {
                Abonos = Abonos + Convert.ToDouble(dtAbonos.Rows[i]["Abono"]);

            }

            txtAbonos.Text = String.Format("{0:0,0.00}", Abonos);
            txtPorCobrar.Text = String.Format("{0:0,0.00}", Subtotal - Descuento-Abonos);

        }


        public void EstilosGrid()
        {
            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            Datos.Columns[0].Width = 60;
            Datos.Columns[1].Width = 60;
            Datos.Columns[2].Width = 160;
            Datos.Columns[3].Width = 160;
            Datos.Columns[4].Width = 70;
            Datos.Columns[5].Width = 70;
            Datos.Columns[6].Width = 70;
            Datos.Columns[7].Width = 70;
            Datos.Columns[8].Width = 70;
            Datos.Columns[9].Visible = false;
            Datos.Columns[10].Visible = false;
            Datos.Columns[11].Visible = false;
            Datos.Columns[12].Visible = false;
            Datos.Columns[13].Visible = false;


            foreach (DataGridViewRow row in Datos.Rows)
            {
                if (row.Cells["Entregado"].Value.ToString() == "Entregado")
                {
                    row.DefaultCellStyle.BackColor = Color.AliceBlue;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else if (row.Cells["Entregado"].Value.ToString() == "Pendiente")
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
              
            }

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {

        }

        private void btnAbonar_Click_1(object sender, EventArgs e)
        {
            try
            {
                Boolean Inserto = false;


                if (txticve.Text == "")
                {
                    MessageBox.Show("Seleccione un número de venta.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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


                Inserto = new ClassGenerales().EjecutaQuery2("insert into AbonosClientes " +
                    " ( iCveVenta, Abono, Comentario,FechaAbono)   values " +
                    " ( " + txticve.Text + ", " + Abono + ", '" + txtComentario.Text.Trim() + "','"+DateTime.Now+"')");

                if (Inserto == true)
                {
                    MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txticve.Text = "";
                    txtAbono.Text = "";
                    txtComentario.Text = "";
                    txtProducto.Text = "";
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                CargaCierre();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Datos.SelectedCells.Count > 0)
            {
                var index = Datos.CurrentCell.RowIndex;
                string iCve = Datos.Rows[index].Cells[0].Value.ToString().Trim();
                txtProducto.Text = Datos.Rows[index].Cells[2].Value.ToString().Trim() + " " + Datos.Rows[index].Cells[3].Value.ToString().Trim();
                txticve.Text = iCve;
            }
        }

        private void btnPendiente_Click(object sender, EventArgs e)
        {
            if (Datos.SelectedCells.Count > 0)
            {
                var index = Datos.CurrentCell.RowIndex;
                string iCve = Datos.Rows[index].Cells[0].Value.ToString().Trim();
                new ClassGenerales().EjecutaQuery2("update venta set Entregado=0 where iCveVenta=" + iCve);
                CargaCierre();
            }
        }

        private void btnEntregado_Click(object sender, EventArgs e)
        {
            if (Datos.SelectedCells.Count > 0)
            {
                var index = Datos.CurrentCell.RowIndex;
                string iCve = Datos.Rows[index].Cells[0].Value.ToString().Trim();
                new ClassGenerales().EjecutaQuery2("update venta set Entregado=1 where iCveVenta=" + iCve);
                CargaCierre();
            }
        }


    }
}
