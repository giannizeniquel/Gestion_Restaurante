using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Diagnostics;
using iTextSharp.text.pdf.parser;
namespace Res_Net.Script
{
    class Tickets
    {
       public StringBuilder linea = new StringBuilder();
        int maxChar = 40, cortar;

        public Tickets() {
            this.TextoCentro("Resto .Net");
            this.TextoIzquierda("DIREC: FRENCH 550");
            this.TextoIzquierda("TELEF: 4425154");
            this.TextoIzquierda("EMAIL: Resto.Net@gmail.com");
            this.TextoIzquierda("");
            this.TextoExtemos("Caja # 1","Ticket # 002-0000003");
            this.LineasAsteriscos();

            this.TextoIzquierda("");
            this.TextoIzquierda("MOZO: " +DatosEstaticos.fichaSeleccionada.mozoAsignado);
            this.TextoIzquierda("CLIENTE: " + DatosEstaticos.fichaSeleccionada.nombreCliente);
            this.TextoIzquierda("");
            this.TextoIzquierda("FECHA: " + DatosEstaticos.fichaSeleccionada.fecha.Date.ToShortDateString());
            this.TextoIzquierda("HORA: "+ DatosEstaticos.fichaSeleccionada.hora);
            this.LineasAsteriscos();

            this.EncabezadoVenta();
            this.LineasAsteriscos();
            float total = 0.0f;
            for (int i = 0; i < DatosEstaticos.fichaSeleccionada.productos.Count; i++)
            {
                this.AgragarProducto(DatosEstaticos.fichaSeleccionada.productos[i].nombre,1,DatosEstaticos.fichaSeleccionada.productos[i].precio,DatosEstaticos.fichaSeleccionada.productos[i].precio);
                total += DatosEstaticos.fichaSeleccionada.productos[i].precio;
            }
            this.LineasGuio();
            this.AgregarTotales("          TOTAL",total );

            Document tiketdoc = new Document();
            PdfWriter.GetInstance(tiketdoc,new FileStream("ticket.pdf",FileMode.Create));
            tiketdoc.Open();
            string a = this.linea.ToString();
            Console.WriteLine(this.linea);
            Console.WriteLine(a);            
            tiketdoc.Add(new Paragraph(a, FontFactory.GetFont(FontFactory.TIMES, 11, iTextSharp.text.Font.NORMAL)));
            tiketdoc.Close();
            Process.Start("ticket.pdf");
        }
        //Creamos la lineas de -
        public string LineasGuion() {

            string lineasGuion = "";
            for (int i = 0; i < maxChar; i++)
            {
                lineasGuion += "-";
            }
            return linea.AppendLine(lineasGuion).ToString();
        }
        //Creamos la lineas de * 
        public string LineasAsteriscos()
        {

            string lineasAsteriscos = "";
            for (int i = 0; i < maxChar; i++)
            {
                lineasAsteriscos += "*";
            }
            return linea.AppendLine(lineasAsteriscos).ToString();
        }
        //Creamos la lineas de = 
        public string LineasGuio()
        {

            string lineasIgual = "";
            for (int i = 0; i < maxChar; i++)
            {
                lineasIgual += "=";
            }
            return linea.AppendLine(lineasIgual).ToString();
        }
        //Creamos encabezado para los productos
        public void EncabezadoVenta() {
            linea.AppendLine("ARTICULO            |CANT|PRECIO|IMPORTE");
                
            }
        //Controo la cantidad de caracteres
        public void TextoIzquierda(string texto) {
            if (texto.Length > maxChar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxChar; longitudTexto -= maxChar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxChar));
                    caracterActual += maxChar;
                }
                linea.AppendLine(texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else {
                linea.AppendLine(texto);
            }
        }
        public void TextoDerecha(string texto) {
            if (texto.Length > maxChar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxChar; longitudTexto -= maxChar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxChar));
                    caracterActual += maxChar;
                }
                string espacios = "";
                for (int i = 0; i < (maxChar - texto.Substring(caracterActual,texto.Length - caracterActual).Length); i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                for (int i = 0; i < (maxChar - texto.Length) ; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios +texto);
            }
        }
        public void TextoCentro(string texto) {
            if (texto.Length > maxChar)
            {
                int caracterActual = 0;
                for (int longitudTexto = texto.Length; longitudTexto > maxChar; longitudTexto -= maxChar)
                {
                    linea.AppendLine(texto.Substring(caracterActual, maxChar));
                    caracterActual += maxChar;
                }
                string espacios = "";
                int centrar = (maxChar - texto.Substring(caracterActual, texto.Length - caracterActual).Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto.Substring(caracterActual, texto.Length - caracterActual));
            }
            else
            {
                string espacios = "";
                int centrar = (maxChar - texto.Length) / 2;

                for (int i = 0; i < centrar; i++)
                {
                    espacios += " ";
                }
                linea.AppendLine(espacios + texto);
            }
        }
        public void TextoExtemos(string textoIzquierdo, string textoDerecho) {
            string textoIzq, textoDer, textoCompleto = "", espacios = "";
            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else {
                textoIzq = textoIzquierdo;
            }
            if (textoDerecho.Length > 20)
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else {
                textoDer = textoDerecho;
            }
            int nroEspacios = maxChar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + textoDerecho;
            linea.AppendLine(textoCompleto);
        }
        public void AgregarTotales(string texto,float total) {
            string resumen, valor, textoCompleto, espacios = "";
            if (texto.Length > 25) {
                cortar = texto.Length - 25;
                resumen = texto.Remove(25,cortar);
            }
            else
            {
                resumen = texto;
            }
            textoCompleto = resumen;
            valor = total.ToString("#,#.00");
            int nroEspacios = maxChar - (resumen.Length + valor.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";
            }
            textoCompleto += espacios + valor;
            linea.AppendLine(textoCompleto);
        }
        public void AgragarProducto(string producto,int cant,float precio,float importe) {
            if (cant.ToString().Length <= 5 && precio.ToString().Length <= 7 && importe.ToString().Length <=8) {
                string elemento = "", espacios = "";
                bool bandera = false;
                int nroEspacios = 0;

                if (producto.Length > 20) {
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();

                    int caracterActual = 0;
                    for (int longitudTexto = producto.Length; longitudTexto >20;longitudTexto-=20)
                    {
                        if (!bandera)
                        {
                            linea.AppendLine(producto.Substring(caracterActual,20)+ elemento);
                            bandera = true;
                        }
                        else
                        {
                            linea.AppendLine(producto.Substring(caracterActual,20));
                            caracterActual += 20;
                        }
                    }
                    linea.AppendLine(producto.Substring(caracterActual,producto.Length - caracterActual));
                }
                else
                {
                    for (int i = 0; i < (20 - producto.Length); i++)
                    {
                        espacios += " ";
                    }
                    elemento = producto + espacios;
                    nroEspacios = (5 - cant.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + cant.ToString();
                    nroEspacios = (7 - precio.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + precio.ToString();

                    nroEspacios = (8 - importe.ToString().Length);
                    espacios = "";
                    for (int i = 0; i < nroEspacios; i++)
                    {
                        espacios += " ";
                    }
                    elemento += espacios + importe.ToString();
                    linea.AppendLine(elemento);
                }
            }
            else
            {
                linea.AppendLine("Los valores ingresados para esta fila");
                linea.AppendLine("Superan las columnas soportados por este");
                throw new Exception("Los valores ingresados para algunas filas del tiket superan las columnas soportadas por este");
            }
        }
    }
}
