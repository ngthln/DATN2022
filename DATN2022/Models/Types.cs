using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;

namespace DATN2022.Models
{
    public class Types
    {
    
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Seats { get; set; }
        public string Layout { get; set; }

        public virtual Coach Coach { get; set; }
    }
}
