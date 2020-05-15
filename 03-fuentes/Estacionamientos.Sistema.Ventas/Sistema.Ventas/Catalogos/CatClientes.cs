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
    public partial class CatClientes : Form
    {
        public CatClientes()
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
            try
            {

            
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            GridDatos.Columns[0].Width = 30;
            GridDatos.Columns[0].Visible = false;
            GridDatos.Columns[1].Width = 250;

            this.GridCompras.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            GridCompras.Columns[0].Visible = false;
            GridCompras.Columns[1].Width = 120;
            GridCompras.Columns[2].Width = 110;
            GridCompras.Columns[3].Width = 100;
            GridCompras.Columns[4].Width = 50;
            GridCompras.Columns[5].Width = 70;
            GridCompras.Columns[6].Width = 70;
            GridCompras.Columns[7].Width = 70;
            GridCompras.Columns[8].Width = 70;
            GridCompras.Columns[9].Width = 50;
            GridCompras.Columns[10].Visible = false;
            GridCompras.Columns[11].Visible = false;
            GridCompras.Columns[12].Visible = false;
            }
            catch (Exception)
            {

               
            }
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            CargaGrid();
            
        }


        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT NUMEROCLIENTE as Codigo,Nombre, Direccion, Ciudad,  Telefono, Email, RFC, Referencia,Cumple FROM cliente");
            GridDatos.DataSource = dt;
            EstilosGrid();
        }



        private void LimpiaControles(string Valor)
        {
            txtNo.Text = Valor;
            txtNombre.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtCiudad.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtRFC.Text = string.Empty;
            txtReferencia.Text = string.Empty;
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
                int iCveUsuarios = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);
                DataTable dt = new DataTable();
                dt = new ClassGenerales().EjecutaQuery("SELECT NUMEROCLIENTE as Codigo,NOMBRE, DIRECCION, CIUDAD,  " +
                    "  TELEFONO, EMAIL, RFC, REFERENCIA,CUMPLE FROM cliente where NUMEROCLIENTE= " + iCveUsuarios);

                txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtDireccion.Text = dt.Rows[0]["DIRECCION"].ToString();
                txtCiudad.Text = dt.Rows[0]["CIUDAD"].ToString();
                txtTelefono.Text = dt.Rows[0]["TELEFONO"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtRFC.Text = dt.Rows[0]["RFC"].ToString();
                txtEmail.Text = dt.Rows[0]["EMAIL"].ToString();
                txtReferencia.Text = dt.Rows[0]["REFERENCIA"].ToString();
                fCumple.Value = Convert.ToDateTime(dt.Rows[0]["CUMPLE"]);
                //CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);
                CargaCierre(iCveUsuarios);
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

                if (txtNombre.Text == "")
                {
                    MessageBox.Show("Inserte un Nombre.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtNombre.Focus();
                    return;
                }

                //if (txtDireccion.Text == "")
                //{
                //    MessageBox.Show("Inserte un Usuario.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtDireccion.Focus();
                //    return;
                //}



                Boolean Inserto = false;
                //string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {//SELECT NUMEROCLIENTE as Codigo,NOMBRE, DIRECCION, CIUDAD,  TELEFONO, EMAIL, RFC, REFERENCIA FROM cliente

                    Inserto = new ClassGenerales().EjecutaQuery2("insert into cliente " +
                        " (NOMBRE, DIRECCION, CIUDAD,  TELEFONO, EMAIL, RFC, REFERENCIA,CUMPLE) values " +
                        " ('" + txtNombre.Text + "', '" + txtDireccion.Text + "', '" + txtCiudad.Text +
                        " ',  '" + txtTelefono.Text + "', '" + txtEmail.Text + "', '" + txtRFC.Text + "', '" + txtReferencia.Text + "','"+fCumple.Value+"') ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCveUsuarios = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update cliente set NOMBRE='"+txtNombre.Text+"', DIRECCION='"+txtDireccion.Text+
                        "', CIUDAD='"+txtCiudad.Text+"',  TELEFONO='"+txtTelefono.Text+"', EMAIL='"+txtEmail.Text+"', RFC='"+txtRFC.Text+
                        "', REFERENCIA='" + txtReferencia.Text + "',CUMPLE='" + fCumple.Value + "' where  NUMEROCLIENTE=" + iCveUsuarios);
                }

                if (Inserto == true)
                {
                    MessageBox.Show("El Cliente se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                LimpiaControles(string.Empty);
                CargaGrid();


                iFormClientesLoad formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Ventas").SingleOrDefault() as iFormClientesLoad;
                if (formInterface != null)
                    formInterface.CargaClientes();

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



        private void CargaCierre(int iCveUsuarios)
        {

            string Query = "SELECT venta.iCveVenta AS NoVenta,venta.fFecha AS Fecha, Categoria.cDesc as Categoria, " +
                " productos.cDesc AS Producto, venta.iCantidad AS Cantidad, venta.mPrecioVenta AS PrecioVenta," +
                " venta.mPrecioVenta*venta.iCantidad as SubTotal, venta.mDescuento AS Descuento, venta.Total, venta.iFolio AS Folio, " +
                "  cliente.NOMBRE AS Cliente, USUARIOS.cNombre AS Usuario, productos.cUPC AS Codigo " +
                " FROM (((venta INNER JOIN productos ON venta.iCveProductos = productos.iCveProductos) INNER JOIN cliente " +
                " ON venta.NUMEROCLIENTE = cliente.NUMEROCLIENTE) INNER JOIN USUARIOS ON venta.iCveUsuarios = USUARIOS.iCveUsuarios) INNER JOIN Categoria ON productos.iCveCategoria = Categoria.iCveCategoria ";

            Query += " where venta.NUMEROCLIENTE=" + iCveUsuarios + " order by venta.fFecha desc";
           

            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            GridCompras.DataSource = dtDatos;
            EstilosGrid();


    




        }

    }
}
