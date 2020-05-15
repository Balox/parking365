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
    public partial class GastosAuxiliar : Form, iFormCargaCatalogoGastos
    {
        public GastosAuxiliar()
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
            txtAbono.Text = Variables.GastoImporte;
            txtComentario.Text = Variables.GastoComentario;
        }


        public void CargaGastos()
        {
            DataTable dtDatos = new ClassGenerales().EjecutaQuery(" select   cDesc,iCveGasto   FROM CatGastos where bActivo=1  order by 1");
            ComboGasto2.DataSource = dtDatos;
            ComboGasto2.DisplayMember = "cDesc";
            ComboGasto2.ValueMember = "iCveGasto";
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
                //form3.MdiParent = MDIMenu.ActiveForm;
                form3.ShowDialog();
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
                    this.Close();
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
 

    }
}
