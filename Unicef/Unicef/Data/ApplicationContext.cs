using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
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
    }
}
=======

namespace Unicef
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
    }
}
>>>>>>> master
