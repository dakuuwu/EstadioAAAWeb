using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Ticket
    {
        [Key]
        public string TicketUUID { get; set; }
        public string UserRUT { get; set; }
        public string EventUUID { get; set; }
    }
}
