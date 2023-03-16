using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
   public interface IContactService
    {
        List<Contact> GetContactList();
        List<Contact> GetListById(int id);
        Contact GetByID(int id);
        void ContactDelete(Contact contact);
        void ContactUpdate(Contact contact);
        void ContactAdd(Contact contact);
    }
}
