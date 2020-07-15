using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KitchenService.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace KitchenService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FridgeController : ControllerBase
    {
        private static List<FoodItem> Items = new List<FoodItem>
        {
            new FoodItem{Id = 1, Name = "Milk", ExpirationDate = new DateTime(2020, 7, 30)},
            new FoodItem{Id = 2, Name = "Eggs", ExpirationDate = new DateTime(2020, 7, 30)},
            new FoodItem{Id = 3, Name = "expired cheese", ExpirationDate = new DateTime(2020, 6, 30)}
        };

        private static Fridge fridge = new Fridge { IsClean = false, Items = FridgeController.Items };
        [HttpPost("clean")]
        public IEnumerable<FoodItem> Clean()
        {
            var removed = Items.Where(i => i.ExpirationDate < DateTime.Now).ToHashSet();
            Items = Items.Except(removed).ToList();
            return removed;
        }

        // GET: api/fridge/items
        [HttpGet("items")]
        public IEnumerable<FoodItem> Get()
        {
            return Items;
        }

        // GET api/fridge/items/5
        [HttpGet("items/{id}")]
        public FoodItem Get(int id)
        {
            return Items.First(i => i.Id == id);
        }

        // POST api/fridge
        [HttpPost("items")]
        public FoodItem Post([FromBody] FoodItem item)
        {
            Items.Add(item);
            return item;
        }

        // PUT api/fridge/5
        [HttpPut("items/{id}")]
        public void Put(int id, [FromBody] FoodItem updatedItem)
        {
            var item = Items.First(i => i.Id == id);
            item.Id = updatedItem.Id;
            item.Name = updatedItem.Name;
            item.ExpirationDate = updatedItem.ExpirationDate;
        }

        // DELETE api/fridge/5
        [HttpDelete("items/{id}")]
        public void Delete(int id)
        {
            Items.Remove(Items.First(i => i.Id == id));
        }
    }
}
