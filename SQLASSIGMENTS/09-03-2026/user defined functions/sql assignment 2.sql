--assignment 5--
CREATE FUNCTION fn_GetDepartmentStudents
(
@DepartmentID INT
)
RETURNS TABLE
AS
RETURN
(
SELECT 
StudentID,
FirstName + ' ' + LastName AS StudentName,
AdmissionDate
FROM Students
WHERE DepartmentID = @DepartmentID
);

--usage--
SELECT * FROM fn_GetDepartmentStudents(2);