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
    public partial class Cabinas : Form
    {

        CruceroDao dao;
        int cantPisos;
        int idCrucero;

        public Cabinas(int pisos, int cruceroId)
        {
            InitializeComponent();
            dao = new CruceroDao();
            this.textBalcon.Text = "0";
            this.textEjecutivo.Text = "0";
            this.textSuite.Text = "0";
            this.textStandar.Text = "0";
            this.textExterior.Text = "0";
            this.cantPisos = pisos;
            this.idCrucero = cruceroId;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.dao.createCabinas(cantPisos, Convert.ToInt32(this.textStandar.Text), this.dao.getIdEstandar(), idCrucero);
            this.dao.createCabinas(cantPisos, Convert.ToInt32(this.textExterior.Text), this.dao.getIdExterior(), idCrucero);
            this.dao.createCabinas(cantPisos, Convert.ToInt32(this.textSuite.Text), this.dao.getIdSuite(), idCrucero);
            this.dao.createCabinas(cantPisos, Convert.ToInt32(this.textBalcon.Text), this.dao.getIdBalcon() , idCrucero);
            this.dao.createCabinas(cantPisos, Convert.ToInt32(this.textEjecutivo.Text), this.dao.getIdEjecutivo(), idCrucero);
            MessageBox.Show("Se crearon correctamente las cabinas");
            this.Close();
        }


    }
}
