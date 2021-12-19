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
        [HttpGet]
        public Car[] asd()
        {
            var context = new CarsContext();
            var c = context.Cars;
            return c.ToArray();
        }

        [HttpPost]
        public string Test([FromBody]Car c)
        {
            var context = new CarsContext();
            context.Cars.Add(c);
            context.SaveChanges();
            var a = "Success";
            return a;
        }

        [HttpPut("{id}")]
        public void UpdateCar(string id, Car car)
        {
            Console.WriteLine("Put request");
            var context = new CarsContext();
            var updatedCar = context.Cars.Find(id);
            updatedCar.Color = car.Color;
            updatedCar.Model = car.Model;
            updatedCar.Numberplate = car.Numberplate;
            context.SaveChanges();
            Console.WriteLine($"Updated:\n{updatedCar.Id} {updatedCar.Model} {updatedCar.Color} {updatedCar.Numberplate}");
        }

        [HttpDelete("{id}") ]
        public void DeleteCar(string id)
        {
            var context = new CarsContext();
            var delCar = context.Cars.Find(id);
            context.Cars.Remove(delCar);
            context.SaveChanges();  
            Console.WriteLine($"Deleted:\n{delCar.Id} {delCar.Model} {delCar.Color} {delCar.Numberplate}");
        }
    }
}
