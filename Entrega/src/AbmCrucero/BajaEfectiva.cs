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
using FrbaCrucero.CompraReservaPasaje;

namespace FrbaCrucero.AbmCrucero
{
    public partial class BajaEfectiva : Form
    {

        Crucero crucero;
        bool vidaUtil = false;
        CruceroDao dao;
        CompraDao cDao;

        public BajaEfectiva(Crucero unCrucero, bool vidaUtil)
        {
            InitializeComponent();
            this.crucero = unCrucero;
            this.vidaUtil = vidaUtil;
            dao = new CruceroDao();
            cDao = new CompraDao();
            if (vidaUtil)
            {
                this.dtAlta.Visible = false;
                this.labelAlta.Visible = false;
                this.corrimiento.Visible = false;
            }
            else
            {
                this.replace.Visible = false;

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void replace_Click(object sender, EventArgs e)
        {
            ReemplazoCrucero re = new ReemplazoCrucero(this.crucero.idCrucero);
            re.FormClosed += new System.Windows.Forms.FormClosedEventHandler(ReemplazoCruceroCerrado);
            re.Show();
        }

        private void ReemplazoCruceroCerrado(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Para devoler los pasajes o realizar otra operacion debe selecionar el boton correspondiente. Seleccionando esto se dara de baja el crucero ", " Desea continuar?", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                if (this.textDescripcion.Text != "")
                {
                    if (vidaUtil)
                    {
                        this.dao.bajaCruceroUtil(crucero.idCrucero, this.textDescripcion.Text, Convert.ToDateTime(this.dtBaja.Value));
                        MessageBox.Show("Se dio de baja por vida util el crucero: " + crucero.identificador);
                    }
                    else
                    {
                        this.dao.bajaCruceroServicio(crucero.idCrucero, this.textDescripcion.Text, Convert.ToDateTime(this.dtBaja.Value), Convert.ToDateTime(this.dtAlta.Value));
                        MessageBox.Show("Se dio de baja por fuera de servicio el crucero: " + crucero.identificador);
                    }

                }
                else
                {
                    MessageBox.Show("Por favor complete la descripcion");
                }
            }
            else
            {
                return;
            }

        }

        private void devolucion_Click(object sender, EventArgs e)
        {
            this.dao.devolverPasajes(crucero.idCrucero, Convert.ToDateTime(this.dtBaja.Value));
            MessageBox.Show("Se han devuelto los pasajes");
        }

        private void corrimiento_Click(object sender, EventArgs e)
        {
            List<Viaje> viajes = this.cDao.getViajes(crucero.idCrucero);
            DateTime inicio = Convert.ToDateTime(this.dtBaja.Value);
            DateTime fin = Convert.ToDateTime(this.dtAlta.Value);
            double corrimiento = (fin - inicio).TotalDays;
            var corrimientoFormateado = (fin - inicio).ToString(@"dd\d\ hh\h\ mm\m\ ");
            int count = viajes.Count();
            for (int i = 0; i < count; i++ )
            {
                Viaje viaje = viajes[i];
                viaje.fechaInicio = viaje.fechaInicio.AddDays(corrimiento);
                viaje.fechaFin = viaje.fechaFin.AddDays(corrimiento);
                this.dao.reprogramarViajes(viaje.idViaje, viaje.fechaInicio, viaje.fechaFin);
            }
            MessageBox.Show("Se han reprogramado todos los viajes con un corrimiento de " + corrimientoFormateado);
        }
    }
}
