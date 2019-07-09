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
    public partial class SeleccionCabina : Form
    {

        DataGridViewRow viaje;
        CompraDao dao;

        public SeleccionCabina()
        {
            InitializeComponent();
        }

        public SeleccionCabina(DataGridViewRow unViaje)
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
            this.dgvCabinas.DataSource = dao.getCabinasDisponibles((int)viaje.Cells["idViaje"].Value, cantiCabinas);
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
                IngresoCliente sc = new IngresoCliente(unaCabina, viaje, Int32.Parse(this.textCant.Text));
                sc.ShowDialog();
            }
        }
    }
}
