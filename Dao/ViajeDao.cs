using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;

namespace FrbaCrucero.Dao
{
    class ViajeDao
    {
        DatabaseController db;

        public ViajeDao()
        {
            this.db = DatabaseController.getInstance();
        }

        public void createViaje(DateTime fIni, DateTime fFin, int idRecorrido, int idCrucero)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@fechaInicio", fIni);
            dic.Add("@fechaFin", fFin);
            dic.Add("@idCrucero", idCrucero);
            dic.Add("@idRecorrido", idRecorrido);

            db.executeProcedureWithParameters("JavaPorter.sp_crear_viaje", dic);
        }
    }
}
