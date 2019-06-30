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

            db.executeProcedureWithParameters("cbo.sp_crear_crucero", dic);
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

            db.executeProcedureWithParameters("cbo.sp_modificar_crucero", dic);
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

            db.executeProcedureWithParameters("cbo.sp_eliminar_crucero", dic);
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

        public List<Crucero> getCrucerosDisponibles(String f1, String f2)
        {
            //TODO: Ver como obtener solo los cruceros disponibles en esas fechas
            List<Crucero> cruceros = new List<Crucero>();
            DataTable dt = getAllCruises();

            foreach (DataRow row in dt.Rows)
            {
                cruceros.Add(new Crucero(row));
            }

            return cruceros;
        }
    }
}
