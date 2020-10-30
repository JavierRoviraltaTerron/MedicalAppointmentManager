USE [master]
GO

/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [mamapi]    Script Date: 30/10/2020 20:29:00 ******/
CREATE LOGIN [mamapi] WITH PASSWORD=N'4wgapc28tW/6qcn6wHiSDBQ6IEyFJTj+ORCheP7m9YQ=', DEFAULT_DATABASE=[MedicalAppointmentManager], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO

ALTER LOGIN [mamapi] DISABLE
GO


