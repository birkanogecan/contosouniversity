using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ContosoUniversity.Data
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<SchoolContext>();
            var connectionString = @"Server=BIRKAN-LAPTOP;Database=SchoolDB;Integrated Security=True";
            builder.UseSqlServer(connectionString);
            return new SchoolContext(builder.Options);
        }
    }
}
