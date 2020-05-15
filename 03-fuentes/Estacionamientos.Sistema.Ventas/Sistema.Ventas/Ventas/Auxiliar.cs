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
    public partial class Auxiliar : Form
    {
        public Auxiliar()
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
            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            Datos.Columns[0].Width = 200;
            Datos.Columns[1].Width = 200;
            Datos.Columns[2].Width = 200;
            Datos.Columns[3].Visible = false;
        }





        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            this.Text = Variables.Auxiliar;

            switch (Variables.Auxiliar)
            {
                case "Citas Pendientes": CargarCitas(); break;
                case "Ultimas Visitas": UltimasVisitas(); break;
                case "Vencimiento Membresias": txtDiasVencer.Visible = true; label8.Visible = true; CargaMembresias(); break;
            }



        }


        private void CargaMembresias()
        {

            try
            {
                Double Cantidad = txtDiasVencer.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtDiasVencer.Text) == true ? Convert.ToDouble(txtDiasVencer.Text) : 0;
                DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT cliente.NOMBRE, Membresias.FechaInicial,DateDiff('d', FechaInicial, now()) as DiasTranscurridos " +
    " FROM Membresias INNER JOIN cliente ON Membresias.NUMEROCLIENTE = cliente.NUMEROCLIENTE" +
    " where DateDiff('d', FechaInicial, now())>=" + Cantidad);

                Datos.DataSource = dtDatos;
                Datos.Columns[0].Width = 200;
                Datos.Columns[1].Width = 200;
                Datos.Columns[2].Width = 200;

                this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            }
            catch (Exception)
            {
                txtDiasVencer.Text = string.Empty;
            }


        }



        private void UltimasVisitas()
        {
            int Dias = Convert.ToInt32(Variables.dtConfiguracion.Rows[0]["Aviso"]);

            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT Max(venta.fFecha) AS UltimaVisita, cliente.NOMBRE as Cliente, venta.iFolio " +
" FROM (venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE " +
                 "where venta.fFecha <= DateAdd('d',-" + Dias + ",now()) and venta.iStatus=1    " +
                 "  GROUP BY cliente.NOMBRE, venta.iFolio  order by 1");

            Datos.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                Datos.Columns[0].Width = 200;
                Datos.Columns[1].Width = 200;
                Datos.Columns[2].Visible = false;
            }

        }



        private void CargarCitas()
        {
            //DiasCitas
            int Dias = Convert.ToInt32(Variables.dtConfiguracion.Rows[0]["DiasCitas"]);
            string sInicial = DateTime.Now.ToString("MM/dd/yyyy");
            string sFinal = DateTime.Now.AddDays(Dias).ToString("MM/dd/yyyy");


            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT Citas.iCveCita as Codigo, Citas.NUMEROCLIENTE, cliente.NOMBRE as Nombre, Citas.Fecha, Citas.Comentarios "
                + " FROM Citas INNER JOIN cliente ON Citas.NUMEROCLIENTE = cliente.NUMEROCLIENTE  " +
                " where Citas.Concretada=0 " +
                 " and Citas.Fecha between #" + sInicial + "# and #" + sFinal + "# " +
                " order by Citas.Fecha");
            Datos.DataSource = dt;
            if (dt.Rows.Count > 0)
            {
                this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
                Datos.Columns[0].Visible = false;
                Datos.Columns[1].Visible = false;
                Datos.Columns[2].Width = 200;
                Datos.Columns[3].Width = 200;
                Datos.Columns[4].Width = 200;
            }

        }




        private void BuscaCliente()
        {
            //            const string quote = "\"";
            //            DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT cliente.NOMBRE as Nombre, cliente.TELEFONO as Telefono, cliente.EMAIL as Email, cliente.NUMEROCLIENTE " +
            //" FROM cliente where cliente.NOMBRE  like " + quote + "%" +txtNombre.Text.Trim() + "%" + quote + "");
            //            Datos.DataSource = dtDatos;
            //            EstilosGrid();
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Text == "Ultimas Visitas")
            {

                if (Datos.SelectedCells.Count > 0)
                {
                    var index = Datos.CurrentCell.RowIndex;
                    string iCve = Datos.Rows[index].Cells[2].Value.ToString().Trim();
                    Detalles form = new Detalles();
                    Variables.FolioDetalles = Convert.ToInt32(iCve);
                    form.ShowDialog();


                }
            }
        }

        private void txtDiasVencer_TextChanged(object sender, EventArgs e)
        {
            CargaMembresias();
        }




    }
}
