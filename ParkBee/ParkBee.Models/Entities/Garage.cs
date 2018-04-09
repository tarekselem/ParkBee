using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkBee.Models.Entities
{
    public class Garage : BaseEntity
    {
        public Garage()
        {
            Doors = new HashSet<Door>();
        }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required, DefaultValue(Statuses.Offline)]
        public Statuses Status { get; set; }

        public Guid OwnerId { get; set; }
        [ForeignKey("OwnerId")]
        public virtual Owner Owner { get; set; }

        public virtual ICollection<Door> Doors { get; set; }
    }



}
