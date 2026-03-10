--task 1---
CREATE VIEW vw_StudentDepartment
AS
SELECT 
    s.StudentID,
    s.FirstName + ' ' + s.LastName AS StudentName,
    d.DepartmentName,
    s.AdmissionDate
FROM Students s
JOIN Departments d
ON s.DepartmentID = d.DepartmentID;

--task 2---
SELECT * FROM vw_StudentDepartment;

--task 3---
SELECT *
FROM vw_StudentDepartment
WHERE DepartmentName = 'Computer Science';

---task 4---
DROP VIEW vw_StudentDepartment;