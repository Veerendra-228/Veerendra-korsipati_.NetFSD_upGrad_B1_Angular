--assignment 4--
CREATE PROCEDURE sp_GetStudentMarks
    @StudentID INT
AS
BEGIN
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.ExamType,
    m.MarksObtained
FROM Marks m
JOIN Students s ON m.StudentID = s.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID
WHERE s.StudentID = @StudentID;
END;

--to execute--

EXEC sp_GetStudentMarks 5;