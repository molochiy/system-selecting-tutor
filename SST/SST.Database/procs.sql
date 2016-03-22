USE SST;
GO

CREATE PROC spGetUserByLogin
	@Login VARCHAR(50),
	@Password VARCHAR(50)

AS

BEGIN

	SELECT 
		Id, 
		FirstName, 
		LastName, 
		[Login], 		
		[Disabled] 
	FROM tblUser
	WHERE [Login] = @Login and [Password] = @Password and [Disabled] <> 1;

END;
GO

CREATE PROC spGetLearnersByPartOfEmail
	@Email VARCHAR(50)

AS

BEGIN

	SELECT 
		Id,
		FirstName,
		LastName,
		Email,
		PhoneNumber
	FROM tblLearner
	WHERE Email LIKE '%'+@Email+'%';

END;
GO

CREATE PROC spGetLearnerByEmail
	@Email VARCHAR(50)

AS

BEGIN

	SELECT 
		Id,
		FirstName,
		LastName,
		Email,
		PhoneNumber
	FROM tblLearner
	WHERE Email = @Email;

END;
GO

CREATE PROC spGetLessonsByLearnerId
	@LearnerId INT

AS

BEGIN

	SELECT ls.Id, t.FirstName AS 'TutorFirstName', t.LastName AS 'TutorLastName', d.Name AS 'Discipline', ls.LessonTime, ls.Price, ls.Paid, s.[Status]
	FROM
			(
					(
						(	
							tblLesson ls JOIN tblLearner ln
							ON ls.LearnerId = ln.Id
						)
						join tblTutor t
						ON ls.TutorId = t.Id
					)
					join
					tblDiscipline d
					ON ls.DisciplineId = d.Id
			)

		join tblStatus s
		ON ls.StatusId = s.Id
	WHERE ls.LearnerId = @LearnerId AND ls.LessonTime >= GETDATE()
	ORDER BY ls.LessonTime
END;
GO

CREATE PROC spUpdateLessonStatus
	@Id INT,
	@Status INT

AS

BEGIN
	UPDATE tblLesson
	SET StatusId = @Status
	WHERE Id = @Id;
END;
GO

CREATE PROC spUpdateLessonPaid
	@Id INT	

AS

BEGIN
	UPDATE tblLesson
	SET Paid = 1
	WHERE Id = @Id;
END;
GO

CREATE PROC spSelectAllTutorsWithDisciplinesAndPrices

AS

BEGIN
	SELECT t.Id, t.FirstName, t.LastName, t.BeginningWorkingDay, t.EndWorkingDay, d.Name, p.LessonPrice
	FROM
	(
		tblPrice p JOIN tblTutor t
		ON p.TutorId = t.Id
	)
	JOIN tblDiscipline d
	ON p.DisciplineId = d.Id
END;
GO

CREATE PROC spGetAllDesciplines

AS

BEGIN
	SELECT Id, Name
	FROM tblDiscipline
END;
GO

CREATE PROC spGetLessonsDateTimesByTutorId
	@Id int

AS

BEGIN
	SELECT ls.LessonTime, t.BeginningWorkingDay, t.EndWorkingDay
	FROM tblLesson ls JOIN tblTutor t ON ls.TutorId = t.Id
	WHERE TutorId = @Id AND LessonTime >= GETDATE() AND StatusId = 0;
END;
GO

CREATE PROC spGetTutorsByPartOfEmail
	@Email VARCHAR(50)

AS

BEGIN

	SELECT 
		Id,
		FirstName,
		LastName,
		Email,
		PhoneNumber,
		BeginningWorkingDay,
		EndWorkingDay
	FROM tblTutor
	WHERE Email LIKE '%'+@Email+'%';

END;
GO

CREATE PROC spGetDisciplinesByTutorId
	@TutorId INT

AS

BEGIN

	SELECT p.TutorId, p.DisciplineId, d.Name, p.LessonPrice
	FROM 
		(
			tblPrice p 
			JOIN 
			tblTutor t 
			ON p.TutorId = t.Id
		) 
		JOIN 
		tblDiscipline d 
		ON p.DisciplineId = d.Id
	WHERE t.Id = @TutorId;

END;
GO

CREATE PROC spGetTutorByEmail
	@Email VARCHAR(50)

AS

BEGIN

	SELECT 
		Id,
		FirstName,
		LastName,
		Email,
		PhoneNumber,
		BeginningWorkingDay,
		EndWorkingDay
	FROM tblTutor
	WHERE Email = @Email;

END;
GO

CREATE PROC spGetTutorById
	@Id INT

AS

BEGIN

	SELECT 
		Id,
		FirstName,
		LastName,
		Email,
		PhoneNumber,
		BeginningWorkingDay,
		EndWorkingDay
	FROM tblTutor
	WHERE Id = @Id;

END;
GO

CREATE PROC spInsertLearner
	@FirstName NVARCHAR (50),
	@LastName NVARCHAR (50),
	@Email NVARCHAR (50),
	@PhoneNumber NVARCHAR (15),
	@Id INT OUT
AS

BEGIN

	BEGIN TRY
		INSERT INTO tblLearner(FirstName, LastName, Email, PhoneNumber)
		VALUES (@FirstName, @LastName, @Email, @PhoneNumber);

		SET @Id = @@IDENTITY;
	END TRY
	BEGIN CATCH    
		THROW 52000, 'Learner with this email already registered', 1;
	END CATCH;
END;
GO

CREATE PROC spInsertTutor
	@FirstName NVARCHAR (50),
	@LastName NVARCHAR (50),
	@Email NVARCHAR (50),
	@PhoneNumber NVARCHAR (15),
	@BeginningWorkingDay TIME,
	@EndWorkingDay TIME,
	@Id INT OUT
AS

BEGIN
	BEGIN TRY
		INSERT INTO tblTutor(FirstName, LastName, Email, PhoneNumber, BeginningWorkingDay, EndWorkingDay)
		VALUES (@FirstName, @LastName, @Email, @PhoneNumber, @BeginningWorkingDay, @EndWorkingDay);

		SET @Id = @@IDENTITY;
	END TRY
	BEGIN CATCH    
		THROW 51000, 'Tutor with this email already registered', 1;
	END CATCH;
END;
GO

CREATE PROC spGetDisciplineIdByName
	@Name NVARCHAR (100)

AS

BEGIN
	SELECT Id 
	FROM tblDiscipline
	WHERE Name = @Name;
END;
GO

CREATE PROC spGetPriceByTutorIdANDDisciplineId
	@TutorId INT,
	@DisciplineId INT

AS

BEGIN
	SELECT LessonPrice
	FROM tblPrice
	WHERE TutorId = @TutorId AND DisciplineId = @DisciplineId;
END;
GO

CREATE PROC spInsertLessons
	@TutorId INT,
	@LearnerId INT,
	@DisciplineId INT,
	@LessonTime DATETIME,
	@Price DECIMAL (18, 4),
	@Paid BIT,
	@StatusId INT,
	@UserId INT

AS

BEGIN
	BEGIN TRY
		INSERT INTO tblLesson(TutorId, LearnerId, DisciplineId, LessonTime, Price, Paid, StatusId, UserId)
		VALUES (@TutorId, @LearnerId, @DisciplineId, @LessonTime, @Price, @Paid, @StatusId, @UserId);
	END TRY
	BEGIN CATCH    
		THROW;
	END CATCH;
END;
GO
