using carbackend.Models;
using System.Data.Entity;

namespace carbackend.Data
{
    public class CarsContext : DbContext
    {
        public CarsContext()
            : base("A1Car")
        {
            Console.WriteLine("Context created");
        }

        public DbSet<Car> Cars { get; set; }
        //public DbSet<CarTemplate> CarsList { get; set; }
    }
}
