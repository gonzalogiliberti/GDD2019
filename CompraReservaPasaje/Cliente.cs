using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaCrucero.CompraReservaPasaje
{
    class Cliente
    {

        public int idCliente;
        public string nombre;
        public string apellido;
        public string mail;
        public string direccion;
        public int telefono;
        public decimal dni;
        public DateTime fechaNac;


        public Cliente(DataRow unCliente)
        {
            nombre = Convert.ToString(unCliente["Nombre"]);
            apellido = Convert.ToString(unCliente["Apellido"]);
            direccion = Convert.ToString(unCliente["direccion"]);
            mail = Convert.ToString(unCliente["mail"]);
            fechaNac = Convert.ToDateTime(unCliente["fechaNac"]);
            telefono = Convert.ToInt32(unCliente["telefono"]);
            dni = Convert.ToDecimal(unCliente["dni"]);
            idCliente = Convert.ToInt32(unCliente["idCliente"]);
        }


    }
}
