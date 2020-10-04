using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolCF.Models
{
    public class Course
    {
       
        [Key]
       public int CourseId { get; set; }
       [Required]
        [MaxLength(50)]
        public string CourseName { get; set; }
        
     
       

    }
}