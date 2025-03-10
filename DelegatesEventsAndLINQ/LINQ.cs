using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Delegates101
{
    class Program
    {
        static void Main()
        {
            #region LINQ Query Syntax and Method Syntax

            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

            List<string> names = new List<string> { "Adam", "Bill", "Alan", "Oscar", "Tony", "Adrian" };


            var namesWithA1 = from n in names
                              where n.StartsWith('A')
                              select n;

            var namesWithA2 = names.Where(n => n.StartsWith('O'));

            Console.WriteLine(String.Join(", ", namesWithA2));

            var evenNumbers1 = from n in numbers
                               where n % 2 == 0
                               select n;

            var evenNumbers2 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine(String.Join(", ", evenNumbers2));

            #endregion


            #region Filtering, Ordering, Projection
            //var students = new List<string> { "Alice", "Bob", "Anna", "Michael" };

            //var aNames = students.Where(name => name.StartsWith("A"));


            //var sortedNames = students.OrderByDescending(name => name);

            //var endANames = students.Where(name => name.EndsWith("l"));

            //Console.WriteLine(String.Join(", ", aNames));
            //Console.WriteLine(String.Join(", ", sortedNames));
            //Console.WriteLine(String.Join(", ", endANames));
            #endregion

            #region Joining, Grouping, Aggregation

            //var students = new List<(int Id, string Name)>
            //{
            //    (1, "Alice"), (2, "Bob")
            //};

            //var grades = new List<(int StudentId, string Grade)>
            //{
            //    (1, "A"), (2, "B")
            //};


            //var employees = new List<(int Id, string Name)>
            //{
            //    (1, "Bill"), (2, "Kyle"), (3, "Thomas")
            //};

            //var departments = new List<(int Id, string department)>
            //{
            //    (1, "HR"), (2, "R&D"), (3, "Testing")
            //};

            //var result = from s in students
            //             join g in grades on s.Id equals g.StudentId
            //             select new { s.Name, g.Grade };



            //var result3 = students.Join(grades, student => student.Id, grade => grade.StudentId,
            //    (student, grade) => new { student.Name, grade.Grade });

            //foreach (var item in result)
            //    Console.WriteLine($"{item.Name}: {item.Grade}");


            //var result2 = from e in employees
            //              join d in departments on e.Id equals d.Id
            //              select new { e.Name, d.department };



            //foreach (var item in result2)
            //    Console.WriteLine($"{item.Name}: {item.department}");

            //foreach (var item in result3)
            //    Console.WriteLine($"{item.Name}: {item.Grade}");

            #endregion


            #region LINQ for XML and JSON
            //string xml = @"<Books>
            //                <Book><Title>C# Programming</Title></Book>
            //                <Book><Title>LINQ in Action</Title></Book>
            //               </Books>";


            //XDocument doc = XDocument.Parse(xml);
            //var title = doc.Descendants("Book").Select(b => b.Element("Title")?.Value);

            //Console.WriteLine(string.Join(", ", title));


            //string json = @"[{ 'Name': 'Alice' }, { 'Name': 'Bob' }]";
            //JArray array = JArray.Parse(json);

            //var names = array.Select(item => item["Name"]?.ToString());
            //Console.WriteLine(string.Join(", ", names));

            #endregion

            #region Introduction EF Core
            //using var db = new AppDbContext();
            //db.Students.Add(new Student { Name = "Alice" });
            //db.SaveChanges();

            //var students = db.Students.ToList();
            //students.ForEach(s => Console.WriteLine(s.Name));

            //var studentWithA = db.Students.Where(s => s.Name.StartsWith("B")).ToList();

            //studentWithA.ForEach(s => Console.WriteLine(s.Name));

            #endregion
        }

    }

    #region Introduction EF Core 

    //class AppDbContext : DbContext
    //{
    //    public DbSet<Student> Students { get; set; }

    //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //        => optionsBuilder.UseInMemoryDatabase("TestDB");
    //}

    //class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}

    #endregion
}
