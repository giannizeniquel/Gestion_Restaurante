using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_Net.Script
{
    class Productos
    {
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public float precio { get; set; }

        public Productos(int idProducto, string nombre, string descripcion, float precio)
        {
            this.idProducto = idProducto;
            this.precio = precio;
            this.nombre = nombre;
            this.descripcion = descripcion;
        }
    }
}
