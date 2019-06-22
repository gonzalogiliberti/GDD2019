using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;
using FrbaCrucero.AbmPuerto;

namespace FrbaCrucero.Dao
{
    class PuertoDao
    {
        private DatabaseController db;

        public PuertoDao()
        {
            db = DatabaseController.getInstance();
        }

        public DataTable getAllPuertos()
        {
            return db.select_query("Select idPuerto, Nombre AS puerto from dbo.Puerto");
        }

        public List<Puerto> getPuertos()
        {
            List<Puerto> puertos = new List<Puerto>();
            DataTable dt = db.select_query("SELECT PUERTOS.idPuerto AS IdPuerto, PUERTOS.Nombre AS Puerto FROM dbo.Puerto PUERTOS");

            foreach (DataRow row in dt.Rows)
            {
                puertos.Add(new Puerto(row));
            }

            return puertos;
        }
    }
}
