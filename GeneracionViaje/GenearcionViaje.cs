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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class GenearcionViaje : Form
    {
        RecorridoDao rDao;
        CruceroDao cDao;
        public GenearcionViaje()
        {
            InitializeComponent();
            setupCombos();
            rDao = new RecorridoDao();
            cDao = new CruceroDao();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {

        }

        private void setupCombos()
        {
            this.comboRecorrido.ValueMember = "id";
            this.comboRecorrido.DisplayMember = "description";
            this.comboRecorrido.DataSource = rDao.getRecorridos();
            this.comboRecorrido.SelectedItem = null;
        }

        private void setupCruceroCombo()
        {

            //TODO: obtener los cruceros que estan disponibles en las fechas seleccionadas
            this.comboCrucero.ValueMember = "id";
            this.comboCrucero.DisplayMember = "description";
            this.comboCrucero.DataSource = rDao.getRecorridos();
            this.comboCrucero.SelectedItem = null;
        }
    }
}
