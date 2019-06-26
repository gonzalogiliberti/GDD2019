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

namespace FrbaCrucero
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
    }
}
