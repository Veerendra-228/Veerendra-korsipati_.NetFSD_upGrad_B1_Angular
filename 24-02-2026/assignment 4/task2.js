let students = [
  { name: "Akhil", marks: 85 },
  { name: "Priya", marks: 72 },
  { name: "Ravi", marks: 90 },
  { name: "Meena", marks: 45 },
  { name: "Karan", marks: 30 }
];

console.log("===== Assignment 2 =====");
let passedStudents = students.filter(student => student.marks >= 40);
console.log("Passed Students:", passedStudents);
let distinctionStudents = students.filter(student => student.marks >= 85);
console.log("Distinction Students:", distinctionStudents);
let classAverage = 
  students.reduce((total, student) => total + student.marks, 0) 
  / students.length;
console.log("Class Average:", classAverage);
let topper = [...students].sort((a, b) => b.marks - a.marks)[0];
console.log("Topper:", topper);
let failedCount = students.filter(student => student.marks < 40).length;
console.log("Failed Students Count:", failedCount);
let gradedStudents = students.map(student => ({
  ...student,
  grade:
    student.marks >= 85 ? "A" :
    student.marks >= 60 ? "B" :
    student.marks >= 40 ? "C" :
    "Fail"
}));

console.log("Students with Grades:", gradedStudents);