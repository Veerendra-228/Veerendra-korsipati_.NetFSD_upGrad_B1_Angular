let employees = [
 { id:1, name:"Ravi", dept:"IT", salary:70000 },
 { id:2, name:"Anita", dept:"HR", salary:50000 },
 { id:3, name:"Karan", dept:"IT", salary:80000 },
 { id:4, name:"Meena", dept:"Finance", salary:60000 }
];
console.log("===== Assignment 4 =====");
let totalSalaryExpense = employees.reduce(
  (total, emp) => total + emp.salary,
  0
);
console.log("Total Salary Expense:", totalSalaryExpense);
let sortedBySalary = [...employees].sort((a, b) => b.salary - a.salary);

let highestPaid = sortedBySalary[0];
let lowestPaid = sortedBySalary[sortedBySalary.length - 1];
console.log("Highest Paid Employee:", highestPaid);
console.log("Lowest Paid Employee:", lowestPaid);
let increasedITSalary = employees.map(emp =>
  emp.dept === "IT"
    ? { ...emp, salary: +(emp.salary * 1.15).toFixed(2) }
    : emp
);

console.log("IT Salary Increased by 15%:", increasedITSalary);
let groupedByDepartment = employees.reduce((acc, emp) => {
  acc[emp.dept] = acc[emp.dept] || [];
  acc[emp.dept].push(emp);
  return acc;
}, {});

console.log("Grouped by Department:", groupedByDepartment);
let departmentWiseAverage = Object.keys(groupedByDepartment).map(dept => {
  let avg =
    groupedByDepartment[dept].reduce((sum, emp) => sum + emp.salary, 0)
    / groupedByDepartment[dept].length;

  return { department: dept, averageSalary: avg };
});
console.log("Department-wise Average Salary:", departmentWiseAverage);
let sortedDescending = [...employees].sort((a, b) => b.salary - a.salary);
console.log("Sorted by Salary (Descending):", sortedDescending);