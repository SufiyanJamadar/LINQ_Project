using System.Linq;

namespace LINQ1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>
                {
                     new Student { Id = 1, Name = "Sufiyan", City = "Pune", Marks = 85 },
                     new Student { Id = 2, Name = "Asma", City = "Mumbai", Marks = 90 },
                     new Student { Id = 3, Name = "John", City = "Pune", Marks = 60 },
                     new Student { Id = 4, Name = "Suranam", City = "Ajara", Marks = 99 },
                     new Student { Id = 5, Name = "Khatija", City = "Adkur", Marks = 98 },
                     new Student { Id = 6, Name = "Satish", City = "Kolhapur", Marks = 30 },
                     new Student { Id = 7, Name = "Alex", City = "Chicago", Marks = 20 }
                };


            var courses = new List<Course>
            {
                new Course { Id = 1, CourseName = "C#", StudentId = 1 },
                new Course { Id = 2, CourseName = "Java", StudentId = 2 },
                new Course { Id = 3, CourseName = "Python", StudentId = 3 },
                new Course { Id = 4, CourseName = "C++", StudentId = 4 },
                new Course { Id = 5, CourseName = "JavaScript", StudentId = 5 },
                new Course { Id = 6, CourseName = "HTML", StudentId = 6 },
                new Course { Id = 7, CourseName = "CSS", StudentId = 7 }
            };
            //var puneStudent=students.Where(s=>s.City=="Pune").ToList();

            //foreach(var s in puneStudent)
            //{
            //    Console.WriteLine($"{s.Name} from {s.City}");
            //}


            //var first=students.FirstOrDefault(x=>x.Id==1);
            //Console.WriteLine($"Name is {first.Name} and City is {first.City} ");



            //var studentsName = students.Select(x => x.Name).ToList();
            //Console.WriteLine(" Students Name List");
            //studentsName.ForEach(name => Console.WriteLine(name));



            ///  OrderBy / OrderByDescending

            //var orderByMarks = students.OrderBy(x => x.Marks).ToList();
            //Console.WriteLine("Students Order By Marks");
            //orderByMarks.ForEach(s => Console.WriteLine($"{s.Name} and {s.Marks}"));


            //var orderByMarksDesc = students.OrderByDescending(x => x.Marks).ToList();
            //Console.WriteLine("Students Order By Marks Descsencding");
            //orderByMarksDesc.ForEach(s => Console.WriteLine($"{s.Name}  and {s.Marks}"));


            //  All

            //bool isPasses = students.All(x => x.Marks > 35);
            //bool isAnyToppeer = students.Any(x => x.Marks > 90);

            //Console.WriteLine($" This Students are passes {isPasses}");
            //Console.WriteLine($" This students are Topper in this class {isAnyToppeer}");



            // Take, Skip 
            //var top3 = students.OrderByDescending(x => x.Marks).Take(4).ToList();
            //Console.WriteLine("Top 3 Students");
            //top3.ForEach(s => Console.WriteLine($"{s.Name} - {s.Marks} - {s.City}"));


            //var skip2 = students.Skip(2).Take(3).ToList();
            //Console.WriteLine("\n Skipping 2 and Taking 3");
            //skip2.ForEach(s => Console.WriteLine($"{s.Name}"));


            //var groupByCity = students.GroupBy(x => x.City).ToList();
            //Console.WriteLine("\nGrouped By City");
            ////  groupByCity.ForEach(x => Console.WriteLine(x));

            //foreach (var group in groupByCity)
            //{
            //    Console.WriteLine($"\n City {group.Key}");

            //    foreach (var s in group)
            //    {
            //        Console.WriteLine($"- {s.Name}");
            //    }

            //}


            //var groupByMarks = students.GroupBy(x => x.Marks).ToList();
            //Console.WriteLine("\nGrouped By Marks");

            //foreach (var marks in groupByMarks)
            //{
            //    Console.WriteLine("\n Group By Marks");
            //    foreach (var m in marks)
            //    {
            //        Console.WriteLine($" - {m.Name} and {m.Marks}");
            //    }
            //}

            // GroupBy After Filtering Marks 

            //var studentsAfterFilter = students.Where(x => x.Marks > 70)
            //    .GroupBy(x => x.Marks).ToList();

            //Console.WriteLine("\nGrouped By Marks After Filtering");

            //foreach (var group in studentsAfterFilter)
            //{
            //    Console.WriteLine($"\nMarks : {group.Key}");
            //    foreach (var student in group)
            //    {
            //        Console.WriteLine($"- {student.Name} and {student.Marks} ");
            //    }
            //}


            //foreach (var student in students)
            //{
            //    Console.WriteLine(student.Name);
            //    Console.WriteLine(student.City);
            //    Console.WriteLine(student.Marks);
            //}



            //var studentCourse = from s in students
            //                    join c in courses on s.Id equals c.StudentId
            //                    select new
            //                    {
            //                        StudentName = s.Name,
            //                        CourseName = c.CourseName
            //                    };

            //Console.WriteLine("\nStudent and Course");

            //foreach (var course in studentCourse)
            //{
            //    Console.WriteLine($"Student Name : {course.StudentName} and Course Name : {course.CourseName}");


            //}


            //var studentCourse2 = students.Join(courses,
            //    s => s.Id,
            //    c => c.StudentId, (s, c) => new { s.Name, c.CourseName }).ToList();

            //Console.WriteLine("\nStudent Courses");
            //studentCourse2.ForEach(sc => Console.WriteLine($"{sc.Name} and {sc.CourseName}"));



            //// GroupBy + Count() – How many students per city

            //var studentCountByCity = students.GroupBy(s => s.City)
            //    .Select(g => new { City = g.Key, Count = g.Count() })
            //    .ToList();

            //Console.WriteLine("\nStudentsCount Per  City : ");

            //studentCountByCity.ForEach(c => Console.WriteLine($" {c.City} : {c.Count} "));


            //// finding avarages

            //int maxMarks = students.Max(s => s.Marks);
            //double avgMarks = students.Average(s => s.Marks);

            //Console.WriteLine($"\nMax Marks: {maxMarks}");
            //Console.WriteLine($"Average Marks: {avgMarks}");



            //  Select Many

            //var allSubjects = students.Where(s => s.Subjects != null)
            //    .SelectMany(s => s.Subjects).ToList();



            //var topScorers = students.OrderByDescending(x => x.Marks).ToList();

            //Console.WriteLine("\nTop Scorers");
            //topScorers.ForEach(s => Console.WriteLine($"{s.Name} - {s.Marks} - {s.City}"));



            ////  Take, Skip – useful for pagination
            //var top3=students.OrderByDescending(x=>x.Marks).Take(3).ToList();
            //Console.WriteLine("\nTop 3 Students");
            //top3.ForEach(s => Console.WriteLine($"{s.Name}- {s.Marks} - {s.City}"));

            //var skip2 = students.Skip(2).Take(3).ToList();
            //Console.WriteLine("\n Skipping 2 and Taking 3");
            //skip2.ForEach(s => Console.WriteLine($"{s.Name} - {s.Marks} - {s.City}"));



            //// Any All 
            //bool anyLowMarks = students.Any(s => s.Marks < 50);
            //Console.WriteLine($"\nAny Student with Marks < 50: {anyLowMarks}");

            //bool allPassed = students.All(s => s.Marks >= 35);
            //Console.WriteLine($"All Passed: {allPassed}");

            ///// Distinct


            //var uniquecities = students.Select(s => s.City).Distinct().ToList();
            //Console.WriteLine("\nUnique Cities:");
            //uniquecities.ForEach(c=>Console.WriteLine(c));


            var topStudentPerCity = students
                .GroupBy(s => s.City)
                .Select(g => g.OrderByDescending(s => s.Marks).First()).ToList();

            Console.WriteLine("\nTop Student from Each City:");
            topStudentPerCity.ForEach(s =>
                Console.WriteLine($"{s.Name} from {s.City} - {s.Marks}")
            );




            var averageStudentMarksPerCity = students
                .GroupBy(s => s.City)
                .Select(g => new
                {
                    City = g.Key,
                    AveragrMarks = g.Average(s => s.Marks)
                })
                .ToList();

            Console.WriteLine("\nAverage Marks Per City:");
            averageStudentMarksPerCity.ForEach(x =>
               Console.WriteLine($"{x.City} - Avg Marks {x.AveragrMarks}"));



            var getAllStudentStartsWithS = students
                .Where(s => s.Name.StartsWith("S")).ToList();

            Console.WriteLine("\nStudents Starts With S");
            getAllStudentStartsWithS.ForEach(s =>
                Console.WriteLine($"{s.Name} from {s.City} - {s.Marks}")
            );


            var studentDict = students
                .ToDictionary(s => s.Id);

            Console.WriteLine("\nAccess student By ID  (eg , ID=3)");
            if (studentDict.TryGetValue(3, out var student))
            {
                Console.WriteLine($"Student Found: {student.Name} from {student.City}");
            }


        }
    }

}