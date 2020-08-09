CREATE DATABASE Nedeljni_I
 IF DB_ID('Nedeljni_I') IS NULL
CREATE DATABASE Nedeljni_I;
GO
USE Nedeljni_I;

if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblProject')
drop table tblProject;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblEmployee')
drop table tblEmployee;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblManager')
drop table tblManagers;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblAdministartor')
drop table tblAdministrator;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblUser')
drop table tblUser;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblPosition')
drop table tblPosition;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'tblSector')
drop table tblSector;
if exists (SELECT name FROM sys.sysobjects WHERE name = 'vwReports')
drop view vwReports;


Create table tblPosition(
PositionID int identity(1,1) PRIMARY KEY,
PositionName varchar(100) UNIQUE NOT NULL,
PositionDescription varchar(255) NOT NULL
);

Create table tblSector (
	SectorID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	SectorName VARCHAR (40) UNIQUE 				NOT NULL,
	SectorDescription VARCHAR (40)
);

  
Create table tblUser(
	UserID INT IDENTITY(1,1) PRIMARY KEY 	NOT NULL,
	FirstName VARCHAR (40)					NOT NULL,
	Surname VARCHAR (40)					NOT NULL,
	JMBG VARCHAR (13) UNIQUE				NOT NULL,
	Gender CHAR								NOT NULL,
	Residence VARCHAR (40)					NOT NULL,
	MarriageStatus VARCHAR (13)				NOT NULL,
	Username VARCHAR (40) UNIQUE			NOT NULL,
	Pasword VARCHAR (40)				NOT NULL,
);

Create table tblEmployee (
	EmployeeID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	YearsOfService INT DEFAULT 0				NOT NULL,
	Salary VARCHAR (40),
	EducationDegree VARCHAR (3)					NOT NULL,
	UserID INT ,
	SectorID INT,
	PositionID INT,
);

Create table tblManager (
	ManagerID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	Email VARCHAR (40)							NOT NULL,
	ReservedPassword VARCHAR (40)				NOT NULL,
	LevelOfResponsibility	CHAR,
	SuccessfulProjects INT DEFAULT 0,
	Salary VARCHAR (40),
	OfficeNumber VARCHAR (20),
	UserID INT ,
);

Create table tblAdministrator (
	AdministratorID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	ExpirationDate DATE							NOT NULL,
	AdministratorType VARCHAR (40)						NOT NULL,
	UserID INT,
);

Create table tblProject (
	ProjectID INT IDENTITY(1,1) PRIMARY KEY		NOT NULL,
	ProjectName VARCHAR (40)					NOT NULL,
	ProjectDescription VARCHAR (40),
	ClientName VARCHAR (60)						NOT NULL,
	ContractDate DATE							NOT NULL,
	ContractManager  VARCHAR (60)				NOT NULL,
	ProjectStartDate DATE						NOT NULL,
	ProjectDeadline DATE						NOT NULL,
	HourlyRate INT								NOT NULL,
	Realisation CHAR DEFAULT 0					NOT NULL,
	ManagerID INT ,
);



ALTER TABLE tblEmployee
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblEmployee
ADD FOREIGN KEY (SectorID) REFERENCES tblSector(SectorID);
ALTER TABLE tblEmployee
ADD FOREIGN KEY (PositionID) REFERENCES tblPosition(PositionID);
ALTER TABLE tblManager
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblAdministrator
ADD FOREIGN KEY (UserID) REFERENCES tblUser(UserID);
ALTER TABLE tblProject
ADD FOREIGN KEY (ManagerID) REFERENCES tblManager(ManagerID);

GO
CREATE VIEW vwEmployee AS
	SELECT	tblUser.*, 
			tblEmployee.YearsOfService, tblEmployee.Salary, tblEmployee.EducationDegree, tblEmployee.SectorID, 
			tblEmployee.PositionID, tblEmployee.EmployeeID 
	FROM	tblUser, tblEmployee
	WHERE	tblUser.UserID = tblEmployee.UserID

GO
CREATE VIEW vwManager AS
	SELECT	tblUser.*, 
			tblManager.Email, tblManager.ReservedPassword, tblManager.Salary, tblManager.LevelOfResponsibility, 
			tblManager.SuccessfulProjects, tblManager.OfficeNumber, tblManager.ManagerID
	FROM	tblUser, tblManager 
	WHERE	tblUser.UserID = tblManager.UserID

GO
CREATE VIEW vwAdministrator AS
	SELECT	tblUser.*, tblAdministrator.ExpirationDate, tblAdministrator.AdministratorType, tblAdministrator.AdministratorID
	FROM	tblUser, tblAdministrator
	WHERE	tblUser.UserID = tblAdministrator.UserID

