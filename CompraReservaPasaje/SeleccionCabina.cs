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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class SeleccionCabina : Form
    {

        Viaje viaje;
        CompraDao dao;

        public SeleccionCabina()
        {
            InitializeComponent();
        }

        public SeleccionCabina(Viaje unViaje)
        {
            InitializeComponent();
            dao = new CompraDao();
            this.viaje = unViaje;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid(int cantiCabinas)
        {
            this.dgvCabinas.DataSource = dao.getCabinasDisponibles(viaje.idViaje, cantiCabinas, viaje.idCrucero );
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (this.textCant.Text != "")
            {
                setupGrid(Int32.Parse(this.textCant.Text));
                this.dgvCabinas.Visible = true;
                this.labelCab.Visible = true;
            }
        }

        private void dgvCabinas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvCabinas.SelectedRows.Count == 1)
            {
                DataGridViewRow unaCabina = this.dgvCabinas.SelectedRows[0];
                TipoCabina tipo = new TipoCabina(unaCabina);
                IngresoCliente sc = new IngresoCliente(tipo, viaje, Int32.Parse(this.textCant.Text));
                sc.FormClosed += new System.Windows.Forms.FormClosedEventHandler(IngresoClienteCerrado);
                sc.ShowDialog();
            }
        }

        private void IngresoClienteCerrado(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
