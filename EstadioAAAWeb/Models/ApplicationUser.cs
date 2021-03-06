using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "RUT")]
        public string RUT { get; set; }
    }
}
