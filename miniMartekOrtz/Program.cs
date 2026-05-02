using System;
using System.Windows.Forms;

namespace miniMartekOrtz
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Aquí pones cuál quieres que sea la primera ventana en abrirse
            Application.Run(new login());
        }
    }
}