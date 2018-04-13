USE [master]
GO
/****** Object:  Database [JudithBakery]    Script Date: 13/4/2018 1:04:49 p. m. ******/
CREATE DATABASE [JudithBakery]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'JudithBakery', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\JudithBakery.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'JudithBakery_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\JudithBakery_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [JudithBakery] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [JudithBakery].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [JudithBakery] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [JudithBakery] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [JudithBakery] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [JudithBakery] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [JudithBakery] SET ARITHABORT OFF 
GO
ALTER DATABASE [JudithBakery] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [JudithBakery] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [JudithBakery] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [JudithBakery] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [JudithBakery] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [JudithBakery] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [JudithBakery] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [JudithBakery] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [JudithBakery] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [JudithBakery] SET  ENABLE_BROKER 
GO
ALTER DATABASE [JudithBakery] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [JudithBakery] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [JudithBakery] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [JudithBakery] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [JudithBakery] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [JudithBakery] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [JudithBakery] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [JudithBakery] SET RECOVERY FULL 
GO
ALTER DATABASE [JudithBakery] SET  MULTI_USER 
GO
ALTER DATABASE [JudithBakery] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [JudithBakery] SET DB_CHAINING OFF 
GO
ALTER DATABASE [JudithBakery] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [JudithBakery] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [JudithBakery] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'JudithBakery', N'ON'
GO
USE [JudithBakery]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Categoria](
	[IdCategoria] [int] NOT NULL,
	[Categoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[IdCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Compra]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Compra](
	[IdCompra] [int] IDENTITY(1,1) NOT NULL,
	[IdProveedor] [int] NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[FechaCompra] [date] NOT NULL,
	[IdTipoPago] [int] NULL,
 CONSTRAINT [PK_Compra] PRIMARY KEY CLUSTERED 
(
	[IdCompra] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleCompra]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleCompra](
	[IdCompra] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_Uni] [nchar](10) NULL,
	[Descuento] [decimal](18, 2) NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[IdVenta] [int] NOT NULL,
	[IdProducto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[Precio_Uni] [decimal](18, 2) NOT NULL,
	[Descuento] [decimal](18, 2) NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleado]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleado](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](150) NOT NULL,
	[Direccion] [varchar](100) NULL,
	[Email] [varchar](50) NULL,
	[Telefono] [char](9) NULL,
	[Sexo] [char](1) NULL,
	[DUI] [char](10) NULL,
	[NIT] [char](17) NULL,
	[Sueldo] [money] NULL,
	[Usuario] [varchar](50) NULL,
	[Contraseña] [varchar](50) NULL,
	[Cargo] [varchar](50) NOT NULL,
	[Activo] [bit] NOT NULL,
 CONSTRAINT [PK_Empleado] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Inventario](
	[IdProducto] [int] IDENTITY(1,1) NOT NULL,
	[Nom_Producto] [varchar](100) NOT NULL,
	[Precio_Uni] [decimal](18, 2) NOT NULL,
	[Cantidad] [int] NOT NULL,
	[IdCategoria] [int] NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[IdProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Proveedor](
	[IdProveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[FAX] [char](9) NULL,
	[NIT] [char](17) NOT NULL,
	[Num_Registro] [char](20) NOT NULL,
	[Servicio] [varchar](50) NULL,
	[Email] [varchar](50) NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[IdProveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TiposDePago]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TiposDePago](
	[IdTipoPago] [int] NOT NULL,
	[Tipo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_TiposDePago] PRIMARY KEY CLUSTERED 
(
	[IdTipoPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 13/4/2018 1:04:49 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[IdVenta] [int] IDENTITY(1,1) NOT NULL,
	[IdEmpleado] [int] NOT NULL,
	[FechaVenta] [date] NOT NULL,
	[IdTipoPago] [int] NULL,
 CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED 
(
	[IdVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Empleado] ON 

INSERT [dbo].[Empleado] ([IdEmpleado], [Nombre], [Direccion], [Email], [Telefono], [Sexo], [DUI], [NIT], [Sueldo], [Usuario], [Contraseña], [Cargo], [Activo]) VALUES (1, N'Eduardo Noyola', N'Santa Ana', N'eduar@gmail.com', N'78916487 ', N'M', N'05440210-7', N'0210-290896-106-9', 500.0000, N'lexar', N'tvZ8FHaQRAw=', N'Administrador', 0)
SET IDENTITY_INSERT [dbo].[Empleado] OFF
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Empleado]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_Proveedor] FOREIGN KEY([IdProveedor])
REFERENCES [dbo].[Proveedor] ([IdProveedor])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_Proveedor]
GO
ALTER TABLE [dbo].[Compra]  WITH CHECK ADD  CONSTRAINT [FK_Compra_TiposDePago] FOREIGN KEY([IdTipoPago])
REFERENCES [dbo].[TiposDePago] ([IdTipoPago])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Compra] CHECK CONSTRAINT [FK_Compra_TiposDePago]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Compra] FOREIGN KEY([IdCompra])
REFERENCES [dbo].[Compra] ([IdCompra])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Compra]
GO
ALTER TABLE [dbo].[DetalleCompra]  WITH CHECK ADD  CONSTRAINT [FK_DetalleCompra_Inventario] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Inventario] ([IdProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleCompra] CHECK CONSTRAINT [FK_DetalleCompra_Inventario]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Inventario] FOREIGN KEY([IdProducto])
REFERENCES [dbo].[Inventario] ([IdProducto])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Inventario]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([IdVenta])
REFERENCES [dbo].[Venta] ([IdVenta])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[Inventario]  WITH CHECK ADD  CONSTRAINT [FK_Inventario_Categoria] FOREIGN KEY([IdCategoria])
REFERENCES [dbo].[Categoria] ([IdCategoria])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Inventario] CHECK CONSTRAINT [FK_Inventario_Categoria]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Empleado] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleado] ([IdEmpleado])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Empleado]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_TiposDePago] FOREIGN KEY([IdTipoPago])
REFERENCES [dbo].[TiposDePago] ([IdTipoPago])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_TiposDePago]
GO
USE [master]
GO
ALTER DATABASE [JudithBakery] SET  READ_WRITE 
GO
