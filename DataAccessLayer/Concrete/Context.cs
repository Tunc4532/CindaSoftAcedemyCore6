using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=monster2684tunc\\SQLEXPRESS;database=AcedemyDb;integrated security=true");
        }

        public DbSet<Feature>? Features { get; set; }
        public DbSet<Course>? Courses { get; set; }
        public DbSet<About>? Abouts { get; set; }
        public DbSet<Teacher>? Teachers { get; set; }
        public DbSet<CommentTeacher>? CommentTeachers { get; set; }
        public DbSet<Article>? Articles { get; set; }
        public DbSet<Welcome>? Welcomes { get; set; }
        public DbSet<Promotion>? Promotions { get; set; }
        public DbSet<OnlineLesson>? OnlineLessons { get; set; }
        public DbSet<Education>? Educations { get; set; }
        public DbSet<Contact>? Contacts { get; set; }
        public DbSet<WriterMesssage>? WriterMesssages { get; set; }
        public DbSet<Lesson>? Lessons { get; set; }
        public DbSet<Announcement>? Announcements { get; set; }
        public DbSet<Account>? Accounts { get; set; }

    }
}
