using KitchenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KitchenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Fridge" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Fridge.svc or Fridge.svc.cs at the Solution Explorer and start debugging.
    public class Fridge : IFridge
    {
        private static List<FoodItem> _contents = new List<FoodItem>
        {
            new FoodItem{Id = 1, Name = "expired cheese", ExpirationDate = new DateTime(2020, 6, 14)},
            new FoodItem{Id = 2, Name = "steak", ExpirationDate = new DateTime(2020, 7, 20)}
        };
        public ICollection<FoodItem> Clean()
        {
            var removed = _contents.Where(i => i.ExpirationDate < DateTime.Now).ToHashSet();
            _contents = _contents.Except(removed).ToList();
            return removed;
        }

        public ICollection<FoodItem> GetAllItems()
        {
            
            return _contents.ToHashSet();
        }
    }
}
