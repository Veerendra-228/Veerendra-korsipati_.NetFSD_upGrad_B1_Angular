--assignment 3--
--view creation--
CREATE VIEW vw_ExamResults
AS
SELECT 
    s.FirstName + ' ' + s.LastName AS StudentName,
    c.CourseName,
    e.ExamType,
    m.MarksObtained
FROM Marks m
JOIN Students s ON m.StudentID = s.StudentID
JOIN Exams e ON m.ExamID = e.ExamID
JOIN Courses c ON e.CourseID = c.CourseID;
--task-1--
SELECT *
FROM vw_ExamResults
WHERE MarksObtained > 80;
--task 2--
SELECT *
FROM vw_ExamResults
WHERE MarksObtained = 
(
    SELECT MAX(MarksObtained)
    FROM vw_ExamResults
);
--task 3---
SELECT *
FROM vw_ExamResults
WHERE MarksObtained < 40;

