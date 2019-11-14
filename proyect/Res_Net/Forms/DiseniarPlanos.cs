using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Res_Net.Script;
using System.Drawing;

namespace Res_Net.Forms
{
    public partial class DiseniarPlanos : Form
    {
        bool escalarPlano = false;
        int escalaInt = 3;
        int idMesa8Cuadrada = 3;
        int anchoPlano = 0;
        int altoPlano = 0;
        private List<ButtonMesa> buttonMesaList = new List<ButtonMesa>();
        private List<PictureAdornos> adornosList = new List<PictureAdornos>();
        private InstanciasObject iniObject;
        public DiseniarPlanos()
        {
            InitializeComponent();
        }

        private void DiseniarPlanos_Load(object sender, EventArgs e)
        {
            iniObject = new InstanciasObject();
            alturaTb.Text = "30";
            anchoTb.Text = "20";
            nombrePlanoTb.Text = "Mi Nuevo Plano en Resto .Net";
            premiunLb.Visible = false;
            premiunLLb.Visible = false;
            errorAnchoLb.Parent = panelPisoPn;
            errorAnchoLb.Location = new Point((panelPisoPn.Width - errorAnchoLb.Width) / 2, (panelPisoPn.Height - errorAnchoLb.Height) / 2);
            errorAlturaLb.Parent = panelPisoPn;
            errorAlturaLb.Location = new Point((panelPisoPn.Width - errorAlturaLb.Width) / 2, (panelPisoPn.Height - errorAlturaLb.Height) / 2);
            errorAlturaLb.Visible = false;
            errorAnchoLb.Visible = false;
            pisoPb.Parent = panelPisoPn;
            pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width)/2,(panelPisoPn.Height - pisoPb.Height)/2);
            MesasCtab.Visible = false;
        }


        /**Parseo y seteo altura y anchura**/
        private void AlturaTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(alturaTb.Text))
            {
                altoPlano = ParseAlturaAncho(alturaTb.Text);
                SetAlturaPlano(altoPlano);
            }
            else {
                SetAlturaPlano(0);
            }
        }
        private void AnchoTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(anchoTb.Text))
            {
                anchoPlano = ParseAlturaAncho(anchoTb.Text);
                SetAnchoPlano(anchoPlano);
            }
            else
            {
                SetAnchoPlano(0);
            }
        }
        private int ParseAlturaAncho(string num) {
            return int.Parse(num);
        }
        private void SetAlturaPlano(int altura) {
            if (altura > 0)
            {
                crearPlano.Enabled = true;
                premiunLb.Visible = false;
                premiunLLb.Visible = false;
                errorAlturaLb.Visible = false;
                if (altura <= 30)
                {
                    pisoPb.Height = altura * 10 * escalaInt;
                    pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
                }
                else
                {
                    pisoPb.Height = 300* escalaInt;
                    crearPlano.Enabled = false;
                    premiunLb.Visible = true;
                    premiunLLb.Visible = true;
                    errorAlturaLb.Visible = true;
                    pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
                }
            }
            else {
                pisoPb.Height = 300* escalaInt;
                pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
            }
            if (escalarPlano) {
                pisoPb.Height = altura * 10 * escalaInt * 2;
                pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
            }
        }
        private void SetAnchoPlano(int ancho) {
            premiunLb.Visible = false;

            if (ancho > 0)
            {
                crearPlano.Enabled = true;
                premiunLb.Visible = false;
                premiunLLb.Visible = false;
                errorAlturaLb.Visible = false;
                errorAnchoLb.Visible = false;
                if (ancho <= 20)
                {
                    pisoPb.Width = ancho * 10* escalaInt;
                    pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
                }
                else
                {
                    pisoPb.Width = 200* escalaInt;
                    crearPlano.Enabled = false;
                    premiunLb.Visible = true;
                    errorAnchoLb.Visible = true;
                    premiunLLb.Visible = true;
                    pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
                }
            }
            else
            {
                pisoPb.Width = 200* escalaInt;
                pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
            }
            if (escalarPlano)
            {
                pisoPb.Width = ancho * 10 * escalaInt * 2;
                pisoPb.Location = new Point((panelPisoPn.Width - pisoPb.Width) / 2, (panelPisoPn.Height - pisoPb.Height) / 2);
            }
        }
        /**FIN de Parseo y seteo altura y anchura**/

        /**Cambio de color piso y elementos**/
        private void ColorNegroBt_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK) {
                pisoPb.BackColor = colorDialog1.Color;
                CambiarColorMesasDeco();
            }
        }
        private void CambiarColorMesasDeco() {
            foreach (ButtonMesa item in buttonMesaList)
            {
                item.BackColor = pisoPb.BackColor;
                item.FlatAppearance.BorderColor = pisoPb.BackColor;
            }
            foreach (PictureAdornos item in adornosList)
            {
                item.BackColor = pisoPb.BackColor;
            }
        }

        /**Compruebo escalas, si se puede escalar**/
        private void ComprobarEscalar() {

            if (altoPlano <= 20 && anchoPlano <= 10)
            {
                escalarPlano = true;
            }
            else
            {
                escalarPlano = false;
            }
        }

        /**Creo mesas,adornos y plano (PictureBox Suelo)**/
        private void CrearPlano_Click(object sender, EventArgs e)
        {
            if (altoPlano <= 30 && anchoPlano <= 20)
            {
                alturaTb.Enabled = false;
                anchoTb.Enabled = false;
                nombrePlanoTb.Enabled = false;
                MesasCtab.Visible = true;

                ComprobarEscalar();
                SetAlturaPlano(altoPlano);
                SetAnchoPlano(anchoPlano);
            }
            else {
                MessageBox.Show("Coloque parametros permitidos","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }

        }
        private void CrearMesas(int tamanioMesa,int anchoMesas,int altoMesas) {
            ButtonMesa btnMesa = iniObject.CreateButtonMesa(tamanioMesa,escalarPlano,anchoMesas,altoMesas);
            Controls.Add(btnMesa);
            btnMesa.Location = new Point((panelPisoPn.Width - btnMesa.Width) / 2, (panelPisoPn.Height - btnMesa.Height) / 2);
            btnMesa.Parent = panelPisoPn;
            btnMesa.Text = btnMesa.numeroMesa.ToString();
            btnMesa.BackColor = pisoPb.BackColor;
            btnMesa.FlatAppearance.BorderColor = pisoPb.BackColor;
            buttonMesaList.Add(btnMesa);
            btnMesa.BringToFront();
        }
        private void CrearAdornos(int altoAdorno,int anchoAdorno,int tipoAdorno) {
            PictureAdornos adornoPicture = iniObject.CreateAdornos(tipoAdorno,escalarPlano,anchoAdorno,altoAdorno);
            //adornoPicture.ContextMenuStrip = ContextMenuFijar;
            Controls.Add(adornoPicture);
            adornoPicture.Location = new Point((panelPisoPn.Width - adornoPicture.Width) / 2, (panelPisoPn.Height - adornoPicture.Height) / 2);
            adornoPicture.Parent = panelPisoPn;
            adornoPicture.BackColor = pisoPb.BackColor;
            adornosList.Add(adornoPicture);
            adornoPicture.BringToFront();
        }

        /**Transformo y guardo las mesas y adornos**/
        private void TransformarGuardarMesas() {
            foreach (ButtonMesa item in buttonMesaList)
            {
                MesasJson mjson = new MesasJson();
                mjson.altura = item.Height;
                mjson.ancho = item.Width;
                mjson.fijado = item.fijado;
                mjson.locationx = item.Location.X;
                mjson.locationy = item.Location.Y;
                mjson.pathImage = item.resourceImageName;
                mjson.numMesa = item.numeroMesa;
                GestionJson.mesasJson.Add(mjson);
            }
        }
        private void TransformarGuardarAdornos()
        {
            foreach (PictureAdornos item in adornosList)
            {
                AdornoJson adornosJson = new AdornoJson(this.Height, this.Width);
                adornosJson.altura = item.Height;
                adornosJson.ancho = item.Width;
                adornosJson.fijadoAdorno = item.fijadoAdorno;
                adornosJson.locationX = item.Location.X;
                adornosJson.locationY = item.Location.Y;
                adornosJson.pathImage = item.resourceImageName;
                adornosJson.idAdorno = item.idAdorno;
                adornosJson.rotateFlip = item.rotateFlip;
                GestionJson.adornosJsonList.Add(adornosJson);
            }
        }
        /**FIN de Transformo y guardo las mesas y adornos**/

        /**Llamo metodos para guardar en Json el plano actual**/
        private void GuardarBt_Click(object sender, EventArgs e)
        {
            SueloJson sueloJson = new SueloJson();
            sueloJson.nombre = nombrePlanoTb.Text;
            sueloJson.altura = pisoPb.Height;
            sueloJson.ancho = pisoPb.Width;
            sueloJson.locationx = pisoPb.Location.X;
            sueloJson.locationy = pisoPb.Location.Y;
            sueloJson.backColor = pisoPb.BackColor.ToArgb();
            GestionJson.suelosListJson.Add(sueloJson);
            TransformarGuardarAdornos();
            TransformarGuardarMesas();
            GestionJson.GuardarAdornos();
            GestionJson.GuardarPlanosJson();
            GestionJson.GuardarMesas();
            MessageBox.Show("El plano se guardo con Exito","Guardado Exitoso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        /**Borro Mesas y Adornos**/
        public void BorrarMesas(Button mesasBorrar) {
            for (int i = 0; i < buttonMesaList.Count; i++)
            {
                if (buttonMesaList[i].numeroMesa.ToString() == mesasBorrar.Text)
                {
                    buttonMesaList.Remove(buttonMesaList[i]);
                }
            }
            this.Controls.Remove(mesasBorrar);
            mesasBorrar.Dispose();
        }
        public void BorrarAdornos(PictureBox adornoBorrar)
        {
            if (this.Contains(adornoBorrar))
            {
                Console.WriteLine("Lo encontre es: Mesa > " + adornoBorrar.Text);
            }
            this.Controls.Remove(adornoBorrar);
            adornoBorrar.Dispose();
        }
        /**FIN de Borro Mesas y Adornos**/

        /**Creo y paso parametros de mesas y adornos**/
        private void Mesa2SillasBt_Click(object sender, EventArgs e)
        {
            CrearMesas(1,20,30);
        }
        private void Mesa6SillasBt_Click(object sender, EventArgs e)
        {
            CrearMesas(3,30,50);
        }
        private void Mesa4SillasBt_Click(object sender, EventArgs e)
        {
            CrearMesas(2,30,40);
        }
        private void Mesa8SillasBt_Click(object sender, EventArgs e)
        {
            CrearMesas(4,30,60);
        }
        private void MesaRedondaBtn_Click(object sender, EventArgs e)
        {
            CrearMesas(5, 35, 35);
        }
        private void BarBtn_Click(object sender, EventArgs e)
        {
            CrearAdornos(30,60,9);
        }
        private void PuertaPb_Click(object sender, EventArgs e)
        {
            CrearAdornos(20,20,6);
        }
        private void InodoroBtn_Click(object sender, EventArgs e)
        {
            CrearAdornos(25, 20, 7);
        }
        private void LavaManosBtn_Click(object sender, EventArgs e)
        {
            CrearAdornos(20, 20, 8);
        }
        private void ParedBt_Click(object sender, EventArgs e)
        {
            CrearAdornos(5,30,5);
        }
        private void MacetaVerdeBt_Click(object sender, EventArgs e)
        {
            CrearAdornos(10, 10, 1);
        }
        private void MacetaVerdeFloresBt_Click(object sender, EventArgs e)
        {
            CrearAdornos(10,10,2);
        }
        private void MacetaRosa_Click(object sender, EventArgs e)
        {
            CrearAdornos(10,10,4);
        }
        private void MacetaVariasPlantasBt_Click(object sender, EventArgs e)
        {
            CrearAdornos(7,30,3);
        }
        /**FIN de Creo y paso parametros de mesas y adornos**/

        private void SalirBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.formList[0].Show();
            this.Hide();
        }
        private void VovlerMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
