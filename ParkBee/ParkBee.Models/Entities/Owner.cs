using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace ParkBee.Models.Entities
{
    public class Owner : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        public Guid GarageId { get; set; }
        [ForeignKey("GarageId")]
        public virtual Garage Garage { get; set; }
    }
}
