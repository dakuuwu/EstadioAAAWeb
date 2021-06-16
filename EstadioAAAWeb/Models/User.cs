using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class User
    {
        [Key]
        [Required]
        [Display(Name = "ID Usuario")]
        public string UserUUID { get; set; }
        [Required]
        [Display(Name = "Nombre de Usuario")]
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Display(Name = "E-Mail Usuario")]
        public string Email { get; set; }
        [Required]
        [Display(Name = "RUT")]
        public string RUT { get; set; }
    }
}
