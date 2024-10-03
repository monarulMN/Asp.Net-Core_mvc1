using System.ComponentModel.DataAnnotations;

namespace Asp.net_core.Model
{
    public class Student
    {
        public int Id { get; set; }

        [Display(Name = "Stusent Name")]
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
        public string DepoartmentName { get; set; }
        [Display(Name = "Address")]
        [Required]
        public string Address { get; set; }


    }
}
