using System.Collections.Generic;

namespace ViewModels
{
    public class GarageList
    {
        public int Total { get; set; }
        public ICollection<Garage> Items { get; set; }
    }
}
