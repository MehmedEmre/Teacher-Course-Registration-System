using Microsoft.EntityFrameworkCore;
using FirstEntityFrameworkCore.DAC.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCore.DAC.DBContext
{
    public class DataBaseContext:DbContext
    {

     public DbSet<Teacher> TeacherTable { set; get; }
     public DbSet<Lessons> LessonTable { set; get; }
     public DbSet<Branch> BranchTable { set; get; }
     public DbSet<Subject> SubjectTable { set; get; }
     public DbSet<Branch_Teacher> Branch_TeacherTable { set; get; }



        public DataBaseContext()
        {


        }

        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options) { }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-D6E78MU\\SQLEXPRESS;database=school;integrated security=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Branch_Teacher>()
                        .HasKey(p => p.id);

            modelBuilder.Entity<Branch_Teacher>()
                        .HasOne(bt => bt.teacher)
                        .WithMany(t => t.branch_teacher)
                        .HasForeignKey(bt => bt.TeacherId);

            modelBuilder.Entity<Branch_Teacher>().
                         HasOne(b => b.branch).
                         WithMany(bt => bt.branch_teacher)
                         .HasForeignKey(b=>b.BranchId);



        }

    }
}
