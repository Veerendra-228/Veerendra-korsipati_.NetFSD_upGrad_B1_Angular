--assignment 6--
CREATE PROCEDURE sp_DeleteEnrollment
    @EnrollmentID INT
AS
BEGIN
DELETE FROM Enrollments
WHERE EnrollmentID = @EnrollmentID;
END;

--to execute--
EXEC sp_DeleteEnrollment 4;