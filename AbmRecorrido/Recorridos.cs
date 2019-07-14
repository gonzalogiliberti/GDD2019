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
    public partial class Recorridos : Form
    {

        private RecorridoDao dao;

        public Recorridos()
        {
            dao = new RecorridoDao();
            InitializeComponent();
            setupGrid();
        }

        public void setupGrid()
        {
            this.dgvRecorrido.DataSource = dao.getAllRecorridos();
        }

        private void dgvRecorrido_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow unRecorrido = this.dgvRecorrido.SelectedRows[0];
            AltaModificacionRecorrido modificacion = new AltaModificacionRecorrido(unRecorrido);
            modificacion.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionRecorridoCerrada);
            modificacion.Show();
        }

        private void AltaModificacionRecorridoCerrada(object sender, FormClosedEventArgs e)
        {
            this.setupGrid();
        }

        private void agregarRecorrido_Click(object sender, EventArgs e)
        {
            AltaModificacionRecorrido modificacion = new AltaModificacionRecorrido();
            modificacion.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionRecorridoCerrada);
            modificacion.Show();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }

        private void search_Click(object sender, EventArgs e)
        {

        }
    }
}
