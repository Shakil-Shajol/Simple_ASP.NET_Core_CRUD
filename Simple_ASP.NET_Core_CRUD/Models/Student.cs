using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required,StringLength(150)]
        public string StudentName { get; set; }
        [Required]
        public DateTime DateOfBirth { get; set; }
        [ForeignKey("Gender")]
        public int GenderId { get; set; }

        public Gender Gender { get; set; }
    }
}
