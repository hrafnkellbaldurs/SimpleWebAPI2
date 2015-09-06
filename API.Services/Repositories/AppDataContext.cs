using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using API.Services.Entities;

namespace API.Services.Repositories
{
    class AppDataContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
    }
}