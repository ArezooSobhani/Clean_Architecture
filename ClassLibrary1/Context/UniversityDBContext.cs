using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Data
{

   public  class UniversityDBContext:DbContext
    {
        public UniversityDBContext(DbContextOptions<UniversityDBContext> options)
            :base(options)
        {

        }  
        public DbSet<Course> Courses { get; set; }
    }
}
