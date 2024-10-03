using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace DotNetFirst_project.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Student Name")]
        [Required]
        public string StudentName { get; set; }
        [Display(Name = "Reg No")]
        [Required]
        public string RegNo { get; set; }
        [EmailAddress]
        [Required]
        public string Email { get; set; }
        [Display(Name = "Department Name")]
        [Required]
        public string DepartmentName { get; set; }


    }
}
