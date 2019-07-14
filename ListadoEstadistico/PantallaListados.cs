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

namespace FrbaCrucero.ListadoEstadistico
{
    public partial class PantallaListados : Form
    {
        private CruceroDao cruceroDao;
        private CompraDao compraDao;
        private String fecha1;
        private String fecha2;

        public PantallaListados()
        {
            cruceroDao = new CruceroDao();
            compraDao = new CompraDao();
            InitializeComponent();
        }

        public void setupCombos()
        {
        }

        public void setupGrid()
        {
//            this.listadosGrid.DataSource = dao.getAllCruises();
        }

        private void genListado_Click(object sender, EventArgs e)
        {
            try
            {
                //this.listadosGrid.Rows.Clear();
                String listadoElegido = this.comboTipoListado.SelectedItem as String;
                String semestre = this.comboSemestre.SelectedItem as String;
                String anio = this.textFecha.Text;

                if (semestre == "Primer semestre")
                {
                    fecha1 = "'" + anio + '-' + "01-01" + "'";
                    fecha2 = "'" + anio + '-' + "06-30" + "'";
                }
                else
                {
                    fecha1 = "'" + anio + '-' + "07-01" + "'";
                    fecha2 = "'" + anio + '-' + "12-31" + "'";
                }

                switch (listadoElegido)
                {
                    case "Recorridos con mayor cantidad de pasajes comprados":
                        this.listadosGrid.DataSource = compraDao.getTopRecorridosVendidos(fecha1, fecha2);
                        break;

                    case "Recorridos con mas cabinas libres en cada viaje realizado":
                        MessageBox.Show(fecha1);
                        MessageBox.Show(fecha2);

                        break;

                    case "Cruceros con mayor cantidad de dias fuera de servicio":
                        MessageBox.Show("listado 3");
                        this.listadosGrid.DataSource = cruceroDao.getAllCruises();
                        break;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error generando el listado solicitado");
            }    
        }



    }
}
