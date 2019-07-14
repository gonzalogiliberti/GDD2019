CREATE TABLE [dbo].[Baja](
	[idBaja] [int] IDENTITY(1,1) NOT NULL,
	[idTipoBaja] [int] NOT NULL,
	[FechaBaja] [date] NOT NULL,
	[FechaRestauracion] [date] NULL,
	[idCrucero] [int] NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
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
	[tarjetaCredito] [char](4),
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
	[Activo] [char] default 'A',
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
	[Codigo] [decimal](18,0),
	[Estado] [char] default 'A',
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
	[orden] [int] default 0,
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
	[pagada] bit,
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
	[idTarjetaCredito] [char](4),
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
	[Recargo] [decimal](18,2),
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
	[username] [nchar](25) UNIQUE,
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
ALTER TABLE [dbo].[RolxFuncion]  WITH CHECK ADD  CONSTRAINT [FK_RolxFuncion_Rol] FOREIGN KEY([idRol])
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
select CLI_DNI, CLI_NOMBRE, CLI_APELLIDO, CLI_TELEFONO, CLI_MAIL, CLI_FECHA_NAC, CLI_DIRECCION
from gd_esquema.Maestra
group by CLI_DNI, CLI_NOMBRE, CLI_APELLIDO, CLI_TELEFONO, CLI_MAIL, CLI_FECHA_NAC, CLI_DIRECCION
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
insert into dbo.TipoCabina(Nombre, Recargo) select distinct(CABINA_TIPO), CABINA_TIPO_PORC_RECARGO from gd_esquema.Maestra
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
--Migracion Datos Compra

select PASAJE_FECHA_COMPRA, PASAJE_PRECIO, PASAJE_CODIGO,CRUCERO_IDENTIFICADOR, CRUCERO_MODELO, RECORRIDO_CODIGO, FECHA_SALIDA, FECHA_LLEGADA, CLI_DNI, CLI_APELLIDO, CLI_NOMBRE, CLI_FECHA_NAC, CABINA_NRO, CABINA_PISO, V.idViaje, Identificador, Modelo, Cru.intCrucero
into #temp_Compra
from gd_esquema.Maestra M, Viaje V, Crucero Cru
where PASAJE_CODIGO Is not null and
		V.FechaInicio = M.FECHA_SALIDA and V.FechaFin = M.FECHA_LLEGADA and V.idCrucero = Cru.intCrucero and
		M.CRUCERO_IDENTIFICADOR = Cru.Identificador and Cru.Modelo = M.CRUCERO_MODELO

insert into dbo.Compra(fecha, precioTotal, codigoPasaje, idViaje, idCliente, idCabina) 
  ( select PASAJE_FECHA_COMPRA, PASAJE_PRECIO, PASAJE_CODIGO, M.idViaje, Cli.idCliente, Cab.idCabina
	from #temp_Compra M, Cliente Cli, Cabina Cab
	where PASAJE_CODIGO Is not null and
		  M.CLI_DNI = Cli.dni and M.CLI_APELLIDO = Cli.Apellido and M.CLI_NOMBRE = Cli.Nombre and M.CLI_FECHA_NAC = Cli.fechaNac and
		  Cab.Numero = M.CABINA_NRO and Cab.Piso = M.CABINA_PISO and cab.idCrucero = M.intCrucero)
GO
--Migracion Datos Reserva

select RESERVA_FECHA, PASAJE_PRECIO, RESERVA_CODIGO, CRUCERO_IDENTIFICADOR, CRUCERO_MODELO, RECORRIDO_CODIGO, FECHA_SALIDA, FECHA_LLEGADA, CLI_DNI, CLI_APELLIDO, CLI_NOMBRE, CLI_FECHA_NAC, CABINA_NRO, CABINA_PISO, V.idViaje, Identificador, Modelo, Cru.intCrucero
into #temp_Reserva
from gd_esquema.Maestra M, Viaje V, Crucero Cru
where RESERVA_CODIGO Is not null and
		V.FechaInicio = M.FECHA_SALIDA and V.FechaFin = M.FECHA_LLEGADA and V.idCrucero = Cru.intCrucero and
		M.CRUCERO_IDENTIFICADOR = Cru.Identificador and Cru.Modelo = M.CRUCERO_MODELO

insert into dbo.Reserva(fecha, codigoReserva, idViaje, idCliente, idCabina, pagada) 
(	select RESERVA_FECHA, RESERVA_CODIGO, M.idViaje, Cli.idCliente, Cab.idCabina, 1
	from #temp_Reserva M, Cliente Cli, Cabina Cab
	where RESERVA_CODIGO Is not null and
		M.CLI_DNI = Cli.dni and M.CLI_APELLIDO = Cli.Apellido and M.CLI_NOMBRE = Cli.Nombre and M.CLI_FECHA_NAC = Cli.fechaNac and
		Cab.Numero = M.CABINA_NRO and Cab.Piso = M.CABINA_PISO and cab.idCrucero = M.intCrucero)
GO
--Se agregan las funciones y los roles para el administrador
-- ROL
insert into dbo.Funcion (nombre) values ('Alta Rol')
insert into dbo.Funcion (nombre) values ('Modificacion Rol')
insert into dbo.Funcion (nombre) values ('Baja Rol')

-- Puerto
insert into dbo.Funcion (nombre) values ('Alta Puerto')
insert into dbo.Funcion (nombre) values ('Modificacion Puerto')
insert into dbo.Funcion (nombre) values ('Baja Puerto')

-- Recorrido
insert into dbo.Funcion (nombre) values ('Alta Recorrido')
insert into dbo.Funcion (nombre) values ('Modificacion Recorrido')
insert into dbo.Funcion (nombre) values ('Baja Recorrido')

-- Crucero
insert into dbo.Funcion (nombre) values ('Alta Crucero')
insert into dbo.Funcion (nombre) values ('Modificacion Crucero')
insert into dbo.Funcion (nombre) values ('Baja Crucero')

-- Viaje
insert into dbo.Funcion (nombre) values ('Alta Viaje')

-- Estadisticas
insert into dbo.Funcion (nombre) values ('Estadistica')

-- Rol de Admin
insert into dbo.Rol (rol_Nombre) values ('Administrador')
GO

insert into dbo.RolxFuncion (idRol, idFuncion) (SELECT idRol, idFuncion from dbo.Funcion, dbo.Rol)
GO
-- Carga de tarjetas de credito
insert into [TarjetaCredito](idTarjetaCredito, Nombre, cuotas) values ('VISA', 'Visa', 12)
insert into [TarjetaCredito](idTarjetaCredito ,Nombre, cuotas) values ('MAST', 'Mastercard', 6)
insert into [TarjetaCredito](idTarjetaCredito, Nombre, cuotas) values ('AMEX', 'AmeX', 3)

-- Carga de Medios de Pago
insert into MedioPAgo(Nombre) Values ('Tarjeta de Credito')
insert into MedioPAgo(Nombre) Values ('Transferencia Bancaria')
insert into MedioPAgo(Nombre) Values ('Efectivo')
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
	INSERT INTO Tramo(puertoOrigen,puertoDestino,precioBase) values (@puertoOrigen, @puertoDestino, @precio)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_set_recorridoxtramo') IS NOT NULL)
	DROP PROCEDURE dbo.sp_set_recorridoxtramo
GO
Create PROCEDURE dbo.sp_set_recorridoxtramo (@idTramo int, @idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	insert into RecorridoXTramo(idRecorrido, idTramo) values (@idRecorrido, @idTramo)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_eliminar_recorridoxtramo') IS NOT NULL)
	DROP PROCEDURE dbo.sp_eliminar_recorridoxtramo
GO
Create PROCEDURE dbo.sp_eliminar_recorridoxtramo (@idTramo int, @idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Delete from RecorridoXTramo where idTramo = @idTramo and idRecorrido = @idRecorrido
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_viaje') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_viaje
GO
Create PROCEDURE dbo.sp_crear_viaje (@fechaInicio datetime2(3), @fechaFin datetime2(3), @idCrucero int, @idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	insert into Viaje(FechaInicio, FechaFin, FechaFinEstimada, idCrucero ,idRecorrido) values (@fechaInicio, @fechaFin, @fechaFin, @idCrucero, @idRecorrido)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_cliente') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_cliente
GO
Create PROCEDURE dbo.sp_crear_cliente (@nombre varchar(255),@apellido varchar(255),@telefono int,@mail varchar(255),@direccion varchar(255),@dni decimal(18,0), @fechaNac datetime2(3)) 
AS BEGIN

    BEGIN TRANSACTION T1
	insert into Cliente(Nombre, Apellido, telefono, mail, direccion,dni,fechaNac) values (@nombre ,@apellido,@telefono ,@mail ,@direccion,@dni , @fechaNac)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_compra') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_compra
GO
Create PROCEDURE dbo.sp_crear_compra (@idCli int, @idViaje int, @tipoCabina int, @medioPago int, @tarjetaNombre varchar(50), @tarjetaCoutas int, @precioTotal decimal(18,2),@cantPasajes int, @idCrucero int) 
AS BEGIN

    BEGIN TRANSACTION T1
	if(@tarjetaNombre != '' and @tarjetaCoutas = 0)
	begin
	INSERT INTO TarjetaCredito(Nombre, cuotas) values (@tarjetaNombre, @tarjetaCoutas)
	end
	
	declare @idCabina int

	select top 1 @idCabina = c.idCabina from Cabina c where c.TipoCabina = @tipoCabina and c.idCrucero = @idCrucero
	and (c.idCabina not in (select co.idCabina from Compra co where co.idViaje = @idViaje) and c.idCabina not in (select re.idCabina from Reserva re where re.idViaje = @idViaje))

	declare @codigo decimal(18,0)
	select @codigo = MAX(codigoPasaje) from Compra
	if (@codigo is not null)
	begin
		set @codigo = @codigo + 1
	end
	else
	begin
		 set @codigo = 0
	end

	insert into Compra(idViaje, idCliente, cantidadPasajes, medioPago, fecha, precioTotal,idCabina, codigoPasaje)
	values (@idViaje, @idCli, @cantPasajes, @medioPago, GETDATE(), @precioTotal, @idCabina, @codigo)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_reserva') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_reserva
GO
Create PROCEDURE dbo.sp_crear_reserva (@idCli int, @idViaje int, @tipoCabina int,@cantPasajes int, @idCrucero int) 
AS BEGIN

    BEGIN TRANSACTION T1
	
	declare @idCabina int

	select top 1 @idCabina = c.idCabina from Cabina c where c.TipoCabina = @tipoCabina and c.idCrucero = @idCrucero
	and (c.idCabina not in (select co.idCabina from Compra co where co.idViaje = @idViaje) and c.idCabina not in (select re.idCabina from Reserva re where re.idViaje = @idViaje))

	declare @codigo decimal(18,0)
	select @codigo = MAX(codigoReserva) from Reserva
	if (@codigo is not null)
	begin
		set @codigo = @codigo + 1
	end
	else
	begin
		 set @codigo = 0
	end

	insert into Reserva(idViaje, idCliente, cantidadPasajeros, fecha, idCabina, codigoReserva)
	values (@idViaje, @idCli, @cantPasajes, GETDATE(), @idCabina, @codigo)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_puerto') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_puerto
GO
Create PROCEDURE dbo.sp_crear_puerto (@Nombre nvarchar(255)) 
AS BEGIN

    BEGIN TRANSACTION T1
	INSERT into Puerto(Nombre) values (@Nombre)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO
IF (OBJECT_ID ('dbo.sp_modificar_puerto') IS NOT NULL)
	DROP PROCEDURE dbo.sp_modificar_puerto
GO
Create PROCEDURE dbo.sp_modificar_puerto (@IdPuerto int,@Nombre nvarchar(255)) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Puerto set Nombre = @Nombre where idPuerto = @IdPuerto
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_pagar_reserva') IS NOT NULL)
	DROP PROCEDURE dbo.sp_pagar_reserva
GO
Create PROCEDURE dbo.sp_pagar_reserva (@codigoReserva decimal(18,0)) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Reserva set pagada = 1 where codigoReserva = @codigoReserva
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO


Create PROCEDURE LOGIN(@usr nchar(25), @pass nchar(25))
as
BEGIN
	declare @fallos int;
	declare @passCursor nchar(25);
	declare @idRol int;
	declare userCursor cursor for ( select top 1 idRol, fallos, password from Usuario where username = @usr);
	open userCursor
	fetch userCursor into @idRoll, @fallos, @passCursor



	if @@FETCH_STATUS = 0
	Begin
		if (@passCursor = @pass)
		Begin
			set @fallos = 0
		END
		else
			set @fallos = @fallos + 1
	End
	
	update Usuario set fallos = @fallos Where username = @usr;
	
	IF @fallos = 0
		RETURN select idFuncion from RolxFuncion where idRol = @idRol

	RETURN NULL;
END;

GO
IF (OBJECT_ID ('dbo.sp_crear_crucero') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_crucero
GO
Create PROCEDURE dbo.sp_crear_crucero (@Identificador nvarchar(50), @Modelo nvarchar(50), @IdFabricante int, @FechaAlta datetime2(3), @CantCabinas int) 
AS BEGIN

    BEGIN TRANSACTION T1
	insert into Crucero(Identificador,Modelo,FechaAlta,Fabricante,Activo) values (@Identificador, @Modelo, @FechaAlta, @IdFabricante, 1)
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_crear_cabinas') IS NOT NULL)
	DROP PROCEDURE dbo.sp_crear_cabinas
GO
Create PROCEDURE dbo.sp_crear_cabinas (@pisos int, @cabinas int,@tipo int, @crucero int) 
AS BEGIN

    BEGIN TRANSACTION T1
	declare @contadorPisos int
	declare @contadorCabinas int
	declare @numero int

	set @contadorPisos = 1
	set @contadorCabinas = 1
	
	WHILE @contadorPisos < (@pisos+1)
	BEGIN
		WHILE @contadorCabinas < (@cabinas+1)
		BEGIN
			set @numero = (@contadorPisos * 100) + @contadorCabinas
			insert into Cabina (Piso, Numero, TipoCabina, idCrucero) values (@contadorPisos, @numero, @tipo, @crucero)
			set @contadorCabinas = @contadorCabinas + 1
		END
		set @contadorCabinas = 1
		set @contadorPisos = @contadorPisos + 1
	END


	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_modificar_crucero') IS NOT NULL)
	DROP PROCEDURE dbo.sp_modificar_crucero
GO
Create PROCEDURE dbo.sp_modificar_crucero (@IdCrucero int,@Identificador nvarchar(50), @Modelo nvarchar(50), @IdFabricante int, @FechaAlta datetime2(3), @CantCabinas int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Crucero set Identificador = @Identificador, Modelo = @Modelo, Fabricante = @IdFabricante, FechaAlta = @FechaAlta where intCrucero = @IdCrucero 
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_modifcar_cucero_viaje') IS NOT NULL)
	DROP PROCEDURE dbo.sp_modifcar_cucero_viaje
GO
Create PROCEDURE dbo.sp_modifcar_cucero_viaje (@crucero int, @viaje int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Viaje set idCrucero = @crucero where idViaje = @viaje
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_baja_crucero_util') IS NOT NULL)
	DROP PROCEDURE dbo.sp_baja_crucero_util
GO
Create PROCEDURE dbo.sp_baja_crucero_util (@crucero int, @descripcion varchar(255), @fechaBaja datetime2(3)) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Crucero set Activo = 'B' where intCrucero = @crucero
	insert into Baja(idTipoBaja, idCrucero, FechaBaja, descripcion) values (1, @crucero, @fechaBaja, @descripcion)

	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_baja_crucero_servicio') IS NOT NULL)
	DROP PROCEDURE dbo.sp_baja_crucero_servicio
GO
Create PROCEDURE dbo.sp_baja_crucero_servicio (@crucero int, @descripcion varchar(255),@fechaBaja datetime2(3), @fechaRestauracion datetime2(3)) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Crucero set Activo = 'B' where intCrucero = @crucero
	insert into Baja(idTipoBaja, idCrucero, FechaBaja, descripcion, FechaRestauracion) values (2, @crucero, @fechaBaja, @descripcion, @fechaRestauracion)

	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_devolver_pasajes') IS NOT NULL)
	DROP PROCEDURE dbo.sp_devolver_pasajes
GO
Create PROCEDURE dbo.sp_devolver_pasajes (@crucero int,@fechaBaja datetime2(3)) 
AS BEGIN

    BEGIN TRANSACTION T1
	declare @idViaje int
	declare miCursor cursor for
	select idViaje from Viaje where idCrucero = @crucero and FechaInicio > @fechaBaja
	
	open miCursor
	fetch miCursor into @idViaje

	if @@FETCH_STATUS = 0
	Begin
		delete from Compra where idViaje = @idViaje
		delete from Reserva where idViaje = @idViaje
	end 
	close miCursor
	deallocate miCursor

	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO

IF (OBJECT_ID ('dbo.sp_reprogramar_viaje') IS NOT NULL)
	DROP PROCEDURE dbo.sp_reprogramar_viaje
GO
Create PROCEDURE dbo.sp_reprogramar_viaje (@idViaje int,@fechaInicio datetime2(3), @fechaFin datetime2(3)) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Viaje set FechaInicio = @fechaInicio, FechaFin = @fechaFin, FechaFinEstimada = @fechaFin where idViaje = @idViaje

	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
GO