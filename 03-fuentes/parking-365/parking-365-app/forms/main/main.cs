using System;
using System.Windows.Forms;
using parking365.common;
using parking_365_app.util;

namespace parking_365_app.forms.main {
  public partial class main : Form {
   
    public main() {
      InitializeComponent();
    }

    private void main_Load(object sender,EventArgs e) {
      try {

        //button17.Visible = false;
        //panel1.Controls.Remove(button17);
        //panel1.Height = panel1.Height - 20;
        Constanst.USER_CURRENT = new parking365.domain.Usuario();
        Constanst.USER_CURRENT.idusuario = 1;

        btnmenuinicio_Click(null,e);
        btnmenuinicio.Focus();

      } catch (Exception ex) {
        MessageBox.Show(ex.Message,Global.NAME_MODULE,MessageBoxButtons.OK,MessageBoxIcon.Error);
      } finally {
        GC.Collect();
      }
    }

    // ** HEADER ** //
    #region Header

    private void pbSalir_MouseClick(object sender,MouseEventArgs e) {
      if(e.Button == MouseButtons.Left)
        salir();
    }

    private void pbMenu_MouseClick(object sender,MouseEventArgs e) {
      if(e.Button == MouseButtons.Left)
        openMenu();
    }

    private void lblLogo_MouseClick(object sender,MouseEventArgs e) {
      if(e.Button == MouseButtons.Left)
        home();
    }

    private void pbLogo_MouseClick(object sender,MouseEventArgs e) {
      if(e.Button == MouseButtons.Left)
        home();
    }

    // ** Metodos ** // 

    private void salir() {
      if(MessageBox.Show("¿Desea salir del sistema PARKING-365?",Global.NAME_MODULE,MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
        Application.Exit();
    }

    private void openMenu() {

    }

    private void home() {

    }




    #endregion

    // ** MENU ** //
    #region Menu

    private void closeMenu_MouseClick(object sender,MouseEventArgs e) {
      if(e.Button == MouseButtons.Left)
        closeMenu();
    }
    
    private void closeMenu() {

    }

    // menus
    private void btnmenuinicio_Click(object sender,EventArgs e) {
      this.openForm(new dashboard.inicio());
    }

    private void btnmenuadmin_Click(object sender,EventArgs e) {
      this.btnsubusuarios_Click(null,e);
    }

    private void btnmenusalida_Click(object sender,EventArgs e) {
      this.btnsubsalida_Click(null,e);
    }

    private void btnmenuentrada_Click(object sender,EventArgs e) {
      this.btnsubentradas_Click(null,e);
    }

    private void btnmenucaja_Click(object sender,EventArgs e) {
      this.btnsubdiario_Click(null,e);
    }

    // submenus
    private void btnsubusuarios_Click(object sender,EventArgs e) {
      this.openForm(administracion.usuarios.Instance);
    }

    private void btnsubclientes_Click(object sender,EventArgs e) {
      this.openForm(administracion.clientes.Instance);
    }

    private void btnsubmodulos_Click(object sender,EventArgs e) {
      this.openForm(new administracion.modulos());
    }

    private void btnsubparametros_Click(object sender,EventArgs e) {
      this.openForm(new administracion.parametros());
    }

    private void btnsubvehiculos_Click(object sender,EventArgs e) {
      this.openForm(new administracion.vehiculos());
    }

    private void btnsubtarifas_Click(object sender,EventArgs e) {
      this.openForm(new administracion.tarifas());
    }

    private void btnsubsalida_Click(object sender,EventArgs e) {
      this.openForm(new salidas.listado());
    }

    private void btnsubentradas_Click(object sender,EventArgs e) {
      this.openForm(new entradas.listado());
    }

    private void btnsubdiario_Click(object sender,EventArgs e) {
      this.openForm(new caja.diario());
    }

    private void btnsubhistorico_Click(object sender,EventArgs e) {
      this.openForm(new caja.historico());
    }

    #endregion
    
    private void openForm(object sender) {
      if(this.pContenedor.Controls.Count > 0)
        this.pContenedor.Controls.RemoveAt(0);

      Form form = sender as Form;
      form.TopLevel = false;
      form.Dock = DockStyle.Fill;

      this.pContenedor.Controls.Add(form);
      this.pContenedor.Tag = form;

      form.Show();
    }

  }
}
