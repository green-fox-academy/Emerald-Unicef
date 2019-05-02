using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Unicef.Models;

namespace Unicef.Data
{
    public class ApplicatonContext : DbContext
    {
        public ApplicatonContext(DbContextOptions options) : base(options) { }

        public DbSet<Query> Queries { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Form> Forms { get; set; }
        public DbSet<Quiz> Quizes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Query>()
            .HasOne<Form>(s => s.Form)
            .WithOne(ad => ad.Query)
            .HasForeignKey<Query>(ad => ad.QueryId);

            modelBuilder.Entity<Query>()
            .HasOne<Quiz>(s => s.Quiz)
            .WithOne(ad => ad.Query)
            .HasForeignKey<Query>(ad => ad.QueryId);
            modelBuilder.Entity<Query>().HasOne<Form>();
            modelBuilder.Entity<Query>().HasOne<Quiz>();
        }
    }
}
