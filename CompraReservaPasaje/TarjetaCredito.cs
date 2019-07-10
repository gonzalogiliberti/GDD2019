using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.CompraReservaPasaje
{
    class TarjetaCredito
    {
        public string nombre;
        public int coutas;

        public TarjetaCredito()
        {
        }

        public TarjetaCredito(string name, int cou)
        {
            this.nombre = name;
            this.coutas = cou;
        }

        public override string ToString()
        {
            return this.nombre;
        }

        public String getTarjetaCredito()
        {
            return nombre;
        }
    }
}
