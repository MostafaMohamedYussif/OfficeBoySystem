using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.OrderStatusRepository
{
    public class OrderStatusRepository : IOrderStatusRepository
    {
        private readonly ApplicationDbContext _context;

        public OrderStatusRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<OrderStatus> GetAll()
        {
            return _context.OrderStatuses.ToList();
        }

        public OrderStatus GetById(int id)
        {
            return _context.OrderStatuses.FirstOrDefault(os => os.Id == id);
        }

        public void Create(OrderStatus orderStatus)
        {
            _context.OrderStatuses.Add(orderStatus);
            _context.SaveChanges();
        }

        public void Update(OrderStatus orderStatus)
        {
            _context.OrderStatuses.Update(orderStatus); // Includes related entities if they are properly tracked
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var orderStatus = _context.OrderStatuses.Find(id);
            if (orderStatus != null)
            {
                _context.OrderStatuses.Remove(orderStatus);
                _context.SaveChanges();
            }
        }
    }

}
