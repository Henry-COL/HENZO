using System.Windows.Forms; 
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1_Clase
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Abre Form1 como ventana principal
        }
    }
}
