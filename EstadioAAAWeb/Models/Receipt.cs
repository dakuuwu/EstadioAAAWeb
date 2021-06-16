using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EstadioAAAWeb.Models
{
    public class Receipt
    {
        [Key]
        [Required]
        [Display(Name ="ID Boleta")]
        public string ReceiptUUID { get; set; }
        [Required]
        [Display(Name = "ID Ticket")]
        [ForeignKey("TicketUUID")]
        public string TicketUUID { get; set; }
        [Required]
        [Display(Name = "Valor Total")]
        public int TotalCost { get; set; }

    }
}
