using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    public  class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Marks { get; set; }


        public List<Subject> Subjects { get; set; }
    }
}
