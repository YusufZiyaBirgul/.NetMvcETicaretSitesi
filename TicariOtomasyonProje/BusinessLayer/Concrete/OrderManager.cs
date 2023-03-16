using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        IOrderDal _repository;

        public OrderManager(IOrderDal repository)
        {
            _repository = repository;
        }

        public Order GetByID(int id)
        {
            return _repository.Get(x=>x.OrderId==id);
        }

        public List<Order> GetOrderList()
        {
            return _repository.List();
        }

        public List<Order> GetOrderListById(int id)
        {
          return  _repository.List(x=>x.OrderId==id);
        }

        public void OrderAdd(Order order)
        {
            _repository.Insert(order);
        }

        public void OrderDelete(Order order)
        {
             _repository.Delete(order);
        }

        public void OrderUpdate(Order order)
        {
            _repository.Update(order);
        }
    }
}
