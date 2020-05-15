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
    public partial class Gastos : Form, iFormCargaCatalogoGastos
    {
        public Gastos()
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
        {//SELECT iCveGasto , cDesc , bActivo as Activo  FROM CatGastos where bActivo=1
            CargaGastos();
        }


        public void CargaGastos()
        {
            DataTable dtDatos = new ClassGenerales().EjecutaQuery("select 'TODOS' AS cDesc, '-1' as iCveGasto from configuracion union select   cDesc,iCveGasto   FROM CatGastos where bActivo=1  order by 1");
            ComboGasto.DataSource = dtDatos;
            ComboGasto.DisplayMember = "cDesc";
            ComboGasto.ValueMember = "iCveGasto";
            ComboGasto.SelectedValue = "-1";

            ComboGasto2.DataSource = dtDatos;
            ComboGasto2.DisplayMember = "cDesc";
            ComboGasto2.ValueMember = "iCveGasto";
            ComboGasto2.SelectedValue = "-1";
        }

        private void btnCatalogo_Click(object sender, EventArgs e)
        {

            if (ValidaFormularioAbierto("CatGastos") == true)
            {
                Form abierto = ValidaFormularioAbiertoForm("CatGastos");
                abierto.WindowState = FormWindowState.Normal;
                abierto.Focus();
            }
            else
            {
                CatGastos form3 = new CatGastos();
                form3.MdiParent = MDIMenu.ActiveForm;
                form3.Show();
            }
        }


        private Form ValidaFormularioAbiertoForm(string Form)
        {
            Form instForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == Form).SingleOrDefault();
            return instForm;
        }


        private Boolean ValidaFormularioAbierto(string Form)
        {
            Form instForm = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == Form).SingleOrDefault();

            if (instForm != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CargaCierre();
        }


        private void CargaCierre()
        {


            string sInicial = fInicial.Value.ToString("MM/dd/yyyy");
            string sFinal = fFinal.Value.AddDays(1).ToString("MM/dd/yyyy");

            string Query = "SELECT cDesc as Gasto, Gasto as Importe, FechaGasto, Comentario FROM Gastos g " +
            " INNER JOIN CatGastos cg ON g.iCveGasto = cg.iCveGasto ";

            Query += " where FechaGasto between #" + sInicial + "# and #" + sFinal + "# ";
                if (ComboGasto.SelectedValue.ToString() != "-1")
                {
                    Query += " and g.iCveGasto=" + ComboGasto.SelectedValue.ToString();
                }

            
            DataTable dtDatos = new ClassGenerales().EjecutaQuery(Query);

            Datos.DataSource = dtDatos;

            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid);
            Datos.Columns[0].Width = 165;
            Datos.Columns[1].Width = 70;
            Datos.Columns[2].Width = 165;
            Datos.Columns[3].Width = 200;

            Double Gasto = 0;

            for (int i = 0; i < dtDatos.Rows.Count; i++)
            {
                Gasto += Convert.ToDouble(dtDatos.Rows[i]["Importe"]);
            }


            txtTotal.Text = String.Format("{0:0,0.00}", Gasto);

        }

        private void btnAbonar_Click(object sender, EventArgs e)
        {
            try
            {
                Boolean Inserto = false;


                Double Abono = txtAbono.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtAbono.Text) == true ? Convert.ToDouble(txtAbono.Text) : 0;


                if (ComboGasto2.SelectedValue.ToString() == "-1")
                {
                    MessageBox.Show("Seleccione un gastos distinto a TODOS.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    ComboGasto2.Focus();
                    return;
                }

                if (Abono == 0)
                {
                    MessageBox.Show("El abono debe ser distinto de 0 (cero).", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtAbono.Focus();
                    return;
                }


                Inserto = new ClassGenerales().EjecutaQuery2("insert into Gastos " +
                    " ( iCveGasto, Gasto, FechaGasto,Comentario)   values " +
                    " ( " + ComboGasto2.SelectedValue + "," + Abono + ", '" + FechaAbono.Value + "', '" + txtComentario.Text.Trim().ToUpper() + "')");

                if (Inserto == true)
                {
                    MessageBox.Show("Registro correctamente.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAbono.Text = "";
                    txtComentario.Text = "";

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
 

    }
}
