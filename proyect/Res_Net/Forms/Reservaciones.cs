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
    public partial class Reservaciones : Form
    {
        int count = 0;
        BindingSource reservaBindingSource = new BindingSource();
        public Reservaciones()
        {
            InitializeComponent();
            foreach (ReservacionMesas item in DatosEstaticos.reservacionesList)
            {
                reservaBindingSource.Add(item);
                count++;
            }
        }

        private void ReservarBt_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numMesaTb.Text) && !string.IsNullOrWhiteSpace(horaTb.Text) && !string.IsNullOrWhiteSpace(contactoTb.Text) && !string.IsNullOrWhiteSpace(nombreClienteTb.Text))
            {
                if (horaTb.TextLength == 5) {
                    int count2 = 0;
                    int numMesaParse = int.Parse(numMesaTb.Text);
                    foreach (MesasJson item in GestionJson.mesasJson)
                    {
                        if (item.numMesa == numMesaParse)
                        {
                            count2++;
                        }
                    }
                    if (count2 == 0)
                    {

                        MessageBox.Show("La mesa elejida no corresponde al plano actual", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        bool comprobacion = ControlHoraMesa();
                        if (comprobacion) {
                            ReservacionMesas res = new ReservacionMesas(numMesaParse, nombreClienteTb.Text, horaTb.Text, fechaDtp.Value, contactoTb.Text);
                            reservaBindingSource.Add(res);
                            DatosEstaticos.reservacionesList.Add(res);
                            if (count == 0)
                            {
                                reservacionesDg.Columns[0].HeaderText = "Mesa";
                                reservacionesDg.Columns[1].HeaderText = "Cliente";
                                reservacionesDg.Columns[2].HeaderText = "Hora";
                                reservacionesDg.Columns[3].HeaderText = "Fecha";
                                reservacionesDg.Columns[4].HeaderText = "Contacto";
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se puede reservar : Mesa reservada en ese horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }

                    }
                }
                else
                {
                    MessageBox.Show("La hora debe contener parametros correctos HH:MM", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else {
                MessageBox.Show("Todos los campos deben contener parametros","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }
        private void Reservaciones_Load(object sender, EventArgs e)
        {
            reservacionesDg.DataSource = reservaBindingSource;
            if (count > 0)
            {
                reservacionesDg.Columns[0].HeaderText = "Mesa";
                reservacionesDg.Columns[1].HeaderText = "Cliente";
                reservacionesDg.Columns[2].HeaderText = "Hora";
                reservacionesDg.Columns[3].HeaderText = "Fecha";
                reservacionesDg.Columns[4].HeaderText = "Contacto";
            }
        }

        private void CancelarBt_Click(object sender, EventArgs e)
        {
            ReservacionMesas r = (ReservacionMesas)reservaBindingSource.Current;
            DatosEstaticos.reservacionesList.Remove(r);
            reservaBindingSource.Remove(r);
        }

        private void HoraTb_KeyPress(object sender, KeyPressEventArgs e)
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
            string nuevaHora = horaTb.Text;

            if (nuevaHora.Length == 3)
            {
                nuevaHora = nuevaHora.Insert(2, ":");
                horaTb.Text = nuevaHora;
                horaTb.Select(horaTb.Text.Length, 0);
            }
            if (nuevaHora.Length == 5)
            {
                e.Handled = true;
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                    horaTb.ResetText();
                }
            }


        }

        private void NumMesaTb_KeyPress(object sender, KeyPressEventArgs e)
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
        }
        private void BuscarReservaciones()
        {
            if (!string.IsNullOrWhiteSpace(buscadorTb.Text))
            {
                List<ReservacionMesas> tempList = new List<ReservacionMesas>();
                reservaBindingSource.Clear();
                for (int i = 0; i < DatosEstaticos.reservacionesList.Count; i++)
                {
                    if ((DatosEstaticos.reservacionesList[i].nombreCliente.ToUpper()).IndexOf(buscadorTb.Text.ToUpper()) == 0)
                    {
                        reservaBindingSource.Add(DatosEstaticos.reservacionesList[i]);
                    }
                    if ((DatosEstaticos.reservacionesList[i].numMesa.ToString().ToUpper()).IndexOf(buscadorTb.Text.ToUpper()) == 0)
                    {
                        reservaBindingSource.Add(DatosEstaticos.reservacionesList[i]);
                    }
                    if ((DatosEstaticos.reservacionesList[i].hora.ToUpper()).IndexOf(buscadorTb.Text.ToUpper()) == 0)
                    {
                        reservaBindingSource.Add(DatosEstaticos.reservacionesList[i]);
                    }
                }
                //productosDg.DataSource = productoBindingSource;
            }
            else
            {
                reservaBindingSource.Clear();
                foreach (ReservacionMesas item in DatosEstaticos.reservacionesList)
                {
                    reservaBindingSource.Add(item);
                }
                reservacionesDg.DataSource = reservaBindingSource;
            }
        }
        private void BuscadorTb_TextChanged(object sender, EventArgs e)
        {
            BuscarReservaciones();
        }
        public bool ControlHoraMesa()
        {
            string horaString = horaTb.Text.Remove(2, 1);
            int horaInt = int.Parse(horaString);
            int numMesaParse = int.Parse(numMesaTb.Text);

            foreach (ReservacionMesas item in DatosEstaticos.reservacionesList)
            {
                string horaStringRes = item.hora.Remove(2, 1);
                int horaIntRes = int.Parse(horaStringRes);

                if (horaIntRes == horaInt && item.numMesa == numMesaParse)
                {
                    return false;
                }
            }
            return true;
        }

        private void HoraTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
