﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;

namespace FrbaCrucero.Dao
{
    class CompraDao
    {

        DatabaseController db;

        public CompraDao()
        {
            db = DatabaseController.getInstance();
        }

        public DataTable getAllTrips(int pOri, int pDest, DateTime inicio)
        {
            
            string query = "select V.idViaje, t.puertoOrigen AS idPuertoOri, p1.Nombre AS PuertoOri, t.puertoDestino AS idPuertoDest, p2.Nombre as PuertoDest, V.FechaInicio, V.FechaFin, c.intCrucero as idCrucero, c.Identificador from Viaje V, RecorridoXTramo rxt, Recorrido r, Tramo t, Puerto p1, Puerto p2, Crucero c ";
            query += "where V.FechaInicio = '" + inicio + "' and t.puertoOrigen = "+ pOri + " and t.puertoDestino = " + pDest +" and rxt.idTramo = t.idTramo and ";
            query += "rxt.idRecorrido = r.idRecorrido and rxt.orden = 0 and p1.idPuerto = " + pOri +" and p2.idPuerto = " + pDest + " and c.intCrucero = v.idCrucero";
            return db.select_query(query);
        }

        public DataTable getCabinasDisponibles(int idViaje, int cantPasajeros)
        {
            string query = "select count(ca.idCabina) as cantidadCabinas, t.Nombre, t.Recargo, t.idTipoCabina from Cabina ca, Crucero c, TipoCabina t, Viaje v ";
            query += "where v.idViaje = " + idViaje +" and t.idTipoCabina = ca.TipoCabina and c.intCrucero = ca.idCrucero and ";
            query += "ca.idCabina not in (select co.idCabina from Compra co where co.idViaje = " + idViaje + ")  group by t.Nombre, t.Recargo, t.idTipoCabina having count(ca.idCabina) > " + cantPasajeros ;
            return db.select_query(query);
        }

        public DataTable searchCliente(decimal dni)
        {
            return db.select_query("select c.idCliente, c.Nombre, c.Apellido, c.mail, c.direccion, c.fechaNac, c.telefono, c.dni from Cliente c where c.dni = " + dni);
        }
    }
}