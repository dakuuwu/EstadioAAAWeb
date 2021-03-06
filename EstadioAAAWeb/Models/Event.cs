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
        [Required]
        [Display(Name = "ID Evento")]
        public string EventUUID { get; set; }

        [Required]
        [Display(Name = "Nombre del Evento")]
        public string EventName { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Fecha del Evento")]
        public DateTime EventDate { get; set; }

        [Display(Name = "Descripción del Evento")]
        public string EventDesc { get; set; }

        [Display(Name = "Quorum del Evento")]
        public int EventQuorum { get; set; }

        [Display(Name = "Valor de Entrada")]
        public int EventFee { get; set; }

        [Display(Name = "Organizador")]
        public string EventOrg { get; set; }


    }
}
