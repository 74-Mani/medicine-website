USE [master]
GO
/****** Object:  Database [Medical.Web]    Script Date: 07/22/2013 20:10:12 ******/
CREATE DATABASE [Medical.Web] ON  PRIMARY 
( NAME = N'Medical.Web', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Medical.Web.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'Medical.Web_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10_50.MSSQLSERVER\MSSQL\DATA\Medical.Web_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [Medical.Web] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Medical.Web].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Medical.Web] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [Medical.Web] SET ANSI_NULLS OFF
GO
ALTER DATABASE [Medical.Web] SET ANSI_PADDING OFF
GO
ALTER DATABASE [Medical.Web] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [Medical.Web] SET ARITHABORT OFF
GO
ALTER DATABASE [Medical.Web] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [Medical.Web] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [Medical.Web] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [Medical.Web] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [Medical.Web] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [Medical.Web] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [Medical.Web] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [Medical.Web] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [Medical.Web] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [Medical.Web] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [Medical.Web] SET  DISABLE_BROKER
GO
ALTER DATABASE [Medical.Web] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [Medical.Web] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [Medical.Web] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [Medical.Web] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [Medical.Web] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [Medical.Web] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [Medical.Web] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [Medical.Web] SET  READ_WRITE
GO
ALTER DATABASE [Medical.Web] SET RECOVERY FULL
GO
ALTER DATABASE [Medical.Web] SET  MULTI_USER
GO
ALTER DATABASE [Medical.Web] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [Medical.Web] SET DB_CHAINING OFF
GO
EXEC sys.sp_db_vardecimal_storage_format N'Medical.Web', N'ON'
GO
USE [Medical.Web]
GO
/****** Object:  Table [dbo].[WareHouseMinimumAllow]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouseMinimumAllow](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[Amount] [int] NULL,
	[Note] [nvarchar](100) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdateUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_tblTonKhoToiThieu_1] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WareHouseIODetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouseIODetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[WareHouseIOId] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[LotNo] [char](20) NOT NULL,
	[ExpireDate] [datetime] NOT NULL,
	[Qty] [int] NOT NULL,
	[UnitPrice] [int] NULL,
	[Unit] [int] NULL,
	[Amount] [int] NULL,
	[CreatedDate] [datetime] NULL,
	[Version] [int] NOT NULL,
	[Type] [nvarchar](50) NULL,
 CONSTRAINT [PK_WareHousePaperDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WareHouseIO]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouseIO](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[Type] [char](1) NOT NULL,
	[ClinicId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[No] [varchar](20) NULL,
	[Person] [nvarchar](100) NULL,
	[Phone] [varchar](20) NULL,
	[Address] [varchar](120) NULL,
	[Note] [nvarchar](250) NULL,
	[AttachmentNo] [nvarchar](50) NULL,
	[CreatedUser] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_tblPhieuKho] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WareHouseExportAllocate]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouseExportAllocate](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[WareHoudeIODetailId] [int] NULL,
	[WareHouseDetailId] [int] NULL,
	[Volumn] [int] NULL,
	[Unit] [int] NULL,
	[Version] [int] NULL,
 CONSTRAINT [PK_WareHouseExportAllocate] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WareHouseDetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouseDetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[WareHouseId] [int] NOT NULL,
	[WareHouseIODetailId] [int] NULL,
	[MedicineId] [int] NOT NULL,
	[LotNo] [varchar](20) NULL,
	[ExpiredDate] [datetime] NOT NULL,
	[OriginalVolumn] [int] NULL,
	[CurrentVolumn] [int] NOT NULL,
	[BadVolumn] [int] NULL,
	[Unit] [int] NULL,
	[UnitPrice] [int] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_WareHouseDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WareHouse]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WareHouse](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[Volumn] [int] NULL,
	[MinAllowed] [int] NULL,
	[LastUpdatedUser] [int] NULL,
	[LastUpdatedDate] [datetime] NULL,
	[Version] [int] NULL,
 CONSTRAINT [PK_WareHouse] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PrescriptionDetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PrescriptionDetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[PrescriptionId] [bigint] NOT NULL,
	[FigureDetailId] [int] NULL,
	[MedicineId] [int] NOT NULL,
	[Day] [int] NOT NULL,
	[VolumnPerDay] [int] NOT NULL,
	[Amount] [int] NOT NULL,
	[Description] [nvarchar](200) NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_PrescriptionDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Prescription]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Prescription](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[PatientId] [int] NOT NULL,
	[DoctorId] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[FigureId] [int] NULL,
	[Note] [ntext] NULL,
	[RecheckDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_tblDonThuoc] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PatientFigure]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PatientFigure](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[PatientId] [int] NULL,
	[FigureId] [int] NULL,
	[StartDate] [datetime] NOT NULL,
	[FromDate] [datetime] NULL,
	[Description] [nvarchar](400) NULL,
	[LastUpdatedDate] [datetime] NULL,
 CONSTRAINT [PK_PatientFigure] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Patient]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Patient](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[Code] [varchar](10) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[BirthYear] [int] NULL,
	[Sexual] [char](1) NULL,
	[Phone] [char](15) NULL,
	[Address] [nvarchar](200) NULL,
	[StartDate] [datetime] NULL,
	[Description] [nvarchar](4000) NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_tblBenhNhan] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicineUnitPrice]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicineUnitPrice](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[StartDate] [datetime] NOT NULL,
	[EndDate] [datetime] NULL,
	[UnitPrice] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_MedicineUnitPrice] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicinePlanDetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicinePlanDetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[PlanId] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[InStock] [int] NOT NULL,
	[LastMonthUsage] [int] NOT NULL,
	[CurrentMonthUsage] [int] NULL,
	[Required] [int] NOT NULL,
	[UnitPrice] [int] NULL,
	[Amount] [int] NULL,
	[Version] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_MedicinePlanDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicinePlan]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicinePlan](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[Year] [int] NOT NULL,
	[Month] [int] NOT NULL,
	[Date] [datetime] NOT NULL,
	[Note] [nvarchar](150) NULL,
	[Status] [int] NOT NULL,
	[ApproveId] [int] NULL,
	[ApproveDate] [datetime] NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_MedicinePlan] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicineDeliveryDetailAllocate]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicineDeliveryDetailAllocate](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[MedicineDeliveryDetailId] [bigint] NOT NULL,
	[WareHouseDetailId] [int] NOT NULL,
	[Volumn] [int] NOT NULL,
	[Unit] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_MedicineDeliveryAllocate] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicineDeliveryDetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicineDeliveryDetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[MedicineDeliveryId] [bigint] NOT NULL,
	[PrescriptionDetailId] [bigint] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[Volumn] [int] NOT NULL,
	[Unit] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_MedicineDeliveryDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedicineDelivery]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[MedicineDelivery](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [bigint] NOT NULL,
	[ClinicId] [int] NOT NULL,
	[PatientId] [int] NOT NULL,
	[PrescriptionId] [bigint] NULL,
	[Date] [datetime] NOT NULL,
	[CreatedDate] [datetime] NOT NULL,
	[CreatedUser] [int] NOT NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_MedicineDelivery] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[FigureDetail]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[FigureDetail](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[FigureId] [int] NOT NULL,
	[MedicineId] [int] NOT NULL,
	[Volumn] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_FigureDetail] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Figure]    Script Date: 07/22/2013 20:10:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Figure](
	[ClientID] [varchar](20) NOT NULL,
	[Id] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ClinicId] [int] NULL,
	[Description] [nvarchar](250) NULL,
	[LastUpdatedDate] [datetime] NOT NULL,
	[LastUpdatedUser] [int] NOT NULL,
	[Version] [int] NOT NULL,
 CONSTRAINT [PK_tblPhacDo] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC,
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
