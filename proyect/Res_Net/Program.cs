using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res_Net.Forms;
using Res_Net.Script;
namespace Res_Net
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            GestionJson.CargarProductos();
            DatosEstaticos.CargarMozos();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MenuPrincipal mp = new MenuPrincipal();
            DatosEstaticos.formList.Add(mp);
            Application.Run(mp);

        }
    }
}
