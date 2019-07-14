using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;

namespace FrbaCrucero.Dao
{
    class RolDao
    {
        DatabaseController db;

        public RolDao()
        {
            db = DatabaseController.getInstance();
        }

        public DataTable getRoles()
        {
            return db.select_query("Select idRol , rol_Nombre from JavaPorter.Rol");
        }

        // Retorna todas la funcionalidades asignadas al rol
        public DataTable getFuncByRol(int rolId)
        {
            return db.select_query("select f.idFuncion as idFuncionalidad, f.nombre as Funcionalidad from JavaPorter.RolxFuncion rf join JavaPorter.Funcion f on rf.idFuncion = f.idFuncion where rf.idRol = " + rolId);
        }

        // Retornas todas las funcionalidad existes que no posee el rol
        public DataTable getFuncAvailable(int rolId)
        {
            return db.select_query("select idFuncion, nombre from JavaPorter.Funcion where idFuncion not in (select f.idFuncion from JavaPorter.RolxFuncion rf join JavaPorter.Funcion f on rf.idFuncion = f.idFuncion where rf.idRol = " + rolId + " )");
        }

        public void removeFunctionFromRol(int idRol, int idFunc)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idRol", idRol);
            dic.Add("@idFunc", idFunc);

            db.executeProcedureWithParameters("JavaPorter.sp_eliminar_funcxrol", dic);
        }

        public void createFunction(String description)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@funcionNombre", description);

            db.executeProcedureWithParameters("JavaPorter.sp_crear_funcion", dic);
        }

        public void createRol(String name)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@rolName", name);

            db.executeProcedureWithParameters("JavaPorter.sp_crear_rol", dic);
        }

        public void updateRol(String name, int idRol)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@name", name);
            dic.Add("@idRol", idRol);

            db.executeProcedureWithParameters("JavaPorter.sp_update_rol", dic);
        }

        public void deleteRol(String name)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@rolName", name);

            db.executeProcedureWithParameters("JavaPorter.sp_eliminar_rol", dic);
        }

        public int verifyRolExisted(String rolName)
        {
            DataTable dt = db.select_query("Select R.idRol from JavaPorter.Rol R where R.rol_Nombre = '" + rolName + "';");
            if (dt.Rows.Count != 0)
            {
                return 1;
            }
            return 0;
        }

        public void setFuncRol(int idFunc, int idRol)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idRol", idRol);
            dic.Add("@idFunc", idFunc);

            db.executeProcedureWithParameters("JavaPorter.sp_set_funcxrol", dic);
        }
    }
}
