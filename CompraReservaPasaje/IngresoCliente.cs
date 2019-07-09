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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class IngresoCliente : Form
    {

        DataGridViewRow viaje;
        DataGridViewRow cabina;
        int cantPasajeros;
        CompraDao dao;
        Cliente cliente = null;
        bool newCliente = false;

        public IngresoCliente()
        {
            InitializeComponent();
        }

        public IngresoCliente(DataGridViewRow unaCabina, DataGridViewRow unViaje, int cantidadPasajeros)
        {
            InitializeComponent();
            dao = new CompraDao();
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
    }
}
