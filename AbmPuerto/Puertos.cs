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

namespace FrbaCrucero.AbmPuerto
{
    public partial class Puertos : Form
    {
        private PuertoDao dao;
        public Puertos()
        {
            this.dao = new PuertoDao();
            InitializeComponent();
            setupGrid();
            setupCombo();
        }

        public void setupGrid()
        {
            this.dgvPuertos.DataSource = this.dao.getAllPuertos();
        }

        public void setupCombo()
        {
            this.comboPuerto.ValueMember = "id";
            this.comboPuerto.DisplayMember = "description";
            this.comboPuerto.DataSource = dao.getPuertos();
            this.comboPuerto.SelectedItem = null;
        }

        private void dgvPuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboPuerto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
