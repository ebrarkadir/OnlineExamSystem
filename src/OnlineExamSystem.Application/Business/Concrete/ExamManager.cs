using Abp.Application.Services;
using Abp.Domain.Repositories;
using OnlineExamSystem.Business.Abstract;
using OnlineExamSystem.Data;
using OnlineExamSystem.Dtos;
using OnlineExamSystem.EntityFrameworkCore.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.Business.Concrete
{
    public class ExamManager : IExamManager
    {
        IExamDal _examDal;
        public ExamManager(IExamDal examDal)
        {
            _examDal = examDal;
        }
        public void AddExam(ExamDto examDto)
        {
            /// Mapper processes examDto mapper exam
            /// 
            Exam exam = new Exam();

            exam.TeacherId = examDto.TeacherId;
            exam.Title = examDto.Title;

            _examDal.Add(exam);


        }
    }
}
