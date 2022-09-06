using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DATN2022.Models
{
    public class Trip
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime DepartureTime { get; set; }
        public int TripNo { get; set; }
        public int UnitPrice { get; set; }
        public Guid? CoachId { get; set; }

        [ForeignKey("CoachId")]
        public Coach Coach { get; set; }
        public virtual ICollection<Pickup> Pickups { get; set; }
        public virtual ICollection<DropOff> DropOffs { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }   
}
