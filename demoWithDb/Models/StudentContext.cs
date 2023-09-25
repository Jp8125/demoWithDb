using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace demoWithDb.Models
{
    public class StudentContext:DbContext
    {
        public StudentContext():base("StudentDbContext")
        {
            
        }
        public DbSet<Student> Students { get; set; }
    }
}