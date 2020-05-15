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
    public partial class CatColores : Form
    {
        public CatColores()
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
            this.GridDatos.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;
            GridDatos.Columns[0].Visible = false;
            GridDatos.Columns[1].Width = 250;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            CargaGrid();
            EstilosGrid();

        }



        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT iCveColor as Codigo, cDesc as Color, bActivo as Activo FROM Colores;");
            GridDatos.DataSource = dt;
        }



        private void LimpiaControles(string Valor)
        {
            txtNo.Text = Valor;
            txtCategoria.Text = string.Empty;
            CheckStatus.Checked = true;
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
                dt = new ClassGenerales().EjecutaQuery("SELECT iCveColor as Codigo, cDesc as Color, bActivo as Activo " +
                    " FROM Colores where  iCveColor=" + iCveUsuarios);

                txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                txtCategoria.Text = dt.Rows[0]["Color"].ToString();
                CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);

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

                if (txtCategoria.Text == "")
                {
                    MessageBox.Show("Inserte un Color.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Focus();
                    return;
                }




                Boolean Inserto = false;
                string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {//SELECT iCveCategoria as Codigo, cDesc as Categoria, bActivo as Activo FROM Categoria;

                    Inserto = new ClassGenerales().EjecutaQuery2("insert into Colores  (cDesc, bActivo) values " +
                        "('" + txtCategoria.Text.Trim().ToUpper() + "'," + Status + ")  ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update Colores set cDesc='"+txtCategoria.Text.Trim().ToUpper()+
                        "', bActivo="+Status+" where iCveColor=" + iCve);
                }

                if (Inserto == true)
                {
                    MessageBox.Show("Se Registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }


    }
}
