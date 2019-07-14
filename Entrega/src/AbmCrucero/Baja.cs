using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public partial class Baja : Form
    {

        Crucero crucero;

        public Baja()
        {
            InitializeComponent();
        }

        public Baja(Crucero unCrucero)
        {
            InitializeComponent();
            this.crucero = unCrucero;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void vidaUtil_Click(object sender, EventArgs e)
        {
            BajaEfectiva be = new BajaEfectiva(crucero, true);
            be.Show();
        }

        private void fueraServicio_Click(object sender, EventArgs e)
        {
            BajaEfectiva be = new BajaEfectiva(crucero, false);
            be.Show();
        }
    }
}
