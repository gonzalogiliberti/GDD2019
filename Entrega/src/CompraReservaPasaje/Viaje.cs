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

        public Viaje(DataRow r)
        {
            this.idViaje = Convert.ToInt32(r["idViaje"]);
            this.idCrucero = Convert.ToInt32(r["idCrucero"]);
            this.idRecorrido = Convert.ToInt32(r["idRecorrido"]);
            this.fechaInicio = Convert.ToDateTime(r["FechaInicio"]);
            this.fechaFin = Convert.ToDateTime(r["FechaFin"]);
        }
    }
}
