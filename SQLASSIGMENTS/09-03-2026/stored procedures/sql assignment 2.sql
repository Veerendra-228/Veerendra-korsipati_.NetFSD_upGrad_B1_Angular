--assignment 2 --
CREATE PROCEDURE sp_GetStudentsByDepartment
    @DepartmentID INT
AS
BEGIN
SELECT 
    StudentID,
    FirstName + ' ' + LastName AS StudentName,
    AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID;
END;

--to execute--
EXEC sp_GetStudentsByDepartment 2;

EXEC sp_GetStudentsByDepartment 3;