--assignment 2--
--view creation--
CREATE VIEW vw_StudentCourses
AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.EnrollmentDate
FROM Students s
JOIN Enrollments e
ON s.StudentID = e.StudentID
JOIN Courses c
ON e.CourseID = c.CourseID;

--task 1--
SELECT *
FROM vw_StudentCourses
WHERE StudentName IN
(
    SELECT FirstName + ' ' + LastName
    FROM Students
    WHERE StudentID = 5
);

--task 2--
SELECT StudentName, COUNT(CourseName) AS TotalCourses
FROM vw_StudentCourses
GROUP BY StudentName;

--task 3--
SELECT *
FROM vw_StudentCourses
WHERE EnrollmentDate > '2024-12-31';