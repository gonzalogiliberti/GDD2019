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

namespace FrbaCrucero.AbmCrucero
{
    public partial class ReemplazoCrucero : Form
    {

        int idCrucero;
        CruceroDao dao;

        public ReemplazoCrucero(int cruceroId)
        {
            InitializeComponent();
            dao = new CruceroDao();
            this.idCrucero = cruceroId;
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid()
        {
            this.dgvViaje.DataSource = dao.getViajesForCruise(idCrucero);
        }

        private void dgvViaje_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvViaje.SelectedRows.Count == 1)
            {
                DataGridViewRow unViaje = this.dgvViaje.SelectedRows[0];
                CrucerosDisponibles cru = new CrucerosDisponibles((int)unViaje.Cells["idViaje"].Value);
                cru.FormClosed += new System.Windows.Forms.FormClosedEventHandler(CruceroDispCerrada);
                cru.Show();
            }
        }

        private void CruceroDispCerrada(object sender, FormClosedEventArgs e)
        {
            this.setupGrid();
        }

    }
}
