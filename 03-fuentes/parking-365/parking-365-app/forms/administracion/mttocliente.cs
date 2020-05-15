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
  public partial class mttocliente : Form {

    private ConfigurationService service = new ConfigurationService();

    public bool New { get; set; }
    public Cliente cliente = new Cliente();
   
    public mttocliente() {
      InitializeComponent();
    }

    private void mttocliente_Load(object sender,EventArgs e) {
      try {
        this.cleanFields();

        if (this.New) {
          rbNatural.Enabled = true;
          rbjuridica.Enabled = true;
          lblTitulo.Text = "Nuevo Cliente     ";
        } else {
          rbNatural.Checked = (this.cliente.idtipocliente == (int)Global.TIPO_CLIENTE.NATURAL);
          txtdocumento.Text = this.cliente.documento;
          txtnombre.Text = this.cliente.nombre;
          txtrepresentante.Text = this.cliente.representante;
          txttelefono.Text = this.cliente.telefono;
          txtemail.Text = this.cliente.email;
          txtobservacion.Text = this.cliente.observacion;

          lblTitulo.Text = "Editar Cliente     ";
          rbNatural.Enabled = false;
          rbjuridica.Enabled = false;
        }

        label2.Text = "Nombre";
        txtrepresentante.Enabled = false;
        txtdocumento.Focus();

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private void rbNatural_CheckedChanged(object sender,EventArgs e) {
      if (rbNatural.Checked) {
        label2.Text = "Nombre";
        txtrepresentante.Clear();
      } else {
        label2.Text = "Razon social";
      }

      txtrepresentante.Enabled = !rbNatural.Checked;
    }

    private void btnsave_Click(object sender,EventArgs e) {
      try {

        if(this.txtdocumento.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar número de documento.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtnombre.Focus();
          return;
        }

        if(this.txtnombre.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar un nombre.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtnombre.Focus();
          return;
        }

        // cargar los datos ingresados o modificados
        this.cliente.idtipocliente = (rbNatural.Checked) ? (int)Global.TIPO_CLIENTE.NATURAL : (int)Global.TIPO_CLIENTE.JURIDICA;
        this.cliente.idtipodocumento = (rbNatural.Checked) ? (int)Global.TIPO_DOCUMENTO.DNI : (int)Global.TIPO_DOCUMENTO.RUC;
        this.cliente.documento = txtdocumento.Text.Trim();
        this.cliente.nombre = txtnombre.Text.Trim();
        this.cliente.representante = (txtrepresentante.Text.Trim().Length == 0) ? null : txtrepresentante.Text.Trim();
        this.cliente.telefono = (txttelefono.Text.Trim().Length == 0) ? null : txttelefono.Text.Trim();
        this.cliente.email = (txtemail.Text.Trim().Length == 0) ? null : txtemail.Text.Trim();
        this.cliente.observacion = (txtobservacion.Text.Trim().Length == 0) ? null : txtobservacion.Text.Trim();
        this.cliente.idusuariocrea = Constanst.USER_CURRENT.idusuario;
                
        if (this.New) {
          if (service.clienteService().insertar(this.cliente)) {
            MessageBox.Show("Se guardaron los datos correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
          } else {
            MessageBox.Show("No se ha podido ingresar los datos",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            txtdocumento.SelectAll();
            txtdocumento.Focus();
          }
        } else {
          if(service.clienteService().actualizar(this.cliente)) {
            MessageBox.Show("Se actualizo correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
          } else {
            MessageBox.Show("No se ha podido actualizar los datos",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
            txtdocumento.SelectAll();
            txtdocumento.Focus();
          }
        }

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private void btncancel_Click(object sender,EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.Close();
    }

    private void mttocliente_KeyDown(object sender,KeyEventArgs e) {
      if(e.KeyCode == Keys.Escape)
        this.Close();
    }

    private void cleanFields() {
      txtdocumento.Clear();
      txtnombre.Clear();
      txtrepresentante.Clear();
      txttelefono.Clear();
      txtemail.Clear();
      txtobservacion.Clear();
    }
  }
}
