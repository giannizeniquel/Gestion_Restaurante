using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Res_Net.Script
{
    static class DatosEstaticos
    {
        static public List<ReservacionMesas> reservacionesList = new List<ReservacionMesas>();
        static public int numMesa = 1;
        static public List<int> Borrados = new List<int>();
        static public List<Productos> productosList = new List<Productos>();
        static public List<FichasMesas> fichasMesas = new List<FichasMesas>();
        static public List<string> mozosList = new List<string>();
        static public FichasMesas fichaSeleccionada;
        static public ButtonMesa mesaSeleccionada;
        static public List<Form> formList = new List<Form>();
        static public int idAdornos;
        static public int simulacionOn;
        static public void IncrementarNumMesa() {
            numMesa++;
        }
        static public void IncrementarIdAdornos()
        {
            idAdornos++;
        }

        static public void CargarMozos() {
            mozosList.Add("Perez Juan");
            mozosList.Add("Gimenez Laura");
            mozosList.Add("Albarez Pedro");
            mozosList.Add("Miño Natanael");
            mozosList.Add("Alfonzo Hernan");
        }
    }
}
