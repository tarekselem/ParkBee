using System;

namespace BindingModels
{
    public class Garage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Entities.Statuses Status { get; set; }
        public Guid OwnerId { get; set; }
    }
}
