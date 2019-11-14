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

namespace Res_Net.Forms
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void NuevoPlanoBt_Click(object sender, EventArgs e)
        {
            GestionJson.adornosJsonList.Clear();
            GestionJson.mesasJson.Clear();
            GestionJson.GuardarAdornos();
            GestionJson.GuardarMesas();
            DiseniarPlanos dp = new DiseniarPlanos();
            this.Hide();
            dp.Show();
        }

        private void GestionarPlanoBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.simulacionOn = 1;
            GestionDeMesas gm = new GestionDeMesas();
            this.Hide();
            gm.Show();
        }

        private void SalirBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CargarPlanoBt_Click(object sender, EventArgs e)
        {
            DatosEstaticos.simulacionOn = 2;
            GestionDeMesas gm = new GestionDeMesas();
            this.Hide();
            gm.Show();
        }
    }
}
