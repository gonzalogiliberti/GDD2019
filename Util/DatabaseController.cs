using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero.Util
{
    class DatabaseController
    {
        private static DatabaseController instance = null;

        private SqlConnection connectionString;

        public DatabaseController()
        {
            createConnection();
        }

        public void createConnection()
        {
            string connection = "Data Source=local; Initial Catalog=GD1C2019; User ID=sa; Password= gestiondedatos";
            connectionString = new SqlConnection(connection);
            connectionString.Open();
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

        private SqlConnection getConnectionString()
        {
            return this.connectionString;
        }

        public void openConnection()
        {
            getConnectionString().Open();
        }

        public void closeConnection()
        {
            getConnectionString().Close();
        }

        public void query(String query)
        {
            try
            {
                openConnection();
                SqlCommand queryCommand = new SqlCommand(query, getConnectionString());
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                closeConnection();
            }
            catch (SqlException ex)
            {
                closeConnection();
                SqlExceptionManager.handlerException(ex);
            }

        }

        public void executeQueryWithParameters(String query, Dictionary<String, Object> dictionary)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand(query, getConnectionString());
                foreach (String key in dictionary.Keys)
                {
                    command.Parameters.AddWithValue(key, dictionary[key]);
                }
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (SqlException ex)
            {
                closeConnection();
                SqlExceptionManager.handlerException(ex);
            }


        }

        public void executeProcedureWithParameters(String query, Dictionary<String, Object> dictionary)
        {
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand(query, getConnectionString());
                foreach (String key in dictionary.Keys)
                {
                    command.Parameters.AddWithValue(key, dictionary[key]);
                }
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                closeConnection();
            }
            catch (SqlException ex)
            {
                closeConnection();
                SqlExceptionManager.handlerException(ex);
            }
        }


        public DataTable select_query(String query)
        {

            try
            {
                openConnection();
                SqlCommand queryCommand = new SqlCommand(query, getConnectionString());
                SqlDataReader queryCommandReader = queryCommand.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(queryCommandReader);
                closeConnection();
                return dataTable;
            }

            catch (SqlException ex)
            {
                SqlExceptionManager.handlerException(ex);
                return null;
            }

        }
    }
}
