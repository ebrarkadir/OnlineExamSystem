using Abp.AutoMapper;
using OnlineExamSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Dtos
{
    [AutoMapFrom(typeof(Exam))]
    public class ExamDto : IDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
