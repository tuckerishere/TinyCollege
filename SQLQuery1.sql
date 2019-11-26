USE master;

IF DB_ID(N'TinyCollegeDB') IS NOT NULL DROP DATABASE TinyCollegeDB;
CREATE DATABASE TinyCollegeDB;
GO

USE TinyCollegeDB
GO
CREATE TABLE student
(
	studentId INT NOT NULL IDENTITY,
	studentName NVARCHAR(150) NOT NULL,
	CONSTRAINT pk_student PRIMARY KEY(studentId),

);

CREATE TABLE course
(
	courseId INT NOT NULL IDENTITY,
	courseName VARCHAR (50) NOT NULL,
	courseSemester VARCHAR(10) NOT NULL,
	studentId INT NOT NULL,
	CONSTRAINT pk_course PRIMARY KEY(courseId),
	CONSTRAINT fk_student FOREIGN KEY(studentId)
		REFERENCES student(studentID)
);

CREATE TABLE enrollment
(
	studentId INT NOT NULL IDENTITY,
	courseId INT NOT NULL
	CONSTRAINT pk_enrolledStudent PRIMARY KEY(studentId)
		REFERENCES student(studentID),
	CONSTRAINT fk_enrolledCourse FOREIGN KEY(courseId)
		REFERENCES course(courseId)
);