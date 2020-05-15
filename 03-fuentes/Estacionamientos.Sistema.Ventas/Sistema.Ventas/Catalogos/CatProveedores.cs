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
    public partial class CatProveedores : Form
    {
        public CatProveedores()
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
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            GridDatos.Columns[0].Visible = false;
            //GridDatos.Columns[0].Visible = false;
            //GridDatos.Columns[1].Visible = false;
            //GridDatos.Columns[2].Visible = false;
            //GridDatos.Columns[3].Visible = false;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            CargaGrid();
            EstilosGrid();



            //ComboUnidad.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveUnidad from unidad");
            //ComboUnidad.DisplayMember = "cDesc";
            //ComboUnidad.ValueMember = "iCveUnidad";
            //ComboUnidad.SelectedIndex = 0;


            //ComboCategoria.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveCategoria from categoria ");
            //ComboCategoria.DisplayMember = "cDesc";
            //ComboCategoria.ValueMember = "iCveCategoria";
            //ComboCategoria.SelectedIndex = 0;


            //ComboProveedor.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveProveedor from proveedor");
            //ComboProveedor.DisplayMember = "cDesc";
            //ComboProveedor.ValueMember = "iCveProveedor";
            //ComboProveedor.SelectedIndex = 0;

        }


        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT iCveProveedor as Codigo, cDesc as Proveedor, cMarca as Marca,"+
                " cDomicilio as Domicilio, cTelefono as Telefono,bActivo as Activo FROM proveedor;");
            GridDatos.DataSource = dt;
        }



        private void LimpiaControles(string Valor)
        {
            txtNo.Text = Valor;
            txtProveedor.Text = string.Empty;
            txtMarca.Text = string.Empty;
            txtDomicilio.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtTelefono.Text = string.Empty;
          
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
                dt = new ClassGenerales().EjecutaQuery("SELECT iCveProveedor, cDesc, cMarca, cDomicilio, bActivo,"+
                    " cTelefono FROM proveedor where iCveProveedor=" + iCve);

                txtNo.Text = dt.Rows[0]["iCveProveedor"].ToString();
                txtProveedor.Text = dt.Rows[0]["cDesc"].ToString();
                txtMarca.Text = dt.Rows[0]["cMarca"].ToString();
                txtDomicilio.Text = dt.Rows[0]["cDomicilio"].ToString();
                txtTelefono.Text = dt.Rows[0]["cTelefono"].ToString();

                CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["bActivo"]);


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

                if (txtProveedor.Text == "")
                {
                    MessageBox.Show("Inserte un Codigo de barras.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtProveedor.Focus();
                    return;
                }

                //if (txtDireccion.Text == "")
                //{
                //    MessageBox.Show("Inserte un Usuario.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //    txtDireccion.Focus();
                //    return;
                //}



                Boolean Inserto = false;
                string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {

                    Inserto = new ClassGenerales().EjecutaQuery2("insert into proveedor  ( cDesc, cMarca,"+
                        " cDomicilio, bActivo," +
                    " cTelefono) values ( '"+txtProveedor.Text+"', '"+txtMarca.Text+"'," +
                        " '" + txtDomicilio.Text + "', " + Status + "," +
                    " '"+txtTelefono.Text+"') ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update proveedor set cDesc='"+txtProveedor.Text+
                        "', cMarca='"+txtMarca.Text+"', cDomicilio='"+txtDomicilio.Text+"', bActivo="+Status+"," +
                    " cTelefono='"+txtTelefono.Text+"'  where iCveProveedor=" + iCve);
                }

                if (Inserto == true)
                {
                    MessageBox.Show("Se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
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


    }
}
