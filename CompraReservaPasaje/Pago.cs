using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.Dao;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Pago : Form
    {

        Viaje viaje;
        TipoCabina tipoCabina;
        int cantidadPasajeros;
        Cliente cliente;
        CompraDao dao;
        RecorridoDao rDao;
        MedioPAgo mp;
        double precioTotal;
        decimal codigoReserva = -1;

        public Pago(Viaje unViaje, TipoCabina unTipo, Cliente unCliente, int pasajeros, decimal codigoReserva)
        {
            InitializeComponent();
            dao = new CompraDao();
            rDao = new RecorridoDao();
            this.viaje = unViaje;
            this.tipoCabina = unTipo;
            this.cliente = unCliente;
            this.cantidadPasajeros = pasajeros;
            this.precioTotal = (double)((rDao.getPrecioFinal(viaje.idRecorrido) * unTipo.recargo) * cantidadPasajeros);
            this.textPrecio.Text = precioTotal.ToString();
            this.codigoReserva = codigoReserva;
            setupCombo();
        }

        public Pago(Viaje unViaje, TipoCabina unTipo, Cliente unCliente, int pasajeros)
        {
            InitializeComponent();
            dao = new CompraDao();
            rDao = new RecorridoDao();
            this.viaje = unViaje;
            this.tipoCabina = unTipo;
            this.cliente = unCliente;
            this.cantidadPasajeros = pasajeros;
            this.precioTotal = (double)((rDao.getPrecioFinal(viaje.idRecorrido) * unTipo.recargo) * cantidadPasajeros);
            this.textPrecio.Text = precioTotal.ToString();
            setupCombo();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupCombo()
        {
            this.comboMedioPago.ValueMember = "id";
            this.comboMedioPago.DisplayMember = "description";
            this.comboMedioPago.DataSource = dao.getMedioPagos();
            this.comboMedioPago.SelectedItem = null;
        }

        private void comboMedioPago_SelectedValueChanged(object sender, EventArgs e)
        {
            mp = this.comboMedioPago.SelectedItem as MedioPAgo;
            if (mp != null)
            {
                if (mp.Nombre.Equals("Tarjeta de Credito"))
                {
                    this.labelCoutas.Visible = true;
                    this.comboTarjeta.Visible = true;
                    this.textCoutas.Visible = true;
                    this.labelTarjeta.Visible = true;
                }
                else
                {
                    this.labelCoutas.Visible = false;
                    this.comboTarjeta.Visible = false;
                    this.textCoutas.Visible = false;
                    this.labelTarjeta.Visible = false;
                }
            }
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (CheckEmptyFields())
            {
                TarjetaCredito tarjeta = this.comboTarjeta.SelectedItem as TarjetaCredito;
                if (tarjeta != null)
                {
                    tarjeta.coutas = Int32.Parse(this.textCoutas.Text);
                }
                dao.pay(cliente, viaje, tipoCabina, mp, precioTotal, tarjeta, cantidadPasajeros);
                if (this.codigoReserva != -1)
                {
                    dao.markReservePaid(codigoReserva);
                }
                decimal codigoPasaje = dao.getCodigoPasaje(cliente, viaje, mp, precioTotal, tarjeta, cantidadPasajeros);
                showPayInformation(codigoPasaje);
            }
        }

        private bool CheckEmptyFields()
        {
            List<ComboBox> inputsCombo = new List<ComboBox> { this.comboMedioPago };
            if (inputsCombo.Any((c) => c.SelectedItem == null))
            {
                throw new Exception("Debe seleccionar medio de pago");
                return false;
            }

            if (mp.Nombre.Equals("Tarjeta de Credito"))
            {
                List<TextBox> inputs = new List<TextBox> { this.textCoutas };
                if (inputs.Any((t) => t.Text == ""))
                {
                    MessageBox.Show("Indique cuantas cuotas desea");
                    return false;
                }

                List<ComboBox> inputCombo = new List<ComboBox> { this.comboTarjeta };
                if (inputsCombo.Any((c) => c.SelectedItem == null))
                {
                    throw new Exception("Debe seleccionar la tarjeta de credito que va a utilizar");
                    return false;
                }
            }
            return true;
        }

        private void showPayInformation(decimal codigoPasaje)
        {
            string puertoOrigen = rDao.getPuertoOrigenRecorrido(viaje.idRecorrido);
            string puertoDestino = rDao.getPuertoDestinoRecorrido(viaje.idRecorrido);

            string texto = "El codigo de su pasaje es: " + codigoPasaje;
            texto += " parte el dia: " + viaje.fechaInicio + " desde " + puertoOrigen;
            texto += " finaliza el dia: " + viaje.fechaFin + " en el puerto: " + puertoDestino;
            texto += " el precio final es: " + precioTotal + " y fue abonado con: " + mp.Nombre;
            texto += ". Le deseamos un buen viaje. ";

            MessageBox.Show(texto);
            this.Close();
        }
    }
}
