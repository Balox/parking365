
namespace parking._365.app.common {
  public class FormBase {
    
    internal static void Initialize(System.Windows.Forms.Form form) {
      form.Font = new System.Drawing.Font("Segoe UI",8.25F);
      form.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      form.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      form.Text = ".:Bienvenida:.";
    }
  }
}
