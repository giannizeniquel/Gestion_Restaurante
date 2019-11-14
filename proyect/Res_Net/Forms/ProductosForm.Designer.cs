namespace Res_Net.Forms
{
    partial class ProductosForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductosForm));
            this.productosDg = new System.Windows.Forms.DataGridView();
            this.buscarTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.agregarBt = new System.Windows.Forms.Button();
            this.productosSeleccionadosDg = new System.Windows.Forms.DataGridView();
            this.aceptarProductosBtn = new System.Windows.Forms.Button();
            this.quitarProductosBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productosDg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSeleccionadosDg)).BeginInit();
            this.SuspendLayout();
            // 
            // productosDg
            // 
            this.productosDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productosDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productosDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosDg.Location = new System.Drawing.Point(6, 50);
            this.productosDg.Name = "productosDg";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productosDg.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.productosDg.Size = new System.Drawing.Size(601, 150);
            this.productosDg.TabIndex = 0;
            // 
            // buscarTb
            // 
            this.buscarTb.Location = new System.Drawing.Point(120, 24);
            this.buscarTb.Name = "buscarTb";
            this.buscarTb.Size = new System.Drawing.Size(363, 20);
            this.buscarTb.TabIndex = 1;
            this.buscarTb.TextChanged += new System.EventHandler(this.BuscarTb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.label1.Location = new System.Drawing.Point(280, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // agregarBt
            // 
            this.agregarBt.BackColor = System.Drawing.Color.SteelBlue;
            this.agregarBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarBt.ForeColor = System.Drawing.Color.PaleGreen;
            this.agregarBt.Location = new System.Drawing.Point(285, 206);
            this.agregarBt.Name = "agregarBt";
            this.agregarBt.Size = new System.Drawing.Size(75, 23);
            this.agregarBt.TabIndex = 3;
            this.agregarBt.Text = "Agregar";
            this.agregarBt.UseVisualStyleBackColor = false;
            this.agregarBt.Click += new System.EventHandler(this.AgregarBt_Click);
            // 
            // productosSeleccionadosDg
            // 
            this.productosSeleccionadosDg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.productosSeleccionadosDg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.productosSeleccionadosDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosSeleccionadosDg.Location = new System.Drawing.Point(6, 254);
            this.productosSeleccionadosDg.Name = "productosSeleccionadosDg";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productosSeleccionadosDg.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.productosSeleccionadosDg.Size = new System.Drawing.Size(601, 150);
            this.productosSeleccionadosDg.TabIndex = 4;
            // 
            // aceptarProductosBtn
            // 
            this.aceptarProductosBtn.BackColor = System.Drawing.Color.DarkGreen;
            this.aceptarProductosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptarProductosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.aceptarProductosBtn.Location = new System.Drawing.Point(532, 461);
            this.aceptarProductosBtn.Name = "aceptarProductosBtn";
            this.aceptarProductosBtn.Size = new System.Drawing.Size(75, 23);
            this.aceptarProductosBtn.TabIndex = 5;
            this.aceptarProductosBtn.Text = "Aceptar";
            this.aceptarProductosBtn.UseVisualStyleBackColor = false;
            this.aceptarProductosBtn.Click += new System.EventHandler(this.AceptarProductosBtn_Click);
            // 
            // quitarProductosBtn
            // 
            this.quitarProductosBtn.BackColor = System.Drawing.Color.Crimson;
            this.quitarProductosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitarProductosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(158)))), ((int)(((byte)(40)))));
            this.quitarProductosBtn.Location = new System.Drawing.Point(285, 410);
            this.quitarProductosBtn.Name = "quitarProductosBtn";
            this.quitarProductosBtn.Size = new System.Drawing.Size(75, 23);
            this.quitarProductosBtn.TabIndex = 6;
            this.quitarProductosBtn.Text = "Quitar";
            this.quitarProductosBtn.UseVisualStyleBackColor = false;
            this.quitarProductosBtn.Click += new System.EventHandler(this.QuitarProductosBtn_Click);
            // 
            // ProductosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(46)))), ((int)(((byte)(27)))));
            this.ClientSize = new System.Drawing.Size(619, 496);
            this.Controls.Add(this.quitarProductosBtn);
            this.Controls.Add(this.aceptarProductosBtn);
            this.Controls.Add(this.productosSeleccionadosDg);
            this.Controls.Add(this.agregarBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buscarTb);
            this.Controls.Add(this.productosDg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProductosForm";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.ProductosForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosDg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosSeleccionadosDg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productosDg;
        private System.Windows.Forms.TextBox buscarTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button agregarBt;
        private System.Windows.Forms.DataGridView productosSeleccionadosDg;
        private System.Windows.Forms.Button aceptarProductosBtn;
        private System.Windows.Forms.Button quitarProductosBtn;
    }
}