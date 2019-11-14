using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_Net.Script
{
    class FichasMesas
    {
        public int numMesa;
        public string mozoAsignado { get; set; }
        public string nombreCliente { get; set; }
        public string contacto { get; set; }
        public DateTime fecha { get; set; }
        public string hora { get; set; }
        public bool esReservacion { get; set; }
        public List<Productos> productos = new List<Productos>();
        public bool ocupada { get; set; }

        public FichasMesas(int numMesa)
        {
            this.numMesa = numMesa;

        }
    }
}
