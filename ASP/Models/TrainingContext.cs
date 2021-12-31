using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace ASP.Models
{
    public partial class TrainingContext : DbContext
    {
        public TrainingContext()
            : base("name=TrainingContext")
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<Cat> Cats { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Coursedetail> Coursedetails { get; set; }
        public virtual DbSet<CourseTrainer> CourseTrainers { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<Topic> Topics { get; set; }
        public virtual DbSet<Trainee> Trainees { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }
        public virtual DbSet<TrainingStaff> TrainingStaffs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<Account>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Cat>()
                .Property(e => e.Catname)
                .IsFixedLength();

            modelBuilder.Entity<Cat>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Coursename)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Coursetoeic)
                .IsUnicode(false);

            modelBuilder.Entity<Course>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Coursedetail>()
                .Property(e => e.Trainee)
                .IsFixedLength();

            modelBuilder.Entity<Topic>()
                .Property(e => e.Topicname)
                .IsUnicode(false);

            modelBuilder.Entity<Topic>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<Trainee>()
                .Property(e => e.Traineename)
                .IsUnicode(false);

            modelBuilder.Entity<Trainee>()
                .Property(e => e.local_address)
                .IsUnicode(false);

            modelBuilder.Entity<Trainee>()
                .Property(e => e.Coursetoeic)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.Trainername)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.education)
                .IsFixedLength();

            modelBuilder.Entity<Trainer>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<Trainer>()
                .Property(e => e.local_address)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingStaff>()
                .Property(e => e.Trainingname)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingStaff>()
                .Property(e => e.phonenumber)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingStaff>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<TrainingStaff>()
                .Property(e => e.local_address)
                .IsUnicode(false);
        }
    }
}
