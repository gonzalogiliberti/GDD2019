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
    public partial class PagarReserva : Form
    {

        CompraDao dao;
        Cliente cliente;
        Viaje viaje;
        TipoCabina tipo;
        int cantPasajes;
        CruceroDao cDao;

        public PagarReserva()
        {
            InitializeComponent();
            dao = new CompraDao();
            cDao = new CruceroDao();
            dao.marcarVencidasReservas(DateUtils.getDateFromConfig());
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pay_Click(object sender, EventArgs e)
        {
            if (this.textCodigo.Text != "")
            {
                decimal codigo = Convert.ToDecimal(this.textCodigo.Text);
                DataRow r = this.dao.getReserve(codigo);
                if (r != null)
                {
                    if (Convert.ToInt32(r["Vencida"]) == 1 || Convert.ToInt32(r["Pagada"]) == 1)
                    {
                        cliente = this.dao.getCliente(Convert.ToInt32(r["idCliente"]));
                        viaje = this.dao.getViaje(Convert.ToInt32(r["idViaje"]));
                        int idTipo = cDao.getTipoCabinaId(Convert.ToInt32(r["idCabina"]));
                        tipo = cDao.getTipoCabina(idTipo);
                        cantPasajes = Convert.ToInt32(r["cantidadPasajeros"]);
                        Pago p = new Pago(viaje, tipo, cliente, cantPasajes, codigo);
                        p.FormClosed += new System.Windows.Forms.FormClosedEventHandler(PagoCerrado);
                        p.Show();
                    }
                    else if (Convert.ToInt32(r["Vencida"]) == 1)
                    {
                        System.Windows.Forms.MessageBox.Show("Su reserva se encuentra vencida");
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("Su reserva se encuentra pagada");
                    }
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("No se encontro ninguna reserva con ese codigo");
                }
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Por favor, ingrese el codigo de la reserva");
            }
        }
        
        private void PagoCerrado(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
