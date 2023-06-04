using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        private string lastFilePath;

        public Form1()
        {
            InitializeComponent();
        }
        private void GuardarArchivo(string ruta)
        {
            string content = RichTextBox.Text;

            try
            {
                File.WriteAllText(ruta, content);
                MessageBox.Show("Guardado exitosamente");
            }
            catch (Exception ex)
            {
                ShowErrorMessageBox(ex);
            }
        }

        private void RichTextBox_TextChanged(object sender, EventArgs e)
        {
            int cantidadCaracteres = RichTextBox.Text.Length;
            toolStripStatusLabel.Text = $"Cantidad de caracteres: {cantidadCaracteres.ToString()}";
        }

        /* Al pulsar el menú "Abrir" se deberá abrir una ventana para seleccionar el archivo a abrir.        
         * Utilizar la clase OpenFileDialog.
         * Mostrar el contenido del archivo en el RichTextBox.*/
        private void ShowErrorMessageBox(Exception ex)
        {
            string errorMessage = $"Error: {ex.Message}\n\nStackTrace: {ex.StackTrace}";
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Archivos de texto|*.txt";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lastFilePath = ofd.FileName;

                try
                {
                    using (StreamReader reader = new StreamReader(lastFilePath))
                    {
                        string fileContent = reader.ReadToEnd();
                        RichTextBox.Text = fileContent;
                    }
                }
                catch (Exception ex)
                {
                    ShowErrorMessageBox(ex);
                }
            }
        }


        /* Al hacer click sobre "Guardar", se deberá guardar en el último archivo guardado
         * o abierto desde la interfaz. En el caso que no haya ningún "último archivo",
         * se comportará igual que la opción "Guardar como...". Reutilizar código.
         * En caso de error en cualquiera de las operaciones se deberá mostrar una ventana de error
         * conteniendo el mensaje de la excepción y su stack trace.*/

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastFilePath))
            {
                // Si no hay un "último archivo" guardado, se comporta como "Guardar como..."
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo de texto|.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        lastFilePath = sfd.FileName;
                    }
                    else
                    {
                        return; // El usuario canceló la operación
                    }
                }
            }

            string content = RichTextBox.Text;

            GuardarArchivo(lastFilePath);
        }
        /* Al pulsar el menú "Guardar como..." se deberá abrir una ventana para seleccionar la ubicación donde se guardará el archivo y cómo se llamará.
         * Utilizar la clase SaveFileDialog.
         * La propiedad Filter de SaveFileDialog deberá tener el valor "Archivo de texto|.txt"*.
         * Tomar el contenido a guardar del texto en el RichTextBox.*/
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
                
            // Si no hay un "último archivo" guardado, se comporta como "Guardar como..."
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo de texto|.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        lastFilePath = sfd.FileName;
                    }
                    else
                    {
                        return; // El usuario canceló la operación
                    }
                }
            GuardarArchivo(lastFilePath);
        }
    }
}