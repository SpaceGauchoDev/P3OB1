CREATE DATABASE P2P_LENDING_DB
GO 
USE P2P_LENDING_DB
GO
CREATE TABLE 	Configuraciones(	IdConfig int identity(1,1) not null,
									MinEdad int not null,
									MinMonto int not null,
									MaxMonto int not null,
									MinCuotas int not null,
									MaxCuotas int not null,
									PenalizacionPorIndividual numeric(10,4) not null,
									BonoPorIntegrante numeric(10,4) not null,
									MaxBonoTotal numeric(10,4) not null,
									FechaDeActualizacion date)
GO
CREATE TABLE InteresPorCuotas	(	Cuotas int not null,
									PorcentajeDeInteres numeric(10,4) not null,
									IdConfig int)
GO
CREATE TABLE 	Usuario(	CI int not null,
							Pass varchar(30) not null, 
							Rol char (1) not null,
							Nombre varchar (30) not null,
							Apellido varchar (50) not null,
							FechaDeNacimiento date not null,
							Email varchar (50) not null,
							Celular varchar(15))
GO
CREATE TABLE 	Proyecto(	IdProyecto int identity(1,1) not null,
							Etapa char (1) not null,
							TipoDeEquipo char (1) not null,
							Titulo varchar (140) not null,
							Descripcion varchar (2000) not null,
							ImgURL varchar (60),
							CantidadDeIntegrantes int,
							ExperienciaIndividual varchar (2000),
							FechaDePresentacion date not null,
							CISolicitante int)
GO 
CREATE TABLE	Financiacion(	IdFinanciacion int identity(1,1) not null,
								Cuotas int not null,
								PrecioPorCuota numeric(10,2) not null, 
								MontoSolicitado numeric(10,2) not null,
								PorcentajeDeInteres numeric(10,4) not null,
								IdProyecto int, 
								IdConfig int)
GO
CREATE TABLE	Evaluacion(	IdEvaluacion int identity(1,1) not null,
							FueEvaluado char (1) not null,
							PuntajeDeEvaluacion int,
							FechaDeEvaluacion date,
							IdProyecto int not null,
							CIAdmin int)
GO																		
ALTER TABLE Configuraciones ADD CONSTRAINT PK_Configuraciones Primary Key (IdConfig)
GO
ALTER TABLE InteresPorCuotas ADD CONSTRAINT FK_Co_In_IdConfig Foreign Key (IdConfig) References Configuraciones (IdConfig)
GO
ALTER TABLE Usuario ADD CONSTRAINT PK_Usuario Primary Key (CI)
ALTER TABLE Usuario ADD CONSTRAINT CK_Rol CHECK (Rol IN ('S', 'A'))
GO
ALTER TABLE Proyecto ADD CONSTRAINT PK_Proyecto Primary Key (IdProyecto)
ALTER TABLE Proyecto ADD CONSTRAINT FK_Us_Pr_CI Foreign Key (CISolicitante) References Usuario (CI)
ALTER TABLE Proyecto ADD CONSTRAINT CK_Etapa CHECK (Etapa IN ('P', 'A', 'R'))
ALTER TABLE Proyecto ADD CONSTRAINT CK_TipoDeEquipo CHECK (TipoDeEquipo IN ('I', 'C'))
GO
ALTER TABLE Financiacion ADD CONSTRAINT PK_Financiacion Primary Key (IdFinanciacion)
ALTER TABLE Financiacion ADD CONSTRAINT FK_Pr_Fi_IdProyecto Foreign Key (IdProyecto) References Proyecto (IdProyecto)
ALTER TABLE Financiacion ADD CONSTRAINT FK_Co_Fi_IdConfig Foreign Key (IdConfig) References Configuraciones (IdConfig)
GO
ALTER TABLE Evaluacion ADD CONSTRAINT PK_Evaluacion Primary Key (IdEvaluacion)
ALTER TABLE Evaluacion ADD CONSTRAINT FK_Pr_Ev_IdProyecto Foreign Key (IdProyecto) References Proyecto (IdProyecto)
ALTER TABLE Evaluacion ADD CONSTRAINT FK_Us_Ev_CI Foreign Key (CIAdmin) References Usuario (CI)
ALTER TABLE Evaluacion ADD CONSTRAINT CK_FueEvaluado CHECK (FueEvaluado IN ('T', 'F'))
GO
