--assignment 4--
--view creation--
CREATE VIEW vw_DepartmentStudentCount
AS
SELECT 
    d.DepartmentName,
    COUNT(s.StudentID) AS TotalStudents
FROM Departments d
LEFT JOIN Students s
ON d.DepartmentID = s.DepartmentID
GROUP BY d.DepartmentName;

--task 1--
SELECT *
FROM vw_DepartmentStudentCount
WHERE TotalStudents > 10;

--task 2--
SELECT *
FROM vw_DepartmentStudentCount
ORDER BY TotalStudents DESC;