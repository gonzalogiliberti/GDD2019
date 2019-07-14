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
            if (newPort)
            {
                createPort();   
            }
            else
            {
                updatePort();
            }
        }

        private void CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> {this.nombrePuerto};
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void createPort()
        {
            try
            {
                CheckEmptyFields();
                Puerto port = getFormData();
                if (this.dao.verifyPortExisted(port) != 0)
                {
                    throw new Exception("El Puerto Ingresado ya existe");
                }
                this.dao.createPort(port);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void updatePort()
        {
            try
            {
                CheckEmptyFields();
                Puerto port = getFormData();
                port.idPuerto = (int)this.unPuerto.Cells["idPuerto"].Value;
                if (port.getPuerto() != this.unPuerto.Cells["Puerto"].Value.ToString())
                {
                    if (this.dao.verifyPortExisted(port) != 0)
                    {
                        throw new Exception("El Puerto Ingresado ya existe");
                    }
                }
                this.dao.updatePort(port);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private Puerto getFormData()
        {
            return new Puerto(this.nombrePuerto.Text);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad no disponible");
        }

    }
}
