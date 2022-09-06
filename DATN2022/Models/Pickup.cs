using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DATN2022.Models
{
    public class Pickup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int PhoneNumber { get; set; }
        public string Address { get; set; }
        public Guid? TripId { get; set; }

        [ForeignKey("TripId")]
        public Trip Trip { get; set; }
    }
}
