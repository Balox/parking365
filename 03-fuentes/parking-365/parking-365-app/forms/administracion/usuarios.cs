using System;
using System.Data;
using System.Windows.Forms;
using parking_365_app.util;
using parking365.service;
using parking365.common;
using parking365.domain;


namespace parking_365_app.forms.administracion {
  public sealed partial class usuarios : Form {

    #region Singleton
    private static volatile usuarios instance = null;
    private static object syncRoot = new Object();
    public static usuarios Instance {
      get {
        if(instance == null) {
          lock(syncRoot) {
            if(instance == null)
              instance = new usuarios();
          }
        }

        return instance;
      }
    }
    #endregion

    private ConfigurationService service = new ConfigurationService();
    private int _index = -1;
    private int _idusario = 0;
    private bool _new = false;
    
    public usuarios() {
      InitializeComponent();      
    }

    private void btnnew_Click(object sender,EventArgs e) {
      dgusuarios.Enabled = false;
      btnedit.Enabled = false;
      btndelete.Enabled = false;
      btnnew.Enabled = false;

      pdatos.Enabled = true;
      btnsave.Enabled = true;
      btncancel.Enabled = true;
      cboperfil.SelectedIndex = 0;
      txtnombre.Clear();
      txtemail.Clear();
      txttelefono.Clear();
      txtusuario.Clear();
      txtclave.Clear();
      txtconfirmacion.Clear();
      this._new = true;
      cboperfil.Focus();
    }

    private void btnedit_Click(object sender,EventArgs e) {
      dgusuarios.Enabled = false;
      btnedit.Enabled = false;
      btndelete.Enabled = false;
      btnnew.Enabled = false;

      pdatos.Enabled = true;
      btnsave.Enabled = true;
      btncancel.Enabled = true;
      
      this._new = false;
      cboperfil.Focus();
    }

    private void btnsave_Click(object sender,EventArgs e) {
      try {
        this.Cursor = Cursors.WaitCursor;

        // validar 
        if(this.cboperfil.SelectedIndex == 0) {
          MessageBox.Show("Debe seleccionar un perfil.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.cboperfil.Focus();
          return;
        }

        if(this.txtnombre.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar un nombre.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtnombre.Focus();
          return;
        }

        if(this.txtusuario.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar un usuario.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtusuario.Focus();
          return;
        }

        if(this.txtclave.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar una clave.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtclave.Focus();
          return;
        }

        if(this.txtconfirmacion.Text.Trim().Length == 0) {
          MessageBox.Show("Debe ingresar confirmación clave.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtconfirmacion.Focus();
          return;
        }

        if(!this.txtclave.Text.Trim().Equals(this.txtconfirmacion.Text.Trim())) {
          MessageBox.Show("Las claves deben coincidir.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          this.txtconfirmacion.Focus();
          return;
        }

        if (this._new) {
          if (service.usuarioService().insertar(
              new Usuario(
                Convert.ToInt32(this.cboperfil.SelectedValue),
                this.txtnombre.Text.Trim(),
                this.txtemail.Text.Trim(),
                this.txttelefono.Text.Trim(),
                this.txtusuario.Text.Trim(),
                this.txtclave.Text.Trim(),
                Constanst.USER_CURRENT.idusuario)
            )) {
            this._new = false;
            this._index = -1;
            this.dgusuarios.DataSource = service.usuarioService().listar("");
            this.seleccionarUsuario(0);

            pdatos.Enabled = false;
            btnsave.Enabled = false;
            btncancel.Enabled = false;

            dgusuarios.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnnew.Enabled = true;
            this.dgusuarios.Refresh();
            dgusuarios.Focus();
            MessageBox.Show("Se guardaron los datos correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
          } else {
            MessageBox.Show("No se ha podido ingresar los datos",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          }          
        } else {
          if (service.usuarioService().actualizar(
              new Usuario(
                this._idusario,
                Convert.ToInt32(this.cboperfil.SelectedValue),
                this.txtnombre.Text.Trim(),
                this.txtemail.Text.Trim(),
                this.txttelefono.Text.Trim(),
                this.txtusuario.Text.Trim(),
                this.txtclave.Text.Trim(),
                Constanst.USER_CURRENT.idusuario),
              Convert.ToString(txtemail.Tag),
              Convert.ToString(txtusuario.Tag)
            )) {
            this._new = false;
            this._index = -1;
            this.dgusuarios.DataSource = service.usuarioService().listar("");
            this.seleccionarUsuario(0);

            pdatos.Enabled = false;
            btnsave.Enabled = false;
            btncancel.Enabled = false;

            dgusuarios.Enabled = true;
            btnedit.Enabled = true;
            btndelete.Enabled = true;
            btnnew.Enabled = true;
            this.dgusuarios.Refresh();
            dgusuarios.Focus();
            MessageBox.Show("Se actualizo correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
          } else {
            MessageBox.Show("No se ha podido actualizar los datos",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
          }
        }
      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        this.Cursor = Cursors.Default;
        GC.Collect();
      }
    }

    private void btndelete_Click(object sender,EventArgs e) {
      try {
        using(security.eliminar feliminar = new  security.eliminar()) {
          feliminar.TextoE = this.txtusuario.Text.Trim();
          
          if (feliminar.ShowDialog() == DialogResult.OK) {
            this.Cursor = Cursors.WaitCursor;
            if (service.usuarioService().eliminar(this._idusario, Constanst.USER_CURRENT.idusuario)) {
              this._new = false;
              this._index = -1;
              this.dgusuarios.DataSource = service.usuarioService().listar("");
              this.seleccionarUsuario(0);
              this.dgusuarios.Refresh();
              dgusuarios.Focus();
              MessageBox.Show("Se elimino el usuario correctamente.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Information);
            } else {
              MessageBox.Show("No se ha podido eliminar el usuario.",Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Warning);
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

    private void btncancel_Click(object sender,EventArgs e) {
      pdatos.Enabled = false;
      btnsave.Enabled = false;
      btncancel.Enabled = false;
      this._new = false;
      this._index = -1;

      dgusuarios.Enabled = true;
      btnedit.Enabled = true;
      btndelete.Enabled = true;
      btnnew.Enabled = true;

      this.dgusuarios.FirstDisplayedScrollingRowIndex = 0;
      this.dgusuarios.Refresh();
      this.dgusuarios.Rows[0].Selected = true;
      this.seleccionarUsuario(0);
      dgusuarios.Focus();
    }

    private void usuarios_Load(object sender,EventArgs e) {
      try {
        this.Cursor = Cursors.WaitCursor;
        this.dgusuarios.DataSource = service.usuarioService().listar("");
        this.cboperfil.DataSource = service.usuarioService().listarPerfiles();
        this.cboperfil.DisplayMember = "perfil";
        this.cboperfil.ValueMember = "idperfil";

        this.seleccionarUsuario(0);
        this.Cursor = Cursors.Default;
      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    private void dgusuarios_CellClick(object sender,DataGridViewCellEventArgs e) {      
      this.seleccionarUsuario(e.RowIndex);
    }

    private void seleccionarUsuario(int index) {
      try {
        if (this._index == index) 
          return;

        this._index = index;
        DataGridViewRow selectedRow = this.dgusuarios.Rows[index];
        this._idusario = Convert.ToInt32(selectedRow.Cells["idusuario"].Value);
        this.cboperfil.SelectedValue = Convert.ToInt32(selectedRow.Cells["idperfil"].Value);
        this.txtnombre.Text = Convert.ToString(selectedRow.Cells["nombrecompleto"].Value);
        this.txtemail.Text = Convert.ToString(selectedRow.Cells["email"].Value);
        this.txtemail.Tag = Convert.ToString(selectedRow.Cells["email"].Value);
        this.txttelefono.Text = Convert.ToString(selectedRow.Cells["telefono"].Value);
        this.txtusuario.Text = Convert.ToString(selectedRow.Cells["usuario"].Value);
        this.txtusuario.Tag = Convert.ToString(selectedRow.Cells["usuario"].Value);
        this.txtclave.Text = Convert.ToString(selectedRow.Cells["clave"].Value);
        this.txtconfirmacion.Text = Convert.ToString(selectedRow.Cells["clave"].Value);

      } catch(Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }
  }
}
