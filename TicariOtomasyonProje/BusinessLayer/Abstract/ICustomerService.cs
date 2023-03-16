using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public  interface ICustomerService
    {
        List<Customer> GetCustomerList();
        List<Customer> GetListById(int id);
        void CustomerAdd(Customer customer);
        Customer GetByID(int id);
        void CustomerDelete(Customer customer);
        void CustomerUpdate(Customer customer);

    }
}
