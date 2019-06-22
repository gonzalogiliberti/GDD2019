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

namespace FrbaCrucero.AbmPuerto
{
    public partial class AltaModificacionPuerto : Form
    {
        private PuertoDao dao;
        public DataGridViewRow unPuerto;
        private bool newPort = true;

        public AltaModificacionPuerto()
        {
            this.dao = new PuertoDao();
            InitializeComponent();
        }

        public AltaModificacionPuerto(DataGridViewRow unPuerto)
        {
            this.dao = new PuertoDao();
            InitializeComponent();
            this.unPuerto = unPuerto;
            this.nombrePuerto.Text = unPuerto.Cells["Puerto"].Value.ToString();
            newPort = false;
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (checkEmptyFileds())
            {
                if (newPort)
                {
                    createPort();   
                }
                else
                {
                    updatePort();
                }
            }
        }

        private bool checkEmptyFileds()
        {
            List<TextBox> inputs = new List<TextBox> {this.nombrePuerto};
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
                return false;
            }
            return true;
        }

        private void createPort()
        { 
            
        }

        private void updatePort()
        {
        }

    }
}
