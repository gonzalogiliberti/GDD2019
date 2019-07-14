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
    public partial class AltaModificacionRecorrido : Form
    {
        RecorridoDao dao;
        bool newRecorrido = true;
        int idRecorrido = -1;
        public DataGridViewRow unRecorrido;

        public AltaModificacionRecorrido()
        {
            dao = new RecorridoDao();
            InitializeComponent();
        }

        public AltaModificacionRecorrido(DataGridViewRow unRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            this.unRecorrido = unRecorrido;
            newRecorrido = false;
            idRecorrido = (int)this.unRecorrido.Cells["idRecorrido"].Value;
            setupGrid();
            this.textCodigo.Text = this.unRecorrido.Cells["Codigo"].Value.ToString();
        }

        public void setupGrid()
        {
            this.dgvTramo.DataSource = dao.getTramosForRecorrido(idRecorrido);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvTramo_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> { this.textCodigo };
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            CheckEmptyFields();
            if (newRecorrido)
            {
                createRecorrido();

            }
            else
            {
                updateRecorrido();
            }
        }

        private void createRecorrido()
        {
            String codigo = this.textCodigo.Text;
            if (this.dao.verifyRecorridoExisted(codigo) != 0)
            {
                throw new Exception("El Recorrido Ingresado ya existe");
            }
            Decimal code;
            Decimal.TryParse(codigo,out code);
            this.dao.createRecorrido(code);
            //TODO: ACa hay que guardar el id del recorrido para poder accerder a los tramos y crear nuevos
            idRecorrido = this.dao.getIdRecorrido(code);
        }

        private void updateRecorrido()
        {
            String codigo = this.textCodigo.Text;
            if (codigo != this.unRecorrido.Cells["Codigo"].Value.ToString())
            {
                if (this.dao.verifyRecorridoExisted(codigo) != 0)
                {
                    throw new Exception("El Recorrido Ingresado ya existe");
                }
            }
            Decimal code;
            Decimal.TryParse(codigo, out code);
            this.dao.updateRecorrido(code, (int)this.unRecorrido.Cells["idRecorrido"].Value);
        }

        private void addTramo_Click(object sender, EventArgs e)
        {
            if (idRecorrido == -1)
            {
                MessageBox.Show("Debe guardar el recorrido primero");
                return;
            }
            Tramos t = new Tramos(idRecorrido);
            t.FormClosed += new System.Windows.Forms.FormClosedEventHandler(TramosCerrada);
            t.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (idRecorrido == -1)
            {
                MessageBox.Show("Debe guardar el recorrido primero");
                return;
            }
            this.dao.deleteRecorrido(idRecorrido);
        }

        private void TramosCerrada(object sender, EventArgs e)
        {
            setupGrid();
        }

        private void deleteTramo_Click(object sender, EventArgs e)
        {
            if (idRecorrido == -1)
            {
                MessageBox.Show("Debe guardar el recorrido primero");
                return;
            }
            RemoverTramo r = new RemoverTramo(idRecorrido);
            r.FormClosed += new System.Windows.Forms.FormClosedEventHandler(TramosCerrada);
            r.Show();
        }

        private void dgvTramo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
