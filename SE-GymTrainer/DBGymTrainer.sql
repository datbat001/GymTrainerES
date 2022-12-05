use [GymTrainer]
GO

CREATE TABLE [dbo].[ejercicios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [varchar](100) NOT NULL,
	[Body_Part] [varchar](100) NOT NULL,
	[Ejercicio] [varchar](max) NOT NULL,
	[Serie] [int] NOT NULL,
	[Repeticion] [int] NOT NULL,
	PRIMARY KEY (Id)
);
GO

CREATE TABLE [dbo].[user](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Tipo] [int] NOT NULL,
	[Photo] [varbinary](max) NULL,
	[nick] [varchar](50) NOT NULL,
	[password] [varchar](20) NOT NULL,
	[email] [varchar](max) NOT NULL,
	[peso] [int] NOT NULL,
	[altura] [int] NOT NULL,
	[active] [bit] NULL,
	PRIMARY KEY (Id)
);
GO