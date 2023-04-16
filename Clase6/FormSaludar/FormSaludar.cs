namespace Saludo
{
    public partial class FormSaludar : Form
    {
        public FormSaludar()
        {
            InitializeComponent();
        }
        public FormSaludar(string nombreCompleto) : this()
        {
            Label_Descripcion.Text = $"Soy {nombreCompleto}.";
        }
    }
}