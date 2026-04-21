using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            string rutaCarpeta = Path.Combine(Application.StartupPath, "..", "..", "DataBase");

            string[] archivos = { "Music.csv", "Purchased_music.csv", "uploaded_music.csv" };

            try
            {
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                foreach (string nombre in archivos)
                {
                    string rutaCompleta = Path.Combine(rutaCarpeta, nombre);

                    if (!File.Exists(rutaCompleta))
                    {
                        File.Create(rutaCompleta).Dispose();
                    }
                }
            }
            catch (Exception)
            {
            }
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_Screen());
        }
    }
}