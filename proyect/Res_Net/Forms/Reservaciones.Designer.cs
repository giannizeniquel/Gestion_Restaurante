namespace Res_Net.Forms
{
    partial class Reservaciones
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservaciones));
            this.reservacionesDg = new System.Windows.Forms.DataGridView();
            this.buscadorTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numMesaTb = new System.Windows.Forms.TextBox();
            this.horaTb = new System.Windows.Forms.TextBox();
            this.contactoTb = new System.Windows.Forms.TextBox();
            this.nombreClienteTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.fechaDtp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.reservarBt = new System.Windows.Forms.Button();
            this.cancelarBt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reservacionMesasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionMesasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reservacionesDg
            // 
            this.reservacionesDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.reservacionesDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reservacionesDg.Location = new System.Drawing.Point(12, 100);
            this.reservacionesDg.Name = "reservacionesDg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.reservacionesDg.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reservacionesDg.Size = new System.Drawing.Size(730, 150);
            this.reservacionesDg.TabIndex = 0;
            // 
            // buscadorTb
            // 
            this.buscadorTb.Location = new System.Drawing.Point(12, 74);
            this.buscadorTb.Name = "buscadorTb";
            this.buscadorTb.Size = new System.Drawing.Size(199, 20);
            this.buscadorTb.TabIndex = 1;
            this.buscadorTb.TextChanged += new System.EventHandler(this.BuscadorTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            // 
            // numMesaTb
            // 
            this.numMesaTb.Location = new System.Drawing.Point(17, 335);
            this.numMesaTb.Name = "numMesaTb";
            this.numMesaTb.Size = new System.Drawing.Size(165, 20);
            this.numMesaTb.TabIndex = 3;
            this.numMesaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.NumMesaTb_KeyPress);
            // 
            // horaTb
            // 
            this.horaTb.Location = new System.Drawing.Point(228, 335);
            this.horaTb.Name = "horaTb";
            this.horaTb.Size = new System.Drawing.Size(100, 20);
            this.horaTb.TabIndex = 4;
            this.horaTb.TextChanged += new System.EventHandler(this.HoraTb_TextChanged);
            this.horaTb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HoraTb_KeyPress);
            // 
            // contactoTb
            // 
            this.contactoTb.Location = new System.Drawing.Point(228, 395);
            this.contactoTb.Name = "contactoTb";
            this.contactoTb.Size = new System.Drawing.Size(100, 20);
            this.contactoTb.TabIndex = 5;
            // 
            // nombreClienteTb
            // 
            this.nombreClienteTb.Location = new System.Drawing.Point(17, 395);
            this.nombreClienteTb.Name = "nombreClienteTb";
            this.nombreClienteTb.Size = new System.Drawing.Size(155, 20);
            this.nombreClienteTb.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Numero de mesa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(454, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(269, 57);
            this.label3.TabIndex = 10;
            this.label3.Text = "RESTO .NET";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.label4.Location = new System.Drawing.Point(522, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 36);
            this.label4.TabIndex = 11;
            this.label4.Text = "Reservaciones";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 367);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(223, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Contacto";
            // 
            // fechaDtp
            // 
            this.fechaDtp.Location = new System.Drawing.Point(17, 466);
            this.fechaDtp.Name = "fechaDtp";
            this.fechaDtp.Size = new System.Drawing.Size(200, 20);
            this.fechaDtp.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 429);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 25);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fecha";
            // 
            // reservarBt
            // 
            this.reservarBt.ForeColor = System.Drawing.Color.Black;
            this.reservarBt.Location = new System.Drawing.Point(12, 547);
            this.reservarBt.Name = "reservarBt";
            this.reservarBt.Size = new System.Drawing.Size(75, 23);
            this.reservarBt.TabIndex = 17;
            this.reservarBt.Text = "Reservar";
            this.reservarBt.UseVisualStyleBackColor = true;
            this.reservarBt.Click += new System.EventHandler(this.ReservarBt_Click);
            // 
            // cancelarBt
            // 
            this.cancelarBt.ForeColor = System.Drawing.Color.Black;
            this.cancelarBt.Location = new System.Drawing.Point(122, 547);
            this.cancelarBt.Name = "cancelarBt";
            this.cancelarBt.Size = new System.Drawing.Size(75, 23);
            this.cancelarBt.TabIndex = 18;
            this.cancelarBt.Text = "Quitar";
            this.cancelarBt.UseVisualStyleBackColor = true;
            this.cancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.pictureBox1.BackgroundImage = global::Res_Net.Properties.Resources.Logo_ResNet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(464, 256);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 230);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // reservacionMesasBindingSource
            // 
            this.reservacionMesasBindingSource.DataSource = typeof(Res_Net.Script.ReservacionMesas);
            // 
            // Reservaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(751, 582);
            this.Controls.Add(this.cancelarBt);
            this.Controls.Add(this.reservarBt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.fechaDtp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nombreClienteTb);
            this.Controls.Add(this.contactoTb);
            this.Controls.Add(this.horaTb);
            this.Controls.Add(this.numMesaTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscadorTb);
            this.Controls.Add(this.reservacionesDg);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(205)))), ((int)(((byte)(46)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Reservaciones";
            this.Text = "Reservaciones";
            this.Load += new System.EventHandler(this.Reservaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reservacionesDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservacionMesasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView reservacionesDg;
        private System.Windows.Forms.TextBox buscadorTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numMesaTb;
        private System.Windows.Forms.TextBox horaTb;
        private System.Windows.Forms.TextBox contactoTb;
        private System.Windows.Forms.TextBox nombreClienteTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker fechaDtp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button reservarBt;
        private System.Windows.Forms.Button cancelarBt;
        private System.Windows.Forms.BindingSource reservacionMesasBindingSource;
    }
}