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
using FrbaCrucero.Util;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.AbmCrucero;

namespace FrbaCrucero.GeneracionViaje
{
    public partial class GeneracionViajes : Form
    {
        RecorridoDao rDao;
        CruceroDao cDao;
        ViajeDao vDao;
        public GeneracionViajes()
        {
            InitializeComponent();
            rDao = new RecorridoDao();
            cDao = new CruceroDao();
            vDao = new ViajeDao();
            setupRecorridoCombo();
            setupDates();
            setupCruceroCombo();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupRecorridoCombo()
        {
            this.comboRecorrido.ValueMember = "id";
            this.comboRecorrido.DisplayMember = "description";
            this.comboRecorrido.DataSource = rDao.getRecorridos();
            this.comboRecorrido.SelectedItem = null;
        }

        private void setupCruceroCombo()
        {
            if (validateDates())
            {
                this.comboCrucero.ValueMember = "id";
                this.comboCrucero.DisplayMember = "description";
                this.comboCrucero.DataSource = cDao.getCrucerosDisponibles(this.dtInicio.Value, this.dtFin.Value);
                this.comboCrucero.SelectedItem = null;
            }
        }

        private void setupDates()
        {
            DateTime now = DateTime.Now;
            this.dtInicio.Value = now;
            this.dtFin.Value = now.AddMinutes(10);
        }

        private void dtInicio_CloseUp(object sender, EventArgs e)
        {
            setupCruceroCombo();
        }

        private bool validateDates()
        {
            if (this.dtInicio.Text == "" && this.dtFin.Text == "")
            {
                System.Windows.Forms.MessageBox.Show("Debe ingresar un fecha de inicio y una fecha de fin");
                return false;
            }

            if (this.dtInicio.Value > this.dtFin.Value)
            {
                System.Windows.Forms.MessageBox.Show("La fecha de fin debe ser mayor al fecha de inicio");
                return false;
            }
            return true;
        }

        private void dtFin_CloseUp(object sender, EventArgs e)
        {
            setupCruceroCombo();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (validateDates() && CheckEmptyFields())
            {
                Recorrido r = this.comboRecorrido.SelectedItem as Recorrido;
                Crucero c = this.comboCrucero.SelectedItem as Crucero;
                this.vDao.createViaje(this.dtInicio.Value, this.dtFin.Value, r.idRecorrido, c.idCrucero);
                System.Windows.Forms.MessageBox.Show("Se genero el viaje correctamente");
                this.Close();
            }
        }

        public bool CheckEmptyFields()
        {
            List<ComboBox> inputsCombo = new List<ComboBox> { this.comboCrucero, this.comboRecorrido };
            if (inputsCombo.Any((c) => c.SelectedItem == null))
            {
                System.Windows.Forms.MessageBox.Show("La fecha de fin debe ser mayor al fecha de inicio");
                return false;
            }
            return true;
        }
    }
}
