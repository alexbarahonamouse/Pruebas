using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SchoolCF.Models;
using System.Data.Entity;

namespace SchoolCF.Data
{
    public class CourseRepository : BaseRepository<Course>
    { 
        public CourseRepository(Context context)
            : base(context)
        {

        }


        public override IList<Course> GetList()
        {
            return Context.Courses
                .OrderBy(a => a.CourseName)
                .ToList();
        }


        public bool CourseHasName(int courseId, string name)
        {
            return Context.Courses
                .Any(a => a.CourseId != courseId && a.CourseName == name);
        }

        public override Course Get(int id, bool includeRelatedEntities = true)
        {
            throw new NotImplementedException();
        }
    }
}