using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCRepositoryEntity.Models
{
    public class Student
    {
        [Key]
        public int intId { get; set; }
        [Required(ErrorMessage ="Please Enter Your Name")]
        public string strName { get; set; }

        [Required(ErrorMessage = "Please Enter Your Name")]
        [EmailAddress(ErrorMessage ="Please Valid Email Address")]
        public string strEmail { get; set; }

        [Required(ErrorMessage = "Please Enter Your Reg No")]
        public string strRegNo { get; set; }
    }
}