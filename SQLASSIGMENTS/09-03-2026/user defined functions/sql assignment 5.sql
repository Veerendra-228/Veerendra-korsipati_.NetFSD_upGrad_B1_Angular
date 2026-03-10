--assignment 2--
CREATE FUNCTION fn_GetStudentAge
(
@DateOfBirth DATE
)
RETURNS INT
AS
BEGIN
RETURN DATEDIFF(YEAR, @DateOfBirth, GETDATE())
END;

--usage of function--

SELECT 
StudentID,
DateOfBirth,
dbo.fn_GetStudentAge(DateOfBirth) AS Age
FROM Students;