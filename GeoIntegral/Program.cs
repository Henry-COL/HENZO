using GeoIntegral.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral
{
    internal class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Load_Screen pantallaCarga = new Load_Screen();
            Application.Run(pantallaCarga);

            Application.Run(new Login_Screen());
        }
    }
}
