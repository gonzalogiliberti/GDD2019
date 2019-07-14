using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FrbaCrucero.AbmRecorrido
{
    class Tramo
    {
        public Int32 idTramo;
        public Int32 idPuertoOrigen;
        public Int32 idPuertoDestino;
        public Int32 precio;

        public Tramo() { }

        public Tramo(Int32 puertoOri, Int32 puertoDes, Int32 precio)
        {
            this.idPuertoOrigen = puertoOri;
            this.idPuertoDestino = puertoDes;
            this.precio =  precio;
        }

        public Tramo(DataRow row)
        {
            this.idTramo = Convert.ToInt32(row["idTramo"]);
            this.idPuertoOrigen = Convert.ToInt32(row["puertoOrigen"]);
            this.idPuertoDestino = Convert.ToInt32(row["puertoDestino"]);
            this.precio = Convert.ToInt32(row["precioBase"]);
        }
       
    }
}
