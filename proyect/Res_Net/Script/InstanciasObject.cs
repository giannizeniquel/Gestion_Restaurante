using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Res_Net.Forms;
using System.Windows.Forms;
using System.Drawing;

namespace Res_Net.Script
{
    class InstanciasObject
    {

        public ButtonMesa CreateButtonMesa(int tamanioMesa, bool escalarPlano,int anchoMesas,int altoMesas) {
            /**1 = 2 sillas cuadrado
          2 = 4 sillas cuadrado
          3 = 6 sillas cuadrado
          4 = 8 sillas cuadrado
          5 = 4 sillas redondas
       **/
            if (escalarPlano)
            {
                anchoMesas *= 2;
                altoMesas *= 2;
            }
            ButtonMesa btnMesa = new ButtonMesa(DatosEstaticos.numMesa, anchoMesas, altoMesas, 8);
            if (DatosEstaticos.Borrados.Count == 0)
            {
                btnMesa.numeroMesa = DatosEstaticos.numMesa;
                DatosEstaticos.IncrementarNumMesa();
            }
            else
            {
                int count = 0;
                int numMesaBusqueda = 0;
                for (int i = 0; i < DatosEstaticos.Borrados.Count; i++)
                {
                    if (count == 0)
                    {
                        numMesaBusqueda = DatosEstaticos.Borrados[0];
                        count = 1;
                    }
                    else
                    {
                        if (numMesaBusqueda > DatosEstaticos.Borrados[i])
                        {
                            numMesaBusqueda = DatosEstaticos.Borrados[i];
                        }
                    }
                }
                btnMesa.numeroMesa = numMesaBusqueda;
                DatosEstaticos.Borrados.Remove(numMesaBusqueda);
            }

            if (tamanioMesa == 1)
            {
                btnMesa.cantidadSillas = 2;
                btnMesa.BackgroundImage = Properties.Resources.Mesa_2Sillas1;
                btnMesa.resourceImageName = "Mesa_2Sillas1";
            }
            else if (tamanioMesa == 2)
            {
                btnMesa.cantidadSillas = 4;
                btnMesa.BackgroundImage = Properties.Resources.Mesa_4Sillas1;
                btnMesa.resourceImageName = "Mesa_4Sillas1";
            }
            else if (tamanioMesa == 3)
            {
                btnMesa.cantidadSillas = 6;
                btnMesa.BackgroundImage = Properties.Resources.Mesa_6Sillas1;
                btnMesa.resourceImageName = "Mesa_6Sillas1";
            }
            else if (tamanioMesa == 4)
            {
                btnMesa.cantidadSillas = 8;
                btnMesa.BackgroundImage = Properties.Resources.Mesa_8Sillas1;
                btnMesa.resourceImageName = "Mesa_8Sillas1";
            }
            else if (tamanioMesa == 5)
            {
                btnMesa.cantidadSillas = 2;
                btnMesa.BackgroundImage = Properties.Resources.MesaVistaAereaCircular_1;
                btnMesa.resourceImageName = "MesaVistaAereaCircular_1";
            }
            btnMesa.BackgroundImageLayout = ImageLayout.Stretch;
            return btnMesa;
        }
        public PictureAdornos CreateAdornos(int tipoAdorno, bool escalarPlano, int anchoAdorno, int altoAdorno) {
            /**
            1 = macetaVerde
           2 = macetaConflores
           3 = macetaLarga
           4 = macetaRosaColores
           5 = pared 1
            6 = puerta 1
            7 = baño 1
            8 = lavamanos 1
           8 = bar 1
             **/
            if (escalarPlano)
            {
                anchoAdorno *= 2;
                altoAdorno *= 2;
            }
            PictureAdornos adornoPicture = new PictureAdornos(altoAdorno, anchoAdorno);
            if (tipoAdorno == 1)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Maceta_PlantaVerde;
                adornoPicture.resourceImageName = "Maceta_PlantaVerde";
            }
            else if (tipoAdorno == 2)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Maceta_PlantaVerdeFlores;
                adornoPicture.resourceImageName = "Maceta_PlantaVerdeFlores";
            }
            else if (tipoAdorno == 3)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Maceta_variasPlantas;
                adornoPicture.resourceImageName = "Maceta_variasPlantas";
            }
            else if (tipoAdorno == 4)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Maceta_PlantaRosa;
                adornoPicture.resourceImageName = "Maceta_PlantaRosa";
            }
            else if (tipoAdorno == 5)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Pared_01;
                adornoPicture.resourceImageName = "Pared_01";
            }
            else if (tipoAdorno == 6)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Puerta_02;
                adornoPicture.resourceImageName = "Puerta_02";
            }
            else if (tipoAdorno == 7)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Inodoro_image;
                adornoPicture.resourceImageName = "Inodoro_image";
            }
            else if (tipoAdorno == 8)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Lavamanos_image;
                adornoPicture.resourceImageName = "Lavamanos_image";
            }
            else if (tipoAdorno == 9)
            {
                adornoPicture.BackgroundImage = Properties.Resources.Bar_image;
                adornoPicture.resourceImageName = "Bar_image";

            }
            adornoPicture.idAdorno = DatosEstaticos.idAdornos;
            DatosEstaticos.IncrementarIdAdornos();
            adornoPicture.BackgroundImageLayout = ImageLayout.Stretch;
            return adornoPicture;
        }
        public ButtonMesa IniMesasPlano(int index) {
            ButtonMesa mesa = new ButtonMesa(GestionJson.mesasJson[index].numMesa, GestionJson.mesasJson[index].altura, 
                                             GestionJson.mesasJson[index].ancho,GestionJson.mesasJson[index].numSillas);
            mesa.fijado = true;
            mesa.yacreadoBool = true;
            mesa.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(GestionJson.mesasJson[index].pathImage);
            mesa.BackgroundImageLayout = ImageLayout.Stretch;
            mesa.FlatAppearance.BorderColor = Color.Green;
            mesa.BackColor = Color.Green;
            mesa.Text = mesa.numeroMesa.ToString();
            if (mesa.Height > mesa.Width)
            {
                mesa.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            }
            if (DatosEstaticos.simulacionOn == 1) {
                FichasMesas ficha = new FichasMesas(mesa.numeroMesa);
                DatosEstaticos.fichasMesas.Add(ficha);
            }

            return mesa;
        }
        public PictureBox IniPisoPlano(int index) {
            PictureBox piso = new PictureBox();
            piso.Name = GestionJson.sueloTestJson[index].nombre;
            piso.Height = GestionJson.sueloTestJson[index].altura;
            piso.Width = GestionJson.sueloTestJson[index].ancho;
            piso.BackColor = Color.FromArgb(GestionJson.sueloTestJson[index].backColor);
            return piso;
        }
        public PictureAdornos IniAdornos(int index) {
            PictureAdornos adorno = new PictureAdornos(GestionJson.adornosJsonList[index].altura, GestionJson.adornosJsonList[index].ancho);
            adorno.fijadoAdorno = true;
            adorno.BackgroundImage = (Image)Properties.Resources.ResourceManager.GetObject(GestionJson.adornosJsonList[index].pathImage);
            adorno.BackgroundImageLayout = ImageLayout.Stretch;
            adorno.rotateFlip = GestionJson.adornosJsonList[index].rotateFlip;
            switch (adorno.rotateFlip)
            {
                case 0:
                    {

                    }
                    break;
                case 1:
                    {
                        adorno.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
                    }
                    break;
                case 2:
                    {
                        adorno.BackgroundImage.RotateFlip(RotateFlipType.Rotate180FlipXY);
                    }
                    break;
                case 3:
                    {
                        adorno.BackgroundImage.RotateFlip(RotateFlipType.Rotate270FlipXY);
                    }
                    break;
            }
            return adorno;
        }
    }
}
