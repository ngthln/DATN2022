using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DATN2022.Models
{
    public class DropOff
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
