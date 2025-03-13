USE [master]
GO
/****** Object:  Database [TiendaDB]    Script Date: 13/03/2025 17:30:26 ******/
CREATE DATABASE [TiendaDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TiendaDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TiendaDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TiendaDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\TiendaDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [TiendaDB] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TiendaDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TiendaDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TiendaDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TiendaDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TiendaDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TiendaDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [TiendaDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [TiendaDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TiendaDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TiendaDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TiendaDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TiendaDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TiendaDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TiendaDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TiendaDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TiendaDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [TiendaDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TiendaDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TiendaDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TiendaDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TiendaDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TiendaDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TiendaDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TiendaDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TiendaDB] SET  MULTI_USER 
GO
ALTER DATABASE [TiendaDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TiendaDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TiendaDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TiendaDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TiendaDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TiendaDB] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TiendaDB] SET QUERY_STORE = ON
GO
ALTER DATABASE [TiendaDB] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [TiendaDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulo]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulo](
	[ArticuloID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](max) NOT NULL,
	[Descripcion] [nvarchar](max) NOT NULL,
	[Precio] [decimal](18, 2) NOT NULL,
	[Imagen] [nvarchar](max) NOT NULL,
	[Stock] [int] NOT NULL,
 CONSTRAINT [PK_Articulo] PRIMARY KEY CLUSTERED 
(
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Articulos]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Articulos](
	[ArticuloID] [int] IDENTITY(1,1) NOT NULL,
	[Codigo] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](255) NOT NULL,
	[Precio] [decimal](10, 2) NOT NULL,
	[Imagen] [nvarchar](255) NULL,
	[Stock] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ArticuloTienda]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ArticuloTienda](
	[ArticuloID] [int] NOT NULL,
	[TiendaID] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ArticuloTienda] PRIMARY KEY CLUSTERED 
(
	[ArticuloID] ASC,
	[TiendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[ClienteID] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](max) NOT NULL,
	[Apellidos] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ClienteArticulo]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ClienteArticulo](
	[ClienteID] [int] NOT NULL,
	[ArticuloID] [int] NOT NULL,
	[ID] [int] NOT NULL,
	[Fecha] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_ClienteArticulo] PRIMARY KEY CLUSTERED 
(
	[ClienteID] ASC,
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tiendas]    Script Date: 13/03/2025 17:30:26 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tiendas](
	[TiendaID] [int] IDENTITY(1,1) NOT NULL,
	[Sucursal] [nvarchar](max) NOT NULL,
	[Direccion] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Tiendas] PRIMARY KEY CLUSTERED 
(
	[TiendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Index [IX_ArticuloTienda_TiendaID]    Script Date: 13/03/2025 17:30:26 ******/
CREATE NONCLUSTERED INDEX [IX_ArticuloTienda_TiendaID] ON [dbo].[ArticuloTienda]
(
	[TiendaID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_ClienteArticulo_ArticuloID]    Script Date: 13/03/2025 17:30:26 ******/
CREATE NONCLUSTERED INDEX [IX_ClienteArticulo_ArticuloID] ON [dbo].[ClienteArticulo]
(
	[ArticuloID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[ArticuloTienda]  WITH CHECK ADD  CONSTRAINT [FK_ArticuloTienda_Articulo_ArticuloID] FOREIGN KEY([ArticuloID])
REFERENCES [dbo].[Articulo] ([ArticuloID])
GO
ALTER TABLE [dbo].[ArticuloTienda] CHECK CONSTRAINT [FK_ArticuloTienda_Articulo_ArticuloID]
GO
ALTER TABLE [dbo].[ArticuloTienda]  WITH CHECK ADD  CONSTRAINT [FK_ArticuloTienda_Tiendas_TiendaID] FOREIGN KEY([TiendaID])
REFERENCES [dbo].[Tiendas] ([TiendaID])
GO
ALTER TABLE [dbo].[ArticuloTienda] CHECK CONSTRAINT [FK_ArticuloTienda_Tiendas_TiendaID]
GO
ALTER TABLE [dbo].[ClienteArticulo]  WITH CHECK ADD  CONSTRAINT [FK_ClienteArticulo_Articulo_ArticuloID] FOREIGN KEY([ArticuloID])
REFERENCES [dbo].[Articulo] ([ArticuloID])
GO
ALTER TABLE [dbo].[ClienteArticulo] CHECK CONSTRAINT [FK_ClienteArticulo_Articulo_ArticuloID]
GO
ALTER TABLE [dbo].[ClienteArticulo]  WITH CHECK ADD  CONSTRAINT [FK_ClienteArticulo_Cliente_ClienteID] FOREIGN KEY([ClienteID])
REFERENCES [dbo].[Cliente] ([ClienteID])
GO
ALTER TABLE [dbo].[ClienteArticulo] CHECK CONSTRAINT [FK_ClienteArticulo_Cliente_ClienteID]
GO
USE [master]
GO
ALTER DATABASE [TiendaDB] SET  READ_WRITE 
GO
