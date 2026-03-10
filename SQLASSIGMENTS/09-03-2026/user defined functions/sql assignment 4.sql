--assignment 4--
CREATE FUNCTION fn_GetStudentCourses
(
@StudentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
c.CourseName,
e.EnrollmentDate
FROM Enrollments e
JOIN Courses c
ON e.CourseID = c.CourseID
WHERE e.StudentID = @StudentID
);

--usage of function--
SELECT * FROM fn_GetStudentCourses(5);