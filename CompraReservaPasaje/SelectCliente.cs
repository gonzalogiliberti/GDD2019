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

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class SelectCliente : Form
    {

        IngresoCliente ing;

        public SelectCliente()
        {
            InitializeComponent();
        }

        public SelectCliente(DataTable dt, IngresoCliente ig)
        {
            InitializeComponent();
            this.ing = ig;
            this.dgvClientes.DataSource = dt;
        }

        private void dgvClientes_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (this.dgvClientes.SelectedRows.Count == 1)
            {
                DataGridViewRow unCliente = this.dgvClientes.SelectedRows[0];
                ing.setCliente(unCliente);
                this.Close();
            }
        }
    }
}
