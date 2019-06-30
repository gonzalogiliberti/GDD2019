using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.AbmPuerto;
using FrbaCrucero.AbmCrucero;
using FrbaCrucero.AbmRecorrido;
using FrbaCrucero.GeneracionViaje;
using FrbaCrucero.AbmRol;

namespace FrbaCrucero
{
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }

        private void puertos_Click(object sender, EventArgs e)
        {
            Puertos p = new Puertos();
            p.ShowDialog();
        }

        private void crucero_Click(object sender, EventArgs e)
        {
            Cruceros c = new Cruceros();
            c.ShowDialog();
        }

        private void recorrido_Click(object sender, EventArgs e)
        {
            Recorridos r = new Recorridos();
            r.ShowDialog();
        }

        private void genViaje_Click(object sender, EventArgs e)
        {
            GeneracionViajes g = new GeneracionViajes();
            g.ShowDialog();
        }

        private void roles_Click(object sender, EventArgs e)
        {
            Roles r = new Roles();
            r.ShowDialog();
        }
    }
}
