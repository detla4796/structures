using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace structure
{
    internal class StudentTask
    {
        public struct Birthday
        {
            public int Day;
            public int Month;
            public int Year;
        }
        public struct Student
        {
            public string LastName;
            public Birthday Birthday;
            public string Gender;
        }
        public static void Run()
        {
            Student[] students = GenerateStudents(25);
            Student oldBoy = new Student();
            int oldBoyIndex = -1;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Gender.ToLower() == "м")
                {
                    if (oldBoyIndex == -1)
                    {
                        oldBoy = students[i];
                        oldBoyIndex = i;
                    }
                    else if (IsOlder(students[i].Birthday, oldBoy.Birthday))
                    {
                        oldBoy = students[i];
                        oldBoyIndex = i;
                    }
                }
            }
            if (oldBoyIndex != -1)
            {
                Console.WriteLine($"The oldest boy is {oldBoy.LastName} Birthday date: {oldBoy.Birthday.Day}.{oldBoy.Birthday.Month}.{oldBoy.Birthday.Year}");
            }
            else
            {
                Console.WriteLine("Boys not found");
            }
        }
        public static Student[] GenerateStudents(int count)
        {
            Student[] students = new Student[count];
            Random random = new Random();
            string[] lastNames = { "Петров", "Иванов", "Сидоров", "Смирнов", "Кузнецов", "Попов", "Васильев", "Павлов", "Семенов", "Голубев" };
            string[] genders = { "М", "Ж" };
            for (int i = 0; i < count; i++)
            {
                students[i] = new Student
                {
                    LastName = lastNames[random.Next(lastNames.Length)],
                    Birthday = new Birthday
                    {
                        Day = random.Next(1, 29),
                        Month = random.Next(1, 13),
                        Year = random.Next(1990, 2002)
                    },
                    Gender = genders[random.Next(genders.Length)]
                };
            }
            return students;
        }
        static bool IsOlder(Birthday date1, Birthday date2)
        {
            if (date1.Year < date2.Year)
            {
                return true;
            }
            if (date1.Year == date2.Year && date1.Month < date2.Month)
            {
                return true;
            }
            if (date1.Year == date2.Year && date1.Month == date2.Month && date1.Day < date2.Day)
            {
                return true;
            }
            return false;
        }
    }
}
