using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.OrderDetailRepository
{
    public interface IOrderDetailRepository
    {
        IEnumerable<OrderDetail> GetAll();
        OrderDetail GetById(int id);
        void Create(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(int id);
    }
}
