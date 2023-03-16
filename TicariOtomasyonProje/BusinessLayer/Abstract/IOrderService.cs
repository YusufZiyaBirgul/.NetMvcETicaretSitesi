using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IOrderService
    {

        List<Order> GetOrderList();
        List<Order> GetOrderListById(int id);
        Order GetByID(int id);
        void OrderDelete(Order order);
        void OrderUpdate(Order order);
        void OrderAdd(Order order);
    }
}
