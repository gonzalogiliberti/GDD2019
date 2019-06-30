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

namespace FrbaCrucero.GeneracionViaje
{
    public partial class GeneracionViajes : Form
    {
        RecorridoDao rDao;
        CruceroDao cDao;
        public GeneracionViajes()
        {
            InitializeComponent();
            rDao = new RecorridoDao();
            cDao = new CruceroDao();
            setupRecorridoCombo();
            setupDates();
            setupCruceroCombo();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            String aa = this.dtInicio.Text;
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
            //TODO: obtener los cruceros que estan disponibles en las fechas seleccionadas
            if (this.dtInicio.Text != "" && this.dtFin.Text != "")
            {
                this.comboCrucero.ValueMember = "id";
                this.comboCrucero.DisplayMember = "description";
                this.comboCrucero.DataSource = cDao.getCrucerosDisponibles(this.dtInicio.Text, this.dtFin.Text);
                this.comboCrucero.SelectedItem = null;
            }
        }

        private void setupDates()
        {
            //TODO: Aca hay que llamar a DateUtils pero no me esta tomando esa clase ahora, no se porque
            DateTime now = DateTime.Parse("2019-06-27");
            this.dtInicio.Value = now;
            this.dtFin.Value = now.AddMinutes(10);
        }

        private void validateDates()
        {
            if (this.dtInicio.Value >= this.dtFin.Value)
            {
                throw new Exception("Las fechas son invalidas");
            }
        }
    }
}
