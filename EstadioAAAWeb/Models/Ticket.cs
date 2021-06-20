using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Ticket
    {
        [Key]
        [Required]
        [Display(Name ="ID Ticket")]
        public string TicketUUID { get; set; }
        [ForeignKey("User")]
        [Required]
        [Display(Name = "RUT Asociado")]
        public string UserRUT { get; set; }
        [ForeignKey("Event")]
        [Required]
        [Display(Name = "ID Evento")]
        public string EventUUID { get; set; }

        public Event Event { get; set; }
    }
}
