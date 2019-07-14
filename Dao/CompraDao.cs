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

            string query = "select V.idViaje, t.puertoOrigen AS idPuertoOri, p1.Nombre AS PuertoOri, t.puertoDestino AS idPuertoDest, p2.Nombre as PuertoDest, V.FechaInicio, V.FechaFin, c.intCrucero as idCrucero, c.Identificador, v.idRecorrido from dbo.Viaje V, RecorridoXTramo rxt, Recorrido r, Tramo t, Puerto p1, Puerto p2, Crucero c ";
            query += "where V.FechaInicio = '" + inicio + "' and t.puertoOrigen = "+ pOri + " and t.puertoDestino = " + pDest +" and rxt.idTramo = t.idTramo and ";
            query += "rxt.idRecorrido = r.idRecorrido and rxt.orden = 0 and p1.idPuerto = " + pOri +" and p2.idPuerto = " + pDest + " and c.intCrucero = v.idCrucero";
            return db.select_query(query);
        }

        public DataTable getCabinasDisponibles(int idViaje, int cantPasajeros, int idCrucero)
        {
            string query = "select count(ca.idCabina) as cantidadCabinas, t.Nombre, t.Recargo, t.idTipoCabina from dbo.Cabina ca, TipoCabina t, Viaje v ";
            query += "where v.idViaje = " + idViaje + " and "+ idCrucero + " = ca.idCrucero and ca.TipoCabina = t.idTipoCabina and ";
            query += "ca.idCabina not in (select co.idCabina from dbo.Compra co where co.idViaje = " + idViaje + ")  group by t.Nombre, t.Recargo, t.idTipoCabina having count(ca.idCabina) > " + cantPasajeros;
            return db.select_query(query);
        }

        public DataTable searchCliente(decimal dni)
        {
            return db.select_query("select c.idCliente, c.Nombre, c.Apellido, c.mail, c.direccion, c.fechaNac, c.telefono, c.dni from dbo.Cliente c where c.dni = " + dni);
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
            DataTable dt = db.select_query("select c.idCliente from dbo.Cliente c where dni = " + cliente.dni + " and Nombre = '" + cliente.nombre + "' and Apellido = '" + cliente.apellido + "'");
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToInt32(r["idCliente"]);
        }

        public Viaje getViaje(int viajeId)
        {
            DataTable dt = db.select_query("select * from dbo.Viaje where idViaje = " + viajeId);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            DataRow r = dt.Rows[0];
            return new Viaje(r);
        }

        public Cliente getCliente(int clienteId)
        {
            DataTable dt = db.select_query("select * from dbo.Cliente where idCliente = " + clienteId);
            if (dt.Rows.Count != 1)
            {
                return null;
            }
            DataRow r = dt.Rows[0];
            return new Cliente(r);
        }

        public DataRow getReserve(Decimal codigo)
        {
            DataTable dt = db.select_query("select * from dbo.Reserva where codigoReserva = " + codigo);
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
            DataTable dt = db.select_query("select codigoPasaje from dbo.Compra where idCliente = " + cliente.idCliente + " and idViaje = " + viaje.idViaje + " and cantidadPasajes = " + cantPasajes + " and medioPago = " + mp.idMedioPago + " and precioTotal = " + precio.Replace(",", "."));
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToDecimal(r["codigoPasaje"]);
        }

        public decimal getCodigoReserva(Cliente cliente, Viaje viaje, int cantPasajes)
        {
            DataTable dt = db.select_query("select codigoReserva from dbo.Reserva where idCliente = " + cliente.idCliente + " and idViaje = " + viaje.idViaje + " and cantidadPasajes = " + cantPasajes);
            if (dt.Rows.Count != 1)
            {
                return -1;
            }
            DataRow r = dt.Rows[0];
            return Convert.ToDecimal(r["codigoReserva"]);
        }

        public DataTable getTopRecorridosVendidos(String fecha1, String fecha2)
        {
            String query = "select TOP 5  idRecorrido AS Recorrido, count(idRecorrido) AS Ventas from " + 
                            "(select idCompra, idViaje, fecha from dbo.Compra where fecha > " + fecha1
                        + " and fecha < " + fecha2 + ") t1 " + 
                        "INNER JOIN " + 
                        "(select idViaje AS viaje2, idRecorrido from dbo.Viaje ) t2" + 
                        " ON t1.idViaje = t2.viaje2 group by idRecorrido ORDER BY 2 DESC;";

            DataTable table = db.select_query(query);
            return table;
        }

        public DataTable getTopRecorridosLibres(String fecha1, String fecha2)
        {
            String query =
                "select TOP 5 Recorrido, sum(CabinasCrucero-CabinasVendidas) as CabinasLibresEnTotalidadDeViajes from " +
                "(select t2.Recorrido, Viaje, t1.CabinasVendidas, t2.Crucero from " +
                    "(select idViaje AS Viaje, count(idViaje) AS CabinasVendidas from dbo.Compra where fecha > " + fecha1 + " and fecha < " + fecha2 + " GROUP BY idViaje) t1 " +
                    "INNER JOIN " +
                    "(select idViaje, idCrucero AS Crucero, idRecorrido AS Recorrido from dbo.viaje) t2 " +
                    "ON t1.Viaje = t2.idViaje " +
                ") table1 " +
                "INNER JOIN " +
                "(select idCrucero, count(idCrucero) AS CabinasCrucero from dbo.Cabina GROUP BY idCrucero) table2 " +
                "ON table1.Crucero = table2.idCrucero " +
                "group by Recorrido " +
                "order by CabinasLibresEnTotalidadDeViajes desc;";

            DataTable table = db.select_query(query);
            return table;
        }

        public DataTable getTopCrucerosDeBaja(String fecha1, String fecha2)
        {
            String query =
                "select TOP 5 idCrucero as Crucero, sum( DATEDIFF(DAY, FechaBaja, FechaRestauracion) ) as DiasDeBaja  from dbo.Baja " + 
                "where idTipoBaja = 2 and FechaBaja > " + fecha1 + " and FechaRestauracion < " + fecha2 +
                " group by idCrucero" +
                " order by DiasDeBaja desc;";

            DataTable table = db.select_query(query);
            return table;
        }

        public List<Viaje> getViajes(int crucero)
        {
            List<Viaje> viajes = new List<Viaje>();
            DataTable dt = db.select_query("select v.idViaje, v.idCrucero, v.idRecorrido, v.FechaInicio, v.FechaFin from dbo.Viaje v where v.idCrucero = " + crucero);

            foreach (DataRow row in dt.Rows)
            {
                viajes.Add(new Viaje(row));
            }

            return viajes;
        }

        public void marcarVencidasReservas(DateTime date)
        {
            Dictionary<String, Object> dic = new Dictionary<String, Object>();
            dic.Add("@date", date);

            db.executeProcedureWithParameters("dbo.delete_old_reserve", dic);
        }
    }
}
