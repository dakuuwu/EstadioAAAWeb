using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Admin
    {
        [Key]
        public string AdminKey { get; set; }
        [Required]
        public string AdminPass { get; set; }

        public User User { get; set; }
    }
}
