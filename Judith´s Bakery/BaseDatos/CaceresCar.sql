USE [master]
GO
/****** Object:  Database [CaceresCar]    Script Date: 2/3/2018 7:47:05 p. m. ******/
CREATE DATABASE [CaceresCar]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CaceresCar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CaceresCar.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'CaceresCar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\CaceresCar_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [CaceresCar] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CaceresCar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CaceresCar] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CaceresCar] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CaceresCar] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CaceresCar] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CaceresCar] SET ARITHABORT OFF 
GO
ALTER DATABASE [CaceresCar] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [CaceresCar] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CaceresCar] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CaceresCar] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CaceresCar] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CaceresCar] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CaceresCar] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CaceresCar] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CaceresCar] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CaceresCar] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CaceresCar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CaceresCar] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CaceresCar] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CaceresCar] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CaceresCar] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CaceresCar] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CaceresCar] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CaceresCar] SET RECOVERY FULL 
GO
ALTER DATABASE [CaceresCar] SET  MULTI_USER 
GO
ALTER DATABASE [CaceresCar] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CaceresCar] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CaceresCar] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CaceresCar] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [CaceresCar] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'CaceresCar', N'ON'
GO
USE [CaceresCar]
GO
/****** Object:  Table [dbo].[Cargos]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cargos](
	[IdCargo] [int] IDENTITY(1,1) NOT NULL,
	[Cargo] [varchar](30) NOT NULL,
 CONSTRAINT [PK_Cargos] PRIMARY KEY CLUSTERED 
(
	[IdCargo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Clientes](
	[IdCliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](150) NOT NULL,
	[Telefono] [char](9) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ControlUsuario]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ControlUsuario](
	[IdEmpleado] [int] NOT NULL,
	[HoraEntrada] [time](7) NOT NULL,
	[HoraSalida] [time](7) NOT NULL,
	[Dia] [date] NOT NULL,
 CONSTRAINT [PK_ControlUsuario] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Empleados](
	[IdEmpleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](150) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[Telefono] [char](9) NOT NULL,
	[Sexo] [char](1) NOT NULL,
	[Edad] [int] NOT NULL,
	[Sueldo] [money] NOT NULL,
	[IdCargo] [int] NOT NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[IdEmpleado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuarios](
	[IdUsuario] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Apellido] [varchar](150) NOT NULL,
	[Direccion] [varchar](150) NOT NULL,
	[FechaNacimiento] [varchar](50) NOT NULL,
	[Telefono] [int] NOT NULL,
	[Usuario] [varchar](50) NOT NULL,
	[Contraseña] [varchar](50) NOT NULL,
	[Cargo] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[IdUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Vehiculos]    Script Date: 2/3/2018 7:47:05 p. m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Vehiculos](
	[Placa] [nchar](12) NOT NULL,
	[Marca] [varchar](50) NOT NULL,
	[Modelo] [varchar](50) NOT NULL,
	[Color] [varchar](50) NOT NULL,
	[IdCliente] [int] NULL,
 CONSTRAINT [PK_Vehiculos] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (1, N'Eduardo ', N'Noyola', N'Los Angeles', N'1996-08-29', 75483165, N'Lexar7', N'HOLA', N'Administrador')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (3, N'Rodrigo', N'Ramos', N'Santa Ana', N'1997-05-10', 74893561, N'visca11', N'1234', N'Administrador')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (9, N'Kendrick', N'Lamar', N'Los Angeles', N'1985-01-10', 78941615, N'lamar9', N'1234', N'Empleado')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (1017, N'Leo', N'Messi', N'Argentina', N'24-Febrero-1977', 78946131, N'messi', N'1234', N'Administrador	')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (1018, N'Willy', N'Rex', N'España', N'24-Septiembre-1957', 78945612, N'willyrex', N'1234', N'Administrador	')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (1019, N'Joel', N'Figueroa', N'Santa Ana', N'21-Mayo-1937', 7894651, N'Sultanes25', N'1234', N'Administrador	')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (2017, N'Daniel', N'Quesada', N'Santa Tecla', N'18-Noviembre-1997', 7896235, N'dantez', N'/bWDpIqcAlQ=', N'Empleado')
INSERT [dbo].[Usuarios] ([IdUsuario], [Nombre], [Apellido], [Direccion], [FechaNacimiento], [Telefono], [Usuario], [Contraseña], [Cargo]) VALUES (3017, N'Marshall', N'Matters', N'Los Angelos', N'25-Diciembre-1938', 7894645, N'Eminem', N'tvZ8FHaQRAw=', N'Administrador	')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
ALTER TABLE [dbo].[ControlUsuario]  WITH CHECK ADD  CONSTRAINT [FK_ControlUsuario_Empleados] FOREIGN KEY([IdEmpleado])
REFERENCES [dbo].[Empleados] ([IdEmpleado])
GO
ALTER TABLE [dbo].[ControlUsuario] CHECK CONSTRAINT [FK_ControlUsuario_Empleados]
GO
ALTER TABLE [dbo].[Empleados]  WITH CHECK ADD  CONSTRAINT [FK_Empleados_Cargos] FOREIGN KEY([IdCargo])
REFERENCES [dbo].[Cargos] ([IdCargo])
GO
ALTER TABLE [dbo].[Empleados] CHECK CONSTRAINT [FK_Empleados_Cargos]
GO
USE [master]
GO
ALTER DATABASE [CaceresCar] SET  READ_WRITE 
GO
