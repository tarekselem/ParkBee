using System;

namespace ViewModels
{
    public class Garage
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public Guid OwnerId { get; set; }
        public string OwnerName { get; set; }
        public int DoorsCount { get; set; }
    }
}
