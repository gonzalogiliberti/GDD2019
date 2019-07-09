using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace FrbaCrucero.AbmRecorrido
{
    class Recorrido
    {
        public Int32 idRecorrido;
        public Decimal codigo;

        public Recorrido(DataRow row)
        {
            this.idRecorrido = Convert.ToInt32(row["idRecorrido"]);
            this.codigo = Convert.ToDecimal(row["codigo"]);
        }

        public Recorrido(Decimal code)
        {
            this.codigo = code;
        }

        public override string ToString()
        {
            return this.codigo.ToString();
        }
        
        public Int32 getId()
        {
            return idRecorrido;
        }

        public String getPuerto()
        {
            return codigo.ToString();
        }

    }
}
