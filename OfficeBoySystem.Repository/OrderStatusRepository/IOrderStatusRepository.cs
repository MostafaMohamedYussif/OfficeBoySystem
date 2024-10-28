using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.OrderStatusRepository
{
    public interface IOrderStatusRepository
    {
        IEnumerable<OrderStatus> GetAll();
        OrderStatus GetById(int id);
        void Create(OrderStatus orderStatus);
        void Update(OrderStatus orderStatus);
        void Delete(int id);
    }
}
