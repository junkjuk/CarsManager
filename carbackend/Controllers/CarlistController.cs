using carbackend.Data;
using carbackend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace carbackend.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class CarlistController : ControllerBase
    {
        [HttpGet]
        public CarTemplate[] asd()
        {
            var context = new CarListContext();
            var c = context.Cars;
            return c.ToArray();
        }

        [HttpPost]
        public string Test([FromBody] CarTemplate c)
        {
            var context = new CarListContext();
            context.Cars.Add(c);
            context.SaveChanges();
            var a = "Success";
            return a;
        }

        [HttpPut("{id}")]
        public void UpdateCar(string id, CarTemplate car)
        {
            Console.WriteLine("Put request");
            var context = new CarListContext();
            var updatedCar = context.Cars.Find(id);
            updatedCar.Color = car.Color;
            updatedCar.Model = car.Model;
            updatedCar.Type = car.Type;
            context.SaveChanges();
            Console.WriteLine($"Updated:\n{updatedCar.Id} {updatedCar.Model} {updatedCar.Color} {updatedCar.Type}");
        }

        [HttpDelete("{id}") ]
        public void DeleteCar(string id)
        {
            var context = new CarListContext();
            var delCar = context.Cars.Find(id);
            context.Cars.Remove(delCar);
            context.SaveChanges();  
            Console.WriteLine($"Deleted:\n{delCar.Id} {delCar.Model} {delCar.Color} {delCar.Type}");
        }
    }
}
