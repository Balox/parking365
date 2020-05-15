using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using parking365.common;
using parking365.service;
using parking365.domain;
using parking_365_app.util;


namespace parking_365_app.forms.administracion {
  public sealed partial class clientes : Form {

    #region Singleton
    private static volatile clientes instance = null;
    private static object syncRoot = new Object();
    public static clientes Instance {
      get {
        if(instance == null) {
          lock(syncRoot) {
            if(instance == null)
              instance = new clientes();
          }
        }

        return instance;
      }
    }
    #endregion

    private ConfigurationService service = new ConfigurationService();
    private mttocliente form;


    public clientes() {
      InitializeComponent();
    }

    private void btnsearch_Click(object sender,EventArgs e) {
      buscarCliente(txtdocumento.Text.Trim());
    }

    private void btnnew_Click(object sender,EventArgs e) {
      try {
        using(mttocliente form = new mttocliente()) {
          form.New = true;
          
          if(form.ShowDialog() == DialogResult.OK) {
            buscarCliente(string.Empty);
          }
        }

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private void btnedit_Click(object sender,EventArgs e) {
      try {

        using(mttocliente form = new mttocliente()) {
          form.New = false;
          form.cliente = this.obtenerCliente();

          if(form.ShowDialog() == DialogResult.OK) {
            buscarCliente(string.Empty);
          }
        }
        
      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private void btndelete_Click(object sender,EventArgs e) {
      try {
        using(security.eliminar feliminar = new security.eliminar()) {
          Cliente c = this.obtenerCliente();
          feliminar.TextoE = c.nombre;

          if(feliminar.ShowDialog() == DialogResult.OK) {
            this.Cursor = Cursors.WaitCursor;
            if(service.clienteService().eliminar(c.idcliente,Constanst.USER_CURRENT.idusuario)) {
              this.buscarCliente("");

              MessageBox.Show("Se elimino el cliente correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else {
              MessageBox.Show("No se ha podido eliminar el cliente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

          }
        }

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        this.Cursor = Cursors.Default;
        GC.Collect();
      }
    }

    private void btnClean_Click(object sender,EventArgs e) {
      this.clean();
    }

    private void clientes_Load(object sender,EventArgs e) {
      this.clean();
    }

    private void clean() {
      try {

        if(this.dgclientes.Rows.Count > 0) {
          this.dgclientes.DataSource = new List<Cliente>();
          this.lblresultado.Text = "Número de registros encontrados: 0.";
          this.dgclientes.Refresh();
        }

        this.btnedit.Enabled = false;
        this.btndelete.Enabled = false;
        txtdocumento.Clear();
        txtdocumento.Focus();

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private Cliente obtenerCliente() {
      DataGridViewRow selectedRow = this.dgclientes.Rows[this.dgclientes.CurrentCell.RowIndex];

      return new Cliente(
          Convert.ToInt64(selectedRow.Cells["idcliente"].Value),
          Convert.ToInt32(selectedRow.Cells["idtipocliente"].Value),
          Convert.ToInt32(selectedRow.Cells["idtipodocumento"].Value),
          Convert.ToString(selectedRow.Cells["documento"].Value),
          Convert.ToString(selectedRow.Cells["nombre"].Value),
          Convert.ToString(selectedRow.Cells["representante"].Value),
          Convert.ToString(selectedRow.Cells["telefono"].Value),
          Convert.ToString(selectedRow.Cells["email"].Value),
          Convert.ToString(selectedRow.Cells["observacion"].Value),
          Convert.ToInt32(selectedRow.Cells["idusuariocrea"].Value)
        );
    }

    private void buscarCliente(string texto) {
      try {
        this.Cursor = Cursors.WaitCursor;

        this.dgclientes.DataSource = service.clienteService().listar(texto);
        this.lblresultado.Text = string.Format("Número de registros encontrados: {0}.",this.dgclientes.Rows.Count);
        this.btnedit.Enabled = (this.dgclientes.Rows.Count > 0) ? true : false;
        this.btndelete.Enabled = (this.dgclientes.Rows.Count > 0) ? true : false;

        this.dgclientes.Refresh();

        this.Cursor = Cursors.Default;
      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }
  }
}
