using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    class MedioPAgo
    {
        public Int32 idMedioPago;
        public String Nombre;

        public MedioPAgo(DataRow row)
        {
            this.idMedioPago = Convert.ToInt32(row["idMedioPago"]);
            this.Nombre = Convert.ToString(row["Nombre"]);
        }

        public MedioPAgo(DataGridViewRow unFabricante)
        {
            this.idMedioPago = (int)unFabricante.Cells["idMedioPago"].Value;
            this.Nombre = (string)unFabricante.Cells["Nombre"].Value;
        }

        public override string ToString()
        {
            return this.Nombre;
        }

        public Int32 getId()
        {
            return idMedioPago;
        }

        public String getMedioPAgo()
        {
            return Nombre;
        }
    }
}
