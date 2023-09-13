using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OnlineExamSystem.Authorization.Roles;
using OnlineExamSystem.Authorization.Users;
using OnlineExamSystem.MultiTenancy;
using OnlineExamSystem.Data;

namespace OnlineExamSystem.EntityFrameworkCore
{
    public class OnlineExamSystemDbContext : AbpZeroDbContext<Tenant, Role, User, OnlineExamSystemDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OnlineExamSystemDbContext(DbContextOptions<OnlineExamSystemDbContext> options)
            : base(options)
        {
        }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Choise> Choises { get; set; }
    }
}
