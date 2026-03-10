--assignment 3--
CREATE PROCEDURE sp_EnrollStudent
    @StudentID INT,
    @CourseID INT
AS
BEGIN
INSERT INTO Enrollments(StudentID, CourseID, EnrollmentDate)
VALUES (@StudentID, @CourseID, GETDATE());
END;

--to execute--
EXEC sp_EnrollStudent 5,3;