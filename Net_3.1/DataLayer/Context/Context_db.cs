using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace DataLayer.Context
{
    public class Context_db : DbContext
    {
        public Context_db(DbContextOptions<Context_db> options) : base(options)
        {

        }

        public DbSet<Tbl_student> TblStudents { get; set; }
    }

    public class ToDoContextFactory : IDesignTimeDbContextFactory<Context_db>
    {
        public Context_db CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context_db>();
            builder.UseSqlServer("Data Source=.;initial Catalog=Net_3_db;integrated Security=SSPI;MultipleActiveResultSets=true");
            return new Context_db(builder.Options);
        }
    }
}
