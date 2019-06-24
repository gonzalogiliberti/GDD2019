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
    public partial class AltaModificacionCrucero : Form
    {
        CruceroDao dao;
        bool newCruise = true;
        public DataGridViewRow unCrucero;

        public AltaModificacionCrucero()
        {
            dao = new CruceroDao();
            InitializeComponent();
            setupCombos();
        }

        public AltaModificacionCrucero(DataGridViewRow unCrucero)
        {
            InitializeComponent();
            dao = new CruceroDao();
            setupCombos();
            this.unCrucero = unCrucero;
            newCruise = false;
            this.textCantCab.Text = unCrucero.Cells["CantidadCabinas"].Value.ToString();
            this.textIdentificador.Text = unCrucero.Cells["Identificador"].Value.ToString();
            this.comboFabricante.Text = unCrucero.Cells["Fabricante"].Value.ToString();
            this.comboModelo.Text = unCrucero.Cells["Modelo"].Value.ToString();
            this.fechaAlta.Text = unCrucero.Cells["FechaAlta"].Value.ToString();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (newCruise)
            {
                createCruise();   
            }
            else
            {
                updateCruise();
            }
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

        private void CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> { this.textCantCab, this.textIdentificador };
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
            }

            List<ComboBox> inputsCombo = new List<ComboBox> { this.comboFabricante, this.comboModelo };
            if (inputsCombo.Any((c) => c.SelectedItem == null))
            {
                throw new Exception("Debe seleccionar Fabricante y modelo");
            }
        }

        private void createCruise()
        {
            try
            {
                CheckEmptyFields();
                Crucero cruise = getFormData();
                if (this.dao.verifyCruiseExisted(cruise) != 0)
                {
                    throw new Exception("El Crucero Ingresado ya existe");
                }
                this.dao.createCruise(cruise);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void updateCruise()
        {
            try
            {
                CheckEmptyFields();
                Crucero cruise = getFormData();
                cruise.idCrucero = (int)this.unCrucero.Cells["idCrucero"].Value;
                if (cruise.getIdentificador() != this.unCrucero.Cells["Identificador"].Value.ToString())
                {
                    if (this.dao.verifyCruiseExisted(cruise) != 0)
                    {
                        throw new Exception("El Crucero Ingresado ya existe");
                    }
                }
                this.dao.updateCruise(cruise);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Crucero getFormData()
        {
            Fabricante f = this.comboFabricante.SelectedItem as Fabricante;
            String model = this.comboModelo.SelectedItem as String;
            return new Crucero(this.textIdentificador.Text, f.getId(), model, this.fechaAlta.Value,  Int32.Parse(this.textCantCab.Text));
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            Crucero cruise = getFormData();
            cruise.idCrucero = (int)this.unCrucero.Cells["idCrucero"].Value;
            dao.deleteCruise(cruise);
        }

    }
}
