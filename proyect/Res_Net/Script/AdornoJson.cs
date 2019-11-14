using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Res_Net.Script
{
    class AdornoJson
    {
        public bool fijadoAdorno;
        public int altura;
        public int ancho;
        public int locationX;
        public int locationY;
        public string pathImage;
        public int idAdorno;
        public byte rotateFlip;

        public AdornoJson(int altura, int ancho)
        {
            this.altura = altura;
            this.ancho = ancho;
        }
    }
}
