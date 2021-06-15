using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EstadioAAAWeb.Models
{
    public class Event
    {
        [Key]
        public string EventUUID { get; set; }
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        public DateTime EventDate { get; set; }
        public string EventDesc { get; set; }
        public int EventQuorum { get; set; }
        public int EventFee { get; set; }
        public string EventOrganizer { get; set; }
        [ForeignKey("UserUUID")]
        public string UserUUID { get; set; }

    }
}
