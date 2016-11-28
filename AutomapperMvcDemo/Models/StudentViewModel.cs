using System;
using System.ComponentModel.DataAnnotations;

namespace AutomapperMvcDemo.Models
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [Display(Name=@"Birth Date")]
        public DateTime BirthDate { get; set; }
    }
}