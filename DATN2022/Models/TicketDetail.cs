using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DATN2022.Models
{
    public class TicketDetail
    {
        [ForeignKey("Gender")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string CustomerName { get; set; }
        public string TicketNo { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerAge { get; set; }
        public string CustomerPhone { get; set; }
        public string IdentityCertificate { get; set; }

        [ForeignKey("Seat")]
        public Guid SeatNo { get; set; }
        public int Quantity { get; set; }
        public Guid? TicketId { get; set; }

        [ForeignKey("TicketId")]
        public Ticket Ticket { get; set; }
        public virtual Gender Gender { get; set; }
        public virtual Seat Seat { get; set; }
    }
}
