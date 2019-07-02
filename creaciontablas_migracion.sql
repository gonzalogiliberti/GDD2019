
GO
CREATE TABLE [dbo].[Baja](
	[idBaja] [int] NOT NULL,
	[idTipoBaja] [int] NOT NULL,
	[FechaBaja] [date] NOT NULL,
	[FechaRestauracion] [date] NULL,
	[idCrucero] [int] NOT NULL,
 CONSTRAINT [PK_Baja] PRIMARY KEY CLUSTERED 
(
	[idBaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cabina]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cabina](
	[idCabina] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [int] NOT NULL,
	[Piso] [int] NOT NULL,
	[TipoCabina] [int],
	[idCrucero] [int],
 CONSTRAINT [PK_Cabina] PRIMARY KEY CLUSTERED 
(
	[idCabina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255) NOT NULL,
	[Apellido] [nvarchar](255) NOT NULL,
	[telefono] [int] NOT NULL,
	[mail] [nvarchar](255) NOT NULL,
	[direccion] [nvarchar](255) NOT NULL,
	[fechaNac] [datetime2](3) NOT NULL,
	[dni] [decimal](18,0) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ClienteXRecorrido]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClienteXRecorrido](
	[idRecorrido] [int],
	[idCliente] [int],
 CONSTRAINT [PK_ClienteXRecorrido] PRIMARY KEY CLUSTERED 
(
	[idRecorrido] ASC,
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Compra]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[idCompra] [int] IDENTITY(1,1) NOT NULL,
	[idViaje] [int],
	[idCliente] [int],
	[cantidadPasajes] [int],
	[medioPago] [int],
	[tarjetaCredito] [int],
	[fecha] [datetime2](3),
	[precioTotal] [decimal](18,2),
	[idCabina] [int],
	[codigoPasaje] [decimal](18,0),
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[idCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Crucero]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Crucero](
	[intCrucero] [int] IDENTITY(1,1) NOT NULL,
	[Modelo] [nvarchar](50),
	[FechaAlta] [datetime2](3),
	[Identificador] [nvarchar](50),
	[Fabricante] [int],
	[TipoServicio] [int],
	[CantidadCabinas] [int],
 CONSTRAINT [PK_Crucero] PRIMARY KEY CLUSTERED 
(
	[intCrucero] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Fabricante]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Fabricante](
	[idFabricante] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](255),
 CONSTRAINT [PK_Fabricante] PRIMARY KEY CLUSTERED 
(
	[idFabricante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Funcion]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Funcion](
	[idFuncion] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Funcion] PRIMARY KEY CLUSTERED 
(
	[idFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedioPAgo]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedioPAgo](
	[idMedioPago] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
 CONSTRAINT [PK_MedioPAgo] PRIMARY KEY CLUSTERED 
(
	[idMedioPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Puerto]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Puerto](
	[idPuerto] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
 CONSTRAINT [PK_Puerto] PRIMARY KEY CLUSTERED 
(
	[idPuerto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Recorrido]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Recorrido](
	[idRecorrido] [int] IDENTITY(1,1),
 CONSTRAINT [PK_Recorrido] PRIMARY KEY CLUSTERED 
(
	[idRecorrido] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RecorridoXTramo]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecorridoXTramo](
	[idRecorrido] [int] NOT NULL,
	[idTramo] [int] NOT NULL,
 CONSTRAINT [PK_RecorridoXTramo] PRIMARY KEY CLUSTERED 
(
	[idRecorrido] ASC,
	[idTramo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] IDENTITY(1,1),
	[idViaje] [int] ,
	[idCliente] [int] ,
	[cantidadPasajeros] [int],
	[fecha] [datetime2](3) ,
	[idCabina] [int],
	[codigoReserva] [decimal](18,0),
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Rol]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[rol_Nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Rol] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[RolxFuncion]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RolxFuncion](
	[idRol] [int] NOT NULL,
	[idFuncion] [int] NOT NULL,
 CONSTRAINT [PK_RolxFuncion] PRIMARY KEY CLUSTERED 
(
	[idRol] ASC,
	[idFuncion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ServicioCrucero]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ServicioCrucero](
	[idServicio] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
 CONSTRAINT [PK_ServicioCrucero] PRIMARY KEY CLUSTERED 
(
	[idServicio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TarjetaCredito]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TarjetaCredito](
	[idTarjetaCredito] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
	[cuotas] [int],
 CONSTRAINT [PK_TarjetaCredito] PRIMARY KEY CLUSTERED 
(
	[idTarjetaCredito] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoBaja]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoBaja](
	[idTipoBaja] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
 CONSTRAINT [PK_TipoBaja] PRIMARY KEY CLUSTERED 
(
	[idTipoBaja] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TipoCabina]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCabina](
	[idTipoCabina] [int] IDENTITY(1,1),
	[Nombre] [nvarchar](255),
	[Recargo] [int],
 CONSTRAINT [PK_TipoCabina] PRIMARY KEY CLUSTERED 
(
	[idTipoCabina] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Tramo]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tramo](
	[idTramo] [int] IDENTITY(1,1),
	[precioBase] [decimal](18,2),
	[puertoOrigen] [int],
	[puertoDestino] [int],
	[recorridoCodigo] [decimal](18,0),
 CONSTRAINT [PK_Tramo] PRIMARY KEY CLUSTERED 
(
	[idTramo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int],
	[username] [nchar](25),
	[password] [nchar](25),
	[fallos] [int],
	[idRol] [int],
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Viaje]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Viaje](
	[idViaje] [int] IDENTITY(1,1),
	[FechaInicio] [datetime2](3),
	[FechaFin] [datetime2](3),
	[FechaFinEstimada] [datetime2](3),
	[idRecorrido] [int],
	[idCrucero] [int],
 CONSTRAINT [PK_Viaje] PRIMARY KEY CLUSTERED 
(
	[idViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [IX_Rol]    Script Date: 05/06/2019 7:37:41 ******/
CREATE NONCLUSTERED INDEX [IX_Rol] ON [dbo].[Rol]
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Baja]  WITH CHECK ADD  CONSTRAINT [FK_Baja_Crucero] FOREIGN KEY([idCrucero])
REFERENCES [dbo].[Crucero] ([intCrucero])
GO
ALTER TABLE [dbo].[Baja] CHECK CONSTRAINT [FK_Baja_Crucero]
GO
ALTER TABLE [dbo].[Baja]  WITH CHECK ADD  CONSTRAINT [FK_Baja_TipoBaja] FOREIGN KEY([idTipoBaja])
REFERENCES [dbo].[TipoBaja] ([idTipoBaja])
GO
ALTER TABLE [dbo].[Baja] CHECK CONSTRAINT [FK_Baja_TipoBaja]
GO
ALTER TABLE [dbo].[Cabina]  WITH CHECK ADD  CONSTRAINT [FK_Cabina_Crucero] FOREIGN KEY([idCrucero])
REFERENCES [dbo].[Crucero] ([intCrucero])
GO
ALTER TABLE [dbo].[Cabina] CHECK CONSTRAINT [FK_Cabina_Crucero]
GO
ALTER TABLE [dbo].[Cabina]  WITH CHECK ADD  CONSTRAINT [FK_Cabina_TipoCabina] FOREIGN KEY([TipoCabina])
REFERENCES [dbo].[TipoCabina] ([idTipoCabina])
GO
ALTER TABLE [dbo].[Cabina] CHECK CONSTRAINT [FK_Cabina_TipoCabina]
GO
ALTER TABLE [dbo].[ClienteXRecorrido]  WITH CHECK ADD  CONSTRAINT [FK_ClienteXRecorrido_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[ClienteXRecorrido] CHECK CONSTRAINT [FK_ClienteXRecorrido_Cliente]
GO
ALTER TABLE [dbo].[ClienteXRecorrido]  WITH CHECK ADD  CONSTRAINT [FK_ClienteXRecorrido_Recorrido] FOREIGN KEY([idRecorrido])
REFERENCES [dbo].[Recorrido] ([idRecorrido])
GO
ALTER TABLE [dbo].[ClienteXRecorrido] CHECK CONSTRAINT [FK_ClienteXRecorrido_Recorrido]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Cliente]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_MedioPAgo] FOREIGN KEY([medioPago])
REFERENCES [dbo].[MedioPAgo] ([idMedioPago])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_MedioPAgo]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_TarjetaCredito] FOREIGN KEY([tarjetaCredito])
REFERENCES [dbo].[TarjetaCredito] ([idTarjetaCredito])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_TarjetaCredito]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Viaje] FOREIGN KEY([idViaje])
REFERENCES [dbo].[Viaje] ([idViaje])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Viaje]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Cabina] FOREIGN KEY([idCabina])
REFERENCES [dbo].[Cabina] ([idCabina])
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Cabina]
GO
ALTER TABLE [dbo].[Crucero]  WITH CHECK ADD  CONSTRAINT [FK_Crucero_Fabricante] FOREIGN KEY([Fabricante])
REFERENCES [dbo].[Fabricante] ([idFabricante])
GO
ALTER TABLE [dbo].[Crucero] CHECK CONSTRAINT [FK_Crucero_Fabricante]
GO
ALTER TABLE [dbo].[Crucero]  WITH CHECK ADD  CONSTRAINT [FK_Crucero_ServicioCrucero] FOREIGN KEY([TipoServicio])
REFERENCES [dbo].[ServicioCrucero] ([idServicio])
GO
ALTER TABLE [dbo].[Crucero] CHECK CONSTRAINT [FK_Crucero_ServicioCrucero]
GO
ALTER TABLE [dbo].[RecorridoXTramo]  WITH CHECK ADD  CONSTRAINT [FK_RecorridoXTramo_Recorrido] FOREIGN KEY([idRecorrido])
REFERENCES [dbo].[Recorrido] ([idRecorrido])
GO
ALTER TABLE [dbo].[RecorridoXTramo] CHECK CONSTRAINT [FK_RecorridoXTramo_Recorrido]
GO
ALTER TABLE [dbo].[RecorridoXTramo]  WITH CHECK ADD  CONSTRAINT [FK_RecorridoXTramo_Tramo] FOREIGN KEY([idRecorrido])
REFERENCES [dbo].[Tramo] ([idTramo])
GO
ALTER TABLE [dbo].[RecorridoXTramo] CHECK CONSTRAINT [FK_RecorridoXTramo_Tramo]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cabina] FOREIGN KEY([idCabina])
REFERENCES [dbo].[Cabina] ([idCabina])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cabina]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Cliente] FOREIGN KEY([idCliente])
REFERENCES [dbo].[Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Cliente]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Viaje] FOREIGN KEY([idViaje])
REFERENCES [dbo].[Viaje] ([idViaje])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Viaje]
GO
ALTER TABLE [dbo].[RolxFuncion]  WITH CHECK ADD  CONSTRAINT [FK_RolxFuncion_Funcion] FOREIGN KEY([idFuncion])
REFERENCES [dbo].[Funcion] ([idFuncion])
GO
ALTER TABLE [dbo].[RolxFuncion] CHECK CONSTRAINT [FK_RolxFuncion_Funcion]
GO
ALTER TABLE [dbo].[RolxFuncion]  WITH CHECK ADD  CONSTRAINT [FK_RolxFuncion_Rol] FOREIGN KEY([idFuncion])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[RolxFuncion] CHECK CONSTRAINT [FK_RolxFuncion_Rol]
GO
ALTER TABLE [dbo].[Tramo]  WITH CHECK ADD  CONSTRAINT [FK_Tramo_PuertoDestino] FOREIGN KEY([puertoDestino])
REFERENCES [dbo].[Puerto] ([idPuerto])
GO
ALTER TABLE [dbo].[Tramo] CHECK CONSTRAINT [FK_Tramo_PuertoDestino]
GO
ALTER TABLE [dbo].[Tramo]  WITH CHECK ADD  CONSTRAINT [FK_Tramo_PuertoOrigen] FOREIGN KEY([puertoOrigen])
REFERENCES [dbo].[Puerto] ([idPuerto])
GO
ALTER TABLE [dbo].[Tramo] CHECK CONSTRAINT [FK_Tramo_PuertoOrigen]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_Rol] FOREIGN KEY([idRol])
REFERENCES [dbo].[Rol] ([idRol])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_Rol]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viaje_Recorrido] FOREIGN KEY([idRecorrido])
REFERENCES [dbo].[Recorrido] ([idRecorrido])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viaje_Recorrido]
GO
ALTER TABLE [dbo].[Viaje]  WITH CHECK ADD  CONSTRAINT [FK_Viaje_Crucero] FOREIGN KEY([idCrucero])
REFERENCES [dbo].[Crucero] ([intCrucero])
GO
ALTER TABLE [dbo].[Viaje] CHECK CONSTRAINT [FK_Viaje_Crucero]
GO
--Migracion Datos Cliente
insert into GD1C2019.dbo.Cliente(dni, Nombre, Apellido, telefono, mail, fechaNac, direccion) 
select CLI_DNI, CLI_NOMBRE, CLI_APELLIDO, CLI_TELEFONO, CLI_TELEFONO, CLI_FECHA_NAC, CLI_DIRECCION
from gd_esquema.Maestra
group by CLI_DNI, CLI_NOMBRE, CLI_APELLIDO
GO
--Migracion Datos Puerto
insert into GD1C2019.dbo.Puerto(nombre) select distinct(PUERTO_HASTA) from gd_esquema.Maestra
GO
--Migracion Datos Fabricante
insert into GD1C2019.dbo.Fabricante(Nombre) select distinct(CRU_FABRICANTE) from gd_esquema.Maestra
GO
--Migracion Datos Crucero
insert into GD1C2019.dbo.Crucero(Identificador,Modelo, Fabricante) select distinct(CRUCERO_IDENTIFICADOR), CRUCERO_MODELO,(Select idFabricante from Fabricante where Nombre = CRU_FABRICANTE ) from gd_esquema.maestra
GO
--Migracion Datos Cabina
insert into GD1C2019.dbo.Cabina(Numero,Piso, TipoCabina, idCrucero) select CABINA_NRO, CABINA_PISO, (select idTipoCabina from TipoCabina where Nombre = CABINA_TIPO) as tipo,
	(select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador) as crucero from gd_esquema.maestra where (select count(*) from Cabina where Numero = CABINA_NRO and Piso = CABINA_PISO and idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador)) = 0
	group by CABINA_NRO, CABINA_PISO, CABINA_TIPO, CRUCERO_IDENTIFICADOR
	order by CABINA_NRO, CABINA_PISO, crucero
GO
insert into Tramo(puertoDestino, puertoOrigen, precioBase) select (select idPuerto from Puerto where PUERTO_HASTA = Nombre), (select idPuerto from Puerto where PUERTO_Desde = Nombre), RECORRIDO_PRECIO_BASE from gd_esquema.maestra group by PUERTO_HASTA, PUERTO_DESDE, RECORRIDO_PRECIO_BASE
GO
insert into Recorrido(Codigo) select distinct(RECORRIDO_CODIGO) from gd_esquema.maestra
GO
insert into RecorridoXTramo(idRecorrido, idTramo) select (select idRecorrido from Recorrido where codigo = RECORRIDO_CODIGO),
 (select idTramo from Tramo where PUERTO_DESDE = (select Nombre from Puerto where puertoOrigen = idPuerto) and PUERTO_HASTA = (select Nombre from Puerto where puertoDestino = idPuerto)) from gd_esquema.maestra
 group by RECORRIDO_CODIGO, PUERTO_DESDE, PUERTO_HASTA
GO
insert into ClienteXRecorrido(idCliente, idRecorrido) select (select idCliente from Cliente where dni = CLI_DNI and CLI_NOMBRE = Nombre),
(select idRecorrido from Recorrido where codigo = RECORRIDO_CODIGO) from gd_esquema.maestra group by CLI_DNI, RECORRIDO_CODIGO, CLI_NOMBRE
GO
insert into dbo.Viaje(FechaInicio, FechaFin, FechaFinEstimada, idCrucero, idRecorrido) select FECHA_SALIDA, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA,
 (select intCrucero from Crucero where Identificador = CRUCERO_IDENTIFICADOR and Modelo = CRUCERO_MODELO), (select idRecorrido from Recorrido where RECORRIDO_CODIGO = codigo)
  from gd_esquema.maestra group by RECORRIDO_CODIGO, CRUCERO_IDENTIFICADOR, CRUCERO_MODELO, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA, FECHA_SALIDA
GO
insert into dbo.TipoBaja(Nombre) values ('Vida Util')
GO
insert into dbo.TipoBaja(Nombre) values ('Fuera de Servicio')
GO


--Stores Funcion y Rol
IF (OBJECT_ID ('dbo.sp_crear_funcion') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_funcion
GO
CREATE PROCEDURE dbo.sp_crear_funcion (@funcionNombre  varchar(50)) 
AS BEGIN
    BEGIN TRANSACTION T1
	insert into Funcion(nombre) values (@funcionNombre)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO


IF (OBJECT_ID ('dbo.sp_crear_rol') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_rol
GO
CREATE PROCEDURE dbo.sp_crear_rol (@rolName  varchar(50)) 
AS BEGIN
    BEGIN TRANSACTION T1
	insert into Rol(rol_Nombre) values (@rolName)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_set_funcxrol') IS NOT NULL)
	DROP PROCEDURE dbo.sp_set_funcxrol
GO
Create PROCEDURE dbo.sp_set_funcxrol (@idRol int, @idFunc int) 
AS BEGIN

    BEGIN TRANSACTION T1
	insert into RolxFuncion(idRol, idFuncion) values (@idRol, @idFunc)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_eliminar_funcxrol') IS NOT NULL)
	DROP PROCEDURE dbo.sp_eliminar_funcxrol
GO
Create PROCEDURE dbo.sp_eliminar_funcxrol (@idRol int, @idFunc int) 
AS BEGIN

    BEGIN TRANSACTION T1
	delete from RolxFuncion where idRol = @idRol and idFuncion = @idFunc
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_update_rol') IS NOT NULL)
	DROP PROCEDURE dbo.sp_update_rol
GO
Create PROCEDURE dbo.sp_update_rol (@name varchar(50) ,@idRol int) 
AS BEGIN

    BEGIN TRANSACTION T1
	UPDATE Rol SET rol_Nombre = @name where idRol = @idRol
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

-- Stores Recorrido
IF (OBJECT_ID ('dbo.sp_crear_recorrido') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_recorrido
GO
Create PROCEDURE dbo.sp_crear_recorrido (@codigo decimal(18,0)) 
AS BEGIN

    BEGIN TRANSACTION T1
	INSERT into Recorrido (codigo) values (@codigo)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_modificar_recorrido') IS NOT NULL)
	DROP PROCEDURE dbo.sp_modificar_recorrido
GO
Create PROCEDURE dbo.sp_modificar_recorrido (@codigo decimal(18,0), @idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	UPDATE Recorrido set codigo = @codigo where idRecorrido = @idRecorrido
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_eliminar_recorrido') IS NOT NULL)
	DROP PROCEDURE dbo.sp_eliminar_recorrido
GO
Create PROCEDURE dbo.sp_eliminar_recorrido (@idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Delete from Recorrido where idRecorrido = @idRecorrido
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_modificar_tramo') IS NOT NULL)
	DROP PROCEDURE dbo.sp_modificar_tramo
GO
Create PROCEDURE dbo.sp_modificar_tramo (@idTramo int, @puertoOrigen int, @puertoDestino int, @precio int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Tramo set puertoOrigen = @puertoOrigen, puertoDestino = @puertoDestino, precioBase = @precio where idTramo = @idTramo
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_eliminar_tramo') IS NOT NULL)
	DROP PROCEDURE dbo.sp_eliminar_tramo
GO
Create PROCEDURE dbo.sp_eliminar_tramo (@idTramo int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Delete from Tramo where idTramo = @idTramo
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_tramo') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_tramo
GO
Create PROCEDURE dbo.sp_crear_tramo (@puertoOrigen int, @puertoDestino int, @precio int) 
AS BEGIN

    BEGIN TRANSACTION T1
	INSERT INTO Tramo(puertoOrigen,puertoDestino,precio) values (@puertoOrigen, @puertoDestino, @precio)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO