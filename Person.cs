using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtentionApp
{
   public  class Person
    {
        public DateTime BirthDate { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GetFullName() => $"{Surname} {Name}";
    }
}
