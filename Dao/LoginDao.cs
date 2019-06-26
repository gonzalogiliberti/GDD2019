using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

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

        // TODO return user?
        public bool loginUser(string user, string pass)
        {
            // TODO Agregar llamada al login, deberia ser una funcion por razones de seguridad?
            return true;
        }
    }
}
