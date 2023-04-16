namespace ContarPalabras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            // Obtener el texto ingresado
            string texto = RichTextBox.Text;
            // Separar el texto en palabras
            string[] palabras = texto.Split(' ');

            // Crear un diccionario para almacenar las palabras y sus conteos
            Dictionary<string, int> conteoPalabras = new Dictionary<string, int>();

            // Recorrer cada palabra del texto
            foreach (string palabra in palabras)
            {
                // Si la palabra ya existe en el diccionario, incrementar su contador
                if (conteoPalabras.ContainsKey(palabra))
                {
                    conteoPalabras[palabra]++;
                }
                // Si la palabra es nueva, agregarla al diccionario e inicializar su contador en 1
                else
                {
                    conteoPalabras.Add(palabra, 1);
                }
            }

            // Ordenar las palabras por cantidad de apariciones en orden descendente
            var palabrasOrdenadas = conteoPalabras.OrderByDescending(x => x.Value);

            // Obtener el TOP 3 de palabras con más apariciones
            var top3 = palabrasOrdenadas.Take(3);

            // Crear el mensaje a mostrar en el MessageBox
            string mensaje = "TOP 3 de palabras con más apariciones:\n\n";
            foreach (var palabra in top3)
            {
                mensaje += $"{palabra.Key}: {palabra.Value}\n";
            }

            // Mostrar el MessageBox con el resultado
            MessageBox.Show(mensaje);
        }
    }
}