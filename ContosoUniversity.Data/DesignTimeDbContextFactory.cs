using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ContosoUniversity.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolContext>();

            builder.UseSqlServer(@"Server=.;Database=SchoolDB;Trusted_Connection=True",

                optionsBuilder => optionsBuilder.MigrationsAssembly(typeof(SchoolContext).GetTypeInfo().Assembly.GetName().Name));

            return new SchoolContext(builder.Options);
        }
    }
}
