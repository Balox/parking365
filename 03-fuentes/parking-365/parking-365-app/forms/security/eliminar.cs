using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parking_365_app.forms.security {
  public partial class eliminar : Form {
    
    public string TextoE;

    public eliminar() {
      InitializeComponent();
    }

    private void btnConfirmar_Click(object sender,EventArgs e) {
      if (txteliminar.Text.Equals(this.TextoE)) {
        this.DialogResult = DialogResult.OK;
        this.TextoE = string.Empty;
        this.Close();
      }
    }

    private void btnCancelar_Click(object sender,EventArgs e) {
      this.DialogResult = DialogResult.Cancel;
      this.TextoE = string.Empty;
      this.Close();
    }

    private void eliminar_Load(object sender,EventArgs e) {
      lbltexto1.Text = String.Format("Vas a eliminar {0}. \n\r¡El registro eliminado NO PUEDE ser restaurado! ¿Está usted ABSOLUTAMENTE seguro ?", this.TextoE);
      lbltextoeliminar.Text = this.TextoE;
    }

    private void eliminar_KeyDown(object sender,KeyEventArgs e) {
      if(e.KeyCode == Keys.Escape)
        this.Close();
    }

    private void txteliminar_TextChanged(object sender,EventArgs e) {
      btnConfirmar.Enabled = (txteliminar.Text.Equals(this.TextoE)) ? true : false;
    }
  }
}
