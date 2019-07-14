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

namespace FrbaCrucero.AbmRol
{
    public partial class Roles : Form
    {



        RolDao rDao;

        public Roles()
        {
            InitializeComponent();
            rDao = new RolDao();
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid()
        {
            this.dgvRol.DataSource = rDao.getRoles();
        }

        private void create_Click(object sender, EventArgs e)
        {
            AltaModificacionRol m = new AltaModificacionRol();
            m.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionRolCerrada);
            m.ShowDialog();
        }

        private void AltaModificacionRolCerrada(object sender, FormClosedEventArgs e)
        {
            setupGrid();
        }

        private void dgvRol_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvRol.SelectedRows.Count == 1)
            {
                DataGridViewRow unRol = this.dgvRol.SelectedRows[0];
                AltaModificacionRol a = new AltaModificacionRol(unRol);
                a.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaModificacionRolCerrada);
                a.ShowDialog();
            }
        }
    }
}
