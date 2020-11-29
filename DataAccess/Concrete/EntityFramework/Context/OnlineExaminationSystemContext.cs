using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class OnlineExaminationSystemContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=OnlineExaminationSystem;Trusted_Connection=true");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseExam>(ce =>
            {
                ce.HasNoKey();
            });
            modelBuilder.Entity<CourseInstructor>(ci =>
            {
                ci.HasNoKey();
            });
            modelBuilder.Entity<ExamQuestion>(eq =>
            {
                eq.HasNoKey();
            });
            modelBuilder.Entity<ExamResult>(er =>
            {
                er.HasNoKey();
            });
            modelBuilder.Entity<Instructor>(i =>
            {
                i.HasNoKey();
            });
            modelBuilder.Entity<QuestionOption>(qo =>
            {
                qo.HasNoKey();
            });
            modelBuilder.Entity<StudentCourse>(sc =>
            {
                sc.HasNoKey();
            });
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseExam> CourseExams { get; set; }
        public DbSet<CourseInstructor> CourseInstructors { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<ExamQuestion> ExamQuestions { get; set; }
        public DbSet<ExamResult> ExamResults { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<QuestionOption> QuestionOptions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
