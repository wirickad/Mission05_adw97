using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//Here, we define the model for the GradeForm. This way we know what inputs to expect, and how to handle them on the back-end. 
namespace Mission05_adw97.Models
{
    public class GradeFormModel
    {
        [Required]
        [Range(0,100,ErrorMessage = "Assignments value must be between 0 and 100")]
        public int Assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Projects value must be between 0 and 100")]
        public int Projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Quizzes value must be between 0 and 100")]
        public int Quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Midterm value must be between 0 and 100")]
        public int Midterm { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Final value must be between 0 and 100")]
        public int Final { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Intex value must be between 0 and 100")]
        public int Intex { get; set; }

        public int FinalGrade;
    }
}
