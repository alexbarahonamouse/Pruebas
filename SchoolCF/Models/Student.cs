using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolCF.Models
{
    public class Student
    {

        [Key]
        public int StudentID { get; set; }

        [Required]
        [MaxLength(50)]
        
        public string StudentName { get; set; }
        public DateTime? DateOfBirth { get; set; }

       public ICollection<Student>Students { get; set; }

    }
}