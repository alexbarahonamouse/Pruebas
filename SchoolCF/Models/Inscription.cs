using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolCF.Models
{
    public class Inscription
    {
        [Key]
        public int InscriptionID { get; set; }

        public DateTime ? DateInscription { get; set; }
        [Required]
        [MaxLength(50)]
        public string GradeName { get; set; }
        [Required]
        [MaxLength(2)]
     
        public string  Section { get; set; }


        public int StudentId { get; set; }
       

        public  Student Student { get; set; }


        public int CourseId { get; set; }

        public Course Course { get; set; }




    }
}