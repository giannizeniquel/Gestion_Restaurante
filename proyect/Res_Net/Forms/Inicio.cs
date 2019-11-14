using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Res_Net.Forms
{
    public partial class Inicio : Form
    {
        int count = 4;
        public Inicio()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (cargaPb.Value == 100)
            {
                this.Opacity -= 0.7;
                if (this.Opacity == 0.0)
                {
                    this.Close();
                    this.Parent.Visible = true; 
                    timer1.Stop();
                    timer1.Enabled = false;
                }
            }
            else {
                cargaPb.Value += 4;
                if (cargaPb.Value == count + 16) {
                    count += 20;
                }
                if (cargaPb.Value == 28) {

                }
            }

        }
    }
}
