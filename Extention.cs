using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionApp
{
    public static class Extention
    {
        public static string GetFullNameWithBirthDate(this Person person)
        {
            return $"{person.BirthDate.ToString("yyy-MM-dd")} - {person.Surname} {person.Name}";
        }
        public static string GetFullStudentInfo(this Student student)
        {
            return $"{student.GetFullName()} - ID: {student.StudentId}";
        }
        public static string GetInitials(this Student student)
        {
            return $"Student: {student.Surname.ToCharArray()[0]}.{student.Name.ToCharArray()[0]}.";
        }
    }
}
