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

namespace FrbaCrucero.AbmRol
{
    public partial class AltaFuncionalidad : Form
    {

        RolDao rDao;

        public AltaFuncionalidad()
        {
            InitializeComponent();
            rDao = new RolDao();
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            this.rDao.createFunction(this.textFunc.Text);
            this.Close();
        }
    }
}
