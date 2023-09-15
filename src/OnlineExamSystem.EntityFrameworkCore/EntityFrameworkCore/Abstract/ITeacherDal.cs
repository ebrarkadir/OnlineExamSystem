using OnlineExamSystem.Data;
using OnlineExamSystem.EntityFrameworkCore.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.EntityFrameworkCore.Abstract
{
    public interface ITeacherDal : IEntityRepository<Teacher>
    {
    }
}
