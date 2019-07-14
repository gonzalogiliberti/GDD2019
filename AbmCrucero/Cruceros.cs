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
    public partial class Cruceros : Form
    {
        private CruceroDao dao;
        public Cruceros()
        {
            dao = new CruceroDao();
            InitializeComponent();
            setupGrid();
            setupCombos();
        }

        public void setupGrid()
        {
            this.dgvCruise.DataSource = dao.getAllCruises();
        }

        public void setupCombos()
        {
            this.comboFabricante.ValueMember = "id";
            this.comboFabricante.DisplayMember = "description";
            this.comboFabricante.DataSource = dao.getFabricantes();
            this.comboFabricante.SelectedItem = null;

            this.comboModelo.ValueMember = "description";
            this.comboModelo.DisplayMember = "description";
            this.comboModelo.DataSource = dao.getModelos();
            this.comboModelo.SelectedItem = null;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvCruise_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvCruise.SelectedRows.Count == 1)
            {
                DataGridViewRow unCrucero = this.dgvCruise.SelectedRows[0];
                AltaModificacionCrucero modificacion = new AltaModificacionCrucero(unCrucero);
                modificacion.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionCruceroCerrada);
                modificacion.Show();
            }
        }

        private void newCruise_Click(object sender, EventArgs e)
        {
            AltaModificacionCrucero alta = new AltaModificacionCrucero();
            alta.Show();
        }

        private void AltaModificacionCruceroCerrada(object sender, FormClosedEventArgs e)
        {
            this.setupGrid();
        }

        private void search_Click(object sender, EventArgs e)
        {
            try
            {
                Fabricante f = this.comboFabricante.SelectedItem as Fabricante;
                String model = this.comboModelo.SelectedItem as String;
                this.dgvCruise.DataSource = dao.searchCruise(f, model, this.textIdentificador.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }    
        }
    }
}
