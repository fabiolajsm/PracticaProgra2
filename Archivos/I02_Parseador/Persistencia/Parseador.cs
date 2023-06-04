namespace Persistencia
{
    public static class Parseador
    {
        /*El método privado VerificarSiExisteDirectorio deberá verificar si 
         * existe el directorio y si no existe deberá crearlo.
        Si existe o no existía pero lo pudo crear, retornar true.
        Si no existía o no se pudo crear, retornar false.

        El método privado VerificarSiExisteArchivo deberá verificar si existe el directorio y
        si no existe deberá crearlo.
        Si existe o no existía pero lo pudo crear, retornar true.
        Si no existía o no se pudo crear, retornar false.*/
        private static bool VerificarSiExisteDirectorio(string ruta)
        {
            return Directory.Exists(ruta);
        }
        private static bool  VerificarSiExisteArchivo(string ruta)
        {
            return File.Exists(ruta);
        }
    }
}