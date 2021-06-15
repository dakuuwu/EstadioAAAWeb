using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Admin
    {
        [Key]
        public string UserUUID { get; set; }
        public string AdminPass { get; set; }
    }
}
