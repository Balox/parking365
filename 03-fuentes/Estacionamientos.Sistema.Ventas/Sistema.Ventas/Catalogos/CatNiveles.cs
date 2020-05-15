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
    public partial class CatNiveles : Form
    {
        public CatNiveles()
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

            ComboNiveles.DataSource = new ClassGenerales().EjecutaQuery("select 'Nivel 1' as Texto,1 as Valor from configuracion union " +
                " select 'Nivel 2' as Texto,2 as Valor from configuracion union " +
                " select 'Nivel 3' as Texto,3 as Valor from configuracion union " +
                " select 'Nivel 4' as Texto,4 as Valor from configuracion union " +
                 " select 'Nivel 5' as Texto,5 as Valor from configuracion union " +
                  " select 'Nivel 6' as Texto,6 as Valor from configuracion union " +
                   " select 'Nivel 7' as Texto,7 as Valor from configuracion union " +
                    " select 'Nivel 8' as Texto,8 as Valor from configuracion union " +
                     " select 'Nivel 9' as Texto,9 as Valor from configuracion union " +
                " select 'Nivel 10' as Texto,10 as Valor from configuracion order by 2");
            ComboNiveles.DisplayMember = "Texto";
            ComboNiveles.ValueMember = "Valor";
            ComboNiveles.SelectedIndex = 0;

            CargaGrid();

        }


 

        private void CargaGrid()
        {
            DataTable dt = new DataTable();
            dt = new ClassGenerales().EjecutaQuery("SELECT Niveles.IdNivel, Niveles.Nivel, Niveles.NoServicios " +
"FROM Niveles  where Nivel=" + ComboNiveles.SelectedValue);
            txtNoServicios.Text = "0";
            if (dt.Rows.Count>0)
            {
                txtNoServicios.Text = dt.Rows[0]["NoServicios"].ToString();    
            }
            
        }






        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        
        }

        private void GridDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void ComboNiveles_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                      CargaGrid();
            }
            catch (Exception)
            {
                
                
            }
        }

        private void btnAgregar_Click_1(object sender, EventArgs e)
        {
            try
            {

                Double NoServicios = txtNoServicios.Text == string.Empty ? 0 : ClassGenerales.IsNumericDouble(txtNoServicios.Text) == true ? Convert.ToDouble(txtNoServicios.Text) : 0;
                Boolean Inserto = false;
                Inserto = new ClassGenerales().EjecutaQuery2("update Niveles set NoServicios= " + NoServicios + " where Nivel = " + ComboNiveles.SelectedValue);

                if (Inserto == true)
                {
                    MessageBox.Show("Se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Fallo el registro verifique todos los datos.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                CargaGrid();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }


    }
}
