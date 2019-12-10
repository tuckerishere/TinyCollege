USE master;

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;
CREATE DATABASE TinyCollegeDB;
GO

USE TinyCollegeDB
GO
CREATE TABLE student
(
	studentId INT NOT NULL IDENTITY (1001,1),
	studentName NVARCHAR(150) NOT NULL,
	CONSTRAINT pk_student PRIMARY KEY(studentId),

);

CREATE TABLE course
(
	courseId INT NOT NULL IDENTITY(1,1),
	courseName VARCHAR (50) NOT NULL,
	courseSemester VARCHAR(10) NOT NULL,

	CONSTRAINT pk_course PRIMARY KEY(courseId),

);

CREATE TABLE enrollment
(
	studentId INT NOT NULL,
	courseId INT NOT NULL,
	CONSTRAINT fk_studentId FOREIGN KEY (studentId)
		REFERENCES student(studentId),
	CONSTRAINT fk_courseId FOREIGN KEY (courseId)
		REFERENCES course(courseId),
	CONSTRAINT pk_enroll PRIMARY KEY(studentId,courseId)

	);
