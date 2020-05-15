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
    public partial class CatMarcas : Form
    {
        public CatMarcas()
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
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            CargaGrid();
            EstilosGrid();
        }



        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT iCveMarca as Codigo, cDesc as Marca, bActivo as Activo FROM CatMarcas;");
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
                dt = new ClassGenerales().EjecutaQuery("SELECT iCveMarca as Codigo, cDesc as Marca, bActivo as Activo " +
                    " FROM CatMarcas where  iCveMarca=" + iCveUsuarios);

                txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                txtCategoria.Text = dt.Rows[0]["Marca"].ToString();
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
                    MessageBox.Show("Inserte una Marca.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Focus();
                    return;
                }




                Boolean Inserto = false;
                string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {//SELECT iCveCategoria as Codigo, cDesc as Categoria, bActivo as Activo FROM Categoria;

                    Inserto = new ClassGenerales().EjecutaQuery2("insert into CatMarcas  (cDesc, bActivo) values " +
                        "('"+txtCategoria.Text.Trim()+"',"+Status+")  ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update CatMarcas set cDesc='" + txtCategoria.Text.Trim() +
                        "', bActivo=" + Status + " where iCveMarca=" + iCve);
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
