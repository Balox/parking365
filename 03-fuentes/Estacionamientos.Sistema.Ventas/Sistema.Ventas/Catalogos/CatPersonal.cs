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
    public partial class CatPersonal : Form
    {
        public CatPersonal()
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
            dt = new ClassGenerales().EjecutaQuery("SELECT iCveUsuarios as Codigo, cNombre as Nombre, cUsuario as Usuario, " +
            " cPassword as Pass, bAdmon as Admon, bActivo as Activo,Ventas,        CierreCaja,        CitasProveedores, " +
        " Membresias,        Paquetes,        Inventario,        CuentasPagar,        CuentasCobrar, " +
        " Gastos,        CatClientes,        CatProductos,        CatPersonal,        CatUnidades, " +
        " CatCategorias,        CatProveedores,        CatNiveles,        Configuracion,        TiempoAire FROM USUARIOS");
            GridDatos.DataSource = dt;

            int Tamaño = 70;

            GridDatos.Columns["Ventas"].Width = Tamaño;
            GridDatos.Columns["CierreCaja"].Width = Tamaño;
            GridDatos.Columns["CitasProveedores"].Width = Tamaño;
            GridDatos.Columns["Membresias"].Width = Tamaño;
            GridDatos.Columns["Paquetes"].Width = Tamaño;
            GridDatos.Columns["Inventario"].Width = Tamaño;
            GridDatos.Columns["CuentasPagar"].Width = Tamaño;
            GridDatos.Columns["CuentasCobrar"].Width = Tamaño;
            GridDatos.Columns["Gastos"].Width = Tamaño;
            GridDatos.Columns["CatClientes"].Width = Tamaño;
            GridDatos.Columns["CatProductos"].Width = Tamaño;
            GridDatos.Columns["CatPersonal"].Width = Tamaño;
            GridDatos.Columns["CatUnidades"].Width = Tamaño;
            GridDatos.Columns["CatCategorias"].Width = Tamaño;
            GridDatos.Columns["CatProveedores"].Width = Tamaño;
            GridDatos.Columns["CatNiveles"].Width = Tamaño;
            GridDatos.Columns["Configuracion"].Width = Tamaño;
            GridDatos.Columns["TiempoAire"].Width = Tamaño;


            //for (int a = 0; a < dt.Rows.Count; a++)
            //{
            //    this.dataGridView2.Rows.Add(dt.Rows[a][0], dt.Rows[a][1], dt.Rows[a][2], dt.Rows[a][3], 
            //        dt.Rows[a][4].ToString()=="1"?"Si":"No", dt.Rows[a][5].ToString()=="1"?"Si":"No", dt.Rows[a][6].ToString()=="1"?"Si":"No",
            //        dt.Rows[a][7].ToString() == "1" ? "Si" : "No", dt.Rows[a][8], dt.Rows[a][9]);
            //}
        }



        private void LimpiaControles(string Valor)
        {
            txtNo.Text = Valor;
            txtNombre.Text = string.Empty;
            txtusuario.Text = string.Empty;
            txtcontraseña.Text = string.Empty;
            checkAdmon.Checked = false;
            CheckCobrar.Checked = false;
            CheckEditar.Checked = false;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtcontraseña2.Text = string.Empty;


            Ventas.Checked = false;
            CierreCaja.Checked = false;
            CitasProveedores.Checked = false;
            Membresias.Checked = false;
            Paquetes.Checked = false;
            Inventario.Checked = false;
            CuentasPagar.Checked = false;
            CuentasCobrar.Checked = false;
            Gastos.Checked = false;
            CatClientes.Checked = false;
            CatProductos.Checked = false;
            CatPersonal2.Checked = false;
            CatUnidades.Checked = false;
            CatCategorias.Checked = false;
            CatProveedores.Checked = false;
            CatNiveles.Checked = false;
            Configuracion.Checked = false;
            TiempoAire.Checked = false;

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
                    "cPassword as Pass, bAdmon as Admon, bActivo as Activo,Ventas,        CierreCaja,        CitasProveedores, " +
        " Membresias,        Paquetes,        Inventario,        CuentasPagar,        CuentasCobrar, " +
        " Gastos,        CatClientes,        CatProductos,        CatPersonal,        CatUnidades, " +
        " CatCategorias,        CatProveedores,        CatNiveles,        Configuracion,        TiempoAire FROM USUARIOS where iCveUsuarios=" + iCveUsuarios);

                txtNo.Text = dt.Rows[0]["Codigo"].ToString();
                txtNombre.Text = dt.Rows[0]["Nombre"].ToString();
                txtusuario.Text = dt.Rows[0]["Usuario"].ToString();
                txtcontraseña.Text = dt.Rows[0]["Pass"].ToString();
                txtcontraseña2.Text = dt.Rows[0]["Pass"].ToString();
                checkAdmon.Checked = Convert.ToBoolean(dt.Rows[0]["Admon"]);
                //CheckEditar.Checked = Convert.ToBoolean(dt.Rows[0][5]);
                //CheckCobrar.Checked = Convert.ToBoolean(dt.Rows[0][6]);
                CheckStatus.Checked = Convert.ToBoolean(dt.Rows[0]["Activo"]);
                //txtDireccion.Text = dt.Rows[0][8].ToString();
                //txtTelefono.Text = dt.Rows[0][9].ToString();
                //txtComision.Text = Math.Round(Convert.ToDecimal(dt.Rows[0][4]), 2).ToString();

                Ventas.Checked = Convert.ToBoolean(dt.Rows[0]["Ventas"]);
                CierreCaja.Checked = Convert.ToBoolean(dt.Rows[0]["CierreCaja"]);
                CitasProveedores.Checked = Convert.ToBoolean(dt.Rows[0]["CitasProveedores"]);
                Membresias.Checked = Convert.ToBoolean(dt.Rows[0]["Membresias"]);
                Paquetes.Checked = Convert.ToBoolean(dt.Rows[0]["Paquetes"]);
                Inventario.Checked = Convert.ToBoolean(dt.Rows[0]["Inventario"]);
                CuentasPagar.Checked = Convert.ToBoolean(dt.Rows[0]["CuentasPagar"]);
                CuentasCobrar.Checked = Convert.ToBoolean(dt.Rows[0]["CuentasCobrar"]);
                Gastos.Checked = Convert.ToBoolean(dt.Rows[0]["Gastos"]);
                CatClientes.Checked = Convert.ToBoolean(dt.Rows[0]["CatClientes"]);
                CatProductos.Checked = Convert.ToBoolean(dt.Rows[0]["CatProductos"]);
                CatPersonal2.Checked = Convert.ToBoolean(dt.Rows[0]["CatPersonal"]);
                CatUnidades.Checked = Convert.ToBoolean(dt.Rows[0]["CatUnidades"]);
                CatCategorias.Checked = Convert.ToBoolean(dt.Rows[0]["CatCategorias"]);
                CatProveedores.Checked = Convert.ToBoolean(dt.Rows[0]["CatProveedores"]);
                CatNiveles.Checked = Convert.ToBoolean(dt.Rows[0]["CatNiveles"]);
                Configuracion.Checked = Convert.ToBoolean(dt.Rows[0]["Configuracion"]);
                TiempoAire.Checked = Convert.ToBoolean(dt.Rows[0]["TiempoAire"]);

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

                if (txtusuario.Text == "")
                {
                    MessageBox.Show("Inserte un Usuario.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtusuario.Focus();
                    return;
                }


                if (txtcontraseña.TextLength >= 4)
                {
                    if (txtcontraseña.Text == txtcontraseña2.Text)
                    {
                        Boolean Inserto = false;
                        string Status = CheckStatus.Checked == true ? "1" : "0";
                        string Admon = checkAdmon.Checked == true ? "1" : "0";



                        string vVentas = Ventas.Checked == true ? "1" : "0";
                        string vCierreCaja = CierreCaja.Checked == true ? "1" : "0";
                        string vCitasProveedores = CitasProveedores.Checked == true ? "1" : "0";
                        string vMembresias = Membresias.Checked == true ? "1" : "0";
                        string vPaquetes = Paquetes.Checked == true ? "1" : "0";
                        string vInventario = Inventario.Checked == true ? "1" : "0";
                        string vCuentasPagar = CuentasPagar.Checked == true ? "1" : "0";
                        string vCuentasCobrar = CuentasCobrar.Checked == true ? "1" : "0";
                        string vGastos = Gastos.Checked == true ? "1" : "0";
                        string vCatClientes = CatClientes.Checked == true ? "1" : "0";
                        string vCatProductos = CatProductos.Checked == true ? "1" : "0";
                        string vCatPersonal2 = CatPersonal2.Checked == true ? "1" : "0";
                        string vCatUnidades = CatUnidades.Checked == true ? "1" : "0";
                        string vCatCategorias = CatCategorias.Checked == true ? "1" : "0";
                        string vCatProveedores = CatProveedores.Checked == true ? "1" : "0";
                        string vCatNiveles = CatNiveles.Checked == true ? "1" : "0";
                        string vConfiguracion = Configuracion.Checked == true ? "1" : "0";
                        string vTiempoAire = TiempoAire.Checked == true ? "1" : "0";





                        if (txtNo.Text == "Nuevo")
                        {//insert into USUARIOS (cNombre, cUsuario, cPassword, bAdmon, bActivo) values ('cNombre','cUsuario', 'cPassword', bAdmon, bActivo)

                            Inserto = new ClassGenerales().EjecutaQuery2("insert into USUARIOS " +
                                " (cNombre, cUsuario, cPassword, bAdmon, bActivo,Ventas,CierreCaja,CitasProveedores, " +
        " Membresias, Paquetes, Inventario,CuentasPagar, CuentasCobrar, " +
        " Gastos, CatClientes, CatProductos, CatPersonal,CatUnidades, " +
        " CatCategorias, CatProveedores, CatNiveles, Configuracion, TiempoAire) values " +
                                " ('" + txtNombre.Text + "','" + txtusuario.Text + "', '" + txtcontraseña.Text + "', " + Admon +
                                ", " + Status + "," + vVentas + " , " + vCierreCaja + " ," + vCitasProveedores + " , " +
        " " + vMembresias + " , " + vPaquetes + " , " + vInventario + " , " + vCuentasPagar + " , " + vCuentasCobrar + " , " +
        " " + vGastos + " , " + vCatClientes + " , " + vCatProductos + " , " + vCatPersonal2 + " ," + vCatUnidades + " , " +
        " " + vCatCategorias + " , " + vCatProveedores + " , " + vCatNiveles + " , " + vConfiguracion + " , " + vTiempoAire + " )");

                        }
                        else
                        {
                            var index = GridDatos.CurrentCell.RowIndex;
                            int iCveUsuarios = Convert.ToInt32(GridDatos.Rows[index].Cells[0].Value);


                            Inserto = new ClassGenerales().EjecutaQuery2("update USUARIOS set cNombre='" + txtNombre.Text + "', " +
                                "cUsuario='" + txtusuario.Text + "', cPassword='" + txtcontraseña.Text + "', bAdmon=" + Admon +
                                ", bActivo=" + Status + ",Ventas=" + vVentas + ",CierreCaja=" + vCierreCaja + ",CitasProveedores=" + vCitasProveedores + ", " +
        " Membresias=" + vMembresias + ",Paquetes=" + vPaquetes + ", Inventario=" + vInventario + ",CuentasPagar=" + vCuentasPagar + ",CuentasCobrar=" + vCuentasCobrar + ", " +
        " Gastos=" + vGastos + ",CatClientes=" + vCatClientes + ", CatProductos=" + vCatProductos + ", CatPersonal=" + vCatPersonal2 + ",CatUnidades=" + vCatUnidades + ", " +
        " CatCategorias=" + vCatCategorias + ", CatProveedores=" + vCatProveedores + ",CatNiveles=" + vCatNiveles + ",Configuracion=" + vConfiguracion + ", TiempoAire=" + vTiempoAire + " where iCveUsuarios=" + iCveUsuarios);
                        }

                        if (Inserto == true)
                        {
                            MessageBox.Show("El personal se registro correctamente", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Fallo el registro.", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        LimpiaControles(string.Empty);
                        CargaGrid();
                    }
                    else
                    {
                        MessageBox.Show("Debe validar la contraseña", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtcontraseña2.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña debe ser mayor o igual a 5 caracteres", Variables.NombreEmpresa, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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
