using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Simple_ASP.NET_Core_CRUD.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        [Required,StringLength(10)]
        public string Sex { get; set; }
    }
}
