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
    public partial class GestionDeMesas : Form
    {
        private BindingSource productoBindingSource = new BindingSource();
        private BindingSource mozosBindingSource = new BindingSource();
        Simulacion simulacion = new Simulacion();
        private List<ButtonMesa> simulacionListMesa = new List<ButtonMesa>();
        private InstanciasObject iniObject = new InstanciasObject();
        public GestionDeMesas()
        {
            InitializeComponent();
        }
        /**Cargamos el form dependiendo si es simulacion o no**/
        private void GestionDeMesas_Load(object sender, EventArgs e)
        {
            if (DatosEstaticos.simulacionOn == 1) {
                CargaJsonNoSimulacion();
                CargarPlanoIni();
                asignarMozoCb.DataSource = mozosBindingSource;
                cambiarMozoBt.Visible = false;
                mozoAsignadoLb.Visible = false;
                generarTiketBtn.Visible = false;
                agregarProdBtn.Visible = false;
                totalPagoLb.Text = "";
                totalPagoLb.Visible = false;
            } else if (DatosEstaticos.simulacionOn == 2) {
                simulacionListMesa.Clear();
                CargaJsonSimulacion();
                //CargarSimulacionMesas();
                CargarPlanoIni();
                ComprMesaOcupada();
                asignarMozoCb.DataSource = mozosBindingSource;
                asignarMozoCb.Visible = false;
                cambiarMozoBt.Visible = false;
                mozoAsignadoLb.Text = DatosEstaticos.fichasMesas[0].mozoAsignado;
                generarTiketBtn.Visible = false;
                agregarProdBtn.Visible = false;
                totalPagoLb.Text = "";
                totalPagoLb.Visible = false;
                nombreClienteTb.Text = DatosEstaticos.fichasMesas[0].nombreCliente;
                nombreClienteTb.Enabled = false;
                DatosEstaticos.fichaSeleccionada = DatosEstaticos.fichasMesas[0];
                CambioOcupadoLibre();
            }

        }

        /**Inicializamos el Plano con todos sus elementos (Mesas y adornos)**/

        private void CargarPlanoIni() {
            //Inicializamos el piso (picturebox)
            PictureBox piso = iniObject.IniPisoPlano(0);
            Point point = new Point(GestionJson.sueloTestJson[0].locationx, GestionJson.sueloTestJson[0].locationy);
            piso.Parent = pisoPanel;
            piso.Location = point;
            piso.Show();
            piso.BringToFront();
            // Inicializamos Las mesas
            for (int i = 0; i < GestionJson.mesasJson.Count; i++)
            {
                ButtonMesa btnMesa = iniObject.IniMesasPlano(i);
                btnMesa.Parent = pisoPanel;
                Point point1 = new Point(GestionJson.mesasJson[i].locationx, GestionJson.mesasJson[i].locationy);
                btnMesa.Location = point1;
                simulacionListMesa.Add(btnMesa);
                btnMesa.BringToFront();
            }
            //Inicializamos los adornos
            if (GestionJson.adornosJsonList.Count > 0) {
                for (int i = 0; i < GestionJson.adornosJsonList.Count; i++)
                {
                    PictureAdornos adornoPic = iniObject.IniAdornos(i);
                    adornoPic.Parent = pisoPanel;
                    Point point1 = new Point(GestionJson.adornosJsonList[i].locationX, GestionJson.adornosJsonList[i].locationY);
                    adornoPic.Location = point1;
                    adornoPic.BackColor = piso.BackColor;                    
                    adornoPic.BringToFront();
                }
            }
            //Cargamos por memoria los Mozos al bindingsource
            for (int i = 0; i < DatosEstaticos.mozosList.Count; i++)
            {
                mozosBindingSource.Add(DatosEstaticos.mozosList[i]);
            }
        }
        //Cargamos las listas dependiendo si es simulacion o no
        private void CargaJsonNoSimulacion() {
            GestionJson.CargarPlanosJson();
            GestionJson.CargarMesasJson();
            GestionJson.CargarAdornos();
        }
        private void CargaJsonSimulacion() {

            GestionJson.adornosJsonList.Clear();
            GestionJson.mesasJson.Clear();
            GestionJson.CargarPisoSimulacionJson();
            GestionJson.CargarAdornosSimulacion();
            GestionJson.CargarMesasSimulacionJson();
            simulacion.EstadoActual("09:10");
        }


        /** -SIMULACION- **/
        //Comprobamos Reservaciones en la simulacion
        public void ComprobarReservacion() {
            if (!string.IsNullOrWhiteSpace(relogSimuTb.Text)) {
                string telString = relogSimuTb.Text.Remove(2, 1);
                int HoraActualInt = int.Parse(telString);

                foreach (ReservacionMesas item in DatosEstaticos.reservacionesList)
                {
                    foreach (FichasMesas fichas in DatosEstaticos.fichasMesas)
                    {
                        if (item.numMesa == fichas.numMesa)
                        {
                            string reserSt = item.hora.Remove(2, 1);
                            int ResHora = int.Parse(reserSt);

                            if ( HoraActualInt < ResHora + 101 && HoraActualInt > ResHora - 101)
                            {
                                foreach (ButtonMesa mesa in simulacionListMesa)
                                {
                                    if (mesa.numeroMesa == item.numMesa)
                                    {
                                        mesa.BackColor = Color.Yellow;
                                    }
                                }
                            }
                        }
                    }         
                }
            }
        }
        //Comprobamos Ocupacion en la simulacion
        /**Fin de simulacion**/

            /**Comprobaciones Altas y bajas**/
        //Boton Aceptar para dar de alta
        private void Button1_Click(object sender, EventArgs e)
        {
            if (DatosEstaticos.fichaSeleccionada != null) {
                if (!string.IsNullOrWhiteSpace(DatosEstaticos.fichaSeleccionada.mozoAsignado))
                {
                    if (!string.IsNullOrWhiteSpace(nombreClienteTb.Text))
                    {
                        if (string.IsNullOrWhiteSpace(relogSimuTb.Text))
                        {
                            DatosEstaticos.fichaSeleccionada.hora = DateTime.Today.ToShortTimeString();
                        }
                        else
                        {
                            DatosEstaticos.fichaSeleccionada.hora = relogSimuTb.Text;
                        }
                        DatosEstaticos.fichaSeleccionada.fecha = DateTime.Today;
                        DatosEstaticos.fichaSeleccionada.nombreCliente = nombreClienteTb.Text;
                        nombreClienteTb.Enabled = false;
                        DatosEstaticos.mesaSeleccionada.BackColor = Color.Red;
                        DatosEstaticos.mesaSeleccionada.FlatAppearance.BorderColor = Color.Red;
                        DatosEstaticos.fichaSeleccionada.ocupada = true;
                        aceptarBt.Visible = false;
                        generarTiketBtn.Visible = true;
                        totalPagoLb.Visible = true;
                        agregarProdBtn.Visible = true;
                        CambioOcupadoLibre();
                    }
                    else
                    {
                        MessageBox.Show("Ingrese Nombre del cliente", "Faltan Valores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Debe haber un mozo encargado de la mesa", "Faltan Valores", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        //Comprobacion y cambio de color de las mesas y fichas en ocupacion
        private void ComprMesaOcupada() {
            for (int i = 0; i < simulacionListMesa.Count; i++)
            {
                foreach (FichasMesas item in DatosEstaticos.fichasMesas)
                {
                    if (item.numMesa == simulacionListMesa[i].numeroMesa)
                    {
                        if (item.ocupada)
                        {
                            simulacionListMesa[i].BackColor = Color.Red;
                        }
                        else
                        {
                            simulacionListMesa[i].BackColor = Color.Green;
                        }
                    }
                }
            }
        }    
        private void CambioOcupadoLibre() {
            if (!DatosEstaticos.fichaSeleccionada.ocupada)
            {
                generarTiketBtn.Visible = false;
                aceptarBt.Visible = true;
                agregarProdBtn.Visible = false;
                ocupadoLb.Text = "LIBRE";
                ocupadoLb.ForeColor = Color.Green;
            }
            else
            {
                agregarProdBtn.Visible = true;
                generarTiketBtn.Visible = true;
                aceptarBt.Visible = false;
                ocupadoLb.Text = "OCUPADO";
                ocupadoLb.ForeColor = Color.Red;
            }
        }
        //Relleno de productos a los grid de las fichas
        public void RellenarProductos() {
            float totalPagar = 0;
            if (DatosEstaticos.fichaSeleccionada != null) {
                productoBindingSource.Clear();
                foreach (var item in DatosEstaticos.fichaSeleccionada.productos)
                {
                    totalPagar += item.precio;
                    productoBindingSource.Add(item);
                }
                productosClienteDg.DataSource = productoBindingSource;
                totalPagoLb.Text = totalPagar.ToString();
            }
        }
        //Muestra la ficha de la mesa seleccionada
        public void MostrarMesaSeleccionada(){
            float totalPagar = 0;
            if (DatosEstaticos.simulacionOn == 2) {
   
            }
            CambioOcupadoLibre();
            if (DatosEstaticos.fichaSeleccionada != null) {
                numMesaLb.Text = DatosEstaticos.fichaSeleccionada.numMesa.ToString();
                mozoAsignadoLb.Text = DatosEstaticos.fichaSeleccionada.mozoAsignado;
                nombreClienteTb.Text = DatosEstaticos.fichaSeleccionada.nombreCliente;
                RellenarProductos();
                if (string.IsNullOrEmpty(DatosEstaticos.fichaSeleccionada.mozoAsignado))
                {
                    cambiarMozoBt.Visible = false;
                    mozoAsignadoLb.Visible = false;
                    asignarMozoCb.Visible = true;
                    aceptarMozoBtn.Visible = true;
                }
                else {   
                    asignarMozoCb.Visible = false;
                    mozoAsignadoLb.Visible = true;
                    mozoAsignadoLb.Text = DatosEstaticos.fichaSeleccionada.mozoAsignado;
                    aceptarMozoBtn.Visible = false;
                    cambiarMozoBt.Visible = true;
                }
            }

        }
        /**Fin de Comprobaciones altas y bajas**/

            /**Instancias de forms**/
            //Instanciamos el form reservacion
        private void ReservacionBt_Click(object sender, EventArgs e)
        {
            Reservaciones reserv = new Reservaciones();
            reserv.Show();
        }
        //Instanciamos el form productos para agregarlos
        private void Button2_Click(object sender, EventArgs e)
        {
            ProductosForm pf = new ProductosForm();
            pf.Show();
        }
        /**Fin de instancias de forms**/

            /**Cambiamos mozos asignados**/
        private void CambiarMozo() {
            if (DatosEstaticos.fichaSeleccionada != null)
            {
                DatosEstaticos.fichaSeleccionada.mozoAsignado = (string)mozosBindingSource.Current;
                asignarMozoCb.Visible = false;
                mozoAsignadoLb.Visible = true;
                mozoAsignadoLb.Text = (string)mozosBindingSource.Current;
                aceptarMozoBtn.Visible = false;
                cambiarMozoBt.Visible = true;
            }
        }
        private void AceptarMozoBtn_Click(object sender, EventArgs e)
        {
            CambiarMozo();
        }
        private void CambiarMozoBt_Click(object sender, EventArgs e)
        {
            cambiarMozoBt.Visible = false;
            mozoAsignadoLb.Visible = false;
            asignarMozoCb.Visible = true;
            aceptarMozoBtn.Visible = true;
        }
        /**Fin de cambio de mozos**/

            //Generamos ticket y cambiamos la mesa a libre
        private void GenerarTiketBtn_Click(object sender, EventArgs e)
        {
            Tickets t = new Tickets();
            DatosEstaticos.fichaSeleccionada.nombreCliente = "";
            totalPagoLb.Visible = false;
            agregarProdBtn.Visible = false;
            nombreClienteTb.Enabled = true;
            Console.WriteLine(t.linea);
            nombreClienteTb.Clear();
            DatosEstaticos.mesaSeleccionada.BackColor = Color.Green;
            DatosEstaticos.mesaSeleccionada.FlatAppearance.BorderColor = Color.Green;
            DatosEstaticos.fichaSeleccionada.ocupada = false;
            aceptarBt.Visible = true;
            generarTiketBtn.Visible = false;
            productoBindingSource.Clear();
            DatosEstaticos.fichaSeleccionada.productos.Clear();
            CambioOcupadoLibre();
        }


        /**Relog de simulacion (Modifica los eventos de la simulacion)**/
        private void AceptarHorarioBtn_Click(object sender, EventArgs e)
        {
            simulacion.EstadoActual(relogSimuTb.Text);           
            ComprMesaOcupada();
            ComprobarReservacion();

        }
        //Comprobamos que el formato de la hora sea el que deseamos
        private void RelogSimuTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
            string nuevaHora = relogSimuTb.Text;

            if (nuevaHora.Length == 3)
            {
                nuevaHora = nuevaHora.Insert(2, ":");
                relogSimuTb.Text = nuevaHora;
                relogSimuTb.Select(relogSimuTb.Text.Length, 0);
            }
            if (nuevaHora.Length == 5)
            {
                e.Handled = true;
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    relogSimuTb.ResetText();
                }
            }
        }


        private void MenuPrincipal_Click(object sender, EventArgs e)
        {
            DatosEstaticos.formList[0].Show();
            this.Hide();
        }
    }
}
