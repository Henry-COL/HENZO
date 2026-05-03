using System;
using System.IO;
using System.Windows.Forms;

namespace app_inventario.Controllers
{
    public static class RutaArchivos
    {
        private static string ObtenerRaiz()
        {
            return Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
        }

        public static string ObtenerRutaMusica()
        {
            return Path.Combine(ObtenerRaiz(), "DataBase", "Music.csv");
        }

        public static string ObtenerRutaEntradas()
        {
            return Path.Combine(ObtenerRaiz(), "DataBase", "uploaded_music.csv");
        }

        public static string ObtenerRutaSalidas()
        {
            return Path.Combine(ObtenerRaiz(), "DataBase", "Purchased_music.csv");
        }

        public static string ObtenerRutaUsuarios()
        {
            return Path.Combine(ObtenerRaiz(), "DataBase", "Usuarios.csv");
        }

        public static string ObtenerRutaDataBase()
        {
            return Path.Combine(ObtenerRaiz(), "DataBase");
        }
    }
}