using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
       
    }
}
