using carbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity;

namespace carbackend.Data
{
    public class CarListContext : DbContext
    {
        public CarListContext()
           : base("TestNewContext")
        {
            Console.WriteLine("Context created");
        }

        public DbSet<CarTemplate> Cars { get; set; }
    }
}
