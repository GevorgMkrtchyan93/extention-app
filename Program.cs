using System;
using System.Collections.Generic;

namespace ExtentionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person()
            {
                Name = "Arman",
                Surname = "Barsexyan",
                BirthDate = new DateTime(1990, 1, 1)
            };
            Console.WriteLine(person.GetFullName());

            var student = new Student()
            {
                Name = "Aram",
                Surname = "Manukyan",
                BirthDate = new DateTime(2000, 01,01),
                StudentId = 123
            };

            Console.WriteLine(student.GetFullNameWithBirthDate());
            Console.WriteLine(student.GetFullStudentInfo());
            Console.WriteLine(student.GetInitials());

        }
    }
}
