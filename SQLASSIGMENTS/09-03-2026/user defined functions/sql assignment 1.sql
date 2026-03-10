--assignment 1--
CREATE FUNCTION fn_GetGrade
(
    @MarksObtained INT
)
RETURNS VARCHAR(10)
AS
BEGIN
DECLARE @Grade VARCHAR(10)

IF @MarksObtained >= 90
SET @Grade = 'A'
ELSE IF @MarksObtained >= 75
SET @Grade = 'B'
ELSE IF @MarksObtained >= 60
SET @Grade = 'C'
ELSE
SET @Grade = 'Fail'

RETURN @Grade
END;

--usage of funtion--
SELECT 
StudentID,
MarksObtained,
dbo.fn_GetGrade(MarksObtained) AS Grade
FROM Marks;