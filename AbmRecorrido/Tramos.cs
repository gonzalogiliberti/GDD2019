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
    public partial class Tramos : Form
    {

        RecorridoDao dao;
        PuertoDao daoPuerto;
        int idRecorrido = -1;

        public Tramos()
        {
            InitializeComponent();
            dao = new RecorridoDao();
            daoPuerto = new PuertoDao();
            setupCombos();
        }

        public Tramos(int idRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            daoPuerto = new PuertoDao();
            this.idRecorrido = idRecorrido;
            setupCombos();
            setupGrid();
        }

        private void crearTramo_Click(object sender, EventArgs e)
        {
            AltaModificacionTramo a = new AltaModificacionTramo();
            a.ShowDialog();
        }

        private void setupGrid()
        {
            this.dgvTramo.DataSource = dao.getTramosAvailableRecorrido(idRecorrido);
        }

        private void setupCombos()
        {
            this.comboOrigen.ValueMember = "id";
            this.comboOrigen.DisplayMember = "description";
            this.comboOrigen.DataSource = daoPuerto.getPuertos();
            this.comboOrigen.SelectedItem = null;

            this.comboDestino.ValueMember = "id";
            this.comboDestino.DisplayMember = "description";
            this.comboDestino.DataSource = daoPuerto.getPuertos();
            this.comboDestino.SelectedItem = null;
        }

        private void dgvTramo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow unTramo = this.dgvTramo.SelectedRows[0];
            this.dao.setRecorridoXTramo(idRecorrido, (int)unTramo.Cells["idTramo"].Value);
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
