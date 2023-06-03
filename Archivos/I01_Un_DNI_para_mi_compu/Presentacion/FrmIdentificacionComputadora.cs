using System;
using System.IO;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FrmIdentificacionComputadora : Form
    {
        public FrmIdentificacionComputadora()
        {
            InitializeComponent();
        }
        /* 1. Manejar el evento Load del formulario y cambiar la propiedad Text para que contenga el mensaje "Compu de [usuario]". 
         * Reemplazar el texto entre corchetes por el nombre del usuario conectado al sistema operativo. 
         * Obtener el dato a partir de la propiedad que corresponda de la clase Environment.*/
        private void FrmIdentificacionComputadora_Load(object sender, EventArgs e)
        {
            Text = $"Compu de {Environment.UserName}";
            ConfigurarLogoSistemaOperativo();
            lblSistemaOperativo.Text = $"Sistema operativo: {Environment.OSVersion}";
            lblNombreMaquina.Text = $"Nombre de la máquina: {Environment.MachineName}";
            ConfigurarArquitectura();
            lblCantProcesadores.Text = $"Cant. procesadores: {Environment.ProcessorCount} procesadores lógicos";
            lblDirectorioActual.Text = $"Identificación ejecutada en: {Environment.NewLine}{Environment.CurrentDirectory}";
            ConfigurarEspacioTotalYDisponible();
        }
        /* 2. Crear el método private void ConfigurarLogoSistemaOperativo() y utilizando los métodos estáticos de la clase OperatingSystem implementar la siguiente lógica:
         * Si el sistema es MacOS, asignar Properties.Resources.mac a la propiedad Image del control picboxSistemaOperativo.
         * Si el sistema es Linux, asignar Properties.Resources.linux a la propiedad Image del control picboxSistemaOperativo.
         * Si el sistema es Windows, asignar Properties.Resources.windows a la propiedad Image del control picboxSistemaOperativo. *
        /* 3. Invocar al método ConfigurarLogoSistemaOperativo del punto anterior dentro del manejador del evento Load.*/
        /* 4. Dentro del manejador del evento Load modificar la propiedad Text del label lblSistemaOperativo y cargar el mensaje 
         * "Sistema operativo: [Plataforma y versión del sistema operativo]".
         * Reemplazar el texto entre corchetes por la descripción del sistema operativo sobre el que se está ejecutando la aplicación. 
         * Obtener el dato a partir de la propiedad que corresponda de la clase Environment.*/
        /* 5. Dentro del manejador del evento Load modificar la propiedad Text del label lblNombreMaquina y cargar el mensaje 
         * "Nombre de la máquina: [Nombre de la máquina]". Reemplazar el texto entre corchetes por el nombre de la máquina sobre la que se está ejecutando la aplicación.
         * Obtener el dato a partir de la propiedad que corresponda de la clase Environment.*/
        private void ConfigurarLogoSistemaOperativo()
        {
            if (OperatingSystem.IsMacOS())
            {
                picboxSistemaOperativo.Image = Properties.Resources.mac;
            }
            if (OperatingSystem.IsLinux())
            {
                picboxSistemaOperativo.Image = Properties.Resources.linux;
            } 
            if(OperatingSystem.IsWindows())
            {
                picboxSistemaOperativo.Image = Properties.Resources.windows;
            }
        }
        /* 6. Crear el método private void ConfigurarArquitectura() y utilizando la propiedad estática que corresponda de la clase Environment implementar la siguiente lógica:
        * Si el sistema es de 64 bits, modificar la propiedad Text del label lblArquitectura y cargar el mensaje "Arquitectura: 64 bits".
        * Si el sistema es de 32 bits, modificar la propiedad Text del label lblArquitectura y cargar el mensaje "Arquitectura: 32 bits".*/
        private void ConfigurarArquitectura()
        {
            if (Environment.Is64BitOperatingSystem)
            {
                lblArquitectura.Text = "Arquitectura: 64 bits";
            }
            else
            {
                lblArquitectura.Text = "Arquitectura: 32 bits";
            }
        }
        /* 7. Dentro del manejador del evento Load modificar la propiedad Text del label lblCantProcesadores y cargar el mensaje "Cant. procesadores: [cantidad de procesadores lógicos] procesadores lógicos". 
         * Reemplazar el texto entre corchetes por la cantidad de procesadores lógicos que tiene la máquina sobre la que se está ejecutando la aplicación. 
         * Obtener el dato a partir de la propiedad que corresponda de la clase Environment.*/
        /* 8. Dentro del manejador del evento Load modificar la propiedad Text del label lblDirectorioActual y:
         * Cargarle el mensaje "Identificación ejecutada en: [Salto de línea]".
         * Reemplazar el texto entre corchetes por un salto de línea que sea agnóstico al sistema operativo sobre el que se ejecuta la aplicación, para eso se deberá utilizar la propiedad que corresponda de la clase Environment.
         * A continuación del salto de línea generado en el punto anterior, incorporar al texto la ruta absoluta del directorio sobre el que se está ejecutando la aplicación. Obtener el dato con la propiedad CurrentDirectory de la clase Environment.*/

        /* 9. Crear el método private void ConfigurarEspacioTotalYDisponible() y utilizando el método estático GetDrives de la clase DriveInfo:
         * Modificar la propiedad Text del label lblEspacioTotal y cargar el mensaje "Espacio total: [espacio total] Gigabytes". 
         * Reemplazar el texto entre corchetes por la suma del espacio total de todas las unidades de almacenamiento de la computadora. 
         * Mostrar el dato en gygabytes redondeado al entero más cercano.
         * Modificar la propiedad Text del label lblEspacioDisponible y cargar el mensaje "Espacio disponible: [espacio disponible] Gigabytes".
         * Reemplazar el texto entre corchetes por la suma del espacio disponible en todas las unidades de almacenamiento de la computadora. 
         * Mostrar el dato en gygabytes redondeado al entero más cercano.*/
        private void ConfigurarEspacioTotalYDisponible()
        {
            long espacioTotalBytes = 0;
            long espacioDisponibleBytes = 0;

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                espacioTotalBytes += drive.TotalSize;
                espacioDisponibleBytes += drive.AvailableFreeSpace;
            }

            double espacioTotal = Math.Round(espacioTotalBytes * 9.31e-10);
            double espacioDisponible = Math.Round(espacioDisponibleBytes * 9.31e-10);

            lblEspacioTotal.Text = $"Espacio total: {espacioTotal} Gigabytes";
            lblEspacioDisponible.Text = $"Espacio disponible: {espacioDisponible} Gigabytes";
        }
    }
}
