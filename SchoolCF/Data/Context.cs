using SchoolCF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SchoolCF.Data
{
    public class Context : DbContext
    {

        public Context(): base ("MydbEntities")
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public DbSet<Inscription>Incription { get; set; }

    }
}