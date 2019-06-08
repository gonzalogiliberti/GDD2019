using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrbaCrucero.Util
{
    class DatabaseController
    {
        private static DatabaseController instance = null;

        private SqlConnection conn;

        public void createConnection()
        {
            string connectionString = "Data Source=local; Initial Catalog=GD1C2019; User ID=sa; Password= gestiondedatos";
            conn = new SqlConnection(connectionString);
            conn.Open();
        }

        public static DatabaseController getInstance()
        {
            if(instance == null)
            {
                instance = new DatabaseController();
                return instance;
            }
            return instance;
        }

        public SqlConnection getConnection()
        {
            return conn;
        }
    }
}
