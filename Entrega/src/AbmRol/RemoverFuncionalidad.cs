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
    public partial class RemoverFuncionalidad : Form
    {
        RolDao rDao;
        int rolId = -1;

        public RemoverFuncionalidad()
        {
            InitializeComponent();
        }

        public RemoverFuncionalidad(int idRol)
        {
            InitializeComponent();
            rolId = idRol;
            rDao = new RolDao();
            setupGrid();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid()
        {
            this.dgvFunc.DataSource = rDao.getFuncByRol(rolId);
        }

        private void dgvFunc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow unaFuncion = this.dgvFunc.SelectedRows[0];
            rDao.removeFunctionFromRol(rolId, (int)unaFuncion.Cells["idFuncionalidad"].Value);
            this.Close();
        }
    }
}
