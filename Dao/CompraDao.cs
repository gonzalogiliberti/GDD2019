using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.Util;
using System.Data;
using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.AbmCrucero;

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
            
            string query = "select V.idViaje, t.puertoOrigen AS idPuertoOri, p1.Nombre AS PuertoOri, t.puertoDestino AS idPuertoDest, p2.Nombre as PuertoDest, V.FechaInicio, V.FechaFin, c.intCrucero as idCrucero, c.Identificador, v.idRecorrido from Viaje V, RecorridoXTramo rxt, Recorrido r, Tramo t, Puerto p1, Puerto p2, Crucero c ";
            query += "where V.FechaInicio = '" + inicio + "' and t.puertoOrigen = "+ pOri + " and t.puertoDestino = " + pDest +" and rxt.idTramo = t.idTramo and ";
            query += "rxt.idRecorrido = r.idRecorrido and rxt.orden = 0 and p1.idPuerto = " + pOri +" and p2.idPuerto = " + pDest + " and c.intCrucero = v.idCrucero";
            return db.select_query(query);
        }

        public DataTable getCabinasDisponibles(int idViaje, int cantPasajeros, int idCrucero)
        {
            string query = "select count(ca.idCabina) as cantidadCabinas, t.Nombre, t.Recargo, t.idTipoCabina from Cabina ca, TipoCabina t, Viaje v ";
            query += "where v.idViaje = " + idViaje + " and "+ idCrucero + " = ca.idCrucero and ca.TipoCabina = t.idTipoCabina and ";
            query += "ca.idCabina not in (select co.idCabina from Compra co where co.idViaje = " + idViaje + ")  group by t.Nombre, t.Recargo, t.idTipoCabina having count(ca.idCabina) > " + cantPasajeros;
            return db.select_query(query);
        }

        public DataTable searchCliente(decimal dni)
        {
            return db.select_query("select c.idCliente, c.Nombre, c.Apellido, c.mail, c.direccion, c.fechaNac, c.telefono, c.dni from Cliente c where c.dni = " + dni);
        }

        public void createClient(Cliente cli)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@nombre", cli.nombre);
            dic.Add("@apellido", cli.apellido);
            dic.Add("@telefono", cli.telefono);
            dic.Add("@mail", cli.mail);
            dic.Add("@direccion", cli.direccion);
            dic.Add("@dni", cli.dni);
            dic.Add("@fechaNac", cli.fechaNac);

            db.executeProcedureWithParameters("dbo.sp_crear_cliente", dic);
        }

        public void updateClient(Cliente cli)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("idCli", cli.idCliente);
            dic.Add("@nombre", cli.nombre);
            dic.Add("@apellido", cli.apellido);
            dic.Add("@telefono", cli.telefono);
            dic.Add("@mail", cli.mail);
            dic.Add("@direccion", cli.direccion);
            dic.Add("@dni", cli.dni);
            dic.Add("@fechaNac", cli.fechaNac);

            db.executeProcedureWithParameters("dbo.sp_update_cliente", dic);
        }

        public List<MedioPAgo> getMedioPagos()
        {
            List<MedioPAgo> medios = new List<MedioPAgo>();
            DataTable dt = db.select_query("SELECT m.idMedioPago, m.Nombre FROM dbo.MedioPAgo m");

            foreach (DataRow row in dt.Rows)
            {
                medios.Add(new MedioPAgo(row));
            }

            return medios;
        }

        public void pay(Cliente cliente, Viaje viaje, TipoCabina tipoCabina, MedioPAgo mp, double precioTotal, TarjetaCredito tarjeta, int cantPasajes)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idCli", cliente.idCliente);
            dic.Add("@idViaje", viaje.idViaje);
            dic.Add("@tipoCabina", tipoCabina.idTipo);
            dic.Add("@medioPago", mp.idMedioPago);
            if (tarjeta != null)
            {
                dic.Add("@tarjetaNombre", tarjeta.nombre);
                dic.Add("@tarjetaCoutas", tarjeta.coutas);
            }
            else
            {
                dic.Add("@tarjetaNombre", "");
                dic.Add("@tarjetaCoutas", 0);
            }
            dic.Add("@precioTotal", precioTotal );
            dic.Add("@cantPasajes", cantPasajes );
            dic.Add("@idCrucero", viaje.idCrucero);

            db.executeProcedureWithParameters("dbo.sp_crear_compra", dic);
        }

        public void reserve(Cliente cliente, Viaje viaje, TipoCabina tipoCabina, int cantPasajes)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@idCli", cliente.idCliente);
            dic.Add("@idViaje", viaje.idViaje);
            dic.Add("@tipoCabina", tipoCabina.idTipo);
            dic.Add("@cantPasajes", cantPasajes);
            dic.Add("@idCrucero", viaje.idCrucero);

            db.executeProcedureWithParameters("dbo.sp_crear_reserva", dic);
        }

        public int getClientId(Cliente cliente)
        {
            DataTable dt = db.select_query("select c.idCliente from Cliente c where dni = " + cliente.dni +" and Nombre = '" + cliente.nombre + "' and Apellido = '" + cliente.apellido +"'");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idCliente"]);
        }

        public Viaje getViaje(int viajeId)
        {
            DataTable dt = db.select_query("select * from Viaje where idViaje = " + viajeId);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            DataRow r = dt.Rows[0];
            return new Viaje(r);
        }

        public Cliente getCliente(int clienteId)
        {
            DataTable dt = db.select_query("select * from Cliente where idCliente = " + clienteId);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            DataRow r = dt.Rows[0];
            return new Cliente(r);
        }

        public DataRow getReserve(Decimal codigo)
        {
            DataTable dt = db.select_query("select * from Reserva where codigoReserva = " + codigo);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            return dt.Rows[0];
        }

        public void markReservePaid(decimal codigo)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@codigoReserva", codigo);

            db.executeProcedureWithParameters("dbo.sp_pagar_reserva", dic);
        }

        public decimal getCodigoPasaje(Cliente cliente, Viaje viaje, MedioPAgo mp, double precioTotal, TarjetaCredito tarjeta, int cantPasajes)
        {
            String precio = precioTotal.ToString();
            DataTable dt = db.select_query("select codigoPasaje from Compra where idCliente = " + cliente.idCliente + " and idViaje = " + viaje.idViaje + " and cantidadPasajes = " + cantPasajes + " and medioPago = " + mp.idMedioPago + " and precioTotal = " + precio.Replace(",", "."));
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToDecimal(r["codigoPasaje"]);
        }

        public decimal getCodigoReserva(Cliente cliente, Viaje viaje, int cantPasajes)
        {
            DataTable dt = db.select_query("select codigoReserva from Reserva where idCliente = " + cliente.idCliente + " and idViaje = " + viaje.idViaje + " and cantidadPasajes = " + cantPasajes );
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToDecimal(r["codigoReserva"]);
        }

    }
}
