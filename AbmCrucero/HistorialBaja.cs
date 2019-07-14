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
    public partial class HistorialBaja : Form
    {
        CruceroDao dao;
        int crucero;

        public HistorialBaja(int cruceroId)
        {
            InitializeComponent();
            this.dao = new CruceroDao();
            this.crucero = cruceroId;
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid()
        {
            this.dgvBaja.DataSource = this.dao.getAllBajas(this.crucero);
        }
    }
}
