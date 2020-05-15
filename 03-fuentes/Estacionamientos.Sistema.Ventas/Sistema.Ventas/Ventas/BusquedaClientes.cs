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
    public partial class BusquedaClientes : Form
    {
        public BusquedaClientes()
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
            this.Datos.DefaultCellStyle.Font = new Font("Arial", Variables.TamañoGrid );
            Datos.Columns[0].Width = 170;
            Datos.Columns[1].Width = 170;
            Datos.Columns[2].Width = 170;
            Datos.Columns[3].Visible = false;
        }





        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
            BuscaCliente();
        }

        private void BusquedaClientes_Load(object sender, EventArgs e)
        {
            BuscaCliente();
            txtNombre.Focus();
            txtNombre.Select();
        }

        private void BuscaCliente()
        {
            const string quote = "\"";
            DataTable dtDatos = new ClassGenerales().EjecutaQuery("SELECT cliente.NOMBRE as Nombre, cliente.TELEFONO as Telefono, cliente.EMAIL as Email, cliente.NUMEROCLIENTE " +
" FROM cliente where cliente.NOMBRE  like " + quote + "%" +txtNombre.Text.Trim() + "%" + quote + "");
            Datos.DataSource = dtDatos;
            EstilosGrid();
        }

        private void Datos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Datos.SelectedCells.Count > 0)
            {
                var index = Datos.CurrentCell.RowIndex;
                string iCve = Datos.Rows[index].Cells[3].Value.ToString().Trim();

                iFormClientes formInterface = Application.OpenForms.OfType<Form>().Where(pre => pre.Name == "Ventas").SingleOrDefault() as iFormClientes;
                if (formInterface != null)
                    formInterface.SeleccionaCliente(Convert.ToInt32(iCve));
                this.Close();
            }
        }




    }
}
