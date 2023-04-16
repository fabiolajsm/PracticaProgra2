using Saludo;
using System.Text;

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
            string materia = this.Cb_Materia.Text;

            if (Validar(nombre, apellido))
            {
                string nombreCompleto = $"{nombre} {apellido}";
                FormSaludar saludar = new FormSaludar(nombreCompleto, materia);
                saludar.Show();
                this.Hide();
            }
        }

        private bool Validar(string nombre, string apellido)
        {
            bool esValido = true;
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Se deben completar los siguientes campos:");
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre y Apellido");
            }
            else if (string.IsNullOrWhiteSpace(nombre))
            {
                esValido = false;
                stringBuilder.AppendLine("Nombre");
            }
            else if (string.IsNullOrWhiteSpace(apellido))
            {
                esValido = false;
                stringBuilder.AppendLine("Apellido");
            }

            if (!esValido)
            {
                MessageBox.Show(stringBuilder.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return esValido;
        }
    }
}