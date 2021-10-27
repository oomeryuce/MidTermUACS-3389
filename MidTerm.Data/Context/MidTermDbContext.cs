using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using midTerm.Data.Entities;

namespace MidTerm.Data.Context
{
    public class MidTermDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\MSSQLLocalDB;Database=MidTerm;integrated security=true;");
        }

        public DbSet<Answers> Answers { get; set; }
        public DbSet<Option> Options { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<SurveyUser> SurveyUsers { get; set; }
    }
}
