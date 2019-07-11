using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero
{
    public class TipoCabina
    {
        public int idTipo;
        public string tipo;
        public decimal recargo;

        public TipoCabina(DataGridViewRow unaCabina)
        {
            this.idTipo = (int)unaCabina.Cells["idTipo"].Value;
            this.tipo = unaCabina.Cells["Tipo"].Value.ToString();
            this.recargo = (decimal)unaCabina.Cells["Recargo"].Value;
        }

        public TipoCabina(DataRow unaCabina)
        {
            this.idTipo = Convert.ToInt32(unaCabina["idTipoCabina"]);
            this.tipo = Convert.ToString(unaCabina["Nombre"]);
            this.recargo = Convert.ToDecimal(unaCabina["Recargo"]);
        }
    }
}
