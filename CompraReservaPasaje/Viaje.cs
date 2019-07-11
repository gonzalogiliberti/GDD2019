using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class Viaje
    {
        public int idViaje;
        public DateTime fechaInicio;
        public DateTime fechaFin;
        public int idCrucero;
        public int idRecorrido;

        public Viaje(DataGridViewRow unViaje)
        {
            this.idViaje = (int)unViaje.Cells["idViaje"].Value;
            this.idCrucero = (int)unViaje.Cells["idCrucero"].Value;
            this.idRecorrido = (int)unViaje.Cells["idRecorrido"].Value;
            this.fechaInicio = Convert.ToDateTime(unViaje.Cells["fechaInicio"].Value);
            this.fechaFin = Convert.ToDateTime(unViaje.Cells["fechaFin"].Value);

        }

    }
}
