using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_Net.Script
{
    class Simulacion
    {
        FichasMesas ficha10 = new FichasMesas(10);
        FichasMesas ficha1 = new FichasMesas(1);
        FichasMesas ficha2 = new FichasMesas(2);
        FichasMesas ficha3 = new FichasMesas(3);
        FichasMesas ficha4 = new FichasMesas(4);
        FichasMesas ficha5 = new FichasMesas(5);
        FichasMesas ficha6 = new FichasMesas(6);
        FichasMesas ficha7 = new FichasMesas(7);
        FichasMesas ficha8 = new FichasMesas(8);
        FichasMesas ficha9 = new FichasMesas(9);

        public Simulacion() {
            DatosEstaticos.fichasMesas.Add(ficha1);
            DatosEstaticos.fichasMesas.Add(ficha2);
            DatosEstaticos.fichasMesas.Add(ficha3);
            DatosEstaticos.fichasMesas.Add(ficha4);
            DatosEstaticos.fichasMesas.Add(ficha5);
            DatosEstaticos.fichasMesas.Add(ficha6);
            DatosEstaticos.fichasMesas.Add(ficha7);
            DatosEstaticos.fichasMesas.Add(ficha8);
            DatosEstaticos.fichasMesas.Add(ficha9);
            DatosEstaticos.fichasMesas.Add(ficha10);

            ReservacionMesas res1 = new ReservacionMesas(1, "Julian Robledo", "14:00", DateTime.Today, "4425616");
            ReservacionMesas res2 = new ReservacionMesas(6, "Alberto Paris", "14:00", DateTime.Today, "44225141");
            ReservacionMesas res3 = new ReservacionMesas(2, "Matias Maidana", "17:15", DateTime.Today, "362451251");
            ReservacionMesas res4 = new ReservacionMesas(3, "Andres Cortez", "18:00", DateTime.Today, "362451541");
            DatosEstaticos.reservacionesList.Add(res1);
            DatosEstaticos.reservacionesList.Add(res2);
            DatosEstaticos.reservacionesList.Add(res3);
            DatosEstaticos.reservacionesList.Add(res4);
        }
      public void EstadoActual(string horaActual) {
            string telString = horaActual.Remove(2, 1);
            int HoraActualInt = int.Parse(telString);

            if (HoraActualInt >= 0900 && HoraActualInt <= 1100) {
                //Mesa 1

                ficha1.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha1.nombreCliente = "Alberto Gomez";
                ficha1.ocupada = true;
                ficha1.fecha = DateTime.Today;
                ficha1.hora = "09:00";
                ficha1.productos.Add(new Productos(15, "Cafe", "Cortado", 50.50f));
                ficha1.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 2

                ficha2.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha2.ocupada = false;
                //Mesa 3

                ficha3.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha3.ocupada = false;
                //Mesa 4

                ficha4.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha4.nombreCliente = "Gonzalez Luis";
                ficha4.ocupada = true;
                ficha4.fecha = DateTime.Today;
                ficha4.hora = "09:00";
                ficha4.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha4.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 5

                ficha5.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha5.ocupada = false;
                //Mesa 6

                ficha6.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha6.ocupada = false;
                //Mesa 7

                ficha7.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha7.ocupada = false;
                //Mesa 8

                ficha8.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha8.ocupada = false;
                //Mesa 9

                ficha9.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha9.ocupada = false;
                //Mesa 10
                ficha10.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha10.ocupada = false;
            }
            //Segunda Hora de simulacion
            else if (HoraActualInt >= 1101 && HoraActualInt <= 1500)
            {
                ficha1.productos.Clear();
                ficha2.productos.Clear();
                ficha3.productos.Clear();
                ficha4.productos.Clear();
                ficha5.productos.Clear();
                ficha6.productos.Clear();
                ficha7.productos.Clear();
                ficha8.productos.Clear();
                ficha9.productos.Clear();
                ficha10.productos.Clear();
                //Mesa 1

                ficha1.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha1.nombreCliente = "";
                ficha1.ocupada = false;
                //Mesa 2
                ficha2.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha2.nombreCliente = "Gimenez Micaela";
                ficha2.ocupada = true;
                ficha2.fecha = DateTime.Today;
                ficha2.hora = "11:00";
                ficha2.productos.Clear();
                ficha2.productos.Add(new Productos(17, "Ensalada de verduras y Huevo", "Ensalada", 175.50f));
                ficha2.productos.Add(new Productos(17, "Bife Ancho", "Menu Principal", 175.50f));
                ficha2.productos.Add(new Productos(15, "Arroz al escabeche", "Arroz", 175.50f));
                ficha2.productos.Add(new Productos(16, "Pepsi 1L", "Bebida", 70.00f));
                //Mesa 3

                ficha3.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha3.nombreCliente = "Solis Juan";
                ficha3.ocupada = true;
                ficha3.fecha = DateTime.Today;
                ficha3.hora = "11:00";
                ficha3.productos.Clear();
                ficha3.productos.Add(new Productos(17, "Ensalada de verduras y Huevo", "Ensalada", 175.50f));
                ficha3.productos.Add(new Productos(17, "Bife Ancho", "Menu Principal", 175.50f));
                ficha3.productos.Add(new Productos(15, "Arroz al escabeche", "Arroz", 175.50f));
                ficha3.productos.Add(new Productos(16, "Pepsi 1L", "Bebida", 70.00f));
                //Mesa 4

                ficha4.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha4.nombreCliente = "Gonzalez Luis";
                ficha4.ocupada = true;
                ficha4.fecha = DateTime.Today;
                ficha4.hora = "09:00";
                ficha4.productos.Clear();
                ficha4.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha4.productos.Add(new Productos(15, "Licuado de banana", "Licuado", 95.50f));
                ficha4.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 5
                ficha5.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha5.ocupada = false;
                //Mesa 6

                ficha6.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha6.ocupada = false;
                //Mesa 7

                ficha7.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha7.ocupada = false;
                //Mesa 8

                ficha8.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha8.ocupada = false;
                //Mesa 9

                ficha9.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha9.nombreCliente = "Zeniquel Ivan";
                ficha9.ocupada = true;
                ficha9.fecha = DateTime.Today;
                ficha9.hora = "11:00";
                ficha9.productos.Clear();
                ficha9.productos.Add(new Productos(17, "Milanesa Napolitana", "Plato Principal", 255.50f));
                ficha9.productos.Add(new Productos(17, "Ensalada Rusa", "Ensalada", 175.50f));
                ficha9.productos.Add(new Productos(15, "Arroz con estofado", "Arroz", 175.50f));
                ficha9.productos.Add(new Productos(16, "Coca-Cola 1L", "Bebida", 85.00f));
                //Mesa 10
                ficha10.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha10.ocupada = false;
            } else if (HoraActualInt >= 1501 && HoraActualInt <= 1700) {
                ficha1.productos.Clear();
                ficha2.productos.Clear();
                ficha3.productos.Clear();
                ficha4.productos.Clear();
                ficha5.productos.Clear();
                ficha6.productos.Clear();
                ficha7.productos.Clear();
                ficha8.productos.Clear();
                ficha9.productos.Clear();
                ficha10.productos.Clear();

                //Mesa 1

                ficha1.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha1.nombreCliente = "Alberto Gomez";
                ficha1.ocupada = true;
                ficha1.fecha = DateTime.Today;
                ficha1.hora = "15:00";
                ficha1.productos.Clear();
                ficha1.productos.Add(new Productos(15, "Cafe", "Cortado", 50.50f));
                ficha1.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 2

                ficha2.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha2.ocupada = false;
                //Mesa 3

                ficha3.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha3.ocupada = false;
                //Mesa 4

                ficha4.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha4.nombreCliente = "Gonzalez Luis";
                ficha4.ocupada = true;
                ficha4.fecha = DateTime.Today;
                ficha4.hora = "15:00";
                ficha4.productos.Clear();
                ficha4.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha4.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 5

                ficha5.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha5.ocupada = false;
                //Mesa 6

                ficha6.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha6.ocupada = false;
                //Mesa 7

                ficha7.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha7.ocupada = false;
                //Mesa 8

                ficha8.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha8.ocupada = false;
                //Mesa 9

                ficha9.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha9.ocupada = false;
                //Mesa 10
                ficha10.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha10.ocupada = false;
            }
            else if (HoraActualInt >= 1701 && HoraActualInt <= 1900) {

                ficha1.productos.Clear();
                ficha2.productos.Clear();
                ficha3.productos.Clear();
                ficha4.productos.Clear();
                ficha5.productos.Clear();
                ficha6.productos.Clear();
                ficha7.productos.Clear();
                ficha8.productos.Clear();
                ficha9.productos.Clear();
                ficha10.productos.Clear();

                //Mesa 1

                ficha1.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha1.nombreCliente = "Alberto Gomez";
                ficha1.ocupada = true;
                ficha1.fecha = DateTime.Today;
                ficha1.hora = "15:00";
                ficha1.productos.Clear();
                ficha1.productos.Add(new Productos(15, "Cafe", "Cortado", 50.50f));
                ficha1.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                ficha1.productos.Add(new Productos(15, "Medialunas", "Facturas", 20.00f));
                //Mesa 2

                ficha2.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha2.ocupada = false;
                //Mesa 3

                ficha3.mozoAsignado = DatosEstaticos.mozosList[0];
                ficha3.ocupada = false;
                //Mesa 4

                ficha4.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha4.nombreCliente = "Franco Pablo";
                ficha4.ocupada = true;
                ficha4.fecha = DateTime.Today;
                ficha4.hora = "17:00";
                ficha4.productos.Clear();
                ficha4.productos.Add(new Productos(15, "Cafe", "Cortado", 50.50f));
                ficha4.productos.Add(new Productos(15, "Facturas varias", "Facturas", 20.00f));
                //Mesa 5

                ficha5.mozoAsignado = DatosEstaticos.mozosList[2];
                ficha5.ocupada = false;
                //Mesa 6

                ficha6.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha6.ocupada = false;
                //Mesa 7

                ficha7.mozoAsignado = DatosEstaticos.mozosList[3];
                ficha7.nombreCliente = "Hernandes Lidia";
                ficha7.ocupada = true;
                ficha7.fecha = DateTime.Today;
                ficha7.hora = "17:00";
                ficha7.productos.Clear();
                ficha7.productos.Add(new Productos(15, "Licuado de frutilla", "Licuado", 75.50f));
                ficha7.productos.Add(new Productos(15, "Cafe", "Cortado", 50.50f));
                ficha7.productos.Add(new Productos(15, "Cafe", "Tarro", 75.50f));
                ficha7.productos.Add(new Productos(15, "Facturas varias", "Facturas", 20.00f));
                //Mesa 8

                ficha8.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha8.ocupada = false;
                //Mesa 9

                ficha9.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha9.ocupada = false;
                //Mesa 10
                ficha10.mozoAsignado = DatosEstaticos.mozosList[4];
                ficha10.ocupada = false;
            }
        }
    }
}
