using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;
using System.Windows.Forms;
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

        public int verifyPortExisted(Puerto port)
        {
            DataTable dt = db.select_query("Select PUERTOS.idPuerto from dbo.Puerto PUERTOS where PUERTOS.Nombre = '" + port.getPuerto() + "';");
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }

        public void createPort(Puerto port)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@Nombre", port.getPuerto());

            db.executeProcedureWithParameters("cbo.sp_crear_puerto",dic);
        }

        public void updatePort(Puerto port)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@IdPuerto", port.getId());
            dic.Add("@Nombre", port.getPuerto());

            db.executeProcedureWithParameters("cbo.sp_modificar_puerto", dic);
        }

        public void deletePort(DataGridViewRow unPuerto)
        {
            Int32 idPuerto = (int)unPuerto.Cells["IdPuerto"].Value;
            String nombrePuerto = unPuerto.Cells["Puerto"].Value.ToString();

            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@IdPuerto", idPuerto);
            dic.Add("@Nombre", nombrePuerto);
            db.executeProcedureWithParameters("cbo.sp_borrar_puerto", dic);
        }
    }
}
