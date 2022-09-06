using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace DATN2022.Models
{
    public class Ticket
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid? TripId { get; set; }

        [ForeignKey("TripId")]
        public Trip Trip { get; set; }

        public virtual ICollection<TicketDetail> TicketDetails { get; set; }
    }
}
