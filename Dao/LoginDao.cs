using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Data.SqlClient;

using FrbaCrucero.Util; //DatabaseController
using FrbaCrucero.AbmPuerto;

namespace FrbaCrucero.Dao
{
    class LoginDao
    {
        private DatabaseController db;

        public LoginDao() 
        {
            db = DatabaseController.getInstance();
        }

       
        public int loginUser(string user, string pass)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@user", user);
            dic.Add("@pass", sha256(pass));

            int res = -2;
            try
            {
                db.openConnection();
                SqlCommand command = new SqlCommand("dbo.sp_login", db.getConnectionString());
                command.Parameters.AddWithValue("@usr", user);
                command.Parameters.AddWithValue("@pass", sha256(pass));
                command.Parameters.Add("@res", SqlDbType.Int).Direction = ParameterDirection.Output;
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                res = (int)command.Parameters["@res"].Value;
                db.closeConnection();
            }
            catch (SqlException ex)
            {
                db.closeConnection();
                SqlExceptionManager.handlerException(ex);
            }
            return (int)res;
        }

        public List<int> getFunciones(int idRol)
        {
            List<int> funciones = new List<int>();
            DataTable res = db.select_query("select F.idFuncion, F.nombre from dbo.RolxFuncion RF join Funcion F on RF.idFuncion = F.idFuncion where idRol = " + idRol.ToString());
            foreach (DataRow row in res.Rows)
            {
                funciones.Add((int)row.ItemArray[0]);
            }
            return funciones;
        }

        static string sha256(string pasword)
        {
            var crypt = new System.Security.Cryptography.SHA256Managed();
            var hash = new System.Text.StringBuilder();
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(pasword));
            foreach (byte theByte in crypto)
            {
                hash.Append(theByte.ToString("x2"));
            }
            return hash.ToString();
        }
    }
}
