using System.ComponentModel;
using System.Text;

namespace I02_Registrate
{
    public partial class FormIngresante : Form
    {
        public string[] cursos;
        public string direccion;
        public int edad;
        public string genero;
        public string nombre;
        public string pais;
        public FormIngresante()
        {
            InitializeComponent();
            this.nombre = string.Empty;
            this.direccion = string.Empty;
            this.edad = 0;
            this.pais = string.Empty;
            this.genero = string.Empty;
            this.cursos = System.Array.Empty<string>();
        }

        public FormIngresante(string[] cursos, string direccion, int edad, string genero, string nombre, string pais) : this()
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.edad = edad;
            this.pais = pais;
            this.genero = genero;
            this.cursos = cursos;
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {

            string nombre = Tb_Nombre.Text;
            string direccion = Tb_Direccion.Text;
            int edad = (int)NumericUpDown_Edad.Value;
            string pais = Lb_Pais.Text;
            RadioButton? radioButtonSeleccionado = null;

            foreach (RadioButton radioButton in Gb_Genero.Controls.OfType<RadioButton>())
            {
                if (radioButton.Checked)
                {
                    radioButtonSeleccionado = radioButton;
                    break;
                }
            }
            string genero = radioButtonSeleccionado.Text;

            List<string> cursosSeleccionados = new List<string>();
            foreach (Control control in Gb_Cursos.Controls)
            {
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    cursosSeleccionados.Add(control.Text);
                }
            }

            FormIngresante formIngresante = new FormIngresante(cursosSeleccionados.ToArray(), direccion, edad, genero , nombre, pais);
            Mostrar(formIngresante);

        }
        
        public void Mostrar(FormIngresante formIngresante)
        {
            StringBuilder stringBuilder = new StringBuilder();
            StringBuilder cursos = new StringBuilder();

            stringBuilder.AppendLine($"Nombre: {formIngresante.nombre}");
            stringBuilder.AppendLine($"Dirección: {formIngresante.direccion}");
            stringBuilder.AppendLine($"Edad: {formIngresante.edad}");
            stringBuilder.AppendLine($"Género: {formIngresante.genero}");
            stringBuilder.AppendLine($"País: {formIngresante.pais}");

            for ( int i = 0; i < formIngresante.cursos.Length; i++)
            {
                cursos.Append($"{formIngresante.cursos[i].ToString()}. ");                
            }
            stringBuilder.AppendLine($"Curso/s: {cursos}");
            MessageBox.Show(stringBuilder.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.None);

        }

        // Por el momento no lo valido
        //public bool ValidarEdad()
        //{
        //    return edad > 9 && edad < 91;
        //}

        private void Rb_GeneroM_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_GeneroM.Checked)
            {
                Rb_GeneroF.Checked = false;
                Rb_GeneroB.Checked = false;
            }
            else
            {
                Rb_GeneroM.Checked = false;
            }
        }

        private void Rb_GeneroF_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_GeneroF.Checked)
            {
                Rb_GeneroM.Checked = false;
                Rb_GeneroB.Checked = false;
            }
            else
            {
                Rb_GeneroF.Checked = false;
            }
        }

        private void Rb_GeneroB_CheckedChanged(object sender, EventArgs e)
        {
            if (Rb_GeneroB.Checked)
            {
                Rb_GeneroF.Checked = false;
                Rb_GeneroM.Checked = false;
            }
            else
            {
                Rb_GeneroB.Checked = false;
            }
        }

        private void Cb_Cursos1_CheckedChanged(object sender, EventArgs e)
        {
            //if (Cb_Cursos1.Checked)
            //{
            //    Cb_Cursos2.Checked = false;
            //    Cb_Cursos3.Checked = false;
            //}
            //else
            //{
            //    Cb_Cursos1.Checked = false;
            //}
        }

        private void Cb_Cursos2_CheckedChanged(object sender, EventArgs e)
        {
            //if (Cb_Cursos2.Checked)
            //{
            //    Cb_Cursos1.Checked = false;
            //    Cb_Cursos3.Checked = false;
            //}
            //else
            //{
            //    Cb_Cursos2.Checked = false;
            //}
        }

        private void Cb_Cursos3_CheckedChanged(object sender, EventArgs e)
        {
            //if (Cb_Cursos3.Checked)
            //{
            //    Cb_Cursos1.Checked = false;
            //    Cb_Cursos2.Checked = false;
            //}
            //else
            //{
            //    Cb_Cursos3.Checked = false;
            //}
        }
    }
}