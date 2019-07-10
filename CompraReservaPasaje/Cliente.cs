using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class Cliente
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

        public Cliente(string name, string lastName, string mail, string direccion, int telef, decimal doc, DateTime date)
        {
            this.nombre = name;
            this.apellido = lastName;
            this.direccion = direccion;
            this.mail = mail;
            this.telefono = telef;
            this.dni = doc;
            this.fechaNac = date;
        }


    }
}
