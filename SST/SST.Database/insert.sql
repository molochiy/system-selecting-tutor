USE SST;
GO

SET IDENTITY_INSERT tblUser ON;
INSERT INTO tblUser(Id, FirstName, LastName, [Login], [Password], [Disabled]) VALUES
(1, 'Taras', 'Tarasenko', 'tarasenko', 'e3f07c1c3cdd70f36aa4f7e5355102e6', 0), --password: tarasenko
(2,	'Stepan', 'Stepanenko', 'stepanenko', '800cc65d5960ae2a02981d7a52219200', 0), --password: stepanenko
(3,	'Iryna', 'Kolisnychenko', 'kolisnychenko', '608d4111ac371bec86d26e60d7a37c33', 0); --password: kolisnychenko
SET IDENTITY_INSERT tblUser OFF;

SET IDENTITY_INSERT tblTutor ON;
INSERT INTO tblTutor(Id, FirstName, LastName, Email, PhoneNumber, BeginningWorkingDay, EndWorkingDay) VALUES 
	(1, 'Vasyl', 'Vasylenko', 'vasylenko@gmail.com', '+380111111111', '11:00:00', '17:00:00'),
	(2, 'Petro', 'Petrenko', 'petrenko@gmail.com', '+380222222222', '07:00:00', '11:00:00'),
	(3, 'Maria', 'Ivanenko', 'ivanenko@gmail.com', '+380333333333', '12:00:00', '20:00:00'),
	(4, 'Nadia', 'Pavlenko', 'pavlenko@gmail.com', '+380444444444', '09:00:00', '13:00:00');
SET IDENTITY_INSERT tblTutor OFF;
GO

SET IDENTITY_INSERT tblDiscipline ON;
INSERT INTO tblDiscipline(Id, Name) VALUES
	(1, 'Math'),
	(2, 'Physics'),
	(3, 'Ukrainian language'),
	(4, 'English'),
	(5, 'Chemistry');
SET IDENTITY_INSERT tblDiscipline OFF;
GO

SET IDENTITY_INSERT tblPrice ON;
INSERT INTO tblPrice(Id, TutorId, DisciplineId, LessonPrice) VALUES
	(1, 1, 1, 120),
	(2, 1, 2, 150),
	(3, 2, 2, 130),
	(4, 2, 5, 140),
	(5, 3, 3, 90),
	(6, 3, 4, 150),
	(7, 4, 3, 100);
SET IDENTITY_INSERT tblPrice OFF;
GO

SET IDENTITY_INSERT tblLearner ON;
INSERT INTO tblLearner(Id, FirstName, LastName, Email, PhoneNumber) VALUES
	(1, 'Iryna', 'Bereza', 'bereza@gmail.com', '+380555555555'),
	(2, 'Ostap', 'Ivaniv', 'ivaniv@gmail.com', '+380666666666'),
	(3, 'Igor', 'Kopylets', 'kopylets@gmail.com', '+380777777777'),
	(4, 'Kateryna', 'Sych', 'sych@gmail.com', '+380888888888'),
	(5, 'Olga', 'Savych', 'savych@gmail.com', '+380999999999');
SET IDENTITY_INSERT tblLearner OFF;
GO

SET IDENTITY_INSERT tblStatus ON;
INSERT INTO tblStatus(Id, [Status]) VALUES
	(0, 'Default'),
	(1, 'Occured'),
	(2, 'Canceled');
SET IDENTITY_INSERT tblStatus OFF;
GO

SET IDENTITY_INSERT tblLesson ON;
INSERT INTO tblLesson(Id, TutorId, LearnerId, DisciplineId, LessonTime, Price, Paid, StatusId, UserId) VALUES
	(1, 1, 1, 1, '03.22.16 11:00:00', 120, 0, 0, 1),
	(2, 1, 1, 1, '03.24.16 13:00:00', 120,0, 0, 1),
	(3, 1, 1, 1, '03.29.16 11:00:00', 120,0, 0, 1),
	(4, 1, 1, 1, '03.31.16 13:00:00', 120,0, 0, 1),
	
	(5, 2, 1, 5, '03.22.16 10:00:00', 140, 0, 0, 1),
	(6, 2, 1, 5, '03.23.16 09:00:00', 140, 0, 0, 1),
	(7, 2, 1, 5, '03.29.16 10:00:00', 140, 0, 0, 1),
	(8, 2, 1, 5, '03.30.16 09:00:00', 140, 0, 0, 1),
	
	(9, 1, 2, 2, '03.22.16 12:00:00', 150, 0, 0, 2),
	(10, 1, 2, 2, '03.24.16 11:00:00', 150, 0, 0, 2),
	(11, 1, 2, 2, '03.29.16 12:00:00', 150, 0, 0, 2),
	(12, 1, 2, 2, '03.31.16 11:00:00', 150, 0, 0, 2),

	(13, 4, 2, 3, '03.21.16 12:00:00', 100, 0, 0, 2),
	(14, 4, 2, 3, '03.25.16 11:00:00', 100, 0, 0, 2),
	(15, 4, 2, 3, '03.28.16 12:00:00', 100, 0, 0, 2),
	(16, 4, 2, 3, '04.01.16 11:00:00', 100, 0, 0, 2),

	(17, 1, 3, 1, '03.21.16 14:00:00', 120, 0, 0, 3),
	(18, 1, 3, 1, '03.25.16 15:00:00', 120, 0, 0, 3),
	(19, 1, 3, 1, '03.28.16 14:00:00', 120, 0, 0, 3),
	(20, 1, 3, 1, '04.01.16 15:00:00', 120, 0, 0, 3),
		
	(21, 2, 3, 5, '03.23.16 10:00:00', 140, 0, 0, 3),
	(22, 2, 3, 5, '03.25.16 09:00:00', 140, 0, 0, 3),
	(23, 2, 3, 5, '03.30.16 10:00:00', 140, 0, 0, 3),
	(24, 2, 3, 5, '04.01.16 09:00:00', 140, 0, 0, 3),

	(25, 3, 4, 3, '03.21.16 13:00:00', 90, 0, 0, 1),
	(26, 3, 4, 3, '03.25.16 16:00:00', 90, 0, 0, 1),
	(27, 3, 4, 3, '03.28.16 13:00:00', 90, 0, 0, 1),
	(28, 3, 4, 3, '04.01.16 16:00:00', 90, 0, 0, 1),

	(29, 3, 4, 4, '03.22.16 15:00:00', 150, 0, 0, 1),	
	(30, 3, 4, 4, '03.29.16 15:00:00', 150, 0, 0, 1),	

	(31, 3, 5, 4, '03.21.16 14:00:00', 150, 0, 0, 2),
	(32, 3, 5, 4, '03.25.16 18:00:00', 150, 0, 0, 2),
	(33, 3, 5, 4, '03.28.16 14:00:00', 150, 0, 0, 2),
	(34, 3, 5, 4, '04.01.16 18:00:00', 150, 0, 0, 2),

	(35, 1, 5, 2, '03.21.16 13:00:00', 150, 0, 0, 3),
	(36, 1, 5, 2, '03.28.16 13:00:00', 150, 0, 0, 3);
	
SET IDENTITY_INSERT tblLesson OFF;
GO