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

        /* Al pulsar el men� "Abrir" se deber� abrir una ventana para seleccionar el archivo a abrir.        
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


        /* Al hacer click sobre "Guardar", se deber� guardar en el �ltimo archivo guardado
         * o abierto desde la interfaz. En el caso que no haya ning�n "�ltimo archivo",
         * se comportar� igual que la opci�n "Guardar como...". Reutilizar c�digo.
         * En caso de error en cualquiera de las operaciones se deber� mostrar una ventana de error
         * conteniendo el mensaje de la excepci�n y su stack trace.*/

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lastFilePath))
            {
                // Si no hay un "�ltimo archivo" guardado, se comporta como "Guardar como..."
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo de texto|.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        lastFilePath = sfd.FileName;
                    }
                    else
                    {
                        return; // El usuario cancel� la operaci�n
                    }
                }
            }

            string content = RichTextBox.Text;

            GuardarArchivo(lastFilePath);
        }
        /* Al pulsar el men� "Guardar como..." se deber� abrir una ventana para seleccionar la ubicaci�n donde se guardar� el archivo y c�mo se llamar�.
         * Utilizar la clase SaveFileDialog.
         * La propiedad Filter de SaveFileDialog deber� tener el valor "Archivo de texto|.txt"*.
         * Tomar el contenido a guardar del texto en el RichTextBox.*/
        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
                
            // Si no hay un "�ltimo archivo" guardado, se comporta como "Guardar como..."
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Archivo de texto|.txt";

                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        lastFilePath = sfd.FileName;
                    }
                    else
                    {
                        return; // El usuario cancel� la operaci�n
                    }
                }
            GuardarArchivo(lastFilePath);
        }
    }
}