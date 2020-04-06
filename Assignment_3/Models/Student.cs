using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment_3.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Column(TypeName ="varchar(50)")]
        [Required]
        public String StudentName { get; set; }
        [Column(TypeName ="nvarchar(50)")]
        [Required]
        public String CourseId { get; set; }
    }
}
