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
    public partial class Funcionalidades : Form
    {
        int idRol = -1;
        RolDao rDao;

        public Funcionalidades()
        {
            InitializeComponent();
            rDao = new RolDao();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Funcionalidades(int rol)
        {
            InitializeComponent();
            idRol = rol;
            rDao = new RolDao();
            setupGrid();
        }

        private void setupGrid()
        {
            this.dgvFunc.DataSource = this.rDao.getFuncAvailable(idRol);
        }

        private void create_Click(object sender, EventArgs e)
        {
            AltaFuncionalidad a = new AltaFuncionalidad();
            a.FormClosed += new System.Windows.Forms.FormClosedEventHandler(AltaFuncionalidadCerrada);
            a.ShowDialog();
        }

        private void AltaFuncionalidadCerrada(object sender, FormClosedEventArgs e)
        {
            setupGrid();
        }

        private void dgvFunc_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow funcion = this.dgvFunc.SelectedRows[0];
            rDao.setFuncRol((int)funcion.Cells["idFuncionalidad"].Value, idRol);
            setupGrid();
        }

        private void search_Click(object sender, EventArgs e)
        {
            String searchValue = this.textBox1.Text;
            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvFunc.Rows)
            {
                if (row.Cells[1].Value.ToString().Equals(searchValue))
                {
                    rowIndex = row.Index;
                    dgvFunc.CurrentCell = dgvFunc[1, rowIndex];
                    break;
                }
            }
        }
    }
}
