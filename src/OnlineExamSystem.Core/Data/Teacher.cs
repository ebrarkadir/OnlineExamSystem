using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Data
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
        public ICollection<Exam> Exams { get; set; }
    }
}
