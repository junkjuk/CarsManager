using carbackend.Data;
using carbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace carbackend.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private static string name = "qwer";
        private static int age = 12;
        [HttpGet]
        public Car[] asd()
        {
            var context = new CarsContext();
            var c = context.Cars;
            Console.WriteLine("112233");
            return c.ToArray();
        }

        [HttpPost]
        public string Test([FromBody]Car c)
        {
            var context = new CarsContext();
            context.Cars.Add(c);
            context.SaveChanges();
            Console.WriteLine($"{c.Id} {c.Model} {c.Color} {c.Numberplate}");
            var a = "Success";
            return a;
        }
    }
}
