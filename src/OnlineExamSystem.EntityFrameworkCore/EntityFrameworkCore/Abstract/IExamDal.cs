using OnlineExamSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExamSystem.EntityFrameworkCore.Abstract
{
    public interface IExamDal : IEntityRepository<Exam>
    {

    }
}
