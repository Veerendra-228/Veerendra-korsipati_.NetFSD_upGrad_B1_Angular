--assignment 1---
CREATE PROCEDURE sp_InsertStudent
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50),
    @Gender VARCHAR(10),
    @DepartmentID INT,
    @AdmissionDate DATE
AS
BEGIN
INSERT INTO Students (FirstName, LastName, Gender, DepartmentID, AdmissionDate)
VALUES (@FirstName, @LastName, @Gender, @DepartmentID, @AdmissionDate);
END;

--to execute--
EXEC sp_InsertStudent 'John','David','Male',2,'2024-06-01';

--to verify--
select * from Students