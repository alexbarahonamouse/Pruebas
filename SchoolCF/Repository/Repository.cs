using SchoolCF.Data;
using SchoolCF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SchoolCF.Repository
{
    public class Repository
    {
        public List<Student> GetStudents()
        {
            using (var db = new Context())
            {
                return db.Students.ToList();
            }
        }

    }
}