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
    public partial class ProductosForm : Form
    {
        private BindingSource productoBindingSource = new BindingSource();
        private BindingSource productoSeleccionadosBindingSource = new BindingSource();
        public ProductosForm()
        {
            InitializeComponent();
            foreach (Productos item in DatosEstaticos.productosList)
            {
                productoBindingSource.Add(item);
            }
            productosDg.DataSource = productoBindingSource;
            productosSeleccionadosDg.DataSource = productoSeleccionadosBindingSource;
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BuscarTb_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void BuscarProducto() {
            if (!string.IsNullOrWhiteSpace(buscarTb.Text))
            {
                List<Productos> tempList = new List<Productos>();
                productoBindingSource.Clear();
                for (int i = 0; i < DatosEstaticos.productosList.Count; i++)
                {
                    if ((DatosEstaticos.productosList[i].nombre.ToUpper()).IndexOf(buscarTb.Text.ToUpper()) == 0)
                    {
                        productoBindingSource.Add(DatosEstaticos.productosList[i]);
                    }
                    if ((DatosEstaticos.productosList[i].descripcion.ToUpper()).IndexOf(buscarTb.Text.ToUpper()) == 0)
                    {
                        productoBindingSource.Add(DatosEstaticos.productosList[i]);
                    }
                }
                //productosDg.DataSource = productoBindingSource;
            }
            else {
                productoBindingSource.Clear();
                foreach (Productos item in DatosEstaticos.productosList)
                {
                    productoBindingSource.Add(item);
                }
                productosDg.DataSource = productoBindingSource;
            }
        }

        private void AgregarBt_Click(object sender, EventArgs e)
        {
            if (DatosEstaticos.fichaSeleccionada != null) {
                Productos p = (Productos)productoBindingSource.Current;
                if (p != null) {
                    DatosEstaticos.fichaSeleccionada.productos.Add(p);
                    productoSeleccionadosBindingSource.Add(p);
                }
            }
        }

        private void QuitarProductosBtn_Click(object sender, EventArgs e)
        {
            Productos p = (Productos)productoSeleccionadosBindingSource.Current;
            DatosEstaticos.fichaSeleccionada.productos.Remove(p);
            productoSeleccionadosBindingSource.Remove(p);
        }

        private void AceptarProductosBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            GestionDeMesas gm = (GestionDeMesas)Form.ActiveForm;
            gm.RellenarProductos();
        }
    }
}
