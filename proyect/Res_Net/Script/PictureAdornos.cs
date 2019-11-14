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
    class PictureAdornos : PictureBox
    {
        public bool fijadoAdorno;
        private System.ComponentModel.IContainer components;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem fijadoTs;
        public string resourceImageName;
        private bool yacreadoBool;
        public int idAdorno;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem fijadoTs2;
        private ToolStripMenuItem borrarTs;
        private Point mousePoint;
        private Size startSize;
        private bool mouseDown;
        public byte rotateFlip;
        Point location;
        public PictureAdornos(int alto,int ancho) {
            this.rotateFlip = 0;
            this.Height = alto;
            this.Width = ancho;
            fijadoAdorno = false;
            //**Context Menu **//
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijadoTs = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.fijadoTs2 = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarTs = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fijadoTs2,
            this.borrarTs});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 48);
            // 
            // fijadoTs2
            // 
            this.fijadoTs2.Name = "fijadoTs2";
            this.fijadoTs2.Size = new System.Drawing.Size(106, 22);
            this.fijadoTs2.Text = "Fijado";
            this.fijadoTs2.Click += new System.EventHandler(this.fijadoTs_Click);

            // 
            // borrarTs
            // 
            this.borrarTs.Name = "borrarTs";
            this.borrarTs.Size = new System.Drawing.Size(106, 22);
            this.borrarTs.Text = "Borrar";
            this.contextMenuStrip1.ResumeLayout(false);
            this.borrarTs.Click += new System.EventHandler(this.borrarTs_Click);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

            this.ContextMenuStrip = this.contextMenuStrip1;
        }
        protected void fijadoTs_Click(object sender, EventArgs e)
        {
            fijadoAdorno = !fijadoAdorno;
        }
        //rotar
        protected override void OnDoubleClick(EventArgs e)
        {
            int dh = this.Height;
            int dw = this.Width;
            this.Height = dw;
            this.Width = dh;
            this.BackgroundImage.RotateFlip(RotateFlipType.Rotate90FlipXY);
            if (rotateFlip == 3)
            {
                rotateFlip = 0;
            }
            else {
                rotateFlip++;
            }
        }
        //cancela estirar
        protected override void OnMouseUp(MouseEventArgs e)
        {
            //base.OnMouseUp(e);
            if (e.Button == MouseButtons.Middle)
            {
                // suelta el mouse abajo
                this.mouseDown = false;
            }
        }
        protected void borrarTs_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < GestionJson.adornosJsonList.Count; i++)
            {
                if (GestionJson.adornosJsonList[i].idAdorno == this.idAdorno)
                {
                    GestionJson.adornosJsonList.Remove(GestionJson.adornosJsonList[i]);
                }
            }
            DiseniarPlanos dp = new DiseniarPlanos();
            dp = (DiseniarPlanos)Form.ActiveForm;
            dp.BorrarAdornos(this);
        }
        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            location = mevent.Location;
            if (mevent.Button == MouseButtons.Middle) { }
            {
                // ubicación del punto de inicio
                this.mousePoint = mevent.Location;

                // tamaño inicial
                this.startSize = this.Size;

                // el mouse esta abajo
                this.mouseDown = true;

            }
        }
        protected override void OnKeyDown(KeyEventArgs e)
        {
        }
        //mover o estirar
        protected override void OnMouseMove(MouseEventArgs mevent)
        {
            if (!fijadoAdorno)
            {
                base.OnMouseMove(mevent);
                if (mevent.Button == MouseButtons.Left)
                {
                    this.Left += mevent.X - location.X;
                    this.Top += mevent.Y - location.Y;
                }

                if (this.mouseDown && mevent.Button == MouseButtons.Middle)
                {
                    if (this.Width >= this.Height)
                    {
                        this.Width = mevent.X - this.mousePoint.X + this.startSize.Width;
                        if (this.Width == this.Height + 10)
                        {
                            this.Width = this.Width + 5;
                            OnMouseUp(mevent);
                        }
                    }
                    else
                    {
                        this.Height = mevent.Y - this.mousePoint.Y + this.startSize.Height;
                        if (this.Height == this.Width + 10)
                        {
                            this.Height = this.Height + 5;
                            OnMouseUp(mevent);
                        }
                    }
                }
            }
        }
            private void InitializeComponent()
        {
  

        }
    }
}
