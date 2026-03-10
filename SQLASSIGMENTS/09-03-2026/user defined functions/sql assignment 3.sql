--assignment 3
CREATE FUNCTION fn_GetTotalMarks
(
@StudentID INT
)
RETURNS INT
AS
BEGIN
DECLARE @Total INT

SELECT @Total = SUM(MarksObtained)
FROM Marks
WHERE StudentID = @StudentID

RETURN @Total
END;

--usage of function--
SELECT 
StudentID,
dbo.fn_GetTotalMarks(StudentID) AS TotalMarks
FROM Students;