using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using SimpleOrderApp.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SimpleOrderApp.Data
{
    class OrderRepository : IOrderRepository
    {
        private readonly SimpleOrderContext _context;

        public OrderRepository(SimpleOrderContext context)
        {
            _context = context;
        }

        public void Create(Order order)
        {
            OrderEntity entity = new OrderEntity
            {
                Id = order.Id,
                Quantity = order.Quantity,
                Location = new LocationEntity { Name = order.Location.Name, Stock = order.Location.Stock }
            };
            _context.Add(entity);
            _context.SaveChanges();

        }

        public IEnumerable<Order> GetAll()
        {
            var entities = _context.Orders.ToList();

            return entities.Select(e => new Order(e.Quantity, new Location(e.Location.Name, e.Location.Stock), e.Placed));
        }
    }
}
