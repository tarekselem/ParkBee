using ParkBee.Data.EFMemory;
using ParkBee.Models.Entities;
using System;
using System.Linq;

namespace ParkBee.SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            var unitOfWork = new UnitOfWork();

            var newDoor = new Door
            {
                IPAddress = "111111",
                Name = "Front Door",
                Status =  Statuses.Online
            };
            var res = unitOfWork.RepositoryFor<Door>().Insert(newDoor);
            unitOfWork.SaveChanges();

            var doors = unitOfWork.RepositoryFor<Door>().Get().ToList();

            Console.WriteLine("Hello World!");
        }
    }
}
