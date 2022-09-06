using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DATN2022.Models
{
    public class Seat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public int SeatNo { get; set; }

        public string Status { get; set; }

        public string Rank { get; set; }
        public string Row { get; set; }
        public string Column { get; set; }
      
        public virtual TicketDetail TicketDetail { get; set; }
    }
}
