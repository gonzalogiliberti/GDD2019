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
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.Login;

namespace FrbaCrucero
{
    public partial class PaginaPrincipal : Form
    {
        Roles r = new Roles();
        List<int> funciones;

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

        private void compraReserva_Click(object sender, EventArgs e)
        {
            CompraReserva c = new CompraReserva();
            c.ShowDialog();
        }

        private void payReserve_Click(object sender, EventArgs e)
        {
            PagarReserva p = new PagarReserva();
            p.ShowDialog();
        }

        private void login_Click(object sender, EventArgs e)
        {
            LoginForm l = new LoginForm();
            DialogResult res = l.ShowDialog();
            if (res == DialogResult.OK)
            {
                funciones = l.funciones;
                showButtons();
            }

        }
        private void showButtons()
        {
            foreach (int f in funciones)
            {
                switch(f)
                {
                    case 1:
                        roles.Visible = true;
                        break;
                    case 2:
                        puertos.Visible = true;
                        break;
                    case 3:
                        recorrido.Visible = true;
                        break;
                    case 4:
                        crucero.Visible = true;
                        break;
                    case 5:
                        genViaje.Visible = true;
                        break;
                    case 14:
                        //.Visible = true;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
