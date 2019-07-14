using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaCrucero.Util;
using FrbaCrucero.Dao;

namespace FrbaCrucero.Login
{
    public partial class LoginForm : Form
    {
        LoginDao dao;
        CompraDao cDao;
        public List<int> funciones;

        public LoginForm()
        {
            InitializeComponent();
            dao = new LoginDao();
            cDao = new CompraDao();
        }

        private void aceotarBtn_Click(object sender, EventArgs e)
        {
            int idRol = dao.loginUser(userBox.Text ,passBox.Text);

            if (idRol == 0)
            {
                //wrong password
                MessageBox.Show("Wrong Password or User", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dao.getFunciones(idRol);
            }
            else if (idRol == -1)
            {
                MessageBox.Show("Usuario Bloqueado ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idRol == -2)
            {
                MessageBox.Show("Error al ejecutar el login", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (idRol > 0)
            {
                //gets funciones x rol
                funciones = dao.getFunciones(idRol);
            }
            this.DialogResult = DialogResult.OK;
            cDao.marcarVencidasReservas(DateUtils.getDateFromConfig());
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
