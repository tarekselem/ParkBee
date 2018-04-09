using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkBee.Models.Entities
{
    public class Door : BaseEntity
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string IPAddress { get; set; }
        [Required, DefaultValue(Statuses.Offline)]
        public Statuses Status { get; set; }
        public Guid GarageId { get; set; }
        [ForeignKey("GarageId")]
        public virtual Garage Garage { get; set; }
    }
}
