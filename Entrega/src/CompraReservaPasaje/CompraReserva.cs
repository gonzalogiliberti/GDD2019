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
using FrbaCrucero.AbmPuerto;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class CompraReserva : Form
    {

        PuertoDao pDao;
        CompraDao dao;

        public CompraReserva()
        {
            InitializeComponent();
            pDao = new PuertoDao();
            dao = new CompraDao();
            setupCombos();
        }

        private void setupCombos()
        {
            this.comboPuertoOri.ValueMember = "id";
            this.comboPuertoOri.DisplayMember = "description";
            this.comboPuertoOri.DataSource = pDao.getPuertos();
            this.comboPuertoOri.SelectedItem = null;

            this.comboPuertoDest.ValueMember = "id";
            this.comboPuertoDest.DisplayMember = "description";
            this.comboPuertoDest.DataSource = pDao.getPuertos();
            this.comboPuertoDest.SelectedItem = null;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void search_Click(object sender, EventArgs e)
        {
            DateTime d = this.dtInicio.Value;
            Puerto pOrigen = this.comboPuertoOri.SelectedItem as Puerto;
            Puerto pDestino = this.comboPuertoDest.SelectedItem as Puerto;
            if(pOrigen != null && pDestino != null)
            {
                this.dgvViajes.DataSource = dao.getAllTrips(pOrigen.idPuerto, pDestino.idPuerto, d);
                dgvViajes.Visible = true;
                this.seleccion.Visible = true;
            }
            else
            {
                MessageBox.Show("Seleccion puerto de destino y origen");
            }
        }

        private void dgvViajes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvViajes.SelectedRows.Count == 1)
            {
                DataGridViewRow unViaje = this.dgvViajes.SelectedRows[0];
                Viaje viaje = new Viaje(unViaje);
                SeleccionCabina sc = new SeleccionCabina(viaje);
                sc.ShowDialog();
            }
        }

        private void dgvViajes_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow unViaje = this.dgvViajes.SelectedRows[0];
            Viaje viaje = new Viaje(unViaje);
            SeleccionCabina sc = new SeleccionCabina(viaje);
            sc.ShowDialog();
        }
    }
}
