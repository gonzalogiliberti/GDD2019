USE [master]
GO
/****** Object:  Database [GD1C2019]    Script Date: 05/06/2019 7:37:41 ******/
CREATE DATABASE [GD1C2019]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GD1C2019', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\GD1C2019.mdf' , SIZE = 147456KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'GD1C2019_log', FILENAME = N'c:\Program Files\Microsoft SQL Server\MSSQL11.SQLSERVER2012\MSSQL\DATA\GD1C2019_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [GD1C2019] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GD1C2019].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GD1C2019] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GD1C2019] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GD1C2019] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GD1C2019] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GD1C2019] SET ARITHABORT OFF 
GO
ALTER DATABASE [GD1C2019] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GD1C2019] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [GD1C2019] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GD1C2019] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GD1C2019] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GD1C2019] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GD1C2019] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GD1C2019] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GD1C2019] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GD1C2019] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GD1C2019] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GD1C2019] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GD1C2019] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GD1C2019] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GD1C2019] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GD1C2019] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GD1C2019] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GD1C2019] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GD1C2019] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GD1C2019] SET  MULTI_USER 
GO
ALTER DATABASE [GD1C2019] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GD1C2019] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GD1C2019] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GD1C2019] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [GD1C2019]
GO
/****** Object:  User [gdCruceros2019]    Script Date: 05/06/2019 7:37:41 ******/
CREATE USER [gdCruceros2019] FOR LOGIN [gdCruceros2019] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Schema [gd_esquema]    Script Date: 05/06/2019 7:37:41 ******/
CREATE SCHEMA [gd_esquema]
GO
/****** Object:  Table [dbo].[Baja]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Baja](
	[idBaja] [int] IDENTITY(1,1)  NOT NULL,
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
	[TipoCabina] [int] NOT NULL,
	[idCrucero] [int] NOT NULL,
	[Recargo] [int] NOT NULL,
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
	[Nombre] [nchar](25) NOT NULL,
	[Apellido] [nchar](25) NOT NULL,
	[telefono] [int] NOT NULL,
	[mail] [nchar](25) NOT NULL,
	[direccion] [nchar](25) NOT NULL,
	[fechaNac] [date] NOT NULL,
	[dni] [nchar](8) NOT NULL,
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
	[idRecorrido] [int] IDENTITY(1,1) NOT NULL,
	[idCliente] [int] NOT NULL,
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
	[idViaje] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[cantidadPasajes] [int] NOT NULL,
	[medioPago] [int] NOT NULL,
	[tarjetaCredito] [int] NULL,
	[fecha] [date] NOT NULL,
	[precioTotal] [int] NOT NULL,
	[idCabina] [int] NOT NULL,
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
	[Modelo] [nvarchar](50) NOT NULL,
	[FechaAlta] [date] NOT NULL,
	[Identificador] [nvarchar](50) NOT NULL,
	[Fabricante] [int] NOT NULL,
	[TipoServicio] [int] NOT NULL,
	[CantidadCabinas] [int] NOT NULL,
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
	[Nombre] [nchar](25) NOT NULL,
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
	[idMedioPago] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
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
	[idPuerto] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](25) NOT NULL,
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
	[idRecorrido] [int] IDENTITY(1,1) NOT NULL,
	[codigo] [decimal](18,0),
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
	[idRecorrido] [int] IDENTITY(1,1) NOT NULL,
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
	[idReserva] [int] IDENTITY(1,1) NOT NULL,
	[idViaje] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[cantidadPasajeros] [int] NOT NULL,
	[fechas] [date] NOT NULL,
	[idCabina] [int] NOT NULL,
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
	[idRol] [int] IDENTITY(1,1) NOT NULL,
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
	[idServicio] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](25) NOT NULL,
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
	[idTarjetaCredito] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](10) NOT NULL,
	[cuotas] [int] NOT NULL,
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
	[idTipoBaja] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
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
	[idTipoCabina] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](50) NOT NULL,
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
	[idTramo] [int] IDENTITY(1,1) NOT NULL,
	[precio] [int] NOT NULL,
	[puertoOrigen] [int] NOT NULL,
	[puertoDestino] [int] NOT NULL,
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
	[idUsuario] [int] IDENTITY(1,1) NOT NULL,
	[username] [nchar](25) NOT NULL,
	[password] [nchar](25) NOT NULL,
	[fallos] [int] NOT NULL,
	[idRol] [int] NOT NULL,
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
	[idViaje] [int] IDENTITY(1,1) NOT NULL,
	[FechaInicio] [date] NOT NULL,
	[FechaFin] [date] NOT NULL,
	[idRecorrido] [int] NOT NULL,
	[idCrucero] [int] NOT NULL,
 CONSTRAINT [PK_Viaje] PRIMARY KEY CLUSTERED 
(
	[idViaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [gd_esquema].[Maestra]    Script Date: 05/06/2019 7:37:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [gd_esquema].[Maestra](
	[CLI_NOMBRE] [nvarchar](255) NULL,
	[CLI_APELLIDO] [nvarchar](255) NULL,
	[CLI_DNI] [decimal](18, 0) NULL,
	[CLI_DIRECCION] [nvarchar](255) NULL,
	[CLI_TELEFONO] [int] NULL,
	[CLI_MAIL] [nvarchar](255) NULL,
	[CLI_FECHA_NAC] [datetime2](3) NULL,
	[PASAJE_CODIGO] [decimal](18, 0) NULL,
	[PASAJE_PRECIO] [decimal](18, 2) NULL,
	[PASAJE_FECHA_COMPRA] [datetime2](3) NULL,
	[FECHA_SALIDA] [datetime2](3) NULL,
	[FECHA_LLEGADA] [datetime2](3) NULL,
	[FECHA_LLEGADA_ESTIMADA] [datetime2](3) NULL,
	[RECORRIDO_CODIGO] [decimal](18, 0) NULL,
	[RECORRIDO_PRECIO_BASE] [decimal](18, 2) NULL,
	[PUERTO_DESDE] [nvarchar](255) NULL,
	[PUERTO_HASTA] [nvarchar](255) NULL,
	[CABINA_NRO] [decimal](18, 0) NULL,
	[CABINA_PISO] [decimal](18, 0) NULL,
	[CRUCERO_MODELO] [nvarchar](50) NULL,
	[CRUCERO_IDENTIFICADOR] [nvarchar](50) NULL,
	[CABINA_TIPO] [nvarchar](255) NULL,
	[CABINA_TIPO_PORC_RECARGO] [decimal](18, 2) NULL,
	[CRU_FABRICANTE] [nvarchar](255) NULL,
	[RESERVA_CODIGO] [decimal](18, 0) NULL,
	[RESERVA_FECHA] [datetime2](3) NULL
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
ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cliente] FOREIGN KEY([idUsuario])
REFERENCES [dbo].[Usuario] ([idUsuario])
GO
ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cliente]
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
ALTER TABLE [dbo].[RecorridoXTramo]  WITH CHECK ADD  CONSTRAINT [FK_RecorridoXTramo_Tramo] FOREIGN KEY([idTramo])
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
USE [master]
GO
ALTER DATABASE [GD1C2019] SET  READ_WRITE 
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
insert into GD1C2019.dbo.Crucero(Identificador,Modelo, Fabricante) select distinct(CRUCERO_IDENTIFICADOR), CRUCERO_MODELO,(Select idFabricante from Fabricante where Nombre = CRU_FABRICANTE ) from gd_esquema.Maestra
GO
--Migracion Datos Cabina
insert into GD1C2019.dbo.Cabina(Numero,Piso, TipoCabina, idCrucero) select CABINA_NRO, CABINA_PISO, (select idTipoCabina from TipoCabina where Nombre = CABINA_TIPO) as tipo,
	(select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador) as crucero from gd_esquema.Maestra where (select count(*) from Cabina where Numero = CABINA_NRO and Piso = CABINA_PISO and idCrucero = (select intCrucero from Crucero where CRUCERO_IDENTIFICADOR = Identificador)) = 0
	group by CABINA_NRO, CABINA_PISO, CABINA_TIPO, CRUCERO_IDENTIFICADOR
	order by CABINA_NRO, CABINA_PISO, crucero
GO
insert into Tramo(puertoDestino, puertoOrigen, precioBase) select (select idPuerto from Puerto where PUERTO_HASTA = Nombre), (select idPuerto from Puerto where PUERTO_Desde = Nombre), RECORRIDO_PRECIO_BASE from gd_esquema.Maestra group by PUERTO_HASTA, PUERTO_DESDE, RECORRIDO_PRECIO_BASE
GO
insert into Recorrido(Codigo) select distinct(RECORRIDO_CODIGO) from gd_esquema.Maestra
GO
insert into RecorridoXTramo(idRecorrido, idTramo) select (select idRecorrido from Recorrido where codigo = RECORRIDO_CODIGO),
 (select idTramo from Tramo where PUERTO_DESDE = (select Nombre from Puerto where puertoOrigen = idPuerto) and PUERTO_HASTA = (select Nombre from Puerto where puertoDestino = idPuerto)) from gd_esquema.Maestra
 group by RECORRIDO_CODIGO, PUERTO_DESDE, PUERTO_HASTA
GO
insert into ClienteXRecorrido(idCliente, idRecorrido) select (select idCliente from Cliente where dni = CLI_DNI and CLI_NOMBRE = Nombre),
(select idRecorrido from Recorrido where codigo = RECORRIDO_CODIGO) from gd_esquema.Maestra group by CLI_DNI, RECORRIDO_CODIGO, CLI_NOMBRE
GO
insert into dbo.Viaje(FechaInicio, FechaFin, FechaFinEstimada, idCrucero, idRecorrido) select FECHA_SALIDA, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA,
 (select intCrucero from Crucero where Identificador = CRUCERO_IDENTIFICADOR and Modelo = CRUCERO_MODELO), (select idRecorrido from Recorrido where RECORRIDO_CODIGO = codigo)
  from gd_esquema.Maestra group by RECORRIDO_CODIGO, CRUCERO_IDENTIFICADOR, CRUCERO_MODELO, FECHA_LLEGADA, FECHA_LLEGADA_ESTIMADA, FECHA_SALIDA
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

Create PROCEDURE dbo.sp_modificar_recorrido (@codigo decimal(18,0), @idRecorrido int) 
AS BEGIN

    BEGIN TRANSACTION T1
	UPDATE Recorrido set codigo = @codigo where idRecorrido = @idRecorrido
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
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

Create PROCEDURE dbo.sp_modificar_tramo (@idTramo int, @puertoOrigen int, @puertoDestino int, @precio int) 
AS BEGIN

    BEGIN TRANSACTION T1
	Update Tramo set puertoOrigen = @puertoOrigen, puertoDestino = @puertoDestino, precioBase = @precio where idTramo = @idTramo
	
	if (@@ERROR !=0)
        ROLLBACK TRANSACTION T1;
	COMMIT TRANSACTION T1;
	
END
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