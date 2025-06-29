USE [master]
GO
/****** Object:  Database [Fravega]    Script Date: 27/11/2024 14:23:52 ******/
CREATE DATABASE [Fravega]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Fravega', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Fravega.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Fravega_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Fravega_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Fravega] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Fravega].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Fravega] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Fravega] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Fravega] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Fravega] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Fravega] SET ARITHABORT OFF 
GO
ALTER DATABASE [Fravega] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Fravega] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Fravega] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Fravega] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Fravega] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Fravega] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Fravega] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Fravega] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Fravega] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Fravega] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Fravega] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Fravega] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Fravega] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Fravega] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Fravega] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Fravega] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Fravega] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Fravega] SET RECOVERY FULL 
GO
ALTER DATABASE [Fravega] SET  MULTI_USER 
GO
ALTER DATABASE [Fravega] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Fravega] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Fravega] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Fravega] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Fravega] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Fravega] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [Fravega] SET QUERY_STORE = ON
GO
ALTER DATABASE [Fravega] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Fravega]
GO
/****** Object:  Table [dbo].[Categoria]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categoria](
	[idCategoria] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categoria] PRIMARY KEY CLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[dni] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[telefono] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[dni] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DetalleVenta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleVenta](
	[idDetalleVenta] [int] NOT NULL,
	[nroVenta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[subtotal] [int] NOT NULL,
 CONSTRAINT [PK_DetalleVenta] PRIMARY KEY CLUSTERED 
(
	[idDetalleVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedioDePago](
	[nroTarjeta] [nvarchar](16) NOT NULL,
	[idTipoTarjeta] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[fechaCaducidad] [datetime] NOT NULL,
	[cvv] [int] NOT NULL,
 CONSTRAINT [PK_MedioDePago] PRIMARY KEY CLUSTERED 
(
	[nroTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[idProducto] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[descripcion] [nvarchar](200) NOT NULL,
	[idCategoria] [int] NOT NULL,
	[stock] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[idTipoTarjeta] [int] NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_TipoTarjeta] PRIMARY KEY CLUSTERED 
(
	[idTipoTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[idUsuario] [int] NOT NULL,
	[contraseña] [nvarchar](max) NOT NULL,
	[dni] [int] NOT NULL,
	[admin] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUsuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Venta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Venta](
	[nroVenta] [int] NOT NULL,
	[dni] [int] NOT NULL,
	[total] [int] NOT NULL,
	[fecha] [datetime] NOT NULL,
	[nroTarjeta] [nvarchar](16) NOT NULL,
 CONSTRAINT [PK_venta] PRIMARY KEY CLUSTERED 
(
	[nroVenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Categoria] ([idCategoria], [nombre], [descripcion]) VALUES (1, N'Televisores', N'LG')
INSERT [dbo].[Categoria] ([idCategoria], [nombre], [descripcion]) VALUES (2, N'Electrodomésticos', N'Philips')
INSERT [dbo].[Categoria] ([idCategoria], [nombre], [descripcion]) VALUES (3, N'Audio y Sonido', N'JBL')
INSERT [dbo].[Categoria] ([idCategoria], [nombre], [descripcion]) VALUES (4, N'Accesorios', N'Logitech')
INSERT [dbo].[Categoria] ([idCategoria], [nombre], [descripcion]) VALUES (5, N'Computación', N'HP')
GO
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (1, N'Pedro', N'Sakihara', N'1150112608')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (42739172, N'Lautaro', N'Sakihara', N'12345678')
INSERT [dbo].[Cliente] ([dni], [nombre], [apellido], [telefono]) VALUES (45151374, N'julian', N'nunez', N'1123915424')
GO
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subtotal]) VALUES (1, 1, 2, 1, 100)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subtotal]) VALUES (2, 2, 3, 3, 600)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subtotal]) VALUES (3, 2, 2, 2, 200)
INSERT [dbo].[DetalleVenta] ([idDetalleVenta], [nroVenta], [idProducto], [cantidad], [subtotal]) VALUES (4, 3, 2, 2, 200)
GO
INSERT [dbo].[MedioDePago] ([nroTarjeta], [idTipoTarjeta], [dni], [fechaCaducidad], [cvv]) VALUES (N'1234', 1, 45151374, CAST(N'2025-10-10T00:00:00.000' AS DateTime), 123)
INSERT [dbo].[MedioDePago] ([nroTarjeta], [idTipoTarjeta], [dni], [fechaCaducidad], [cvv]) VALUES (N'1234567890123451', 3, 42739172, CAST(N'2034-12-12T00:00:00.000' AS DateTime), 123)
INSERT [dbo].[MedioDePago] ([nroTarjeta], [idTipoTarjeta], [dni], [fechaCaducidad], [cvv]) VALUES (N'1234567890123456', 0, 0, CAST(N'2033-11-11T00:00:00.000' AS DateTime), 123)
INSERT [dbo].[MedioDePago] ([nroTarjeta], [idTipoTarjeta], [dni], [fechaCaducidad], [cvv]) VALUES (N'6061123456781234', 1, 45151374, CAST(N'2029-10-10T00:00:00.000' AS DateTime), 1234)
GO
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [idCategoria], [stock], [precio]) VALUES (2, N'Pollo', N'Crispy', 4, 49, 100)
INSERT [dbo].[Producto] ([idProducto], [nombre], [descripcion], [idCategoria], [stock], [precio]) VALUES (3, N'SmartWatch', N'SmartWatch Band 3', 4, 49, 200)
GO
INSERT [dbo].[TipoTarjeta] ([idTipoTarjeta], [nombre]) VALUES (1, N'MasterCard')
INSERT [dbo].[TipoTarjeta] ([idTipoTarjeta], [nombre]) VALUES (2, N'Visa')
INSERT [dbo].[TipoTarjeta] ([idTipoTarjeta], [nombre]) VALUES (3, N'American Express')
GO
INSERT [dbo].[Usuario] ([idUsuario], [contraseña], [dni], [admin]) VALUES (1, N'1', 1, 1)
INSERT [dbo].[Usuario] ([idUsuario], [contraseña], [dni], [admin]) VALUES (2, N'1234', 45151374, 0)
INSERT [dbo].[Usuario] ([idUsuario], [contraseña], [dni], [admin]) VALUES (3, N'a12345678', 42739172, 0)
GO
INSERT [dbo].[Venta] ([nroVenta], [dni], [total], [fecha], [nroTarjeta]) VALUES (1, 42739172, 100, CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'1234567890123451')
INSERT [dbo].[Venta] ([nroVenta], [dni], [total], [fecha], [nroTarjeta]) VALUES (2, 45151374, 800, CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'1234')
INSERT [dbo].[Venta] ([nroVenta], [dni], [total], [fecha], [nroTarjeta]) VALUES (3, 45151374, 200, CAST(N'2024-11-27T00:00:00.000' AS DateTime), N'1234')
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Producto] FOREIGN KEY([idProducto])
REFERENCES [dbo].[Producto] ([idProducto])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Producto]
GO
ALTER TABLE [dbo].[DetalleVenta]  WITH CHECK ADD  CONSTRAINT [FK_DetalleVenta_Venta] FOREIGN KEY([nroVenta])
REFERENCES [dbo].[Venta] ([nroVenta])
GO
ALTER TABLE [dbo].[DetalleVenta] CHECK CONSTRAINT [FK_DetalleVenta_Venta]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_User_Cliente] FOREIGN KEY([dni])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_User_Cliente]
GO
ALTER TABLE [dbo].[Venta]  WITH CHECK ADD  CONSTRAINT [FK_Venta_Cliente] FOREIGN KEY([dni])
REFERENCES [dbo].[Cliente] ([dni])
GO
ALTER TABLE [dbo].[Venta] CHECK CONSTRAINT [FK_Venta_Cliente]
GO
/****** Object:  StoredProcedure [dbo].[ActualizarCategoria]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarCategoria]
    @idCategoria INT,
    @Nombre NVARCHAR(50),
    @Descripcion NVARCHAR(255)
AS
BEGIN
    UPDATE Categoria
    SET Nombre = @Nombre,
        Descripcion = @Descripcion
    WHERE idCategoria = @idCategoria;
END;
GO
/****** Object:  StoredProcedure [dbo].[ActualizarProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarProducto] 
	@idProducto int,
	@Nombre nvarchar(50),
	@Descripcion nvarchar(200),
	@Stock INT,
	@idCategoria INT,
	@Precio decimal(10,0)
AS
BEGIN
	update Producto set 
	nombre = @Nombre,
	stock = @Stock,
	descripcion = @Descripcion,
	idCategoria = @idCategoria,
	precio = @Precio
	where idProducto = @idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[ActualizarUsuario]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ActualizarUsuario]
    @DNI INT,
	@Nombre NVARCHAR(250),
	@Apellido NVARCHAR(250),
	@Telefono INT
AS
BEGIN
    UPDATE Cliente
    SET nombre = @Nombre, apellido = @Apellido, telefono = @Telefono
    WHERE dni = @DNI;
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarCategoria]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarCategoria]
    @Nombre NVARCHAR(50),
    @Descripcion NVARCHAR(255)
AS
BEGIN
	declare @UltimoID int
	set @UltimoID = (select coalesce(MAX(idCategoria),0) + 1 from Categoria)
    INSERT INTO Categoria
	VALUES (@UltimoId,@Nombre, @Descripcion);
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarDetalleVenta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarDetalleVenta]
    @nroVenta INT,
    @idProducto INT,
    @cantidad INT,
    @subtotal INT
AS
BEGIN
	declare @UltimoID int
	set @UltimoID = (select coalesce(MAX(idDetalleVenta),0) + 1 from DetalleVenta)
    INSERT INTO DetalleVenta (idDetalleVenta,nroVenta, idProducto, cantidad, subtotal)
    VALUES (@UltimoID,@nroVenta, @idProducto, @cantidad, @subtotal);

	update Producto
	set stock -= @cantidad
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarMedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarMedioDePago]
    @nroTarjeta nvarchar(16),
    @idTipoTarjeta INT,
    @dni INT,
    @FechaCaducidad DATE,
    @cvv INT
AS
BEGIN
    INSERT INTO MedioDePago
    VALUES (@nroTarjeta, @idTipoTarjeta, @dni, @FechaCaducidad, @cvv);
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarProducto]
    @Nombre NVARCHAR(50),
    @Descripcion NVARCHAR(200),
	@IdCategoria INT,
	@Stock INT,
    @Precio DECIMAL(18, 2)
AS
BEGIN
	declare @UltimoID int
	set @UltimoID = (select coalesce(MAX(idProducto),0) + 1 from Producto)

    INSERT INTO Producto
    VALUES (@UltimoID,@Nombre, @Descripcion,@IdCategoria,@Stock,@Precio);
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarTipoTarjeta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Store Procedure: Agregar Tipo de Tarjeta
CREATE PROCEDURE [dbo].[AgregarTipoTarjeta]
    @Nombre NVARCHAR(50)
AS
BEGIN
    INSERT INTO TipoTarjeta (Nombre) VALUES (@Nombre);
END;
GO
/****** Object:  StoredProcedure [dbo].[AgregarVenta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[AgregarVenta]
    @DNI INT,
    @Total INT,
    @Fecha DATE,
	@NroTarjeta nvarchar(50)
AS
BEGIN
	declare @UltimoID int
	set @UltimoID = (select coalesce(MAX(nroVenta),0) + 1 from Venta)

    INSERT INTO Venta (nroVenta,dni, total, fecha,nroTarjeta)
    VALUES (@UltimoID,@DNI, @Total, @Fecha,@NroTarjeta);
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarCategoria]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarCategoria]
@IdCategoria INT
AS
BEGIN
DELETE FROM Categoria
WHERE idCategoria = @IdCategoria
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarMedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Store Procedure: Eliminar Medio de Pago
CREATE PROCEDURE [dbo].[EliminarMedioDePago]
    @nroTarjeta nvarchar(16)
AS
BEGIN
    DELETE FROM MedioDePago WHERE nroTarjeta = @nroTarjeta;
END;
GO
/****** Object:  StoredProcedure [dbo].[EliminarProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[EliminarProducto] 
	@idProducto int
AS
BEGIN
	delete Producto where idProducto = @idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[EliminarUsuario]
    @dni INT
AS
BEGIN
    DELETE FROM Cliente WHERE dni = @dni;
END;
GO
/****** Object:  StoredProcedure [dbo].[getIdProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getIdProducto]
@nombre nvarchar(50)
AS
BEGIN
	select idProducto from Producto where nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[getNombreProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getNombreProducto]
	@id int
AS
BEGIN
	select nombre from Producto where idProducto = @id
END
GO
/****** Object:  StoredProcedure [dbo].[getPrecioProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getPrecioProducto]
@idProducto int
AS
BEGIN
	select precio from Producto where idProducto = @idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[getStock]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getStock]
	@idProducto int
AS
BEGIN
	select stock from Producto where idProducto = @idProducto
END
GO
/****** Object:  StoredProcedure [dbo].[ListarDetallesDeVentas]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarDetallesDeVentas]
AS
BEGIN
	SELECT * FROM DetalleVenta
END
GO
/****** Object:  StoredProcedure [dbo].[ListarDetalleVenta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Store Procedure: Listar Detalle de Venta
CREATE PROCEDURE [dbo].[ListarDetalleVenta]
    @nroVenta INT
AS
BEGIN
    SELECT idDetalleVenta, nroVenta, idProducto, cantidad, subtotal
    FROM DetalleVenta
    WHERE nroVenta = @nroVenta;
END;
GO
/****** Object:  StoredProcedure [dbo].[ListarMedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarMedioDePago]
    @Dni INT
AS
BEGIN
    SELECT * FROM MedioDePago where dni = @Dni
END;
GO
/****** Object:  StoredProcedure [dbo].[ListarTipoTarjeta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- Store Procedure: Listar Tipos de Tarjeta
CREATE PROCEDURE [dbo].[ListarTipoTarjeta]
AS
BEGIN
    SELECT * FROM TipoTarjeta;
END;
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuarios]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarUsuarios]
AS
BEGIN
	SELECT 
    Usuario.idUsuario,
    Usuario.contraseña,
    Usuario.dni,
    Usuario.admin,
    Cliente.Nombre,
    Cliente.Apellido,
    Cliente.dni,
    Cliente.Telefono
FROM Usuario
INNER JOIN Cliente ON Usuario.dni = Cliente.dni;
END
GO
/****** Object:  StoredProcedure [dbo].[ListarVentas]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarVentas]
AS
BEGIN
	SELECT * FROM Venta
END;
GO
/****** Object:  StoredProcedure [dbo].[ListarVentasPorDni]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ListarVentasPorDni]
@DNI INT
AS
BEGIN
	SELECT nroVenta,total,fecha,nroTarjeta FROM Venta
	WHERE dni = @DNI 
END;
GO
/****** Object:  StoredProcedure [dbo].[ObtenerIdTipoTarjeta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ObtenerIdTipoTarjeta]
@nombre nvarchar(50)
AS
BEGIN
	select idTipoTarjeta from TipoTarjeta
	where nombre = @nombre
END
GO
/****** Object:  StoredProcedure [dbo].[RegistrarUsuario]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[RegistrarUsuario]
	@DNI INT,
	@Nombre NVARCHAR(50),
	@Apellido NVARCHAR(50),
	@Telefono INT,
    @Contraseña NVARCHAR(MAX)
AS
BEGIN
	INSERT INTO Cliente (dni , nombre, apellido , telefono )
	VALUES
	(@DNI , @Nombre , @Apellido , @Telefono )

	DECLARE @last_userId INT = ISNULL((SELECT MAX(idUsuario) + 1 FROM Usuario), 0)

	INSERT INTO Usuario
	VALUES (@last_userId, @Contraseña, @DNI, 0)

END;
GO
/****** Object:  StoredProcedure [dbo].[selectCategorias]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectCategorias]
AS
BEGIN
    SELECT * FROM Categoria;
END;
GO
/****** Object:  StoredProcedure [dbo].[selectNombreCategoriaSegunID]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[selectNombreCategoriaSegunID]
    @idCategoria INT
AS
BEGIN
    SELECT Nombre FROM Categoria WHERE idCategoria = @idCategoria;
END;
GO
/****** Object:  StoredProcedure [dbo].[SelectProductos]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectProductos]
AS
BEGIN
    SELECT * FROM Producto;
END;
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerarXMLCategorias]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerarXMLCategorias]
AS
BEGIN
    SELECT *
    FROM Categoria

END
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerarXMLMedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerarXMLMedioDePago]
AS
BEGIN
    SELECT *
    FROM MedioDePago

END
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerarXMLProducto]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerarXMLProducto]
AS
BEGIN
    SELECT *
    FROM Producto

END;
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerarXMLUsuario]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerarXMLUsuario]
AS
BEGIN
    SELECT *
    FROM Usuario

END
GO
/****** Object:  StoredProcedure [dbo].[sp_GenerarXMLVenta]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_GenerarXMLVenta]
AS
BEGIN
    SELECT *
    FROM Venta

END
GO
/****** Object:  StoredProcedure [dbo].[sp_Login]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[sp_Login]
	@dni int,
	@contraseña nvarchar(max)
AS
BEGIN
	 SELECT LoginUser.idUsuario, LoginUser.dni, LoginUser.admin,
    Cliente.nombre, Cliente.apellido
    FROM Usuario AS LoginUser
    JOIN Cliente AS Cliente ON Cliente.dni = Loginuser.dni
    WHERE contraseña = @contraseña AND  Cliente.dni = @dni
END
GO
/****** Object:  StoredProcedure [dbo].[ValidarMedioDePago]    Script Date: 27/11/2024 14:23:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[ValidarMedioDePago]
	@nroTarjeta nvarchar(16),
	@cvv int
AS
BEGIN
	select * from MedioDePago where nroTarjeta = @nroTarjeta and cvv = @cvv
END
GO
USE [master]
GO
ALTER DATABASE [Fravega] SET  READ_WRITE 
GO
