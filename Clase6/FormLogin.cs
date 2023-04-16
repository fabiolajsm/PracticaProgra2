using HomePage;

namespace Clase6
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void cb_mostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_mostrarContrasena.Checked)
            {
                tb_contrasena.PasswordChar = '\0'; // Mostrar 
            } else
            {
                tb_contrasena.PasswordChar = '*'; // Ocultar
            }

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string usuarioIngresado = this.tb_usuario.Text;
            string contrasenaIngresada = this.tb_contrasena.Text;
            if (string.IsNullOrEmpty(usuarioIngresado) && string.IsNullOrEmpty(contrasenaIngresada)) MessageBox.Show("Error. Debe ingresar usuario y contraseña."); 
            else if (string.IsNullOrEmpty(usuarioIngresado)) MessageBox.Show("Error. Debe ingresar un usuario");
            else if (string.IsNullOrEmpty(contrasenaIngresada)) MessageBox.Show("Error. Debe ingresar una contraseña");
            else if (usuarioIngresado == "fabiolajsm" && contrasenaIngresada == "1234")
            {
                FormHome home = new FormHome(usuarioIngresado);
                this.Hide();
                home.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña inválidos.");
            }
        }
    }
}