using System;
using System.Collections.Generic;
using System.Linq;

namespace HandOnLinq
{
    // Models
    class Student
    {
        public int Id, Age, Marks;
        public string Name, Class, Subject;
    }

    class Employee
    {
        public int Id, Salary;
        public string Name, Department;
        public DateTime JoiningDate;
    }

    class Customer
    {
        public int Id;
        public string Name;
    }

    class Order
    {
        public int Id, CustomerId, Amount;
        public string CustomerName;
        public DateTime OrderDate;
    }

    class Product
    {
        public int Id, Price, Stock;
        public string Name, Category;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // ================= LEVEL 1 =================

            Console.WriteLine("===== Assignment 1 =====");
            var students = new List<Student>
            {
                new Student{Id=1,Name="Ravi",Age=20,Marks=80},
                new Student{Id=2,Name="Kiran",Age=22,Marks=70},
                new Student{Id=3,Name="Amit",Age=19,Marks=90}
            };

            Print(students.Where(s => s.Marks > 75));
            Print(students.Where(s => s.Age >= 18 && s.Age <= 25));
            Print(students.OrderByDescending(s => s.Marks));
            Print(students.Select(s => new { s.Name, s.Marks }));


            Console.WriteLine("\n===== Assignment 2 =====");
            var numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

            Print(numbers.Where(n => n % 2 == 0));
            Print(numbers.Where(n => n > 15));
            Print(numbers.Select(n => n * n));
            Console.WriteLine(numbers.Count(n => n % 5 == 0));


            Console.WriteLine("\n===== Assignment 3 =====");
            var names = new List<string> { "Ravi", "Kiran", "Amit", "Raj", "Anil" };

            Print(names.Where(n => n.StartsWith("A")));
            Print(names.OrderBy(n => n));
            Print(names.Select(n => n.ToUpper()));
            Print(names.Where(n => n.Length > 4));


            // ================= LEVEL 2 =================

            Console.WriteLine("\n===== Assignment 4 =====");
            var employees = new List<Employee>
            {
                new Employee{Id=1,Name="A",Department="IT",Salary=5000,JoiningDate=DateTime.Now.AddMonths(-2)},
                new Employee{Id=2,Name="B",Department="HR",Salary=4000,JoiningDate=DateTime.Now.AddMonths(-8)},
                new Employee{Id=3,Name="C",Department="IT",Salary=7000,JoiningDate=DateTime.Now.AddMonths(-1)}
            };

            Print(employees.Where(e => e.Department == "IT"));
            Console.WriteLine(employees.Max(e => e.Salary));
            Console.WriteLine(employees.Average(e => e.Salary));

            var grpEmp = employees.GroupBy(e => e.Department);
            foreach (var g in grpEmp)
                Console.WriteLine($"{g.Key} - {g.Count()}");


            Console.WriteLine("\n===== Assignment 5 =====");
            var customers = new List<Customer>
            {
                new Customer{Id=1,Name="Ravi"},
                new Customer{Id=2,Name="Kiran"}
            };

            var orders = new List<Order>
            {
                new Order{Id=1,CustomerId=1,Amount=3000},
                new Order{Id=2,CustomerId=1,Amount=3000}
            };

            var join = customers.Join(orders,
                c => c.Id,
                o => o.CustomerId,
                (c, o) => new { c.Name, o.Amount });

            Print(join);

            var totals = orders.GroupBy(o => o.CustomerId)
                .Select(g => new { Id = g.Key, Total = g.Sum(x => x.Amount) });

            Print(totals.Where(t => t.Total > 5000));

            Print(customers.Where(c => !orders.Any(o => o.CustomerId == c.Id)));


            Console.WriteLine("\n===== Assignment 6 =====");
            var nums = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

            Print(nums.Distinct());
            Print(nums.GroupBy(n => n).Where(g => g.Count() > 1).Select(g => g.Key));
            Print(nums.GroupBy(n => n).Select(g => new { g.Key, Count = g.Count() }));


            // ================= LEVEL 3 =================

            Console.WriteLine("\n===== Assignment 7 =====");
            var products = new List<Product>
            {
                new Product{Id=1,Name="A",Category="Elec",Price=100,Stock=5},
                new Product{Id=2,Name="B",Category="Elec",Price=200,Stock=20},
                new Product{Id=3,Name="C",Category="Food",Price=50,Stock=0}
            };

            Print(products.Where(p => p.Stock < 10));
            Print(products.OrderByDescending(p => p.Price).Take(3));

            foreach (var g in products.GroupBy(p => p.Category))
                Console.WriteLine($"{g.Key} - {g.Sum(x => x.Stock)}");

            Console.WriteLine(products.Any(p => p.Stock == 0));


            Console.WriteLine("\n===== Assignment 8 =====");
            students.ForEach(s => { s.Class = "10"; s.Subject = "Math"; });

            var multi = students.GroupBy(s => s.Class)
                .Select(c => new
                {
                    Class = c.Key,
                    Subjects = c.GroupBy(x => x.Subject)
                        .Select(s => new
                        {
                            Subject = s.Key,
                            Avg = s.Average(x => x.Marks)
                        })
                });

            Print(multi);


            Console.WriteLine("\n===== Assignment 9 =====");
            var orders2 = new List<Order>
            {
                new Order{Id=1,CustomerName="Ravi",OrderDate=DateTime.Now.AddDays(-10),Amount=2000},
                new Order{Id=2,CustomerName="Kiran",OrderDate=DateTime.Now.AddDays(-40),Amount=5000}
            };

            Print(orders2.Where(o => o.OrderDate >= DateTime.Now.AddDays(-30)));

            Print(orders2.GroupBy(o => o.OrderDate.Month)
                .Select(g => new { Month = g.Key, Total = g.Sum(x => x.Amount) }));


            // ================= LEVEL 4 =================

            Console.WriteLine("\n===== Assignment 10 =====");
            Print(employees.OrderBy(e => e.Department).ThenByDescending(e => e.Salary));


            Console.WriteLine("\n===== Assignment 15 =====");
            Console.WriteLine(employees.Count());

            Print(employees.GroupBy(e => e.Department)
                .Select(g => new { g.Key, Avg = g.Average(x => x.Salary) }));

            Print(employees.Where(e => e.JoiningDate >= DateTime.Now.AddMonths(-6)));

            Print(employees.GroupBy(e => e.Department)
                .Select(g => g.OrderByDescending(x => x.Salary).First()));

            Console.WriteLine(employees.Min(e => e.Salary));
            Console.WriteLine(employees.Max(e => e.Salary));
            Console.WriteLine(employees.Average(e => e.Salary));
        }

        // Common Print Method
        static void Print<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
                Console.WriteLine(item);
        }
    }
}