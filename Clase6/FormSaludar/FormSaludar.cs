namespace Saludo
{
    public partial class FormSaludar : Form
    {
        public FormSaludar()
        {
            InitializeComponent();
        }
        public FormSaludar(string nombreCompleto, string materia) : this()
        {
            Label_Descripcion.Text = $"Soy {nombreCompleto} y mi materia favorita es {materia}.";
        }
    }
}