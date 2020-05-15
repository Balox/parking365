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
    public partial class CatModelos : Form
    {
        public CatModelos()
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
            GridDatos.Columns[0].Width = 80;
            GridDatos.Columns[1].Width = 130;
            GridDatos.Columns[2].Width = 130;
            GridDatos.Columns[3].Width = 60;
            //GridDatos.Columns[0].Width = 100;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            try
            {
                CargaGrid();
                EstilosGrid();


                ComboMarca.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveMarca from CatMarcas");
                ComboMarca.DisplayMember = "cDesc";
                ComboMarca.ValueMember = "iCveMarca";
                ComboMarca.SelectedIndex = 0;
            }
            catch (Exception)
            {

            }
          
        }



        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT CatModelo.iCveModelos AS Codigo,CatMarcas.cDesc as Marca, CatModelo.cDesc AS Modelo, CatModelo.bActivo AS Activo,Tarifa  "+
                " FROM CatModelo INNER JOIN CatMarcas ON CatModelo.iCveMarca = CatMarcas.iCveMarca;");
            GridDatos.DataSource = dt;

            //DataTable dtMarca= new DataTable();
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    dtMarca= new ClassGenerales().EjecutaQuery("select iCveMarca from CatMarcas where cDesc='"+dt.Rows[i]["Marca"].ToString().Trim()+"'");
            //    new ClassGenerales().EjecutaQuery2("update CatModelo set iCveMarca=" + dtMarca.Rows[0][0] + " where iCveModelos=" + dt.Rows[i]["Codigo"].ToString().Trim());
            //}
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
                dt = new ClassGenerales().EjecutaQuery("SELECT iCveMarca as Codigo, cDesc as Modelo, bActivo as Activo,iCveMarca,Tarifa " +
                    " FROM CatModelo where  iCveModelos=" + iCveUsuarios);

                txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                txtCategoria.Text = dt.Rows[0]["Modelo"].ToString();
                CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);
                ComboMarca.SelectedValue = dt.Rows[0]["iCveMarca"].ToString();
               txtTarifa.Text = dt.Rows[0]["Tarifa"].ToString();
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
                    MessageBox.Show("Inserte un Modelo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Focus();
                    return;
                }


                Double Tarifa = txtTarifa.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtTarifa.Text) == true ? Convert.ToDouble(txtTarifa.Text) : 0;

                if (Tarifa==0)
                {
                    MessageBox.Show("Ingrese una tarifa para el modelo.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCategoria.Focus();
                    return;
                }
                
                Boolean Inserto = false;
                string Status = CheckStatus.Checked == true ? "1" : "0";
                if (txtNo.Text == "Nuevo")
                {

                    Inserto = new ClassGenerales().EjecutaQuery2("insert into CatModelo  (cDesc, bActivo,iCveMarca,Tarifa) values " +
                        "('"+txtCategoria.Text.Trim()+"',"+Status+","+ComboMarca.SelectedValue+","+Tarifa+")  ");

                }
                else
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                    Inserto = new ClassGenerales().EjecutaQuery2("update CatModelo set cDesc='" + txtCategoria.Text.Trim().ToUpper() +
                        "', bActivo=" + Status + ",iCveMarca=" + ComboMarca.SelectedValue + ",Tarifa="+Tarifa+" where iCveModelos=" + iCve);
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
