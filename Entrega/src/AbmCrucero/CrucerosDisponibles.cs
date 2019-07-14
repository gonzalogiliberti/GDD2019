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
    public partial class CrucerosDisponibles : Form
    {

        int idViaje;
        CruceroDao dao;
        CompraDao cDao;

        public CrucerosDisponibles(int idViaje)
        {
            InitializeComponent();
            dao = new CruceroDao();
            cDao = new CompraDao();
            this.idViaje = idViaje;
            setupGrid();
        }

        private void CrucerosDisponibles_Load(object sender, EventArgs e)
        {

        }

        private void dgvCrucero_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvCrucero.SelectedRows.Count == 1)
            {
                DataGridViewRow crucero = this.dgvCrucero.SelectedRows[0];
                dao.updateCruiseViaje((int)crucero.Cells["idCrucero"].Value, idViaje);
                this.Close();
            }
        }

        private void create_Click(object sender, EventArgs e)
        {
            AltaModificacionCrucero alta = new AltaModificacionCrucero(idViaje);
            alta.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionCruceroCerrada);
            alta.Show();
        }

        private void setupGrid()
        {
            Viaje viaje = cDao.getViaje(idViaje);
            this.dgvCrucero.DataSource = dao.getCrucerosParaReemplazo(viaje.fechaInicio, viaje.fechaFin);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaModificacionCruceroCerrada(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
