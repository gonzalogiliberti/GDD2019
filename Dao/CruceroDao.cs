using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;
using FrbaCrucero.AbmCrucero;

namespace FrbaCrucero.Dao
{
    class CruceroDao
    {
        DatabaseController db;

        public CruceroDao()
        {
            db = DatabaseController.getInstance();
        }

        public DataTable getAllCruises()
        {
            return db.select_query("Select intCrucero as idCrucero, Modelo, Identificador, Fabricante as IdFabricante, (select F.Nombre from dbo.Fabricante F where F.idFabricante = Fabricante) as Fabricante, CantidadCabinas, FechaAlta  from dbo.Crucero");
        }

        public List<Fabricante> getFabricantes()
        {
            List<Fabricante> fabricantes = new List<Fabricante>();
            DataTable dt = db.select_query("SELECT FAB.idFabricante AS IdFabricante, FAB.Nombre AS Fabricante FROM dbo.Fabricante FAB");

            foreach (DataRow row in dt.Rows)
            {
                fabricantes.Add(new Fabricante(row));
            }

            return fabricantes;
        }

        public List<String> getModelos()
        {
            List<String> modelos = new List<String>();
            DataTable dt = db.select_query("SELECT Distinct(Modelo) FROM dbo.Crucero");

            foreach (DataRow row in dt.Rows)
            {
                modelos.Add(Convert.ToString(row["Modelo"]));
            }

            return modelos;
        }

        public List<Crucero> getCruceros()
        {
            List<Crucero> cruceros = new List<Crucero>();
            DataTable dt = getAllCruises();

            foreach (DataRow row in dt.Rows)
            {
                cruceros.Add(new Crucero(row));
            }

            return cruceros;
        }

        public int verifyCruiseExisted(Crucero cruise)
        {
            DataTable dt = db.select_query("Select CRU.intCrucero from dbo.Crucero CRU where CRU.Identificador = '" + cruise.getIdentificador() + "';");
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }

        public void createCruise(Crucero cruise)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@Identificador", cruise.getIdentificador());
            dic.Add("@Modelo", cruise.getModelo());
            dic.Add("@IdFabricante", cruise.getIdFabricante());
            dic.Add("@FechaAlta", cruise.getFechaAlta());
            dic.Add("@CantCabinas", cruise.getCantidadCabinas());

            db.executeProcedureWithParameters("dbo.sp_crear_crucero", dic);
        }

        public void updateCruise(Crucero cruise)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@IdCrucero", cruise.getIdCrucero());
            dic.Add("@Identificador", cruise.getIdentificador());
            dic.Add("@Modelo", cruise.getModelo());
            dic.Add("@IdFabricante", cruise.getIdFabricante());
            dic.Add("@FechaAlta", cruise.getFechaAlta());
            dic.Add("@CantCabinas", cruise.getCantidadCabinas());

            db.executeProcedureWithParameters("dbo.sp_modificar_crucero", dic);
        }

        public void deleteCruise(Crucero cruise)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@IdCrucero", cruise.getIdCrucero());
            dic.Add("@Identificador", cruise.getIdentificador());
            dic.Add("@Modelo", cruise.getModelo());
            dic.Add("@IdFabricante", cruise.getIdFabricante());
            dic.Add("@FechaAlta", cruise.getFechaAlta());
            dic.Add("@CantCabinas", cruise.getCantidadCabinas());

            db.executeProcedureWithParameters("dbo.sp_eliminar_crucero", dic);
        }

        public DataTable searchCruise(Fabricante fabricante, String model, String identificador)
        {

            String where = getWhereClause(fabricante, model, identificador);
            return db.select_query("Select intCrucero as idCrucero, Modelo, Identificador, Fabricante as IdFabricante, (select F.Nombre from dbo.Fabricante F where F.idFabricante = Fabricante) as Fabricante, CantidadCabinas, FechaAlta  from dbo.Crucero " + where);
        }

        public String getWhereClause(Fabricante fabricante, String model, String identificador)
        {
            String where = " where ";
            if (model != null)
            {
                where += "Modelo like '%" + model + "%'";
            }
            else
            {
                where += "Modelo like '%" + "" + "%'";
            }

            if (identificador != "")
            {
                where += " and Identificador like '%" + identificador + "%'";
            }
            else
            {
                where += " and Identificador like '%" + "" + "%'";
            }

            if (fabricante != null)
            {
                where += "and Fabricante = " + fabricante.getId();
            }
            return where;
        }

        public List<Crucero> getCrucerosDisponibles(DateTime f1, DateTime f2)
        {

            List<Crucero> cruceros = new List<Crucero>();
            string query = " select c.intCrucero as idCrucero, c.Modelo, c.Identificador, c.Fabricante as IdFabricante, (select F.Nombre from dbo.Fabricante F where F.idFabricante = Fabricante) as Fabricante, ISNULL(c.CantidadCabinas, 0) AS CantidadCabinas, ISNULL(c.FechaAlta, GETDATE()) AS FechaAlta from Crucero c where ";
            query += "c.intCrucero not in ( select v1.idCrucero from Viaje v1 where '" + f1 + "' between v1.FechaInicio and v1.FechaFin) and ";
            query += "c.intCrucero not in ( select v2.idCrucero from Viaje v2 where '" + f2 + "' between v2.FechaInicio and v2.FechaFin) and ";
            query += "c.intCrucero not in ( select v3.idCrucero from Viaje v3 where v3.FechaInicio between '" + f1 + "' and '" + f2 + "') and ";
            query += "c.intCrucero not in ( select v4.idCrucero from Viaje v4 where v4.FechaFin between '" + f1 + "' and '" + f2 + "') ";

            DataTable dt = db.select_query(query);

            foreach (DataRow row in dt.Rows)
            {
                cruceros.Add(new Crucero(row));
            }

            return cruceros;
        }

        public int getTipoCabinaId(int idCabina)
        {
            DataTable dt = db.select_query("select c.TipoCabina from Cabina c where idCabina = " + idCabina);
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["TipoCabina"]);
        }

        public TipoCabina getTipoCabina(int tipo)
        {
            DataTable dt = db.select_query("select * from TipoCabina where idTipoCabina = " + tipo);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            DataRow r = dt.Rows[0];
            return new TipoCabina(r);
        }

        public void createCabinas(int cantPisos, int cantCabinas, int tipo, int crucero)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@pisos", cantPisos);
            dic.Add("@cabinas", cantCabinas);
            dic.Add("@tipo", tipo);
            dic.Add("@crucero", crucero);

            db.executeProcedureWithParameters("dbo.sp_crear_cabinas", dic);
        }

        public int getIdCrucero(Crucero cruise)
        {
            DataTable dt = db.select_query("Select CRU.intCrucero from dbo.Crucero CRU where CRU.Identificador = '" + cruise.getIdentificador() + "'");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["intCrucero"]);
        }

        public int getIdEstandar()
        {
            DataTable dt = db.select_query("select idTipoCabina from TipoCabina where Recargo = 1.20");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idTipoCabina"]);
        }

        public int getIdExterior()
        {
            DataTable dt = db.select_query("select idTipoCabina from TipoCabina where Recargo = 1.40");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idTipoCabina"]);
        }

        public int getIdBalcon()
        {
            DataTable dt = db.select_query("select idTipoCabina from TipoCabina where Recargo = 1.60");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idTipoCabina"]);
        }

        public int getIdSuite()
        {
            DataTable dt = db.select_query("select idTipoCabina from TipoCabina where Recargo = 1.80");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idTipoCabina"]);
        }

        public int getIdEjecutivo()
        {
            DataTable dt = db.select_query("select idTipoCabina from TipoCabina where Recargo = 2.00");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idTipoCabina"]);
        }
    }
}
