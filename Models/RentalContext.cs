using System;
using System.Data.Entity;
using System.Linq;
using System.Security.AccessControl;

namespace RentalBuildingApplication.Models
{
    public class RentalContext : DbContext
    {

        public RentalContext()
            : base("name=RentalContext")
        {
        }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Orendar> Orendars { get; set; }
        public DbSet<Type> Types { get; set; }
        public DbSet<Rent> Rents { get; set; }
        //public DbSet<RentedPlace> RentedPlaces { get; set; }
    }


}