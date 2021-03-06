﻿using System;
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
        private static readonly List<FoodItem> s_contents = new List<FoodItem>
        {
            new FoodItem { Id = 1, Name = "expired cheese", ExpirationDate = new DateTime(2020, 6, 14) },
            new FoodItem { Id = 2, Name = "steak", ExpirationDate = new DateTime(2020, 7, 28) },
            new FoodItem { Id = 3, Name = "salmon", ExpirationDate = new DateTime(2020, 7, 28) }
        };

        // GET: api/fridge/items
        [HttpGet("items")]
        public IEnumerable<FoodItem> GetItems()
        {
            return s_contents;
        }

        // GET api/fridge/items/5
        [HttpGet("items/{id}", Name = "itembyid")]
        //[HttpGet("fooditems/{id}", Name = "fooditembyid")]
        public IActionResult GetItem(int id)
        {
            if (s_contents.FirstOrDefault(x => x.Id == id) is FoodItem item)
            {
                return Ok(item);
            }
            return NotFound();
        }

        // POST api/fridge/items
        [HttpPost("items")]
        public IActionResult PostItem([FromBody] FoodItem item)
        {
            if (s_contents.Any(x => x.Id == item.Id))
            {
                return Conflict();
            }
            s_contents.Add(item); // imagine e.g. the database generates its ID here

            // kind of like how tag helpers/HTML helpers allow you to avoid hardcoding URLs in all your views
            // these results hook into the route configuration too.

            // (if an exception is thrown after the response headers have been sent, it might be hard
            //  to interpret the result on the client)

            //return CreatedAtRoute("fooditembyid", new { id = item.Id }, item);
            return CreatedAtAction(
                actionName: nameof(GetItem),
                routeValues: new { id = item.Id },
                value: item);
        }

        // PUT api/fridge/items/5
        [HttpPut("items/{id}")]
        public void PutItem(int id, [FromBody] string value)
        {
        }

        // DELETE api/fridge/items/5
        [HttpDelete("items/{id}")]
        public void DeleteItem(int id)
        {
        }
    }
}
