SELECT student.studentId,student.studentName, course.courseName
FROM student JOIN enrollment
	ON student.studentId = enrollment.studentId
	JOIN course on enrollment.courseId = course.courseId
WHERE student.studentId = 1001