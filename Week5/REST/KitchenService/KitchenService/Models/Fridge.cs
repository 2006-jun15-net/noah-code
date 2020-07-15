using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KitchenService.Models
{
    public class Fridge
    {
        public bool IsClean { get; set; }
        public List<FoodItem> Items { get; set; }
    }
}
