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
using FrbaCrucero.AbmPuerto;

namespace FrbaCrucero.AbmRecorrido
{
    public partial class AltaModificacionTramo : Form
    {
        RecorridoDao dao;
        PuertoDao daoPuerto;
        DataGridViewRow unTramo;
        bool newTramo = true;
        int idRecorrido;

        public AltaModificacionTramo()
        {
            //Nunca deberia entrar por este constructor
            InitializeComponent();
            dao = new RecorridoDao();
            daoPuerto = new PuertoDao();
        }

        public AltaModificacionTramo(int idRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            this.idRecorrido = idRecorrido;
            daoPuerto = new PuertoDao();
            setupCombos();
        }

        public AltaModificacionTramo(DataGridViewRow unTramo, int idRecorrido)
        {
            InitializeComponent();
            dao = new RecorridoDao();
            this.unTramo = unTramo;
            newTramo = false;
            this.idRecorrido = idRecorrido;
            daoPuerto = new PuertoDao();
            setupCombos();
            this.comboOrigen.Text = unTramo.Cells["puertoOrigen"].Value.ToString();
            this.comboDestino.Text = unTramo.Cells["puertoDestino"].Value.ToString();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupCombos()
        {
            this.comboOrigen.ValueMember = "id";
            this.comboOrigen.DisplayMember = "description";
            this.comboOrigen.DataSource = daoPuerto.getPuertos();
            this.comboOrigen.SelectedItem = null;

            this.comboDestino.ValueMember = "id";
            this.comboDestino.DisplayMember = "description";
            this.comboDestino.DataSource = daoPuerto.getPuertos();
            this.comboDestino.SelectedItem = null;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            this.dao.deleteTramo(idRecorrido, (int)this.unTramo.Cells["idTramo"].Value);
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (newTramo)
            {
                createTramo();
            }
            else
            {
                updateTramo();
            }
        }

        private void createTramo()
        {
            Tramo unTramo = getFormData();
            CheckEmptyFields();
            if (this.dao.verifyTramoExisted(unTramo.idPuertoOrigen, unTramo.idPuertoDestino, idRecorrido) != 0)
            {
                throw new Exception("El Crucero Ingresado ya existe");
            }
            this.dao.createTramo(idRecorrido, unTramo.idPuertoOrigen, unTramo.idPuertoDestino, unTramo.precio);
        }

        private void updateTramo()
        {
            Tramo unTramo = getFormData();
            CheckEmptyFields();
            int idTramo = (int)this.unTramo.Cells["idTramo"].Value;
            int pOrigen = (int)this.unTramo.Cells["puertoOrigen"].Value;
            int pDestino = (int)this.unTramo.Cells["puertoDestino"].Value;
            if ((pOrigen != unTramo.idPuertoOrigen) || (pDestino != unTramo.idPuertoDestino))
            {
                if (this.dao.verifyTramoExisted(unTramo.idPuertoOrigen, unTramo.idPuertoDestino, idRecorrido) != 0)
                {
                    throw new Exception("El Crucero Ingresado ya existe");
                }
            }
            this.dao.updateTramo(idTramo, unTramo.idPuertoOrigen, unTramo.idPuertoDestino, unTramo.precio);
        }

        private Tramo getFormData()
        {
            Puerto pO = this.comboOrigen.SelectedItem as Puerto;
            Puerto pD = this.comboDestino.SelectedItem as Puerto;
            return new Tramo(pO.getId(), pD.getId(), Int32.Parse(this.textBox1.Text));
        }

        private void CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> { this.textBox1 };
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
            }

            List<ComboBox> inputsCombo = new List<ComboBox> { this.comboOrigen, this.comboDestino };
            if (inputsCombo.Any((c) => c.SelectedItem == null))
            {
                throw new Exception("Debe seleccionar Fabricante y modelo");
            }
        }
    }
}
