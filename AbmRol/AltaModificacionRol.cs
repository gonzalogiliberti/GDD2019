using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Util;
using FrbaCrucero.Dao;

namespace FrbaCrucero.AbmRol
{
    public partial class AltaModificacionRol : Form
    {

        RolDao rDao;
        bool newRol = true;
        public DataGridViewRow unRol;


        public AltaModificacionRol()
        {
            InitializeComponent();
            rDao = new RolDao();
        }

        public AltaModificacionRol(DataGridViewRow unRol)
        {
            InitializeComponent();
            rDao = new RolDao();
            this.unRol = unRol;
            newRol = false;
            this.textRol.Text = unRol.Cells["Rol"].Value.ToString();
            setupGrid((int)unRol.Cells["idRol"].Value);
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void setupGrid(int rolId)
        {
            this.dgvFuncionalidad.DataSource = rDao.getFuncByRol(rolId);
        }

        private void addFunction_Click(object sender, EventArgs e)
        {
            if (!newRol)
            {
                Funcionalidades modificacion = new Funcionalidades((int)unRol.Cells["idRol"].Value);
                modificacion.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FuncionalidadesCerrada);
                modificacion.Show();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Debe Guardar Primero el Rol antes de asignar Funcionalidad");
            }
        }

        private void deleteFuncionalidad_Click(object sender, EventArgs e)
        {
            RemoverFuncionalidad r = new RemoverFuncionalidad((int)unRol.Cells["idRol"].Value);
            r.FormClosed += new System.Windows.Forms.FormClosedEventHandler(FuncionalidadesCerrada);
            r.Show();
        }

        private void FuncionalidadesCerrada(object sender, FormClosedEventArgs e)
        {
            this.setupGrid((int)unRol.Cells["idRol"].Value);
        }

        private void save_Click(object sender, EventArgs e)
        {
            CheckEmptyFields();
            if (newRol)
            {
                if (rDao.verifyRolExisted(this.textRol.Text) != 0)
                {
                    System.Windows.Forms.MessageBox.Show("Ya existe un rol con el nombre ingresado");
                }
                rDao.createRol(this.textRol.Text);
            }
            else
            {
                if (this.textRol.Text != unRol.Cells["rol_Nombre"].Value.ToString())
                {
                    if (rDao.verifyRolExisted(this.textRol.Text) != 0)
                    {
                        System.Windows.Forms.MessageBox.Show("Ya existe un rol con el nombre ingresado");
                    }
                    rDao.updateRol(this.textRol.Text, (int)unRol.Cells["idRol"].Value);
                }
            }
        }

        private void CheckEmptyFields()
        {
            List<TextBox> inputs = new List<TextBox> { this.textRol };
            if (inputs.Any((t) => t.Text == ""))
            {
                MessageBox.Show("Complete todos los campos");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

        }
    }
}
