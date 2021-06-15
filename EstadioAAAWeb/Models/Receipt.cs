using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Receipt
    {
        [Key]
        public string ReceiptUUID { get; set; }
        public string TicketUUID { get; set; }
        public int TotalCost { get; set; }

    }
}
