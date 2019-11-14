using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Res_Net.Forms;

namespace Res_Net.Script
{
    class ButtonMesa : Button
    {
        public int numeroMesa;
        public int cantidadSillas;
        public bool yacreadoBool;
        public bool fijado;
        private ContextMenuStrip contextMenuStrip1;
        private System.ComponentModel.IContainer components;
        private ToolStripMenuItem fijarTs;
        Point location;
       public string resourceImageName;

        public ButtonMesa(int numMesa,int height,int width,int cantidadSillas) {
            this.numeroMesa = numMesa;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Width = width;
            this.Height = height;
            this.cantidadSillas = cantidadSillas;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = this.BackColor;
            fijado = false;

            //**Context Menu **//
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijarTs = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fijarTs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(97, 26);
            // 
            // fijarTs
            // 
            this.fijarTs.Name = "fijarTs";
            this.fijarTs.Size = new System.Drawing.Size(96, 22);
            this.fijarTs.Text = "Fijar";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.fijarTs.Click += new System.EventHandler(this.fijarTs_Click);
            this.ContextMenuStrip = this.contextMenuStrip1;

            SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }
        
        private void InitializeComponent()
        {
 
        }
        protected void fijarTs_Click(object sender, EventArgs e) {
            fijado = !fijado;
        }
        protected override void OnClick(EventArgs e)
        {
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            location = mevent.Location;
            if (yacreadoBool)
            {
                this.ContextMenuStrip = null;
                foreach (FichasMesas item in DatosEstaticos.fichasMesas)
                {
                    if (item.numMesa == this.numeroMesa)
                    {
                        DatosEstaticos.fichaSeleccionada = item;
                        DatosEstaticos.mesaSeleccionada = this;
                    }
                }
                GestionDeMesas gm = (GestionDeMesas)Form.ActiveForm;
                gm.MostrarMesaSeleccionada();
            }
        }

        protected override void OnKeyDown(KeyEventArgs kevent)
        {
            if (kevent.KeyData == Keys.Delete)
            {
                DatosEstaticos.Borrados.Add(this.numeroMesa);
                for (int i = 0; i < GestionJson.mesasJson.Count; i++)
                {
                    if (GestionJson.mesasJson[i].numMesa == this.numeroMesa)
                    {
                        GestionJson.mesasJson.Remove(GestionJson.mesasJson[i]);
                    }
                }
                DiseniarPlanos dp = new DiseniarPlanos();
                dp = (DiseniarPlanos)Form.ActiveForm;
                dp.BorrarMesas(this);
            }
        }

        protected override void OnDoubleClick(EventArgs e)
        {
            int dh = this.Height;
            int dw = this.Width;
            this.Height = dw;
            this.Width = dh;
            this.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
    }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {

        }
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (!fijado) {
                base.OnMouseMove(mevent);
                if (mevent.Button == MouseButtons.Left)
                {
                    this.Left += mevent.X - location.X;
                    this.Top += mevent.Y - location.Y;
                }
            }

        }
    }
}
