using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Dao;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.Util;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class IngresoCliente : Form
    {

        Viaje viaje;
        TipoCabina cabina;
        int cantPasajeros;
        CompraDao dao;
        RecorridoDao rDao;
        Cliente cliente = null;
        bool newCliente = false;

        public IngresoCliente()
        {
            InitializeComponent();
        }

        public IngresoCliente(TipoCabina unaCabina, Viaje unViaje, int cantidadPasajeros)
        {
            InitializeComponent();
            dao = new CompraDao();
            rDao = new RecorridoDao();
            this.viaje = unViaje;
            this.cabina = unaCabina;
            this.cantPasajeros = cantidadPasajeros;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (this.textDNI.Text != "")
            {
                DataTable dt = dao.searchCliente(Convert.ToDecimal(this.textDNI.Text));
                if (dt.Rows.Count == 0)
                {
                    showComponents();
                    newCliente = true;
                }
                else if (dt.Rows.Count == 1)
                {
                    cliente = new Cliente(dt.Rows[0]);
                    fillComponents();
                    showComponents();
                }
                else
                {
                    SelectCliente sc = new SelectCliente(dt, this);
                    sc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(seleccionCliente);
                    sc.ShowDialog();
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Por favor, ingrese su DNI");
            }
        }

        private void showComponents()
        {
            this.textNombre.Visible = true;
            this.labelName.Visible = true;
            this.labelLast.Visible = true;
            this.textApellido.Visible = true;
            this.textDireccion.Visible = true;
            this.labelDir.Visible = true;
            this.labelMail.Visible = true;
            this.textMail.Visible = true;
            this.labelNac.Visible = true;
            this.dtNac.Visible = true;
            this.saveClient.Visible = true;
            this.pay.Visible = true;
            this.reserve.Visible = true;
            this.labelTelefono.Visible = true;
            this.textTelefono.Visible = true;
        }

        private void fillComponents()
        {
            this.textNombre.Text = cliente.nombre;
            this.textApellido.Text = cliente.apellido;
            this.textDireccion.Text = cliente.direccion;
            this.textMail.Text = cliente.mail;
            this.dtNac.Value = cliente.fechaNac;
            this.textTelefono.Text = cliente.telefono.ToString();
        }

        private void seleccionCliente(object sender, FormClosedEventArgs e)
        {
            if (cliente != null)
            {
                fillComponents();
            }
        }

        public void setCliente(DataGridViewRow unCliente)
        {
            this.cliente = new Cliente(((DataRowView)unCliente.DataBoundItem).Row);
        }

        private void saveClient_Click(object sender, EventArgs e)
        {
            if(CheckEmptyFields())
            {
                if (newCliente)
                {
                    cliente = getFormData();
                    this.dao.createClient(cliente);
                    cliente.idCliente = this.dao.getClientId(cliente);
                    MessageBox.Show("Se guardaron correctamente los datos del cliente");
                }
                else
                {
                    this.dao.updateClient(cliente);
                    MessageBox.Show("Se actualizaron correctamente los datos del cliente");
                }
            }
        }

        private bool CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> { this.textNombre, this.textApellido, this.textDireccion, this.textMail, this.textTelefono, this.textDNI };
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }

            if (this.dtNac.Text == "")
            {
                MessageBox.Show("Complete la fecha de nacimiento");
                return false;
            }

            return true;
        }

        private Cliente getFormData()
        {
            return new Cliente(this.textNombre.Text, this.textApellido.Text, this.textMail.Text, this.textDireccion.Text, Int32.Parse(this.textTelefono.Text), Decimal.Parse(this.textDNI.Text), this.dtNac.Value);
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                MessageBox.Show("Debe guardar los datos del cliente primero");
                return ;
            }
            Pago pago = new Pago(viaje, cabina, cliente, cantPasajeros);
            pago.FormClosed += new System.Windows.Forms.FormClosedEventHandler(PagoCerrado);
            pago.ShowDialog();
        }

        private void reserve_Click(object sender, EventArgs e)
        {
            if (cliente == null)
            {
                MessageBox.Show("Debe guardar los datos del cliente primero");
                return;
            }
            dao.reserve(cliente, viaje, cabina, cantPasajeros);
            decimal codigoReserva = dao.getCodigoReserva(cliente, viaje, cantPasajeros);
            showReserveInformation(codigoReserva);
        }

        private void PagoCerrado(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void showReserveInformation(decimal codigoReserva)
        {
            string puertoOrigen = rDao.getPuertoOrigenRecorrido(viaje.idRecorrido);
            string puertoDestino = rDao.getPuertoDestinoRecorrido(viaje.idRecorrido);

            string texto = "El codigo de su reserva es: " + codigoReserva;
            texto += " parte el dia: " + viaje.fechaInicio + " desde " + puertoOrigen;
            texto += " finaliza el dia: " + viaje.fechaFin + " en el puerto: " + puertoDestino;
            texto += ". Su reserva vence el: " + DateUtils.getDateFromConfig().AddDays(3);

            MessageBox.Show(texto);
            this.Close();
        }
    }
}
