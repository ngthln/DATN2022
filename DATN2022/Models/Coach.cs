using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;

namespace DATN2022.Models
{
    public class Coach
    {

        [ForeignKey("Types")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Schedule { get; set; }
      
        public string Type { get; set; }

        [ForeignKey("Colors")]
        public Guid Color { get; set; }
        public string LisencePlates { get; set; }
        public string Reserve { get; set; }

        public Guid? OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public CoachOwner CoachOwner { get; set; }

        public virtual ICollection<Trip> Trips { get; set; }
        public virtual Types Types { get; set; }
        public virtual Colors Colors { get; set; }


    }
}
