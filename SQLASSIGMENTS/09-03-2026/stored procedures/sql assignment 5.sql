--assignment 5--
CREATE PROCEDURE sp_UpdateMarks
    @MarkID INT,
    @NewMarks INT
AS
BEGIN
UPDATE Marks
SET MarksObtained = @NewMarks
WHERE MarkID = @MarkID;

SELECT * FROM Marks WHERE MarkID = @MarkID;
END;

--to execute--
EXEC sp_UpdateMarks 2,85;