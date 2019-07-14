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

namespace FrbaCrucero.AbmRecorrido
{
    public partial class RemoverTramo : Form
    {

        RecorridoDao dao;
        PuertoDao daoPuerto;
        int idRecorrido = -1;
        DataGridViewRow unRecorrido;

        public RemoverTramo()
        {
            InitializeComponent();
        }

        public RemoverTramo(DataGridViewRow unRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            idRecorrido = (int)this.unRecorrido.Cells["idRecorrido"].Value;
            this.unRecorrido = unRecorrido;
            setupGrid();
        }

        public RemoverTramo(int idRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            this.idRecorrido = idRecorrido;
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid()
        {
            this.dgvTramo.DataSource = dao.getTramosForRecorrido(idRecorrido);
        }

        private void dgvTramo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow unTramo = this.dgvTramo.SelectedRows[0];
            this.dao.deleteTramoFromRecorrido((int)unTramo.Cells["idTramo"].Value,idRecorrido);
            setupGrid();
        }
    }
}
