using System;

namespace BindingModel
{
    public class Garage
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Entities.Statuses Status { get; set; }
        public Guid OwnerId { get; set; }
    }
}
