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
    public partial class CatCitas : Form
    {
        public CatCitas()
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
            this.GridDatos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            GridDatos.Columns[0].Visible = false;
            GridDatos.Columns[1].Visible = false;
            GridDatos.Columns[2].Width = 120;
            GridDatos.Columns[3].Width = 160;
            GridDatos.Columns[4].Width = 160;
            GridDatos.RowTemplate.Height = 60;
            GridDatos.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            //this.GridDatos.DefaultCellStyle.ForeColor = Color.White;
            //this.GridDatos.DefaultCellStyle.BackColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            //this.GridDatos.DefaultCellStyle.SelectionBackColor = Color.White;
        }


        private void CatPersonal_Load(object sender, EventArgs e)
        {
            CargaGrid();
            EstilosGrid();

            ComboProveedor.DataSource = new ClassGenerales().EjecutaQuery("select cDesc,iCveProveedor from proveedor");
            ComboProveedor.DisplayMember = "cDesc";
            ComboProveedor.ValueMember = "iCveProveedor";
            ComboProveedor.SelectedIndex = 0;

        }


        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT Citas.iCveCita as Codigo, Citas.iCveProveedor, cDesc as NOMBRE, Citas.Fecha, Citas.Comentarios,Switch(Concretada=1,'Si',Concretada=0,'No') AS Concretadas "
+ " FROM Citas INNER JOIN proveedor ON Citas.iCveProveedor = proveedor.iCveProveedor order by Concretada asc, Fecha asc");
            GridDatos.DataSource = dt;

        }


        private void LimpiaControles(string Valor)
        {

            txtObservaciones.Text = string.Empty;

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
                dt = new ClassGenerales().EjecutaQuery("SELECT iCveUsuarios as Codigo, cNombre as Nombre, cUsuario as Usuario, " +
                    "cPassword as Pass, bAdmon as Admon, bActivo as Activo FROM USUARIOS");

                //txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                //txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                //txtusuario.Text = dt.Rows[0]["Usuario"].ToString();
                //txtcontraseña.Text = dt.Rows[0]["Pass"].ToString();
                //txtcontraseña2.Text = dt.Rows[0]["Pass"].ToString();
                //checkAdmon.Checked = Convert.ToBoolean(dt.Rows[0]["Admon"]);
                //CheckEditar.Checked = Convert.ToBoolean(dt.Rows[0][5]);
                //CheckCobrar.Checked = Convert.ToBoolean(dt.Rows[0][6]);
                //CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);
                //txtDireccion.Text = dt.Rows[0][8].ToString();
                //txtTelefono.Text = dt.Rows[0][9].ToString();
                //txtComision.Text = Math.Round(Convert.ToDecimal(dt.Rows[0][4]), 2).ToString();
            }
        }

        private void Guardar()
        {

            try
            {


                if (txtObservaciones.Text == "")
                {
                    MessageBox.Show("Inserte una observación.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtObservaciones.Focus();
                    return;
                }

                Boolean Inserto = false;

                string fecha = FFecha.SelectionEnd.ToShortDateString() + " " + dHora.Value.ToShortTimeString();
                Inserto = new ClassGenerales().EjecutaQuery2("insert into citas (iCveProveedor,Fecha,Comentarios) values " +
                    " (" + ComboProveedor.SelectedValue.ToString() + ",'" + fecha + "','" + txtObservaciones.Text + "' )");



                if (Inserto == true)
                {
                    MessageBox.Show("La Cita se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La Cita no se registro correctamente verifique", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnConcretar_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaCierre();
        }

        private void CargaCierre()
        {


            string sInicial = fInicial.Value.ToShortDateString() + " " + HoraInicio.Value.ToShortTimeString().Replace("p. m.", "PM");
            string sFinal = fFinal.Value.ToShortDateString() + " " + HoraFin.Value.ToShortTimeString().Replace("p. m.", "PM");



            //string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            //string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT proveedor.cDesc as Proveedor, Citas.Fecha, Citas.Comentarios,   Switch(Concretada=1,'Si',Concretada=0,'No') AS Concretadas " +
" FROM Citas INNER JOIN proveedor ON Citas.iCveProveedor = proveedor.iCveProveedor ";

            Query += " where Citas.Fecha>=#" + sInicial.Replace("a. m.", "AM") + "# and Citas.Fecha<=#" + sFinal.Replace("a. m.", "AM") + "#";

            //Query += " where Citas.Fecha between #" + sInicial + "# and #" + sFinal + "# ";
            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);
            Datos.DataSource = dtDatos;
            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            Datos.Columns[0].Width = 200;
            Datos.Columns[1].Width = 200;
            Datos.Columns[2].Width = 200;
            Datos.Columns[3].Width = 100;
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            Guardar();
        }

        private void btnConcretar_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (GridDatos.SelectedCells.Count > 0)
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);
                    bool Inserto = new ClassGenerales().EjecutaQuery2("update citas set Concretada=1 where iCveCita=" + iCve);
                    CargaGrid();

                    if (Inserto == true)
                    {
                        MessageBox.Show("La Cita concreto correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Fallo al registrar.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult Resultado = MessageBox.Show("¿Desea eliminar la cita? ", "Cita", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Resultado == System.Windows.Forms.DialogResult.Yes)
                {
                }
                else
                {
                    return;
                }


                if (GridDatos.SelectedCells.Count > 0)
                {
                    var index = GridDatos.CurrentCell.RowIndex;
                    int iCve = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);
                    bool Inserto = new ClassGenerales().EjecutaQuery2("delete from citas where iCveCita=" + iCve);
                    CargaGrid();

                    if (Inserto == true)
                    {
                        MessageBox.Show("La Cita se elimino correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("La Cita no se elimino correctamente verifique", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            new ClassGenerales().ExportarExcel(Datos);
        }


    }
}
