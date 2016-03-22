USE SST;
GO

DROP PROC spGetAllDesciplines;
GO

DROP PROC spGetDisciplineIdByName;
GO

DROP PROC spGetDisciplinesByTutorId;
GO

DROP PROC spGetLearnerByEmail;
GO

DROP PROC spGetLearnersByPartOfEmail;
GO

DROP PROC spGetLessonsByLearnerId;
GO

DROP PROC spGetLessonsDateTimesByTutorId;
GO

DROP PROC spGetPriceByTutorIdANDDisciplineId;
GO

DROP PROC spGetTutorByEmail;
GO

DROP PROC spGetTutorById;
GO

DROP PROC spGetTutorsByPartOfEmail;
GO

DROP PROC spGetUserByLogin;
GO

DROP PROC spInsertLearner;
GO

DROP PROC spInsertLessons;
GO

DROP PROC spInsertTutor;
GO

DROP PROC spSelectAllTutorsWithDisciplinesAndPrices;
GO

DROP PROC spUpdateLessonPaid;
GO

DROP PROC spUpdateLessonStatus;
GO

DROP TABLE tblLesson;
GO

DROP TABLE tblPrice;
GO

DROP TABLE tblDiscipline;
GO

DROP TABLE tblLearner;
GO

DROP TABLE tblTutor;
GO

DROP TABLE tblUser;
GO