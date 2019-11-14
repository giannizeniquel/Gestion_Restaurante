namespace Res_Net.Forms
{
    partial class GestionDeMesas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GestionDeMesas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.aceptarMozoBtn = new System.Windows.Forms.Button();
            this.asignarMozoCb = new System.Windows.Forms.ComboBox();
            this.generarTiketBtn = new System.Windows.Forms.Button();
            this.ocupadoLb = new System.Windows.Forms.Label();
            this.totalPagoLb = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.agregarProdBtn = new System.Windows.Forms.Button();
            this.aceptarBt = new System.Windows.Forms.Button();
            this.productosClienteDg = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.nombreClienteTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cambiarMozoBt = new System.Windows.Forms.Button();
            this.mozoAsignadoLb = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numMesaLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.reservacionBt = new System.Windows.Forms.Button();
            this.pisoPanel = new System.Windows.Forms.Panel();
            this.relogSimuTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.menuPrincipal = new System.Windows.Forms.Button();
            this.AceptarHorarioBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosClienteDg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.panel1.Controls.Add(this.aceptarMozoBtn);
            this.panel1.Controls.Add(this.asignarMozoCb);
            this.panel1.Controls.Add(this.generarTiketBtn);
            this.panel1.Controls.Add(this.ocupadoLb);
            this.panel1.Controls.Add(this.totalPagoLb);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.agregarProdBtn);
            this.panel1.Controls.Add(this.aceptarBt);
            this.panel1.Controls.Add(this.productosClienteDg);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.nombreClienteTb);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cambiarMozoBt);
            this.panel1.Controls.Add(this.mozoAsignadoLb);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numMesaLb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(205)))), ((int)(((byte)(46)))));
            this.panel1.Location = new System.Drawing.Point(7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(422, 688);
            this.panel1.TabIndex = 0;
            // 
            // aceptarMozoBtn
            // 
            this.aceptarMozoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.aceptarMozoBtn.BackgroundImage = global::Res_Net.Properties.Resources.Check_Marquer;
            this.aceptarMozoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.aceptarMozoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarMozoBtn.Font = new System.Drawing.Font("Wingdings 2", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.aceptarMozoBtn.ForeColor = System.Drawing.Color.Black;
            this.aceptarMozoBtn.Location = new System.Drawing.Point(297, 59);
            this.aceptarMozoBtn.Name = "aceptarMozoBtn";
            this.aceptarMozoBtn.Size = new System.Drawing.Size(25, 23);
            this.aceptarMozoBtn.TabIndex = 27;
            this.aceptarMozoBtn.UseVisualStyleBackColor = false;
            this.aceptarMozoBtn.Click += new System.EventHandler(this.AceptarMozoBtn_Click);
            // 
            // asignarMozoCb
            // 
            this.asignarMozoCb.FormattingEnabled = true;
            this.asignarMozoCb.Location = new System.Drawing.Point(154, 59);
            this.asignarMozoCb.Name = "asignarMozoCb";
            this.asignarMozoCb.Size = new System.Drawing.Size(137, 21);
            this.asignarMozoCb.TabIndex = 26;
            // 
            // generarTiketBtn
            // 
            this.generarTiketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.generarTiketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generarTiketBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.generarTiketBtn.Location = new System.Drawing.Point(165, 217);
            this.generarTiketBtn.Name = "generarTiketBtn";
            this.generarTiketBtn.Size = new System.Drawing.Size(92, 36);
            this.generarTiketBtn.TabIndex = 21;
            this.generarTiketBtn.Text = "Generar Ticket";
            this.generarTiketBtn.UseVisualStyleBackColor = false;
            this.generarTiketBtn.Click += new System.EventHandler(this.GenerarTiketBtn_Click);
            // 
            // ocupadoLb
            // 
            this.ocupadoLb.AutoSize = true;
            this.ocupadoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ocupadoLb.Location = new System.Drawing.Point(314, 3);
            this.ocupadoLb.Name = "ocupadoLb";
            this.ocupadoLb.Size = new System.Drawing.Size(102, 24);
            this.ocupadoLb.TabIndex = 20;
            this.ocupadoLb.Text = "OCUPADA";
            // 
            // totalPagoLb
            // 
            this.totalPagoLb.AutoSize = true;
            this.totalPagoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPagoLb.Location = new System.Drawing.Point(203, 547);
            this.totalPagoLb.Name = "totalPagoLb";
            this.totalPagoLb.Size = new System.Drawing.Size(40, 18);
            this.totalPagoLb.TabIndex = 19;
            this.totalPagoLb.Text = "1000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(140, 547);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "Total: $";
            // 
            // agregarProdBtn
            // 
            this.agregarProdBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.agregarProdBtn.Location = new System.Drawing.Point(154, 568);
            this.agregarProdBtn.Name = "agregarProdBtn";
            this.agregarProdBtn.Size = new System.Drawing.Size(75, 23);
            this.agregarProdBtn.TabIndex = 17;
            this.agregarProdBtn.Text = "Añadir";
            this.agregarProdBtn.UseVisualStyleBackColor = true;
            this.agregarProdBtn.Click += new System.EventHandler(this.Button2_Click);
            // 
            // aceptarBt
            // 
            this.aceptarBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.aceptarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.aceptarBt.Location = new System.Drawing.Point(9, 169);
            this.aceptarBt.Name = "aceptarBt";
            this.aceptarBt.Size = new System.Drawing.Size(75, 23);
            this.aceptarBt.TabIndex = 16;
            this.aceptarBt.Text = "Aceptar";
            this.aceptarBt.UseVisualStyleBackColor = false;
            this.aceptarBt.Click += new System.EventHandler(this.Button1_Click);
            // 
            // productosClienteDg
            // 
            this.productosClienteDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosClienteDg.Location = new System.Drawing.Point(3, 300);
            this.productosClienteDg.Name = "productosClienteDg";
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.productosClienteDg.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productosClienteDg.Size = new System.Drawing.Size(413, 244);
            this.productosClienteDg.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 279);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Consumicion";
            // 
            // nombreClienteTb
            // 
            this.nombreClienteTb.Location = new System.Drawing.Point(9, 132);
            this.nombreClienteTb.Name = "nombreClienteTb";
            this.nombreClienteTb.Size = new System.Drawing.Size(197, 20);
            this.nombreClienteTb.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nombre del cliente";
            // 
            // cambiarMozoBt
            // 
            this.cambiarMozoBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.cambiarMozoBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarMozoBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.cambiarMozoBt.Location = new System.Drawing.Point(340, 59);
            this.cambiarMozoBt.Name = "cambiarMozoBt";
            this.cambiarMozoBt.Size = new System.Drawing.Size(75, 23);
            this.cambiarMozoBt.TabIndex = 4;
            this.cambiarMozoBt.Text = "Cambiar";
            this.cambiarMozoBt.UseVisualStyleBackColor = false;
            this.cambiarMozoBt.Click += new System.EventHandler(this.CambiarMozoBt_Click);
            // 
            // mozoAsignadoLb
            // 
            this.mozoAsignadoLb.AutoSize = true;
            this.mozoAsignadoLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mozoAsignadoLb.Location = new System.Drawing.Point(150, 56);
            this.mozoAsignadoLb.Name = "mozoAsignadoLb";
            this.mozoAsignadoLb.Size = new System.Drawing.Size(152, 24);
            this.mozoAsignadoLb.TabIndex = 3;
            this.mozoAsignadoLb.Text = "Mozo Asignado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mozo Asignado: ";
            // 
            // numMesaLb
            // 
            this.numMesaLb.AutoSize = true;
            this.numMesaLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numMesaLb.Location = new System.Drawing.Point(183, 3);
            this.numMesaLb.Name = "numMesaLb";
            this.numMesaLb.Size = new System.Drawing.Size(60, 42);
            this.numMesaLb.TabIndex = 1;
            this.numMesaLb.Text = "10";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mesa N°:";
            // 
            // reservacionBt
            // 
            this.reservacionBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.reservacionBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reservacionBt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.reservacionBt.Location = new System.Drawing.Point(354, 700);
            this.reservacionBt.Name = "reservacionBt";
            this.reservacionBt.Size = new System.Drawing.Size(75, 23);
            this.reservacionBt.TabIndex = 25;
            this.reservacionBt.Text = "Reservacion";
            this.reservacionBt.UseVisualStyleBackColor = false;
            this.reservacionBt.Click += new System.EventHandler(this.ReservacionBt_Click);
            // 
            // pisoPanel
            // 
            this.pisoPanel.Location = new System.Drawing.Point(429, 6);
            this.pisoPanel.Name = "pisoPanel";
            this.pisoPanel.Size = new System.Drawing.Size(650, 950);
            this.pisoPanel.TabIndex = 1;
            // 
            // relogSimuTb
            // 
            this.relogSimuTb.Location = new System.Drawing.Point(1085, 30);
            this.relogSimuTb.Name = "relogSimuTb";
            this.relogSimuTb.Size = new System.Drawing.Size(100, 20);
            this.relogSimuTb.TabIndex = 2;
            this.relogSimuTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.RelogSimuTb_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(1112, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Relog";
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.BackColor = System.Drawing.Color.Crimson;
            this.menuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuPrincipal.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.menuPrincipal.Location = new System.Drawing.Point(7, 700);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(96, 23);
            this.menuPrincipal.TabIndex = 4;
            this.menuPrincipal.Text = "Menu Principal";
            this.menuPrincipal.UseVisualStyleBackColor = false;
            this.menuPrincipal.Click += new System.EventHandler(this.MenuPrincipal_Click);
            // 
            // AceptarHorarioBtn
            // 
            this.AceptarHorarioBtn.Location = new System.Drawing.Point(1097, 63);
            this.AceptarHorarioBtn.Name = "AceptarHorarioBtn";
            this.AceptarHorarioBtn.Size = new System.Drawing.Size(75, 23);
            this.AceptarHorarioBtn.TabIndex = 26;
            this.AceptarHorarioBtn.Text = "Aceptar";
            this.AceptarHorarioBtn.UseVisualStyleBackColor = true;
            this.AceptarHorarioBtn.Click += new System.EventHandler(this.AceptarHorarioBtn_Click);
            // 
            // GestionDeMesas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(1284, 788);
            this.Controls.Add(this.AceptarHorarioBtn);
            this.Controls.Add(this.menuPrincipal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reservacionBt);
            this.Controls.Add(this.relogSimuTb);
            this.Controls.Add(this.pisoPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GestionDeMesas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion De Mesas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.GestionDeMesas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productosClienteDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label numMesaLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button agregarProdBtn;
        private System.Windows.Forms.Button aceptarBt;
        private System.Windows.Forms.DataGridView productosClienteDg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nombreClienteTb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label mozoAsignadoLb;
        private System.Windows.Forms.Button generarTiketBtn;
        private System.Windows.Forms.Label ocupadoLb;
        private System.Windows.Forms.Label totalPagoLb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pisoPanel;
        private System.Windows.Forms.Button reservacionBt;
        private System.Windows.Forms.Button aceptarMozoBtn;
        private System.Windows.Forms.ComboBox asignarMozoCb;
        private System.Windows.Forms.Button cambiarMozoBt;
        private System.Windows.Forms.TextBox relogSimuTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button menuPrincipal;
        private System.Windows.Forms.Button AceptarHorarioBtn;
    }
}