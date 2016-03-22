CREATE DATABASE SST;
GO

USE SST;

CREATE TABLE tblTutor
(
	Id INT NOT NULL IDENTITY (1, 1),
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Email NVARCHAR (50) NOT NULL,
	PhoneNumber NVARCHAR (15) NOT NULL,
	BeginningWorkingDay TIME NOT NULL,
	EndWorkingDay TIME NOT NULL,
	CONSTRAINT CHK_Times CHECK (EndWorkingDay > BeginningWorkingDay),
	CONSTRAINT PK_tblTutor_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblTutor_Email UNIQUE (Email)
);
GO

CREATE TABLE tblLearner
(
	Id INT NOT NULL IDENTITY (1, 1),
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	Email NVARCHAR (50) NOT NULL,
	PhoneNumber NVARCHAR (15) NOT NULL,
	CONSTRAINT PK_tblLearner_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblLearner_Email UNIQUE (Email)
);
GO

CREATE TABLE tblDiscipline
(
	Id INT NOT NULL IDENTITY (1, 1),
	Name NVARCHAR (100) NOT NULL,
	CONSTRAINT PK_tblDiscipline_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblDiscipline_Name UNIQUE (Name)
);
GO

CREATE TABLE tblPrice
(
	Id INT NOT NULL IDENTITY (1, 1),
	TutorId INT NOT NULL,
	DisciplineId INT NOT NULL,
	LessonPrice DECIMAL (18, 4) NOT NULL,
	CONSTRAINT PK_tblPrice_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblPrice_tblPrice_tblTutor_Id FOREIGN KEY (TutorId) REFERENCES tblTutor (Id),
	CONSTRAINT FK_tblPrice_DisciplineId_tblDiscipline_Id FOREIGN KEY (DisciplineId) REFERENCES tblDiscipline (Id),
	CONSTRAINT CHK_LessonPrice CHECK (LessonPrice > 0)
);
GO

create table tblUser
(
	Id INT NOT NULL IDENTITY (1,1),
	FirstName NVARCHAR (50) NOT NULL,
	LastName NVARCHAR (50) NOT NULL,
	[Login] VARCHAR (50) NOT NULL,
	[Password] VARCHAR (50) NOT NULL,
	[Disabled] BIT NOT NULL,
	CONSTRAINT PK_tblUser_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblUser_Login UNIQUE ([Login])
);
GO

CREATE TABLE tblStatus
(
	Id INT NOT NULL IDENTITY (1, 1),
	[Status] NVARCHAR (100) NOT NULL,
	CONSTRAINT PK_tblStatus_Id PRIMARY KEY (Id),
	CONSTRAINT UQ_tblStatus_Status UNIQUE ([Status])
);
GO

CREATE TABLE tblLesson
(
	Id INT IDENTITY (1, 1) NOT NULL,
	TutorId INT NOT NULL,
	LearnerId INT NOT NULL,
	DisciplineId INT NOT NULL,
	LessonTime DATETIME NOT NULL,
	Price DECIMAL (18, 4) NOT NULL,
	Paid BIT NOT NULL,
	StatusId INT NOT NULL,
	UserId INT NOT NULL,
	CONSTRAINT PK_tblLesson_Id PRIMARY KEY (Id),
	CONSTRAINT FK_tblLesson_TutorId_tblTutor_Id FOREIGN KEY (TutorId) REFERENCES tblTutor (Id),
	CONSTRAINT FK_tblLesson_LearnerId_tblLearner_Id FOREIGN KEY (LearnerId) REFERENCES tblLearner (Id),
	CONSTRAINT FK_tblLesson_DisciplineId_tblDiscipline_Id FOREIGN KEY (DisciplineId) REFERENCES tblDiscipline (Id),
	CONSTRAINT FK_tblLesson_UserId_tblUser_Id FOREIGN KEY (UserId) REFERENCES tblUser (Id),
	CONSTRAINT FK_tblLesson_StatusId_tblStatus_Id FOREIGN KEY (StatusId) REFERENCES tblStatus (Id)
);
GO