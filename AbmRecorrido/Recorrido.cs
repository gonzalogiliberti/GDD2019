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
        public String codigo;

        public Recorrido(DataRow row)
        {
            this.idRecorrido = Convert.ToInt32(row["idRecorrido"]);
            this.codigo = Convert.ToString(row["Codigo"]);
        }
    }
}
