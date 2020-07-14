using KitchenService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace KitchenService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFridge" in both code and config file together.
    [ServiceContract]
    public interface IFridge
    {
        [OperationContract]
        ICollection<FoodItem> GetAllItems();

        //remove all the expired items and return them
        [OperationContract]
        ICollection<FoodItem> Clean();
    }
}
