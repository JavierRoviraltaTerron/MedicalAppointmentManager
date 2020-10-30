USE [master]
GO

/****** Object:  Database [MedicalAppointmentManager]    Script Date: 30/10/2020 19:34:25 ******/
CREATE DATABASE [MedicalAppointmentManager]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'MedicalAppointmentManager', FILENAME = N'D:\Instalados\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MedicalAppointmentManager.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'MedicalAppointmentManager_log', FILENAME = N'D:\Instalados\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\MedicalAppointmentManager_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [MedicalAppointmentManager].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [MedicalAppointmentManager] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ARITHABORT OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [MedicalAppointmentManager] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [MedicalAppointmentManager] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET  DISABLE_BROKER 
GO

ALTER DATABASE [MedicalAppointmentManager] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [MedicalAppointmentManager] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [MedicalAppointmentManager] SET  MULTI_USER 
GO

ALTER DATABASE [MedicalAppointmentManager] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [MedicalAppointmentManager] SET DB_CHAINING OFF 
GO

ALTER DATABASE [MedicalAppointmentManager] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [MedicalAppointmentManager] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [MedicalAppointmentManager] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [MedicalAppointmentManager] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [MedicalAppointmentManager] SET QUERY_STORE = OFF
GO

ALTER DATABASE [MedicalAppointmentManager] SET  READ_WRITE 
GO

