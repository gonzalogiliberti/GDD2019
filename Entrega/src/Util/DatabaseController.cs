using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace FrbaCrucero.Util
{
    class DatabaseController
    {
        private static DatabaseController instance = null;

        private SqlConnection connectionString;

        string user = ConfigurationManager.AppSettings["user"].ToString();
        string password = ConfigurationManager.AppSettings["password"].ToString();
        string server = ConfigurationManager.AppSettings["server"].ToString();

        public DatabaseController()
        {
            createConnection();
        }

        public void createConnection()
        {
            string connection = "Server="+server+"\\SQLSERVER2012;DATABASE=GD1C2019;UID="+user+";Password="+password;
            connectionString = new SqlConnection(connection);
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

        public SqlConnection getConnectionString()
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

        public int executeProcedureWithParametersReturnInt(String query, Dictionary<String, Object> dictionary, Dictionary<String, Object> returnParams)
        {
            int res = 0;
            try
            {
                openConnection();
                SqlCommand command = new SqlCommand(query, getConnectionString());
                foreach (String key in dictionary.Keys)
                {
                    command.Parameters.AddWithValue(key, dictionary[key]);
                }
                foreach (String key in returnParams.Keys)
                {
                    command.Parameters.Add(key, dictionary[key]).Direction = ParameterDirection.Output;
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
            return (int)res;
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
