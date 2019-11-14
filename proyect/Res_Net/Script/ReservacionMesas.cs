using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_Net.Script
{
    class ReservacionMesas
    {
        public int numMesa { get; set; }
        public string nombreCliente { get; set; }
        public string hora { get; set; }
        public DateTime fecha { get; set; }
        public string contacto { get; set; }

        public ReservacionMesas(int numMesa, string nombreCliente, string hora, DateTime fecha, string contacto)
        {
            this.numMesa = numMesa;
            this.nombreCliente = nombreCliente;
            this.hora = hora;
            this.fecha = fecha;
            this.contacto = contacto;
        }
    }
}
