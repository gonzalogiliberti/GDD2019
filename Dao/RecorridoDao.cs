using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;
using FrbaCrucero.AbmRecorrido;


namespace FrbaCrucero.Dao
{
    class RecorridoDao
    {

        DatabaseController db;

        public RecorridoDao()
        {
            db = DatabaseController.getInstance();
        }

        public DataTable getAllRecorridos()
        {
            return db.select_query("select r.idRecorrido AS idRecorrido, t.idTramo AS idTramo, r.codigo AS Codigo , t.puertoOrigen AS idPuertoOrigen, (Select p1.Nombre from Puerto p1 where p1.idPuerto = t.puertoOrigen) AS puertoOrigen, t.puertoDestino AS idPuertoDestino,(Select p2.Nombre from Puerto p2 where p2.idPuerto = t.puertoDestino) AS puertoDestino , t.precioBase AS Precio   from (Recorrido r join RecorridoXTramo rt on r.idRecorrido = rt.idRecorrido) join Tramo t on t.idTramo = rt.idTramo");
        }

        public DataTable getTramosForRecorrido(int idRecorrido)
        {
            return db.select_query("select t.idTramo AS idTramo,  t.puertoOrigen AS idPuertoOrigen, (Select p1.Nombre from Puerto p1 where p1.idPuerto = t.puertoOrigen) AS puertoOrigen, t.puertoDestino AS idPuertoDestino,(Select p2.Nombre from Puerto p2 where p2.idPuerto = t.puertoDestino) AS puertoDestino , t.precioBase AS Precio   from RecorridoXTramo rt join Tramo t on t.idTramo = rt.idTramo where rt.idRecorrido = " + idRecorrido + " order by rt.orden");
        }

        public DataTable getTramosAvailableRecorrido(int idRecorrido)
        {
            return db.select_query("select t.idTramo AS idTramo,  t.puertoOrigen AS idPuertoOrigen, (Select p1.Nombre from Puerto p1 where p1.idPuerto = t.puertoOrigen) AS puertoOrigen, t.puertoDestino AS idPuertoDestino,(Select p2.Nombre from Puerto p2 where p2.idPuerto = t.puertoDestino) AS puertoDestino , t.precioBase AS Precio from Tramo t join RecorridoXTramo rt on t.idTramo = rt.idTramo where t.idTramo not in (select t.idTramo  from RecorridoXTramo rt join Tramo t on t.idTramo = rt.idTramo where rt.idRecorrido = " + idRecorrido + ") order by t.idTramo desc  ");
        }

        public int verifyRecorridoExisted(String codigo)
        {
            DataTable dt = db.select_query("Select r.idRecorrido from dbo.Recorrido r where r.codigo = '" + codigo + "';");
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }

        public void createRecorrido(Decimal codigo)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@codigo", codigo);

            db.executeProcedureWithParameters("dbo.sp_crear_recorrido", dic);
        }

        public void updateRecorrido(Decimal codigo, int idRecorrido)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@codigo", codigo);
            dic.Add("@idRecorrido", idRecorrido);

            db.executeProcedureWithParameters("dbo.sp_modificar_recorrido", dic);
        }

        public void deleteRecorrido(int idRecorrido)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idRecorrido", idRecorrido);

            db.executeProcedureWithParameters("dbo.sp_eliminar_recorrido", dic);
        }

        public int verifyTramoExisted(Int32 puertoOrigen, Int32 puertoDestino)
        {
            DataTable dt = db.select_query("select t.idTramo from Tramo t where t.puertoOrigen = " + puertoOrigen +" and t.puertoDestino =" + puertoDestino + " ;");
            
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }

        public void createTramo(int puertoOrigen, int puertoDestino, int precio)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@puertoOrigen", puertoOrigen);
            dic.Add("@puertoDestino", puertoDestino);
            dic.Add("@precio", precio);

            db.executeProcedureWithParameters("dbo.sp_crear_tramo", dic);
        }

        public void updateTramo(int idTramo, int puertoOrigen, int puertoDestino, int precio)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idTramo", idTramo);
            dic.Add("@puertoOrigen", puertoOrigen);
            dic.Add("@puertoDestino", puertoDestino);
            dic.Add("@precio", precio);

            db.executeProcedureWithParameters("dbo.sp_modificar_tramo", dic);
        }

        public void deleteTramoFromRecorrido(int idTramo, int idRecorrido)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idTramo", idTramo);
            dic.Add("@idRecorrido", idRecorrido);

            db.executeProcedureWithParameters("dbo.sp_eliminar_recorridoxtramo", dic);
        }

        public void deleteTramo(int idTramo)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idTramo", idTramo);

            db.executeProcedureWithParameters("dbo.sp_eliminar_tramo", dic);
        }

        public List<Recorrido> getRecorridos()
        {
            List<Recorrido> recorridos = new List<Recorrido>();
            DataTable dt = db.select_query("SELECT R.idRecorrido AS idRecorrido, R.codigo AS codigo FROM dbo.Recorrido R");

            foreach (DataRow row in dt.Rows)
            {
                recorridos.Add(new Recorrido(row));
            }

            return recorridos;
        }

        public void setRecorridoXTramo(int idRecorrido, int idTramo)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idTramo", idTramo);
            dic.Add("@idRecorrido", idRecorrido);

            db.executeProcedureWithParameters("dbo.sp_set_recorridoxtramo", dic);
        }

        public int getIdRecorrido(Decimal codigo)
        {
            DataTable dt = db.select_query("SELECT R.idRecorrido FROM dbo.Recorrido R where R.codigo = " + codigo);
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idRecorrido"]);
        }

        public int getPrecioFinal(int idRecorrido)
        {
            DataTable dt = db.select_query("select sum(t.precioBase) as PrecioFinal  from RecorridoXTramo rt, Tramo t where rt.idRecorrido  = "+ idRecorrido +" and rt.idTramo = t.idTramo");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["PrecioFinal"]);
        }

        public String getPuertoOrigenRecorrido(int idRecorrido)
        {
            DataTable dt = getTramosForRecorrido(idRecorrido);
            DataRow r = dt.Rows[0];

            return Convert.ToString(r["puertoOrigen"]);
        }

        public String getPuertoDestinoRecorrido(int idRecorrido)
        {
            DataTable dt = getTramosForRecorrido(idRecorrido);
            int lastTramo = dt.Rows.Count - 1;
            DataRow r = dt.Rows[lastTramo];

            return Convert.ToString(r["puertoDestino"]);
        }
    }
}
