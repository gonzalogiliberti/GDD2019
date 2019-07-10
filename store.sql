 alter procedure dbo.insertCompra
 AS
 
 declare @pasajeFecha datetime2(3)
 declare @pasajePrecio decimal(18,2)
 declare @pasajeCodigo decimal(18,0)
 declare @idViaje int
 declare @idCliente int
 declare @idCabina int
 /*
 declare miCursor cursor for
	 select PASAJE_FECHA_COMPRA, PASAJE_PRECIO, PASAJE_CODIGO,
(select v.idViaje from Viaje v where 
idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador and CRUCERO_MODELO = Modelo)
 and (select idRecorrido from Recorrido where RECORRIDO_CODIGO = codigo) = idRecorrido and v.FechaFin = FECHA_LLEGADA 
 and v.FechaInicio = FECHA_SALIDA),
 (select idCliente from Cliente where dni = CLI_DNI and Nombre = CLI_NOMBRE and Apellido = CLI_APELLIDO and fechaNac = CLI_FECHA_NAC),
 (select idCabina from Cabina where Numero = CABINA_NRO and Piso = CABINA_PISO 
 and idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador and CRUCERO_MODELO = Modelo) )
  from gd_esquema.Maestra where PASAJE_CODIGO Is not null
  */

  insert into dbo.Compra(fecha, precioTotal, codigoPasaje, idViaje, idCliente, idCabina) select PASAJE_FECHA_COMPRA, PASAJE_PRECIO, PASAJE_CODIGO,
(select v.idViaje from Viaje v where 
idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador and CRUCERO_MODELO = Modelo)
 and (select idRecorrido from Recorrido where RECORRIDO_CODIGO = codigo) = idRecorrido and v.FechaFin = FECHA_LLEGADA 
 and v.FechaInicio = FECHA_SALIDA),
 (select idCliente from Cliente where dni = CLI_DNI and Nombre = CLI_NOMBRE and Apellido = CLI_APELLIDO and fechaNac = CLI_FECHA_NAC),
 (select idCabina from Cabina where Numero = CABINA_NRO and Piso = CABINA_PISO 
 and idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador and CRUCERO_MODELO = Modelo) )
  from gd_esquema.Maestra where PASAJE_CODIGO Is not null
 GO