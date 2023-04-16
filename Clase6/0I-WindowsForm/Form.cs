using Saludo;

namespace _0I_WindowsForm
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void Btn_Saludar_Click(object sender, EventArgs e)
        {
            string nombre = this.Tb_Nombre.Text;
            string apellido = this.Tb_Apellido.Text;
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido)) MessageBox.Show("Error. Debe ingresar nombre y apellido.");
            else if (string.IsNullOrEmpty(nombre)) MessageBox.Show("Error. Debe ingresar un nombre");
            else if (string.IsNullOrEmpty(apellido)) MessageBox.Show("Error. Debe ingresar un apellido");
            else
            {
                string nombreCompleto = $"{nombre} {apellido}";
                FormSaludar saludar = new FormSaludar(nombreCompleto);
                saludar.Show();
                this.Hide();
            }
        }
    }
}