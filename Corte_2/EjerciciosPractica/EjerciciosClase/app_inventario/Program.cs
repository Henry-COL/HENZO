using System;
using System.IO;
using System.Windows.Forms;
using app_inventario.Views;

namespace app_inventario
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Principal_Screen());
        }
    }
}